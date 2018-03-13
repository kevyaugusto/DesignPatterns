using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.C02
{
    public class DiscountCalculator
    {
        public double CalculateDiscount(Budget budget)
        {
            var noDiscount = new NoDiscount();
            var fiveItemsDiscount = new FiveItemsDiscount();
            var fiveHundredDollarsDiscount = new FiveHundredDollarsDiscount();

            fiveItemsDiscount.NextDiscount = fiveHundredDollarsDiscount;
            fiveHundredDollarsDiscount.NextDiscount = noDiscount;

            var discountApplied = fiveItemsDiscount.ApplyDiscount(budget);

            return discountApplied;
        }
    }
}
