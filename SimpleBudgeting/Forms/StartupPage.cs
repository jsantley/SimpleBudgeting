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
using SimpleBudgeting;

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

        public void AddBudgetItemBttn_Click(object sender, EventArgs e)
        {
            
            var addBudgetItem = new AddBudgetItem();
            addBudgetItem.Show();
            

        }

        private void refreshData_Click(object sender, EventArgs e)
        {
           

        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void StartupPage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'simpleBudgetDBDataSet1.overviewTable' table. You can move, or remove it, as needed.
            this.overviewTableTableAdapter1.Fill(this.simpleBudgetDBDataSet1.overviewTable);

        }
    }
}
