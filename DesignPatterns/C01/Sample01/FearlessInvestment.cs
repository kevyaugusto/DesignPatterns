using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.C01.Sample01
{
    public class FearlessInvestment : IInvestment
    {
        private Random random;

        public double Factor { get; private set; }

        public FearlessInvestment()
        {
            random = new Random();
        }

        public double CalculateProfit(BankAccount bankAccount)
        {
            var probability = random.Next(10);

            if (probability >= 0 && probability <= 1)
                Factor = 0.05D;
            else if (probability >= 2 && probability <= 4)
                Factor = 0.03D;
            else
                Factor = 0.006D;

            var profit = bankAccount.Balance * Factor;

            return profit;
        }
    }
}
