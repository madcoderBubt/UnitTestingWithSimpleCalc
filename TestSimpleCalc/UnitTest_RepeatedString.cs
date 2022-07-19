using SimpleCalc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestSimpleCalc
{
    public class UnitTest_HackerRankProblem { 
        [Theory]
        [InlineData("a", 1000000000000, 1000000000000)]
        [InlineData("aba", 10, 7)]
        [InlineData("abcac", 10, 4)]
        [InlineData("kmretasscityylpdhuwjirnqimlkcgxubxmsxpypgzxtenweirknjtasxtvxemtwxuarabssvqdnktqadhyktagjxoanknhgilnm", 736778906400, 51574523448)]
        [InlineData("epsxyyflvrrrxzvnoenvpegvuonodjoxfwdmcvwctmekpsnamchznsoxaklzjgrqruyzavshfbmuhdwwmpbkwcuomqhiyvuztwvq", 549382313570, 16481469408)]
        public void TestForRepeatedString(string s, long n, long output) => 
            Assert.Equal(output, RepeatedStringSolutions.RepeatedString(s, n));
    }
}
