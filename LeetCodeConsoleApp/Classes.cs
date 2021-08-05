﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeConsoleApp
{


    public class TreeNode2
    {
        public char Value { get; set; }
        public List<TreeNode2> Children { get; set; }
        public TreeNode2 Parent { get; set; }
        public int Depth { get; set; }

        public TreeNode2(char value, int depth, TreeNode2 parent)
        {
            Value = value;
            Children = new List<TreeNode2>();
            Depth = depth;
            Parent = parent;
        }

        public bool IsLeaf()
        {
            return Children.Count == 0;
        }

        public TreeNode2 FindChildNode(char c)
        {
            foreach (var child in Children)
                if (child.Value == c)
                    return child;

            return null;
        }

        public void DeleteChildNode(char c)
        {
            for (var i = 0; i < Children.Count; i++)
                if (Children[i].Value == c)
                    Children.RemoveAt(i);
        }
    }

    public class Trie
    {
        private readonly TreeNode2 _root;

        public Trie()
        {
            _root = new TreeNode2('^', 0, null);
        }

        public TreeNode2 Prefix(string s)
        {
            var currentNode = _root;
            var result = currentNode;

            foreach (var c in s)
            {
                currentNode = currentNode.FindChildNode(c);
                if (currentNode == null)
                    break;
                result = currentNode;
            }

            return result;
        }

        public bool Search(string s)
        {
            var prefix = Prefix(s);
            return prefix.Depth == s.Length && prefix.FindChildNode('$') != null;
        }

        public void InsertRange(List<string> items)
        {
            for (int i = 0; i < items.Count; i++)
                Insert(items[i]);
        }

        public void Insert(string s)
        {
            var commonPrefix = Prefix(s);
            var current = commonPrefix;

            for (var i = current.Depth; i < s.Length; i++)
            {
                var newNode = new TreeNode2(s[i], current.Depth + 1, current);
                current.Children.Add(newNode);
                current = newNode;
            }

            current.Children.Add(new TreeNode2('$', current.Depth + 1, current));
        }

        public void Delete(string s)
        {
            if (Search(s))
            {
                var node = Prefix(s).FindChildNode('$');

                while (node.IsLeaf())
                {
                    var parent = node.Parent;
                    parent.DeleteChildNode(node.Value);
                    node = parent;
                }
            }
        }

    }




    class RandomPick
    {

        Random random = new Random();
        int[] nums;

        public RandomPick(int[] nums)
        {
            this.nums = nums;
        }

        //My solution does work though.  23 percent slower than the Pick() method below.
        public int MyPick(int target)
        {

            var valueindexes = nums.Select((value, index) => new { value, index }).Where(pair => pair.value == target).ToList();



            var randomindex = random.Next(valueindexes.Count());



            return valueindexes[randomindex].index;


        }


        //public int Pick(int target)
        //{
        //    var candidate = -1;
        //    var n = nums.Length;

        //    var count = 0;
        //    for (int i = 0; i < n; i++)
        //    {
        //        if (nums[i] != target) continue;

        //        count++;

        //        var randomIndex = random.Next(count);
        //        if (randomIndex == 0)
        //        {
        //            candidate = i;

        //        }
        //    }
        //    return candidate;
        //}

    }


    public class MyCalendarTwo
    {

        private SortedDictionary<int, int> _dict;
        public MyCalendarTwo()
        {
            _dict = new SortedDictionary<int, int>();
        }

        /// <summary>
        /// foreach start you add a pair of (start,1)
        /// foreach end you add a pair of (end,-1)
        /// the list is sorted we add and remove events.
        /// if we can more then 3 events added at the same time.
        /// we need to remove the event 
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public bool Book(int start, int end)
        {
            //   s1------e1
            // s-----e
            //      s---e
            // s------------e
            //      s---------e
            //s--e good
            //               s--e

            if (!_dict.TryGetValue(start, out var temp))
            {
                _dict.Add(start, temp + 1);
            }
            else
            {
                _dict[start]++;
            }

            if (!_dict.TryGetValue(end, out var temp1))
            {
                _dict.Add(end, temp1 - 1);
            }
            else
            {
                _dict[end]--;
            }

            int active = 0;
            foreach (var d in _dict.Values)
            {
                active += d;
                if (active >= 3)
                {
                    _dict[start]--;
                    _dict[end]++;
                    //if (_dict[start] == 0)
                    // {
                    //     _dict.Remove(start);
                    // }

                    return false;
                }
            }

            return true;
        }

    }

    public class MyCalendarSoso // Fails a few test cases;
    {

        private List<int[]> booked;
        private List<int[]> doublebooked;
        public MyCalendarSoso()
        {
            doublebooked = new List<int[]>();
            booked = new List<int[]>();
        }

        public bool Book(int start, int end)
        {
            if (booked.Count == 0)
                booked.Add(new int[] { start, end });
            else

            if (booked.Count >= 1)
            {
                var triple = doublebooked.Any(db => db[1] > start && db[0] < end);
                if (triple)
                    return false;
                else
                {
                    CalcDb(start, end);
                    booked.Add(new int[] { start, end });
                }
            }



            return true;
        }

        private void CalcDb(int start, int end)
        {

            var outerinner = false;
            var ind = booked.FindIndex(b => b[0] >= start && b[1] <= end);
            if (ind >= 0)
            {
                doublebooked.Add(new int[] { booked[ind][0], booked[ind][1] });
                outerinner = true;
            }
            else
            {
                ind = booked.FindIndex(b => b[0] < start && b[1] > end);
                if (ind >= 0)
                {
                    doublebooked.Add(new int[] { start, end });
                    outerinner = true;
                }

            }

            if (outerinner == false)
            {


                ind = booked.FindIndex(b => b[0] < end && b[0] >= start);
                if (ind >= 0)
                    doublebooked.Add(new int[] { booked[ind][0], end });


                ind = booked.FindIndex(b => b[1] > start && b[1] <= end);
                if (ind >= 0)
                    doublebooked.Add(new int[] { start, booked[ind][1] });


            }

        }
    }





    static class Extensions
    {
        public static void AddSorted<T>(this List<T> list, T value)
        {
            int x = list.BinarySearch(value);
            list.Insert((x >= 0) ? x : ~x, value);
        }
    }


    public class ListEqualityComparer<T> : IEqualityComparer<List<T>>
    {
        private readonly IEqualityComparer<T> _itemEqualityComparer;

        public ListEqualityComparer() : this(null) { }

        public ListEqualityComparer(IEqualityComparer<T> itemEqualityComparer)
        {
            _itemEqualityComparer = itemEqualityComparer ?? EqualityComparer<T>.Default;
        }

        public static readonly ListEqualityComparer<T> Default = new ListEqualityComparer<T>();

        public bool Equals(List<T> x, List<T> y)
        {
            if (ReferenceEquals(x, y)) return true;
            if (ReferenceEquals(x, null) || ReferenceEquals(y, null)) return false;
            return x.Count == y.Count && !x.Except(y, _itemEqualityComparer).Any();
        }

        public int GetHashCode(List<T> list)
        {
            int hash = 17;
            foreach (var itemHash in list.Select(x => _itemEqualityComparer.GetHashCode(x))
                                         .OrderBy(h => h))
            {
                hash += 31 * itemHash;
            }
            return hash;
        }
    }




    class Node3
    {
        public int[] perm;
        public int steps;

        public Node3(int[] perm, int steps)
        {
            this.perm = perm;
            this.steps = steps;
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Born { get; set; }
        public int Death { get; set; }
    }

    public class Query
    {
        public int u;
        public char c;
    }



    public class MaxHeap
    {
        private readonly int[] _elements;
        private int _size;

        public MaxHeap(int size)
        {
            _elements = new int[size];
        }

        private int GetLeftChildIndex(int elementIndex) => 2 * elementIndex + 1;
        private int GetRightChildIndex(int elementIndex) => 2 * elementIndex + 2;
        private int GetParentIndex(int elementIndex) => (elementIndex - 1) / 2;

        private bool HasLeftChild(int elementIndex) => GetLeftChildIndex(elementIndex) < _size;
        private bool HasRightChild(int elementIndex) => GetRightChildIndex(elementIndex) < _size;
        private bool IsRoot(int elementIndex) => elementIndex == 0;

        private int GetLeftChild(int elementIndex) => _elements[GetLeftChildIndex(elementIndex)];
        private int GetRightChild(int elementIndex) => _elements[GetRightChildIndex(elementIndex)];
        private int GetParent(int elementIndex) => _elements[GetParentIndex(elementIndex)];

        private void Swap(int firstIndex, int secondIndex)
        {
            var temp = _elements[firstIndex];
            _elements[firstIndex] = _elements[secondIndex];
            _elements[secondIndex] = temp;
        }

        public bool IsEmpty()
        {
            return _size == 0;
        }

        public int Count()
        {
            return _size;
        }

        public int Peek()
        {
            if (_size == 0)
                throw new IndexOutOfRangeException();

            return _elements[0];
        }

        public int Pop()
        {
            if (_size == 0)
                throw new IndexOutOfRangeException();

            var result = _elements[0];
            _elements[0] = _elements[_size - 1];
            _size--;

            ReCalculateDown();

            return result;
        }

        public void Add(int element)
        {
            if (_size == _elements.Length)
                throw new IndexOutOfRangeException();

            _elements[_size] = element;
            _size++;

            ReCalculateUp();
        }

        private void ReCalculateDown()
        {
            int index = 0;
            while (HasLeftChild(index))
            {
                var biggerIndex = GetLeftChildIndex(index);
                if (HasRightChild(index) && GetRightChild(index) > GetLeftChild(index))
                {
                    biggerIndex = GetRightChildIndex(index);
                }

                if (_elements[biggerIndex] < _elements[index])
                {
                    break;
                }

                Swap(biggerIndex, index);
                index = biggerIndex;
            }
        }

        private void ReCalculateUp()
        {
            var index = _size - 1;
            while (!IsRoot(index) && _elements[index] > GetParent(index))
            {
                var parentIndex = GetParentIndex(index);
                Swap(parentIndex, index);
                index = parentIndex;
            }
        }


    }



    public class PriorityQueue<T> where T : IComparable<T>  //min heap same thing?
    {
        private List<T> data;

        public PriorityQueue()
        {
            this.data = new List<T>();
        }

        public void Enqueue(T item)
        {
            data.Add(item);
            int ci = data.Count - 1; // child index; start at end
            while (ci > 0)
            {
                int pi = (ci - 1) / 2; // parent index
                if (data[ci].CompareTo(data[pi]) >= 0) break; // child item is larger than (or equal) parent so we're done
                T tmp = data[ci]; data[ci] = data[pi]; data[pi] = tmp;
                ci = pi;
            }
        }

        public T Dequeue()
        {
            // assumes pq is not empty; up to calling code
            int li = data.Count - 1; // last index (before removal)
            T frontItem = data[0];   // fetch the front
            data[0] = data[li];
            data.RemoveAt(li);

            --li; // last index (after removal)
            int pi = 0; // parent index. start at front of pq
            while (true)
            {
                int ci = pi * 2 + 1; // left child index of parent
                if (ci > li) break;  // no children so done
                int rc = ci + 1;     // right child
                if (rc <= li && data[rc].CompareTo(data[ci]) < 0) // if there is a rc (ci + 1), and it is smaller than left child, use the rc instead
                    ci = rc;
                if (data[pi].CompareTo(data[ci]) <= 0) break; // parent is smaller than (or equal to) smallest child so done
                T tmp = data[pi]; data[pi] = data[ci]; data[ci] = tmp; // swap parent and child
                pi = ci;
            }
            return frontItem;
        }

        public T Peek()
        {
            T frontItem = data[0];
            return frontItem;
        }

        public int Count()
        {
            return data.Count;
        }

        public override string ToString()
        {
            string s = "";
            for (int i = 0; i < data.Count; ++i)
                s += data[i].ToString() + " ";
            s += "count = " + data.Count;
            return s;
        }

        public bool IsConsistent()
        {
            // is the heap property true for all data?
            if (data.Count == 0) return true;
            int li = data.Count - 1; // last index
            for (int pi = 0; pi < data.Count; ++pi) // each parent index
            {
                int lci = 2 * pi + 1; // left child index
                int rci = 2 * pi + 2; // right child index

                if (lci <= li && data[pi].CompareTo(data[lci]) > 0) return false; // if lc exists and it's greater than parent then bad.
                if (rci <= li && data[pi].CompareTo(data[rci]) > 0) return false; // check the right child too.
            }
            return true; // passed all checks
        } // IsConsistent
    } // PriorityQueue



    public class GraphNode
    {
        public int val;
        public IList<GraphNode> neighbors;

        public GraphNode()
        {
            val = 0;
            neighbors = new List<GraphNode>();
        }

        public GraphNode(int _val)
        {
            val = _val;
            neighbors = new List<GraphNode>();
        }

        public GraphNode(int _val, List<GraphNode> _neighbors)
        {
            val = _val;
            neighbors = _neighbors;
        }
    }


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
