using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBudgeting
{
    public class AddItems
    {
        public decimal amtBudgeted;
        public string budgetItemName;

        public decimal AmtBudgeted
        { get; set; }
        public string BudgetItemName
        { get; set; }

        public void AddItemstoOverview(decimal amtBudgeted, string budgetItemName)
        {
            AmtBudgeted = amtBudgeted;
            BudgetItemName = budgetItemName;

            
        }
    }
}
