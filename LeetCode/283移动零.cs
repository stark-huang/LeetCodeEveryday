using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _283移动零
    {
        public void MoveZeroes(int[] nums)
        {
            int index = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    nums[index] = nums[i];
                    if (i != index)
                    {
                        nums[i] = 0;
                    }
                    index++;
                }
            }
        }
    }
}
