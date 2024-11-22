
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreCalculatorXUnit.Services.Addition
{
    public class AdditionService : IAdditionService
    {
        public int Calculate(int a, int b)
        {
            return a + b;
        }
    }
}
