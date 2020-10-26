using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _7整数反转
    {
        public static int Reverse(int x)
        {
            try
            {
                bool isNeg = false;
                if (x < 0)
                {
                    x = -x;
                    isNeg = true;

                }
                string[] nums = new string[x.ToString().Length];
                for (int i = 0; i < nums.Length; i++)
                {
                    nums[i] = x.ToString()[nums.Length - i - 1].ToString();
                }
                string str = string.Join(",", nums);
                x = int.Parse(str);
                if (isNeg)
                    x = -x;
                return x;
            }
            catch
            {
                return 0;
            }
        }
    }
}
