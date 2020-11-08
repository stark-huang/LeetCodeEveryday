using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _327区间和的个数
    {  

        /// <summary>
        /// 这个方法会超出时间限制
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="lower"></param>
        /// <param name="upper"></param>
        /// <returns></returns>
        public int CountRangeSum(int[] nums, int lower, int upper)
        {
            int num = 0;
            int l = 0;
            long count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                l = i;
                while (l < nums.Length)
                {
                    count += nums[l];
                    if(count <= upper && count >= lower)
                        num++;
                    l++;
                }
                count = 0;
            }
            return num;
        }

    }
}
