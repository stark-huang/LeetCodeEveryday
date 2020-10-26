using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class LCP17速算机器人
    {
        public int Calculate(string s)
        {
            int x = 1, y = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if ('A'.Equals(s[i]))
                    x = 2 * x + y;
                else if ('B'.Equals(s[i]))
                    y = 2 * y + x;
            }
            return x + y;
        }
    }
}
