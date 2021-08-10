using DrMathDesktop.Database;
using DrMathDesktop.Enums;
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
using DrMathDesktop.Reports.StudentsWithDegreeReport;
using DrMathDesktop.Reports.ReportDtos;

namespace DrMathDesktop.Reports
{
    public partial class ReportViewerForm : Form
    {
        private readonly AppDbContext context;
        public ReportViewerForm()
        {
            InitializeComponent();
        }

        public ReportViewerForm(EnumReportType reportType, object parameters)
        {
            InitializeComponent();
            context = new AppDbContext();
            switch (reportType)
            {
                case EnumReportType.StudentsAndTrainerWithinDegreeRange:
                    StudentsAndTrainerWithinDegreeRangeReport(parameters as StudentsWithDegreeRangeParameters);
                    break;
                case EnumReportType.StudentsAndTrainerOutOfDegreeRange:
                    break;
                default:
                    break;
            }
        }

        private void StudentsAndTrainerWithinDegreeRangeReport(StudentsWithDegreeRangeParameters parameters)
        {

            var items = context.Results
                .Where(x => x.ResultValue >= parameters.ResultFrom && x.ResultValue <= parameters.ResultTo)
                .AsQueryable();

            if (parameters.TrainerId != 0)
            {
                items = items.Where(x => x.Student.Trainer.Id == parameters.TrainerId);
            }


            var result = items
                .Include(x => x.Student).Include(x => x.Student.Trainer)
                .Select(x => new StudentsWithDegreeRangeDto
                {
                    TrainerName = x.Student.Trainer.Name,
                    StudentName = x.Student.NameArabic,
                    Degree = x.ResultValue
                })
            .OrderByDescending(x => x.Degree)
            .ToList();


            var dataSet = new ReportsDataSet();
            var dataTable = dataSet.Tables["InRange"];
            foreach (var dataRow in result)
            {
                DataRow row = dataTable.NewRow();
                row["Name"] = dataRow.TrainerName;
                row["NameArabic"] = dataRow.StudentName;
                row["ResultValue"] = dataRow.Degree;

                dataTable.Rows.Add(row);
            }

            var report = new rptStudentsWithDegreeRange();
            report.SetDataSource(dataTable);
            crystalReportViewer1.ReportSource = report;
        }
    }
}
