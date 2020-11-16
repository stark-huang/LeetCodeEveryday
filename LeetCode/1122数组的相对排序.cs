using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _1122数组的相对排序
    {
        public int[] RelativeSortArray(int[] arr1, int[] arr2)
        {
            List<int> list = new List<int>();
            var arr1List = arr1.ToList();
            for (int i = 0; i < arr2.Length; i++)
            {
                list = list.Concat(arr1List.AsEnumerable().Where(x => x == arr2[i]).ToList()).ToList();
                arr1List.RemoveAll(x => x == arr2[i]);
            }
            arr1List.Sort();
            list = list.Concat(arr1List).ToList();
            return list.ToArray();
        }
    }
}
