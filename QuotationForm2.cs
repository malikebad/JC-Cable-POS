using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop_Management__System
{
    public partial class QuotationForm2: Form
    {
        private string quotationReceiptText;
        private Font printFont = new Font("Courier New", 12);
        private Form previousForm;
        public QuotationForm2()
        {
            InitializeComponent();
        }
        public QuotationForm2(DataGridView orderView, string customerName, decimal totalAmount, Form previousFormRef)
        {
            InitializeComponent();
            previousForm = previousFormRef;

            // Populate date
            dtQuotationDate.Value = DateTime.Now;
            comboCustomerName.Text = customerName;
            txtTotalAmount.Text = totalAmount.ToString("F2");

            // Populate DataGridView
            foreach (DataGridViewRow row in orderView.Rows)
            {
                if (!row.IsNewRow)
                {
                    int index = dgvQuotationItems.Rows.Add();
                    dgvQuotationItems.Rows[index].Cells[0].Value = row.Cells[0].Value; // Adjust index mapping
                    dgvQuotationItems.Rows[index].Cells[1].Value = row.Cells[1].Value;
                    dgvQuotationItems.Rows[index].Cells[2].Value = row.Cells[2].Value;
                    dgvQuotationItems.Rows[index].Cells[3].Value = row.Cells[3].Value;
                    dgvQuotationItems.Rows[index].Cells[4].Value = row.Cells[4].Value;
                }
            }

            // Set total amount
            txtTotalAmount.Text = totalAmount.ToString("0.00");

            // Set quotation ID
            txtQuotationID.Text = GenerateQuotationID();

            // Set customer name (match from dropdown)
            SetCustomerComboBox(customerName);
            this.previousForm = previousForm;
        }
        private void SetCustomerComboBox(string customerName)
        {
            // Ensure the combo is filled before selecting
            foreach (var item in comboCustomerName.Items)
            {
                if (comboCustomerName.GetItemText(item).Equals(customerName, StringComparison.OrdinalIgnoreCase))
                {
                    comboCustomerName.SelectedItem = item;
                    return;
                }
            }

            // If not found in items, add temporarily
            comboCustomerName.Items.Add(customerName);
            comboCustomerName.SelectedItem = customerName;
        }
        private string GenerateQuotationID()
        {
            return "Q" + DateTime.Now.Ticks.ToString().Substring(10); // or fetch from DB
        }
        

        private void QuotationForm2_Load(object sender, EventArgs e)
        {

        }

        private void dgvQuotationItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void PrintQuotationPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float yPos = 20;
            int leftMargin = 10;
            int lineHeight = 20;

            using (StringReader reader = new StringReader(quotationReceiptText))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    e.Graphics.DrawString(line, printFont, Brushes.Black, leftMargin, yPos);
                    yPos += lineHeight;
                }
            }
        }

        private void btnPrintQuotation_Click(object sender, EventArgs e)
        {
            // Generate preview text
            GenerateQuotationReceiptText();

            // Show print preview
            printDocument1.PrintPage += new PrintPageEventHandler(PrintQuotationPage);
            printPreviewDialog1.Document = printDocument1;

            DialogResult previewResult = printPreviewDialog1.ShowDialog();

            if (previewResult == DialogResult.OK)
            {
                // Ask if user wants to print
                DialogResult printConfirm = MessageBox.Show("Do you want to print the quotation?", "Print Confirmation", MessageBoxButtons.YesNo);

                if (printConfirm == DialogResult.Yes)
                {
                    PrintDialog printDialog = new PrintDialog();
                    printDialog.Document = printDocument1;

                    if (printDialog.ShowDialog() == DialogResult.OK)
                    {
                        printDocument1.Print();
                    }
                }
            }
        }
        private void GenerateQuotationReceiptText()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("========== JC Cables ==========");
            sb.AppendLine($"Quotation ID: {txtQuotationID.Text}");
            sb.AppendLine($"Date: {dtQuotationDate.Value.ToShortDateString()}");
            sb.AppendLine($"Customer: {comboCustomerName.Text}");
            sb.AppendLine("===================================");
            sb.AppendLine("Item        Qty   Price   Total");
            sb.AppendLine("-----------------------------------");

            foreach (DataGridViewRow row in dgvQuotationItems.Rows)
            {
                if (!row.IsNewRow)
                {
                    string item = row.Cells[1].Value.ToString().PadRight(10);
                    string qty = row.Cells[2].Value.ToString().PadLeft(4);
                    string price = row.Cells[3].Value.ToString().PadLeft(7);
                    string total = row.Cells[4].Value.ToString().PadLeft(7);
                    sb.AppendLine($"{item} {qty} {price} {total}");
                }
            }

            sb.AppendLine("-----------------------------------");
            sb.AppendLine($"Grand Total: {txtTotalAmount.Text}");
            sb.AppendLine("===================================");
            sb.AppendLine("  Thank You! Visit Again!");

            quotationReceiptText = sb.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
