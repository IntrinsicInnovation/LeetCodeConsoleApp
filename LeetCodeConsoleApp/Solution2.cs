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
