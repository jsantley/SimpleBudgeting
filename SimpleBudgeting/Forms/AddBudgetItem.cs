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
        public AddBudgetItem()
        {
            InitializeComponent();
        }


        private void bgtItemNmetxtBox_TextChanged(object sender, EventArgs e)
        {
            bgtItemName = bgtItemNmetxtBox.Text;
        }

        private void amtBudgetedMonthly_ValueChanged(object sender, EventArgs e)
        {
            amtbudgetedMonthly = amtBudgetedMonthly.Value;
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

    }
}
