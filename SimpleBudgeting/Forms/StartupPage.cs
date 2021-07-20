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

        SqlConnection con = new SqlConnection(@"Data Source=TEST-MACHINE-RI;Initial Catalog=simpleBudgetDB;Integrated Security=True");
        SqlCommand cmd;
        DataTable dt;
        SqlDataAdapter da;
        DataSet ds;


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
            bgtItemListView.Columns.Add("Budget Item",150);
            bgtItemListView.Columns.Add("Amount Budgeted", 150, HorizontalAlignment.Center);
            bgtItemListView.Columns.Add("Amount Remaining", 150, HorizontalAlignment.Center);
            bgtItemListView.View = View.Details;

            con.Open();
            cmd = new SqlCommand("select * from overviewTable",con);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            _ = da.Fill(ds, "Overview");
            
        }
    }
}
