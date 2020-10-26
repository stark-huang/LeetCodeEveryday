using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _1290二进制链表转整数
    {
        public int GetDecimalValue(ListNode<int> head)
        {
            List<int> node = new List<int>();
            while (head != null)
            {
                node.Add(head.Data);
                head = head.Next;
            }
            string num = string.Join("", node);
            return Convert.ToInt32(num, 2);
        }
    }
}
