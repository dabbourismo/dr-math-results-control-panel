using DrMathDesktop.Database;
using DrMathDesktop.Enums;
using DrMathDesktop.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using DrMathDesktop.Dtos;

namespace DrMathDesktop.ResultForms
{
    public partial class ResultList : Form
    {
        private readonly AppDbContext context;
        private bool IsEditing;
        public ResultList()
        {
            InitializeComponent();
            context = new AppDbContext();
            PopulateTrainerCombobox();
            LoadData();
        }

        private void LoadData()
        {
            var items = context.Results
                  .Include(x => x.Student)
                  .OrderByDescending(x=>x.ResultValue)
                .AsNoTracking().ToList();
            dgv.DataSource = DataTablesFactory.ResultsDataTable(items);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            IsEditing = false;
            FormParameters.ResultId = 0;
            var form = new ResultCrud();
            form.FormClosed += ChildFormClosed;
            Open<ResultCrud>.Form(form);
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            IsEditing = true;
            if (dgv.Rows.Count > 0 && dgv.SelectedRows.Count > 0)
            {
                FormParameters.ResultId = Convert.ToInt32(dgv.SelectedRows[0].Cells[0].Value.ToString());
                var form = new ResultCrud();
                form.FormClosed += ChildFormClosed;
                Open<ResultCrud>.Form(form);
            }
        }

        private void ChildFormClosed(object sender, FormClosedEventArgs e)
        {
            LoadData();
            switch (IsEditing)
            {
                case true:
                    int currentRow = dgv.CurrentRow.Index;
                    RefreshDgv.Refresh(this.dgv, EnumOperation.Edit, currentRow);
                    break;
                case false:
                    RefreshDgv.Refresh(this.dgv, EnumOperation.Add);
                    break;
                default:
                    break;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialog =
             MessageBox.Show("هل انت متأكد من رغبتك في مسح درجة الطالب؟", "تنبية", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                int currentRow = dgv.CurrentRow.Index;
                var item = context.Results.Find(Convert.ToInt32(dgv.SelectedRows[0].Cells[0].Value.ToString()));
                context.Results.Remove(item);
                context.SaveChanges();
                LoadData();
                RefreshDgv.Refresh(this.dgv, EnumOperation.Delete, currentRow);
                DisableEditDeleteButtons();
            }
        }

        private void DisableEditDeleteButtons()
        {
            if (dgv.Rows.Count == 0)
            {
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
            }
            else
            {
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
            }
        }

        private void ResultList_Activated(object sender, EventArgs e)
        {
            DisableEditDeleteButtons();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var searchText = txtSearch.Text;

            var items = context.Results
             .OrderByDescending(x => x.ResultValue)
             .Include(x => x.Student)
             .AsQueryable();

            if (!string.IsNullOrEmpty(searchText))
            {
                items = items.Where(x => x.Student.NameArabic.Contains(searchText)
                                   || x.Student.NameEnglish.Contains(searchText)
                                   || x.Student.Id.ToString() == searchText);
            }


            if (Convert.ToInt32(cmbTrainerName.SelectedValue) > 0)
            {
                var trainerId = Convert.ToInt32(cmbTrainerName.SelectedValue);
                items = items.Where(x => x.Student.TrainerId == trainerId);
            }
            dgv.DataSource = DataTablesFactory.ResultsDataTable(items.AsNoTracking().ToList());
        }

        private void PopulateTrainerCombobox()
        {
            var dataSource = new List<ComboBoxClass>();

            dataSource.Add(new ComboBoxClass()
            {
                Name = "جميع المدربين",
                Value = 0,
            });

            var trainers = context.Trainers.AsNoTracking()
                .Select(x => new ComboBoxClass()
                {
                    Name = x.Name,
                    Value = x.Id
                }).ToList();

            dataSource.AddRange(trainers);


            cmbTrainerName.DataSource = dataSource;
            cmbTrainerName.DisplayMember = "Name";
            cmbTrainerName.ValueMember = "Value";
        }

       

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                LoadData();
                cmbTrainerName.SelectedIndex = 0;
            }
        }
    }
}
