using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.C02
{
    public class FiveHundredDollarsDiscount : IDiscount
    {

        public IDiscount NextDiscount { get; set; }

        public double ApplyDiscount(Budget budget)
        {
            if (budget.Value >= 500)
            {
                budget.DiscountFactor = 0.08;
                return budget.Value * budget.DiscountFactor;
            }

            return NextDiscount.ApplyDiscount(budget);
        }
    }
}
