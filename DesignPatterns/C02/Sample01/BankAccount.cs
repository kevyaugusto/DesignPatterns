using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.C02.Sample01
{
    public class BankAccount
    {
        public double Balance { get; private set; }
        public string OwnerName { get; set; }

        public BankAccount(string ownerName, double balance)
        {
            Balance = balance;
            OwnerName = ownerName;
        }
    }
}