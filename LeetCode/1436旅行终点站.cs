using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _1436旅行终点站
    {
        public string DestCity(IList<IList<string>> paths)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            for (int i = 0; i < paths.Count; i++)
                dic.Add(paths[i][0], paths[i][1]);
            string city = paths[0][0];
            while (dic.ContainsKey(city))
                city = dic[city];

            return city;
        }
    }
}
