using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreCalculatorXUnit.Services.Substraction
{
    public class SubstractionService : ISubstractionService
    {
        public int Calculate(int a, int b)
        {
            return a - b;
        }
    }
}
