using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _1572矩阵对角线元素的和
    {
        public static int DiagonalSum(int[][] mat)
        {
            if (mat.Length == 1)
                return mat[0][0];
            int count = 0;
            for (int i = 0; i < mat.Length; i++)
            {
                count += mat[i][i] + mat[i][mat.Length - i - 1];
            }
            if (mat.Length % 2 != 0)
                count -= mat[(mat.Length / 2)][(mat.Length / 2)];
            return count;
        }
    }
}
