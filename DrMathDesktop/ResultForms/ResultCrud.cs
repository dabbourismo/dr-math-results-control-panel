using DrMathDesktop.Database;
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

namespace DrMathDesktop.ResultForms
{
    public partial class ResultCrud : Form
    {
        private readonly AppDbContext context;
        public ResultCrud()
        {
            InitializeComponent();
            context = new AppDbContext();
            if (FormParameters.ResultId != 0)
            {
                AssignValues(FormParameters.ResultId);
                btnAddEdit.Text = FormText.Edit;
                txtSecret.Enabled = false;
            }
        }

        private void btnAddEdit_Click(object sender, EventArgs e)
        {
            var student = context.Students.Find(Convert.ToInt32(txtSecret.Text));
            if (student != null)
            {
                if (FormParameters.ResultId == 0)
                {
                    Insert(student);
                }
                else
                {
                    Update(FormParameters.ResultId);
                }

            }
            else
            {
                MessageBox.Show("هذا الطالب غير موجود");
            }
            Close();

        }

        private void Insert(Student student)
        {
            var result = new Result()
            {
                StudentId = student.Id,
                ResultValue = Convert.ToDecimal(txtResult.Text),
                Level = student.Level,
            };
            context.Results.Add(result);
            context.SaveChanges();
        }

        private void Update(int id)
        {
            var item = context.Results.Find(id);
            item.ResultValue = Convert.ToDecimal(txtResult.Text);

            context.SaveChanges();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void txtSecret_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int id = Convert.ToInt32(txtSecret.Text);
                var student = context.Students.Find(id);
                if (student != null)
                {
                    lblName.Text = student.NameArabic;
                    switch (student.Level)
                    {
                        case Enums.EnumStudentLevel.One:
                            lblLevel.Text = "الاول";
                            break;
                        case Enums.EnumStudentLevel.Two:
                            lblLevel.Text = "الثاني";
                            break;
                        case Enums.EnumStudentLevel.Three:
                            lblLevel.Text = "الثالث";
                            break;
                        case Enums.EnumStudentLevel.Four:
                            lblLevel.Text = "الرابع";
                            break;
                        case Enums.EnumStudentLevel.Five:
                            lblLevel.Text = "الخامس";
                            break;
                        case Enums.EnumStudentLevel.Six:
                            lblLevel.Text = "السادس";
                            break;
                        case Enums.EnumStudentLevel.Seven:
                            lblLevel.Text = "السابع";
                            break;
                        case Enums.EnumStudentLevel.Eight:
                            lblLevel.Text = "الثامن";
                            break;
                        default:
                            break;
                    }

                    switch (student.AgeRange)
                    {
                        case Enums.EnumAgeRange.Under6:
                            lblAgeRange.Text = "تحت 6 سنين";
                            break;
                        case Enums.EnumAgeRange.Under7:
                            lblAgeRange.Text = "تحت 7 سنين";
                            break;
                        case Enums.EnumAgeRange.Under8:
                            lblAgeRange.Text = "تحت 8 سنين";
                            break;
                        case Enums.EnumAgeRange.Under9:
                            lblAgeRange.Text = "تحت 9 سنين";
                            break;
                        case Enums.EnumAgeRange.Under10:
                            lblAgeRange.Text = "تحت 10 سنين";
                            break;
                        case Enums.EnumAgeRange.Over10:
                            lblAgeRange.Text = "فوق 10 سنين";
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("هذا الطالب غير موجود");
                }

            }
        }

        private void txtSecret_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputEventsHandler.TexboxNumericOnly(sender, e);
        }

        private void txtResult_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputEventsHandler.TexboxDecimalOnly(sender, e);
        }

        private void AssignValues(int id)
        {
            var item = context.Results.Find(id);
            if (item != null)
            {
                this.txtSecret.Text = item.StudentId.ToString();
                this.txtResult.Text = item.ResultValue.ToString();
                switch (item.Level)
                {
                    case Enums.EnumStudentLevel.One:
                        lblLevel.Text = "الاول";
                        break;
                    case Enums.EnumStudentLevel.Two:
                        lblLevel.Text = "الثاني";
                        break;
                    case Enums.EnumStudentLevel.Three:
                        lblLevel.Text = "الثالث";
                        break;
                    case Enums.EnumStudentLevel.Four:
                        lblLevel.Text = "الرابع";
                        break;
                    case Enums.EnumStudentLevel.Five:
                        lblLevel.Text = "الخامس";
                        break;
                    case Enums.EnumStudentLevel.Six:
                        lblLevel.Text = "السادس";
                        break;
                    case Enums.EnumStudentLevel.Seven:
                        lblLevel.Text = "السابع";
                        break;
                    case Enums.EnumStudentLevel.Eight:
                        lblLevel.Text = "الثامن";
                        break;
                    default:
                        break;
                }


                var student = context.Students.Find(item.StudentId);
                this.lblName.Text = student.NameArabic;
            }

        }

        private void txtResult_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAddEdit_Click(sender, e);

            }
        }
    }
}
