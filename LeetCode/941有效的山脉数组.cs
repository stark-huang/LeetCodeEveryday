using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _941有效的山脉数组
    {
        public bool ValidMountainArray(int[] A)
        {
            if (A.Length < 3) return false;
            int tcout = 0;
            int acout = 0;
            for (int i = 1; i < A.Length - 1; ++i)
            {
                if (A[i - 1] < A[i] && A[i] > A[i + 1]) ++tcout;
                else if (A[i - 1] > A[i] && A[i] < A[i + 1]) ++acout;
                else if (A[i - 1] == A[i] || A[i] == A[i + 1]) return false;
            }
            return tcout == 1 && acout == 0;
        }
    }
}
