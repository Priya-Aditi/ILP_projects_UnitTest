// File: CalculatorTests.cs
using Xunit;
using Products.Infrastructure;

namespace Products.Infrastructure.Test
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_ReturnsCorrectSum()
        {
            var calc = new Calculator();
            int result = calc.Add(2, 3);
            Assert.Equal(5, result);
        }
    }
}
