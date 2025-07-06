namespace Shop_Management__System
{
    partial class viewOrder
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.orders_view = new System.Windows.Forms.DataGridView();
            this.oRDERIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oRDERDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oRDERTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUSTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bILLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oRDERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBProjectDataSet4 = new Shop_Management__System.DBProjectDataSet4();
            this.orderDetails_view = new System.Windows.Forms.DataGridView();
            this.oRDERIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTEMIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oRDERQTYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oRDERDETAILSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBProjectDataSet5 = new Shop_Management__System.DBProjectDataSet5();
            this.oRDERSTableAdapter = new Shop_Management__System.DBProjectDataSet4TableAdapters.ORDERSTableAdapter();
            this.oRDER_DETAILSTableAdapter = new Shop_Management__System.DBProjectDataSet5TableAdapters.ORDER_DETAILSTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.orders_view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oRDERSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBProjectDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetails_view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oRDERDETAILSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBProjectDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // orders_view
            // 
            this.orders_view.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.orders_view.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.orders_view.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.orders_view.AutoGenerateColumns = false;
            this.orders_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.orders_view.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.orders_view.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.orders_view.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.orders_view.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.orders_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orders_view.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.oRDERIDDataGridViewTextBoxColumn,
            this.oRDERDateDataGridViewTextBoxColumn,
            this.oRDERTimeDataGridViewTextBoxColumn,
            this.cUSTIDDataGridViewTextBoxColumn,
            this.bILLDataGridViewTextBoxColumn});
            this.orders_view.DataSource = this.oRDERSBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.orders_view.DefaultCellStyle = dataGridViewCellStyle3;
            this.orders_view.EnableHeadersVisualStyles = false;
            this.orders_view.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.orders_view.Location = new System.Drawing.Point(-30, 12);
            this.orders_view.Name = "orders_view";
            this.orders_view.RowHeadersWidth = 51;
            this.orders_view.Size = new System.Drawing.Size(1042, 242);
            this.orders_view.TabIndex = 22;
            this.orders_view.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.orders_view_CellContentClick);
            // 
            // oRDERIDDataGridViewTextBoxColumn
            // 
            this.oRDERIDDataGridViewTextBoxColumn.DataPropertyName = "ORDER_ID";
            this.oRDERIDDataGridViewTextBoxColumn.HeaderText = "ORDER_ID";
            this.oRDERIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.oRDERIDDataGridViewTextBoxColumn.Name = "oRDERIDDataGridViewTextBoxColumn";
            // 
            // oRDERDateDataGridViewTextBoxColumn
            // 
            this.oRDERDateDataGridViewTextBoxColumn.DataPropertyName = "ORDER_Date";
            this.oRDERDateDataGridViewTextBoxColumn.HeaderText = "ORDER_Date";
            this.oRDERDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.oRDERDateDataGridViewTextBoxColumn.Name = "oRDERDateDataGridViewTextBoxColumn";
            // 
            // oRDERTimeDataGridViewTextBoxColumn
            // 
            this.oRDERTimeDataGridViewTextBoxColumn.DataPropertyName = "ORDER_Time";
            this.oRDERTimeDataGridViewTextBoxColumn.HeaderText = "ORDER_Time";
            this.oRDERTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.oRDERTimeDataGridViewTextBoxColumn.Name = "oRDERTimeDataGridViewTextBoxColumn";
            // 
            // cUSTIDDataGridViewTextBoxColumn
            // 
            this.cUSTIDDataGridViewTextBoxColumn.DataPropertyName = "CUST_ID";
            this.cUSTIDDataGridViewTextBoxColumn.HeaderText = "CUST_ID";
            this.cUSTIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cUSTIDDataGridViewTextBoxColumn.Name = "cUSTIDDataGridViewTextBoxColumn";
            // 
            // bILLDataGridViewTextBoxColumn
            // 
            this.bILLDataGridViewTextBoxColumn.DataPropertyName = "BILL";
            this.bILLDataGridViewTextBoxColumn.HeaderText = "BILL";
            this.bILLDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bILLDataGridViewTextBoxColumn.Name = "bILLDataGridViewTextBoxColumn";
            // 
            // oRDERSBindingSource
            // 
            this.oRDERSBindingSource.DataMember = "ORDERS";
            this.oRDERSBindingSource.DataSource = this.dBProjectDataSet4;
            // 
            // dBProjectDataSet4
            // 
            this.dBProjectDataSet4.DataSetName = "DBProjectDataSet4";
            this.dBProjectDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderDetails_view
            // 
            this.orderDetails_view.AllowUserToOrderColumns = true;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.orderDetails_view.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.orderDetails_view.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.orderDetails_view.AutoGenerateColumns = false;
            this.orderDetails_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.orderDetails_view.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.orderDetails_view.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.orderDetails_view.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.orderDetails_view.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.orderDetails_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDetails_view.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.oRDERIDDataGridViewTextBoxColumn1,
            this.iTEMIDDataGridViewTextBoxColumn,
            this.oRDERQTYDataGridViewTextBoxColumn,
            this.totalPriceDataGridViewTextBoxColumn});
            this.orderDetails_view.DataSource = this.oRDERDETAILSBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.orderDetails_view.DefaultCellStyle = dataGridViewCellStyle6;
            this.orderDetails_view.EnableHeadersVisualStyles = false;
            this.orderDetails_view.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.orderDetails_view.Location = new System.Drawing.Point(-56, 290);
            this.orderDetails_view.Name = "orderDetails_view";
            this.orderDetails_view.RowHeadersWidth = 51;
            this.orderDetails_view.Size = new System.Drawing.Size(1068, 246);
            this.orderDetails_view.TabIndex = 23;
            this.orderDetails_view.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.orderDetails_view_CellContentClick);
            // 
            // oRDERIDDataGridViewTextBoxColumn1
            // 
            this.oRDERIDDataGridViewTextBoxColumn1.DataPropertyName = "ORDER_ID";
            this.oRDERIDDataGridViewTextBoxColumn1.HeaderText = "ORDER_ID";
            this.oRDERIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.oRDERIDDataGridViewTextBoxColumn1.Name = "oRDERIDDataGridViewTextBoxColumn1";
            // 
            // iTEMIDDataGridViewTextBoxColumn
            // 
            this.iTEMIDDataGridViewTextBoxColumn.DataPropertyName = "ITEM_ID";
            this.iTEMIDDataGridViewTextBoxColumn.HeaderText = "ITEM_ID";
            this.iTEMIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iTEMIDDataGridViewTextBoxColumn.Name = "iTEMIDDataGridViewTextBoxColumn";
            // 
            // oRDERQTYDataGridViewTextBoxColumn
            // 
            this.oRDERQTYDataGridViewTextBoxColumn.DataPropertyName = "ORDER_QTY";
            this.oRDERQTYDataGridViewTextBoxColumn.HeaderText = "ORDER_QTY";
            this.oRDERQTYDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.oRDERQTYDataGridViewTextBoxColumn.Name = "oRDERQTYDataGridViewTextBoxColumn";
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            this.totalPriceDataGridViewTextBoxColumn.DataPropertyName = "Total_Price";
            this.totalPriceDataGridViewTextBoxColumn.HeaderText = "Total_Price";
            this.totalPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            // 
            // oRDERDETAILSBindingSource
            // 
            this.oRDERDETAILSBindingSource.DataMember = "ORDER_DETAILS";
            this.oRDERDETAILSBindingSource.DataSource = this.dBProjectDataSet5;
            // 
            // dBProjectDataSet5
            // 
            this.dBProjectDataSet5.DataSetName = "DBProjectDataSet5";
            this.dBProjectDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oRDERSTableAdapter
            // 
            this.oRDERSTableAdapter.ClearBeforeFill = true;
            // 
            // oRDER_DETAILSTableAdapter
            // 
            this.oRDER_DETAILSTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Shop_Management__System.Properties.Resources.icons8_go_back_48;
            this.pictureBox1.Location = new System.Drawing.Point(1, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // viewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1092, 548);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.orderDetails_view);
            this.Controls.Add(this.orders_view);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "viewOrder";
            this.Text = "viewOrder";
            this.Load += new System.EventHandler(this.viewOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orders_view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oRDERSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBProjectDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetails_view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oRDERDETAILSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBProjectDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView orders_view;
        private System.Windows.Forms.DataGridView orderDetails_view;
        private DBProjectDataSet4 dBProjectDataSet4;
        private System.Windows.Forms.BindingSource oRDERSBindingSource;
        private DBProjectDataSet4TableAdapters.ORDERSTableAdapter oRDERSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn oRDERIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oRDERDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oRDERTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUSTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bILLDataGridViewTextBoxColumn;
        private DBProjectDataSet5 dBProjectDataSet5;
        private System.Windows.Forms.BindingSource oRDERDETAILSBindingSource;
        private DBProjectDataSet5TableAdapters.ORDER_DETAILSTableAdapter oRDER_DETAILSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn oRDERIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iTEMIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oRDERQTYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


