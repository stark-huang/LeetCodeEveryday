using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _1323_6和9组成的最大数字_
    {
        public int Maximum69Number(int num)
        {
            string str = num.ToString();
            if (str.Contains("6"))
            {
                int index = str.IndexOf("6");
                str = str.Remove(index, 1);
                str = str.Insert(index, "9");
            }
            return Convert.ToInt32(str);
        }
    }
}
