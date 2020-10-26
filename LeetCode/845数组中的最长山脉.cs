using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _845数组中的最长山脉
    {
        public static int LongestMountain(int[] A)
        {
            bool sign = true;
            int length = 1;
            int max = 1;
            for (int i = 1; i < A.Length; i++)
            {
                if (A[i] > A[i - 1] && sign)
                    length++;
                else if (A[i] < A[i - 1] && length > 1)
                {
                    sign = false;
                    length++;
                    max = length > max ? length : max;
                }
                else//结束登山只有两种可能，并且代码又所重复，精简如下
                {
                    if (!sign)
                        i--; ;
                    sign = true;
                    length = 1;
                }
            }
            return max > 2 ? max : 0;
        }
    }
}
