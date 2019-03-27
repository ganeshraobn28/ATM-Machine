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
    public partial class AccountType : Form
    {
        public AccountType()
        {
            InitializeComponent();
        }

        public void openWithdrawalForm()
        {
            Withdrawal wtd = new Withdrawal();
            wtd.ShowDialog();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                MessageBox.Show("Account type is selected successfully !! Your selection is : 'SAVINGS Account'", "Account Type Selection Confirmation Window", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                //this.Close();
                openWithdrawalForm();
            }
            else if (radioButton2.Checked == true)
            {
                MessageBox.Show("Account type is selected successfully !! Your selection is : 'CURRENT Account'", "Account Type Selection Confirmation Window", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                this.Close();            
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult iRetry;

            iRetry = MessageBox.Show("You have not selected the Account Type ..!!!!", "Account Type Selection Not Done", MessageBoxButtons.RetryCancel,
                MessageBoxIcon.Stop);

            if (iRetry == DialogResult.Cancel)
            {
                this.Close();
            }
        }
    }
}
