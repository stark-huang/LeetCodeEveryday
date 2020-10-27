using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _1021删除最外层的括号
    {
        public string RemoveOuterParentheses(string S)
        {
            List<string> list = new List<string>();
            string s = "";
            int count = 0;
            for (int i = 0; i < S.Length; i++)
            {
                if ('('.Equals(S[i]))
                    count++;  
                if (')'.Equals(S[i]))
                    count--;
                s += S[i].ToString();
                if (count == 0)
                {
                    s = s.Substring(0, s.Length - 1);//去掉最后一个逗号
                    s = s.Substring(1);//去掉第一个字
                    list.Add(s);
                    s = "";
                }
            }
            return string.Join("", list);
        }
    }
}
