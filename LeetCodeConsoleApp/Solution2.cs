using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeConsoleApp
{
    internal class Solution2
    {


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
}
