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
    public partial class StartupPage : Form
    {
        decimal totalPaycheck;
        decimal budgetedAmount;
        
        public StartupPage()
        {
            InitializeComponent();
        }

        public void TotalPaycheckTextBox_ValueChanged(object sender, EventArgs e)
        {
            totalPaycheck = totalPaycheckTextBox.Value;
            leftToBudgetTextBox.Text = Convert.ToString(totalPaycheck - budgetedAmount);
            

        }

        private void addBudgetItemBttn_Click(object sender, EventArgs e)
        {
            var addBudgetItem = new AddBudgetItem();
            addBudgetItem.Show();
        }
    }
}
