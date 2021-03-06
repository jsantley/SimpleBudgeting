using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SimpleBudgeting
{
    public partial class AddBudgetItem : Form
    {
        private string bgtItemName = "No Name";
        static decimal amtbudgetedMonthly;
        private bool isAFund = false;
        decimal fundGoal;
        decimal amtRemaining = amtbudgetedMonthly;



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
            amtRemaining = amtbudgetedMonthly;

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
            StartupPage sp = new StartupPage();
            dataGridView1.Rows.Add(sp.userID, bgtItemName, amtbudgetedMonthly.ToString(), amtRemaining.ToString() , isAFund, fundGoal.ToString());
        }

        private void backToOverviewButton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=TEST-MACHINE-RI;Initial Catalog=budgetDB;Integrated Security=True");

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(@"INSERT INTO BudgetItems ([UserID], [Budget Item], [Amount Budgeted], [Amount Remaining], [Fund], [Fund Goal]) VALUES('" + dataGridView1.Rows[i].Cells[0].Value + "','" + dataGridView1.Rows[i].Cells[1].Value + "','" + dataGridView1.Rows[i].Cells[2].Value + "','" + dataGridView1.Rows[i].Cells[3].Value + "','" + dataGridView1.Rows[i].Cells[4].Value + "','" + dataGridView1.Rows[i].Cells[5].Value + "')", connection);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    this.Close();
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception);
                    MessageBox.Show("Database Error!");
                    throw;
                }
                    

            }


        }

        
    }
}
