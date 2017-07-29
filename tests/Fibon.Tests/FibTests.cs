using System;
using Xunit;
using Fibon.Service;

namespace Fibon.Tests
{
    public class FibTests
    {
		[Theory]
        [InlineData(0,0)]
        [InlineData(1,1)]
        [InlineData(2,1)]
        [InlineData(7,13)]
		public void Fib_RetursCorrentValues(int number, int expected)
        {
			ICalculator calc = new Fast();
			int result = calc.Fib(number);

			Assert.Equal(expected, result);
        }
    }
}
