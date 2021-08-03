using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrMathDesktop.Utilities
{
    public static class Open<T> where T : Form
    {
        public static void Form(T frm)
        {
            if (Application.OpenForms.OfType<T>().Any())
            {
                return;
            }
            else
            {

                frm.Show();

            }
        }
    }
}
