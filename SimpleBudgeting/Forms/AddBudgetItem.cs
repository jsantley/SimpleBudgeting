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

namespace SimpleBudgeting
{
    public partial class AddBudgetItem : Form
    {
        string bgtItemName;
        decimal amtbudgetedMonthly;
        bool isAFund;
        decimal fundGoal;
        string connectionString;

        public AddBudgetItem()
        {
            InitializeComponent();
        }

        private void SQLConnectionClass()
        {
            InitializeComponent();
            

        }


        private void bgtItemNmetxtBox_TextChanged(object sender, EventArgs e)
        {
            bgtItemName = bgtItemNmetxtBox.Text;
            
        }

        private void amtBudgeted_ValueChanged(object sender, EventArgs e)
        {
            amtbudgetedMonthly = amtBudgeted.Value;
        }

        private void isAFundcheckBx_CheckedChanged(object sender, EventArgs e)
        {
            isAFund = isAFundcheckBx.Checked;
            if (isAFund == true)
            {
                goalLabel.Visible = true;
                goalTextBox.Visible = true;
            }
            else
            {
                goalLabel.Visible = false;
                goalTextBox.Visible = false;
            }

        }

        private void goalTextBox_ValueChanged(object sender, EventArgs e)
        {
            fundGoal = goalTextBox.Value;
        }

        private void AddBgtItmDoneBttn_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
