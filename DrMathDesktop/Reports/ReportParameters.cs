using DrMathDesktop.Database;
using DrMathDesktop.Dtos;
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

namespace DrMathDesktop.Reports
{
    public partial class ReportParameters : Form
    {
        private readonly AppDbContext context;

        public ReportParameters()
        {
            InitializeComponent();
            context = new AppDbContext();
            PopulateTrainerCombobox();
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

        private void btnShowInRange_Click(object sender, EventArgs e)
        {
            var parameters = new StudentsWithDegreeRangeParameters()
            {
                ResultFrom = Convert.ToInt32(txtResultFrom.Text),
                ResultTo = Convert.ToInt32(txtResultTo.Text),
                TrainerId = Convert.ToInt32(cmbTrainerName.SelectedValue)
            };
            new ReportViewerForm(Enums.EnumReportType.StudentsAndTrainerWithinDegreeRange, parameters).ShowDialog();
        }

        private void btnShowOutOfRange_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtResultFrom_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputEventsHandler.TexboxNumericOnly(sender, e);
        }

        private void txtResultTo_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputEventsHandler.TexboxNumericOnly(sender, e);
        }
    }
}
