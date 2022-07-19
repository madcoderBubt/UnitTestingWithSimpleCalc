using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalc
{
    public class RepeatedStringSolutions
    {
        public static long RepeatedString(string s, long n)
        {
            if (s.All(x => x == 'a'))
            {
                return n;
            }
            else
            {
                long total = 0;

                total = s.Count(i => i == 'a') * (n / s.Length);
                long last = n % (long)s.Length;
                if(last > 0)
                    total += s.Substring(0, (int)last).Count(i => i == 'a');

                return total;
            }

        }
    }
}
