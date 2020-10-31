using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _804唯一摩尔斯密码词
    {
        public int UniqueMorseRepresentations(string[] words)
        {
            Dictionary<char, string> Dic = new Dictionary<char, string>(){{'a',".-"},{'b',"-..."},{'c',"-.-."},{'d',"-.."},{'e',"."},{'f',"..-."},{'g',"--."},{'h',"...."},
            {'i',".."},{'j',".---"},{'k',"-.-"},{'l',".-.."},{'m',"--"},{'n',"-."},{'o',"---"},{'p',".--."},
            {'q',"--.-"},{'r',".-."},{'s',"..."},{'t',"-"},{'u',"..-"},{'v',"...-"},{'w',".--"},{'x',"-..-"},
            {'y',"-.--"},{'z',"--.."}};
            Dictionary<string, string> dic = new Dictionary<string, string>();
            for (int i = 0; i < words.Length; i++)
            {
                string str = "";
                for (int j = 0; j < words[i].Length; j++)
                {
                    str += Dic[words[i][j]];
                }
                if (!dic.ContainsKey(str))
                {
                    dic.Add(str, "");
                }

            }
            return dic.Count;
        }
    }
}
