using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.C01
{
    public class TaxCalculator
    {
        public double Calculate(Budget budget, ITax taxStrategy)
        {
            double calculatedTax = taxStrategy.CalculateTax(budget);

            return calculatedTax;
        }
    }
}
