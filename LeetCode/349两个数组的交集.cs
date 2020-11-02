using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _349两个数组的交集
    {
        //解法1：普通遍历
        public int[] Intersection(int[] nums1, int[] nums2)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < nums1.Length; i++)
                if (nums2.Contains(nums1[i]) && !list.Contains(nums1[i]))
                    list.Add(nums1[i]);
            return list.ToArray();
        }
        //解法2 linq查询
        public int[] Intersection2(int[] nums1, int[] nums2)
        {
            return nums1.Intersect(nums2).ToArray();
        }

    }
}
