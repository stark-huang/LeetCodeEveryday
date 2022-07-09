using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _922按奇偶排序数组II
    {
        public int[] SortArrayByParityII(int[] A)
        {
            Stack<int> stk1 = new Stack<int>();
            Stack<int> stk2 = new Stack<int>();
            for (int i = 0; i < A.Length; i++)
            {
                if (Convert.ToBoolean(A[i] & 1))
                    stk1.Push(A[i]);
                else
                    stk2.Push(A[i]);
            }
            List<int> list = new List<int>();
            while (stk1.Any() || stk2.Any())
            {
                list.Add(stk2.Pop());
                list.Add(stk1.Pop());
            }
            return list.ToArray();
        }
    }
}
