using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _129求根到叶子节点数字之和
    {
        public int SumNumbers(TreeNode<int> root)
        {
            return FindP(root, 0);
        }

        public int FindP(TreeNode<int> node, int path)
        {
            if (node == null) return 0;

            path = path * 10 + node.Data;
            if (node.LChild == null && node.RChild == null)
            {
                return path;
            }
            else
            {
                return FindP(node.LChild, path) + FindP(node.RChild, path);
            }
        }
    }
}
