using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.C02
{
    public class FiveItemsDiscount : IDiscount
    {

        public IDiscount NextDiscount { get; set; }

        public double ApplyDiscount(Budget budget)
        {
            if (budget.BudgetItems.Count >= 5)
            {
                budget.DiscountFactor = 0.05;
                return budget.Value * budget.DiscountFactor;
            }

            return NextDiscount.ApplyDiscount(budget);
        }
    }
}
