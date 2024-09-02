using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyApp1;

namespace Myapp1.Test
{
    public class CalculatorTest
    {
        [Test]
        public void add_Test()
        {
            //Arrange
            Calculator calculator = new Calculator();

            //Act
            int result = calculator.add(2, 3);

            //Assert
            Assert.AreEqual(5, result);
        }

    }
}
