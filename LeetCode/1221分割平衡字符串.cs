using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _1221分割平衡字符串
    {
        public int BalancedStringSplit(string s)
        {
            int count = 0;
            int num = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if ('R'.Equals(s[i]))
                    num++;
                else if ('L'.Equals(s[i]))
                    num--;
                if (num == 0)
                    count++;
            }
            return count;
        }
    }
}
