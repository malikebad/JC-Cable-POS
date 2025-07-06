using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Printing;
using System.Text.RegularExpressions;

namespace Shop_Management__System
{
    public partial class PlaceOrder : Form
    {
        Image companyLogo = Properties.Resources.ShopingCart;

        public PlaceOrder()
        {
            InitializeComponent();
            fillBoxSelectCustomer();
            fillBoxSelectItem();
            setOrderId();

            txtCustID.Text = "";
            txtItem_Name.Text = "";
            txtItem_UPrice.Text = "";
            txtCust_City.Text = "";
            txtCust_Contact.Text = "";
            txtTotal.Text = "";

        }
        public class OrderItem
        {
            public string Name { get; set; }
            public int Quantity { get; set; }
            public decimal Price { get; set; }
        }
        List<OrderItem> orderItems = new List<OrderItem>();
        decimal totalAmount = 0;
        int qty, gTotal = 0, amount;

        public string constring = "Data Source=localhost;Initial Catalog=DBProject;Integrated Security=True;";

        void fillBoxSelectCustomer()
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string q = "Select CUST_ID,CUST_Name from CUSTOMER";
            SqlCommand cmd = new SqlCommand(q, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable selectCustomer = new DataTable();
            da.Fill(selectCustomer);
            boxSelectCustomer.DataSource = selectCustomer;
            boxSelectCustomer.DisplayMember = "CUST_Name";
            boxSelectCustomer.ValueMember = "CUST_ID";
        }
        void fillBoxSelectItem()
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string q = "Select ITEM_ID from ITEM";
            SqlCommand cmd = new SqlCommand(q, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable selectItem = new DataTable();
            da.Fill(selectItem);
            boxSelectItem.DataSource = selectItem;
            boxSelectItem.DisplayMember = "ITEM_ID";
            boxSelectItem.ValueMember = "ITEM_ID";
        }

        private void btnSearch_Cust_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string q = "Select * from CUSTOMER where CUST_Name= '"+boxSelectCustomer.Text+"'";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            SqlDataAdapter sda1 = new SqlDataAdapter(q, constring);
            DataTable dtl1 = new DataTable();
            sda1.Fill(dtl1);
            if (dtl1.Rows.Count == 1)
            {
                while (dr.Read())
                {
                    String conta = (string)dr["CUST_Contact"].ToString();
                    txtCust_Contact.Text = conta;

                    String city = (string)dr["CUST_City"].ToString();
                    txtCust_City.Text = city;

                    String cID = (string)dr["CUST_ID"].ToString();
                    txtCustID.Text = cID;
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Data Not Found");
            }
           
        }

        private void btnSearch_item_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string q = "Select * from ITEM where ITEM_ID= '" + boxSelectItem.Text + "'";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                String iName = (string)dr["ITEM_Name"].ToString();
                txtItem_Name.Text = iName;

                String iUPrice = (string)dr["ITEM_RetailUnitPrice"].ToString();
                txtItem_UPrice.Text = iUPrice;
            }
            con.Close();
            CalculateTotal();
        }

        private void PlaceOrder_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        public void setOrderId()
        {

            using (SqlConnection con = new SqlConnection(constring))
            {
                con.Open();
                string q = "SELECT MAX(RIGHT(Order_id, 3)) FROM ORDERS";
                SqlCommand cmd = new SqlCommand(q, con);

                object result = cmd.ExecuteScalar(); // Check for NULL value

                int i = (result == DBNull.Value || result == null) ? 0 : Convert.ToInt32(result);
                i++; // Increment order number

                string oId = "K" + i.ToString("D3"); // Format as K001, K002, etc.
                txtOrder_Id.Text = oId;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblOrderTime.Text = DateTime.Now.ToLongTimeString();
            lblOrderDate.Text = DateTime.Now.ToShortDateString();
        }

        private void txtOrder_Id_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string q = "Select * from ITEM where ITEM_ID= '" + boxSelectItem.Text + "'";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                String iName = (string)dr["ITEM_Name"].ToString();
                txtItem_Name.Text = iName;

                String iUPrice = (string)dr["ITEM_RetailUnitPrice"].ToString();
                txtItem_UPrice.Text = iUPrice;
            }
            con.Close();
        }
        private DataTable GetOrderViewData()
        {
            DataTable dt = new DataTable();

            // Create columns
            foreach (DataGridViewColumn column in Order_view.Columns)
            {
                dt.Columns.Add(column.Name, column.ValueType ?? typeof(string));
            }

            // Copy rows
            foreach (DataGridViewRow row in Order_view.Rows)
            {
                if (!row.IsNewRow)
                {
                    DataRow dataRow = dt.NewRow();
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        dataRow[cell.OwningColumn.Name] = cell.Value ?? DBNull.Value;
                    }
                    dt.Rows.Add(dataRow);
                }
            }

            return dt;
        }


        private void Order_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        public void getGrandTotal()
        {
            gTotal = 0;
            for (int i = 0; i<Order_view.Rows.Count; i++)
            {
                gTotal = gTotal + Convert.ToInt32(Order_view.Rows[i].Cells[4].Value);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                Order_view.Rows.RemoveAt(this.Order_view.SelectedRows[0].Index);

            }
            catch { }
            getGrandTotal();
            txtGrandTotal.Text = "Rs. " + gTotal;
        }
        private void UpdateStock(string itemId, int qtyToSubtract)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(constring))
                {
                    con.Open();

                    // Make sure you subtract the quantity from stock
                    string query = "UPDATE ITEM SET ITEM_Qty = ITEM_Qty - @Quantity WHERE ITEM_ID = @ItemID";

                    SqlCommand cmd = new SqlCommand(query, con);

                    // Convert Quantity to integer safely
                    int quantity = (int)txtDropQty.Value;

                    // Use item ID directly
                    string itemID = boxSelectItem.Text;

                    cmd.Parameters.AddWithValue("@Quantity", quantity);
                    cmd.Parameters.AddWithValue("@ItemID", itemID);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    SqlCommand checkStock = new SqlCommand("SELECT ITEM_Qty FROM ITEM WHERE ITEM_ID = @ItemID", con);
                    checkStock.Parameters.AddWithValue("@ItemID", itemID);
                    int remainingStock = (int)checkStock.ExecuteScalar();

                    if (remainingStock == 0)
                    {
                        MessageBox.Show("This item is now OUT OF STOCK.", "Stock Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Updating Stock: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument1;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }

        }

       

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);

        }


        private string receiptText;
        private Font printFont = new Font("Courier New", 12);


        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float yPos = 20;
            int leftMargin = 10;
            int lineHeight = 20;

            Image companyLogo = Properties.Resources.ShopingCart; int logoWidth = 150;
            int logoHeight = 60;
            int centerX = (e.PageBounds.Width - logoWidth) / 2;

            // Print the company logo if available
            if (companyLogo != null)
            {
                e.Graphics.DrawImage(companyLogo, leftMargin, yPos, 100, 100);  // x, y, width, height
                yPos += 110; // add space after logo
            }

            // Header
            e.Graphics.DrawString("========== Jc Cables ==========", printFont, Brushes.Black, leftMargin, yPos);
            yPos += lineHeight;

            e.Graphics.DrawString($"Order ID: {txtOrder_Id.Text}", printFont, Brushes.Black, leftMargin, yPos);
            yPos += lineHeight;
            e.Graphics.DrawString($"Date: {lblOrderDate.Text}  Time: {lblOrderTime.Text}", printFont, Brushes.Black, leftMargin, yPos);
            yPos += lineHeight;
            e.Graphics.DrawString($"Customer: {boxSelectCustomer.Text}", printFont, Brushes.Black, leftMargin, yPos);
            yPos += lineHeight;

            e.Graphics.DrawString("===================================", printFont, Brushes.Black, leftMargin, yPos);
            yPos += lineHeight;
            e.Graphics.DrawString("Item        Qty   Price   Total", printFont, Brushes.Black, leftMargin, yPos);
            yPos += lineHeight;
            e.Graphics.DrawString("-----------------------------------", printFont, Brushes.Black, leftMargin, yPos);
            yPos += lineHeight;

            // Items from DataGridView
            foreach (DataGridViewRow row in Order_view.Rows)
            {
                if (!row.IsNewRow)
                {
                    string item = row.Cells[1].Value.ToString().PadRight(10);
                    string qty = row.Cells[3].Value.ToString().PadLeft(4);
                    string price = row.Cells[2].Value.ToString().PadLeft(7);
                    string total = row.Cells[4].Value.ToString().PadLeft(7);
                    e.Graphics.DrawString($"{item} {qty} {price} {total}", printFont, Brushes.Black, leftMargin, yPos);
                    yPos += lineHeight;
                }
            }

            e.Graphics.DrawString("-----------------------------------", printFont, Brushes.Black, leftMargin, yPos);
            yPos += lineHeight;
            e.Graphics.DrawString($"Grand Total: {txtGrandTotal.Text}", printFont, Brushes.Black, leftMargin, yPos);
            yPos += lineHeight;
            e.Graphics.DrawString("===================================", printFont, Brushes.Black, leftMargin, yPos);
            yPos += lineHeight;
            e.Graphics.DrawString("  Thank You! Visit Again!", printFont, Brushes.Black, leftMargin, yPos);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            EmployeeDashboard ob = new EmployeeDashboard();
            ob.Show();
        }

        private void printDocument2_PrintPage(object sender, PrintPageEventArgs e)
        {

        }

        private void btnPrintPreview_Click(object sender, EventArgs e)
        {
            printDocument1.PrintPage -= printDocument1_PrintPage;  // Prevent multiple subscriptions
            printDocument1.PrintPage += printDocument1_PrintPage;  // Assign event


            printDocument1.DefaultPageSettings.PaperSize = new PaperSize("Custom", 450, 600); // Adjust for 80mm thermal printer

            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.WindowState = FormWindowState.Maximized;
            printPreviewDialog1.ShowDialog();
        }

        private void QuickSale_Click(object sender, EventArgs e)
        {
            // Disable the main form to prevent interaction
            this.Enabled = false;

            // Open the quick sale form
            QuickSaleForm quickForm = new QuickSaleForm();

            // Use FormClosed event to re-enable the main form when quick sale is done
            quickForm.FormClosed += (s, args) => {
                this.Enabled = true;
                this.Activate();
            };

            quickForm.Show();
        }

        private void txtItem_UPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void txtGrandTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddToCart_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(constring))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT ITEM_Qty FROM ITEM WHERE ITEM_ID = @ItemID", conn);
                cmd.Parameters.AddWithValue("@ItemID", boxSelectItem.Text);

                object result = cmd.ExecuteScalar();
                int Stock = 0;

                if (result != null && result != DBNull.Value)
                {
                    Stock = Convert.ToInt32(result);
                }

                conn.Close();

                if (!string.IsNullOrWhiteSpace(txtTotal.Text) && txtTotal.Text != "0")
                {
                    if (txtDropQty.Value >= 1)
                    {
                        if ((int)txtDropQty.Value <= Stock)
                        {
                            if (!string.IsNullOrWhiteSpace(txtItem_Name.Text) &&
                                !string.IsNullOrWhiteSpace(txtItem_UPrice.Text) &&
                                !string.IsNullOrWhiteSpace(txtCustID.Text) &&
                                !string.IsNullOrWhiteSpace(txtCust_City.Text) &&
                                !string.IsNullOrWhiteSpace(txtCust_Contact.Text))
                            {
                                int check = 0;

                                for (int i = 0; i < Order_view.Rows.Count; i++)
                                {
                                    // Ensure the DataGridView cell is not null before accessing it
                                    if (Order_view.Rows[i].Cells[0].Value != null &&
                                        boxSelectItem.Text == Order_view.Rows[i].Cells[0].Value.ToString())
                                    {
                                        int existingQty = 0, existingTotal = 0;

                                        // Ensure safe conversion
                                        if (Order_view.Rows[i].Cells[3].Value != null)
                                            int.TryParse(Order_view.Rows[i].Cells[3].Value.ToString(), out existingQty);

                                        if (Order_view.Rows[i].Cells[4].Value != null)
                                            int.TryParse(Order_view.Rows[i].Cells[4].Value.ToString(), out existingTotal);

                                        int newQty = (int)txtDropQty.Value + existingQty;
                                        int newTotal = Convert.ToInt32(txtTotal.Text) + existingTotal;

                                        DataGridViewRow newdata = Order_view.Rows[i];
                                        newdata.Cells[0].Value = boxSelectItem.Text;
                                        newdata.Cells[1].Value = txtItem_Name.Text;
                                        newdata.Cells[2].Value = txtItem_UPrice.Text;
                                        newdata.Cells[3].Value = newQty;
                                        newdata.Cells[4].Value = newTotal;

                                        check = 1;
                                        break;
                                    }
                                }

                                if (check == 0)
                                {
                                    int n = Order_view.Rows.Add();
                                    Order_view.Rows[n].Cells[0].Value = boxSelectItem.Text;
                                    Order_view.Rows[n].Cells[1].Value = txtItem_Name.Text;
                                    Order_view.Rows[n].Cells[2].Value = txtItem_UPrice.Text;
                                    Order_view.Rows[n].Cells[3].Value = txtDropQty.Value.ToString();
                                    Order_view.Rows[n].Cells[4].Value = txtTotal.Text;
                                }

                                getGrandTotal();
                                txtGrandTotal.Text = "Rs. " + gTotal;

                                //UpdateStock();
                                txtItem_Name.Text = "";
                                txtItem_UPrice.Text = "";
                                txtTotal.Text = "";
                                txtDropQty.Value = 1;
                            }
                            else
                            {
                                MessageBox.Show("Missing Information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Not Enough In the Stock", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Minimum Quantity needs to be 1", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Minimum Quantity needs to be 1", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void boxSelectItem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void genQutation_Click(object sender, EventArgs e)
        {
            string customerName = boxSelectCustomer.Text;
            decimal totalAmount;

            if (!decimal.TryParse(txtGrandTotal.Text.Replace(",", "").Replace("Rs.", "").Trim(), out totalAmount))
            {
                MessageBox.Show("Invalid total amount format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.Hide(); // Hide current PlaceOrder form
            QuotationForm2 qForm = new QuotationForm2(Order_view, customerName, totalAmount, this);
            qForm.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void CalculateTotal()
        {
            if (!string.IsNullOrEmpty(txtItem_UPrice.Text) && txtDropQty.Value > 0)
            {
                if (decimal.TryParse(txtItem_UPrice.Text, out decimal unitPrice))
                {
                    decimal total = unitPrice * txtDropQty.Value;
                    txtTotal.Text = total.ToString();
                }
                else
                {
                    txtTotal.Text = "";
                }
            }
            else
            {
                txtTotal.Text = "";
            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (gTotal == 0 || txtCustID.Text == "" || txtCust_City.Text == "" || txtCust_Contact.Text == "")
            {
                MessageBox.Show("Missing Information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                getGrandTotal();

                using (SqlConnection con = new SqlConnection(constring))
                {
                    con.Open();

                    // Use parameterized query to avoid SQL injection
                    string q = "EXEC PLACE_ORDER @OrderID, @OrderDate, @OrderTime, @CustID, @OrderTotal, @Bill";

                    using (SqlCommand cmd = new SqlCommand(q, con))
                    {
                        cmd.Parameters.AddWithValue("@OrderID", txtOrder_Id.Text);
                        cmd.Parameters.AddWithValue("@OrderDate", DateTime.Now.Date); // inserts today's correct date

                        cmd.Parameters.AddWithValue("@OrderTime", lblOrderTime.Text);
                        cmd.Parameters.AddWithValue("@CustID", txtCustID.Text);
                        cmd.Parameters.AddWithValue("@OrderTotal", gTotal);
                        cmd.Parameters.AddWithValue("@Bill", gTotal);  // Assuming Order Total is the Bill

                        cmd.ExecuteNonQuery();

                    }


                    // Insert into ORDER_DETAILS
                    for (int i = 0; i < Order_view.Rows.Count - 1; i++)
                    {
                        string q1 = "INSERT INTO ORDER_DETAILS (ORDER_ID, ITEM_ID, ORDER_QTY, Total_Price) " +
                                    "VALUES (@OrderID, @ItemID, @OrderQty, @TotalPrice)";

                        using (SqlCommand cmd1 = new SqlCommand(q1, con))
                        {
                            cmd1.Parameters.AddWithValue("@OrderID", txtOrder_Id.Text);
                            cmd1.Parameters.AddWithValue("@ItemID", Order_view.Rows[i].Cells[0].Value);
                            cmd1.Parameters.AddWithValue("@OrderQty", Order_view.Rows[i].Cells[3].Value);
                            cmd1.Parameters.AddWithValue("@TotalPrice", Order_view.Rows[i].Cells[4].Value);

                            cmd1.ExecuteNonQuery();
                        }

                        UpdateStock(Order_view.Rows[i].Cells[0].Value.ToString(), Convert.ToInt32(Order_view.Rows[i].Cells[3].Value));

                    }

                    Order_view.Rows.Clear();
                }

                setOrderId();

                // Clear fields
                txtCustID.Text = "";
                txtItem_Name.Text = "";
                txtItem_UPrice.Text = "";
                txtCust_City.Text = "";
                txtCust_Contact.Text = "";
                txtTotal.Text = "";
            }
        }


        }


}



