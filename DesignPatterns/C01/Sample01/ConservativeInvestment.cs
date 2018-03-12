using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.C01.Sample01
{
    public class ConservativeInvestment : IInvestment
    {
        public double Factor { get; private set; }

        public double CalculateProfit(BankAccount bankAccount)
        {
            Factor = 0.008;

            var profit = bankAccount.Balance * Factor;

            return profit;
        }
    }
}
