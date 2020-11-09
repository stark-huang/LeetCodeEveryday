using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _973最接近原点的K个点
    {
        public int[][] KClosest(int[][] points, int K)
        {
            int[][] nums = new int[K][];
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < points.Length; i++)
            {
                dic.Add(i, (points[i][0] * points[i][0] + points[i][1] * points[i][1]));
            }
            Dictionary<int, int> dic1_SortedByKey = dic.OrderBy(p => p.Value).ToDictionary(p => p.Key, o => o.Value);

            foreach (KeyValuePair<int, int> item in dic1_SortedByKey)
            {
                if (K > 0)
                {
                    nums[K - 1] = points[item.Key];
                    K--;
                }
                else
                {
                    return nums;
                }
            }
            return nums;
        }
    }
}
