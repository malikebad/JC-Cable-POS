using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using ClosedXML.Excel;
using System.IO;
using System.Windows.Forms;

namespace Shop_Management__System
{
    public partial class ReportSales: Form
    {
        private string connectionString = @"Data Source=localhost;Initial Catalog=DBProject;Integrated Security=True";
        public ReportSales()
        {
            InitializeComponent();
        }

        private void lblTo66_Click(object sender, EventArgs e)
        {

        }
        private void SaveSalesSummary(DateTime startDate, DateTime endDate, decimal totalSales, int totalOrders)
        {
            string reportType;
            int days = (endDate - startDate).Days + 1;

            if (days <= 1)
                reportType = "Daily";
            else if (days <= 7)
                reportType = "Weekly";
            else
                reportType = "Monthly";

            DateTime reportDate = DateTime.Now.Date;

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string insertQuery = @"INSERT INTO SalesReports (ReportType, ReportDate, TotalSales, TotalOrders)
                                       VALUES (@Type, @Date, @Total, @Orders)";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@Type", reportType);
                        cmd.Parameters.AddWithValue("@Date", reportDate);
                        cmd.Parameters.AddWithValue("@Total", totalSales);
                        cmd.Parameters.AddWithValue("@Orders", totalOrders);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show("Sales summary saved successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving summary: " + ex.Message, "Save Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ExportToExcel(DataGridView dgv)
        {
            using (SaveFileDialog sfd = new SaveFileDialog()
            {
                Filter = "Excel Workbook|*.xlsx",
                Title = "Save Report as Excel File"
            })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    var workbook = new XLWorkbook();
                    var worksheet = workbook.Worksheets.Add("Sales Report");

                    // Headers
                    for (int col = 0; col < dgv.Columns.Count; col++)
                    {
                        worksheet.Cell(1, col + 1).Value = dgv.Columns[col].HeaderText;
                        worksheet.Cell(1, col + 1).Style.Font.Bold = true;
                        worksheet.Cell(1, col + 1).Style.Fill.BackgroundColor = XLColor.LightGray;
                    }

                    // Data Rows
                    for (int row = 0; row < dgv.Rows.Count; row++)
                    {
                        for (int col = 0; col < dgv.Columns.Count; col++)
                        {
                            worksheet.Cell(row + 2, col + 1).Value = dgv.Rows[row].Cells[col].Value?.ToString();
                        }
                    }

                    worksheet.Columns().AdjustToContents();
                    workbook.SaveAs(sfd.FileName);
                    MessageBox.Show("Excel file saved successfully!", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            DateTime startDate;
            DateTime endDate;

            
            
            
                startDate = dtpStartDate.Value.Date;
                endDate = dtpEndDate.Value.Date.AddDays(1).AddTicks(-1);  // FIXED: include entire end date
            

            string query = @"
   SELECT 
    O.ORDER_ID,
    CAST(O.ORDER_Date AS DATE) AS OrderDate,
    O.ORDER_Time,
    C.CUST_Name,
    E.EMP_Name,
    I.ITEM_Name,
    OD.ORDER_QTY,
    OD.Total_Price
FROM ORDERS O
INNER JOIN CUSTOMER C ON O.CUST_ID = C.CUST_ID
LEFT JOIN EMPLOYEE E ON O.EMP_ID = E.EMP_ID
INNER JOIN ORDER_DETAILS OD ON O.ORDER_ID = OD.ORDER_ID
INNER JOIN ITEM I ON OD.ITEM_ID = I.ITEM_ID
WHERE CAST(O.ORDER_Date AS DATE) BETWEEN @StartDate AND @EndDate";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@StartDate", startDate);
                    cmd.Parameters.AddWithValue("@EndDate", endDate);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvSalesReport.DataSource = dt;

                    decimal totalSales = 0;
                    int totalOrders = dt.Rows.Count;
                    int totalQty = 0;

                    foreach (DataRow row in dt.Rows)
                    {
                        totalSales += Convert.ToDecimal(row["Total_Price"]);
                        totalQty += Convert.ToInt32(row["ORDER_QTY"]);
                    }

                    lblTotalSales.Text = $"Total Sales: Rs. {totalSales:N2}";
                    lblTotalOrders.Text = $"Total Orders: {totalOrders}";
                    lblTotalQty.Text = $"Total Items Sold: {totalQty}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }



        private void ReportSales_Load(object sender, EventArgs e)
        {
            dgvSalesReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSalesReport.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvSalesReport.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void SaveSalesSummary_Click(object sender, EventArgs e)
        {
            DateTime reportDate = DateTime.Now.Date;
            decimal totalSales = 0;
            int totalOrders = dgvSalesReport.Rows.Count;

            foreach (DataGridViewRow row in dgvSalesReport.Rows)
            {
                if (row.Cells["Total_Price"].Value != DBNull.Value)
                    totalSales += Convert.ToDecimal(row.Cells["Total_Price"].Value);
            }

            string reportType = "";
            TimeSpan span = dtpEndDate.Value.Date - dtpStartDate.Value.Date;
            if (span.TotalDays <= 1)
                reportType = "Daily";
            else if (span.TotalDays <= 7)
                reportType = "Weekly";
            else
                reportType = "Monthly";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string insertQuery = @"INSERT INTO SalesReports (ReportType, ReportDate, TotalSales, TotalOrders)
                                       VALUES (@Type, @Date, @Total, @Orders)";
                SqlCommand cmd = new SqlCommand(insertQuery, con);
                cmd.Parameters.AddWithValue("@Type", reportType);
                cmd.Parameters.AddWithValue("@Date", reportDate);
                cmd.Parameters.AddWithValue("@Total", totalSales);
                cmd.Parameters.AddWithValue("@Orders", totalOrders);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Report summary saved successfully.");
            }
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //numDays.Value = 7;
            dgvSalesReport.DataSource = null;
            lblTotalSales.Text = "Total Sales: Rs. 0.00";
            lblTotalOrders.Text = "Total Orders: 0";
            lblTotalQty.Text = "Total Items Sold: 0";
        }

        private void btnGenerateByDateRange_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnGenerateByDays_CheckedChanged(object sender, EventArgs e)
        {

        }

        //private void rbUseDays_CheckedChanged(object sender, EventArgs e)
        //{
        //    numDays.Enabled = rbUseDays.Checked;
        //    dtpStartDate.Enabled = !rbUseDays.Checked;
        //    dtpEndDate.Enabled = !rbUseDays.Checked;
        //}

        private void rbUseDateRange_CheckedChanged(object sender, EventArgs e)
        {
            dtpStartDate.Enabled = rbUseDateRange.Checked;
            dtpEndDate.Enabled = rbUseDateRange.Checked;
            //numDays.Enabled = !rbUseDateRange.Checked;
        }

        private void btnGeneratePrintable_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to save the report as PDF?\nClick Yes to Save as PDF\nClick No to Print directly",
                                          "Choose Action",
                                          MessageBoxButtons.YesNoCancel,
                                          MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                SaveDataGridViewAsPDF(dgvSalesReport);
            }
            else if (result == DialogResult.No)
            {
                PrintDataGridView(dgvSalesReport);
            }
        }
        private void PrintDataGridView(DataGridView dgv)
        {
            // Create the print document
            PrintDocument printDoc = new PrintDocument();

            // Set up the event handler for printing the page
            printDoc.PrintPage += (sender, e) => PrintPage(sender, e, dgv);

            // Show the Print dialog to allow the user to select the printer and print options
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDoc;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDoc.Print();
            }
        }

        private void PrintPage(object sender, PrintPageEventArgs e, DataGridView dgv)
        {
            // Define some basic settings for the print
            float lineHeight = 20f;
            float yLineTop = e.MarginBounds.Top;
            int cellMargin = 5;

            // Loop through the columns of the DataGridView to print header
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                e.Graphics.DrawString(column.HeaderText, dgv.Font, Brushes.Black, e.MarginBounds.Left + (column.Index * 100), yLineTop);
            }

            yLineTop += lineHeight;

            // Loop through each row and print cell content
            foreach (DataGridViewRow row in dgv.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    e.Graphics.DrawString(cell.Value?.ToString() ?? string.Empty, dgv.Font, Brushes.Black, e.MarginBounds.Left + (cell.ColumnIndex * 100), yLineTop);
                }

                yLineTop += lineHeight;
            }
        }
        private void SaveDataGridViewAsPDF(DataGridView dgv)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF Files|*.pdf";
            sfd.Title = "Save Sales Report as PDF";
            sfd.FileName = "Sales_Report_" + DateTime.Now.ToString("yyyyMMdd") + ".pdf";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (System.IO.FileStream stream = new System.IO.FileStream(sfd.FileName, System.IO.FileMode.Create))
                    {
                        var doc = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4, 10f, 10f, 20f, 30f);
                        iTextSharp.text.pdf.PdfWriter.GetInstance(doc, stream);
                        doc.Open();

                        iTextSharp.text.pdf.PdfPTable table = new iTextSharp.text.pdf.PdfPTable(dgv.ColumnCount);
                        table.WidthPercentage = 100;

                        // Header
                        foreach (DataGridViewColumn column in dgv.Columns)
                        {
                            table.AddCell(new iTextSharp.text.Phrase(column.HeaderText));
                        }

                        // Data
                        foreach (DataGridViewRow row in dgv.Rows)
                        {
                            if (!row.IsNewRow)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    table.AddCell(cell.Value?.ToString());
                                }
                            }
                        }

                        doc.Add(table);
                        doc.Close();
                        stream.Close();

                        MessageBox.Show("PDF saved successfully!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving PDF: " + ex.Message);
                }
            }
        }

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            ExportToExcel(dgvSalesReport);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void numDays_ValueChanged(object sender, EventArgs e)
        //{

        //}
    }
}
