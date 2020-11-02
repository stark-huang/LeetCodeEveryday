using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _1252奇数值单元格的数目
    {
        public int OddCells(int n, int m, int[][] indices)
        {
            var array = new int[n][];
            for (int i = 0; i < n; i++)
            {
                array[i] = new int[m];
            }

            for (int i = 0; i < indices.Length; i++)
            {
                for (int row = 0; row < n; row++)
                {
                    array[row][indices[i][1]]++;
                }
                for (int cell = 0; cell < m; cell++)
                {
                    array[indices[i][0]][cell]++;
                }
            }
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                count += array[i].Where(x => x % 2 == 1).Count();
                //count += array[i].Select(x => x % 2 == 1).Count();//错误的方式
            }

            return m * n - count;
        }
    }
}
