using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.C01
{
    public interface ITax
    {
        double CalculateTax(Budget budget);
    }
}
