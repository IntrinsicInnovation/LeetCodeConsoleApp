using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;

namespace LeetCodeConsoleApp
{


    public class mycar
    {

        public static int count {  get; private set; }
        public int count2 { get; set; }


        private mycar()
        {
            Console.WriteLine("in Private Consstructor!!");

        }

        static mycar()
        {
            Console.WriteLine("in STATIC Consstructor!!");
        }

        public mycar(int count)
        {
            count2 = count;
            Console.WriteLine("in Regular Consstructor!!");
        }

        public static void increment()
        {
            count++;
        }

    }



    //class a
    //{
    //    public virtual  void area()
    //    {

    //    }
    //}

    //class b : a
    //{
    //    public  override void area()
    //    {

    //    }
    //}


    class MyQueue3
    {

        private Stack<int> s1 = new Stack<int>();

        public int a { get; set; }


        public void Enqueue(int val)
        {
            var s2 = new Stack<int>();


            while (s1.Count > 0)
            {
                s2.Push(s1.Pop());
            }
            s1.Push(val);
            while (s2.Count > 0)
            {
                s1.Push(s2.Pop());
            }

        }

        public int Dequeue()
        {
            if (s1.Count > 0)
                return s1.Pop();
            else
                return -1;
        }


        public int Peek()
        {

            return s1.Peek();
        }

    }


    public class MultiMap<V>
    {
        Dictionary<string, List<V>> _dictionary =
            new Dictionary<string, List<V>>();

        public void Add(string key, V value)
        {
            // Add a key.
            List<V> list;
            if (this._dictionary.TryGetValue(key, out list))
            {
                list.Add(value);
            }
            else
            {
                list = new List<V>();
                list.Add(value);
                this._dictionary[key] = list;
            }
        }

        public IEnumerable<string> Keys
        {
            get
            {
                // Get all keys.
                return this._dictionary.Keys;
            }
        }

        public List<V> this[string key]
        {
            get
            {
                // Get list at a key.
                List<V> list;
                if (!this._dictionary.TryGetValue(key, out list))
                {
                    list = new List<V>();
                    this._dictionary[key] = list;
                }
                return list;
            }
        }
    }


    public class HuffNode
    {
        public int frequency; // the frequency of this tree
        public char? data;
        public HuffNode left, right;
    }



    public class queue
    {

        public Stack<int> instack = new Stack<int>();
        public Stack<int> outstack = new Stack<int>();


        public void enqueue(int n)
        {
            instack.Push(n);
        }

        public void dequeue()
        {
            if (outstack.Count == 0)
            {
                while (instack.Count > 0)
                {
                    outstack.Push(instack.Pop());
                    outstack.Push(instack.Pop());
                }
            }
            outstack.Pop();


        }


        public int peek()
        {
            if (outstack.Count == 0)
            {
                while (instack.Count > 0)
                {
                    outstack.Push(instack.Pop());
                }
            }
            if (outstack.Count > 0)
                return outstack.Peek();
            else
                return -1;
        }


    }



    public class Trie
    {

        /** Initialize your data structure here. */
        public Trie()
        {
            root = new Node();
        }

        /** Inserts a word into the trie. */
        public void Insert(string word)
        {
            var node = root;
            for (var i = 0; i < word.Length; i++)
            {
                if (node.children[word[i] - 'a'] == null) 
                    node.children[word[i] - 'a'] = new Node();

                node = node.children[word[i] - 'a'];
            }
            node.endofword = true;
        }

        /** Returns if the word is in the trie. */
        public bool Search(string word)
        {
            var node = FindWord(word);
            if (node != null && node.endofword)
                return true;
            else
                return false;
        }

        /** Returns if there is any word in the trie that starts with the given prefix. */
        public bool StartsWith(string prefix)
        {
            return FindWord(prefix) != null;
        }

        private Node FindWord(string word)
        {
            var node = root;
            for (var i = 0; i < word.Length; i++)
            {
                if (node.children[word[i] - 'a'] == null)
                    return null;
                node = node.children[word[i] - 'a'];

            }
            return node;
        }


        private Node root;

        class Node
        {
            public Node()
            {
                //this.c = c;
                endofword = false;
                children = new Node[26];
            }
            //char c;
            public bool endofword;
            public Node[] children;
        }
    }


    //public class TimeMap
    //{

    //    Dictionary<string, List<(int, string)>> dict = new Dictionary<string, List<(int, string)>>();

    //    public TimeMap()
    //    {

    //    }

    //    public void Set(string key, string value, int timestamp)
    //    {
    //        if (!dict.ContainsKey(key))
    //        {

    //            dict.Add(key, new List<(int, string)>() { (timestamp, value)});

    //        }
    //        else
    //        {
    //            dict[key].Add((timestamp, value));
    //        }
    //    }

    //    public string Get(string key, int timestamp)
    //    {
    //        List<(int, string)> list;
    //        if (!dict.TryGetValue(key, out list))
    //            return "";

    //        list.Sort();






    //            var max = dict[key].Where(d => d.Item1 <= timestamp).OrderByDescending(d => d.Item1).FirstOrDefault();
    //        if (max.Item2 != null)
    //            return max.Item2;







    //    }


    //}





    public class Trie2
    {
        public struct Letter
        {
            public const string Chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            public static implicit operator Letter(char c)
            {
                return new Letter() { Index = Chars.IndexOf(c) };
            }
            public int Index;
            public char ToChar()
            {
                return Chars[Index];
            }
            public override string ToString()
            {
                return Chars[Index].ToString();
            }
        }

        public class Node
        {
            public string Word;
            public bool IsTerminal { get { return Word != null; } }
            public Dictionary<Letter, Node> Edges = new Dictionary<Letter, Node>();
        }

        public Node Root = new Node();

        public Trie2(string[] words)
        {
            for (int w = 0; w < words.Length; w++)
            {
                var word = words[w];
                var node = Root;
                for (int len = 1; len <= word.Length; len++)
                {
                    var letter = word[len - 1];
                    Node next;
                    if (!node.Edges.TryGetValue(letter, out next))
                    {
                        next = new Node();
                        if (len == word.Length)
                        {
                            next.Word = word;
                        }
                        node.Edges.Add(letter, next);
                    }
                    node = next;
                }
            }
        }

    }






        public class LRUCache
    {

        Dictionary<int, int> cache = new Dictionary<int, int>();
        int count;
        int capacity;

        List<int> lru;
        public LRUCache(int capacity)
        {
            this.capacity = capacity;
            cache.TrimExcess(capacity);
            lru = new List<int>(capacity);
        }

        public int get(int key)
        {
            if (cache.ContainsKey(key))
            {
                lru.Remove(key);
                lru.Add(key);

                return cache[key];

            }
            else
                return -1;
        }

        public void put(int key, int value)
        {
            if (!cache.ContainsKey(key) && count == capacity)
            {


                cache.Remove(lru[0]);
                cache.Add(key, value);
                lru.RemoveAt(0);
                lru.Add(key);

            }
            else if (!cache.ContainsKey(key))
            {
                cache.Add(key, value);
                lru.Add(key);
                count++;

            }
            else
            {
                cache[key] = value;
                lru.RemoveAt(key);
                lru.Add(key);
            }



        }
    }



    public class Node2
    {
        public String str;
        public int steps;

        public Node2(String str, int steps)
        {
            this.str = str;
            this.steps = steps;
        }
    }

    public class Node4
    {
        public int val;
        public Node4 left;
        public Node4 right;
        public Node4 next;

        public Node4() { }

        public Node4(int _val)
        {
            val = _val;
        }

        public Node4(int _val, Node4 _left, Node4 _right, Node4 _next)
        {
            val = _val;
            left = _left;
            right = _right;
            next = _next;
        }
    }


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

    //public class Trie
    //{
    //    private readonly TreeNode2 _root;

    //    public Trie()
    //    {
    //        _root = new TreeNode2('^', 0, null);
    //    }

    //    public TreeNode2 Prefix(string s)
    //    {
    //        var currentNode = _root;
    //        var result = currentNode;

    //        foreach (var c in s)
    //        {
    //            currentNode = currentNode.FindChildNode(c);
    //            if (currentNode == null)
    //                break;
    //            result = currentNode;
    //        }

    //        return result;
    //    }

    //    public bool Search(string s)
    //    {
    //        var prefix = Prefix(s);
    //        return prefix.Depth == s.Length && prefix.FindChildNode('$') != null;
    //    }

    //    public void InsertRange(List<string> items)
    //    {
    //        for (int i = 0; i < items.Count; i++)
    //            Insert(items[i]);
    //    }

    //    public void Insert(string s)
    //    {
    //        var commonPrefix = Prefix(s);
    //        var current = commonPrefix;

    //        for (var i = current.Depth; i < s.Length; i++)
    //        {
    //            var newNode = new TreeNode2(s[i], current.Depth + 1, current);
    //            current.Children.Add(newNode);
    //            current = newNode;
    //        }

    //        current.Children.Add(new TreeNode2('$', current.Depth + 1, current));
    //    }

    //    public void Delete(string s)
    //    {
    //        if (Search(s))
    //        {
    //            var node = Prefix(s).FindChildNode('$');

    //            while (node.IsLeaf())
    //            {
    //                var parent = node.Parent;
    //                parent.DeleteChildNode(node.Value);
    //                node = parent;
    //            }
    //        }
    //    }

    //}




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

        public static void MoveToTop<T>(this List<T> list, int index)
        {
            T item = list[index];
            for (int i = index; i > 0; i--)
                list[i] = list[i - 1];
            list[0] = item;
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


        public T PeekMax()
        {
            T frontItem = data[data.Count-1];
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


    public class StringListNode
    {
        public string val;
        public StringListNode next;
        public StringListNode(string s) { val = s; }
    }

    class ChrisCustom : IComparable<ChrisCustom>
    {

        public int val { get; set; }

        public ChrisCustom(int val)
        {
            this.val = val;
        }


        public int CompareTo(ChrisCustom that)
        {
            if (this.val > that.val)
                return -1;
            else if (this.val == that.val)
                return 0;
            else return 1;
        }
    }



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




    //static class Glider
    //{
    //    public static void start(int a)
    //    {
    //        return;
    //    }
    //}



    public class c1
    {
        c2 o = new c2();
        public c1()
        {

            Console.WriteLine("in class c1");

        }

    }


    public class c2
    {
        c1 o = new c1();
        public c2()
        {

            Console.WriteLine("in class c2");

        }

    }







    //learn to create class to read files:

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
