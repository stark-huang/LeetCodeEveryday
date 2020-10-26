using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _1024视频拼接
    {
        public static int VideoStitching(int[][] clips, int T)
        {
            bool isStop = true;
            List<int> startList = new List<int>();
            List<int> endList = new List<int>();
            int count = -1;
            foreach (var video in clips)
            {
                if (video[1] >= T)
                    isStop = false;
                startList.Add(video[0]);
                endList.Add(video[1]);

            }
            if (isStop)
                return count;
            count = 0;
            int num = 0;
            List<int> MaxList = new List<int>();
            while (num < T)
            {
                for (int i = 0; i < startList.Count; i++)
                {
                    if (startList[i] <= num)
                    {
                        if (num < endList[i])
                        {
                            MaxList.Add(endList[i]);
                        }
                    }
                }
                num = MaxList.Max();
                count++;
            }
            return count;
        }
        public static int VideoStitching2(int[][] clips, int T)
        {
            int max = 0;
            int last = -1;
            int count = 0;
            for (; max < T; count++)
            {
                var choose = clips.Where(x => x[0] > last && x[0] <= max).ToList();
                if (choose.Any())
                {
                    last = max;
                    max = choose.Max(x => x[1]);
                    if (max > last) continue;
                }
                return -1;
            }

            return count;
        }
    }
}
