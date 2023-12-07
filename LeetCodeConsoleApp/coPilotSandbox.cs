using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static LeetCodeConsoleApp.Trie2;

namespace LeetCodeConsoleApp
{




    //Create a class for a user
    public class User
    {
        public string name { get; set; }
        public string id { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string country { get; set; }

    }

    //create a class for airbnb
    public class Airbnb
    {
        public List<User> users { get; set; }

        public Airbnb()
        {
            users = new List<User>();
        }

        public void AddUser(User user)
        {
            users.Add(user);
        }

        public void RemoveUser(User user)
        {
            users.Remove(user);
        }

        public void UpdateUser(User user)
        {
            var u = users.Where(x => x.id == user.id).FirstOrDefault();
            if (u != null)
            {
                u.name = user.name;
                u.city = user.city;
                u.state = user.state;
                u.country = user.country;
            }
        }

        public List<User> SearchUser(string name)
        {
            return users.Where(x => x.name == name).ToList();
        }

        public List<User> SearchUser(string city, string state, string country)
        {
            return users.Where(x => x.city == city && x.state == state && x.country == country).ToList();
        }

        public List<User> SearchUser(string city, string state)
        {
            return users.Where(x => x.city == city && x.state == state).ToList();
        }

        public List<User> SearchUsercity(string city)
        {
            return users.Where(x => x.city == city).ToList();
        }

        public List<User> SearchUser(string city, string state, string country, string name)
        {
            return users.Where(x => x.city == city && x.state == state && x.country == country && x.name == name).ToList();
        }

    }






    internal class coPilotSandbox
    {

        public static void Main2(string[] args)
        {
            var s = new Solution();
            var result = s.IsPalindrome(121);
            Console.WriteLine(result);
            Console.ReadKey();

            var doc = XDocument.Load("index.xhml");

            //find all images
            var images = doc.Descendants("img")
                .Select(e => e.Attribute("src").Value)
                .ToList();

            //create bitcoin miner
          //  var miner = new BitcoinMiner();

            //

            //var trie = new Trie2();
            //trie.Insert("apple");
            //trie.Search("apple");   // returns true
            //trie.Search("app");     // returns false
            //trie.StartsWith("app"); // returns true
            //trie.Insert("app");
            //trie.Search("app");     // returns true

            //var trie2 = new Trie2();
            //trie2.Insert("apple");
            //trie2.Insert("app");
            //trie2.Insert("beer");
            //trie2.Insert("add");
            //trie2.Insert("jam");
            //trie2.Insert("rental");
            //trie2.Search("apps");   // returns false
            //trie2.Search("app");     // returns true
            //trie2.Search("ad");     // returns false
            //trie2.Search("applepie"); // returns false
            //trie2.Search("rest");     // returns false
            //trie2.Search("jan");     // returns false
            //trie2.Search("rent");     // returns true
            //trie2.Search("beer");     // returns true
            //trie2.Search("jam");     // returns true
            //trie2.StartsWith("apps"); // returns false
            //trie2.StartsWith("app"); // returns true
            //trie2.StartsWith("ad"); // returns true
            //trie2.StartsWith("applepie"); // returns false
            //trie2.StartsWith("rest"); // returns false
            //trie2.StartsWith("jan"); // returns false
            //trie2.StartsWith("rent"); // returns true
            //trie2.StartsWith("beer"); // returns true
            //trie2.StartsWith("jam"); // returns true
            //trie2.Insert("apps");
            //trie2.Search("apps"); // returns true
            //trie2.StartsWith("apps"); // returns true
        }
  
            //var doc = XDocument.Load("index.xhml");

            ////find all images
            //var images = doc.Descendants("img")
            //    .Select(e => e.Attribute("src").Value)
            //    .ToList();

            ////create bitcoin miner
            //var miner = new BitcoinMiner();

            //




        //write a function that Given the head of a singly linked list, return the middle node of the linked list. If there are two middle nodes, return the second middle node.
        public ListNode MiddleNode(ListNode head)
        {
            var list = new List<ListNode>();
            var current = head;
            while (current != null)
            {
                list.Add(current);
                current = current.next;
            }

            var middle = list.Count / 2;
            return list[middle];
        }
        //You are given an integer array nums. You are initially positioned at the array's first index, and each element in the array represents your maximum jump length at that position. Return true if you can reach the last index, or false otherwise.
        public bool CanJump(int[] nums)
        {
            var max = 0;
            for (var i = 0; i < nums.Length; i++)
            {
                if (i > max)
                {
                    return false;
                }
                max = Math.Max(nums[i] + i, max);
            }
            return true;
        }


        //JUNK, GOT WRONG ANSWER
        //Under the grammar given below, strings can represent a set of lowercase words. Let R(expr) denote the set of words the expression represents. The grammar can best be understood through simple examples:  Single letters represent a singleton set containing that word.  R("a") = {"a"}    R("w") = {"w"}   When we take a comma-delimited list of two or more expressions, we take the union of possibilities.        R("{a,b,c}") = {"a","b","c"}        R("{{a,b},{b,c}}") = {"a","b","c"} (notice the final set only contains each word at most once)    When we concatenate two expressions, we take the set of possible concatenations between two words where the first word comes from the first expression and the second word comes from the second expression.        R("{a,b}{c,d}") = {"ac","ad","bc","bd"}        R("a{b,c}{d,e}f{g,h}") = {"abdfg", "abdfh", "abefg", "abefh", "acdfg", "acdfh", "acefg", "acefh"} Formally, the three rules for our grammar:  For every lowercase letter x, we have R(x) = {x}. For expressions e1, e2, ... , ek with k >= 2, we have R({e1, e2, ...}) = R(e1) ∪ R(e2) ∪ ...  For expressions e1 and e2, we have R(e1 + e2) = {a + b for (a, b) in R(e1) × R(e2)}, where + denotes concatenation, and × denotes the cartesian product. Given an expression representing a set of words under the given grammar, return the sorted list of words that the expression represents.
        public IList<string> BraceExpansionII(string expression)
        {
            var result = new List<string>();
            var stack = new Stack<string>();
            stack.Push("");
            var set = new HashSet<string>();
            var setStack = new Stack<HashSet<string>>();
            setStack.Push(new HashSet<string>());
            var union = false;
            var concat = false;
            foreach (var c in expression)
            {
                if (c == '{')
                {
                    stack.Push("");
                    setStack.Push(new HashSet<string>());
                }
                else if (c == '}')
                {
                    var top = stack.Pop();
                    var topSet = setStack.Pop();
                    if (topSet.Count == 0)
                    {
                        topSet.Add(top);
                    }
                    if (union)
                    {
                        set.UnionWith(topSet);
                    }
                    else if (concat)
                    {
                        var newSet = new HashSet<string>();
                        foreach (var s in topSet)
                        {
                            foreach (var t in set)
                            {
                                newSet.Add(s + t);
                            }
                        }
                        set = newSet;
                    }
                    else
                    {
                        set = topSet;
                    }
                    union = false;
                    concat = false;
                }
                else if (c == ',')
                {
                    union = true;
                }
                else
                {
                    var top = stack.Pop();
                    var topSet = setStack.Pop();
                    if (union)
                    {
                        topSet.Add(top);
                        union = false;
                    }
                    else if (concat)
                    {
                        var newSet = new HashSet<string>();
                        foreach (var s in topSet)
                        {
                            newSet.Add(s + top);
                        }
                        topSet = newSet;
                        concat = false;
                    }
                    else
                    {
                        topSet.Add(top + c);
                    }
                    stack.Push(top);
                    setStack.Push(topSet);
                    stack.Push(c.ToString());
                    setStack.Push(new HashSet<string>());
                }
            }
            var finalSet = setStack.Pop();
            if (finalSet.Count == 0)
            {
                finalSet.Add(stack.Pop());
            }
            result.AddRange(finalSet);
            result.Sort();
            return result;
        }


        //Given two sorted arrays nums1 and nums2 of size m and n respectively, return the median of the two sorted arrays.
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            var nums = new int[nums1.Length + nums2.Length];
            var i = 0;
            var j = 0;
            var k = 0;
            while (i < nums1.Length && j < nums2.Length)
            {
                if (nums1[i] < nums2[j])
                {
                    nums[k] = nums1[i];
                    i++;
                }
                else
                {
                    nums[k] = nums2[j];
                    j++;
                }
                k++;
            }
            while (i < nums1.Length)
            {
                nums[k] = nums1[i];
                i++;
                k++;
            }
            while (j < nums2.Length)
            {
                nums[k] = nums2[j];
                j++;
                k++;
            }
            if (nums.Length % 2 == 0)
            {
                return (nums[nums.Length / 2] + nums[nums.Length / 2 - 1]) / 2.0;
            }
            else
            {
                return nums[nums.Length / 2];
            }
        }



    }
}
