using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _1351统计有序矩阵中的负数
    {
        public int CountNegatives(int[][] grid)
        {
            int count = 0;
            for (int i = 0; i < grid.Length; i++)
                count += grid[i].Where(x => x < 0).Count();
            return count;
        }
    }
}
