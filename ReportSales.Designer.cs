namespace Shop_Management__System
{
    partial class ReportSales
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.dtpStartDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpEndDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnFilterReport = new Guna.UI2.WinForms.Guna2Button();
            this.dgvSalesReport = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnSaveSummary = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.lblTotalSales = new System.Windows.Forms.Label();
            this.rbUseDateRange = new System.Windows.Forms.RadioButton();
            this.lblTotalOrders = new System.Windows.Forms.Label();
            this.lblTotalQty = new System.Windows.Forms.Label();
            this.btnGeneratePrintable = new Guna.UI2.WinForms.Guna2Button();
            this.btnExportToExcel = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesReport)).BeginInit();
            this.guna2ShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFrom.Location = new System.Drawing.Point(186, 161);
            this.lblFrom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(88, 19);
            this.lblFrom.TabIndex = 0;
            this.lblFrom.Text = "From Date";
            this.lblFrom.Click += new System.EventHandler(this.lblTo66_Click);
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTo.Location = new System.Drawing.Point(193, 219);
            this.lblTo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(66, 19);
            this.lblTo.TabIndex = 1;
            this.lblTo.Text = "To Date";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Animated = true;
            this.dtpStartDate.AutoRoundedCorners = true;
            this.dtpStartDate.BorderColor = System.Drawing.Color.White;
            this.dtpStartDate.BorderRadius = 13;
            this.dtpStartDate.BorderThickness = 1;
            this.dtpStartDate.Checked = true;
            this.dtpStartDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.dtpStartDate.Font = new System.Drawing.Font("Sitka Small", 10.2F, System.Drawing.FontStyle.Bold);
            this.dtpStartDate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpStartDate.Location = new System.Drawing.Point(273, 161);
            this.dtpStartDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpStartDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpStartDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(244, 29);
            this.dtpStartDate.TabIndex = 4;
            this.dtpStartDate.Value = new System.DateTime(2025, 4, 14, 22, 17, 16, 215);
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.AutoRoundedCorners = true;
            this.dtpEndDate.BorderColor = System.Drawing.Color.White;
            this.dtpEndDate.BorderRadius = 13;
            this.dtpEndDate.BorderThickness = 1;
            this.dtpEndDate.Checked = true;
            this.dtpEndDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.dtpEndDate.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold);
            this.dtpEndDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpEndDate.Location = new System.Drawing.Point(273, 209);
            this.dtpEndDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpEndDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpEndDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(244, 29);
            this.dtpEndDate.TabIndex = 5;
            this.dtpEndDate.Value = new System.DateTime(2025, 4, 14, 22, 17, 16, 215);
            // 
            // btnFilterReport
            // 
            this.btnFilterReport.AutoRoundedCorners = true;
            this.btnFilterReport.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFilterReport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFilterReport.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFilterReport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFilterReport.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.btnFilterReport.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilterReport.ForeColor = System.Drawing.Color.White;
            this.btnFilterReport.Location = new System.Drawing.Point(372, 255);
            this.btnFilterReport.Margin = new System.Windows.Forms.Padding(2);
            this.btnFilterReport.Name = "btnFilterReport";
            this.btnFilterReport.Size = new System.Drawing.Size(145, 37);
            this.btnFilterReport.TabIndex = 6;
            this.btnFilterReport.Text = "View Records";
            this.btnFilterReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // dgvSalesReport
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvSalesReport.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSalesReport.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSalesReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvSalesReport.ColumnHeadersHeight = 5;
            this.dgvSalesReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSalesReport.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvSalesReport.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvSalesReport.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvSalesReport.Location = new System.Drawing.Point(0, 383);
            this.dgvSalesReport.Margin = new System.Windows.Forms.Padding(2);
            this.dgvSalesReport.Name = "dgvSalesReport";
            this.dgvSalesReport.RowHeadersVisible = false;
            this.dgvSalesReport.RowHeadersWidth = 51;
            this.dgvSalesReport.RowTemplate.Height = 24;
            this.dgvSalesReport.Size = new System.Drawing.Size(874, 165);
            this.dgvSalesReport.TabIndex = 7;
            this.dgvSalesReport.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvSalesReport.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvSalesReport.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvSalesReport.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvSalesReport.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvSalesReport.ThemeStyle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvSalesReport.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvSalesReport.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvSalesReport.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvSalesReport.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSalesReport.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvSalesReport.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvSalesReport.ThemeStyle.HeaderStyle.Height = 5;
            this.dgvSalesReport.ThemeStyle.ReadOnly = false;
            this.dgvSalesReport.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvSalesReport.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSalesReport.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSalesReport.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvSalesReport.ThemeStyle.RowsStyle.Height = 24;
            this.dgvSalesReport.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvSalesReport.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btnSaveSummary
            // 
            this.btnSaveSummary.AutoRoundedCorners = true;
            this.btnSaveSummary.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveSummary.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveSummary.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSaveSummary.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSaveSummary.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.btnSaveSummary.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveSummary.ForeColor = System.Drawing.Color.White;
            this.btnSaveSummary.Location = new System.Drawing.Point(372, 331);
            this.btnSaveSummary.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveSummary.Name = "btnSaveSummary";
            this.btnSaveSummary.Size = new System.Drawing.Size(145, 37);
            this.btnSaveSummary.TabIndex = 10;
            this.btnSaveSummary.Text = "Save Summary";
            this.btnSaveSummary.Click += new System.EventHandler(this.SaveSalesSummary_Click);
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.guna2ShadowPanel1.Controls.Add(this.lblTitle);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(42, 10);
            this.guna2ShadowPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(773, 82);
            this.guna2ShadowPanel1.TabIndex = 11;
            this.guna2ShadowPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2ShadowPanel1_Paint);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Stencil", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(220, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(334, 57);
            this.lblTitle.TabIndex = 22;
            this.lblTitle.Text = "SALE REPORT";
            // 
            // btnClear
            // 
            this.btnClear.AutoRoundedCorners = true;
            this.btnClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(52, 331);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(135, 37);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear Form";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblTotalSales
            // 
            this.lblTotalSales.AutoSize = true;
            this.lblTotalSales.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSales.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTotalSales.Location = new System.Drawing.Point(563, 151);
            this.lblTotalSales.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalSales.Name = "lblTotalSales";
            this.lblTotalSales.Size = new System.Drawing.Size(193, 19);
            this.lblTotalSales.TabIndex = 3;
            this.lblTotalSales.Text = "Show total sales amount";
            // 
            // rbUseDateRange
            // 
            this.rbUseDateRange.AutoSize = true;
            this.rbUseDateRange.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbUseDateRange.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbUseDateRange.Location = new System.Drawing.Point(42, 121);
            this.rbUseDateRange.Margin = new System.Windows.Forms.Padding(2);
            this.rbUseDateRange.Name = "rbUseDateRange";
            this.rbUseDateRange.Size = new System.Drawing.Size(145, 23);
            this.rbUseDateRange.TabIndex = 17;
            this.rbUseDateRange.TabStop = true;
            this.rbUseDateRange.Text = "For Date Range";
            this.rbUseDateRange.UseVisualStyleBackColor = true;
            this.rbUseDateRange.CheckedChanged += new System.EventHandler(this.rbUseDateRange_CheckedChanged);
            // 
            // lblTotalOrders
            // 
            this.lblTotalOrders.AutoSize = true;
            this.lblTotalOrders.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalOrders.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTotalOrders.Location = new System.Drawing.Point(563, 182);
            this.lblTotalOrders.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalOrders.Name = "lblTotalOrders";
            this.lblTotalOrders.Size = new System.Drawing.Size(193, 19);
            this.lblTotalOrders.TabIndex = 15;
            this.lblTotalOrders.Text = "Show total sales amount";
            // 
            // lblTotalQty
            // 
            this.lblTotalQty.AutoSize = true;
            this.lblTotalQty.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalQty.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTotalQty.Location = new System.Drawing.Point(563, 209);
            this.lblTotalQty.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalQty.Name = "lblTotalQty";
            this.lblTotalQty.Size = new System.Drawing.Size(193, 19);
            this.lblTotalQty.TabIndex = 16;
            this.lblTotalQty.Text = "Show total sales amount";
            // 
            // btnGeneratePrintable
            // 
            this.btnGeneratePrintable.AutoRoundedCorners = true;
            this.btnGeneratePrintable.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGeneratePrintable.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGeneratePrintable.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGeneratePrintable.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGeneratePrintable.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.btnGeneratePrintable.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeneratePrintable.ForeColor = System.Drawing.Color.White;
            this.btnGeneratePrintable.Location = new System.Drawing.Point(552, 342);
            this.btnGeneratePrintable.Margin = new System.Windows.Forms.Padding(2);
            this.btnGeneratePrintable.Name = "btnGeneratePrintable";
            this.btnGeneratePrintable.Size = new System.Drawing.Size(173, 37);
            this.btnGeneratePrintable.TabIndex = 19;
            this.btnGeneratePrintable.Text = "Generate PDF / Print";
            this.btnGeneratePrintable.Click += new System.EventHandler(this.btnGeneratePrintable_Click);
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.AutoRoundedCorners = true;
            this.btnExportToExcel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExportToExcel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExportToExcel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExportToExcel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExportToExcel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.btnExportToExcel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportToExcel.ForeColor = System.Drawing.Color.White;
            this.btnExportToExcel.Location = new System.Drawing.Point(729, 342);
            this.btnExportToExcel.Margin = new System.Windows.Forms.Padding(2);
            this.btnExportToExcel.Name = "btnExportToExcel";
            this.btnExportToExcel.Size = new System.Drawing.Size(145, 37);
            this.btnExportToExcel.TabIndex = 20;
            this.btnExportToExcel.Text = "Save As XML";
            this.btnExportToExcel.Click += new System.EventHandler(this.btnExportToExcel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Shop_Management__System.Properties.Resources.icons8_cross_50;
            this.pictureBox1.Location = new System.Drawing.Point(0, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ReportSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(874, 548);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnExportToExcel);
            this.Controls.Add(this.btnGeneratePrintable);
            this.Controls.Add(this.lblTotalQty);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblTotalOrders);
            this.Controls.Add(this.lblTotalSales);
            this.Controls.Add(this.rbUseDateRange);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Controls.Add(this.btnSaveSummary);
            this.Controls.Add(this.dgvSalesReport);
            this.Controls.Add(this.btnFilterReport);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblFrom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ReportSales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportSales";
            this.Load += new System.EventHandler(this.ReportSales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesReport)).EndInit();
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpStartDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpEndDate;
        private Guna.UI2.WinForms.Guna2Button btnFilterReport;
        private Guna.UI2.WinForms.Guna2DataGridView dgvSalesReport;
        private Guna.UI2.WinForms.Guna2Button btnSaveSummary;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private System.Windows.Forms.Label lblTotalSales;
        private System.Windows.Forms.RadioButton rbUseDateRange;
        private System.Windows.Forms.Label lblTotalOrders;
        private System.Windows.Forms.Label lblTotalQty;
        private Guna.UI2.WinForms.Guna2Button btnGeneratePrintable;
        private Guna.UI2.WinForms.Guna2Button btnExportToExcel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}