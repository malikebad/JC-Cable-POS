﻿namespace Shop_Management__System
{
    partial class QuickSaleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuickSaleForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.QuicjOrderBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDropQty = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.btnAddToCart = new Guna.UI2.WinForms.Guna2Button();
            this.txtTotal = new Guna.UI2.WinForms.Guna2TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtItem_UPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCustID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCust_City = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCust_Contact = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch_Cust = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.boxSelectCustomer = new Guna.UI2.WinForms.Guna2ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtGrandTotal = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnRemove = new Guna.UI2.WinForms.Guna2Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtItem_Name = new Guna.UI2.WinForms.Guna2TextBox();
            this.Order_view = new System.Windows.Forms.DataGridView();
            this.ITEM_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ITEM_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RUP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPrint = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtOrder_Id = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblOrderTime = new System.Windows.Forms.Label();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSearch_item = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.boxSelectItem = new Guna.UI2.WinForms.Guna2ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.printDocument2 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.txtDropQty)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Order_view)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // QuicjOrderBtn
            // 
            this.QuicjOrderBtn.AutoRoundedCorners = true;
            this.QuicjOrderBtn.BorderColor = System.Drawing.Color.Transparent;
            this.QuicjOrderBtn.BorderRadius = 23;
            this.QuicjOrderBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.QuicjOrderBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.QuicjOrderBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.QuicjOrderBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.QuicjOrderBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.QuicjOrderBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuicjOrderBtn.ForeColor = System.Drawing.Color.White;
            this.QuicjOrderBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.QuicjOrderBtn.Location = new System.Drawing.Point(595, 226);
            this.QuicjOrderBtn.Name = "QuicjOrderBtn";
            this.QuicjOrderBtn.Size = new System.Drawing.Size(213, 48);
            this.QuicjOrderBtn.TabIndex = 45;
            this.QuicjOrderBtn.Text = "submitQuickOrder";
            this.QuicjOrderBtn.Click += new System.EventHandler(this.QuicjOrderBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(10, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 16);
            this.label3.TabIndex = 31;
            this.label3.Text = "City";
            // 
            // txtDropQty
            // 
            this.txtDropQty.AutoRoundedCorners = true;
            this.txtDropQty.BackColor = System.Drawing.Color.Transparent;
            this.txtDropQty.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtDropQty.BorderRadius = 13;
            this.txtDropQty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDropQty.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtDropQty.Font = new System.Drawing.Font("Cambria", 9F);
            this.txtDropQty.Location = new System.Drawing.Point(125, 161);
            this.txtDropQty.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDropQty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtDropQty.Name = "txtDropQty";
            this.txtDropQty.ShadowDecoration.Color = System.Drawing.Color.White;
            this.txtDropQty.Size = new System.Drawing.Size(75, 29);
            this.txtDropQty.TabIndex = 43;
            this.txtDropQty.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtDropQty.UpDownButtonForeColor = System.Drawing.Color.White;
            this.txtDropQty.UseTransparentBackground = true;
            this.txtDropQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.AutoRoundedCorners = true;
            this.btnAddToCart.BorderColor = System.Drawing.Color.Transparent;
            this.btnAddToCart.BorderRadius = 13;
            this.btnAddToCart.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddToCart.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddToCart.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddToCart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddToCart.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnAddToCart.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnAddToCart.ForeColor = System.Drawing.Color.White;
            this.btnAddToCart.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnAddToCart.Location = new System.Drawing.Point(107, 223);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(101, 29);
            this.btnAddToCart.TabIndex = 42;
            this.btnAddToCart.Text = "Add to Cart";
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.txtTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotal.DefaultText = "";
            this.txtTotal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTotal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTotal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotal.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.txtTotal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotal.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtTotal.ForeColor = System.Drawing.Color.Transparent;
            this.txtTotal.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotal.Location = new System.Drawing.Point(14, 223);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.PlaceholderText = "";
            this.txtTotal.SelectedText = "";
            this.txtTotal.Size = new System.Drawing.Size(59, 23);
            this.txtTotal.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtTotal.TabIndex = 41;
            this.txtTotal.TextChanged += new System.EventHandler(this.txtQty_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(11, 203);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 16);
            this.label10.TabIndex = 40;
            this.label10.Text = "Total";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(126, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 16);
            this.label7.TabIndex = 36;
            this.label7.Text = "Qunatity";
            // 
            // txtItem_UPrice
            // 
            this.txtItem_UPrice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.txtItem_UPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtItem_UPrice.DefaultText = "";
            this.txtItem_UPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtItem_UPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtItem_UPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtItem_UPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtItem_UPrice.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.txtItem_UPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtItem_UPrice.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtItem_UPrice.ForeColor = System.Drawing.Color.Transparent;
            this.txtItem_UPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtItem_UPrice.Location = new System.Drawing.Point(14, 161);
            this.txtItem_UPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtItem_UPrice.Name = "txtItem_UPrice";
            this.txtItem_UPrice.PlaceholderText = "";
            this.txtItem_UPrice.SelectedText = "";
            this.txtItem_UPrice.Size = new System.Drawing.Size(87, 23);
            this.txtItem_UPrice.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtItem_UPrice.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(11, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 16);
            this.label6.TabIndex = 34;
            this.label6.Text = "Unit Price";
            // 
            // txtCustID
            // 
            this.txtCustID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.txtCustID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCustID.DefaultText = "";
            this.txtCustID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCustID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCustID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCustID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCustID.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.txtCustID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCustID.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCustID.ForeColor = System.Drawing.Color.Transparent;
            this.txtCustID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCustID.Location = new System.Drawing.Point(184, 155);
            this.txtCustID.Margin = new System.Windows.Forms.Padding(4);
            this.txtCustID.Name = "txtCustID";
            this.txtCustID.PlaceholderText = "";
            this.txtCustID.SelectedText = "";
            this.txtCustID.Size = new System.Drawing.Size(82, 23);
            this.txtCustID.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtCustID.TabIndex = 40;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(181, 135);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 16);
            this.label11.TabIndex = 39;
            this.label11.Text = "Customer ID";
            // 
            // txtCust_City
            // 
            this.txtCust_City.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.txtCust_City.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCust_City.DefaultText = "";
            this.txtCust_City.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCust_City.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCust_City.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCust_City.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCust_City.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.txtCust_City.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCust_City.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCust_City.ForeColor = System.Drawing.Color.Transparent;
            this.txtCust_City.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCust_City.Location = new System.Drawing.Point(13, 155);
            this.txtCust_City.Margin = new System.Windows.Forms.Padding(4);
            this.txtCust_City.Name = "txtCust_City";
            this.txtCust_City.PlaceholderText = "";
            this.txtCust_City.SelectedText = "";
            this.txtCust_City.Size = new System.Drawing.Size(153, 23);
            this.txtCust_City.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtCust_City.TabIndex = 32;
            // 
            // txtCust_Contact
            // 
            this.txtCust_Contact.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.txtCust_Contact.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCust_Contact.DefaultText = "";
            this.txtCust_Contact.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCust_Contact.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCust_Contact.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCust_Contact.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCust_Contact.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.txtCust_Contact.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCust_Contact.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCust_Contact.ForeColor = System.Drawing.Color.Transparent;
            this.txtCust_Contact.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCust_Contact.Location = new System.Drawing.Point(13, 94);
            this.txtCust_Contact.Margin = new System.Windows.Forms.Padding(4);
            this.txtCust_Contact.Name = "txtCust_Contact";
            this.txtCust_Contact.PlaceholderText = "";
            this.txtCust_Contact.SelectedText = "";
            this.txtCust_Contact.Size = new System.Drawing.Size(240, 23);
            this.txtCust_Contact.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtCust_Contact.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 29;
            this.label1.Text = "Conatct No";
            // 
            // btnSearch_Cust
            // 
            this.btnSearch_Cust.AutoRoundedCorners = true;
            this.btnSearch_Cust.BorderColor = System.Drawing.Color.Transparent;
            this.btnSearch_Cust.BorderRadius = 13;
            this.btnSearch_Cust.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch_Cust.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch_Cust.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch_Cust.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearch_Cust.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnSearch_Cust.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.btnSearch_Cust.ForeColor = System.Drawing.Color.White;
            this.btnSearch_Cust.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnSearch_Cust.Location = new System.Drawing.Point(184, 27);
            this.btnSearch_Cust.Name = "btnSearch_Cust";
            this.btnSearch_Cust.Size = new System.Drawing.Size(69, 29);
            this.btnSearch_Cust.TabIndex = 28;
            this.btnSearch_Cust.Text = "Search";
            this.btnSearch_Cust.Click += new System.EventHandler(this.btnSearch_Cust_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Select Customer";
            // 
            // boxSelectCustomer
            // 
            this.boxSelectCustomer.AutoRoundedCorners = true;
            this.boxSelectCustomer.BackColor = System.Drawing.Color.Transparent;
            this.boxSelectCustomer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.boxSelectCustomer.BorderRadius = 17;
            this.boxSelectCustomer.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.boxSelectCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxSelectCustomer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.boxSelectCustomer.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.boxSelectCustomer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.boxSelectCustomer.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold);
            this.boxSelectCustomer.ForeColor = System.Drawing.Color.White;
            this.boxSelectCustomer.ItemHeight = 30;
            this.boxSelectCustomer.Location = new System.Drawing.Point(13, 27);
            this.boxSelectCustomer.Name = "boxSelectCustomer";
            this.boxSelectCustomer.Size = new System.Drawing.Size(165, 36);
            this.boxSelectCustomer.TabIndex = 0;
            // 
            // txtGrandTotal
            // 
            this.txtGrandTotal.AutoRoundedCorners = true;
            this.txtGrandTotal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.txtGrandTotal.BorderRadius = 11;
            this.txtGrandTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGrandTotal.DefaultText = "Rs.";
            this.txtGrandTotal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGrandTotal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGrandTotal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGrandTotal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGrandTotal.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.txtGrandTotal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGrandTotal.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtGrandTotal.ForeColor = System.Drawing.Color.Transparent;
            this.txtGrandTotal.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGrandTotal.Location = new System.Drawing.Point(580, 128);
            this.txtGrandTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtGrandTotal.Name = "txtGrandTotal";
            this.txtGrandTotal.PlaceholderText = "";
            this.txtGrandTotal.SelectedText = "";
            this.txtGrandTotal.SelectionStart = 3;
            this.txtGrandTotal.Size = new System.Drawing.Size(201, 24);
            this.txtGrandTotal.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtGrandTotal.TabIndex = 53;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(591, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 19);
            this.label9.TabIndex = 52;
            this.label9.Text = "Grand Total";
            // 
            // btnRemove
            // 
            this.btnRemove.AutoRoundedCorners = true;
            this.btnRemove.BorderColor = System.Drawing.Color.Transparent;
            this.btnRemove.BorderRadius = 20;
            this.btnRemove.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRemove.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRemove.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRemove.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRemove.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.btnRemove.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnRemove.Location = new System.Drawing.Point(621, 43);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(143, 42);
            this.btnRemove.TabIndex = 51;
            this.btnRemove.Text = "Remove";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click_1);
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.txtCustID);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.txtCust_City);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtCust_Contact);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btnSearch_Cust);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.boxSelectCustomer);
            this.panel3.Location = new System.Drawing.Point(46, 79);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(285, 195);
            this.panel3.TabIndex = 47;
            // 
            // txtItem_Name
            // 
            this.txtItem_Name.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.txtItem_Name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtItem_Name.DefaultText = "";
            this.txtItem_Name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtItem_Name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtItem_Name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtItem_Name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtItem_Name.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.txtItem_Name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtItem_Name.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtItem_Name.ForeColor = System.Drawing.Color.Transparent;
            this.txtItem_Name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtItem_Name.Location = new System.Drawing.Point(14, 95);
            this.txtItem_Name.Margin = new System.Windows.Forms.Padding(4);
            this.txtItem_Name.Name = "txtItem_Name";
            this.txtItem_Name.PlaceholderText = "";
            this.txtItem_Name.SelectedText = "";
            this.txtItem_Name.Size = new System.Drawing.Size(194, 23);
            this.txtItem_Name.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtItem_Name.TabIndex = 33;
            // 
            // Order_view
            // 
            this.Order_view.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.Order_view.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Order_view.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Order_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Order_view.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.Order_view.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Order_view.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Order_view.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Order_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Order_view.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ITEM_ID,
            this.ITEM_Name,
            this.RUP,
            this.Quantity,
            this.tPrice});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Order_view.DefaultCellStyle = dataGridViewCellStyle3;
            this.Order_view.EnableHeadersVisualStyles = false;
            this.Order_view.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.Order_view.Location = new System.Drawing.Point(26, 280);
            this.Order_view.Name = "Order_view";
            this.Order_view.RowHeadersWidth = 51;
            this.Order_view.Size = new System.Drawing.Size(808, 226);
            this.Order_view.TabIndex = 50;
            this.Order_view.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Order_view_CellContentClick_1);
            // 
            // ITEM_ID
            // 
            this.ITEM_ID.HeaderText = "ITEM ID";
            this.ITEM_ID.MinimumWidth = 6;
            this.ITEM_ID.Name = "ITEM_ID";
            // 
            // ITEM_Name
            // 
            this.ITEM_Name.HeaderText = "ITEM Name";
            this.ITEM_Name.MinimumWidth = 6;
            this.ITEM_Name.Name = "ITEM_Name";
            // 
            // RUP
            // 
            this.RUP.HeaderText = "Unit Price";
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
            this.tPrice.HeaderText = "Total Price";
            this.tPrice.MinimumWidth = 6;
            this.tPrice.Name = "tPrice";
            // 
            // btnPrint
            // 
            this.btnPrint.AutoRoundedCorners = true;
            this.btnPrint.BorderColor = System.Drawing.Color.Transparent;
            this.btnPrint.BorderRadius = 23;
            this.btnPrint.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPrint.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPrint.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPrint.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPrint.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.btnPrint.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnPrint.Location = new System.Drawing.Point(621, 172);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(159, 48);
            this.btnPrint.TabIndex = 49;
            this.btnPrint.Text = "Print Reciept";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txtOrder_Id);
            this.panel1.Controls.Add(this.lblOrderTime);
            this.panel1.Controls.Add(this.lblOrderDate);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(46, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 62);
            this.panel1.TabIndex = 46;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(187, 7);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 16);
            this.label13.TabIndex = 40;
            this.label13.Text = "Order Time";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(87, 7);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 16);
            this.label12.TabIndex = 39;
            this.label12.Text = "Order Date";
            // 
            // txtOrder_Id
            // 
            this.txtOrder_Id.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.txtOrder_Id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOrder_Id.DefaultText = "";
            this.txtOrder_Id.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtOrder_Id.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtOrder_Id.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOrder_Id.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOrder_Id.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.txtOrder_Id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOrder_Id.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtOrder_Id.ForeColor = System.Drawing.Color.Transparent;
            this.txtOrder_Id.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOrder_Id.Location = new System.Drawing.Point(8, 32);
            this.txtOrder_Id.Margin = new System.Windows.Forms.Padding(4);
            this.txtOrder_Id.Name = "txtOrder_Id";
            this.txtOrder_Id.PlaceholderText = "";
            this.txtOrder_Id.SelectedText = "";
            this.txtOrder_Id.Size = new System.Drawing.Size(59, 23);
            this.txtOrder_Id.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtOrder_Id.TabIndex = 38;
            // 
            // lblOrderTime
            // 
            this.lblOrderTime.AutoSize = true;
            this.lblOrderTime.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderTime.ForeColor = System.Drawing.Color.White;
            this.lblOrderTime.Location = new System.Drawing.Point(187, 39);
            this.lblOrderTime.Name = "lblOrderTime";
            this.lblOrderTime.Size = new System.Drawing.Size(68, 15);
            this.lblOrderTime.TabIndex = 34;
            this.lblOrderTime.Text = "Order Time";
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderDate.ForeColor = System.Drawing.Color.White;
            this.lblOrderDate.Location = new System.Drawing.Point(87, 39);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(66, 15);
            this.lblOrderDate.TabIndex = 32;
            this.lblOrderDate.Text = "Order Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(5, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 16);
            this.label8.TabIndex = 31;
            this.label8.Text = "Order ID";
            // 
            // btnSearch_item
            // 
            this.btnSearch_item.AutoRoundedCorners = true;
            this.btnSearch_item.BorderColor = System.Drawing.Color.Transparent;
            this.btnSearch_item.BorderRadius = 13;
            this.btnSearch_item.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch_item.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch_item.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch_item.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearch_item.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnSearch_item.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.btnSearch_item.ForeColor = System.Drawing.Color.White;
            this.btnSearch_item.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnSearch_item.Location = new System.Drawing.Point(139, 26);
            this.btnSearch_item.Name = "btnSearch_item";
            this.btnSearch_item.Size = new System.Drawing.Size(69, 29);
            this.btnSearch_item.TabIndex = 31;
            this.btnSearch_item.Text = "Search";
            this.btnSearch_item.Click += new System.EventHandler(this.btnSearch_item_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.txtDropQty);
            this.panel2.Controls.Add(this.btnAddToCart);
            this.panel2.Controls.Add(this.txtTotal);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtItem_UPrice);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtItem_Name);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btnSearch_item);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.boxSelectItem);
            this.panel2.Location = new System.Drawing.Point(337, 11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(219, 263);
            this.panel2.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(11, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 32;
            this.label5.Text = "Item Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(11, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 30;
            this.label4.Text = "Item ID";
            // 
            // boxSelectItem
            // 
            this.boxSelectItem.AutoRoundedCorners = true;
            this.boxSelectItem.BackColor = System.Drawing.Color.Transparent;
            this.boxSelectItem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.boxSelectItem.BorderRadius = 17;
            this.boxSelectItem.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.boxSelectItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxSelectItem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.boxSelectItem.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.boxSelectItem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.boxSelectItem.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold);
            this.boxSelectItem.ForeColor = System.Drawing.Color.White;
            this.boxSelectItem.ItemHeight = 30;
            this.boxSelectItem.Location = new System.Drawing.Point(14, 26);
            this.boxSelectItem.Name = "boxSelectItem";
            this.boxSelectItem.Size = new System.Drawing.Size(108, 36);
            this.boxSelectItem.TabIndex = 29;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Shop_Management__System.Properties.Resources.icons8_cross_50;
            this.pictureBox1.Location = new System.Drawing.Point(9, 7);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // printDocument2
            // 
            this.printDocument2.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument2_PrintPage_1);
            // 
            // QuickSaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(856, 518);
            this.Controls.Add(this.txtGrandTotal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Order_view);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.QuicjOrderBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "QuickSaleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuickSaleForm";
            this.Load += new System.EventHandler(this.QuickSaleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtDropQty)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Order_view)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button QuicjOrderBtn;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2NumericUpDown txtDropQty;
        private Guna.UI2.WinForms.Guna2Button btnAddToCart;
        private Guna.UI2.WinForms.Guna2TextBox txtTotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txtItem_UPrice;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtCustID;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2TextBox txtCust_City;
        private Guna.UI2.WinForms.Guna2TextBox txtCust_Contact;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnSearch_Cust;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox boxSelectCustomer;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2TextBox txtGrandTotal;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2Button btnRemove;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2TextBox txtItem_Name;
        private System.Windows.Forms.DataGridView Order_view;
        private System.Windows.Forms.DataGridViewTextBoxColumn ITEM_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ITEM_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn RUP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn tPrice;
        private Guna.UI2.WinForms.Guna2Button btnPrint;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2TextBox txtOrder_Id;
        private System.Windows.Forms.Label lblOrderTime;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2Button btnSearch_item;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox boxSelectItem;
        private System.Drawing.Printing.PrintDocument printDocument2;
    }
}