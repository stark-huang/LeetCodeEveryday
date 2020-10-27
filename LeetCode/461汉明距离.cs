using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _461汉明距离
    {
        public int HammingDistance(int x, int y)
        {
            string x1 = Convert.ToString(x, 2);
            string y1 = Convert.ToString(y, 2);
            if (x1.Length > y1.Length)
                y1 = y1.PadLeft(x1.Length, '0');
            else if (x1.Length < y1.Length)
                x1 = x1.PadLeft(y1.Length, '0');
            int count = 0;
            for (int i = 0; i < x1.Length; i++)
            {
                if (!x1[i].Equals(y1[i]))
                    count++;
            }
            return count;
        }
    }
}
