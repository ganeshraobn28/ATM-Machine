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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
            LabelsVisibleFalse();
            BtnEnabledFalse();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult iExit;

            iExit = MessageBox.Show("Confirm you want to exit ??", "ATM System", MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question);

            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        public void LabelsVisibleFalse()
        {
            lblBalance.Visible = false;
            lblDeposit.Visible = false;
            lblLoan.Visible = false;
            lblWithdrawal.Visible = false;
        }

        public void LabelsVisibleTrue()
        {
            lblBalance.Visible = true;
            lblDeposit.Visible = true;
            lblLoan.Visible = true;
            lblWithdrawal.Visible = true;
        }

        public void BtnEnabledFalse()
        {
            btnDeposit.Enabled = false;
            btnPinChange.Enabled = false;
            btnWithdrawal.Enabled = false;
            btnBalance.Enabled = false;
        }

        public void BtnEnabledTrue()
        {
            btnDeposit.Enabled = true;
            btnPinChange.Enabled = true;
            btnWithdrawal.Enabled = true;
            btnBalance.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LabelsVisibleFalse();
            BtnEnabledFalse();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            String pin1 = String.Format(lblPin.Text);

            if (pin1 == "")
            {
                DialogResult iRetry;

                iRetry = MessageBox.Show("Please enter the PIN code and click on 'ENTER'", "Warning Message", MessageBoxButtons.RetryCancel,
                MessageBoxIcon.Warning);
            }
            else if (pin1 == "1234")
            {
                LabelsVisibleTrue();
                BtnEnabledTrue();
            }
            else
            {
                DialogResult iRetry;

                iRetry = MessageBox.Show("Invalid PIN !! Please enter the correct PIN", "Warning Message", MessageBoxButtons.RetryCancel,
                MessageBoxIcon.Warning);
                //if (iRetry == DialogResult.Retry)
                //{
                //    lblPin.Text = "";
                //}
                lblPin.Text = "";
            }
        }

        private void btnAccountType_Click(object sender, EventArgs e)
        {
            
        }

        private void btnWithdrawal_Click(object sender, EventArgs e)
        {
            AccountType acc = new AccountType();
            acc.ShowDialog();
        }
    }
}
