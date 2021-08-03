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

namespace DrMathDesktop.TrainerForms
{
    public partial class TrainerCrud : Form
    {
        private readonly AppDbContext context;
        public TrainerCrud()
        {
            InitializeComponent();
            context = new AppDbContext();
            if (FormParameters.TrainerId != 0)
            {
                AssignValues(FormParameters.TrainerId);
                btnAddEdit.Text = FormText.Edit;
            }
        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddEdit_Click(object sender, EventArgs e)
        {
            if (FormParameters.TrainerId == 0)
            {
                Insert();
            }
            else
            {
                Update(FormParameters.TrainerId);
            }

            Close();
        }

        private void Insert()
        {
            var item = new Trainer()
            {
                Name = txtName.Text,
            };
            context.Trainers.Add(item);
            context.SaveChanges();
        }

        private void Update(int id)
        {
            var item = context.Trainers.Find(id);
            item.Name = txtName.Text;

            context.Entry(item).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
        }


        private void AssignValues(int id)
        {
            var item = context.Trainers.Find(id);
            this.txtName.Text = item.Name;
        }
    }
}
