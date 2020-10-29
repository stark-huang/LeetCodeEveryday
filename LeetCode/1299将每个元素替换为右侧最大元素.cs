using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _1299将每个元素替换为右侧最大元素
    {
        //这个方法会超时
        public int[] ReplaceElements(int[] arr)
        {
            int[] nums = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < arr.Max())
                {
                    nums[i] = arr.Max();
                    arr[i] = 0;
                }
                else
                {
                    arr[i] = 0;
                    nums[i] = arr.Max();
                }
            }
            nums[arr.Length - 1] = -1;
            return nums;
        }

        public int[] ReplaceElements2(int[] arr)
        {
            int max = -1;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                int c = max;
                if (arr[i] > max)
                    max = arr[i];
                arr[i] = c;
            }
            return arr;
        }
    }
}
