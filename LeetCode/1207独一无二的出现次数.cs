using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _1207独一无二的出现次数
    {
        public bool UniqueOccurrences(int[] arr)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            List<int> list = arr.ToList();
            for (int i = 0; i < list.Count; i++)
            {
                if (dic.ContainsValue(list[i]))
                    continue;
                if (!dic.ContainsKey(list.Where(x => x == list[i]).Count()))
                {
                    dic.Add(list.Where(x => x == list[i]).Count(), list[i]);
                }
                else
                    return false;
            }
            return true;
        }
    }
}
