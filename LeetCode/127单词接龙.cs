using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _127单词接龙
    {
        public int LadderLength(string beginWord, string endWord, IList<string> wordList)
        {
            if (!wordList.Contains(endWord)) return 0;
            if (beginWord == endWord) return 1;
            var set = new HashSet<string>(wordList);
            var visited = new HashSet<string>();
            visited.Add(beginWord);
            visited.Add(endWord);
            var waits = new HashSet<string>();
            waits.Add(beginWord);
            var waits2 = new HashSet<string>();
            waits2.Add(endWord);
            var step = 1;
            while (waits.Any() && waits2.Any())
            {
                step++;
                if (waits.Count > waits2.Count)
                {
                    var tmp = waits2;
                    waits2 = waits;
                    waits = tmp;
                }

                var waitsNext = new HashSet<string>();
                foreach (var wait in waits)
                {
                    foreach (var neighbour in ListNeighbours(wait, set))
                    {
                        if (waits2.Contains(neighbour)) return step;
                        if (visited.Contains(neighbour)) continue;
                        visited.Add(neighbour);
                        waitsNext.Add(neighbour);
                    }
                }
                waits = waitsNext;
            }
            return 0;
        }

        private IList<string> ListNeighbours(string word, HashSet<string> set)
        {
            var list = new List<string>();
            char[] arr = word.ToCharArray();
            for (int i = 0; i < word.Length; i++)
            {
                var old = arr[i];
                for (char j = 'a'; j <= 'z'; j++)
                {
                    if (j == old) continue;
                    arr[i] = j;
                    var newWord = new string(arr);
                    if (set.Contains(newWord)) list.Add(newWord);
                }
                arr[i] = old;
            }
            return list;

        }
    }
}
