using DrMathDesktop.Database;
using DrMathDesktop.Models;
using DrMathDesktop.Reports;
using DrMathDesktop.ResultForms;
using DrMathDesktop.StudentForms;
using DrMathDesktop.TrainerForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrMathDesktop
{
    public partial class Home : Form
    {
        private readonly AppDbContext context;
        public Home()
        {
            InitializeComponent();
            context = new AppDbContext();


            panel3.Height = button1.Height;
            panel3.Top = button1.Top;
            this.Text = "المدربين";
            var trainersForm = new TrainerList();
            groupBox1.Controls.Clear();
            trainersForm.TopLevel = false;
            groupBox1.Controls.Add(trainersForm);
            trainersForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            trainersForm.Dock = DockStyle.Fill;
            trainersForm.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel3.Height = button1.Height;
            panel3.Top = button1.Top;
            this.Text = "المدربين";
            var trainersForm = new TrainerList();
            groupBox1.Controls.Clear();
            trainersForm.TopLevel = false;
            groupBox1.Controls.Add(trainersForm);
            trainersForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            trainersForm.Dock = DockStyle.Fill;
            trainersForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var trainers = context.Trainers.Count();
            if (trainers == 0)
            {
                MessageBox.Show("فضلا قم بادخال مدربين اولا");
            }
            else
            {
                panel3.Height = button2.Height;
                panel3.Top = button2.Top;
                this.Text = "الطلاب";
                var form = new StudentList();
                groupBox1.Controls.Clear();
                form.TopLevel = false;
                groupBox1.Controls.Add(form);
                form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                form.Dock = DockStyle.Fill;
                form.Show();
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var trainers = context.Students.Count();
            if (trainers == 0)
            {
                MessageBox.Show("فضلا قم بادخال طلاب اولا");
            }
            else
            {
                panel3.Height = button3.Height;
                panel3.Top = button3.Top;
                this.Text = "النتائج";
                var form = new ResultList();
                groupBox1.Controls.Clear();
                form.TopLevel = false;
                groupBox1.Controls.Add(form);
                form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                form.Dock = DockStyle.Fill;
                form.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var trainers = context.Students.Count();
            if (trainers == 0)
            {
                MessageBox.Show("فضلا قم بادخال طلاب اولا");
            }
            else
            {
                panel3.Height = button4.Height;
                panel3.Top = button4.Top;
                this.Text = "التقارير";
                var form = new ReportParameters();
                groupBox1.Controls.Clear();
                form.TopLevel = false;
                groupBox1.Controls.Add(form);
                form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                form.Dock = DockStyle.Fill;
                form.Show();
            }
        }
    }
}
