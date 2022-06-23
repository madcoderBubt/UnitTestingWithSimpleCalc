using System;
using Xunit;
using SimpleCalc;

namespace TestSimpleCalc
{
    public class UnitTest1
    {
        [Fact]
        public void Test1() => Assert.Equal(3858, Addition.Calc(3058, 800));
        [Fact]
        public void Test2() => Assert.Equal(16.3445f, Addition.Calc(15, 134.45E-2f));
        
        [Theory]
        [InlineData(2.2, 1.5, 3.7)]
        [InlineData(20, 5, 25)]
        [InlineData(double.MaxValue, 1.5, double.MaxValue)]
        [InlineData(double.MinValue, 1, double.MinValue)]
        public void TestDoubleAddition(double x, double y, double o) => Assert.Equal(o, Addition.Calc(x, y));

        [Theory]
        [InlineData(2.2, 1.5, 3.7)]
        [InlineData(20, 5, 25)]
        [InlineData(1.5E6, 1.5, 1500001.5)]
        public void TestDecimalAddition(decimal x, decimal y, decimal o) => Assert.Equal(o, Addition.Calc(x, y));

    }
}
