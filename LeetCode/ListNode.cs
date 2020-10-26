using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{

    public class ListNode<T>
    {
        private T data;        //数据域
        private ListNode<T> next;  //引用域

        #region 构造函数
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="val"></param>
        /// <param name="p"></param>
        public ListNode(T val, ListNode<T> p)
        {
            data = val;
            next = p;
        }
        public ListNode(ListNode<T> p)
        {
            next = p;
        }
        public ListNode(T val)
        {
            data = val;
            next = null;
        }
        public ListNode()
        {
            data = default(T);
            next = null;
        }
        #endregion

        //数据域属性
        public T Data
        {
            get
            {
                return data;
            }
            set
            {
                data = value;
            }
        }
        //引用域属性
        public ListNode<T> Next
        {
            get
            {
                return next;
            }
            set
            {
                next = value;
            }
        }

    }
}
