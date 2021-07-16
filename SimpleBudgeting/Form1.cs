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
    public partial class Form1 : Form
    {
        string totalPaycheckString;
        double totalPaycheck;
        double leftToBudget;
        double budgetedAmount;
        public Form1()
        {
            InitializeComponent();
        }

        public void TotalPaycheckTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
            
             totalPaycheckString = totalPaycheckTextBox.Text;
             totalPaycheck = Convert.ToDouble(totalPaycheckString);
             leftToBudget = totalPaycheck - budgetedAmount;

             leftToBudgetTextBox.Text = Convert.ToString(leftToBudget);

            } catch
            {
                _ = MessageBox.Show("Input must be numbers and decimals!");
            }

        }

        public void TotalPaycheckTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                leftToBudgetTextBox.Text = Convert.ToString(leftToBudget);
            } else
            {
                return;
            }

        }
    }
}
