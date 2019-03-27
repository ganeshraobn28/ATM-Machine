using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_Machine
{
    public partial class Withdrawal : Form
    {
        public Withdrawal()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            String pin1 = String.Format(lblPin.Text);
            DialogResult iRetry;
            if (pin1 == "")
            {
                iRetry = MessageBox.Show("Please enter the Amount and click on 'ENTER'", "Warning Message", MessageBoxButtons.RetryCancel,
                MessageBoxIcon.Warning);
            }
            else if (Convert.ToInt32(pin1) < 100 || Convert.ToInt32(pin1) > 20000)
            {
                iRetry = MessageBox.Show("Please read the instructions on the screen before entering the amount !!", "Warning Message", MessageBoxButtons.RetryCancel,
                MessageBoxIcon.Warning);
            }
            else if (Convert.ToInt32(pin1) % 10 != 0)
            {
                iRetry = MessageBox.Show("Please read the instructions on the screen before entering the amount !!", "Warning Message", MessageBoxButtons.RetryCancel,
                MessageBoxIcon.Warning);
            }
            else
            {
                lblSuccess.Visible = true;
                progressBar1.Visible = true;
                timer1.Start();
                timer1.Interval = 1000;
                timer1.Tick += new EventHandler(timer1_Tick);
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            lblPin.Text = lblPin.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            lblPin.Text = lblPin.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            lblPin.Text = lblPin.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            lblPin.Text = lblPin.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            lblPin.Text = lblPin.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            lblPin.Text = lblPin.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            lblPin.Text = lblPin.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            lblPin.Text = lblPin.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            lblPin.Text = lblPin.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            lblPin.Text = lblPin.Text + "0";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblPin.Text = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //timer1.Enabled = true;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 10;
            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.Value++;
            }
            if (progressBar1.Value == 9)
            {
                DialogResult iSuccess = MessageBox.Show("Please collect the amount and also your card !!!", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
        }
    }
}
