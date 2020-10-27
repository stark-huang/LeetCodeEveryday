using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    /// <summary>
    /// 二叉链表结点类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class TreeNode<T>
    {
        private T data;               //数据域
        private TreeNode<T> lChild;   //左孩子   树中一个结点的子树的根结点称为这个结点的孩子
        private TreeNode<T> rChild;   //右孩子

        public TreeNode(T val, TreeNode<T> lp, TreeNode<T> rp)
        {
            data = val;
            lChild = lp;
            rChild = rp;
        }

        public TreeNode(TreeNode<T> lp, TreeNode<T> rp)
        {
            data = default(T);
            lChild = lp;
            rChild = rp;
        }

        public TreeNode(T val)
        {
            data = val;
            lChild = null;
            rChild = null;
        }

        public TreeNode()
        {
            data = default(T);
            lChild = null;
            rChild = null;
        }

        public T Data
        {
            get { return data; }
            set { data = value; }
        }

        public TreeNode<T> LChild
        {
            get { return lChild; }
            set { lChild = value; }
        }

        public TreeNode<T> RChild
        {
            get { return rChild; }
            set { rChild = value; }
        }
    }
}
