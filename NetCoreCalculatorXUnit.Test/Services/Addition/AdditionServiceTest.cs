﻿using NetCoreCalculatorXUnit.Services.Addition;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreCalculatorXUnit.Test.Services.Addition
{
    public class AdditionServiceTest
    {
        //[Fact(Skip = "Esta prueba no es valida en este momento, añadir número ticket para darle manejo")] //cuando no se pueda ejecutar la prueba por problemas de version de librerias, etc. esto hace que la prueba se omita
        [Fact]
        public void Calculate_Addition() 
        {
            // Arrange
            var a = 10;
            var b = 15;
            var expected = a + b;

            var service = new AdditionService();

            // Act
            var result = service.Calculate(a, b);

            // Asser
            Assert.Equal(expected, result); 
        }

        [Theory]
        [InlineData(5, 15, 20)]
        [InlineData(25, 1, 26)]
        [InlineData(40, 45, 85)]
        [InlineData(5, 10, 15)]
        public void Calculate_Addition_ResultEqualsExpected(int a, int b, int expected) 
        { 
            var additionService = new AdditionService();

            var result = additionService.Calculate(a, b);

            Assert.Equal(expected, result);
        }
    }
}
