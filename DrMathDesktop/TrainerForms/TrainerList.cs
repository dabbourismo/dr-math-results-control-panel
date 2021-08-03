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

namespace DrMathDesktop.TrainerForms
{
    public partial class TrainerList : Form
    {
        private readonly AppDbContext context;
        private bool IsEditing;
        public TrainerList()
        {
            InitializeComponent();
            context = new AppDbContext();
            LoadData();
        }

        private void LoadData()
        {
            var items = context.Trainers.AsNoTracking().ToList();
            dgv.DataSource = DataTablesFactory.TrainersDataTable(items);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            IsEditing = false;
            FormParameters.TrainerId = 0;
            var form = new TrainerCrud();
            form.FormClosed += ChildFormClosed;
            Open<TrainerCrud>.Form(form);
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            IsEditing = true;
            if (dgv.Rows.Count > 0 && dgv.SelectedRows.Count > 0)
            {
                FormParameters.TrainerId = Convert.ToInt32(dgv.SelectedRows[0].Cells[0].Value.ToString());
                var form = new TrainerCrud();
                form.FormClosed += ChildFormClosed;
                Open<TrainerCrud>.Form(form);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialog =
                MessageBox.Show("هل انت متأكد من رغبتك في مسح المدرب؟", "تنبية", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                int currentRow = dgv.CurrentRow.Index;
                var item = context.Trainers.Find(Convert.ToInt32(dgv.SelectedRows[0].Cells[0].Value.ToString()));
                context.Trainers.Remove(item);
                context.SaveChanges();
                LoadData();
                RefreshDgv.Refresh(this.dgv, EnumOperation.Delete, currentRow);
                DisableEditDeleteButtons();
            }


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var searchText = txtSearch.Text;
            var items = context.Trainers.AsNoTracking()
                .Where(x => x.Name.Contains(searchText) || x.Id.ToString() == searchText).ToList();
            dgv.DataSource = DataTablesFactory.TrainersDataTable(items);
        }

        private void TrainerList_Activated(object sender, EventArgs e)
        {
            DisableEditDeleteButtons();
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                LoadData();
            }
        }
    }
}
