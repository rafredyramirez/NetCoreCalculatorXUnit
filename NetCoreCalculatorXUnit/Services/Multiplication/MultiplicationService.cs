using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreCalculatorXUnit.Services.Multiplication
{
    public class MultiplicationService : IMultiplicationService
    {
        public int Calculate(int a, int b)
        {
            return a * b;
        }
    }
}
