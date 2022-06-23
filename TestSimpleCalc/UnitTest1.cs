using System;
using Xunit;
using SimpleCalc;

namespace TestSimpleCalc
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(5, SimpleCalc.Addition.Calc(3, 2));
        }
    }
}
