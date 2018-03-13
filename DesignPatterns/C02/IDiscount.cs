using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.C02
{
    public interface IDiscount
    {
        IDiscount NextDiscount { get; set; }
        double ApplyDiscount(Budget budget);
    }
}