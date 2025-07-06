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

namespace Shop_Management__System
{
    public partial class dashForm : Form
    {
        public string constring = "Data Source=localhost;Initial Catalog=DBProject;Integrated Security=True;";

        public dashForm()
        {
            InitializeComponent();
            SqlConnection con = new SqlConnection(constring);
            con.Open();

            string q = "select count(CUST_ID) as general from CUSTOMER";
            SqlCommand cmd = new SqlCommand(q, con);
            object resultC = cmd.ExecuteScalar();
            int rows_countC = (resultC != DBNull.Value) ? Convert.ToInt32(resultC) : 0;
            cmd.Dispose();
            totalCustomers.Text = rows_countC.ToString();

            string q1 = "select count(ORDER_ID) as general from ORDERS";
            SqlCommand cmd1 = new SqlCommand(q1, con);
            object resultO = cmd1.ExecuteScalar();
            int rows_countO = (resultO != DBNull.Value) ? Convert.ToInt32(resultO) : 0;
            cmd1.Dispose();
            valuEOrder.Text = rows_countO.ToString();

            string q2 = "select sum(ORDER_QTY) as general from ORDER_DETAILS";
            SqlCommand cmd2 = new SqlCommand(q2, con);
            object resultQ = cmd2.ExecuteScalar();
            int rows_countQ = (resultQ != DBNull.Value) ? Convert.ToInt32(resultQ) : 0;
            cmd2.Dispose();
            valueSoldItems.Text = rows_countQ.ToString();

            string q3 = "select sum(BILL) as general from ORDERS";
            SqlCommand cmd3 = new SqlCommand(q3, con);
            object resultS = cmd3.ExecuteScalar();
            int rows_countS = (resultS != DBNull.Value) ? Convert.ToInt32(resultS) : 0;
            cmd3.Dispose();
            Value_Sales.Text = rows_countS.ToString();

            string q4 = "select count(*) as general from ITEM where ITEM_Qty = 0";
            SqlCommand cmd4 = new SqlCommand(q4, con);
            object resultSt = cmd4.ExecuteScalar();
            int rows_countSt = (resultSt != DBNull.Value) ? Convert.ToInt32(resultSt) : 0;
            cmd4.Dispose();
            countOutOfStock.Text = rows_countSt.ToString();

            con.Close();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {

        }

        private void btnSales_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {

        }
    }
}



