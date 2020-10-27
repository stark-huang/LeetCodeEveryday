using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _1450在既定时间做作业的学生人数
    {
        public int BusyStudent(int[] startTime, int[] endTime, int queryTime)
        {
            int  count =0;
            for (int i = 0; i < startTime.Length;i++ )
            {
                if (startTime[i] <= queryTime && endTime[i] >= queryTime)
                    count++;
            }
            return count;
        }
    }
}
