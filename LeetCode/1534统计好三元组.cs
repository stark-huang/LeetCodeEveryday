using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _1534统计好三元组
    {
        public int CountGoodTriplets(int[] arr, int a, int b, int c)
        {
            int count = 0;
            for (int i = 0; i < arr.Length - 2; i++)
            {
                for (int j = i + 1; j < arr.Length - 1; j++)
                {
                    for (int n = j + 1; n < arr.Length; n++)
                    {
                        if (Math.Abs(arr[i] - arr[j]) <= a && Math.Abs(arr[j] - arr[n]) <= b && Math.Abs(arr[i] - arr[n]) <= c)
                            count++;
                    }
                }
            }
            return count;
        }
    }
}
