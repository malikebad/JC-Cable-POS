using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop_Management__System
{
    public partial class Form1 : Form
    {
        int progressValue = 0;
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 50; 
            timer1.Tick += timer1_Tick;
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 50; 
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressValue++;

            if (progressValue <= 100)
            {
                progressBar1.Value = progressValue; // Update progress bar
            }
            else
            {
                timer1.Stop();
                this.Hide();

                // Ensure only one login form opens
                if (Application.OpenForms["login"] == null)
                {
                    login loginForm = new login();
                    loginForm.Show();
                }
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}




