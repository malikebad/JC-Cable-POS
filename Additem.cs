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
    public partial class Additem : Form
    {
        public Additem()
        {
            InitializeComponent();
            setItemId();
        }

        public string constring = "Data Source=localhost;Initial Catalog=DBProject;Integrated Security=True;";

        public void disp_data()
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string q = "SELECT * FROM ITEM";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            Item_view.DataSource = dt;
            con.Close();
        }
        public void setItemId()
        {

            using (SqlConnection con = new SqlConnection(constring))
            {
                con.Open();
                string q = "SELECT MAX(RIGHT(ITEM_ID, 3)) AS ExtractString FROM ITEM";
                SqlCommand cmd = new SqlCommand(q, con);

                object result = cmd.ExecuteScalar(); // Fetch the result

                if (result == DBNull.Value || result == null) // Check if the result is NULL
                {
                    result = "000"; // Default value if no records exist
                }

                int i = Convert.ToInt32(result);
                i++;
                string oId = "I" + i.ToString("D3"); // Ensure the format remains I001, I002, etc.
                txtItem_Id.Text = oId;
            }
        }


        private void Additem_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAdd_Item_Click(object sender, EventArgs e)
        {
            if (txtItem_Id.Text == "" || txtItem_Name.Text == "" || txtItem_PurchaseUnitPrice.Text == "" || txtItem_Quantity.Text == "" || txtItem_Retail.Text == "" || txtItem_BatchDate.Text == "" || txtSupp_ID.Text == "" || txtBatch_ID.Text == "")
            {
                MessageBox.Show("Information Missing", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlConnection con = new SqlConnection(constring);
                con.Open();
                string q2 = "Select Count(*) from SUPPLIER where SUPP_ID = '" + txtSupp_ID.Text + "'";
                SqlCommand cmd2 = new SqlCommand(q2, con);
                int count2 = 0;
                count2 = Convert.ToInt32(cmd2.ExecuteScalar());
                if (count2 == 1)
                {
                    string q1 = "Select Count(*) from ITEM where ITEM_ID = '" + txtItem_Id.Text + "'";
                    SqlCommand cmd1 = new SqlCommand(q1, con);
                    int count = 0;
                    count = Convert.ToInt32(cmd1.ExecuteScalar());
                    if (count == 0)
                    {
                        string q = "INSERT INTO ITEM(ITEM_ID,SUPP_ID,ITEM_Name,ITEM_PurchaseUnitPrice,ITEM_RetailUnitPrice,ITEM_Qty,ITEM_BatchID,ITEM_BatchDate) VALUES('" + txtItem_Id.Text.ToString() + "','" + txtSupp_ID.Text.ToString() + "','" + txtItem_Name.Text.ToString() + "','" + txtItem_PurchaseUnitPrice.Text.ToString() + "','" + txtItem_Retail.Text.ToString() + "','" + txtItem_Quantity.Text.ToString() + "','" + txtBatch_ID.Text.ToString() + "','" + txtItem_BatchDate.Text.ToString() + "')";
                        SqlCommand cmd = new SqlCommand(q, con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Added Succesfully...!");
                        txtItem_Id.Text = "";
                        txtSupp_ID.Text = "";
                        txtItem_Name.Text = "";
                        txtItem_PurchaseUnitPrice.Text = "";
                        txtItem_Retail.Text = "";
                        txtItem_Quantity.Text = "";
                        txtBatch_ID.Text = "";
                        txtItem_BatchDate.Text = "";
                        con.Close();
                        setItemId();
                    }
                    else
                    {
                        MessageBox.Show("Record already exist with that ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        con.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Supplier does not exit","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    con.Close();
                }
            }

            disp_data();
        }

        private void btnSearch_Item_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string q1 = "Select Count(*) from ITEM where ITEM_ID = '" + txtItem_Id.Text + "'";
            SqlCommand cmd1 = new SqlCommand(q1, con);
            int count = 0;
            count = Convert.ToInt32(cmd1.ExecuteScalar());
            if (count == 1)
            {
                string q = "SELECT * FROM ITEM WHERE ITEM_ID = ('" + txtItem_Id.Text.ToString() + "')";
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                Item_view.DataSource = dt;
                txtItem_Id.Text = "";
                txtSupp_ID.Text = "";
                txtItem_Name.Text = "";
                txtItem_PurchaseUnitPrice.Text = "";
                txtItem_Retail.Text = "";
                txtItem_Quantity.Text = "";
                txtBatch_ID.Text = "";
                txtItem_BatchDate.Text = "";
                con.Close();
                setItemId();
            }
            else
            {
                MessageBox.Show("No Record found against that ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }

        }

        private void btnUpdate_Item_Click(object sender, EventArgs e)
        {
            if (txtItem_Id.Text == "" || txtItem_Name.Text == "" || txtItem_PurchaseUnitPrice.Text == "" || txtItem_Quantity.Text == "" || txtItem_Retail.Text == "" || txtItem_BatchDate.Text == "" || txtSupp_ID.Text == "" || txtBatch_ID.Text == "")
            {
                MessageBox.Show("Information Missing", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlConnection con = new SqlConnection(constring);
                con.Open();
                string q2 = "Select Count(*) from SUPPLIER where SUPP_ID = '" + txtSupp_ID.Text + "'";
                SqlCommand cmd2 = new SqlCommand(q2, con);
                int count2 = 0;
                count2 = Convert.ToInt32(cmd2.ExecuteScalar());
                if (count2 == 1)
                {
                    string q1 = "Select Count(*) from ITEM where ITEM_ID = '" + txtItem_Id.Text + "'";
                    SqlCommand cmd1 = new SqlCommand(q1, con);
                    int count = 0;
                    count = Convert.ToInt32(cmd1.ExecuteScalar());
                    if (count == 1)
                    {
                        string q = "UPDATE ITEM SET SUPP_ID = @SuppId, ITEM_Name = @ItemName, " +
           "ITEM_PurchaseUnitPrice = @PurchaseUP, ITEM_RetailUnitPrice = @RetailUP, " +
           "ITEM_Qty = @ItemQty, ITEM_BatchID = @BatchID, ITEM_BatchDate = @BatchDate " +
           "WHERE ITEM_ID = @ItemId";

                        using (SqlCommand cmd = new SqlCommand(q, con))
                        {
                            cmd.Parameters.AddWithValue("@SuppId", txtSupp_ID.Text);
                            cmd.Parameters.AddWithValue("@ItemName", txtItem_Name.Text);
                            cmd.Parameters.AddWithValue("@PurchaseUP", Convert.ToDecimal(txtItem_PurchaseUnitPrice.Text)); // Convert to Decimal
                            cmd.Parameters.AddWithValue("@RetailUP", Convert.ToDecimal(txtItem_Retail.Text)); // Convert to Decimal
                            cmd.Parameters.AddWithValue("@ItemQty", Convert.ToInt32(txtItem_Quantity.Text)); // Convert to Int
                            cmd.Parameters.AddWithValue("@BatchID", txtBatch_ID.Text);
                            cmd.Parameters.AddWithValue("@BatchDate", DateTime.Parse(txtItem_BatchDate.Text)); // Convert to DateTime
                            cmd.Parameters.AddWithValue("@ItemId", txtItem_Id.Text);

                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Update Successfully...!");

                    }
                    else
                    {
                        MessageBox.Show("No Record found against that ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        con.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Supplier does not exit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.Close();
                }
            }
            disp_data();
        }

        private void btnDelete_Item_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("If you delete this item then the corresponding orders data would also be deleted do yo wish to continue", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                MessageBox.Show("Operation Confirmed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (txtItem_Id.Text == "")
                {
                    MessageBox.Show("Information Missing Please provide only Item Id", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    SqlConnection con = new SqlConnection(constring);
                    con.Open();
                    string q1 = "Select Count(*) from ITEM where ITEM_ID = '" + txtItem_Id.Text + "'";
                    SqlCommand cmd1 = new SqlCommand(q1, con);
                    int count = 0;
                    count = Convert.ToInt32(cmd1.ExecuteScalar());
                    if (count == 1)
                    {
                        string q = "DELETE FROM ITEM WHERE ITEM_ID = ('" + txtItem_Id.Text.ToString() + "')";
                        SqlCommand cmd = new SqlCommand(q, con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Deleted Succesfully...!");
                        txtItem_Id.Text = "";
                        txtSupp_ID.Text = "";
                        txtItem_Name.Text = "";
                        txtItem_PurchaseUnitPrice.Text = "";
                        txtItem_Retail.Text = "";
                        txtItem_Quantity.Text = "";
                        txtBatch_ID.Text = "";
                        txtItem_BatchDate.Text = "";
                        con.Close();
                        setItemId();
                    }
                    else
                    {
                        MessageBox.Show("No Record found against that ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        con.Close();
                    }
                }

                disp_data();
            }
            else
            {
                MessageBox.Show("Operation canceled","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void Item_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            disp_data();
        }

        private void txtItem_Retail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtItem_PurchaseUnitPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtItem_Quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            dashboard ob = new dashboard();
            ob.Show();
        }
    }
}



