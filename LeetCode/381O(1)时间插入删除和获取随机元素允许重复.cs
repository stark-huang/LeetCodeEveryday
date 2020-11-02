using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _381O_1_时间插入删除和获取随机元素允许重复
    {
        //主要为add方法，时间复杂度为O(1)，需要扩容时为O(n)，因此该操作平均时间复杂度为O(1).
        private List<int> _LIST;
        private int _LENGTH; //当前集合长度
        //字典主要用到Add(时间复杂度同List.Add)、CntainsKey和dic[index]，时间复杂度均为O(1)，hashset操作均为O(1)
        Dictionary<int, HashSet<int>> _DICINDEX;
        /** Initialize your data structure here. */
        public _381O_1_时间插入删除和获取随机元素允许重复()
        {
            _LIST = new List<int>();
            _LENGTH = 0;
            _DICINDEX = new Dictionary<int, HashSet<int>>();
        }

        /** Inserts a value to the collection. Returns true if the collection did not already contain the specified element. */
        public bool Insert(int val)
        {
            //由于删除集合元素是覆盖，用额外变量维护集合的实际有效长度，当集合元素数量超过有效长度时，
            //新增元素从有效长度的末尾元素开始将无效的元素替换，反之，才添加到末尾
            if (_LIST.Count > _LENGTH)
                _LIST[_LENGTH] = val;
            else
                _LIST.Add(val);
            _LENGTH++;
            bool isExists = false;
            //用字典里的当前插入值对应的HashSet保存插入后该元素的索引，若对应索引数大于0，则表示已存在
            if (_DICINDEX.ContainsKey(val))
            {
                isExists = _DICINDEX[val].Count > 0;
                _DICINDEX[val].Add(_LENGTH - 1);
            }
            else
            {
                _DICINDEX.Add(val, new HashSet<int>() { _LENGTH - 1 });
            }
            return !isExists;
        }

        /** Removes a value from the collection. Returns true if the collection contained the specified element. */
        public bool Remove(int val)
        {
            int index = -1;
            if (_DICINDEX.ContainsKey(val) && _DICINDEX[val].Count > 0)
            {
                //获取删除元素的索引
                index = _DICINDEX[val].FirstOrDefault();
                //从字典中删除该索引
                _DICINDEX[val].Remove(index);
            }
            //没有找到，返回false，无需删除
            if (index == -1) return false;
            //只有一个时，即待删除元素索引等于末尾元素索引时，无需替换，因已删除过该元素的索引，只需维护集合长度即可
            if (index == _LENGTH - 1)
            {
                _LENGTH--;
                return true;
            }
            //若有多个元素时，末尾元素覆盖待删除元素后
            _LIST[index] = _LIST[_LENGTH - 1];
            _LENGTH--;
            //需要维度覆盖后的也就是末尾元素的索引，将旧索引删除，然后保存当前索引即可
            _DICINDEX[_LIST[index]].Remove(_LENGTH);
            _DICINDEX[_LIST[index]].Add(index);

            return true;
        }

        /** Get a random element from the collection. */
        public int GetRandom()
        {
            int res = -1;
            int seed = Guid.NewGuid().GetHashCode();
            Random rd = new Random(seed);
            int idx = rd.Next(_LENGTH);
            if (idx >= 0 && _LIST.Count > 0)
                res = _LIST[idx];
            return res;
        }


    }
}
