using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _381O_1_时间插入删除和获取随机元素允许重复
    {
        // 字典内使用 HashSet 是为了实现 O(1) 删除索引，而且索引不会重复
        Dictionary<int, HashSet<int>> IndexDictionary { get; set; } = new Dictionary<int, HashSet<int>>();
        List<int> Values { get; set; } = new List<int>();

        /** Initialize your data structure here. */
        public _381O_1_时间插入删除和获取随机元素允许重复()
        {
            /* 列表随机插入是 0(n)，因为要后移插入位置之后的元素，但追加在列表尾部是O(1)
             * 列表按索引查找是 O(1)，按值查找是 O(n)
             */

        }

        /** Inserts a value to the collection. Returns true if the collection did not already contain the specified element. */
        public bool Insert(int val)
        {
            // 使用一个字典维护某个数字的所有索引列表
            if (!IndexDictionary.TryGetValue(val, out var indexSet))
            {
                indexSet = new HashSet<int>();
                IndexDictionary.Add(val, indexSet);
            }

            Values.Add(val);
            indexSet.Add(Values.Count - 1);
            return true;
        }

        /** Removes a value from the collection. Returns true if the collection contained the specified element. */
        public bool Remove(int val)
        {
            // 字典不存在某个数字的索引，也就不存在某个数字
            if (!IndexDictionary.TryGetValue(val, out var valIndexList) ||
                valIndexList.Count == 0)
                return false;

            var lastValue = Values.Last();
            if (lastValue == val)
            {
                // 直接在列表最后移除
                valIndexList.Remove(Values.Count - 1);
                Values.RemoveAt(Values.Count - 1);
                return true;
            }

            // 将Values最后一个元素的值替换要删除的元素的最后一个索引的位置，然后Values删除最后一个元素，即为0(1)删除
            // 被替换的值的索引列表应该移除其索引值（Values的长度-1），并追加一个被删除元素所在的索引值（因为被替换的值被替换到这个索引了）
            var valLastIndex = valIndexList.Last();
            var exchangeIndexList = IndexDictionary[lastValue];

            valIndexList.Remove(valLastIndex);
            exchangeIndexList.Remove(Values.Count - 1);
            exchangeIndexList.Add(valLastIndex);

            Values[valLastIndex] = lastValue;
            Values.RemoveAt(Values.Count - 1);
            return true;
        }

        /** Get a random element from the collection. */
        public int GetRandom()
        {
            return Values[new Random().Next(0, Values.Count)];
        }

    }
}
