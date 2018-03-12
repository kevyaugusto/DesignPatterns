using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.C01.Sample01
{
    public interface IInvestment
    {
        double CalculateProfit(BankAccount bankAccount);
    }
}
