using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.C01.Sample01
{
    public class ModerateInvestment : IInvestment
    {
        private Random random;

        public double Factor { get; private set; }

        public ModerateInvestment()
        {
            random = new Random();
        }

        public double CalculateProfit(BankAccount bankAccount)
        {
            Factor = random.Next(2) == 0 ? 0.025 : 0.007;

            var profit = bankAccount.Balance * Factor;

            return profit;
        }
    }
}
