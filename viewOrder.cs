using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Shop_Management__System
{
    public partial class viewOrder : Form
    {
        string connectionString = "Data Source=localhost;Initial Catalog=DBProject;Integrated Security=True;"; // Replace with your actual connection string
       

        public viewOrder()
        {
            InitializeComponent();
           
            
        }
        private DataTable allOrders;
        private void viewOrder_Load(object sender, EventArgs e)
        {
            LoadOrders();
           
            ConfigureOrderGrid();
            ConfigureOrderDetailsGrid();
        }

        private void LoadOrders()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                SELECT 
                    o.ORDER_ID,
                    o.ORDER_DATE,
                    o.ORDER_TIME,
                    o.CUST_ID,
                    c.CUST_NAME,
                    o.BILL,
                    o.EMP_ID
                FROM 
                    ORDERS o
                JOIN 
                    CUSTOMER c ON o.CUST_ID = c.CUST_ID
                ORDER BY 
                    o.ORDER_DATE DESC";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    orders_view.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading orders: " + ex.Message);
            }
        }
        private void ConfigureOrderGrid()
        {
            orders_view.AutoGenerateColumns = false;
            orders_view.Columns.Clear();

            orders_view.Columns.Add(new DataGridViewTextBoxColumn { Name = "ORDER_ID", HeaderText = "Order ID", DataPropertyName = "ORDER_ID" });
            orders_view.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Order Date", DataPropertyName = "ORDER_DATE" });
            orders_view.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Order Time", DataPropertyName = "ORDER_TIME" });
            orders_view.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Customer ID", DataPropertyName = "CUST_ID" });
            orders_view.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Customer Name", DataPropertyName = "CUST_NAME" });
            orders_view.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Bill", DataPropertyName = "BILL" });
            //orders_view.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Employee ID", DataPropertyName = "EMP_ID" });

            orders_view.CellClick += Orders_view_CellClick;
        }
        private void ConfigureOrderDetailsGrid()
        {
            orderDetails_view.AutoGenerateColumns = false;
            orderDetails_view.Columns.Clear();

            orderDetails_view.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Order ID", DataPropertyName = "ORDER_ID" });
            orderDetails_view.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Item ID", DataPropertyName = "ITEM_ID" });
            orderDetails_view.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Quantity", DataPropertyName = "ORDER_QTY" });
            orderDetails_view.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Total Price", DataPropertyName = "TOTAL_PRICE" });
        }
        private void Orders_view_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string orderId = orders_view.Rows[e.RowIndex].Cells["ORDER_ID"].Value.ToString();
                LoadOrderDetails(orderId);
            }
        }

        private void orders_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle cell clicks (optional, for future functionality)
        }
       
        private void LoadOrderDetails(string orderId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                SELECT 
                    ORDER_ID,
                    ITEM_ID,
                    ORDER_QTY,
                    TOTAL_PRICE
                FROM 
                    ORDER_DETAILS
                WHERE 
                    ORDER_ID = @OrderId";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@OrderId", orderId);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No items found for this order.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    orderDetails_view.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading order details: " + ex.Message);
            }
        }

        private void orderDetails_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
           

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
          
        }
    }
}



