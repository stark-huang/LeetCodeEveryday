using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _463岛屿的周长
    {
        //先计算出所有的1的总值，再去判断是否有相邻的1
        public int IslandPerimeter(int[][] grid)
        {
            int num = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        num += 4;
                    }
                    if (j > 0)
                    {
                        if (grid[i][j] == 1 && grid[i][j - 1] == 1)
                        {
                            num -= 2;
                        }
                    }
                    if (i > 0)
                    {
                        if (grid[i][j] == 1 && grid[i - 1][j] == 1)
                        {
                            num -= 2;
                        }
                    }
                }

            }
            return num;
        }
    }
}
