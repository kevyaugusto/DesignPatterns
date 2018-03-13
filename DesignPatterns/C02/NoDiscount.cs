using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.C02
{
    public class NoDiscount : IDiscount
    {
        public IDiscount NextDiscount { get; set; }

        public double ApplyDiscount(Budget budget)
        {
            budget.DiscountFactor = 0;

            return 0;
        }
    }
}
