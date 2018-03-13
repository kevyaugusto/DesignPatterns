using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.C02
{
    public class BudgetItem
    {
        public string Name { get; private set; }
        public double Value { get; private set; }

        public BudgetItem(string name, double value)
        {
            Name = name;
            Value = value;
        }
    }
}
