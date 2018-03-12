using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.C01
{
    public class CompanyTax : ITax
    {
        public double CalculateTax(Budget budget)
        {
            return budget.Value * 0.1;
        }
    }
}
