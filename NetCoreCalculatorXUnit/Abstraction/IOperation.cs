using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreCalculatorXUnit.Abstraction
{
    public interface IOperation
    {
        int Calculate(int a, int b);
    }
}
