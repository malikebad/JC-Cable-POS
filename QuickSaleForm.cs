using DocumentFormat.OpenXml.Office.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace Shop_Management__System
{



    public partial class QuickSaleForm: Form

    {
        PrintDocument printDocument = new PrintDocument();

        Font printFont = new Font("Courier New", 10);
        Image companyLogo = Properties.Resources.ShopingCart;

        public QuickSaleForm()
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

        public string constring = "Data Source=DESKTOP-0M59JG5;Initial Catalog=DBProject;Integrated Security=True;";

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

        private void QuicjOrderBtn_Click(object sender, EventArgs e)
        {
            if (Order_view.Rows.Count == 0)
            {
                MessageBox.Show("Cart is empty. Please add items first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection con = new SqlConnection(constring))
            {
                con.Open();

                string orderID = txtOrder_Id.Text;
                DateTime orderDateTime = DateTime.Now;

                foreach (DataGridViewRow row in Order_view.Rows)
                {
                    if (row.IsNewRow) continue;

                    string itemID = row.Cells[0].Value?.ToString();
                    string itemName = row.Cells[1].Value?.ToString();
                    string unitPriceStr = row.Cells[2].Value?.ToString();
                    string quantityStr = row.Cells[3].Value?.ToString();
                    string totalPriceStr = row.Cells[4].Value?.ToString();

                    if (decimal.TryParse(unitPriceStr, out decimal unitPrice) &&
                        int.TryParse(quantityStr, out int quantity) &&
                        decimal.TryParse(totalPriceStr, out decimal totalPrice))
                    {
                        string insertQuery = @"INSERT INTO QUICKSALE 
                (OrderID, OrderDateTime, ItemID, ItemName, UnitPrice, Quantity, TotalPrice)
                VALUES 
                (@OrderID, @OrderDateTime, @ItemID, @ItemName, @UnitPrice, @Quantity, @TotalPrice)";

                        using (SqlCommand cmd = new SqlCommand(insertQuery, con))
                        {
                            cmd.Parameters.AddWithValue("@OrderID", orderID);
                            cmd.Parameters.AddWithValue("@OrderDateTime", orderDateTime);  // ✅ Here!
                            cmd.Parameters.AddWithValue("@ItemID", itemID);
                            cmd.Parameters.AddWithValue("@ItemName", itemName);
                            cmd.Parameters.AddWithValue("@UnitPrice", unitPrice);
                            cmd.Parameters.AddWithValue("@Quantity", quantity);
                            cmd.Parameters.AddWithValue("@TotalPrice", totalPrice);

                            cmd.ExecuteNonQuery();  // ✅ Executes for each item
                        }
                        UpdateStock(itemID, quantity);

                    }
                }

                MessageBox.Show("Quick Order Saved Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Order_view.Rows.Clear();
                setOrderId();  // Prepare next Order ID
            }
        }
        private void UpdateStock(string itemId, int qtyToSubtract)
        {
            using (SqlConnection con = new SqlConnection(constring))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE ITEM SET ITEM_Qty = ITEM_Qty - @qty WHERE ITEM_ID = @id", con);
                cmd.Parameters.AddWithValue("@qty", qtyToSubtract);
                cmd.Parameters.AddWithValue("@id", itemId);
                cmd.ExecuteNonQuery();
            }
        }

        private void btnSearch_Cust_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string q = "Select * from CUSTOMER where CUST_Name= '" + boxSelectCustomer.Text + "'";
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
        private void txtDropQty_ValueChanged_1(object sender, EventArgs e)
        {

            CalculateTotal();

        }
        private void CalculateTotal()
        {
            if (!string.IsNullOrEmpty(txtItem_UPrice.Text) && txtDropQty.Value > 0)
            {
                if (decimal.TryParse(txtItem_UPrice.Text, out decimal unitPrice))
                {
                    decimal total = unitPrice * txtDropQty.Value;
                    txtTotal.Text = total.ToString("0.00");
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

        private void Order_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void getGrandTotal()
        {
            gTotal = 0;

            foreach (DataGridViewRow row in Order_view.Rows)
            {
                if (row.IsNewRow) continue; // skip the last empty row used for input

                object value = row.Cells[4].Value;
                if (value != null && decimal.TryParse(value.ToString(), out decimal total))
                {
                    gTotal += (int)total;
                }
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
        private void UpdateStock()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(constring))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("EXEC Update_Qty @Quantity, @ItemID", con);

                    // Convert Quantity to integer safely
                    int quantity = (int)txtDropQty.Value;

                    // Extract ItemID correctly
                    string itemIDText = boxSelectItem.Text.Trim();

                    // Use Regex to Extract Only Numeric ID (If Text Contains Both Name & ID)
                    Match match = Regex.Match(itemIDText, @"\d+$"); // Extracts the last numbers
                    if (!match.Success)
                    {
                        MessageBox.Show("Invalid Item ID format. Please select a valid item.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    int itemID = int.Parse(match.Value);

                    cmd.Parameters.AddWithValue("@Quantity", quantity);
                    cmd.Parameters.AddWithValue("@ItemID", itemID);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error Updating Stock: " + Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnPrint_Click(object sender, EventArgs e)
        {
            // Set paper size for thermal (280 = ~80mm)
            printDocument1.DefaultPageSettings.PaperSize = new PaperSize("Receipt", 280, 800);
            printDocument1.PrintPage += printDocument_PrintPage; // ✅ Correct attachment

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
       // private Font printFont = new Font("Courier New", 12);


        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int y = 10;
            int leftMargin = 10;
            int lineHeight = 20;
            Font font = new Font("Courier New", 10);

            // Optional Logo
            if (companyLogo != null)
            {
                e.Graphics.DrawImage(companyLogo, leftMargin, y, 100, 60);
                y += 70;
            }

            e.Graphics.DrawString("==== JC Cables ====", font, Brushes.Black, leftMargin, y); y += lineHeight;
            e.Graphics.DrawString($"Order ID: {txtOrder_Id.Text}", font, Brushes.Black, leftMargin, y); y += lineHeight;
            e.Graphics.DrawString($"Date: {lblOrderDate.Text} {lblOrderTime.Text}", font, Brushes.Black, leftMargin, y); y += lineHeight;

            e.Graphics.DrawString("-----------------------------", font, Brushes.Black, leftMargin, y); y += lineHeight;
            e.Graphics.DrawString("Item      Qty  Price  Total", font, Brushes.Black, leftMargin, y); y += lineHeight;
            e.Graphics.DrawString("-----------------------------", font, Brushes.Black, leftMargin, y); y += lineHeight;

            foreach (DataGridViewRow row in Order_view.Rows)
            {
                if (!row.IsNewRow)
                {
                    string item = row.Cells[1].Value?.ToString().PadRight(8).Substring(0, 8);
                    string qty = row.Cells[3].Value?.ToString().PadLeft(3);
                    string price = row.Cells[2].Value?.ToString().PadLeft(6);
                    string total = row.Cells[4].Value?.ToString().PadLeft(7);

                    string line = $"{item} {qty} {price} {total}";
                    e.Graphics.DrawString(line, font, Brushes.Black, leftMargin, y);
                    y += lineHeight;
                }
            }

            y += 5;
            e.Graphics.DrawString("-----------------------------", font, Brushes.Black, leftMargin, y); y += lineHeight;
            e.Graphics.DrawString($"Total: {txtGrandTotal.Text}", new Font("Courier New", 11, FontStyle.Bold), Brushes.Black, leftMargin, y); y += lineHeight;
            e.Graphics.DrawString("Thank you for shopping!", font, Brushes.Black, leftMargin, y); y += lineHeight;
            e.Graphics.DrawString("Visit again!", font, Brushes.Black, leftMargin, y);
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

        private void btnAddToCart_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(constring))
            {
                conn.Open();

                // Step 1: Get current stock for the item
                SqlCommand cmd = new SqlCommand("SELECT ITEM_Qty FROM ITEM WHERE ITEM_ID = @ItemID", conn);
                cmd.Parameters.AddWithValue("@ItemID", boxSelectItem.Text);
                object result = cmd.ExecuteScalar();

                int stock = 0;
                if (result != null && result != DBNull.Value)
                    stock = Convert.ToInt32(result);

                // Step 2: Safely calculate total here in case event didn't fire
                int selectedQty = (int)txtDropQty.Value;
                decimal unitPrice = 0;
                decimal total = 0;

                if (decimal.TryParse(txtItem_UPrice.Text, out unitPrice))
                {
                    total = selectedQty * unitPrice;
                    txtTotal.Text = total.ToString("0.00");
                }
                else
                {
                    MessageBox.Show("Invalid unit price.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Step 3: Validation
                if (selectedQty < 1)
                {
                    MessageBox.Show("Minimum Quantity needs to be 1", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (selectedQty > stock)
                {
                    MessageBox.Show("Not Enough In the Stock", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtItem_Name.Text) ||
                    string.IsNullOrWhiteSpace(txtItem_UPrice.Text) ||
                    string.IsNullOrWhiteSpace(txtCustID.Text) ||
                    string.IsNullOrWhiteSpace(txtCust_City.Text) ||
                    string.IsNullOrWhiteSpace(txtCust_Contact.Text))
                {
                    MessageBox.Show("Missing Information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Step 4: Check if item is already in cart
                bool found = false;
                for (int i = 0; i < Order_view.Rows.Count; i++)
                {
                    if (Order_view.Rows[i].Cells[0].Value != null &&
                        boxSelectItem.Text == Order_view.Rows[i].Cells[0].Value.ToString())
                    {
                        // Update quantity and total
                        int existingQty = Convert.ToInt32(Order_view.Rows[i].Cells[3].Value);
                        decimal existingTotal = Convert.ToDecimal(Order_view.Rows[i].Cells[4].Value);

                        int newQty = selectedQty + existingQty;
                        decimal newTotal = total + existingTotal;

                        Order_view.Rows[i].Cells[3].Value = newQty.ToString();
                        Order_view.Rows[i].Cells[4].Value = newTotal.ToString("0.00");
                        found = true;
                        break;
                    }
                }

                // Step 5: If not found, add new row
                if (!found)
                {
                    int rowIndex = Order_view.Rows.Add();
                    Order_view.Rows[rowIndex].Cells[0].Value = boxSelectItem.Text;
                    Order_view.Rows[rowIndex].Cells[1].Value = txtItem_Name.Text;
                    Order_view.Rows[rowIndex].Cells[2].Value = unitPrice.ToString("0.00");
                    Order_view.Rows[rowIndex].Cells[3].Value = selectedQty.ToString();
                    Order_view.Rows[rowIndex].Cells[4].Value = total.ToString("0.00");
                }

                // Step 6: Update grand total
                getGrandTotal();
                txtGrandTotal.Text = "Rs. " + gTotal;

                // Step 7: Update stock in DB
                UpdateStock();

                // Step 8: Reset input fields
                txtItem_Name.Text = "";
                txtItem_UPrice.Text = "";
                txtTotal.Text = "";
                txtDropQty.Value = 1;
            }
        }

        private void btnSearch_Cust_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string q = "Select * from CUSTOMER where CUST_Name= '" + boxSelectCustomer.Text + "'";
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

        private void btnSearch_item_Click_1(object sender, EventArgs e)
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

        private void btnAddToCart_Click(object sender, EventArgs e)
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

                // conn.Close();  ← not needed here; 'using' will close it

                // Check if total is not empty or 0
                if (!string.IsNullOrWhiteSpace(txtTotal.Text) && txtTotal.Text != "0")
                {
                    int selectedQty = (int)txtDropQty.Value;  // ✅ cast to int

                    // Optional debug
                    // MessageBox.Show("Selected Quantity = " + selectedQty);

                    if (selectedQty >= 1)
                    {
                        if (selectedQty <= Stock)
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
                                    if (Order_view.Rows[i].Cells[0].Value != null &&
                                        boxSelectItem.Text == Order_view.Rows[i].Cells[0].Value.ToString())
                                    {
                                        int existingQty = 0, existingTotal = 0;

                                        if (Order_view.Rows[i].Cells[3].Value != null)
                                            int.TryParse(Order_view.Rows[i].Cells[3].Value.ToString(), out existingQty);

                                        if (Order_view.Rows[i].Cells[4].Value != null)
                                            int.TryParse(Order_view.Rows[i].Cells[4].Value.ToString(), out existingTotal);

                                        int newQty = selectedQty + existingQty;
                                        int newTotal = (int)(decimal.Parse(txtTotal.Text)) + existingTotal;


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
                                    Order_view.Rows[n].Cells[3].Value = selectedQty.ToString();
                                    Order_view.Rows[n].Cells[4].Value = txtTotal.Text;
                                }

                                getGrandTotal();
                                txtGrandTotal.Text = "Rs. " + gTotal;

                                UpdateStock();

                                // Clear input fields
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
            using (SqlConnection con = new SqlConnection(constring))
            {
                con.Open();
                string query = "SELECT ITEM_Name, ITEM_RetailUnitPrice FROM ITEM WHERE ITEM_ID = @ItemID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ItemID", boxSelectItem.Text);

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtItem_Name.Text = dr["ITEM_Name"].ToString();
                    txtItem_UPrice.Text = dr["ITEM_RetailUnitPrice"].ToString();
                }
            }

            CalculateTotal();  // ✅ Recalculate total when item changes
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (gTotal == 0)
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
                        cmd.Parameters.AddWithValue("@OrderDate", lblOrderDate.Text);
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

        private void t(object sender, EventArgs e)
        {

        }

        private void Order_view_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCheckOut_Click_1(object sender, EventArgs e)
        {

        }

        private void QuickSale_Click_1(object sender, EventArgs e)
        {

        }

        private void btnPrintPreview_Click_1(object sender, EventArgs e)
        {

        }
        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            int y = 10;
            int leftMargin = 10;
            int lineHeight = 20;
            Font font = new Font("Courier New", 10);

            // Optional Logo
            if (companyLogo != null)
            {
                e.Graphics.DrawImage(companyLogo, leftMargin, y, 100, 60);
                y += 70;
            }

            e.Graphics.DrawString("==== JC Cables ====", font, Brushes.Black, leftMargin, y); y += lineHeight;
            e.Graphics.DrawString($"Order ID: {txtOrder_Id.Text}", font, Brushes.Black, leftMargin, y); y += lineHeight;
            e.Graphics.DrawString($"Date: {lblOrderDate.Text} {lblOrderTime.Text}", font, Brushes.Black, leftMargin, y); y += lineHeight;

            e.Graphics.DrawString("-----------------------------", font, Brushes.Black, leftMargin, y); y += lineHeight;
            e.Graphics.DrawString("Item      Qty  Price  Total", font, Brushes.Black, leftMargin, y); y += lineHeight;
            e.Graphics.DrawString("-----------------------------", font, Brushes.Black, leftMargin, y); y += lineHeight;

            foreach (DataGridViewRow row in Order_view.Rows)
            {
                if (!row.IsNewRow)
                {
                    string item = row.Cells[1].Value?.ToString().PadRight(8).Substring(0, 8);
                    string qty = row.Cells[3].Value?.ToString().PadLeft(3);
                    string price = row.Cells[2].Value?.ToString().PadLeft(6);
                    string total = row.Cells[4].Value?.ToString().PadLeft(7);

                    string line = $"{item} {qty} {price} {total}";
                    e.Graphics.DrawString(line, font, Brushes.Black, leftMargin, y);
                    y += lineHeight;
                }
            }

            y += 5;
            e.Graphics.DrawString("-----------------------------", font, Brushes.Black, leftMargin, y); y += lineHeight;
            e.Graphics.DrawString($"Total: {txtGrandTotal.Text}", new Font("Courier New", 11, FontStyle.Bold), Brushes.Black, leftMargin, y); y += lineHeight;
            e.Graphics.DrawString("Thank you for shopping!", font, Brushes.Black, leftMargin, y); y += lineHeight;
            e.Graphics.DrawString("Visit again!", font, Brushes.Black, leftMargin, y);
        }
        


        private void btnPrint_Click_1(object sender, EventArgs e)
        {
            printDocument.PrintPage -= printDocument_PrintPage; // Prevent duplicates
            printDocument.PrintPage += printDocument_PrintPage;

            // Set paper size for 80mm printer
            printDocument.DefaultPageSettings.PaperSize = new PaperSize("Receipt", 280, 1000);

            PrintDialog printDialog = new PrintDialog
            {
                Document = printDocument
            };

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    printDocument.Print();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Print failed: " + ex.Message);
                }
            }
        }

       

        private void btnRemove_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void printDocument2_PrintPage_1(object sender, PrintPageEventArgs e)
        {
            printDocument.PrintPage += printDocument_PrintPage;


        }

        private void QuickSaleForm_Load(object sender, EventArgs e)
        {
            txtCustID.Text = "GUEST";
            txtCust_Contact.Text = "N/A";
            txtCust_City.Text = "N/A";
            boxSelectCustomer.Visible = false;
            txtCust_Contact.Visible = false;
            txtCust_City.Visible = false;
            txtCustID.Visible = false;
            btnSearch_Cust.Visible = false;
            boxSelectItem.SelectedIndexChanged += boxSelectItem_SelectedIndexChanged;
            txtDropQty.ValueChanged += txtDropQty_ValueChanged_1;
            printDocument.PrintPage += printDocument_PrintPage;



        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }
    }
}
