using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.C01.Sample01
{
    public class InvestmentCalculator
    {

        public double Calculate(BankAccount bankAccount, IInvestment investmentStrategy)
        {
            var profitOfInvestment = investmentStrategy.CalculateProfit(bankAccount);            

            return profitOfInvestment;
        }
    }
}
