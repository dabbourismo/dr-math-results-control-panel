using DrMathDesktop.Database;
using DrMathDesktop.Dtos;
using DrMathDesktop.Enums;
using DrMathDesktop.Models;
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

namespace DrMathDesktop.StudentForms
{
    public partial class StudentCrud : Form
    {
        private readonly AppDbContext context;
        public StudentCrud()
        {
            InitializeComponent();
            context = new AppDbContext();

            PopulateTrainerCombobox();
            PopulateExamLanguageCombobox();
            PopulateLevelCombobox();
            PopulateAgeRangeCombobox();

            if (FormParameters.StudentId != 0)
            {
                AssignValues(FormParameters.StudentId);
                btnAddEdit.Text = FormText.Edit;
            }
        }

        private void btnAddEdit_Click(object sender, EventArgs e)
        {
            if (FormParameters.StudentId == 0)
            {
                Insert();
            }
            else
            {
                Update(FormParameters.StudentId);
            }

            Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private  void Insert()
        {
            var id = Convert.ToInt32(cmbTrainerName.SelectedValue);
            var trainer =  context.Trainers.AsNoTracking().FirstOrDefault(x=>x.Id == id);
            if (trainer == null)
            {
                MessageBox.Show("هذا المدرب غير موجود ، تاكد من اختيار المدرب بشكل صحيح من القائمة");
                return;
            }

            var item = new Student()
            {
                NameArabic = txtNameArabic.Text,
                NameEnglish = txtNameEnglish.Text,
                BirthDate = dtpBirthDate.Value,
                ExamLanguage = (EnumExamLanguage)cmbExamLanguage.SelectedValue,
                Level = (EnumStudentLevel)cmbLevel.SelectedValue,
                TrainerId = Convert.ToInt32(cmbTrainerName.SelectedValue),
                Governate = txtGovernate.Text
            };
            context.Students.Add(item);
            context.SaveChanges();
        }

        private void Update(int id)
        {
            var item = context.Students.Find(id);
            item.NameArabic = txtNameArabic.Text;
            item.NameEnglish = txtNameEnglish.Text;
            item.BirthDate = dtpBirthDate.Value;
            item.ExamLanguage = (EnumExamLanguage)cmbExamLanguage.SelectedValue;
            item.Level = (EnumStudentLevel)cmbLevel.SelectedValue;
            item.TrainerId = Convert.ToInt32(cmbTrainerName.SelectedValue);
            item.Governate = txtGovernate.Text;

            context.SaveChanges();
        }

        private void PopulateTrainerCombobox()
        {
            var dataSource = context.Trainers.AsNoTracking()
                .Select(x => new ComboBoxClass()
                {
                    Name = x.Name,
                    Value = x.Id
                }).ToList();

            cmbTrainerName.DataSource = dataSource;
            cmbTrainerName.DisplayMember = "Name";
            cmbTrainerName.ValueMember = "Value";
        }

        private void PopulateExamLanguageCombobox()
        {
            cmbExamLanguage.DataSource = Enum.GetValues(typeof(EnumExamLanguage));
        }
        private void PopulateLevelCombobox()
        {
            cmbLevel.DataSource = Enum.GetValues(typeof(EnumStudentLevel));
        }
        private void PopulateAgeRangeCombobox()
        {
            cmbAgeRange.DisplayMember = CombBoxFactory.Description;
            cmbAgeRange.ValueMember = CombBoxFactory.Value;
            cmbAgeRange.DataSource = CombBoxFactory.AgeRangeCombBox();
        }

        private void AssignValues(int id)
        {
            var item = context.Students.Find(id);
            this.txtNameArabic.Text = item.NameArabic;
            this.txtNameEnglish.Text = item.NameEnglish;
            this.dtpBirthDate.Value = item.BirthDate;
            this.cmbExamLanguage.SelectedIndex = (int)item.ExamLanguage;
            this.cmbLevel.SelectedIndex = (int)item.Level;
            this.cmbTrainerName.SelectedValue = item.TrainerId;
            this.txtGovernate.Text = item.Governate;
        }

        private void DatesChanging(object sender, EventArgs e)
        {
            if (dtpContestDate.Value < dtpBirthDate.Value)
            {
                MessageBox.Show("تاريخ البطولة يجب ان يكون اكبر من تاريخ الميلاد");
            }
            else
            {
                var birthdate = dtpBirthDate.Value;
                var contestDate = dtpContestDate.Value;

                var age = contestDate.Year - birthdate.Year;
                if (birthdate.Date > contestDate.AddYears(-age)) age--;

                if (age < 6)
                {
                    cmbAgeRange.SelectedIndex = 0;
                }
                else if (age >= 6 && age < 7)
                {
                    cmbAgeRange.SelectedIndex = 1;
                }
                else if (age >= 7 && age < 8)
                {
                    cmbAgeRange.SelectedIndex = 2;
                }
                else if (age >= 8 && age < 9)
                {
                    cmbAgeRange.SelectedIndex = 3;
                }
                else if (age >= 9 && age < 10)
                {
                    cmbAgeRange.SelectedIndex = 4;
                }
                else
                {
                    cmbAgeRange.SelectedIndex = 5;
                }

            }



        }
    }
}
