using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.C02
{
    public class Budget
    {
        public Budget(double value)
        {
            Value = value;
            BudgetItems = new List<BudgetItem>();
        }


        public double DiscountFactor { get; set; }

        public double Value { get; private set; }

        public IList<BudgetItem> BudgetItems { get; private set; }

        public void AddBudgetItem(BudgetItem budgetItem)
        {
            BudgetItems.Add(budgetItem);
        }
    }
}