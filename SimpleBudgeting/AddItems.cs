using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace SimpleBudgeting 
{
    public class AddItems : StartupPage
    {
        public decimal amtBudgeted;
        public string budgetItemName;
        private string amtRemaining;

        public decimal AmtBudgeted
        { get; set; }
        public string BudgetItemName
        { get; set; }

        
        public void AddItemstoOverview(decimal amtBudgeted, string budgetItemName)
        {
            AmtBudgeted = amtBudgeted;
            BudgetItemName = budgetItemName;
            overviewTableGridView.Rows.Add(AmtBudgeted); ;


            











        }
    }
}
