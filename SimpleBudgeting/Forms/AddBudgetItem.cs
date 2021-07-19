using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleBudgeting
{
    public partial class AddBudgetItem : Form
    {
        string bgtItemName;
        decimal amtbudgetedMonthly;
        bool isAFund;
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
            } else
            {
                goalLabel.Visible = false;
                goalTextBox.Visible = false;
            }

        }

        private void goalTextBox_ValueChanged(object sender, EventArgs e)
        {
            fundGoal = goalTextBox.Value;
        }
    }
}
