using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _144二叉树的前序遍历
    {
        public IList<int> PreorderTraversal(TreeNode<int> root)
        {
            IList<int> list = new List<int>();
            if (root == null)
                return list;
            var stack = new Stack<TreeNode<int>>();
            stack.Push(root);
            while (stack.Count > 0)
            {
                var node = stack.Pop();//移除顶部的节点数据
                list.Add(node.Data);//数据加载到list中

                if (node.RChild != null)
                {
                    stack.Push(node.RChild);//把右节点插入到stack中
                }

                if (node.LChild != null)
                {
                    stack.Push(node.LChild);//把左节点插入到stack中
                }

            }
            return list;
        }
    }
}
