namespace billInvoiceApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.btnPreview = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ItmDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogo = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.compName = new System.Windows.Forms.TextBox();
            this.compAdd = new System.Windows.Forms.TextBox();
            this.deliveryToAdd = new System.Windows.Forms.TextBox();
            this.billToAdd = new System.Windows.Forms.TextBox();
            this.lblInvoiceNo = new System.Windows.Forms.Label();
            this.lblCurrDate = new System.Windows.Forms.Label();
            this.yourRefNo = new System.Windows.Forms.TextBox();
            this.ourRefNo = new System.Windows.Forms.TextBox();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtFright = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.addInvoiceNo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(13, 590);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(100, 23);
            this.btnPreview.TabIndex = 0;
            this.btnPreview.Text = "Print Previwe";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItmDescription,
            this.Quantity,
            this.Rate,
            this.Amount});
            this.dataGridView1.Location = new System.Drawing.Point(12, 267);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.Size = new System.Drawing.Size(567, 264);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView1_CellValidating);
            // 
            // ItmDescription
            // 
            this.ItmDescription.DataPropertyName = "ItmDescription";
            this.ItmDescription.HeaderText = "Description";
            this.ItmDescription.Name = "ItmDescription";
            this.ItmDescription.Width = 301;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 87;
            // 
            // Rate
            // 
            this.Rate.DataPropertyName = "Rate";
            this.Rate.HeaderText = "Rate";
            this.Rate.Name = "Rate";
            this.Rate.Width = 87;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            this.Amount.Width = 88;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(410, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 83);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnLogo
            // 
            this.btnLogo.Location = new System.Drawing.Point(410, 12);
            this.btnLogo.Name = "btnLogo";
            this.btnLogo.Size = new System.Drawing.Size(77, 26);
            this.btnLogo.TabIndex = 3;
            this.btnLogo.Text = "Logo upload";
            this.btnLogo.UseVisualStyleBackColor = true;
            this.btnLogo.Click += new System.EventHandler(this.btnLogo_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // compName
            // 
            this.compName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compName.ForeColor = System.Drawing.Color.Maroon;
            this.compName.Location = new System.Drawing.Point(12, 12);
            this.compName.Multiline = true;
            this.compName.Name = "compName";
            this.compName.Size = new System.Drawing.Size(392, 37);
            this.compName.TabIndex = 4;
            this.compName.Text = "Company Name";
            // 
            // compAdd
            // 
            this.compAdd.Location = new System.Drawing.Point(13, 51);
            this.compAdd.Multiline = true;
            this.compAdd.Name = "compAdd";
            this.compAdd.Size = new System.Drawing.Size(391, 68);
            this.compAdd.TabIndex = 5;
            this.compAdd.Text = "Street No 1245 near kalina post Metor silk Mills\r\nPo box 421500 Tel:- 215003654 E" +
                "xt 425";
            // 
            // deliveryToAdd
            // 
            this.deliveryToAdd.Location = new System.Drawing.Point(213, 145);
            this.deliveryToAdd.Multiline = true;
            this.deliveryToAdd.Name = "deliveryToAdd";
            this.deliveryToAdd.Size = new System.Drawing.Size(182, 93);
            this.deliveryToAdd.TabIndex = 6;
            this.deliveryToAdd.Text = "Street No 1234 karunar vihar\r\nnear santacruze bus depot\r\npo box 554466 tel:- 4215" +
                "563\r\nemail Id:- asdfasdf@asdf.com";
            // 
            // billToAdd
            // 
            this.billToAdd.Location = new System.Drawing.Point(12, 145);
            this.billToAdd.Multiline = true;
            this.billToAdd.Name = "billToAdd";
            this.billToAdd.Size = new System.Drawing.Size(195, 93);
            this.billToAdd.TabIndex = 7;
            this.billToAdd.Text = "Street No 1234 karunar vihar\r\nnear santacruze bus depot\r\npo box 554466 tel:- 4215" +
                "563\r\nemail Id:- asdfasdf@asdf.com";
            // 
            // lblInvoiceNo
            // 
            this.lblInvoiceNo.AutoSize = true;
            this.lblInvoiceNo.Location = new System.Drawing.Point(514, 135);
            this.lblInvoiceNo.MaximumSize = new System.Drawing.Size(45, 0);
            this.lblInvoiceNo.MinimumSize = new System.Drawing.Size(45, 0);
            this.lblInvoiceNo.Name = "lblInvoiceNo";
            this.lblInvoiceNo.Size = new System.Drawing.Size(45, 13);
            this.lblInvoiceNo.TabIndex = 8;
            this.lblInvoiceNo.Text = "001";
            // 
            // lblCurrDate
            // 
            this.lblCurrDate.AutoSize = true;
            this.lblCurrDate.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCurrDate.Location = new System.Drawing.Point(442, 148);
            this.lblCurrDate.MaximumSize = new System.Drawing.Size(100, 0);
            this.lblCurrDate.MinimumSize = new System.Drawing.Size(100, 0);
            this.lblCurrDate.Name = "lblCurrDate";
            this.lblCurrDate.Size = new System.Drawing.Size(100, 13);
            this.lblCurrDate.TabIndex = 9;
            this.lblCurrDate.Text = "10/12/2015";
            // 
            // yourRefNo
            // 
            this.yourRefNo.Location = new System.Drawing.Point(475, 162);
            this.yourRefNo.Name = "yourRefNo";
            this.yourRefNo.Size = new System.Drawing.Size(100, 20);
            this.yourRefNo.TabIndex = 10;
            // 
            // ourRefNo
            // 
            this.ourRefNo.Location = new System.Drawing.Point(475, 176);
            this.ourRefNo.Name = "ourRefNo";
            this.ourRefNo.Size = new System.Drawing.Size(100, 20);
            this.ourRefNo.TabIndex = 11;
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubTotal.Location = new System.Drawing.Point(489, 534);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.ReadOnly = true;
            this.txtSubTotal.Size = new System.Drawing.Size(91, 21);
            this.txtSubTotal.TabIndex = 12;
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(489, 553);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(93, 20);
            this.txtTax.TabIndex = 13;
            this.txtTax.TextChanged += new System.EventHandler(this.txtTax_TextChanged);
            this.txtTax.Validating += new System.ComponentModel.CancelEventHandler(this.txtTax_Validating);
            // 
            // txtFright
            // 
            this.txtFright.Location = new System.Drawing.Point(488, 570);
            this.txtFright.Margin = new System.Windows.Forms.Padding(0);
            this.txtFright.Name = "txtFright";
            this.txtFright.Size = new System.Drawing.Size(93, 20);
            this.txtFright.TabIndex = 14;
            this.txtFright.TextChanged += new System.EventHandler(this.txtFright_TextChanged);
            this.txtFright.Validating += new System.ComponentModel.CancelEventHandler(this.txtFright_Validating);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(487, 584);
            this.lblTotal.MaximumSize = new System.Drawing.Size(90, 0);
            this.lblTotal.MinimumSize = new System.Drawing.Size(90, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(90, 15);
            this.lblTotal.TabIndex = 15;
            this.lblTotal.Text = "0.00";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(119, 590);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(200, 590);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save Bill";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // addInvoiceNo
            // 
            this.addInvoiceNo.Location = new System.Drawing.Point(564, 133);
            this.addInvoiceNo.Name = "addInvoiceNo";
            this.addInvoiceNo.Size = new System.Drawing.Size(15, 23);
            this.addInvoiceNo.TabIndex = 18;
            this.addInvoiceNo.Text = "+";
            this.addInvoiceNo.UseVisualStyleBackColor = true;
            this.addInvoiceNo.Visible = false;
            this.addInvoiceNo.Click += new System.EventHandler(this.addInvoiceNo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(591, 750);
            this.Controls.Add(this.addInvoiceNo);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtFright);
            this.Controls.Add(this.txtTax);
            this.Controls.Add(this.txtSubTotal);
            this.Controls.Add(this.ourRefNo);
            this.Controls.Add(this.yourRefNo);
            this.Controls.Add(this.lblCurrDate);
            this.Controls.Add(this.lblInvoiceNo);
            this.Controls.Add(this.billToAdd);
            this.Controls.Add(this.deliveryToAdd);
            this.Controls.Add(this.compAdd);
            this.Controls.Add(this.compName);
            this.Controls.Add(this.btnLogo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnPreview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItmDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLogo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox compName;
        private System.Windows.Forms.TextBox compAdd;
        private System.Windows.Forms.TextBox deliveryToAdd;
        private System.Windows.Forms.TextBox billToAdd;
        private System.Windows.Forms.Label lblInvoiceNo;
        private System.Windows.Forms.Label lblCurrDate;
        private System.Windows.Forms.TextBox yourRefNo;
        private System.Windows.Forms.TextBox ourRefNo;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.TextBox txtFright;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button addInvoiceNo;
    }
}

