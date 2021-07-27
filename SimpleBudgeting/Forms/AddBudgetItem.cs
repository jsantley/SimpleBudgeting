using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SimpleBudgeting
{
    public partial class AddBudgetItem : Form
    {
        private string bgtItemName = "No Name";
        decimal amtbudgetedMonthly;
        private bool isAFund = false;
        decimal fundGoal;
        

        public AddBudgetItem()
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
           

           /* dataGridView1.ColumnCount = 4;

            int rowId = dataGridView1.Rows.Add();
            DataGridViewRow row = dataGridView1.Rows[rowId];
           */

            dataGridView1.Rows.Add(bgtItemName,amtbudgetedMonthly.ToString(), isAFund, fundGoal.ToString());







           
        }

        private void backToOverviewButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
