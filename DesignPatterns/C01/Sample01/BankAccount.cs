using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.C01.Sample01
{
    public class BankAccount
    {
        public double Balance { get; private set; }

        public void Deposit(double value)
        {
            Balance += value;
        }
    }
}
