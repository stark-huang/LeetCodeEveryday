using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _122买卖股票的最佳时机II
    {
        public int MaxProfit(int[] prices)
        {
            int max = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] > prices[i - 1])
                    max += prices[i] - prices[i - 1];
            }
            return max;
        }
    }
}
