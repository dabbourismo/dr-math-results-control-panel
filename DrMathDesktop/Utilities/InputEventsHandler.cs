using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrMathDesktop.Utilities
{
    public static class InputEventsHandler
    {
        /// <summary>
        /// Allows only int values to standard textbox, only works with KeyPress Event
        /// </summary>
        /// <param name="sender">KeyPressEventArgs</param>
        /// <param name="e">object</param>
        public static void TexboxNumericOnly(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }


        }

        /// <summary>
        /// Allows only decimal values to standard textbox, only works with KeyPress Event
        /// </summary>
        /// <param name="sender">KeyPressEventArgs</param>
        /// <param name="e">object</param>
        public static void TexboxDecimalOnly(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
