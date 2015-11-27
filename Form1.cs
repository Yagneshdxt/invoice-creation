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
    public partial class Form1 : Form
    {

        private string ThePictureFileName = "";

        public Form1()
        {
            //this.BackgroundImage = Properties.Resources.billImage;
            InitializeComponent();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            PrintPreviewInvoice();
        }

        private void PrintPreviewInvoice()
        {
            try
            {
                PrintPreviewDialog printPreviewDialog1 = new PrintPreviewDialog();
                printPreviewDialog1.Document = this.printDocument1;
                printPreviewDialog1.FormBorderStyle = FormBorderStyle.Fixed3D;
                printPreviewDialog1.SetBounds(20, 20, this.Width, this.Height);
                printPreviewDialog1.ShowDialog();
            }
            catch (Exception exp)
            {
                System.Console.WriteLine(exp.Message.ToString());
            }

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            this.Focus();
            DrawAll(e.Graphics);
        }

        //scaling function
        RectangleF GetScaledRectangle(float x, float y, RectangleF r)
        {
            RectangleF result = new RectangleF(r.X * x, r.Y * y, r.Width * x, r.Height * y);
            return result;
        }

        private void DrawAll(Graphics g)
        {
            //			RectangleF srcRect = new Rectangle(0, 0, this.LargerImage.Width, 
            //				LargerImage.Height);

            RectangleF srcRect = new Rectangle(0, 0, this.BackgroundImage.Width,
                BackgroundImage.Height);


            int nWidth = printDocument1.PrinterSettings.DefaultPageSettings.PaperSize.Width;
            int nHeight = printDocument1.PrinterSettings.DefaultPageSettings.PaperSize.Height;
            RectangleF destRect = new Rectangle(0, 0, nWidth, nHeight);

            g.DrawImage(this.BackgroundImage, destRect, srcRect, GraphicsUnit.Pixel);
            //			g.DrawImage(this.LargerImage, destRect, srcRect, GraphicsUnit.Pixel);

            float scalex = destRect.Width / this.BackgroundImage.Width;
            float scaley = destRect.Height / this.BackgroundImage.Height;

            Pen aPen = new Pen(Brushes.Black, 1);

            for (int i = 0; i < this.Controls.Count; i++)
            {
                // draw logo
                if (Controls[i].GetType() == this.pictureBox1.GetType())
                {
                    if (pictureBox1.Image != null)
                    {
                        GraphicsUnit gu = GraphicsUnit.Pixel;
                        RectangleF scaledRectangle = GetScaledRectangle(scalex, scaley, pictureBox1.Bounds);
                        Image myImage = (Image)pictureBox1.Image.Clone();
                        g.DrawImage(myImage, scaledRectangle, pictureBox1.Image.GetBounds(ref gu), GraphicsUnit.Pixel);
                    }
                }

                // print CompanyName textbox
                if (Controls[i].Name == this.compName.Name)
                {
                    TextBox theText = (TextBox)Controls[i];
                    g.DrawString(theText.Text, theText.Font, Brushes.Black, theText.Bounds.Left * scalex, theText.Bounds.Top * scaley, new StringFormat());
                }

                // print CompanyName Address
                if (Controls[i].Name == this.compAdd.Name)
                {
                    TextBox theText = (TextBox)Controls[i];
                    g.DrawString(theText.Text, theText.Font, Brushes.Black, theText.Bounds.Left * scalex, theText.Bounds.Top * scaley, new StringFormat());
                }

                // print Bill To  Address
                if (Controls[i].Name == this.billToAdd.Name)
                {
                    TextBox theText = (TextBox)Controls[i];
                    g.DrawString(theText.Text, theText.Font, Brushes.Black, theText.Bounds.Left * scalex, theText.Bounds.Top * scaley, new StringFormat());
                }

                // print Delivery To  Address
                if (Controls[i].Name == this.deliveryToAdd.Name)
                {
                    TextBox theText = (TextBox)Controls[i];
                    g.DrawString(theText.Text, theText.Font, Brushes.Black, theText.Bounds.Left * scalex, theText.Bounds.Top * scaley, new StringFormat());
                }

                // print Invoice Number
                if (Controls[i].Name == this.lblInvoiceNo.Name)
                {
                    Label theText = (Label)Controls[i];
                    g.DrawString(theText.Text, theText.Font, Brushes.Black, theText.Bounds.Left * scalex, theText.Bounds.Top * scaley, new StringFormat());
                }

                // print Invoice Date
                if (Controls[i].Name == this.lblCurrDate.Name)
                {
                    Label theText = (Label)Controls[i];
                    g.DrawString(theText.Text, theText.Font, Brushes.Black, theText.Bounds.Left * scalex, theText.Bounds.Top * scaley, new StringFormat());
                }

                // print Your Ref no
                if (Controls[i].Name == this.yourRefNo.Name)
                {
                    TextBox theText = (TextBox)Controls[i];
                    g.DrawString(theText.Text, theText.Font, Brushes.Black, theText.Bounds.Left * scalex, theText.Bounds.Top * scaley, new StringFormat());
                }

                // print Our Ref No
                if (Controls[i].Name == this.ourRefNo.Name)
                {
                    TextBox theText = (TextBox)Controls[i];
                    g.DrawString(theText.Text, theText.Font, Brushes.Black, theText.Bounds.Left * scalex, theText.Bounds.Top * scaley, new StringFormat());
                }


                Rectangle GridCellRtng;
                if (Controls[i].GetType() == this.dataGridView1.GetType())
                {
                    for (int row = 0; row < dataGridView1.Rows.Count; row++)
                    {
                        int nextColumnPosition = dataGridView1.Bounds.X;
                        for (int col = 0; col < dataGridView1.ColumnCount; col++)
                        {
                            GridCellRtng = dataGridView1.GetCellDisplayRectangle(col, row, false);

                            g.DrawString(dataGridView1.Rows[row].Cells[col].Value.ToString(), dataGridView1.Font, Brushes.Black,
                                (nextColumnPosition + 13) * scalex,
                                (dataGridView1.GetRowDisplayRectangle(row, false).Location.Y + dataGridView1.Bounds.Y) * scaley,
                                new StringFormat());
                            nextColumnPosition += GridCellRtng.Width;

                        }
                    }
                }


                // print sub Total
                if (Controls[i].Name == this.txtSubTotal.Name)
                {
                    TextBox theText = (TextBox)Controls[i];
                    g.DrawString(theText.Text, theText.Font, Brushes.Black, theText.Bounds.Left * scalex, theText.Bounds.Top * scaley, new StringFormat());
                }


                // print tax 
                if (Controls[i].Name == this.txtTax.Name)
                {
                    TextBox theText = (TextBox)Controls[i];
                    g.DrawString(theText.Text, theText.Font, Brushes.Black, theText.Bounds.Left * scalex, theText.Bounds.Top * scaley, new StringFormat());
                }

                // print Freight
                if (Controls[i].Name == this.txtFright.Name)
                {
                    TextBox theText = (TextBox)Controls[i];
                    g.DrawString(theText.Text, theText.Font, Brushes.Black, theText.Bounds.Left * scalex, theText.Bounds.Top * scaley, new StringFormat());
                }

                // print Total
                if (Controls[i].Name == this.lblTotal.Name)
                {
                    Label theText = (Label)Controls[i];
                    g.DrawString(theText.Text, theText.Font, Brushes.Black, theText.Bounds.Left * scalex, theText.Bounds.Top * scaley, new StringFormat());
                }

                /*
                // handle List View Control
                if (Controls[i].GetType() == this.listView1.GetType())
                {
                    for (int row = 0; row < listView1.Items.Count; row++)
                    {
                        int nextColumnPosition = listView1.Bounds.X;
                        for (int col = 0; col < listView1.Items[row].SubItems.Count; col++)
                        {
                            g.DrawString(listView1.Items[row].SubItems[col].Text, listView1.Items[row].Font, Brushes.Black, (nextColumnPosition + 3) * scalex, (listView1.Items[row].Bounds.Y + listView1.Bounds.Y) * scaley, new StringFormat());
                            nextColumnPosition += listView1.Columns[col].Width;

                        }
                    }
                }*/
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BindControls();
        }

        private void BindControls()
        {
            DataAccess dataAcc = new DataAccess();
            dataGridView1.DataSource = dataAcc.getBillDetailScheme();
            dataGridView1.FirstDisplayedCell.Selected = false;

            this.lblCurrDate.Text = DateTime.Now.Day.ToString() + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString();

            this.lblInvoiceNo.Text = dataAcc.getInvoiceNumber();
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
                    row.Cells["Amount"].Value = String.Format("{0:0.00}", Convert.ToDouble(QuantityStr) * Convert.ToDouble(RateStr));

                    setTotal();
                }

            }
        }

        private void setTotal()
        {
            Double SubTotal = 0, testOut, tax = 0, fright = 0;
            String RowAmt = "";
            this.lblTotal.Text = "0.00";
            this.txtSubTotal.Text = "0.00";
            foreach (DataGridViewRow dgR in dataGridView1.Rows)
            {
                RowAmt = Convert.ToString(dgR.Cells["Amount"].Value);
                if (!String.IsNullOrWhiteSpace(RowAmt) && Double.TryParse(RowAmt, out testOut))
                {
                    SubTotal = SubTotal + testOut;
                }
            }
            this.txtSubTotal.Text = String.Format("{0:0.00}", SubTotal);
            testOut = 0;
            if (!String.IsNullOrWhiteSpace(this.txtTax.Text) && Double.TryParse(this.txtTax.Text, out testOut))
            {
                tax = (SubTotal * (testOut / 100));
            }
            testOut = 0;
            if (!String.IsNullOrWhiteSpace(this.txtFright.Text) && Double.TryParse(this.txtFright.Text, out testOut))
            {
                fright = (SubTotal * (testOut / 100));
            }
            this.lblTotal.Text = String.Format("{0:0.00}", tax + fright + SubTotal);
        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            //Allow Numeric values only
            if (e.ColumnIndex == 1 || e.ColumnIndex == 2)
            {
                Double outTest;
                if (!Double.TryParse(Convert.ToString(e.FormattedValue), out outTest) && !String.IsNullOrWhiteSpace(Convert.ToString(e.FormattedValue)))
                {
                    e.Cancel = true;
                    MessageBox.Show("Please enter only numeric values");
                }
            }
        }

        private void btnLogo_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                ThePictureFileName = openFileDialog1.FileName;
            }

        }

        private void txtTax_TextChanged(object sender, EventArgs e)
        {
            setTotal();
        }

        private void txtFright_TextChanged(object sender, EventArgs e)
        {
            setTotal();
        }

        private void txtTax_Validating(object sender, CancelEventArgs e)
        {
            Double outTest;
            if (!Double.TryParse(Convert.ToString(this.txtTax.Text), out outTest) && !String.IsNullOrWhiteSpace(Convert.ToString(this.txtTax.Text)))
            {
                e.Cancel = true;
                MessageBox.Show("Entered Tax is not numeric");
            }

        }

        private void txtFright_Validating(object sender, CancelEventArgs e)
        {
            Double outTest;
            if (!Double.TryParse(Convert.ToString(this.txtFright.Text), out outTest) && !String.IsNullOrWhiteSpace(Convert.ToString(this.txtFright.Text)))
            {
                e.Cancel = true;
                MessageBox.Show("Entered Fright Is not numeric");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            BindControls();
            this.lblTotal.Text = "0.00";
            this.txtSubTotal.Text = "0.00";
            this.billToAdd.Text = "";
            this.deliveryToAdd.Text = "";
            this.yourRefNo.Text = "";
            this.ourRefNo.Text = "";
            this.txtTax.Text = "";
            this.txtFright.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(this.billToAdd.Text) && !String.IsNullOrWhiteSpace(this.deliveryToAdd.Text) && !String.IsNullOrWhiteSpace(this.txtTax.Text) && !String.IsNullOrWhiteSpace(this.txtFright.Text))
            {

                BillData billData = new BillData();
                billData.BillToAdd = this.billToAdd.Text;
                billData.DeliveryToAdd = this.deliveryToAdd.Text;
                billData.InvoiceNo = Convert.ToInt64(this.lblInvoiceNo.Text);
                billData.yourRefNo = this.yourRefNo.Text;
                billData.ourRefNo = this.ourRefNo.Text;
                billData.tax = Convert.ToDouble(this.txtTax.Text);
                billData.freight = Convert.ToDouble(this.txtFright.Text);

                BillItems billItms;
                List<BillItems> lstBillItms = new List<BillItems>();
                foreach (DataGridViewRow dgR in dataGridView1.Rows)
                {
                    if (!String.IsNullOrWhiteSpace(Convert.ToString(dgR.Cells["ItmDescription"].Value)) && !String.IsNullOrWhiteSpace(Convert.ToString(dgR.Cells["Quantity"].Value)) && !String.IsNullOrWhiteSpace(Convert.ToString(dgR.Cells["Quantity"].Value)))
                    {
                        billItms = new BillItems();
                        billItms.ItmDescription = Convert.ToString(dgR.Cells["ItmDescription"].Value);
                        billItms.Quantity = Convert.ToDouble(dgR.Cells["Quantity"].Value);
                        billItms.Rate = Convert.ToDouble(dgR.Cells["Quantity"].Value);
                        lstBillItms.Add(billItms);
                    }
                }
                billData.billItms = lstBillItms;

                DataAccess dataAcc = new DataAccess();
                if (dataAcc.SaveData(billData))
                {
                    this.lblInvoiceNo.Text = dataAcc.getInvoiceNumber();
                    MessageBox.Show("Bill Saved Successfuly");
                }
            }
        }

        private void addInvoiceNo_Click(object sender, EventArgs e)
        {

        }
    }
}
