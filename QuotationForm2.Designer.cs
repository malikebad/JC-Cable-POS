namespace Shop_Management__System
{
    partial class QuotationForm2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuotationForm2));
            this.dgvQuotationItems = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ITEM_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ITEM_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RUP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPrintQuotation = new Guna.UI2.WinForms.Guna2Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.txtQuotationID = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtQuotationDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.comboCustomerName = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtTotalAmount = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuotationItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvQuotationItems
            // 
            this.dgvQuotationItems.AllowUserToOrderColumns = true;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.dgvQuotationItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvQuotationItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvQuotationItems.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.dgvQuotationItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQuotationItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvQuotationItems.ColumnHeadersHeight = 24;
            this.dgvQuotationItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ITEM_ID,
            this.ITEM_Name,
            this.RUP,
            this.Quantity,
            this.tPrice});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvQuotationItems.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvQuotationItems.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.dgvQuotationItems.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvQuotationItems.Location = new System.Drawing.Point(9, 37);
            this.dgvQuotationItems.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvQuotationItems.Name = "dgvQuotationItems";
            this.dgvQuotationItems.RowHeadersVisible = false;
            this.dgvQuotationItems.RowHeadersWidth = 51;
            this.dgvQuotationItems.RowTemplate.Height = 24;
            this.dgvQuotationItems.Size = new System.Drawing.Size(665, 240);
            this.dgvQuotationItems.TabIndex = 0;
            this.dgvQuotationItems.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WetAsphalt;
            this.dgvQuotationItems.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.dgvQuotationItems.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvQuotationItems.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvQuotationItems.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvQuotationItems.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvQuotationItems.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.dgvQuotationItems.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.dgvQuotationItems.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.dgvQuotationItems.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.dgvQuotationItems.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvQuotationItems.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvQuotationItems.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvQuotationItems.ThemeStyle.HeaderStyle.Height = 24;
            this.dgvQuotationItems.ThemeStyle.ReadOnly = false;
            this.dgvQuotationItems.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.dgvQuotationItems.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvQuotationItems.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvQuotationItems.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvQuotationItems.ThemeStyle.RowsStyle.Height = 24;
            this.dgvQuotationItems.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            this.dgvQuotationItems.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvQuotationItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuotationItems_CellContentClick);
            // 
            // ITEM_ID
            // 
            this.ITEM_ID.HeaderText = "ITEM_ID";
            this.ITEM_ID.MinimumWidth = 6;
            this.ITEM_ID.Name = "ITEM_ID";
            // 
            // ITEM_Name
            // 
            this.ITEM_Name.HeaderText = "ITEM_Name";
            this.ITEM_Name.MinimumWidth = 6;
            this.ITEM_Name.Name = "ITEM_Name";
            // 
            // RUP
            // 
            this.RUP.HeaderText = "RUP";
            this.RUP.MinimumWidth = 6;
            this.RUP.Name = "RUP";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            // 
            // tPrice
            // 
            this.tPrice.HeaderText = "tPrice";
            this.tPrice.MinimumWidth = 6;
            this.tPrice.Name = "tPrice";
            // 
            // btnPrintQuotation
            // 
            this.btnPrintQuotation.AutoRoundedCorners = true;
            this.btnPrintQuotation.BorderColor = System.Drawing.Color.Transparent;
            this.btnPrintQuotation.BorderRadius = 17;
            this.btnPrintQuotation.BorderThickness = 2;
            this.btnPrintQuotation.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPrintQuotation.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPrintQuotation.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPrintQuotation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPrintQuotation.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.btnPrintQuotation.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.btnPrintQuotation.ForeColor = System.Drawing.Color.White;
            this.btnPrintQuotation.Location = new System.Drawing.Point(500, 292);
            this.btnPrintQuotation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPrintQuotation.Name = "btnPrintQuotation";
            this.btnPrintQuotation.Size = new System.Drawing.Size(175, 37);
            this.btnPrintQuotation.TabIndex = 2;
            this.btnPrintQuotation.Text = "Print Quotation";
            this.btnPrintQuotation.Click += new System.EventHandler(this.btnPrintQuotation_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
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
            // txtQuotationID
            // 
            this.txtQuotationID.Animated = true;
            this.txtQuotationID.AutoRoundedCorners = true;
            this.txtQuotationID.BorderRadius = 19;
            this.txtQuotationID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuotationID.DefaultText = "";
            this.txtQuotationID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtQuotationID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtQuotationID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuotationID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuotationID.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.txtQuotationID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuotationID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtQuotationID.ForeColor = System.Drawing.Color.White;
            this.txtQuotationID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuotationID.Location = new System.Drawing.Point(22, 292);
            this.txtQuotationID.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtQuotationID.Name = "txtQuotationID";
            this.txtQuotationID.PlaceholderText = "";
            this.txtQuotationID.SelectedText = "";
            this.txtQuotationID.Size = new System.Drawing.Size(172, 40);
            this.txtQuotationID.TabIndex = 3;
            // 
            // dtQuotationDate
            // 
            this.dtQuotationDate.Animated = true;
            this.dtQuotationDate.AutoRoundedCorners = true;
            this.dtQuotationDate.Checked = true;
            this.dtQuotationDate.FillColor = System.Drawing.Color.White;
            this.dtQuotationDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtQuotationDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtQuotationDate.Location = new System.Drawing.Point(226, 292);
            this.dtQuotationDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtQuotationDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtQuotationDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtQuotationDate.Name = "dtQuotationDate";
            this.dtQuotationDate.Size = new System.Drawing.Size(181, 29);
            this.dtQuotationDate.TabIndex = 4;
            this.dtQuotationDate.Value = new System.DateTime(2025, 4, 12, 22, 52, 29, 718);
            // 
            // comboCustomerName
            // 
            this.comboCustomerName.AutoRoundedCorners = true;
            this.comboCustomerName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.comboCustomerName.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.comboCustomerName.BorderRadius = 17;
            this.comboCustomerName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboCustomerName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCustomerName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.comboCustomerName.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboCustomerName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboCustomerName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboCustomerName.ForeColor = System.Drawing.Color.White;
            this.comboCustomerName.ItemHeight = 30;
            this.comboCustomerName.Location = new System.Drawing.Point(22, 344);
            this.comboCustomerName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboCustomerName.Name = "comboCustomerName";
            this.comboCustomerName.Size = new System.Drawing.Size(173, 36);
            this.comboCustomerName.TabIndex = 5;
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.AutoRoundedCorners = true;
            this.txtTotalAmount.BorderColor = System.Drawing.Color.White;
            this.txtTotalAmount.BorderRadius = 18;
            this.txtTotalAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalAmount.DefaultText = "";
            this.txtTotalAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTotalAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTotalAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalAmount.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.txtTotalAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalAmount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTotalAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalAmount.Location = new System.Drawing.Point(226, 335);
            this.txtTotalAmount.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.PlaceholderText = "";
            this.txtTotalAmount.SelectedText = "";
            this.txtTotalAmount.Size = new System.Drawing.Size(181, 39);
            this.txtTotalAmount.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Shop_Management__System.Properties.Resources.icons8_cross_50;
            this.pictureBox1.Location = new System.Drawing.Point(9, 6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // QuotationForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(683, 398);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtTotalAmount);
            this.Controls.Add(this.comboCustomerName);
            this.Controls.Add(this.dtQuotationDate);
            this.Controls.Add(this.txtQuotationID);
            this.Controls.Add(this.btnPrintQuotation);
            this.Controls.Add(this.dgvQuotationItems);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "QuotationForm2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuotationForm2";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.QuotationForm2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuotationItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvQuotationItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn ITEM_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ITEM_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn RUP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn tPrice;
        private Guna.UI2.WinForms.Guna2Button btnPrintQuotation;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private Guna.UI2.WinForms.Guna2TextBox txtQuotationID;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtQuotationDate;
        private Guna.UI2.WinForms.Guna2ComboBox comboCustomerName;
        private Guna.UI2.WinForms.Guna2TextBox txtTotalAmount;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}