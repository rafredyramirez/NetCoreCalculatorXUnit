using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreCalculatorXUnit.Services.Division
{
    public class DivisionService : IDivisionService
    {
        public int Calculate(int a, int b)
        {
            if (b == 0)
                throw new ArgumentException("El dividendo (b) no puede ser igual a 0");

            return a / b;
        }
    }
}
