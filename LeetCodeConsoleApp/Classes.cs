using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeConsoleApp
{





    public class Node
    {
        public int val;
        public Node next;
        public Node random;

        public Node(int _val)
        {
            val = _val;
            next = null;
            random = null;
        }
    }


    //* Definition for a binary tree node.
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x = 0, TreeNode left = null, TreeNode right = null)
        {
            val = x;
            this.left = left;
            this.right = right;
        }
    }




    // Definition for singly-linked list.
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }


    //class ChrisCustom : IComparable<ChrisCustom>
    //{

    //    public int val { get; set; }

    //    public ChrisCustom(int val)
    //    {
    //        this.val = val;
    //    }


    //    public int CompareTo(ChrisCustom that)
    //    {
    //        if (this.val > that.val)
    //            return -1;
    //        else if (this.val == that.val)
    //            return 0;
    //        else return 1;
    //    }
    //}



    public class DuplicateKeyComparer<TKey>
                :
             IComparer<TKey> where TKey : IComparable
    {
        #region IComparer<TKey> Members

        public int Compare(TKey x, TKey y)
        {
            int result = x.CompareTo(y);

            if (result == 0)
                return 1;   // Handle equality as beeing greater
            else
                return result;
        }

        #endregion
    }




    public class KthLargest
    {

        private int _k;
        private List<int> _nums;
        public KthLargest(int k, int[] nums)
        {
            _k = k;
            _nums = nums.OrderBy(x => x).ToList();
        }

        public int Add(int val)
        {
            if (_nums.Count < _k || val > _nums[_nums.Count - _k])
            {
                var i = _nums.BinarySearch(val);
                if (i < 0) _nums.Insert(~i, val);
                else _nums.Insert(i, val);
            }

            var n = _nums[_nums.Count - _k];
            return n;
        }
    }






    //    public class Reader4
    //    {

    //        public char[] buffer { get; set; }
    //        public int Read4(char[] buf4)
    //        {
    //            this.buffer = buf4;

    //            return 1;
    //        }

    //}


    //    public class Solution2 : Reader4
    //    {

    //        public int Read(char[] buf, int n)
    //        {

    //            var buffer = new char[4];
    //            var bytesread = 0;

    //            var count = 0;
    //            while (count < n)
    //            {
    //                bytesread = Read4(buffer);
    //                for (var i = 0; i < bytesread && count < n; i++)
    //                {
    //                    buf[count] = buffer[i];
    //                    count++;
    //                }

    //                if (bytesread < 4)
    //                {

    //                    break;
    //                }

    //            }

    //            return bytesread;
    //        }
    //    }










}
