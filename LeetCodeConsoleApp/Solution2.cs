using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Diagnostics;
using System.Linq;
using System.Net.Security;
using System.Numerics;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using static LeetCodeConsoleApp.Solution.editor;
using System.Collections.Immutable;
using System.Security.Cryptography;
using LeetCodeConsoleApp;

namespace LeetCodeConsoleApp
{


    //Practice nested classes:

    public class OuterClass
    {
        public InnerClass Ic { get; set; }

        public class InnerClass
        {
            public InnerClass()
            {
                Foo = 42;
            }

            public int Foo { get; set; }
        }
    }

    




    internal class Solution2
    {



        /****************************************************************************************************************************************/
        //leetcode  827

        private int n;
            private int[][] directions = new int[][] { new int[] { 1, 0 }, new int[] { -1, 0 }, new int[] { 0, 1 }, new int[] { 0, -1 } };

            public int LargestIsland(int[][] grid)
            {
                n = grid.Length;
                int maxIslandSize = 0;
                Dictionary<int, int> islandSizes = new Dictionary<int, int>();
                int islandId = 2; // Start from 2 to differentiate from 0 and 1

                // Step 1: Identify all islands and their sizes
                for (int r = 0; r < n; r++)
                {
                    for (int c = 0; c < n; c++)
                    {
                        if (grid[r][c] == 1)
                        {
                            int size = DFS(grid, r, c, islandId);
                            islandSizes[islandId] = size;
                            maxIslandSize = Math.Max(maxIslandSize, size);
                            islandId++;
                        }
                    }
                }

                // Step 2: Check each 0 to see if converting it to 1 can create a larger island
                for (int r = 0; r < n; r++)
                {
                    for (int c = 0; c < n; c++)
                    {
                        if (grid[r][c] == 0)
                        {
                            HashSet<int> seenIslands = new HashSet<int>();
                            int potentialSize = 1; // Start with 1 for the current 0 being turned into 1

                            var dirlen = directions.Length;
                            for (var i = 0; i < dirlen; i++)
                            {
                                //foreach (var dir in directions) {
                                var dir = directions[i];
                                int nr = r + dir[0], nc = c + dir[1];
                                if (IsValid(nr, nc) && grid[nr][nc] > 1 && !seenIslands.Contains(grid[nr][nc]))
                                {
                                    seenIslands.Add(grid[nr][nc]);
                                    potentialSize += islandSizes[grid[nr][nc]];
                                }
                            }

                            maxIslandSize = Math.Max(maxIslandSize, potentialSize);
                        }
                    }
                }

                return maxIslandSize;
            }

            private int DFS(int[][] grid, int r, int c, int islandId)
            {
                if (!IsValid(r, c) || grid[r][c] != 1) return 0;

                grid[r][c] = islandId;
                int size = 1;

                foreach (var dir in directions)
                {
                    size += DFS(grid, r + dir[0], c + dir[1], islandId);
                }

                return size;
            }

            private bool IsValid(int r, int c)
            {
                return r >= 0 && r < n && c >= 0 && c < n;
            }
      


/****************************************************************************************************************************************/




        //got it working reasonably fast from scratch, no ai assist needed.
        public ListNode AddTwoNumbers2(ListNode l1, ListNode l2)
        {
             var curr = new ListNode(-1);
            var head = curr;

            var remainder = 0;
            var i = 0;
            while (l1 != null || l2 != null)
            {

                var val1 = (l1 == null) ? 0 : l1.val;
                var val2 = (l2 == null) ? 0 : l2.val;
                var sum = val1 + val2;
                sum = (sum + remainder) % 10;
                curr.next = new ListNode(0);
                curr = curr.next;
                curr.val = sum;

                remainder = (val1 + val2 + remainder) / 10;

                if (l1 != null)
                    l1 = l1.next;
                if (l2 != null)
                    l2 = l2.next;

                i++;
            }

            if (remainder > 0)
            {
                curr.next = new ListNode(0);
                curr = curr.next;
                curr.val = remainder;
            }
            


            return head.next;
        }



        //Leetcode hard atlassian:
        // learn this:

        /*

                Input: s = "103301"
        Output: 2
        Explanation: 
        There are 6 possible subsequences of length 5: "10330","10331","10301","10301","13301","03301". 
        Two of them(both equal to "10301") are palindromic.

        Example 2:

        Input: s = "0000000"
        Output: 21
        Explanation: All 21 subsequences are "00000", which is palindromic.

        Example 3:

        Input: s = "9999900000"
        Output: 2
        Explanation: The only two palindromic subsequences are "99999" and "00000".

        */



        private const int M = 1_000_000_000 + 7;

        public int CountPalindromes(string s)
        {

            int n = s.Length;
            long totalCount = 0;

            // for palindromes of the form "cd.dc", we will check
            // every possible combination of "cd" from "00" to "99"
            for (char c = '0'; c <= '9'; c++)
            {
                for (char d = '0'; d <= '9'; d++)
                {

                    // number of combinations of "cd." up to each index (inclusive)
                    long[] startCount = new long[n];

                    // number of combinations of "cd"
                    long cBeforeD = 0;

                    // number of "c"
                    long cCount = 0;

                    // scan forwards to populate startCount
                    for (int i = 0; i < n; i++)
                    {
                        startCount[i] = cBeforeD;

                        // use multiple if instead of if/else for when c == d
                        char ch = s[i];
                        if (ch == d)
                        {
                            cBeforeD += cCount;
                        }
                        if (ch == c)
                        {
                            cCount++;
                        }
                    }

                    // reset counts
                    cBeforeD = 0;
                    cCount = 0;

                    // scan backwards to update totalCount, stop at i == 3
                    // because startCount counts the first 3 characters "cd."
                    for (int i = n - 1; i >= 3; i--)
                    {
                        char ch = s[i];
                        if (ch == d)
                        {
                            cBeforeD += cCount;
                        }
                        if (ch == c)
                        {
                            cCount++;
                        }

                        // the update to totalCount is the number of combinations of "dc"
                        // encountered so far multiplied by the number of combinations
                        // of "cd." up to index i - 1
                        totalCount = (totalCount + cBeforeD * startCount[i - 1]) % M;
                    }
                }
            }

            return (int)totalCount;
        }







        //Atlassian Full stack 2nd interview.  PASSED!!
        //
        //Imagine you are the team that maintains the Atlassian employee directory.
        //At Atlassian - there are multiple groups, and each can have one or more groups. Every employee is part of a group.
        //You are tasked with designing a system that could find the closest common parent group given a target set of employees in the organization.
        //Write it using depth first search if possible

        //Just wrote it using recursion.



        public class EmpGroup
        {

            public string Name { get; set; }
            public List<EmpGroup> SubGroups { get; set; }
            public List<string> Employees { get; set; }


            public EmpGroup(string name)
            {

                Name = name;
                SubGroups = new List<EmpGroup>();
                Employees = new List<string>();

            }

        }

        public class EmployeeDirectory
        {

            private EmpGroup root;


            public EmployeeDirectory(EmpGroup root)
            {
                this.root = root;
            }

            public string FindClosestCommonParent(List<string> employees)
            {
                return FindLCA(root, employees).Name;

            }


            private EmpGroup FindLCA(EmpGroup currentGroup, List<string> targetEmployees)
            {

                if (currentGroup == null)
                    return null;

                if (currentGroup.Employees.Exists(emp => targetEmployees.Contains(emp)))
                    return currentGroup;


                EmpGroup temp = null;
                var count = 0;

                foreach (var subgroup in currentGroup.SubGroups)
                {
                    var result = FindLCA(subgroup, targetEmployees);
                    if (result != null)
                    {
                        count++;
                        temp = result;
                    }

                }

                if (count > 1)
                    return currentGroup;


                return temp;

            }


        }




        //Leetcode hard.  doesn't work I think.
            public IList<string> FullJustify(string[] words, int maxWidth)
        {

            var len = words.Length;


            var results = new List<string>();
            var i = 0;
            var lastwordadded = false;
            while (i < len && !lastwordadded)
            {
                var linelen = 0;
                var startindex = i;
                var tempspaces = 0;
                while (i < len && (linelen + tempspaces) < maxWidth)
                {
                   /* if (linelen + words[i].Length >= maxWidth)
                    {
                        //i++;
                        break;
                    } */

                    linelen += words[i].Length;
                    if (startindex < i)
                        tempspaces++;
                    i++;
                }
                i--;


                float numspaces = 0;
                if (i > startindex)
                { 
                    linelen -= words[i].Length;
                    numspaces = ((maxWidth - linelen) / (i - 1 - startindex));
                }
                else
                {
                    numspaces = maxWidth - linelen;
                }

                    var numspacesrounded = 0;

                var isint = Int32.TryParse(numspaces.ToString(), out numspacesrounded);
                if (!isint)
                {
                    numspacesrounded = Convert.ToInt32(Math.Ceiling(numspaces));
                }

                var sb = new StringBuilder();

                var lastnumspaces = 0;
                if (!isint)
                {
                    lastnumspaces = maxWidth - (i - 1 - startindex - 1) * numspacesrounded;
                }



                if (startindex == i)
                {

                    sb.Append(words[i]);
                    sb.Append("".PadRight(numspacesrounded));
                    if (i == len - 1)
                        lastwordadded = true;
                }
                else

                { 
                    for (var j = startindex; j < i; j++)
                    {
                        sb.Append(words[j]);
                        if (j == i - 1 && !isint)
                        {
                            sb.Append("".PadRight(lastnumspaces));
                        }
                        else if (j < i - 1)
                        {
                            sb.Append("".PadRight(numspacesrounded));
                        }
                        if (j == len - 1)
                            lastwordadded = true;
                    }
                }
                results.Add(sb.ToString());


            }


            return results;
        }









        //Generated by CoCheat.com:
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode[] nodes)
        {
            HashSet<TreeNode> nodeSet = new HashSet<TreeNode>(nodes);
            return LCAHelper(root, nodeSet);
        }

        private TreeNode LCAHelper(TreeNode root, HashSet<TreeNode> nodeSet)
        {
            if (root == null)
            {
                return null;
            }

            TreeNode left = LCAHelper(root.left, nodeSet);
            TreeNode right = LCAHelper(root.right, nodeSet);

            if (left != null && right != null)
            {
                return root;
            }

            if (nodeSet.Contains(root))
            {
                return root;
            }

            return left != null ? left : right;
        }



        public string FindScrambledWord(string[] words, string note)
        {
            var noteCharCount = getFrequency(note);

            foreach (var word in words)
            {
                var wordCharCount = getFrequency(word);

                if (canFormWord(wordCharCount, noteCharCount))
                {
                    return word;
                }

            }

            return "-";

        }

        private  Dictionary<char, int> getFrequency(string str)
        {
            var charCount = new Dictionary<char, int>();
            foreach (var c in str)
            {
                if (charCount.ContainsKey(c))
                {
                    charCount[c]++;
                }
                else
                {
                    charCount[c] = 1;
                }
            }

            /*  foreach (var c in charCount)
              {
                  Console.WriteLine("key: " + c.Key);
                  Console.WriteLine("value: " + c.Value);
              }  */

            Console.WriteLine();
            return charCount;


        }


        private  bool canFormWord(Dictionary<char, int> wordCharCount, Dictionary<char, int> noteCharCount)
        {
            foreach (var kvp in wordCharCount)
            {

                var c = kvp.Key;
                var count = kvp.Value;

                Console.WriteLine("key: " + c);
                Console.WriteLine("value: " + count);


                if (!noteCharCount.ContainsKey(c) || noteCharCount[c] < count)
                    return false;

            }

            return true;
        }




        //Need custom comparer to improve function below!!!

        public string RankTeams(string[] votes)
            {
                var len = votes.Length;
                if (len == 1)
                    return votes[0];
                var result = new StringBuilder();
                var dict = new Dictionary<int, Dictionary<char, int>>();


                for (var row = 0; row < len; row++)
                {
                    for (var col = 0; col < votes[0].Length; col++)
                    {
                        if (!dict.ContainsKey(col))
                        {
                            dict[col] = new Dictionary<char, int>()
                            {
                                { votes[row][col], 1 }
                            };
                        }

                        else
                        {
                            if (dict[col].ContainsKey(votes[row][col]))
                            {
                                dict[col][votes[row][col]]++;
                            }
                            else
                            {
                                dict[col][votes[row][col]] = 1;
                            }
                        }

                    }

                }

                foreach(var d in dict)
            {
                var counts = d.Value.OrderByDescending(d => d.Value, Comparer<int>.Create((a,b) => a.CompareTo(b))).Select(d => d.Key).First();
                result.Append(counts);
                //var a = d.Key;
                //var b = d.Value;

            }
                return result.ToString();

            }
      



        //Atlassian.

        //changed to binary search to optimize
        // var shoppinglist = new string[] { "steak", "butter", "apples", "milk" };
        // var products = new string[][] { new string[] { "apples", "produce" }, new string[] { "butter", "dairy" }, new string[] { "milk", "dairy" }, new string[] { "steak", "meat" } };



        public int CalculateSaved(string[] shoppingList, string[][] products)
        {
            if (shoppingList == null || shoppingList.Count() == 0)
                return 0;

            HashSet<string> uniqueDepartments = new HashSet<string>();
            var lastDepartment = "";
            var transitions = 0;

            foreach (var item in shoppingList)
            {
                var currentDepartment = lookup(item, products);
                uniqueDepartments.Add(currentDepartment);

                if (currentDepartment != lastDepartment)
                {
                    transitions++;
                    lastDepartment = currentDepartment;
                }
            }


            var difference = transitions - uniqueDepartments.Count;
            return difference;
        }

        static string lookup(string item, string[][] products)
        {



            /* int index = Array.BinarySearch(
           products,
           searchKey,
           Comparer<string[]>.Create((a, b) => string.Compare(a[0], b[0], StringComparison.OrdinalIgnoreCase))
       );  */



            //var rowzero = products[0];
            var result = Array.BinarySearch(products, item, Comparer<object>.Create((x, y) =>
            {
                string key = x as string ?? (x as string[])?[0] ?? "";
                string val = y as string ?? (y as string[])?[0] ?? "";
                return string.Compare(key, val, StringComparison.OrdinalIgnoreCase);
            }));

            /*  foreach (var product in products)
              {
                  if (product[0] == item)
                      return product[1];
              }
               return ""; */

            return products[result][1];
        }




        //IComparer comparer = Comparer<object>.Create((x, y) =>
        //{
        //    string keyX = x is string[] arrX ? arrX[0] : x?.ToString() ?? "";
        //    string keyY = y is string[] arrY ? arrY[0] : y?.ToString() ?? "";
        //    return string.Compare(keyX, keyY, StringComparison.OrdinalIgnoreCase);
        //});

        //// Sort the jagged array


        //// Perform binary search
        //string searchKey = "milk";
        //int index = Array.BinarySearch(products, searchKey, comparer);


        public bool CanPlaceFlowers(int[] flowerbed, int n)
        {

            var len = flowerbed.Length;

            if (len == 1)
            {

                if ((n <= 1 && flowerbed[0] == 0) || (n == 0 && flowerbed[0] == 1))
                    return true;
                else
                    return false;
            }

            var count = 0;

            for (var i = 0; i < flowerbed.Length; i++)
            {
                if (flowerbed[i] == 0)
                {

                    if ((i == 0 && flowerbed[i + 1] == 0) || (i > 0 && i < len - 1 && flowerbed[i - 1] == 0 && flowerbed[i + 1] == 0) || (i == len - 1 && flowerbed[i - 1] == 0))
                    {
                        flowerbed[i] = 1;
                        count++;
                    }

                }

            }

            return count >= n ? true : false;

        }



        public bool CanPlaceFlowers2(int[] flowerbed, int n)
            {

                var len = flowerbed.Length;
                var count = 0;
                var i = 0;
                if (len == 1 && n == 1 & flowerbed[0] == 0)
                    return true;
                while (count < n && i < len)
                {
                    if (flowerbed[i] == 0)
                    {
                        if (i == 0 && flowerbed[i + 1] == 0)
                        {
                            Console.WriteLine("1");
                            count++;
                            flowerbed[i] = 1;
                        }
                        else if (i == len - 1 && flowerbed[i - 1] == 0)
                        {
                            Console.WriteLine("2");
                            count++;
                            flowerbed[i] = 1;
                        }
                        else if (i > 0 && i < len - 1 && flowerbed[i - 1] == 0 && flowerbed[i + 1] == 0)
                        {
                            Console.WriteLine("3");
                            count++;
                            flowerbed[i] = 1;
                        }
                    }
                    i++;
                }


                if (count < n)
                    return false;
                else
                    return true;

            }








        public bool CanPlaceFlowers1(int[] flowerbed, int n)
        {
            var count = 0;
            var len = flowerbed.Length;
            if (len == 1 && n == 1 && flowerbed[0] == 0)
                return true;
            var i = 0;

            while (count < n && i < len)
            {
                if (flowerbed[i] == 0)
                {
                    if (i == 0 && flowerbed[i + 1] == 0)
                    {
                        flowerbed[i] = 1;
                        count++;
                        i += 2;
                    }

                    else if (i == len - 1 && flowerbed[i - 1] == 0)
                    {
                        flowerbed[i] = 1;
                        count++;
                        i += 2;
                    }

                    else if (i > 0 && i < len - 1 && flowerbed[i - 1] == 0 && flowerbed[i + 1] == 0)
                    {

                    }
                }
         
            
            }

            return false;
        }




        //Atlassian:


        /*
You and your friends are driving to a Campground to go camping. Only 2 of you have cars, so you will be carpooling. 

Routes to the campground are linear, so each location will only lead to 1 location and there will be no loops or detours. Both cars will leave from their starting locations at the same time. The first car to pass someone's location will pick them up. If both cars arrive at the same time, the person can go in either car.

Roads are provided as a directed list of connected locations with the duration (in minutes) it takes to drive between the locations. 
[Origin, Destination, Duration it takes to drive]

Given a list of roads, a list of starting locations and a list of people/where they live, return a collection of who will be in each car upon arrival to the Campground.
------------------------------------------------------
Bridgewater--(30)-->Caledonia--(15)-->New Grafton--(5)-->Campground
                                       ^
Liverpool---(10)---Milton-----(30)-----^

roads1 = [
    ["Bridgewater", "Caledonia", "30"], <= The road from Bridgewater to Caledonia takes 30 minutes to drive.
    ["Caledonia", "New Grafton", "15"], 
    ["New Grafton", "Campground", "5"], 
    ["Milton", "New Grafton", "30"],
    ["Liverpool", "Milton", "10"]
]
starts1 = ["Bridgewater", "Liverpool"]
people1 = [
    ["Jessie", "Bridgewater"], ["Travis", "Caledonia"], 
    ["Jeremy", "New Grafton"], ["Katie", "Liverpool"]
]

Car1 path: (from Bridgewater): [Bridgewater(0, Jessie)->Caledonia(30, Travis)->New Grafton(45)->Campground(50)]
Car2 path: (from Liverpool): [Liverpool(0, Katie)->Milton(10)->New Grafton(40, Jeremy)->Campground(45)]

Output (In any order/format):
    [Jessie, Travis], [Katie, Jeremy]
--------------------------------------
Riverport->Chester->Campground
             ^
Halifax------^

roads2 = [["Riverport", "Chester", "40"], ["Chester", "Campground", "60"], ["Halifax", "Chester", "40"]]
starts2 = ["Riverport", "Halifax"]
people2 = [["Colin", "Riverport"], ["Sam", "Chester"], ["Alyssa", "Halifax"]]

Output (In any order/format):
    [Colin, Sam], [Alyssa] OR [Colin], [Alyssa, Sam]
----------------------------------------
Riverport->Bridgewater->Liverpool->Campground

roads3 = [["Riverport", "Bridgewater", "1"], ["Bridgewater", "Liverpool", "1"], ["Liverpool", "Campground", "1"]]
starts3_1 = ["Riverport", "Bridgewater"]
starts3_2 = ["Bridgewater", "Riverport"]
starts3_3 = ["Riverport", "Liverpool"]
people3 = [["Colin", "Riverport"], ["Jessie", "Bridgewater"], ["Sam", "Liverpool"]]

Output (starts3_1/starts3_2):  [Colin], [Jessie, Sam] - (Cars can be in any order)
Output (starts3_3): [Jessie, Colin], [Sam]
----------------------------------------
All Test Cases: (Cars can be in either order)
carpool(roads1, starts1, people1) => [Jessie, Travis], [Katie, Jeremy]
carpool(roads2, starts2, people2) => [Colin, Sam], [Alyssa] OR [Colin], [Alyssa, Sam]
carpool(roads3, starts3_1, people3) => [Colin], [Jessie, Sam]
carpool(roads3, starts3_2, people3) => [Jessie, Sam], [Colin]
carpool(roads3, starts3_3, people3) => [Jessie, Colin], [Sam]
----------------------------------------
Complexity Variable:
n = number of roads



*/

        // Atlassian coding results:

        //Generated from chat gpt .  works:

     //   moved down:




        //beats 91% -- generated from cocheat!!  awesome job!
        public IList<int> FindClosestElements(int[] arr, int k, int x)
        {
            int left = 0;
            int right = arr.Length - 1;

            // Binary search to find the closest element
            while (right - left >= k)
            {
                if (Math.Abs(arr[left] - x) > Math.Abs(arr[right] - x))
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }

            // Collect the k closest elements
            List<int> result = new List<int>();
            for (int i = left; i <= right; i++)
            {
                result.Add(arr[i]);
            }

            return result;
        }



        //good - beets 70%
        public IList<int> FindClosestElements5(int[] arr, int k, int x)
        {


                                                          var result = new List<int>();

            // Base case
            if (arr.Length == k)
            {
                for (int i = 0; i < k; i++)
                {
                    result.Add(arr[i]);
                }

                return result;
            }

            // Binary search to find the closest element
            int left = 0;
            int right = arr.Length;
            int mid = 0;
            while (left < right)
            {
                mid = (left + right) / 2;
                if (arr[mid] >= x)
                {
                    right = mid;
                }
                else
                {
                    left = mid + 1;
                }
            }

            // Initialize our sliding window's bounds
            left -= 1;
            right = left + 1;

            // While the window size is less than k
            while (right - left - 1 < k)
            {
                // Be careful to not go out of bounds
                if (left == -1)
                {
                    right += 1;
                    continue;
                }

                // Expand the window towards the side with the closer number
                // Be careful to not go out of bounds with the pointers
                if (right == arr.Length || Math.Abs(arr[left] - x) <= Math.Abs(arr[right] - x))
                {
                    left -= 1;
                }
                else
                {
                    right += 1;
                }
            }

            // Build and return the window
            for (int i = left + 1;  i < right; i++)
            {
                result.Add(arr[i]);
            }

            return result;
        }



public IList<int> FindClosestElements4(int[] arr, int k, int x)
        {
            var len = arr.Length;
            if (len == k)
                return arr;
            //var mid = Array.BinarySearch(arr, x); // Comparer<int>.Create((a, b) => a.CompareTo(b)));
            var left = 0;
            var right = len - 1;
            var mid = 0;


            do
            {
                mid = left + (right - left) / 2;
                if (x > arr[mid])
                    left = mid + 1;
                else
                    right = mid - 1;
                if (x == arr[mid])
                    break;
            } while (left <= right);





            left--;
            right = left + 1;
            while (right - left -1 < k)
            {
                if (left < 0)
                {
                    right++;
                    continue;
                    
                }
                

                if (right == len || Math.Abs(arr[left] - x) <= Math.Abs(arr[right] - x))
                    left--;
                else
                    right++;

                
            }


            return new List<int>();
        }

        //works, beats 24% on leetcode
        public IList<int> FindClosestElements3(int[] arr, int k, int x)
        {
            var sorted = arr.OrderBy(a => Math.Abs(a - x));
            return sorted.Take(k).OrderBy(a => a).ToList();
        }

        //Fails, as you need a custom comparer on two levels (a - x), then a.
        public IList<int> FindClosestElements2(int[] arr, int k, int x)
        {

            Array.Sort(arr, (a, b) => Math.Abs(a - x) - (Math.Abs(b-x)));
            Array.Sort(arr);
            return arr.Take(k).ToList();

        }


        //Works but beats only 17% on leetcode

        public IList<int> FindClosestElements1(int[] arr, int k, int x)
        {
            var q = new PriorityQueue<int, (int,int)>();

            for (var i = 0; i < arr.Length; i++)
            {
                var elem = arr[i];
                q.Enqueue(elem, (Math.Abs(elem - x), elem));

            }

            var results = new List<int>();
            while (k-- > 0)
            {
                results.Add(q.Dequeue());
            }
            results.Sort();
            return results;
        }



        //META phone interview:



        //        **Parsing the Expression:** The approach involves parsing the string character by character.We maintain a running total (`result`), a `lastNumber` to handle multiplication, and a `currentNumber` to build multi-digit numbers.
        //**Handling Operations:** We process the operations as we encounter them.For addition, we add the `lastNumber` to the `result` and update `lastNumber` with `currentNumber`. For multiplication, we update `lastNumber` by multiplying it with `currentNumber`.
        //**Final Calculation:** After the loop, we add the last processed number to the result to account for the final operation.
        //** Edge Cases:** The solution handles edge cases like empty strings and single-digit expressions by returning 0 or the digit itself.
        //**

        //public class ArithmeticExpressionEvaluator
        //    {
        public int EvaluateArithmeticExpression(string expression)
        {
            if (string.IsNullOrEmpty(expression))
                return 0;
            int currentNumber = 0;
            int lastNumber = 0;
            int result = 0;
            char operation = '+';
            for (int i = 0; i < expression.Length; i++)
            {
                char currentChar = expression[i];
                if (char.IsDigit(currentChar))
                {
                    currentNumber = currentNumber * 10 + (currentChar - '0');
                }
                if (!char.IsDigit(currentChar) && !char.IsWhiteSpace(currentChar) || i == expression.Length - 1)
                {
                    if (operation == '+')
                    {
                        result += lastNumber;
                        lastNumber = currentNumber;
                    }
                    else if (operation == '*')
                    {
                        lastNumber *= currentNumber;
                    }
                    operation = currentChar;
                    currentNumber = 0;
                }
            }
            result += lastNumber;
            return result;
        }








        //META letcode hard past problems generated by GPT.  works OK

        private int max = 0;
        public int DiameterOfBinaryTree(TreeNode root)
        {
            Traverse(root);
            return max;

        }


        private int Traverse(TreeNode node)
        {

            if (node == null)
                return 0;

            var left = Traverse(node.left);
            var right = Traverse(node.right);
            max = Math.Max(max, left + right);
            return Math.Max(left, right) + 1;



        }



        public IList<IList<int>> VerticalOrder(TreeNode root)
        {

            if (root == null)
                return new List<IList<int>>();


            var columnTable = new Dictionary<int, List<int>>();
            var queue = new Queue<(TreeNode node, int column)>();

            queue.Enqueue((root, 0));

            var mincol = 0;
            var maxcol = 0;

            while (queue.Count > 0)
            {
                var (node, column) = queue.Dequeue();

                if (node != null)
                {
                    if (!columnTable.ContainsKey(column))
                    {
                        columnTable[column] = new List<int>();
                    }

                    columnTable[column].Add(node.val);

                    mincol = Math.Min(mincol, column);
                    maxcol = Math.Max(maxcol, column);

                    queue.Enqueue((node.left, column - 1));
                    queue.Enqueue((node.right, column + 1));
                }
            }


            var result = new List<IList<int>>();
            for (var i = mincol; i <= maxcol; i++)
            {
                if (columnTable.ContainsKey(i))
                {
                    result.Add(columnTable[i]);
                }
            }

            return result;
        }



        public int MaxProfit(int[] prices)
        {
            if (prices == null || prices.Length == 0) return 0;
            int n = prices.Length;
            int[] leftProfits = new int[n];
            int[] rightProfits = new int[n + 1];
            // Calculate max profit for one transaction from the left to right
            int minPrice = prices[0];
            for (int i = 1; i < n; i++)
            {
                minPrice = Math.Min(minPrice, prices[i]);
                leftProfits[i] = Math.Max(leftProfits[i - 1], prices[i] - minPrice);
            }
            // Calculate max profit for one transaction from the right to left
            int maxPrice = prices[n - 1];
            for (int i = n - 2; i >= 0; i--)
            {
                maxPrice = Math.Max(maxPrice, prices[i]);
                rightProfits[i] = Math.Max(rightProfits[i + 1], maxPrice - prices[i]);
            }
            // Combine the two profits
            int maxProfit = 0;
            for (int i = 0; i < n; i++)
            {
                maxProfit = Math.Max(maxProfit, leftProfits[i] + rightProfits[i + 1]);
            }
            return maxProfit;
        }



        public IList<IList<int>> VerticalTraversal(TreeNode root)
        {
            if (root == null) return new List<IList<int>>();
            // Dictionary to hold the column index and the list of nodes at that column
            Dictionary<int, List<(int row, int value)>> columnTable = new Dictionary<int, List<(int, int)>>();
            // Queue for BFS traversal
            Queue<(TreeNode node, int row, int col)> queue = new Queue<(TreeNode, int, int)>();
            queue.Enqueue((root, 0, 0));
            int minColumn = 0, maxColumn = 0;
            while (queue.Count > 0)
            {
                var (node, row, col) = queue.Dequeue();
                if (node != null)
                {
                    if (!columnTable.ContainsKey(col))
                    {
                        columnTable[col] = new List<(int, int)>();
                    }
                    columnTable[col].Add((row, node.val));
                    minColumn = Math.Min(minColumn, col);
                    maxColumn = Math.Max(maxColumn, col);
                    queue.Enqueue((node.left, row + 1, col - 1));
                    queue.Enqueue((node.right, row + 1, col + 1));
                }
            }
            List<IList<int>> result = new List<IList<int>>();
            for (int i = minColumn; i <= maxColumn; i++)
            {
                columnTable[i].Sort((a, b) => a.row == b.row ? a.value.CompareTo(b.value) : a.row.CompareTo(b.row));
                List<int> sortedColumn = new List<int>();
                foreach (var pair in columnTable[i])
                {
                    sortedColumn.Add(pair.value);
                }
                result.Add(sortedColumn);
            }
            return result;
        }




        public int Calculate(string s)
        {
            int len = s.Length;
            int currentNumber = 0;
            int result = 0;
            int sign = 1;
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < len; i++)
            {
                char ch = s[i];
                if (char.IsDigit(ch))
                {
                    currentNumber = 0;
                    while (i < len && char.IsDigit(s[i]))
                    {
                        currentNumber = currentNumber * 10 + (s[i] - '0');
                        i++;
                    }
                    i--; // Adjust for the next iteration
                    result += sign * currentNumber;
                }
                else if (ch == '+')
                {
                    sign = 1;
                }
                else if (ch == '-')
                {
                    sign = -1;
                }
                else if (ch == '(')
                {
                    stack.Push(result);
                    stack.Push(sign);
                    result = 0;
                    sign = 1;
                }
                else if (ch == ')')
                {
                    result = stack.Pop() * result + stack.Pop();
                }
            }
            return result;
        }




        public IList<string> AddOperators(string num, int target)
        {
            IList<string> result = new List<string>();
            if (string.IsNullOrEmpty(num)) return result;
            Backtrack(result, num, target, "", 0, 0, 0);
            return result;
        }

        private void Backtrack(IList<string> result, string num, int target, string path, int pos, long eval, long multed)
        {
            if (pos == num.Length)
            {
                if (target == eval)
                {
                    result.Add(path);
                }
                return;
            }
            for (int i = pos; i < num.Length; i++)
            {
                if (i != pos && num[pos] == '0') break; // Skip numbers with leading zeros
                long cur = long.Parse(num.Substring(pos, i - pos + 1));
                if (pos == 0)
                {
                    // First number, pick it without any operator
                    Backtrack(result, num, target, path + cur, i + 1, cur, cur);
                }
                else
                {
                    Backtrack(result, num, target, path + "+" + cur, i + 1, eval + cur, cur);
                    Backtrack(result, num, target, path + "-" + cur, i + 1, eval - cur, -cur);
                    Backtrack(result, num, target, path + "*" + cur, i + 1, eval - multed + multed * cur, multed * cur);
                }
            }
        }




        //leetcode possible Meta question:
        public string MinRemoveToMakeValid(string s)
        {
            var sb = new StringBuilder();

            var len = s.Length;
            //var stack = new Stack<char>();
            //var start = -1;
            //var left = 0;
            //var right = len-1;


            var count = 0;
            for (var i = 0; i < len; i++)
            {
                var c = s[i];
                if (c == '(')
                {
                    sb.Append(c);
                    count++;
                }
                else if (c == ')')
                {
                    if (count > 0)
                    {
                        sb.Append(c);
                        count--;
                    }

                }
                else
                {
                    sb.Append(c);
                }
            }

            count = 0;
            var s2 = sb.ToString();
            sb.Clear();
            for (var i = s2.Length - 1; i >= 0; i--)
            {
                var c = s2[i];
                if (c == ')')
                {
                    sb.Insert(0, c);
                    count++;
                }
                else if (c == '(')
                {
                    if (count > 0)
                    {
                        sb.Insert(0, c);
                        count--;
                    }

                }
                else
                {
                    sb.Insert(0, c);
                }
            }

            return sb.ToString();

        }






        //amazon:
        //phone interview leetcode HARD!!
        //28Feb2025
        //create a solution 

        //to find the shortest path from a word where you only change one letter on each traversal
        //so from "bit"  to "hog"
        //https://leetcode.com/problems/word-ladder/description/
        // Create solution yourself first,  
        //my initial thought was create a graph ie dictionary<string, List<string>>();

        //Then do BFS
        //
        //But, you can skip creating the graph, as you can just bfs through the list of words.





        public long maxprofit(int[] prices)
        {


            var min = Int32.MaxValue;
            long maxprofit = 0;

            for (var i = 0; i < prices.Length; i++)
            {




                if (prices[i] < min)
                    min = prices[i];
                else
                    maxprofit = Math.Max(prices[i] - min, maxprofit);

            }

            return maxprofit;

        }






        public string ReverseWords(string s)
            {
                var stack = new Stack<char>();
                var len = s.Length;
                var i = len - 1;
                var sb = new StringBuilder();

                while (s[i] == ' ')
                    i--;

                for (; i >= 0; i--)
                {
                    var c = s[i];
                    if (c != ' ')
                        stack.Push(c);
                    else
                    {
                        if (stack.Count > 0)
                        {
                            while (stack.Count > 0)
                                sb.Append(stack.Pop());
                            sb.Append(' ');
                            stack.Clear();
                        }

                    }


                }
                while (stack.Count > 0)
                    sb.Append(stack.Pop());

                return sb.ToString().Trim();

            }










        public int LadderLength(string beginWord, string endWord, IList<string> wordList)
        {


            Dictionary<string, int> distances = new Dictionary<string, int>();

            distances[beginWord] = 1;
            var count = 1;
            var q = new Queue<string>();
            q.Enqueue(beginWord);
            var len = wordList.Count();
            while (q.Count > 0)
            {
                var node = q.Dequeue();
              //  Console.WriteLine("dequeued: " + node);
                
                //if (!distances.ContainsKey(node))
               // {
               //     distances[node] = count;
                //}

                if (node == endWord)
                    break;
                var newnodes = diffbyonechar(node, wordList);
                foreach (var newnode in newnodes)
                {
                    if (!distances.ContainsKey(newnode))
                    {
                        distances[newnode] = distances[node] + 1;
                        q.Enqueue(newnode);
                    }
                }
            }

            if (!distances.ContainsKey(endWord))
                return 0;
            else
                return distances[endWord];



        }

        private IList<string> diffbyonechar(string word, IList<string> wordList)
        {
            var results = new List<string>();
            foreach (var wordcompare in wordList)
            {
                if (wordcompare == word) // || distances.ContainsKey(wordcompare))
                    continue;
                var diff = 0;
                for (var i = 0; i < wordcompare.Length; i++)
                {
                    if (word[i] != wordcompare[i])
                        diff++;
                }
                if (diff == 1)
                    results.Add(wordcompare);

            }
            return results;

        }







        public int NumIslands(char[][] grid)
        {
            var islands = 0;
            for (var i = 0; i < grid.Length; i++)
            {
                for (var j = 0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] == '1')
                    {
                        DFS(i, j, grid);
                        islands++;
                    }
                }
            }
            return islands;
        }

        private void DFS(int i, int j, char[][] grid)
        {
            if (i < 0 || i >= grid.Length || j < 0 || j >= grid[0].Length || grid[i][j] == '0')
                return;
            grid[i][j] = '0';
            DFS(i + 1, j, grid);
            DFS(i - 1, j, grid);
            DFS(i, j + 1, grid);
            DFS(i, j - 1, grid);
        }

        public int PartitionString(string s)
        {

            var len = s.Length;
            //var sb = new StringBuilder();
            var hs = new Dictionary<char, int>();
            hs.Add(s[0], 1);
            var count = 1;
            for (var i = 1; i < len; i++)
            {
                if (hs.ContainsKey(s[i]))
                {
                    //Console.WriteLine("DUPE foiund " + s[i]);
                    count++;
                    hs.Clear();
                    hs.Add(s[i], 1);
                }
                else
                {
                    //Console.WriteLine("Added " + s[i]);
                    hs.Add(s[i], 1);
                }
            }

            return count;


        }


        public int LongestSubarray(int[] nums)
        {
            var left = 0;
            var right = 0;
            var len = nums.Length;
            while (left < len && nums[left] == 0)
                left++;
            right = left;
            var nextleft = left;
            var zeros = 0;
            var maxcount = 0;
            while (right < len)
            {
                if (nums[right] == 0)
                {
                    zeros++;
                    if (zeros > 1)
                    {
                        maxcount = Math.Max(maxcount, right - 1 - left);
                        Console.WriteLine("maxcount: " + maxcount + "right: " + right);
                        left = nextleft; //right + 1;
                        right = left;
                        zeros = 0;
                    }
                    else
                    {
                        nextleft = right;
                        while (nextleft < len && nums[nextleft] == 0)
                            nextleft++;
                    }
                }
                right++;
                Console.WriteLine("right: " + right);
            }

            if (zeros == 0 && left == 0)
                zeros = 1;
            maxcount = Math.Max(maxcount, right - zeros - left);
            return maxcount;
        }


        //exponent practice interview:
        public int decodeVariations(string S)
        {
            // your code goes here
            var len = S.Length;
            var dp = new int[len + 1];
            dp[len] = 1;
            for (var i = len - 1; i >= 0; i--)
            {
                if (S[i] == '0')
                    dp[i] = 0;
                else if (S[i] == '1')
                {
                    dp[i] = dp[i + 1];
                    if (i < len -1)
                        dp[i] += dp[i + 2];
                }
                    
                else if (S[i] == '2')
                {
                    dp[i] = dp[i + 1]; 
                    if (i < len -1 && S[i+1] <= '6')
                        dp[i] += dp[i + 2];
                }

                    

                else
                    dp[i] = dp[i + 1];



            }
            return dp[0];


        }


        //Hackerrank practice:
        public void inorderTreeTraversal(TreeNode node, List<int> list)
        {

            if (node == null)
                return;

            inorderTreeTraversal(node.left, list);
            list.Add(node.val);
            inorderTreeTraversal(node.right, list);



        }




        class MyTrie
        {

            private Node head;


            public bool search(string word)
            {
                var node = head;
                var len = word.Length;
                for (var i = 0; i < len; i++)
                {
                    if (node.nodes.ContainsKey(word[i]))
                    {
                        node = node.nodes[word[i]];

                        if (node.nodes[word[i]].isword)
                        {
                            return false;
                        }
                        
                    }

                }



                return true;
            }


            class Node
            {

                public Node()
                {
                    nodes = new Dictionary<char, Node> ();   
                }

                public bool isword;
                public Dictionary<char, Node> nodes;

            }               
                
                
                
        }




        //this fails about 15 test cases though, and too slow:
        //Need to use a TRIE class, create your own
        public void noPrefix(List<string> words)
        {
            var dict = new Dictionary<int, string>();

            var len = words.Count;

            for (var i = 0; i < len; i++)
            {

                var found = words.Where(w => w.StartsWith(words[i]));
                if (found.Count() > 1)
                {
                    var fl = found.ToList();
                    var index = words.IndexOf(fl[1]);
                    dict[index] = fl[1];
                }

            }

            if (dict.Count > 0)
            {
                var badset = dict.OrderBy(d => d.Key).Select(d => d.Value).FirstOrDefault();
                Console.WriteLine("BAD SET");
                Console.WriteLine(badset);
            }
            else
                Console.WriteLine("GOOD SET");
            
        }
    



    public class Trie2
        {




            private class TrieNode2
            {


                TrieNode2() 
                {
                    trieNodes = new TrieNode2[26];
                }

                private TrieNode2[] trieNodes;
                private bool isfound;



            }
        }



        public static int cookies(int k, List<int> A)
        {

           

            var q = new PriorityQueue<int, int>();
            foreach (var a in A)
                q.Enqueue(a, a);
            var count = 0;

            while (q.Peek() < k)
            {
                var lowest = q.Dequeue();
                if (q.Count == 0)
                    return -1;
                var scndlowest = q.Dequeue();
                var newel = lowest + (scndlowest * 2);
                q.Enqueue(newel, newel);
                count++;
            }
            return count;
        }

        public class Editor
        {


            StringBuilder sb;
            Stack<Tuple<string, string>> undoes;

            public Editor()
            {
                sb = new StringBuilder();
                undoes = new Stack<Tuple<string, string>>();
            }

            public void append(string s)
            {
                sb.Append(s);
                undoes.Push(new Tuple<string, string>("appended", s));
            }

            public void delete(int n)
            {
                var len = sb.Length;
                var subs = sb.ToString().Substring(len - n, n);
                sb.Remove(len - n, n);
                undoes.Push(new Tuple<string, string>("deleted", subs));
            }

            public void print(int n)
            {
                var len = sb.Length;
                Console.WriteLine(sb[n - 1]);

            }

            public void undo()
            {
                var toundo = undoes.Pop();
                var len = sb.Length;
                var lenofundostr = toundo.Item2.Count();
                if (toundo.Item1 == "appended")
                {

                    sb.Remove(len - lenofundostr, lenofundostr);
                }
                else
                {
                    sb.Append(toundo.Item2);
                }


            }

        }





        public SinglyLinkedListNode mergeLists3(SinglyLinkedListNode head1, SinglyLinkedListNode head2)
        {
            var curr = new SinglyLinkedListNode(-1);
            var head = curr;

            while (head1 != null || head2 != null)
            {
                if ((head1 != null && head2 != null && head2.data < head1.data)
                    || head1 == null)
                {
                    curr.next = head2;
                    curr = curr.next;
                    head2 = head2.next;
                }
                else
                {
                    curr.next = head1;
                    curr = curr.next;
                    head1 = head1.next;
                }


            }
            return head.next;

        }


        public void minimumBribes4(List<int> q)
        {
            var i = 1;
            var len = q.Count;
            var count = 0;


            for (var j = 0; j < len; j++)
            {
                if (q[j] - (j + 1) >= 3)
                {
                    Console.WriteLine("Too chaotic");
                    return;
                }
            }

            while (i < len)
            {
                if (q[i - 1] > q[i])
                {

                    (q[i - 1], q[i]) = (q[i], q[i - 1]);
                    count++;
                    i -= 2;
                    if (i < 0)
                        i = 0;
                }
                i++;

            }



            Console.WriteLine(count);


        }

        public static int superDigit2(string n, int k)
        {
            var sd = new StringBuilder(n);

            //too slow, so optimize below:
            // for (var i = 0; i < k; i++)
            // {
            //     sd.Append(n);
            // } 
            var firsttime = true;
            while (sd.Length > 1)
            {

                long sum = 0;
                for (var i = 0; i < sd.Length; i++)
                {
                    sum += Convert.ToInt32(sd[i].ToString());
                   
                }

                

                if (firsttime)
                {
                    sum *= k;
                    firsttime = false;
                }

                sd.Clear();
                sd.Append(sum);
            }

            return Convert.ToInt32(sd.ToString());
        }










        public int flippingMatrix2(List<List<int>> matrix)
        {
            var len = matrix.Count;
            var sum = 0;
            for (var row = 0; row < len / 2; row++)
            {
                for (var col = 0; col < len / 2; col++)
                {
                    sum += Math.Max(Math.Max(matrix[row][col], matrix[row][len - 1 - col]), Math.Max(matrix[len - 1 - row][col], matrix[len - 1 - row][len - 1 - col]));
                }
            }
            return sum;
        }



        public int diagonalDifference(List<List<int>> arr)
        {
            var len = arr.Count; //width = length;
                                 //var cols = arr[0].Count;

            //Console.WriteLine(len + " " + cols);


            var ltr = 0;
            var rtl = 0;
            var lindex = 0;
            var rindex = len - 1;
            for (var row = 0; row < arr.Count; row++)
            {
                ltr += arr[row][lindex];
                rtl += arr[row][rindex];
                lindex++;
                rindex--;
            }

            return Math.Abs(ltr - rtl);
        }



        public  List<int> countingSort(List<int> arr)
        {
            var len = arr.Count;
            var freq = new int[100];
            for (var i = 0; i < len; i++)
            {
                freq[arr[i]]++;
            }
            return freq.ToList();
        }


        public class LRUCache
        {
            private int _capacity;
            private int _lru;

            private int count;

            private Queue<Tuple<int, int>> cache;


            //Dictionary<int, int> cache;

            public LRUCache(int capacity)
            {
                _capacity = capacity;


                cache = new Queue<Tuple<int, int>>(capacity);


            }
            public void Put(int key, int value)
            {
                if (cache.Count == _capacity)
                {
                    cache.Dequeue();
                }

                cache.Enqueue(Tuple.Create(key, value));


            }


            public int Get(int key)
            {
                var f = cache.Where(c => c.Item1 == key).FirstOrDefault();
                if (f == null)
                    return -1;
                //var lru = cache.re
                //cache.Enqueue(lru);
                return 0; // lru.Item2;  //value

            }



        }





            public string timeConversion2(string s)
            {

                var sb = new StringBuilder();
                var hour = Convert.ToInt32(s.Substring(0, 2));
                if (s[8] == 'P')
                {

                    if (hour < 12)
                    {
                        hour += 12;
                    }

                }
                else
                {
                    if (hour == 12)
                    {
                        hour = 0;
                    }
                }

                sb.Append(hour.ToString("00"));
                sb.Append(s.Substring(2, 6));
                return sb.ToString();
            }
        







        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var sb1 = new StringBuilder();
            var sb2 = new StringBuilder();
            while (l1 != null)
            {
                sb1.Insert(0, l1.val);

                l1 = l1.next;
            }
            while (l2 != null)
            {
                sb2.Insert(0, l2.val);
                l2 = l2.next;
            }


            BigInteger num1 = BigInteger.Parse(sb1.ToString());
            BigInteger num2 = BigInteger.Parse(sb2.ToString());

            BigInteger sum = num1 + num2;



            var reversed = new string(sum.ToString().Reverse().ToArray());



            var result = new ListNode(reversed[0] - '0');

            var head = result;

            for (var i = 1; i < reversed.Length; i++)
            {

                result.next = new ListNode(reversed[i] - '0');
                result = result.next;

            }


            return head;




        }



        //Hacker  rank easy questions
        //can make this better by assigning dictionary to be identical with counter
        public List<string> AreIsomorphic(string s, List<string> words)
        {
           
            var results = new List<string>();
            var len = s.Length;

            foreach (var w in words) {

                var isiso = true;
                if (w.Length != s.Length)
                {
                    isiso = false;
                    continue;
                }
                var dict = new Dictionary<char, char>();
                var dict2 = new Dictionary<char, char>();
                for (var i = 0; i < len; i++)
                {
                    if (dict.ContainsKey(s[i]))
                    {
                        if (dict[s[i]] != w[i])
                        {
                            isiso = false;
                            break;
                        }
                            
                    }
                    else if (dict2.ContainsKey(w[i]))
                    {
                        if (dict2[w[i]] != s[i])
                        {
                            isiso = false;
                            break;
                        }
                    }
                    else
                        dict[s[i]] = w[i];
                        dict2[w[i]] = s[i];

                }
                if (isiso)
                {
                    results.Add(w);
                }
            }

            return results;
        }



        public int[] FindOrder(int numCourses, int[][] prerequisites)
        {
            var results = new List<int>();
            if (prerequisites.Length == 0)
            {
                for (var i = 0; i < numCourses; i++)
                {
                    results.Add(i);
                }
                return results.ToArray();
            }
            var graph = new List<List<int>>();
            var indegree = new int[numCourses];

            for (var i = 0; i < numCourses; i++)
            {
                graph.Add(new List<int>());
            }

            foreach (var pre in prerequisites)
            {
                graph[pre[1]].Add(pre[0]);
                indegree[pre[0]]++;
            }

          

            var queue = new Queue<int>();
            for (var i = 0; i < indegree.Length; i++)
            {
                if (indegree[i] == 0)
                    queue.Enqueue(i);
            }
            

            

            
            while (queue.Count > 0)
            {
                var node = queue.Dequeue();
                results.Add(node);
                foreach (var child in graph[node])
                {
                    indegree[child]--;
                    if (indegree[child] == 0)
                        queue.Enqueue(child);
                }
            }

            if (!indegree.Any(i => i != 0))
            {
                return new int[0];
            }


            return results.ToArray();
        }



        public int MinSubArrayLen(int target, int[] nums)
        {
         
            var left = 0;
         
            var minlen = Int32.MaxValue;
            var sum = 0;
            for (var right = 0; right < nums.Length; right++)
            {
                sum += nums[right];

                while (sum >= target)
                {
                    minlen = Math.Min(minlen, right - left + 1);
                    sum -= nums[left];
                    left++;
                }

            

            }
            return minlen == Int32.MaxValue ? 0 : minlen;
        }


        public  int palindromeIndex(string s)
        {
            var sb = new StringBuilder(s);
            for (var i = 0; i < s.Length; i++)
            {
                var c = s[i];
                var sub = sb.Remove(i, 1).ToString();
                if (isPalindrome(sub))
                {
                    return i;
                }
                sb.Insert(i, c);
            }
            return -1;
        }

        private  bool isPalindrome(string s)
        {
            var left = 0;
            var right = s.Length - 1;

            while (left < right)
            {
                if (s[left] != s[right])
                    return false;
                left++;
                right--;
            }
            return true;
        }





        public class Trie
        {

            private TrieNode trienode;

            public Trie()
            {
                trienode = new TrieNode();

            }

            public void Insert(string word)
            {
                var node = trienode;
                for (var i = 0; i < word.Length; i++)
                {
                    var c = word[i];
                    var chr = c - 'a';
                    if (node.nodes[chr] == null)
                        node.nodes[chr] = new TrieNode();
                    node = node.nodes[chr];
                    if (i == word.Length - 1)
                    {
                        node.isEnd = true;
                        break;
                    }
                }
            }




            public bool Search(string word)
            {
                var node = trienode;

                if (Contains(word, ref node))
                {
                    return node.isEnd;
                }

                return false;



            }

            public bool StartsWith(string prefix)
            {
                var node = trienode;
                if (Contains(prefix, ref node))
                    return true;
                return false;
            }


            private bool Contains(string prefix, ref TrieNode node)
            {
                for (var i = 0; i < prefix.Length; i++)
                {
                    var c = prefix[i];
                    var chr = c - 'a';
                    if (node.nodes[chr] != null)
                    {
                        node = node.nodes[chr];
                        if (i == prefix.Length - 1)
                        {
                            return true;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                return false;
            }







        }

        public class TrieNode
        {

            public bool isEnd { get; set; }
            public TrieNode[] nodes;

            public TrieNode()
            {
                nodes = new TrieNode[26];
            }

        }






        public static int flippingMatrix(List<List<int>> matrix)
        {

            var end = matrix.Count - 1;
            
            var sum = 0;
            for (var i = 0; i < matrix.Count /2 ; i++)
            {
                for (var j = 0; j < matrix.Count/2; j++)

                {
                    var max = Math.Max(Math.Max(matrix[i][j], matrix[i][end - j]), Math.Max(matrix[end - i][j], matrix[end - i][end - j]));
                    sum += max;
                }
            }
            return sum;

        }


        public static string gridChallenge2(List<string> grid)
        {
            var leni = grid.Count;
            var lenj = grid[0].Length;
            for (var idx = 0; idx < grid.Count; idx++)
            {
                char[] ga = grid[idx].ToCharArray();
                Array.Sort(ga);
                var ns = new string(ga);
                grid[idx] = ns;
            }




            for (var i = 0; i < leni - 1; i++)
            {
                for (var j = 0; j < lenj; j++)
                {


                    var f = grid[i][j] - 'a';
                    var s = grid[i + 1][j] - 'a';

                    if (f > s)
                        return "NO";

                }

            }
            return "YES";
        }

            //hacker rank easy.  clean code well done!!
            SinglyLinkedListNode mergeLists2(SinglyLinkedListNode head1, SinglyLinkedListNode head2)
        {


            var ll = new SinglyLinkedListNode(0);
            var head = ll;

            while (head1 != null || head2 != null)
            {

                var val1 = head1 == null ? 1001 : head1.data;
                var val2 = head2 == null ? 1001 : head2.data;


                if (val1 <= val2)
                {
                    ll.next = new SinglyLinkedListNode(val1);
                    ll = ll.next;
                    head1 = head1.next;

                }
                else
                {
                    ll.next = new SinglyLinkedListNode(val2);
                    ll = ll.next;
                    head2 = head2.next;

                }

            }

            return head.next;


        }




        public  int superDigit(string n, int k)
        {
            
           

            var numstr = n;
            BigInteger sum = 0;
            do
            {
                sum = 0;
                foreach (var c in numstr)
                {
                    sum += (c - '0');
                }
                numstr = sum.ToString();
            }
            while (sum > 9);

            sum *= k;
            numstr = sum.ToString();
            while (sum > 9)
            {
                sum = 0;
                foreach (var c in numstr)
                {
                    sum += (c - '0');
                }
                numstr = sum.ToString();
            }



            return (int)sum;


        }







        public  int truckTour(List<List<int>> petrolpumps)
        {
            var len = petrolpumps.Count;
            var startindex = 0;
            var petrol = 0;
            var i = 0;
            var count = 1;
            while (true)
            {
                petrol += petrolpumps[i][0];
                petrol -= petrolpumps[i][1];
                if (petrol < 0)
                {

                    petrol = 0;
                    i++;
                    if (i == petrolpumps.Count)
                        i = 0;
                    startindex = i;
                    count = 1;
                }
                else if (count == len)
                {
                    break;
                }
                else
                {
                    i++;
                    if (i == petrolpumps.Count)
                        i = 0;
                    count++;
                }
                    
            }
        

        return startindex;

        }



    //Hacker  rank easy questions
    //can make this better by assigning dictionary to be identical with counter
    public bool IsIsomorphic(string s, string t)
        {
            var dict = new Dictionary<char, char>();
            var dict2 = new Dictionary<char, char>();
            var len = s.Length;
            for (var i = 0; i < len; i++)
            {
                if (dict.ContainsKey(s[i]))
                {
                    if (dict[s[i]] != t[i])
                        return false;
                }
                else if (dict2.ContainsKey(t[i]))
                {
                    if (dict2[t[i]] != s[i])
                        return false;
                }

                else
                    dict[s[i]] = t[i];
                dict2[t[i]] = s[i];

            }

            return true;
        }



        public string timeConversion(string s)
        {
            var am = true;
            var sb = new StringBuilder();
            if (s[8] == 'P')
                am = false;
            if (am)
            {
                if (s[1] - '0' == 2)
                {
                    sb.Append("00");
                }
                else
                {
                    sb.Append(s[0]);
                    sb.Append(s[1]);

                }


            }
            else
            {
                var hour = Convert.ToInt32(s.Substring(0, 2));
                if (hour < 12)
                {

                    hour += 12;
                }

                sb.Append(hour);


            }



            sb.Append(s.Substring(2, 6));

            return sb.ToString();
        }


        public void plusMinus(List<int> arr)
        {

            var zero = 0;
            double neg = 0;
            float pos = 0;
            double len = arr.Count;

            for (var i = 0; i < len; i++)
            {
                if (arr[i] < 0)
                    neg++;
                else if (arr[i] == 0)
                    zero++;
                else
                    pos++;

            }

         

            Console.WriteLine((pos / len).ToString("0.000000"));
            Console.WriteLine((neg / len).ToString("F6"));
            Console.WriteLine((zero / len).ToString("F6"));


        }


        public int SuitableLocations(List<int> centers, long d)
        {
            if (centers == null || centers.Count == 0) return 0;

            // Sort the centers to apply a more efficient algorithm
            centers.Sort();

            int suitableLocations = 0;
            long currentSum = 0;
            int left = 0; // Start of the window

            // Initialize currentSum with the distance from the first center to all others
            for (int i = 0; i < centers.Count; i++)
            {
                currentSum += Math.Abs(centers[i] - centers[0]);
            }

            for (int right = 0; right < centers.Count; right++)
            {
                // Adjust the window to maintain the sum of distances <= d
                while (currentSum > d && left < right)
                {
                    currentSum -= Math.Abs(centers[right] - centers[left]);
                    left++;
                }

                // If currentSum is within the limit, update suitableLocations
                if (currentSum <= d)
                {
                    int currentSuitable = right - left + 1;
                    suitableLocations = Math.Max(suitableLocations, currentSuitable);
                }

                // Prepare currentSum for the next iteration (next right)
                if (right < centers.Count - 1)
                {
                    currentSum += (centers[right + 1] - centers[right]) * (right - left + 1);
                }
            }

            return suitableLocations;
        }




        //Amazon suitable delivery locations.  - AOE - 27Feb2024
        //Find all the locations  that you can deliver to and from all indexes in center that are <= d.
        //This passes 7/15 test case.  good brute force start.
        //you forgot the case where the maxsum or minsum can only be <= and not ==, so you may need a flag
        //to determine if both directions (eg + and -), then if so, and it's <= then break out of loop. 
        //otherwise it's an infinite loop.


        public int SuitableLocations1(List<int> center, long d)
        {

            var min = center.Min();
            var max = center.Max();

            while (true)
            {
                long minsum = 0;
                long maxsum = 0;

                for (var i = 0; i < center.Count; i++) {

                    minsum += Math.Abs(center[i] - min);
                    maxsum += Math.Abs(center[i] - max);

                }

                minsum *= 2; maxsum *= 2;

                if (minsum > d)
                {
                    min++;


                }
                else if (minsum < d)
                {
                    min--;


                }
                
                if (maxsum > d)
                {
                    max--;


                }
                else if (maxsum < d)
                {
                    max++;


                }

                if (maxsum == d && minsum == d)
                    break;



            }


            return Math.Abs(min - max) + 1;

        }




        //Amazon Locate Longest non-increasing linked list segment  - AOE - 27Feb2024
        //Find the longest NON-Increasing (eg.  5 4 4 3) in a linked list, and return the start to only that segment.
        //This passes 15/15 test case.  perfect score!!!

        public SinglyLinkedListNode locateLongestList(SinglyLinkedListNode head)
        {
            
            var start = head;
            int curr_len = 1, max_len = 1;
            int total_count = 1, res_index = 0;
            for (SinglyLinkedListNode curr = head; curr.next != null;
                                   curr = curr.next)
            {
            
                if (curr.data >= curr.next.data)
                    curr_len++;
                else
                {
            
                    if (max_len < curr_len)
                    {
                        max_len = curr_len;
                        res_index = total_count - curr_len;
                    }

                    curr_len = 1;
                }
                total_count++;
            }

            if (max_len < curr_len)
            {
                max_len = curr_len;
                res_index = total_count - max_len;
            }
         
            var i = 0;
            for (SinglyLinkedListNode curr = head; curr != null;
                                   curr = curr.next)
            {
                if (i == res_index)
                {
                    start = curr;
         
                    while (max_len > 0)
                    {
                        if (max_len == 1)
                            curr.next = null;
                        else
                            curr = curr.next;
                        max_len--;
                    }
                    break;
                }
                i++;
            }
            return start;
        }










        //LC 2781 - length of the longest valid substring
        // my real attempt from scratch!  (763 / 763 testcases passed!!)

        public int LongestValidSubstring(string word, IList<string> forbidden)
        {
            var max = 0;
            var left = 0;
            var len = word.Length;
            var fhs = new HashSet<string>(forbidden);

            for (var i = 0; i < len; i++)
            {
                for (var j = Math.Max(left, i - 9); j <= i; j++)
                {
                    var substr = word.Substring(j, i - j + 1);
                    if (fhs.Contains(substr))
                    {
                        left = j + 1;

                    }

                }
                max = Math.Max(max, i - left + 1);
            }
            return max;


        }



        //LC 2781 - length of the longest valid substring
        // my real attempt from scratch!  (613 / 763 testcases passed)
        public int LongestValidSubstringOK(string word, IList<string> forbidden)
        {
            var hash = new HashSet<string>(forbidden);
            var maxlength = 0;
            var len = word.Length;
            var found = false;

            for (var r = 0; r < len; r++)
            {
                var leftmin = r;
                for (var l = r; l >= 0 && l > r - 10; l--)
                {
                    var w = word.Substring(l, r - l + 1);
                    if (!hash.Any(h => w.Contains(h)))
                    {
                        leftmin = Math.Min(leftmin, l);
                        found = true;
                    }
                    else
                        break;
                }
                maxlength = Math.Max(maxlength, r - leftmin + 1);
            }
            return found ? maxlength : 0;
        }




        //amazon  question 2 - passed all test cases

        public int findReviewScore(string review, List<string> prohibitedWords)
        {

            //   public int LongestValidSubstring(string word, IList<string> forbidden)

            int maxLength = 0;


            int maxRight = review.Length - 1;

            var forbiddenSet = new HashSet<string>(prohibitedWords);


            for (int left = review.Length - 1; left >= 0; left--)
            {
                for (int right = left; right <= Math.Min(left + 10, maxRight); right++)
                {
                    if (forbiddenSet.Contains(review.Substring(left, right - left + 1).ToLower()))
                    {

                        maxRight = right - 1;
                        break;
                    }
                }
                maxLength = Math.Max(maxLength, maxRight - left + 1);
            }
            return maxLength;

        }


        //Amazon question 1 - passed all test cases - used DP
        //need to understand

        public int maxSetSize(List<int> riceBags)
        {

            riceBags.Sort();
            var dp = new Dictionary<int, int>();
            int maxSetSize = 1;

            foreach (int grains in riceBags)
            {
                int root = (int)Math.Sqrt(grains);
                if (root * root == grains && dp.ContainsKey(root))
                {
                    dp[grains] = dp[root] + 1;
                }
                else
                {
                    dp[grains] = 1;
                }
                maxSetSize = Math.Max(maxSetSize, dp[grains]);
            }

            return maxSetSize > 1 ? maxSetSize : -1;

        }



        public SinglyLinkedListNode mergeLists(SinglyLinkedListNode head1, SinglyLinkedListNode head2)
        {

            var pointer = new SinglyLinkedListNode(-1);
            var head = new SinglyLinkedListNode(-1);
         

            while (head1 != null || head2 != null)
            {
                var val1 = head1 == null ? 0 : head1.data;
                var val2 = head2 == null ? 0 : head2.data;
                if (val1 < val2  || val2 == 0)
                {
                    if (pointer.data == -1)
                    {
                        pointer = head1;
                        head = pointer;
                    }
                        
                    else
                    {
                        pointer.next = head1;
                        pointer = pointer.next;
                    }

                    head1 = head1.next;



                }
                else
                {
                    if (pointer.data == -1)
                    { 
                        pointer = head2;
                        head = pointer;
                    }
                    else
                    {
                        pointer.next = head2;
                        pointer = pointer.next;
                    }

                    head2 = head2.next;
                }


            }

            return head;
        }









        //hackerrank
        public void miniMaxSum(List<int> arr)
        {
            arr.Sort();
            var len = arr.Count;
            BigInteger sum = 0;
            for (var i = 0; i < len; i++)
            {
                sum = BigInteger.Add(sum, arr[i]);
            }
            BigInteger min = sum - arr[len - 1];
            BigInteger max = sum - arr[0];

            Console.WriteLine(min + " " + max);

        }


        //Passes 12/36
        public int[] PlatesBetweenCandles(string s, int[][] queries)
        { 
            List<int> candles = new List<int>(s.Length);
            for (int i = 0; i<s.Length; ++i)
            if (s[i] == '|') 
                candles.Add(i);

            int[] result = new int[queries.Length];

            for (int i = 0; i<queries.Length; ++i) {
            int left = candles.BinarySearch(queries[i][0]);

            if (left< 0)
                left = ~left;

            int right = candles.BinarySearch(queries[i][1]);

            if (right< 0)
                right = ~right - 1;

            if (left<right)
                result[i] = candles[right] - candles[left] - (right - left);
            }
            return result;
        }


        //Passes 12/36
        public int[] PlatesBetweenCandlesslow(string s, int[][] queries)
        {
            //approach is 2 pointer.
            // 
            var results = new List<int>();
            for (var i = 0; i < queries.Length; i++)
            {
                var plates = 0;
                var left = queries[i][0];
                var right = queries[i][1];
                while (left < right && s[left] != '|')
                    left++;
                while (left < right && s[right] != '|')
                    right--;

                if (s[left] == '|' && s[right] == '|')
                {
                    while (left <= right)
                    {


                        if (s[left] == '*')
                            plates++;

                        if (left != right && s[right] == '*')
                            plates++;

                        left++;
                        right--;

                    }
                }
                results.Add(plates);
            }

            return results.ToArray();
        }





        public int LongestValidSubstringcrap(string word, IList<string> strs)
        {
            HashSet<string> setF = new HashSet<string>(strs);
            int res = 0;
            int left = 0;

            for (int i = 0; i < word.Length; i++)
            {
                for (int j = Math.Max(left, i - 9); j <= i; j++)
                {
                    var span2 = word.AsSpan(1, 2);
                    var subSpan = word.AsSpan(j, i - j + 1);
                    var sss = subSpan.ToString();
                    if (setF.Contains(sss))
                    {  // Convert span to string for hashset lookup
                        left = j + 1;
                    }
                }
                res = Math.Max(res, i - left + 1);
            }

            return res;
        }

    }



    //Leetcode hard for doubly linked list, 432. All O`one Data Structure


    public class AllOne
    {

        public class Node
        {

            public int frequency;
            public HashSet<string> keys;
            public Node prev;
            public Node next;


            public Node(int val)
            {
                frequency = val;
                keys = new HashSet<string>();
            }
        }


        private Node head;
        private Node tail;
        private Dictionary<string, Node> dict;

        public AllOne()
        {
            head = new Node(0);
            tail = new Node(0);
            head.next = tail;
            tail.prev = head;

            dict = new Dictionary<string, Node>();
        }

        public void Inc(string key)
        {

            if (dict.ContainsKey(key))
            {

                var node = dict[key];
                node.keys.Remove(key);

                var frequency = node.frequency;
                var nextnode = node.next;

                if (node.keys.Count == 0)
                {
                    node = node.prev;
                    dict.Remove(key);
                }


                if (nextnode == tail || nextnode.frequency != frequency + 1)
                {
                    //create new node, etc.
                    var newnode = new Node(frequency + 1);
                    newnode.keys.Add(key);
                    newnode.prev = node;
                    newnode.next = nextnode;
                    node.next = newnode;
                    nextnode.prev = newnode;
                    dict[key] = newnode;
                    Console.WriteLine("dict has key of " + key + " AND next=tail or not equal freq+1");
                    debug();

                }
                else
                {
                    nextnode.keys.Add(key);
                    dict[key] = nextnode;

                    if (node.next.keys.Count == 0)
                    {
                        node.next = nextnode;
                        nextnode.prev = node;
                    }


                    Console.WriteLine("dict has key of " + key + " AND next NOT equals tail etd");
                    debug();
                }


            }
            else
            {

                var nextnode = head.next;
                if (nextnode == tail || nextnode.frequency != 1)
                {
                    //create new node, etc.
                    var newnode = new Node(1);
                    newnode.keys.Add(key);
                    newnode.prev = head;
                    newnode.next = nextnode;
                    head.next = newnode;
                    nextnode.prev = newnode;
                    dict[key] = newnode;

                    Console.WriteLine("dict NOT have key and frequency != or tail");
                    debug();

                }
                else
                {
                    nextnode.keys.Add(key);
                    dict[key] = nextnode;
                    Console.WriteLine("dict NOT have key of " + key);
                    debug();

                }

            }


        }

        public void Dec(string key)
        {


            if (dict.ContainsKey(key))
            {

                var node = dict[key];
                node.keys.Remove(key);

                var frequency = node.frequency;
                var prevnode = node.prev;

                if (node.keys.Count == 0)
                {
                    node = node.next;
                    dict.Remove(key);
                }

                var newfrequency = frequency - 1;
                if (newfrequency == 0)
                {
                    dict.Remove(key);
                }
                else
                if (prevnode == head || prevnode.frequency != frequency - 1)
                {
                    //create new node, etc.
                    var newnode = new Node(newfrequency);
                    newnode.keys.Add(key);
                    newnode.prev = prevnode;
                    newnode.next = node;
                    prevnode.next = newnode;
                    node.prev = newnode;
                    dict[key] = newnode;
                    Console.WriteLine("DEC: dict has key of " + key + " AND next=tail or not equal freq+1");
                    debug();

                }
                else
                {
                    prevnode.keys.Add(key);
                    dict[key] = prevnode;

                    if (node.prev.keys.Count == 0)
                    {
                        prevnode.next = node;
                        node.prev = prevnode;
                    }

                    Console.WriteLine("DEC: dict has key of " + key + " AND next NOT equals tail etd");
                    debug();
                }

            }
            else
            {

                Console.WriteLine("DEC: dict NOT have key and frequency != or tail");
                debug();

            }

        }








        private void AddNode(Node node, string key, Node nextnode, int newfrequency, Node headortail)
        {
            if (headortail == tail || headortail.frequency != newfrequency)
            {
                //create new node, etc.
                var newnode = new Node(newfrequency);
                newnode.keys.Add(key);
                newnode.prev = node;
                newnode.next = nextnode;
                node.next = newnode;
                nextnode.prev = newnode;
                dict[key] = newnode;
                //Console.WriteLine("dict has key of " + key + " AND next=tail or not equal freq+1");
                //debug();

            }
            else
            {
                nextnode.keys.Add(key);
                dict[key] = nextnode;
                //Console.WriteLine("dict has key of " + key + " AND next NOT equals tail etd");
                //debug();
            }


        }



        public string GetMaxKey()
        {
            Console.WriteLine("B4 get max");
            var max = tail.prev.keys.FirstOrDefault();
            return max ?? "";
        }

        public string GetMinKey()
        {
            Console.WriteLine("B4 get MIN");
            var min = head.next.keys.FirstOrDefault();
            return min ?? "";
        }

        private void debug()
        {
            var testnode = head.next;
            while (testnode != tail)
            {
                Console.WriteLine("frequency: " + testnode.frequency);
                foreach (var k in testnode.keys)
                    Console.WriteLine("key: " + k);
                testnode = testnode.next;
            }
            Console.WriteLine("_____________");
        }

    }

    /**
     * Your AllOne object will be instantiated and called as such:
     * AllOne obj = new AllOne();
     * obj.Inc(key);
     * obj.Dec(key);
     * string param_3 = obj.GetMaxKey();
     * string param_4 = obj.GetMinKey();
     */


    //Wrong answer.  Scrap it or rework.

    public class StockPrice1
    {

        private PriorityQueue<int, int> minprice;
        private PriorityQueue<int, int> maxprice;
        int latestprice = -1;
        int latesttime = -1;

        public StockPrice1()
        {
            minprice = new PriorityQueue<int, int>();
            maxprice = new PriorityQueue<int, int>(Comparer<int>.Create((x, y) => y.CompareTo(x)));
        }

        public void Update(int timestamp, int price)
        {


            minprice.Enqueue(timestamp, price);
            maxprice.Enqueue(timestamp, price);
            extensions.TryUpdatePriority(minprice, timestamp, price, out _);
            extensions.TryUpdatePriority(maxprice, timestamp, price, out _);


            //Console.WriteLine(minprice.Peek());
            //Console.WriteLine(maxprice.Peek());
            if (timestamp >= latesttime)
            {
                latestprice = price;
                latesttime = timestamp;
            }

        }

        public int Current()
        {

            return latestprice;
        }

        public int Maximum()
        {
            int timestamp, price = 0;
            var success = maxprice.TryPeek(out timestamp, out price);
            return price;
        }

        public int Minimum()
        {
            int timestamp, price = 0;
            var success = minprice.TryPeek(out timestamp, out price);
            return price;
        }


    }

    public static class extensions
    {


        public static bool TryUpdatePriority<TElement, TPriority>(
        this PriorityQueue<TElement, TPriority> source,
        TElement element, TPriority newPriority, out TPriority oldPriority)
        {
            ArgumentNullException.ThrowIfNull(source);
            if (source.Remove(element, out TElement removedElement, out oldPriority))
            {
                source.Enqueue(removedElement, newPriority);
                return true;
            }
            return false;
        }


    }






    public class StockPrice2
    {
        private Dictionary<int, int> timestampPriceMap;
        private SortedDictionary<int, int> priceFrequencyMap;
        private int latestTimestamp;

        public StockPrice2()
        {
            timestampPriceMap = new Dictionary<int, int>();
            priceFrequencyMap = new SortedDictionary<int, int>();
            latestTimestamp = 0;
        }

        public void Update(int timestamp, int price)
        {
            // If the timestamp already exists, update the price frequency map
            if (timestampPriceMap.ContainsKey(timestamp))
            {
                int oldPrice = timestampPriceMap[timestamp];
                priceFrequencyMap[oldPrice]--;
                if (priceFrequencyMap[oldPrice] == 0)
                {
                    priceFrequencyMap.Remove(oldPrice);
                }
            }

            // Update the timestamp to price mapping
            timestampPriceMap[timestamp] = price;

            // Update the price frequency map
            if (!priceFrequencyMap.ContainsKey(price))
            {
                priceFrequencyMap[price] = 0;
            }
            priceFrequencyMap[price]++;

            // Update the latest timestamp
            if (timestamp > latestTimestamp)
            {
                latestTimestamp = timestamp;
            }
        }

        public int Current()
        {
            return timestampPriceMap[latestTimestamp];
        }

        public int Maximum()
        {
            return priceFrequencyMap.Keys.Max();
        }

        public int Minimum()
        {
            return priceFrequencyMap.Keys.Min();
        }
    }



    //Works.  Beats 96%
    public class StockPrice
    {


        int latest;
        Dictionary<int, int> timeStampPrices;
        PriorityQueue<int, int> minPrice;
        PriorityQueue<int, int> maxPrice;


        public StockPrice()
        {

            timeStampPrices = new Dictionary<int, int>();
            minPrice = new PriorityQueue<int, int>();
            maxPrice = new PriorityQueue<int, int>(Comparer<int>.Create((a, b) => b.CompareTo(a)));


        }

        public void Update(int timestamp, int price)
        {
            latest = Math.Max(latest, timestamp);
            timeStampPrices[timestamp] = price;

            minPrice.Enqueue(timestamp, price);
            maxPrice.Enqueue(timestamp, price);
        }

        public int Current()
        {
            return timeStampPrices[latest];
        }

        public int Maximum()
        {
            if (maxPrice.TryPeek(out int time, out int max))
            {
                while (max != timeStampPrices[time])
                {
                    maxPrice.Dequeue();
                    var success = maxPrice.TryPeek(out time, out max);
                    if (!success)
                        break;
                }

                return max;
            }
            else
                return 0;

        }

        public int Minimum()
        {
            if (minPrice.TryPeek(out int time, out int min))
            {
                while (min != timeStampPrices[time])
                {
                    minPrice.Dequeue();
                    var success = minPrice.TryPeek(out time, out min);
                    if (!success)
                        break;
                }

                return min;
            }
            else
                return 0;
        }
    }

    /**
     * Your StockPrice object will be instantiated and called as such:
     * StockPrice obj = new StockPrice();
     * obj.Update(timestamp,price);
     * int param_2 = obj.Current();
     * int param_3 = obj.Maximum();
     * int param_4 = obj.Minimum();
     */



    public class Carpooling
    {
        public class Road
        {
            public string Start { get; set; }
            public string End { get; set; }
            public int Duration { get; set; }
        }

        public List<string> DeterminePickupOrder(List<Road> roads, string car1Start, string car2Start, List<string> peopleLocations)
        {
            // Create a graph from the roads
            var graph = new Dictionary<string, List<(string, int)>>();
            foreach (var road in roads)
            {
                if (!graph.ContainsKey(road.Start))
                {
                    graph[road.Start] = new List<(string, int)>();
                }
                graph[road.Start].Add((road.End, road.Duration));
            }

            // Priority queue to simulate the movement of cars
            var pq = new SortedSet<(int, string, int)>(); // (time, location, carId)
            pq.Add((0, car1Start, 1));
            pq.Add((0, car2Start, 2));

            // Dictionary to track the earliest time a car can reach a location
            var earliestArrival = new Dictionary<string, (int, int)>(); // location -> (time, carId)

            // Result list to store the pickup order
            var pickupOrder = new List<string>();

            while (pq.Count > 0)
            {
                var current = pq.Min;
                pq.Remove(current);

                int currentTime = current.Item1;
                string currentLocation = current.Item2;
                int currentCarId = current.Item3;

                // If this location is a person's location, pick them up
                if (peopleLocations.Contains(currentLocation))
                {
                    pickupOrder.Add(currentLocation);
                    peopleLocations.Remove(currentLocation);
                }

                // Explore neighbors
                if (graph.ContainsKey(currentLocation))
                {
                    foreach (var neighbor in graph[currentLocation])
                    {
                        int newTime = currentTime + neighbor.Item2;
                        string neighborLocation = neighbor.Item1;

                        if (!earliestArrival.ContainsKey(neighborLocation) || newTime < earliestArrival[neighborLocation].Item1)
                        {
                            earliestArrival[neighborLocation] = (newTime, currentCarId);
                            pq.Add((newTime, neighborLocation, currentCarId));
                        }
                    }
                }
            }

            return pickupOrder;
        }


    }







}
