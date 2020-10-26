using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _1266访问所有点的最小时间
    {
        public static int MinTimeToVisitAllPoints(int[][] points)
        {
            int count = 0;
            for (int i = 1; i < points.Length; i++)
            {
                int num1 = Math.Abs(points[i][0] - points[i - 1][0]);
                int num2 = Math.Abs(points[i][1] - points[i - 1][1]);
                count += num1 > num2 ? num1 : num2;
            }
            return count;
        }
    }
}
