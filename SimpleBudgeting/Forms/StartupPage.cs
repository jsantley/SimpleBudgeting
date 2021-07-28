using System;
using System.Windows.Forms;

namespace SimpleBudgeting
{
    public partial class StartupPage : Form
    {
        decimal totalPaycheck;
        decimal budgetedAmount;
        public int userID;

        


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

        public void refreshData_Click(object sender, EventArgs e)
        {

            this.budgetItemsTableAdapter2.Fill(this.budgetDBDataSet3.BudgetItems);


        }

        private void StartupPage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'budgetDBDataSet3.BudgetItems' table. You can move, or remove it, as needed.
            this.budgetItemsTableAdapter2.Fill(this.budgetDBDataSet3.BudgetItems);
            

        }
    }
}
