using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace billInvoiceApp
{
    public partial class testFrm : Form
    {
        public testFrm()
        {
            InitializeComponent();
            BindControls();
        }

        private void BindControls()
        {
            DataAccess dataAcc = new DataAccess();
            
            dataGridView1.DataSource = dataAcc.getBillDetailScheme();
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                String QuantityStr, RateStr;
                QuantityStr = Convert.ToString(row.Cells["Quantity"].Value);
                RateStr = Convert.ToString(row.Cells["Rate"].Value);
                Double outValue;
                if (!String.IsNullOrWhiteSpace(QuantityStr) && !String.IsNullOrWhiteSpace(RateStr) && Double.TryParse(QuantityStr, out outValue) && Double.TryParse(RateStr, out outValue))
                {
                    row.Cells["Quantity"].Value = String.Format("{0:0.00}", Convert.ToDouble(QuantityStr));
                    row.Cells["Rate"].Value = String.Format("{0:0.00}", Convert.ToDouble(RateStr));
                    row.Cells["Amount"].Value = String.Format("{0:0.00}", Convert.ToDouble(QuantityStr) + Convert.ToDouble(RateStr));
                }

            }
        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            //Allow Numeric values only
            if (e.ColumnIndex == 1 || e.ColumnIndex == 2) {
                Double outTest;
                if (!Double.TryParse(Convert.ToString(e.FormattedValue), out outTest) && !String.IsNullOrWhiteSpace(Convert.ToString(e.FormattedValue)))
                {
                    e.Cancel = true;
                    MessageBox.Show("Please enter only numeric values");
                }
            }
        }

        /*private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 1 || e.ColumnIndex == 2) {
                e.Value = String.Format("{0:0.00}", Convert.ToString(e.Value));
            }
        }*/
    }
}
