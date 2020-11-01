using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "catsanddog";
            IList<string> wordDict = new List<string>();
            wordDict.Add("cat");
            wordDict.Add("cats");
            wordDict.Add("and");
            wordDict.Add("sand");
            wordDict.Add("dog");
            new _140单词拆分II().WordBreak(s, wordDict);
        }

    }
}
