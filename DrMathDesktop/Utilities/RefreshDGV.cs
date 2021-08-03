using DrMathDesktop.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrMathDesktop.Utilities
{
    public static class RefreshDgv
    {
        public static void Refresh(DataGridView dgv, EnumOperation operation, int row = 0)
        {
            if (dgv.SelectedRows.Count > 0)
            {

                switch (operation)
                {
                    case EnumOperation.Add:
                        dgv.CurrentCell = dgv[1, dgv.Rows.Count - 1];
                      
                        break;
                    case EnumOperation.Edit:            
                        
                        dgv.CurrentCell = dgv[1, row];

                        break;

                    case EnumOperation.Delete:

                        if (row == 0)
                        {
                            dgv.CurrentCell = dgv[1, 0];
                        }
                        else
                        {
                            dgv.CurrentCell = dgv[1, row - 1];
                        }
                        break;

                    default:
                        break;
                }
                dgv.FirstDisplayedScrollingRowIndex = dgv.SelectedRows[0].Index;
            }
        }
    }
}
