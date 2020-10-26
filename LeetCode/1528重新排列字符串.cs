using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _1528重新排列字符串
    {
        public string RestoreString(string s, int[] indices)
        {
            Dictionary<int, string> dic = new Dictionary<int, string>();
            for (int i = 0; i < indices.Length; i++)
            {
                dic.Add(indices[i], s[i].ToString());
            }
            var dicSort = from objDic in dic orderby objDic.Key select objDic;
            string str = "";
            foreach (KeyValuePair<int, string> kvp in dicSort)
                str += kvp.Value;
            return str;
        }
    }
}
