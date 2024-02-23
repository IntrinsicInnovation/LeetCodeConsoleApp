using LeetCodeConsoleApp;
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography;
using System.Text;


namespace LeetCodeConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            var sol = new Solution();

            //  var l = new ListNode(5); 
            // l.next = new ListNode(4);
            //l.next.next = new ListNode(3);


            //  var l2 = new ListNode(5);
            // l2.next = new ListNode(6);
            // l2.next.next = new ListNode(4);
            //   var a = sol.AddTwoNumbers5(l, l2);




            //sol.SortedSquares(new int[] {-4, -1, 0, 3, 10});
            //var sorted = sol.CustomSortString("cba", "abccd");
            //var a = sol.LongestPalindrome("babad");
            //var b = sol.WordPattern("abba", "dog dog dog dog");



            //var d = sol.MaxDistToClosest(new int[] { 0, 1, 0, 1, 0 }); //, 1, 0, 1 });
            //var root = new TreeNode(1);
            //root.left = new TreeNode(3);
            //root.right = new TreeNode(2);
            //root.left.left = new TreeNode(5);
            //root.left.right = new TreeNode(3);
            //root.right.right = new TreeNode(9);
            //1,3,2,5,3,null,9]

            //   5
            //  / \
            //  3   6
            // / \   \
            //2   4   7

            //  var l = sol.LargestValues(root);



            //var root = new TreeNode(3);
            //root.left = new TreeNode(9);
            //root.right = new TreeNode(20);

            //root.right.left = new TreeNode(15);
            //root.right.right = new TreeNode(7);
            //var f = sol.SumOfLeftLeaves(root);



            // var r = sol.RelativeSortArray2( new int[] { 2, 3, 1, 3, 2, 4, 6, 7, 9, 2, 19 }, new int[] { 2, 1, 4, 3, 9, 6 });

            //   var c = sol.CommonChars(new string [] { "bella", "label", "roller" });


            //var s = sol.TwoSum(new int[] { 3, 2, 4 }, 6);


            //  var s = sol.ProductExceptSelf(new int[] { 1, 2, 3, 4 });
            //var s = sol.ProductExceptSelf(new int[] { 0,0});

            //var s = sol.MaxSubArray(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 });

            // var p = sol.MaxProduct(new int[] { -2, 3, -4 });
            // var m = sol.FindMin(new int[] { 3, 4, 5, 1, 2 });
            //var m = sol.Search(new int[] { 4, 5, 6, 7, 0, 1, 2 }, 8);
            //var s = sol.ThreeSum(new int[] {-1, 0, 1, 2, -1, -4});
            //var m = sol.MaxArea(new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7});
            //var s = sol.GetSum(2, 6);
            //var h = sol.HammingWeight(11);
            //var r = sol.reverseBits(0b_00000010100101000001111010011100); // (43261596);

            // var p = sol.IsPalindrome("0P"); // ( " A man, a plan, a canal: Panama");

            //var arraytosort = new int[] { 0, 1, 2, 0, 1, 2 };
            //sol.MSInterviewsort012(arraytosort);

            //var l = new ListNode(1); // ListNode(7);
            //l.next = new ListNode(8);
            // l.next.next = new ListNode(3);
            //l.next.next.next = new ListNode(7);

            //var rll = sol.ReverseList(l);

            //  var c = sol.ClimbStairs(5);





            //var lis = sol.LengthOfLIS(new int[] { 10, 9, 2, 5, 3, 7, 101, 18 });

            //var l = new ListNode(3); 
            //l.next = new ListNode(2);
            // l.next.next = new ListNode(0);
            //l.next.next.next = new ListNode(-4);
            //l.next.next.next.next = l.next;

            //var hc = sol.HasCycle(null);

            //var l = new ListNode(1);
            //l.next = new ListNode(2);
            //l.next.next = new ListNode(4);

            //var l2 = new ListNode(1);
            //l2.next = new ListNode(3);
            //l2.next.next = new ListNode(4);

            //var l3 = new ListNode(2);
            //l3.next = new ListNode(6);



            //var l4 = new ListNode(-1);
            //var l5 = new ListNode(2);



            //var m2l = sol.MergeTwoLists2(l, l2);


            // var m2l = sol.MergeKLists(new ListNode[]{l5,null,l4});

            //var l = new ListNode(7);
            //l.next = new ListNode(2);
            //l.next.next = new ListNode(4);
            //l.next.next.next = new ListNode(3);

            //var l2 = new ListNode(5);
            //l2.next = new ListNode(6);
            //l2.next.next = new ListNode(4);

            ////var r = sol.RemoveNthFromEnd(l, 2);
            //sol.ReorderList(l);

            //var l = sol.LengthOfLongestSubstring("pwwkew");

            // sol.TestIcomparable();
            //var l = new ListNode(9);
            //l.next = new ListNode(1);
            //l.next.next = new ListNode(6);

            //var l2 = new ListNode(0);


            //var a = sol.AddTwoNumbers(l, l2);


            // var r = sol.RestoreString("codeleet", new int[]{ 4, 5, 6, 7, 0, 2, 1, 3});

            //var m = sol.MinTimeToVisitAllPoints(new int[][] { new int[] { 1, 1 }, new int[] { 3, 4 }, new int[] { -1, 0 } });


            //  var sol2 = new Solution2();

            //          var r = sol2.Read(new char[] { 'a','b','c','d','e' }, 4);


            //  var p = sol.MaxProfit(new int[] { 1, 4, 2 }); // 7, 1, 5, 6, 4 });




            //            var ms = sol.MaxSubArrayLen(new int[] { 1, -1, 5, -2, 3 }, 3);
            //  var ms = sol.MaxSubArrayLen2(new int[] { -2, -1, 2, 1 },  1);


            // var ai = sol.ArraysIntersection(new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 5, 7, 9 }, new int[] { 1, 3, 4, 5, 8 });


            // var ng = sol.NextGreaterElement(new int[] { 4, 1, 2 }, new int[] { 1, 3, 4, 2 });



            //var sp = sol.SimplifyPath("/home//foo//foo2/../");

            //var sp = sol.SimplifyPath("/a/./b/../../c/");

            //  var sp = sol.SimplifyPath("/a/../../b/../c//.//");

            //  var lm = sol.LeftMostColumnWithOne(new int[][] { new int[] { 0,0,0,0 } 
            //  , new int[] { 0,0,0,0 }});

            //  var rv = sol.ReverseVowels("leetcode");


            //  var s = sol.GetSum2(0b1110, 0b0011);


            // var ndt = sol.NetworkDelayTime(new int[][] { new int[] { 2, 1, 1 }, new int[] { 2, 3, 1 }, new int[] { 3, 4, 1 } }, 4, 2);

            //var m = sol.MissingElement(new int[] { 4, 7, 9, 10 }, 1);

            //var ri = sol.RomanToInt("DCXXI");

            // var r = sol.RemoveOuterParentheses("(()())(())(()(()))");


            // var cb = sol.CountBits2(5);


            //  var rb = sol.reverseBits2(0b_00000010100101000001111010011100);
            //   var rb = sol.reverseBits(0b_1101);


            //var n = new Node(1);
            //n.random = null;
            //n.next = new Node(2);
            //n.next.random = n;
            //n.next.next = new Node(3);

            //var c = sol.CopyRandomList(n);


            //var l = new ListNode(1);
            //l.next = new ListNode(2);
            //l.next.next = new ListNode(3);
            //l.next.next.next = new ListNode(4);
            //l.next.next.next.next = new ListNode(5);
            // sol.ReorderList2(l);


            // var c = sol.MyAtoi2("2147483646");



            //  var dupes = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            //  var u = sol.RemoveDuplicates(dupes); 


            //  var a = sol.FindAnagrams2("cbaebabacd", "abc");

            // var a = sol.AddStrings("1", "9"); // "6913259244", "71103343");

            //var ip = sol.IsPalindrome2("A man, a plan, a canal: Panama");

            //  var ab = sol.AddBinary("1010", "1011");




            //facebook interview 
            //var grid = new char[][] { new char[] { '-', '-', '-', '-' }, new char[] { '-', '-', '-', '-' }, new char[] { '-', '-', '-', '-' } };
            //sol.generateKMines(grid,3);
            //for (int i = 0; i < grid.Length; i++)
            //{
            //    for (int j = 0; j < grid[0].Length; j++)
            //    {
            //        Console.Write(grid[i][j] + " ");
            //        //System.out.print(grid[i][j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //var root = new TreeNode(10);
            //root.left = new TreeNode(5);
            //root.right = new TreeNode(15);
            //root.left.left = new TreeNode(3);
            //root.left.right = new TreeNode(7);
            //root.right.right = new TreeNode(18);

            ////  var rs = sol.RangeSumBST(root, 7,15);
            //var ks = sol.KthSmallest(root, 1);
            // var ias = sol.IsAlienSorted(new string[] { "world", "word", "row" }, "worldabcefghijkmnpqstuvxyz");

            // var ias = sol.IsAlienSorted(new string[] { "kuvp", "q" }, "ngxlkthsjuoqcpavbfdermiywz");


            //var ias = sol.IsAlienSorted(new string[] { "apple", "app" },  "abcdefghijklmnopqrstuvwxyz");



            //var ao = sol.AlienOrder(new string []{ "wrt", "wrf", "er", "ett", "rftt" });

            //  var mr = sol.MinRemoveToMakeValid("lee(t(c)o)de)");

            // var po = sol.PlusOne(new int[] { 4, 3, 2, 1 });

            //  var d = sol.deserialize("1 2 3 null null 4 5");


            //var root = new TreeNode(1);
            //root.left = new TreeNode(2);
            //root.right = new TreeNode(3);
            //root.left.right = new TreeNode(5);
            //var btp = sol.BinaryTreePaths(root);


            //var iv = sol.IsValid("([)]");

            //var l = new ListNode(1);
            //l.next = new ListNode(1);
            //l.next.next = new ListNode(1);
            ////l.next.next.next = new ListNode(3);
            ////l.next.next.next.next = new ListNode(3);

            //var dd = sol.DeleteDuplicates(l);

            //  var ci = sol.CheckInclusion("hello", "ooolleoooleh");


            //var wb = sol.WordBreak2("leetcode", new string[] { "leet", "code" });
            //var wb = sol.WordBreak2("aaaaaaa", new string[] { "aaaa", "aaa" });

            // var wb = sol.WordBreak2("applepenapple", new string[] {"apple", "pen"});


            // var io = sol.IsOneBitCharacter(new int[] { 0, 1, 0 });

            // var lt = sol.LargestTimeFromDigits(new int[] { 5, 5, 5, 5 });


            //var q = new MyQueue();
            //q.Push(1);
            //q.Push(2);
            //var p = q.Peek();
            //var pop = q.Pop();
            //var e = q.Empty();


            //var s = new MyStack();
            //s.Push(1);
            //s.Push(2);
            //var p = s.Peek();
            //var pop = s.Pop();
            //s.Push(3);
            //var pop2 = s.Pop();
            //s.Push(4);


            //var root = new TreeNode(3);
            //root.left = new TreeNode(5);
            //root.right = new TreeNode(1);
            //root.left.left = new TreeNode(6);
            //root.left.right = new TreeNode(2);
            //root.right.left = new TreeNode(9);
            //root.right.right = new TreeNode(8);
            //root.left.right.left = new TreeNode(7);
            //root.left.right.right = new TreeNode(4);

            //var root2 = new TreeNode(3);
            //root2.left = new TreeNode(5);
            //root2.right = new TreeNode(1);
            //root2.left.left = new TreeNode(6);
            //root2.left.right = new TreeNode(7);
            //root2.right.left = new TreeNode(4);
            //root2.right.right = new TreeNode(2);
            //root2.right.right.left = new TreeNode(9);
            //root2.right.right.right = new TreeNode(8);

            //var s = sol.LeafSimilar(root, root2);

            //var hw = sol.HammingWeight2(0b_00000000000000000000000000001011);

            //sol.SortColors(new int[] { 2, 0, 1 }); // 2, 1, 1, 0});


            //var root = new TreeNode(5);
            //root.left = new TreeNode(3);
            //root.right = new TreeNode(6);

            //root.left.left = new TreeNode(2);
            //root.left.right = new TreeNode(4);
            //root.left.left.left = new TreeNode(1);



            //var root = new TreeNode(2);
            ////root.left = new TreeNode(3);
            //root.right = new TreeNode(3);


            //var p = new TreeNode(2);
            //var ios = sol.InorderSuccessor2(root, p);




            //var r = sol.RepeatedSubstringPattern("aba"); // ababaab");





            //var l = new ListNode(7);
            //l.next = new ListNode(2);
            //l.next.next = new ListNode(4);
            //l.next.next.next = new ListNode(3);

            //var l2 = new ListNode(5);
            //l2.next = new ListNode(6);
            //l2.next.next = new ListNode(4);

            //var a = sol.AddTwoNumbers6(l, l2);




            // var me = sol.MajorityElement(new int[] { 3, 2, 3 });

            //  var nct = sol.NextClosestTime("23:59");
            //var ue = sol.NumUniqueEmails(new string[] { "test.email+alex@leetcode.com", "test.e.mail+bob.cathy@leetcode.com", "testemail+david@lee.tcode.com" });


            //  var tf = sol.TotalFruit(new int[] { 1, 2, 3, 2, 2 });
            // var ntp = sol.NumTilePossibilities("AAB");

            // var n = sol.NumWaterBottles(15, 8);

            // var m = sol.MinSteps("bab", "aba");

            //var l = sol.LengthLongestPath("dir\n\tsubdir1\n\t\tfile1.ext\n\t\tsubsubdir1\n\tsubdir2\n\t\tsubsubdir2\n\t\t\tfile2.ext");

            // var l = new ListNode(5); 
            // l.next = new ListNode(4);
            // l.next.next = new ListNode(3);


            // sol.ReverseList(l);

            // var d = sol.MaxDistToClosest(new int[] {1, 1, 0, 0, 0, 1, 1, 0, 0, 1, 0});
            //var l = sol.LargestTimeFromDigits3(new int[] {1, 2, 4, 3});

            // sol.NumArray(new int[] { 1, 2, 3, 4 });
            //var e = sol.MajorityElement2(new int[] { 3,2,3});



            //var root1 = new TreeNode(1);
            //var root2 = new TreeNode(2);

            //var ls = sol.LeafSimilar2(root1, root2);



            // var r = sol.RemoveKdigits("10200", 1);




            //var l = new ListNode(7);
            //l.next = new ListNode(2);
            //l.next.next = new ListNode(4);
            //l.next.next.next = new ListNode(3);

            //var l2 = new ListNode(5);
            //l2.next = new ListNode(6);
            //l2.next.next = new ListNode(4);

            //var a = sol.AddTwoNumbers7(l, l2);

            //  var c = sol.CompareVersion("7.5.2.4", "7.5.3");



            // var root1 = new TreeNode(1);
            // var root2 = new TreeNode(2);

            //  var ls = sol.LeafSimilar3(root1, root2);



            //var s = new MyStack();
            //s.Push(1);
            //s.Push(2);
            //var p = s.Peek();
            //var pop = s.Pop();
            //s.Push(3);
            //var pop2 = s.Pop();
            //s.Push(4);
            ////var ie = s.IsEmpty();

            // var s = sol.MaxSubArray2(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 });


            //var l = new ListNode(1);
            //l.next = new ListNode(2);
            //l.next.next = new ListNode(3);
            //l.next.next.next = new ListNode(4);
            //l.next.next.next.next = new ListNode(5);
            //var oel = sol.OddEvenList(l);


            //  var a = new int[][] { new int[2] { 1, 2 }, new int[3] { 1, 2, 3} };

            //  var fcn = sol.FindCircleNum(new int[][] { 
            //  new int[]{ 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
            //  new int[] {0, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0 }
            //, new int[] {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
            //, new int[] {0, 1, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0},
            //  new int[] {0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0}, 
            //  new int[] {0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0}, 
            //  new int[] {0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0}, 
            //  new int[] {0, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0}
            //, new int[] {0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0}, 
            //  new int[] {1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0}, 
            //  new int[] {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0}, 
            //  new int[] {0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0}, 
            //  new int[] {0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0}, 
            //  new int[] {0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0}, 
            //  new int[] {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 }});


            //var l = new ListNode(7);
            //l.next = new ListNode(2);
            //l.next.next = new ListNode(4);
            //l.next.next.next = new ListNode(3);

            //var l2 = new ListNode(5);
            //l2.next = new ListNode(6);
            //l2.next.next = new ListNode(4);

            //var io = sol.IsOneEditDistance("ab", "ac");
            // var r = sol.ReverseOnlyLetters("a-bC-dEf-ghIj");

            //var q = new MyCircularQueueListNode(3);
            //var r = q.EnQueue(2);
            //var a1 = q.Rear();
            //var a2 = q.Front();
            //var a3 = q.DeQueue();


            //var root = new TreeNode(1);
            //root.left = new TreeNode(2);
            //root.right = new TreeNode(3);

            //root.left.left = new TreeNode(4);
            //root.left.right = new TreeNode(5);
            //root.right.right = new TreeNode(6);

            //root.left.left.left = new TreeNode(7);
            //root.right.right.right = new TreeNode(8);
            //var s = sol.DeepestLeavesSum(root);





            //Console.WriteLine(sol.wildcard_match("aaab", "aab")); //true;
            //Console.WriteLine(sol.wildcard_match("aab", "aaab")); // False
            //Console.ReadKey();
            // Console.WriteLine(wildcard_match("hello world", ".ello"));
            // Console.WriteLine(wildcard_match("hello world", "..llo.wor"));
            // Console.WriteLine(wildcard_match("hello world", "or.."));
            // Console.WriteLine(wildcard_match("hello world", "or..."));
            // Console.WriteLine(wildcard_match("hello world", "...llo"));   


            //var m = sol.MaxRepOpt2("abcaa");


            //  var cc = sol.CoinChange(new int[] { 2, 1, 5 }, 4);



            // var e = sol.Exist(new char[][] { new char[] { 'A', 'B', 'C', 'E' }, new char[] { 'S', 'F', 'C', 'S' }, new char[] { 'A', 'D', 'E', 'E' } }, "ABCCED");


            // var c = sol.Check(new int[] { 3, 4, 5, 1, 2});

            //var ln = sol.LuckyNumbers(new int[][] { new int[] { 1, 10, 4, 2 }, new int[] { 9, 3, 8, 7 }, new int[] { 15, 16, 17, 12 } });


            //var matrix = new int[][] { new int[] { 0, 1, 2, 0 }, new int[] { 3, 4, 5, 2 }, new int[] { 1, 3, 1, 5 } };
            //sol.SetZeroes(matrix);
            //var ai = sol.MyAtoi3("+"); // "20000000000000000000");

            // var up = sol.UniquePathsIII(new int[][] { new int[] { 1, 0, 0, 0 }, new int[] { 0, 0, 0, 0 }, new int[] { 0, 0, 2, -1 } });



            //var pi = new PeekingIterator(new List<int> { 1, 2, 3 });

            //var a = pi.Next();
            //var b = pi.Peek();
            //var c = pi.Next();
            //var d = pi.Next();
            //var e = pi.HasNext();



            // var si = sol.FindSpecialInteger(new int[] { 1, 2, 2, 6, 6, 6, 6, 7, 10 });

            // int[] d = new int[] { 0, 1, 2, Int32.MaxValue }; //, Int32.MaxValue};
            // var hd = sol.HasDupes(d);


            //var numsubmatrices = sol.NumSubmat(new int[][] { new int[] { 1, 0, 1 }, new int[] { 1, 1, 0 }, new int[] { 1, 1, 0}});




            //  var su = sol.SumOfUnique(new int[] { 1, 2, 3, 2 });
            //var siw = sol.SwimInWater(new int[][] { new int[] { 0, 2 }, new int[] { 1, 3 } });
            //   var mcw = sol.MostCommonWord("Bob. hIt, baLl", new string[] { "bob", "hit" });

            //var us = new UndergroundSystem();
            //us.checkIn(596854, "EQH524YN", 13);
            //us.checkIn(29725, "Y1A2ROGU", 17);
            //us.checkOut(596854, "8AYN1B7O", 115);
            //us.checkIn(579716, "EQH524YN", 145);
            //us.checkOut(579716, "8AYN1B7O", 199);
            //us.checkOut(29725, "8AYN1B7O", 295);
            //us.checkIn(939079, "16MTS56Z", 371);
            //var at1 = us.getAverageTime("EQH524YN","8AYN1B7O");
            //var at2 = us.getAverageTime("Y1A2ROGU", "8AYN1B7O");
            //us.checkIn(697035, "EQH524YN", 442);
            //us.checkIn(90668, "Y1A2ROGU", 508);
            //var at3 = us.getAverageTime("EQH524YN", "8AYN1B7O");


            // var dn = sol.FindDisappearedNumbers(new int[] { 4, 3, 2, 7, 8, 2, 3, 1 });

            //var s = sol.CustomSortString2("cba", "abcd");

            //   var sk = sol.SortKMessedArray(new int[] { 1, 4, 5, 2, 3, 7, 8, 6, 10, 9 }, 2);


            //var a = "a";
            //var b = "b";

            //var r1 = a == b;

            //var r2 = a.Equals(b);
            //var cs = sol.CombinationSum(new int[]{ 2, 3, 6, 7 }, 7);

            //var sm = sol.sockMerchant(10, new int[] { 1, 1, 3, 1, 2, 1, 3, 3, 3, 3 });
            //var ms = sol.minimumSwaps(new int[] { 4, 3, 1, 2 });


            //var l = new ListNode(2);
            //l.next = new ListNode(5);
            //l.next.next = new ListNode(3);
            //l.next.next.next = new ListNode(4);

            //l.next.next.next.next = new ListNode(6);
            //l.next.next.next.next.next = new ListNode(2);
            //  l.next.next.next.next.next.next = new ListNode(2);





            //var sp = sol.SwapPairs2(l);
            // sol.minimumBribes(new int[] { 2, 1, 5, 3, 4 });

            //  var fd = sol.foo(250, new List<int>() { 100, 180, 40, 120, 10 });

            //  var dc = sol.doesCircleExist(new List<string>() {  "GLGLGLGL" });


            //  var cs = sol.connectedSum(4, new List<string>() {"8 1","5 8","7 3","8 6"});

            //  var l = new ListNode(1);
            // l.next = new ListNode(0);
            //l.next.next = new ListNode(9);
            //l.next.next.next = new ListNode(9);


            //var l2 = new ListNode(7);
            //l2.next = new ListNode(3);
            //l2.next.next = new ListNode(2);
            //var ai = sol.add_integers(l, l2);

            //var mp2 = sol.MaxProfit2(new int[] { 7, 1,5,3,6,4 });

            //var pes = sol.ProductExceptSelf3()
            // var mcw2 = sol.MostCommonWord2("Bob hit a ball, the hit BALL flew far after it was hit.", new string[] { "hit" });
            //  var gmn = sol.getMissingNo(new int[] { 1, 2, 4 }, 3);
            // sol.test();


            //var root = new TreeNode(4);
            //root.left = new TreeNode(7);
            //root.right = new TreeNode(9);
            //root.left.left = new TreeNode(10);
            //root.left.right = new TreeNode(2);
            //root.right.right = new TreeNode(6);
            //root.left.right.right = new TreeNode(6);
            //root.left.right.right.left = new TreeNode(2);

            //var ael = sol.getavgeachlevel(root);

            //  var pt = sol.Generate(5);
            //  var css = sol.CustomSortString3("cba", "abcd");

            // var cc = sol.CountCharacters(new string[] { "cat", "bt", "hat", "tree" }, "atach");

            //var ilpn = sol.IsLongPressedName("leelee", "lleeelee");
            //   var ilpn = sol.IsLongPressedName("saeed", "ssaaedd");

            // var cc = sol.CommonChars2(new string[] { "bella", "label", "roller" });
            //  var dn = sol.FindDisappearedNumbers2(new int[] { 4, 3, 2, 7, 8, 2, 3, 1 });


            //  var sn = sol.SingleNumber(new int[] { 4, 1, 2, 1, 2 });
            //  var zeroed = new int[] { 1, 10, 20, 59, 0, 3, 0, 4, 0, 88 };
            //  sol.move_zeros_to_left(zeroed);


            //var root = new TreeNode(100);
            //root.left = new TreeNode(50);
            //root.right = new TreeNode(200);
            //root.left.left = new TreeNode(25);
            //root.left.right = new TreeNode(75);
            //root.right.right = new TreeNode(350);


            //sol.LevelOrderTraversal(root);

            // var p = sol.Power(2, -2);
            //   var sets = new List<int[]>();
            //   sol.GetAllSubSets(new int[] { 8, 13, 3, 22, 17, 39, 87, 45, 36 }, sets);

            //*********************************************************************************************************************
            //var two = new GraphNode(2);
            //var three = new GraphNode(3);
            //var four = new GraphNode(4);


            //var one = new GraphNode(1, new List<GraphNode>() { two, four});
            //two.neighbors = new List<GraphNode>(){ one, three };
            //three.neighbors = new List<GraphNode>() { two, four };
            //four.neighbors = new List<GraphNode>() { one, three };

            //var cloned = sol.CloneGraph(one);



            // var sr = sol.SearchRange(new int[] { 2, 2 }, 3); // { 5, 7, 7, 8, 8, 10 }, 8);
            // var s = sol.Search2(new int[] { 4, 5, 6, 7, 0, 1, 2 }, 3);
            //sol.Rotate(new int[][] { new int[] { 5, 1, 9, 11 }, new int[] { 2, 4, 8, 10 }, new int[] { 13, 3, 6, 7 }, new int[] { 15, 14, 12, 16 } }); 
            //  var nw = sol.numberOfWays2(new int[] { 1, 5, 3, 3, 3 }, 6); // 7, 9, 5, 3,3 }, 6);
            //  var rc = sol.rotationalCipher("All-convoYs-9-be:Alert1.", 4);
            //Expected:   "Epp-gsrzsCw-3-fi:Epivx5.";

            //var l = new ListNode(1); 
            //l.next = new ListNode(2);
            //l.next.next = new ListNode(3);
            //l.next.next.next = new ListNode(4);
            // var r = sol.ReverseList(l);
            //

            // var cgec = sol.canGetExactChange(94, new int[] { 5, 10, 25, 100, 200 });

            // var cgec = sol.canGetExactChange(75, new int[] { 4, 17, 29 });


            //var people = new Person[]
            //{
            //    new Person()
            //    {
            //        Name = "a",
            //        Born = 2000,
            //        Death = 2010
            //    },

            //      new Person()
            //    {
            //        Name = "a",
            //        Born = 1975,
            //        Death = 2005
            //    },

            //        new Person()
            //    {
            //        Name = "a",
            //        Born = 1975,
            //        Death = 2003
            //    },

            //          new Person()
            //    {
            //        Name = "a",
            //        Born = 1803,
            //        Death = 1809
            //    },

            //      new Person()
            //    {
            //        Name = "a",
            //        Born = 1750,
            //        Death = 1869
            //    },


            //      new Person()
            //    {
            //        Name = "a",
            //        Born = 1840,
            //        Death = 1935
            //    },
            //      new Person()
            //    {
            //        Name = "a",
            //        Born = 1803,
            //        Death = 1921
            //    },

            //      new Person()
            //    {
            //        Name = "a",
            //        Born = 1894,
            //        Death = 1921
            //    },


            //};

            //var maxpop = sol.FindMaxPopulation(people);


            //var root = new TreeNode(8);
            //root.left = new TreeNode(3);
            //root.right = new TreeNode(10);
            //root.left.left = new TreeNode(1);
            //root.left.right = new TreeNode(6);
            //root.right.right = new TreeNode(14);
            //root.left.right.left = new TreeNode(4);
            //root.left.right.right = new TreeNode(7);
            //root.right.right.left = new TreeNode(13);
            //var visible = sol.VisibleNodes(root);


            //var s = sol.matchingPairs("", "");


            // var ml = sol.MinWindowNotMine("dcbefebce", "fd");


            // ml = sol.MinWindowNotMine("dcbefebbacbfeb", "bbe");


            //  ml = sol.MinWindowNotMine("abc", "ac");

            // var fm = sol.findMedian(new int[] {5, 15, 1, 3});


            // var total = sol.getTotalTime(new int[] { 4, 2, 1, 3 });
            //var ma = sol.findMinArray(new int[] {5, 3, 1}, 2);

            // var ma = sol.findMinArray(new int[] {8, 9, 11, 2, 1}, 3);

            //var md = sol.getMilestoneDays(new int[] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 }, new int[] { 100, 200, 500 });
            // var days = sol.GetBillionUsersDay(new float[] { 1.1f, 1.2f, 1.3f });
            //var bal = sol.balancedSplitExists(new int[] {12, 7, 6, 7, 6});

            //  var uniq = sol.countDistinctTriangles(new int[,] { { 2, 2, 3 }, { 3, 2, 2 }, { 2, 5, 6 } });

            //var min = sol.minimumPrefixReversals(new int[] { 1, 2, 4, 3});

            // var min = sol.minOperations(new int[] {1, 2, 4, 3});
            //var min = sol.minOperations(new int[] { 3,1, 2 });


            // var lk = sol.LicenseKeyFormatting("5F3Z-2e-9-w", 4);

            //var lk = sol.LicenseKeyFormatting("2-4A0r7-4k", 4);
            //ar lk = sol.LicenseKeyFormatting("2-4A0r7-4k", 3);


            // var lp = sol.LengthLongestPath2("dir\n\tsubdir1\n\tsubdir2\n\t\tfile.ext");

            // var ip = sol.IsPalindrome(1000000001);

            // var nr = sol.NumRollsToTarget(1, 6, 3);

            //  var lp = sol.LongestPalindrome("cbbd");

            // var lp = sol.LongestPalindrome("aacabdkacaa");
            //MinConferenceRooms(new int[][] { new int[] { 0, 30 }, new int[] { 5, 10 }, new int[] { 15, 20 }});

            //var l = sol.RemoveElement(new int[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2);

            // var l = sol.RemoveElement(new int[] { 2,2,3 }, 2);

            //var mc2 = new MyCalendarTwo();
            //var tb = mc2.Book(10, 20);
            //tb = mc2.Book(50, 60);
            //tb = mc2.Book(10, 40);
            //tb = mc2.Book(5, 15);
            //tb = mc2.Book(5, 10);
            //tb = mc2.Book(25, 55);

            //var mc2 = new MyCalendarTwo();
            //var tb = mc2.Book(36, 41);
            //tb = mc2.Book(28, 34);
            //tb = mc2.Book(40, 46);
            //tb = mc2.Book(10, 18);
            //tb = mc2.Book(4, 11);
            //tb = mc2.Book(25, 34);
            //tb = mc2.Book(36, 44);
            //tb = mc2.Book(32, 40);
            //tb = mc2.Book(34, 39);
            //tb = mc2.Book(40, 49);




            //  var r = sol.Reverse(-123);


            //    var s = sol.BuddyStrings("ab","babbb");

            //  var cp = sol.ClosestSumPairs(new int[] { -1, 3, 8, 2, 9, 5 }, new int[] { 4, 1, 2, 10, 5, 20 }, 24);


            // var im = sol.IsMatch("aab", "c*a*b");


            //var fm = sol.FindMin2(new int[] { 4, 5, 6, 7, 0, 1, 2 });

            //var numsubmatrices = sol.NumSubmat2(new int[][] { new int[] { 1, 0, 1 }, new int[] { 1, 1, 0 }, new int[] { 1, 1, 0}});

            //var rp = new RandomPick(new int[] {-11, 2, 3, 3, 3 });
            //var r = rp.Pick(3);
            //r = rp.Pick(1);
            //r = rp.Pick(3);








            //  var picks = new int[] { -1002464978, -68020051, -1462267596, 1317081354, -888922907, 709696102, 1566377039, -1568877186, 1975821187, -242325840, 317741131, 1029545763, 1955280671, 1893328244, 2093616131, -482518759, -714187586, 275678785, -2087905559, -1133540364, -2025446997, -516336286, -1251713464, -672993494, 397763492, -1151463861, -423085760, 2060203531, -1216235733, 1432526354, -167581936, 1605950372, 834406161, 1968791536, -45297112, 738141992, -1228566543, -364754177, -360751980, -983948383, 412673963, 725918816, -310613135, 370644200, 642313055, -1970525419, -1697058904, 1016585295, -1450613598, -1841144696, 821057663, -970457088, -501524242, -309374753, -1200613413, 615121420, -1918986005, 1848134926, -1349226362, -1372431586, 1674029384, 131178055, 1292801910, 227047929, -801771049, 775453731, -1626213089, 186338334, -1192847875, -730944471, -913618417, 1638202134, -1273573202, -941015785, 1115202197, 741802099, 958112505, -1202787942, -232190071, 1645261758, -1507846737, -816141589, -206408385, 427626634, -848661292, -2124980648, -1606808617, -583788369, 324063966, -672941063, 1191535100, -466791352, 2126072215, -1642193008, -921853792, -825942334, 2146452158, -1337978577, 1798001512, -153011858, 1897794843, -773236891, 1275898877, 1247081290, -1287025276, 1740159875, -780642733, 315650296, 2014442314, -701663671, -169263053, -1025348238, -1441015859, 814396953, 1494365140, 1983574551, 1723893704, 238003093, 2042400556, 898482288, 218387801, -669791742, -108941855, 126166200, -42426066, -629573754, 1120731202, 1136406888, 1236013361, -1583727760, 1669956609, 156689481, 651930527, 1789007232, -2136639904, 47367889, -623984757, 2078025957, -972930537, -812733600, 1267223961, 1012441021, 1860222598, 1918769592, 1001674578, 649031280, -844760230, -381588608, 445895811, 1538935169, 201421488, 98353522, 359267686, -622969692, 2069321254, -1006289347, 16908663, -58139448, -248086586, -1657828891, -2129453660, -2137316550, 1628266939, 1952996536, 217835664, -405302488, 454912692, -199667165, 383741368, -1136950343, -1039117932, -214792229, -1469925981, -549335831, 1892160569, -172396004, -1008677120, 2122731118, 450086180, 1668620439, -1094622256, 1280815874, 1505595611, -538499832, 2073589735, 420084889, -1548151169, 350419124, 1629459109, 434372363, 1404547248, 551467154, 990032929, -2089833537, 1690969652, -1418881291, -1092075604, -480157741, 1068550033, 1008024585, -1752962988, -2108470178, 140650956, -423639279, -1438317909, 1276491241, 1323152895, -1454337382, -1096695545, 1157398395, 157552126, -377949934, 1593598944, -2145180348, 202753860, 2131354894, -1438596138, -856202755, 80157004, 257069176, -1575688476, -221269680, -218986452, 778525081, 1784062091, -1577206828, 582538032, -1670368772, -1343277195, 318539566, -299272772, 1843441301, 710440830, 1480120183, 1130264052, -1406649724, -1052830787, 618841210, -336266537, -1410693566, 47207631, 475670355, 394310001, -1841085640, 376708861, 1970266463, -414749596, -1137446894, -1676107967, -1160650981, 930650487, 1859707965, -1847746147, 2102568272, 934933512, 383815885, 1346135106, -308538792, 572067582, 1380313926, 134477858, -626960019, -1630962167, 577933277, 277688273, 424567439, 609942213, -2063490530, -1486019045, 903956962, -1244093252, 1686412712, -137654151, -1600332474, -2038916343, -2010772753, 430775956, -984300147, -1000929663, 2135872606, -1862904269, -1788636261, 2081431165, 464282769, -526558401, -960242362, 1421862321, 1411838251, -208555140, 1921459902, -789492882, -1738879976, 1830482313, 1185845774, -112034308, 1881487766, 506918481, 505727142, 1689142373, 30917487, -173751578, 988682490, -1780071192, 1127750249, 672577328, 2102253350, 1368591180, 293905606, 1050293588, 237148718, 2109783721, 1568110388, -651278357, 1744148974, 688767855, -1154485902, -1914746898, 1125063024, 578158092, 2024545584, 2089485037, 1192648779, -2006987159, -1723359015, 1571339071, 1107216828, 2069389428, 609127404, 1178934316, 1822728418, -1844814653, -1234698995, 797966206, 595061268, 2056997982, -48242940, 11858302, -709140981, -1363213365, -1558576467, 356401791, 1655654124, 1080604586, -715236534, 301847926, -966906577, -1696578397, 1053589760, -1084181603, 31689097, -50275713, -519349225, -1725830112, -153254264, -681951655, -1668236844, 914219754, 890635982, -626486948, -1667720114, -2098755479, -1922444848, 1783539762, -10705005, -2060107328, -1993995948, 81587335, 1800453455, -360511803, -160923034, 498879775, 4886777, 1559302415, -1202625748, -214072741, -1190683731, 1115112066, 1606639212, 977216412, -1540495675, 2105384189, 2615284, 544566631, -1015179255, 847361072, -1891235609, 1220573546, 1362220041, 12322986, -512114752, 1449360181, -7621766, 390230060, -1185814858, -870715852, -1093854060, -1367603373, -1048518050, -1772092555, -1834439022, 655045940, 705202408, -1323815192, 1580171286, 82443597, -1231731605, 1507496619, -1814124933, 189924291, 290226368, 758491460, 798654919, -572579138, 1495330206, -1919318501, 1540929713, 1585760120, 1928816928, 2018820912, 1984783274, 1375153475, -817418630, 459219051, 2132984914, 436412511, 2146623247, -1890538288, 2130106798, 859581592, -1870196515, -437441893, -758761449, -170596680, -1695724361, -555951206, 161807899, 622887228, 472237040, 1135608613, -1810907289, -1460637244, 457817003, 403040541, -564651659, -786557734, -1856799825, -1799000789, -1023162907, -494052038, -360215200, 1787339205, -1415621345, -706633775, -15089422, -1215716556, -878896650, 1114945010, 1255730874, 316228175, -120606690, -1066255957, -284829460, -1585795586, 543112313, -1029076590, -1310667890, -664082113, -1836764944, -665961663, -1060888412, 1634738858, -250275021, -219930922, 721137884, 1196661510, -1321470932, 42247351, 1823602602, -1166469072, -1156251943, -591969309, 2100982879, -381126446, -792825325, 1034886889, 2048060255, 297628049, 264271258, -782154492, 1387746094, 1966586113, -1035714941, 2086451450, 1772901345, 1373000733, 636037314, -523943241, -974011674, 1655105438, -1590459934, -1152537231, -795915828, 903704262, -1385406790, -275673026, -975431235, 1799877591, 1027309270, 360145482, -1832825876, -1730206840, -82795215, 1023017222, -1639134082, -2066179277, 1419777230, -835105980, 761552648, -1398928275, 1932588431, -43429440, 234094875, 991084144, -141720223, 2107163638, -121238255, 195899277, -1260682671, 761963677, 1251334793, 1483171819, 190663431, -61821726, -533318814, -988511235, -1413576321, -753048440, 432548979, -1244068191, -205992483, 554849452, 163533675, -1483690610, -185163794, 1976849401, -61379039, 492280302, -568895520, 985549607, 2113377564, 689547281, 1541195551, -1528148441, 1848303158, 1117601164, 1675622859, -527740333, 2126096483, 1725391129, 1163968901, -1141614851, 1888894718, 1855340346, 743940416, -1193272777, -279905493, 1736941744, 938953000, 1953967036, -120611110, 303168995, 449198584, 177232247, 1717409390, 382249489, -795779123, -1404390711, 559201997, 209587426, 348803901, -1932870294, 468156844, 1031881490, -957003849, -213777845, 429094465, -1349659495, -1513367588, 1218238529, 1792974872, -1188474630, 1044419905, 1587707320, -1885356112, -1345874035, -353514582, 1046399757, -126431238, 409198272, 42292794, -2103982887, 1879938170, 2019036467, -2014606175, 142222964, 71669344, -1819112924, 1813240902, 1241292538, -2117301956, 1796641834, -821084057, -241687606, -736808073, -1759678446, -641098721, 856501365, 1198256130, -1836157173, -1659282979, -467261937, 551505039, -761048431, 217536258, 1085735074, 1489077077, -42304030, -1804730219, -999670178, 1135890486, 1892252927, 1038159187, -1757018002, -338232834, 486276566, 1677197699, 2000236291, -91305854, -738827758, -960414801, 1685129336, -118242281, -635261775, 1760169041, -44989576, 768219752, 596251023, -39337841, 1733133647, 1751704006, -808124881, -465181152, 1501475557, -171981997, -336306421, -1570204545, -834124532, -761719793, 2143521482, 902755594, -1304191184, 181331942, 98205229, -1035024607, -1671951118, 1746688355, -1276771578, 1250654054, 724496727, -1584333002, -45883165, 118356714, 950705170, 117134473, 898593691, 971684066, -40156282, -386559138, 1575628287, -1915276036, 1825143172, 30672650, -352237609, 1853358684, -1652738942, -351551388, 586945080, 436989880, -1058172265, -39395939, 1931083162, -120899572, 1923405983, 1581598553, -510244191, -2061480135, 1678721153, -1962023865, 1277132427, -1110886287, -1523372032, 785745830, 717155305, 801401289, 1784565254, -158147337, -1680301157, -460504490, 1392568413, -461163032, -580818353, 670852298, -103451526, -628948457, 1031251156, -1179811655, 1918469873, -2137145420, 2109641272, 1223242050, -1576488702, 1980581259, -1304997821, -1973037732, -1675321690, -841452636, -261013732, -80575033, -191729963, 357573379, -1820648232, 907793958, -322565590, 1087234810, 929248841, -1670024096, 1540097236, -288279856, -141092235, 918430357, 231182672, -2005390195, -1398748564, -2000829321, -1391491023, -1368579809, 1240282601, -1189579631, 617155061, -982875820, -1285547626, 177296625, -739733295, -31922668, 163864244, -338645412, -1803649270, 140537471, -1163980465, 164638081, -536168498, -1279894328, -1861997574, 1519259484, 1638696325, -213306259, -1902621511, 621251278, 1945719456, -1854308158, 75657734, -269777554, -748079983, 669030873, -1881671881, -970549033, 290292907, 1371499556, 1162288140, -1805544819, 934112708, 1697378226, 1738216678, -1058746205, -1564097559, -1652799741, -1283953690, 263426793, -1896007391, -244408901, -967275971, -2084845592, 89746712, 1679929880, -148188575, 555900577, -408965409, -701839648, 454340340, -1901029532, 873012643, -1124651743, -498381664, -1599494812, 1227310836, 362815508, 1834816954, -1431164416, 451344581, -729454164, -371134611, -1882375344, 113777664, -645846783, 1350392279, 2046898780, 598573648, 374223231, -144451767, -1842426578, 249615552, 1743477937, -1470148278, 1741520859, 627467573, -1846316811, 713489615, -2056567494, -2043781571, -2119201999, 1068270768, -821773091, -836932437, -545087630, 1660383348, -1617123048, 1428499863, 539044774, -748181862, -1944223362, -778342480, 886719403, -576015629, -1302699823, 1362924099, -690008141, -1592032021, -520568407, 2146874815, 1087868986, -204625677, -1064672989, -789232338, -2112440180, -1579850728, 417679337, -1302620388, -81898331, -1312426933, -2037998697, 568026741, -1225284617, 1209231996, 1756065287, 1831018973, -1086153174, -678908670, -26592532, -1197098806, -672943426, 80425847, 1382679299, 175550893, 487256336, 1884163576, 1437196676, 910401359, 1205789903, 109438383, 1424913094, 1913171037, -1153001737, 1462328803, -948574285, -747630144, -491526505, -911608133, -1076837257, 1218576258, -1879283119, -1551632747, -2074492355, 831641405, -692591544, 999693296, 651022700, 1632169731, 1891428481, 1212018891, -1722977065, -453076185, -1982329054, 2029248250, 638270231, -574905753, 1350625001, 993937862, 331361609, -1949384252, 831997567, 1357556644, -526592432, -654457434, 1481513537, -485039753, 1165443159, 1352304341, 2123660492, -1738841987, 1149662751, 595392162, 420817144, 444025802, 533134554, -65032476, -157069603, -601823963, -839461477, 164195755, 2025793879, 414159436, -1540068254, -2019810732, 1860629281, -1189880355, -50817822, 1989261895, 756523448, 505060040, -232133840, 372744844, 61867796, -575666904, -78240182, -1427512726, 376132, -1159135821, -1904259225, 251046254, 816198450, 680631243, 1658758594, 782414926, -1884790626, -1203585939, -866417759, -1326617461, -1942204212, -1606136784, 5951507, -860076726, 193044629, -207997213, -680253061, 1132142029, 643618092, 844218035, -1831579358, 2077623996, -703298447, 1554519154, 1141606433, 1618507090, -1457853482, 1146355980, 1984413477, 427853541, -1359914572, 1177496430, -1892900244, -2008896853, -1567107417, 1627585867, 903098026, -570004152, -1269762493, -1379145336, 1434748456, -2077112061, -1724345036, 36354205, -241817028, -1348172149, -1684239714, 348793226, -1692098008, -2536282, 2024103913, 704532899, 1931807930, 263980817, 1235388766, -588664115, -1745763465, -1551944689, 1987975806, -761022215, 919703908, -88779947, 43682107, 57606813, -1568046009, 2035030653, -578079338, -1548647028, 454904122, 1985859644, 331241700, -1062892797, -1466202779, -1314496210, -321464143, -1621356841, -113461229, -304061812, -1666228908, 900257123, 576856233, -1168038608, -135863311, -652835333, 783243489, -1621317868, 1248209057, -41418709, 886302836, 1908586882, -1201339752, -1745641510, -970783129, 1491030692, 1089223282, 186540377, -637672637, -1878188876, -680851936, 561022943, 1700695486, 2051662832, 513185952, 309877506, -1960030281, 385516144, -758671881, 2131895804, 1214386531, -1606295997, 1480768018, -1768828132, -749321779, 1055115895, -1502144035, -1318069413, -958850766, -1432422519, -259258529, 1022522654, -1903232385, -653594545, 628692426, 2034724875, -463440765, -294195194, -1323079033, 530546378, -731207527, -410035381, 855583702, 1909396814, 247681734, -1700296285, 164266734, 891564123, 1311700499, 566216974, -1079402834, 977468676, -1090098655, -1370206977, 164957009, 1566764159, 1113563990, 1102756094, 1833223226, 1325007434, 416747884, -1275737047, 61823274, -848330445, -894224060, 1938181840, 1108559960, -135192483, 568525614, -813820156, -2099427247, 1819863526, 1903272150, 267701897, 942966974, 1019563260, 1098675562, -421942498, 1479786312, -1713679584, -1441697391, -656365570, -321198422, -1215692241, -956028606, -168197726, 1390277972, 1526938414, -1326072830, -1754036067, 1547973500, -473831985, 2053081122, -181418661, 284746724, -698543808, -2103303084, -1732721113, -1519572290, 1112787996, 552416463, 861515733, -2138574980, -1011066046, -1164075942, 983440606, 1868497312, 529687711, -251465281, 1564223938, 1379711593, -274368918, 1468192694, -278886323, 570741758, 1984170481, 1993602396, 1134959295, -1081953439, -61204364, 792207282, -395949282, -213971678, -255655867, 241273440, 1434068371, 1774282171, -393402057, -298610725, 1937893072, -1374826152, 1760262141, -1181084689, 1674025130, -1399539970, -266198581, 1878624623, 1891127596, -1206581032, 253430175, -284354507, -499899114, 11143146, -985323632, -578892455, -272693347, -841718945, -921321773, 2146305998, -254387674, 2049453286, -1348872734, 2129327416, 1128892573, -521682658, 674500235, 1024755197, 956082792, 817648042, -495925422, 1923793117, 222151083, 1843706599, -1525928702, 798542327, -1760476697, -174735750, -1810901622, -1294132626, -171186791, -1178527874, 78877989, 200393293, 1935209947, -1628637876, -45045758, 1330423933, 1752950473, -1788353189, 1430218511, 427960478, -1109464840, 615535677, 1395357421, -392928530, -948950847, -962206945, 1126093157, 600678380, -878850224, -374557545, 733782538, -1120157732, -1711006515, -865150774, -1274609976, -697067126, -273998500, 2010570964, -1740100600, 214595826, -1343504455, 1202362556, -1026659692, 478052411, 703226429, -1269378272, -1387201383, -2146718251, 1746142715, 1615031155, -1949268799, 606379792, -33921075, -493025252, 1918998061, -977930102, -1767930167, 645895908, -189587797, 1960788868, -303773484, 1201953365, -429739834, 159571435, 1958810245, 457801201, -951055806, 1833117084, 937525415, -362121151, 624388299, 474594888, 942260072, -472574713, 1210240, -961449890, -1837699529, 95598507, 1246785017, 1602455721, 621879547, 814337864, 217276178, 518193792, 663420898, 1007124626, 754443420, -1987087659, 1203459925, -952394703, 662194208, -1248805341, 872706527, -1668839372, -403253377, 1933238617, -1810532628, -1193067123, -827636129, 308423691, 1806008520, -687220111, 1267431886, -1893073048, -1252931109, 408101216, -807733541, 679966762, -1659956457, 94341729, -133026118, 1880617337, 904588805, 341664194, -312201310, 1246739910, -1224230061, -199756, 1204619506, -1467401768, 631458618, -1162175524, -1669001188, 1072869194, -751643866, 2031833171, 609377594, -152778917, 55683534, -1428920550, -39191297, -838779251, -1378368543, 816902063, 1662784052, -581015513, -128349563, 1730393191, -1224550201, 874337376, -1390598538, 249115902, 1193432906, 606762300, -479386183, 264571800, 294520149, -1037581641, -1254461725, 1892924952, -1611315440, -2049872495, 214152546, 577200641, 1378627532, 1615851585, -1989539324, 1391057105, 596833534, 1651533041, -2070582369, 275458178, 2131910418, -1451816604, 1852432040, 786094441, 808789331, 1026464547, 95346290, 499015322, -521603367, 301936397, 1142724918, 1775575347, -898945450, 607289249, 1605180479, 1516067953, 2025410408, 1914408234, -1282043872, 1601571554, -1426968962, 167302306, -713285097, 493053129, -184473755, -492425506, 1995372500, -1276293838, 1793395071, 336216440, -724854233, 1753831900, -720067494, 1957783124, 1478708709, 856963403, -106288401, -1151500423, 1816588592, 1270294106, -1048520752, -1600533221, 511274686, 100909215, -366516899, -74323294, -1689550372, 979882554, 693878880, 1579762430, 1156040953, 2051707181, 235681760, -1541635174, 1557827682, 128405091, 1775190576, -392451652, -2021839010, 405187502, 658166639, 1236031340, 1581934721, 1278024628, -90716982, 2004343997, 955377414, 734811661, 688664506, -1999699490, -1345617933, -1406856696, 1130982400, -1511779510, 1338221445, 577544447, 2023409751, 1773122482, 1931220632, 1519458747, -496756908, 742540725, 1861634776, 1031361870, -905256565, 1007722784, -1848680187, 2093901136, 698407896, -490214804, -1855657777, -1459807227, 1785748918, -1230321948, -656375304, -1893271659, -796533990, 451459285, 1922668358, 570066493, -624348410, 2008802977, -1012902693, 1263418083, 580852856, 1332057582, -416012924, -1919414258, -607932137, -1354190127, -2116526949, -2122858245, 1873410729, -43187405, 1004099243, -1702695250, 268474261, 1012192404, 1853919331, 611522737, -1673158178, -433557081, 345, 1907196897, -167885707, 2078222097, 17988523, 1289509139, -38111118, 131780905, -1347296521, -621812974, 889599102, -276638035, -1552442572, -1723230035, 1489894231, -1968293202, 1254563474, -156839167, -1146365421, -1249468628, 1334200960, -1441601556, 1370887514, 1088652869, -497705488, -1737442366, -172532428, 862466023, 2029298589, -158993728, 706231456, -758114500, 1560473198, 1809431909, -1603025110, -1875807640, 1826856738, 1957194149, 564813219, -1637905399, 1849533920, -2101855210, 1792818119, 1565617860, -1077978164, 915233965, 900012746, -1348455071, -93079248, -1938953793, -335508667, -2021950032, 439373307, 2045817802, 1267783419, 352981959, 1429435666, 1082961121, -96166931, -319667654, -2101445342, -785489478, 484482773, 1229957636, 376302495, 443508588, -1601968485, 1026888352, -1165903363, -1190653260, -1655637670, 1587771952, -1465043439, 524775809, -725238871, -1576630058, 1848824283, -2043886472, -898923853, -17979159, 1216530528, 228529819, 1630283309, 724778209, 25460202, -1179294990, 670100885, -698360707, 352052666, 1666622737, 410167734, -1862607650, 1558033139, 1897530799, 968124758, -513268618, -1517600030, -2114194299, 610518896, 272707493, 730878553, -665269140, -958415520, 1620073671, 1380745308, 172279393, 2160997, -1047484991, 1788983789, -1037277789, -1620809774, 1095795012, -1495085865, -908314164, 548457767, -433872148, 319867724, -1964120813, 207279622, 260256869, -364615731, 95047238, 129543255, 1590613804, 717287355, 1934993989, 49632917, -368858188, 454744448, 1161116748, -600548632, 1147458433, -1778113641, -85112232, -1612026611, 1884653098, 1458741301, -1618969737, -170401380, -1830558657, -529557565, -787765554, 1186598402, -1892936270, 1992722541, 126014695, -961118226, 1884601147, -1285969740, -1144208936, -1958047806, -173023925, 2070249280, -448716015, -529851629, -676010212, -1856101514, 1349141010, -1744480672, 1495836638, 276879242, -1393993836, -715694081, -877107699, -1967232848, 1091952638, 465124914, -2126020346, -1523473654, 1469466727, 1929447287, -1140293273, 82147072, -1338511572, 669480924, -2054059515, -867811308, 948006351, 763369073, -477763081, 1406216384, -1405365152, 2126823208, 326864496, 1474665081, 1599663066, -1045036884, 968382116, -1559316307, 2130473506, -401871028, -2013443299, 1402688544, -1600884473, -1963919806, -122630389, -524210336, -1835319572, 1555868998, 1285181766, 533003299, -2047953079, 1781103641, -382367544, -2043858398, 1524147965, -293138839, -2146257704, 1915152782, -675107202, -900839867, 442955032, 495006874, 1470961108, 657410461, 412997841, -1590703961, -1266853968, 220384173, 509646467, 577606965, -1150787254, -1380517689, -1138440414, 1659959797, -1699319729, 483785797, 636806970, 284586850, -1582880499, 1994338717, -1851585412, -2125874463, 1120362855, 1257121802, -1906876440, -1228697188, -1593090530, -1108632686, 748458794, 1976902711, -1999969171, -1447006257, 1741525911, 325696458, 559999019, 828288017, -1643511870, 1037586974, 1488479158, -728362993, -13960920, -161659811, -542108529, 1719729318, -1178520592, -34038279, 2098492316, -287963190, 1689338603, -1175684808, -1695228887, -684164928, -841179650, 931531288, -283511646, -1009573867, -1041978045, 649577074, -810651962, 244209667, 757467089, -995407871, 1202527654, 1768161361, 2050306288, 1420547191, 838571361, -2130479428, 34940817, -856244560, -1878101784, 804222078, 1471083686, 1370957602, 540226339, 1506792988, 1579273901, 1605509551, -238556247, -1030406673, 1994359067, -369120539, -361843043, -2038706331, -1075138282, 623791559, 1645906667, -221640991, 1948375491, -480049574, 1366804226, 1060260179, -2022933511, -55945790, 1359243964, 1457585447, -1346729570, 68530135, -1169833555, 187347855, 1974521872, -314260879, 659203032, -1871794211, 1803280928, -1555313329, -431436848, 1928079262, -979970737, 1021806021, -908502287, 312736596, 761478182, 1224858003, -934062252, 1767926451, -1982991684, -2091279045, 1349443825, -1145939572, -1593025532, 1906440584, -565736861, -1251374951, -1367658189, 2120630658, -1709570536, 1029093793, -2122241592, -1178004486, 223778695, 341062061, -1979322211, 17428000, 790210369, -1906964485, 394946475, 592969913, 98048543, -532804298, 663638079, -251726322, 921546160, -110835550, -155658508, 1548223015, -1861809799, 2056445594, -1346235117, -723231561, -1877284809, -340350533, -939604318, -1032205996, 1899785390, 472672249, 1912738173, 472901735, 1205958304, 2131937205, 708744303, 1798908498, 2026994418, 68209587, 1255916308, -581014209, -1044623582, 1454039888, -473351232, 1682155560, 1748287299, 74626696, -1479744483, 639169477, -781501997, -299403460, 1343869057, 910600517, 2045629820, -212033681, 486671902, -2109380554, -333273383, 1798554615, 320073049, -1274798256, -613581842, 1912926065, 1322158759, -147410608, -767903455, -1104338493, 1975795040, 43758720, 1411187543, -1180665112, 1116544769, 1837200189, -331427575, -2112060959, 1012983757, 1052966770, -1690189120, -960237509, -729113147, 814499370, -455728529, 2057934630, 565088521, -1480587370, -750475280, -1761157749, -1768912391, -826290785, -443354937, -167468311, -1858150951, 1584882381, -777399466, -683857531, -2014124948, 317456735, -833111463, -141736569, 860465308, -2034835326, 1248699471, -1102395691, -1659163067, 1811622446, -1250990304, -1126236059, -1684001296, 1448715087, -453343046, -604888025, -90345144, 218637373, 1564676141, -435242231, 1397054907, 1505577070, -47233644, 1632901215, 2125761513, -1966682743, 252131425, 703030051, 409558496, 630459042, -1945575579, -946768779, 1750666789, -645299369, -1626319674, 722102739, -1510261015, -614711934, 340604145, 28269473, 1596430555, 1215059173, -658615467, -925992143, 1352316846, 1294697902, -646683091, -978343170, -904199618, -1209560642, 1167063204, 1361691685, 666186080, 406416465, -720464321, 445643941, -263493952, 1391745728, -1673218397, 21422721, -2046060899, -1558647298, -108518165, 73248058, -1465621521, -317878039, 562216483, 1172643489, -536816368, 1733023620, 2016500993, -873898140, -1571746965, -2110928714, -455722262, -61573348, -1482141734, -1484573148, 1305527082, -655307166, 936480576, 173796141, 771776312, -128489106, -2143019841, 454657559, -1617744583, 15001600, -1340255199, 1108463832, -1097119643, -69057438, 1328906598, 719799971, -1895673857, -591380894, -688168845, -62920964, -2058048975, 2019201205, 873858863, -1479158008, 1517722819, 817357156, 1258742014, 1931682299, -1767401606, 1765493568, -1965037555, -358770780, -1734507290, -339712484, -1172350909, 1023167140, 728152129, -658819648, -1941731952, 222550359, -1672906963, -1269380182, -763505321, 1446746643, -1851843048, -534460694, 301080295, 1122431008, -2040543643, 1606894560, -1453387165, 1854835118, -1664814648, 1021154308, -1241563804, -1000040011, -89476740, -1918149583, -213516389, 1391877486, -414738452, 911397604, -909305990, -905638857, -1078370663, -1672900771, 35125642, -798337347, 1660995112, 1000497423, 837131172, -946906864, 1811292737, -1665804821, -1773880435, 1243886951, -1819847013, 679402445, -1723986838, 325328494, -36779607, -13536200, 157931217, 1075930975, 1730391645, -1891050022, -1606715691, -1274909054, 1613506001, -2240289, -1776424777, -1042665304, -1389527075, -567654779, 44342671, 2114107653, 613853696, -158753885, -525006413, 1815623820, 576526326, 973562019, 178846374, -130249694, 1060536246, 1035770281, -1675079337, 990674920, -504028585, 262009591, -1048753469, -1445595317, 1178662222, -807927216, 8479457, 2120204097, 1581540460, -376099912, -402038173, 1152600199, -479252667, 1992939866, 25526964, -854878496, 509591604, 1822686522, 1486687687, -2122253657, 1448512040, -1248289332, -1964026399, -800559324, 2120984196, -1117478338, -1108101227, 135396342, -1826641011, 648948519, -1874988840, 1279244594, 2110059564, 1133471386, -1675613382, -1466335071, 1106674971, 595030200, -384681602, 2035013775, 257434059, -996398280, 1514255572, 776326280, 930902067, 1233017410, -1409985368, 772646716, -1876393543, -431312230, -1938943330, 1499552431, -1563015757, -915329756, -1946573296, -155701896, 1783603399, 1424312013, -2083450645, -1274672329, -1915086977, -1625333455, 1869745927, 92259711, -312961353, -1875234485, -622261646, 1713038506, -508401376, -1753758740, -1673097583, 2122970035, -1020832218, 1663014866, 2014513527, 2030545533, 1835894859, -1596327538, 1051395413, 90796117, 277556649, -1010153943, 543848279, -294182871, -1180085231, -856249830, -1706144557, -1782269098, 961317558, -595259506, 981362348, -360210940, -1993699948, 878288407, -19857661, -1964579689, -1063885709, -1295165249, -377421524, 2136038362, -928588814, -913466080, 433463091, 2143696991, -171199993, 1727874811, 1730918680, 1392902488, 754252475, -1025549199, 1126656871, 1320315268, -1880612409, 934841794, 1460669032, -13814011, 743722111, -1553863168, 212263183, -1130448981, -1115643396, -1971808503, 534436386, 1027799249, 710389522, 269218812, 2095661731, -448004313, -1170479158, 133612004, -887352158, 246109321, -1635381746, -1358554706, 1784869049, -1288025062, 178392782, -861796325, 122019124, -285884867, -1328810084, -936328463, 569952553, 2144575182, 1323145787, -1421139519, 1415119993, -2050283166, 771507159, 154457248, 39584495, 920804532, 227270375, -939229983, -1785602413, -1193511752, 1444998387, -184374332, -120151529, 1838619930, -792358026, 861635786, -1391956161, 206104522, -56999793, -888992509, -1066829561, 58959179, 140821904, 1153675230, -1577470076, 1013296789, -67523206, 1654564679, 1614091668, -1074845156, 752689223, -687924790, -1252459097, 1473451603, -652383241, -975537898, -436219353, 653993879, 1391274315, 1973980796, 539818214, 1781525067, 1528008533, -1008118420, 496634580, 2109392796, 318861583, 497307669, 1455884185, 1970353124, -372287384, 1333340280, 1500763620, -933818906, 1610922388, 1696938392, 368370952, -200958229, 1600949625, -72551364, 1724526311, 333486100, 1747527330, 1224027863, -1729596686, -1880416559, 1285514616, 1496966503, -1039352952, 973182266, -1042065011, 652201417, 113452527, 1721650385, -693468786, -1133642255, -141514596, 1256405190, -951285776, 1933516331, -1821400456, -1580892979, 568071163, 4310315, -1956014513, -1632035085, 302881574, -501566716, 1429093284, 924939374, -1252185660, 1135936567, -1797500402, -1297173374, 827168239, 154375567, -1839076703, -1276084794, 1199655703, -1889402034, -2010797097, -1670610675, -618963447, -25583551, -945175905, -718706121, 902081697, 1865705182, -928690623, -1438027120, -1330950661, 1386691566, 954721286, 158085635, 1269305111, -1931954914, -1343670910, -300076717, -1572727063, -1102206053, -448743888, 1251270142, -413703838, -903745204, 791911897, -189812879, -1270405197, -431295907, -48451132, 966048035, 1823610142, 1973531274, -324535942, -591067574, 1167379460, -1924304808, 671610327, -2081446993, -669763220, -340834372, -1324719809, -521991453, -1417186240, 1432905367, -1296828796, 1402748655, -706832746, 223090746, 653980435, -140026673, 1005137455, -665753656, -2088361252, 456056421, -1903930702, -748858125, 2023043584, 1728200344, -1069498639, -73708273, -1731669325, 300736130, -493660432, 202602503, 671924484, -1171516391, -473676145, -2009088126, -1853565332, -2059058387, -1071963802, -1241989323, -1478135994, -589962335, -810640030, -387130930, 35977175, 995637856, -1015457317, 1105122724, 1323610550, -210218922, -1977602965, -1417120693, 528862972, 963823759, 116350613, 80054032, -1242757521, -1942591816, -735198845, 1356592156, -1970476589, 66187984, -82492084, -1089199046, 1303709219, -1097581429, -97722901, -1045232659, -1381244173, -753221569, -213188123, -135656982, 220448626, -550637441, 1030824284, -1829624032, -1112772986, -883279655, 160515892, -895167637, 2031907070, 1597048726, 1529945226, -1587236464, -66825568, 518260913, 1265901168, 1645694841, 527470863, -1711928988, -436345007, -174831780, 1986422137, 970983458, -13997225, 1896209559, -660776576, 181620393, -609384337, 400585711, 55629776, -613353757, 1821046832, -890314138, 2062685475, -79919609, 1931831429, 1238178922, -595126988, 1285838118, -778960043, 1361834427, 929875837, 1726996677, 650338499, 171944776, -2053426502, -1333459934, 1592723620, -918228300, 1727360928, 390051749, -526060236, -1336434834, 1992557849, -1675656330, 1665679969, 622698657, -292256144, 1196277714, -1800440926, 1701144803, -2057342547, 548316049, 1479005829, 946957774, 1606000726, 149087622, -1627788063, 573730786, 1835595797, 384685847, 62775674, 1349497675, -762947600, 1156051070, 861243461, 20295041, 58681843, -593665149, -1896767217, 379062266, -452269047, -1174663765, -2029877536, 306776366, 1540670903, -1812682978, -1078721285, -1966369328, -1968319002, -2018971268, -258539288, -1223074500, 1744960242, -945298053, 2066922660, -700196695, 289571658, -393821498, -1483952759, -267181689, -1943947514, 371114882, -2004272582, 2038798206, 1990789320, -362024928, 438543802, 572308612, 1687122524, -2066304284, -1364138867, 224565867, -699518600, -895407853, -1582450905, 950348380, 722245298, -124680718, -756046875, 1030685645, 838508992, 392759786, 200703780, -1195858797, 234961432, -272675445, -1445397481, 1438832439, 576900165, -1080308957, 289585857, 45833229, -1104163767, -1222424725, 515497425, 528809622, 843142985, -1664295706, -327741408, -422826651, 253247597, -1989072728, -1123672329, -1140628175, -525619722, 1086039551, -7645614, 175779925, -14348527, -1283675434, 111394348, -1696126828, 1787055901, -629012147, 1525890819, 342060266, 2111556958, 1942932742, -636916714, 856092905, 1377926719, -47205052, 1684826911, 1841847379, 1605101137, -1279292310, 1838849963, -60844467, 221222533, 689349361, -333725811, -103920575, -285841318, -49751376, 1792341488, 371056405, -965484637, 714174648, -602596501, 238294368, -1966995277, -105288136, -1166730325, 1850386875, 1075276882, 918101859, 979374989, -972754394, 1314754566, 1363317992, -224488626, -1295849159, 151873089, 1389655834, 1730626190, -1112144378, 1423112717, -405459415, -109474517, -125613902, -698673085, 1025186359, -1502383146, -662030442, 1943673279, -448908722, -714555264, 930937145, -2027532311, -244652330, 1679567246, -1185866105, -2046508718, -306812344, -620180539, 1782257401, -592088741, 970429063, -256521134, 613572032, 1085189784, 2113738222, -2024716637, -591592115, -518547467, -1928793220, -1887289495, -1818402637, -1535216702, 1418948472, 914154127, 1639561918, 2074068319, 1812390892, 1820059949, -1075791374, 852055814, -309632154, 1397700114, 1000374601, 705253392, 1064605433, 1811280493, 10568469, 2036000270, 6530825, -1956932544, -1534906890, 1127290388, -780121419, 1249246494, 91825693, 1148359310, -564507295, 305404040, -516747537, 1113773849, -199060391, -1983141909, 1267838150, -1207570559, 1305074985, 1414478475, 1866432143, -870500656, -2094513679, 2125197881, 1794206120, -1907759426, -1416685931, 774394895, 482432294, -898756905, 1025000477, 963017191, -1797683793, -966416540, 559953020, 507815879, 1878149131, 886444710, 549543848, 1361981948, 1423666962, -1505356700, -420087934, -2036374358, 377107068, -627300473, -1721541086, 2112542817, 579187706, 68196616, -851620341, 1046256308, -1666589182, -1513983137, 245319909, -1943986037, 548866801, 1458067152, -1804054358, -1782298056, -651773002, -1027258065, -1296233831, 1231800839, 967859844, 1653823060, -1917685276, -811205090, -158024205, 486303392, -933964749, -309372036, -1524630349, -77217293, 1779935952, 347234629, -2113617222, 1358838611, 1276266085, 942530216, -1667454784, 1169794257, -990151475, -1186972153, 1833352373, 335910365, -253339669, -331270622, -847421411, -1029228387, -1737535610, 1423800127, -2015964447, -1629139123, 851409676, 438585647, -872415589, -294250279, 2060289643, 2043518716, -1768466668, 967133704, -1872056492, 1185379530, 109751888, 1723710999, 1673502599, -483027750, 2088761069, -866607732, -1521834611, -1315986601, 1299140564, -1458874860, 1979120066, -1793549511, -1851814160, -1690716109, 1596060617, 1794041982, 1461640967, -1788383225, -592202907, -2076212250, 332719276, -119874755, 1055563783, 1990233897, 1153093516, -800466206, 264834172, -676484542, 1307359414, 701830724, -1647827077, 682918162, 805451307, -853452896, -576045331, 398664903, -1367613240, 310532901, -533010141, -474809705, 494762707, -1434668434, -1338139602, 236253842, 1010896684, 1279021372, 1258579821, -423020520, -1007023061, -2032802753, -451043420, -250479949, 1423514512, 477403996, 1569641736, 478821982, -932869912, 862535513, -1302276002, -1065737881, -1813728535, 1148962563, 1926018785, 1742239862, 836458215, 1080828969, 602157540, -735686849, -1184821658, -1319690674, -324982318, -2053984973, 588849840, -1889348957, 1044598489, -1625538650, -1589657532, -2092603011, 477546133, -1025647213, 924359544, -1703970005, 165995475, -427293760, 1651077594, 1830273557, -117526310, 606637345, 220771953, 2027387153, -1410318075, 146733698, -273359968, -357235640, -2104481069, -1589375440, 46067923, 920318250, -1670012325, -642397203, 1731587848, 1228933097, -1016113309, 1825858767, -613155186, 89331462, 1480688288, -1188564200, 1010346120, -109295082, -429944620, -845453652, 1906190228, 1900977719, 1326530842, -1325423159, 1141757584, 1718348541, 259845272, 1191122837, -1207832721, 72571832, 1772528198, -1578144640, 1306350280, -1001420780, -609263310, 1802079055, 212577548, 2061569331, 1765448273, 1291518299, 255430886, 1064606010, 562581570, -507623216, 169135206, 458271189, 1987658009, 997645553, -153494719, -270935466, -450492799, -848974791, -820583824, 1117626691, 873550787, -728450944, -619050003, 612035643, 660237102, -265358638, -1170032003, -461933401, -683502227, -1038812115, -1344942469, -521856068, -1843697103, -971940136, 920520653, 797433677, -632727024, 70433708, -858105815, 1368302370, 1864037254, -1590123474, 1551182325, -1147202758, 780689044, 1082796105, 1972975685, -1830291130, 1500939787, 1513100835, -1587379038, -1267861704, -1320921500, -215784206, 810107029, 925023395, 899083178, 1929026864, 1628753993, -582267003, 1231278116, 818868603, 190486508, -1664500217, -800804380, -1599552936, 330400559, -1942936033, 1470408955, 1079962212, 124520881, 1396347356, 1549269740, 69097312, -287559449, -1431677301, 236850900, 423817870, -2061419726, -2065760538, 1157329561, 1210655880, 155710269, 143917086, 1939215526, -852558852, -1583714947, 1869996207, 109329667, -1672622977, -798743997, -172322118, 1178429576, -282052624, -1533018372, 596367541, -416833355, 1305291768, 303193648, -1850996926, -1520396192, 498351016, 1889610996, -837323487, -119017729, 387477436, 1274776133, 1519741547, 464224936, -1013353462, 498521219, 867135459, -898036699, 971969109, -568582175, 1233383809, 2002087389, -194602139, -917773200, -1219520476, -1590499940, 408589750, -416956604, 682849790, 109350396, -971764070, -192873241, 1272519462, -1665273817, -546088340, -1164963800, 604189621, 95128899, -1139327330, 743664953, -998704894, 31621643, 1370237980, -1168891985, -788789761, -1183699297, 1987077737, 1511637306, -490697762, 896946048, -1723126479, -5316746, 1059668960, -2097430894, 1014774651, 1846438272, 1149174442, -806280743, -375360853, 2121226647, -630885917, 1487582733, -47603040, 111033181, -1009891269, 1415237583, 1510321603, 669029457, -2087988175, 1393720911, -1386940331, 182326458, 173515406, -2103443513, 1306030774, 912319747, -1534630356, -1300022039, -1571938011, 387589963, 49677110, 551971896, 1114775990, -313354302, -243098107, 745573415, -520941389, -658737906, -1222492641, -616234386, 154231436, 236886623, -1578798440, -855677045, 1952367265, 1077499519, 726422893, -2002087399, -664880208, 1006104911, 1638195132, -1097801786, 532758578, 816480218, -835614580, 1873217856, 989432797, -530505042, 1995375552, -1256387035, 1119383512, -1146007463, 1866784883, -15847265, -1261009890, 2117807656, -927664865, -498479209, 921594173, -1206005379, -2110796741, -848766546, -1042830917, 1903756807, -891570044, 1481154667, 2126621285, -1309655605, 1693911218, -442646030, 1668063945, -1638773286, -1469631080, -804208209, -1696179506, -1548935199, -2132887034, 1232451637, 1101929545, -1759326524, -226439298, -1407811430, -1359964941, -209196124, 2120934862, 2080788933, 1351154694, -1221547733, -2039548385, 1172532881, 1395043565, -362241123, 1033414937, 1657549448, -1729196377, 1395655980, 1311114355, 650776978, -891715423, -2081444457, 53792695, -551348957, -1866760590, 642822078, -1596749464, -1097844474, -407795320, 1040355871, -555056756, -669359273, 912008862, 1780619555, 345523470, 770274100, 682275151, 1161287440, 964844767, -1527963956, 1794392937, -399088760, 189041046, -1586046264, -591397960, 138738119, -1309082482, 102939696, 1312020715, -709626161, -794017471, 394115834, -216333919, 1709975218, 1581513455, 810791054, -954453223, 975247650, 706283617, 912171172, 598366744, -1456514619, 1201800253, 1769793294, 949243259, 2064697492, 715446061, -651426085, -365938745, -1193879662, 277810842, -1745680603, -363823316, 1245527911, -1209981578, -696941189, -822085021, -816354090, -575236209, -1504839675, -1771085395, 1082908445, -1516964140, 1451891023, 2065710723, -22315724, -672649778, 836713996, -404555641, 503761713, 187426156, 211716972, 1929015039, 1001653390, -1727129343, 1293774754, -638219736, -1245384044, -1846711643, -1566090116, 1292317829, 230255241, 160747631, -705970221, 2142255687, -113728531, -822696914, -513158177, -2102122386, 1958001054, -1173677788, -43710773, 456203527, -1492338261, 1543212301, 1288004963, 978031117, 873004546, -1518787381, -90713934, -773787020, -131521183, -938542916, 1867612442, 75321715, 1064741461, 939027210, 1962886697, -514621041, -1178234967, 495813249, -1112118022, -2030232669, -1787163624, 1263300749, -211688086, 2006064086, 2132087260, -1185481265, -409788038, -2077093800, 672251405, 1781035001, 951319266, 584841196, -1881508349, -372234964, 878738328, 770879224, -1078374982, -1056609571, -646101803, -69999300, -1780822046, -26124122, 899594499, 260340004, 988803989, 311351723, -1273262305, -238764747, 728254232, 256671325, 2037439031, 433023863, -1087001763, -614781959, -1777606929, -1379726567, 1430234871, -1881219614, 1169616253, -1085645049, 1526438499, 1439756583, -1304660572, -2009233763, 811465810, 981849300, -771646968, 2097840791, -1754537696, 1185733077, 1407318072, 1970066695, 1696595081, 1826300064, 362650301, -619144353, 1539151675, 52310669, 1065306275, 148397688, 1867861107, 284084175, 2254687, -600952249, -2037284975, -575534866, 353905697, -1266524964, 852289923, -1407639853, 1987817454, 765017906, -1657147858, 683534886, 1340758728, 1531347408, 1790775148, -1844308857, 991491553, 963046894, -94017244, -662683277, 973382850, -1033475393, -2026537744, -1400550581, 1946319193, -9164629, 1179815185, -800402080, 1795854311, -393672856, 941611988, -1243086528, -831513325, 220240514, -1401780674, -1703694026, 76936626, 1423245110, -1829962396, -201322726, -479248129, -1013211826, -2021147865, 1160554792, 607622881, 1927263377, -1289147150, -725393518, -13395845, -934084077, -1233924686, -2070921333, -842347982, -1347110792, 1034165883, 147761220, -83546896, -1482854560, -1745318278, 950684752, -647805945, -108622162, 78313826, 1134045620, 369464052, -1888984660, 1910999759, -1077368518, -1133568287, 108654946, 2115450151, -1258864750, 1066263119, 1912059560, 772744004, 433980711, -445070110, -2132964740, 538984779, -116837667, -1109795994, 1045099614, 135764187, 1949862893, -1942148663, -1351029571, 651901631, -1104153188, -1204990902, 721762843, -1271803121, -1216235712, 394174567, 917576016, 1505607077, 1434924475, 1268069057, 1553425081, 974718167, -2039070470, 682211535, -709537369, -1955301279, 692320306, -1198332832, -819763740, -2050377081, -1378818875, -1966422365, -9065408, -28508426, 1487102643, -750434891, -1552388410, 1325941688, 63870912, 1545579134, -950345203, -551993133, -704151878, 1070261087, -428101336, -1772260125, 1624188787, 1789737173, -1734473521, -4699701, -1865043983, 167608287, -1739518079, -2056479582, 1473691812, 211493074, -872068364, 1872304261, 1873691201, -733001077, -2131266777, -393877239, -588380807, 565834334, 1092745677, -1972718065, -802815833, -1678692090, 1038330933, -1262444015, 1922587910, -724073690, -1556664687, 208324247, -1297957034, -1504608927, -116052550, 875454981, -1220977521, 1116219223, 1126965127, 1723935927, -1118651055, 1391725577, 2060960759, -1137445225, -1414497512, -2082170534, -157834506, 67669135, 2080091432, 1523465268, -1729749589, 92885787, -659869239, 1503602737, 1101945968, -1160789697, 1054824021, -1938261003, -793111485, -1032031108, -1025753179, -1345157787, 203465893, 1095787120, 974697936, 1152721587, 1756188837, 1360556827, 482711629, -606057723, -1846828273, -879149854, -255822704, -1770982555, 87137137, 1231603201, 424839867, -2098676986, -122562550, 548920293, 87416252, -73065055, 1856475265, 397462676, -2033904170, 2094178620, -957823030, -1543849427, 1224183764, 1032457363, -727598267, 1475133176, 840777269, -409122586, -255815457, -1817573818, 350156365, -27622023, -997062587, -1947244539, -1592938116, -1604409220, 87158185, -1760765311, 519430392, 960112310, -2010918513, 1396611401, -820507603, 1588134671, -887624714, 1588515902, 1546304041, 1890305255, -196207179, 221415564, 1089259047, 1940953680, 1760578566, -1288076226, -1164757426, -32541318, -880053722, -47454372, -1832865603, 8120497, 1110320176, -935757602, 1687154851, 1583795015, 1897961467, 995592053, 1275529554, -815687270, -1303601539, 1650798067, 1621061475, -2096317025, -273312506, -789709874, 632176667, -73793343, 386761252, 1265880108, -1525466457, 988449783, -1705087332, 433771189, -1215366063, -1639480608, -1467338893, 1098167170, -188763522, -8309599, 373295877, 642277358, 373679772, -1757066341, 488952091, 825514351, 1713940720, 69282229, 908953300, -57040754, 469933713, 1398044621, 707276727, -1538472441, 1633071870, -982789784, 1823150380, -1846825567, -905033573, -143380510, -1582713568, -1694178864, 1480153183, -30829682, -2125113157, -842434229, -463113661, -1385249436, -1098061449, 1346781816, -1133777690, -1317433198, -1482012359, 810355337, -1209464002, 1280321484, -2029228943, -637136729, -549230548, -1950048519, -844660796, 1308506198, -13189831, 1955762057, -1326800792, 1306577533, -330735400, -1436076523, -474645208, 2063180653, 1099203075, -473724060, -1347656692, 1114205327, 690836119, -452654329, 244304295, 1543949114, -261759005, 1856164214, 1869500427, 1609663977, 423306465, 1807747581, -2106358531, -122540210, 1558308398, 948590629, 590233588, -871389488, -1750160176, -40829227, -457440411, 1879972309, 939095865, 1154433709, 982927854, -1780380347, 115300240, -823449110, 1595322650, -827966684, 875256683, 1348769775, -969509278, -1075619969, -321003736, 1230130829, 332239615, -1827185326, -1663063351, -1951681084, 1328971632, -1969857214, -969993755, -58482961, 995087965, -150447284, 901645886, 1934883824, -1037020621, 1244902060, 1886044403, -230262965, 967331886, 2095910559, 266601573, -1788516678, 1492683921, 1432596167, 1547350864, -950397177, 1274406958, 476437906, -293055668, 878997057, 1520563561, 1871555087, -1315850622, -878403313, 12042669, -190333605, 1650929930, -160898310, 1022267862, -1714358579, 1573060532, -1758904790, -268431258, -973152438, -966942313, -1653116881, 1732444596, 1026438914, 100472463, 341862741, -689176852, 406805306, 639357512, 1806034416, 423328734, 1598305396, -1254624252, -1691918577, 1593966829, 1858667697, -983543407, -606386237, -975459219, 588516338, 1564156787, 1177418103, 378390255, -1797865466, -1762558039, -254728086, 1304969138, 1567086707, 435067544, -216320846, -1888398057, -177192350, -1809731105, 2050960986, -1630672594, -1839484657, -1223192098, 1946736607, -2076871127, -947114344, 529294403, -1729730288, -1520455681, -259644074, 807797088, 66575601, -1811562604, -964134818, -953957520, 2076780819, 2147280281, 43618739, 1255573660, 178385409, -2034197996, -2026245735, 835537913, 1571447107, 1347518535, -923503683, -2121307366, 1400399630, -901630020, 844924007, -1763202635, 754457393, 46698909, 962227032, -2050640901, -448365746, 300316407, 1779193851, -225098482, -987184368, 1263905846, -1731598285, -445351973, -1674917294, -1160853806, -605689292, -51624350, -190113215, -1744066124, 973510957, 413620819, -1013763494, -2091849857, 641342371, -175744726, 1281986112, 1336620593, 548912173, -561429617, -1152159885, 1503222562, 1452367321, -909477239, -1063491003, 794238403, -724268425, 1881790318, 123468416, 1713201149, 9356825, -934806501, -1606308570, -34465481, -240281969, 1633205985, 1420095503, -57762078, 2010773213, 166179773, -370128611, -1800748407, -977493653, 930885149, 1558761549, 38393830, 362807883, 1025620476, -45358918, 1266444718, -362993712, 1028697253, -189062681, 1486637302, -2093739972, -621808222, 212301809, -1637868998, 322982964, 1358334692, 1657278647, -1375933094, -380362399, -462464125, 1434212126, -1856259911, 2147330576, -2047087645, -713352805, -620882208, -1451460789, 1240705802, 436926957, 707374320, 256993797, -799611747, 1523126562, 1909855565, 321558373, -212350059, 1363409669, 2027695871, -350965639, 363184942, 838353697, 1005752614, -429438826, -1396913937, 746470450, -1637436719, 1320702934, 2134498875, 1883549548, 240631517, 592609532, 1034330655, -1236688887, -1956663491, -1024931935, 384928787, 1198747424, -870085719, 1052892911, 2055606359, -913856532, 1398471563, -705512236, 1641343947, 1655719551, -234527463, 2033393384, -1749820766, 393552738, 864953275, 262062474, -804465514, 539421731, -1169333324, -179987202, -411917454, 155156793, 929529863, 1194746509, 1637536436, 851752364, 1613186661, 1357625198, -741019961, -1639837817, 1365376840, -2128029314, 2103016972, 1880374928, 1595032109, -1927300047, -671352352, 728500509, 1904311082, -228142672, -1948668080, 1018004229, -2080638886, -305958831, 619320933, 1017546876, -969491882, 1405706052, -1183813780, 453513321, 893981703, 1002567562, 1601733058, -189587497, -826344516, 306435018, -20902789, 1106379676, 45111246, 1925379292, 188495304, -1386344466, -1231230573, -1613910428, -44277011, -1281515372, 1850798720, -2102218948, 32234249, -106907053, -1668389808, 505935680, 1135717124, -1006454727, 1639788431, 2050479451, 422058293, 853198085, -1978339401, -1559400242, 1533201565, 1655904791, -404415725, 1645913619, 55864294, 1788742572, -566101913, -1404215149, -262484080, 345878556, 1639673540, 759252783, -673623613, -1921760967, 1323517916, 462239182, -232209348, -2086998304, 651934252, 1324665781, -1747533778, -1001274287, -1943733128, 841175870, 1620015505, -312403273, 340849865, 1375507657, -1953787729, -1330121836, 1735795834, -2102445164, 589028513, -2047369213, -1273734675, 1787338924, -935623240, -1111488596, 659528536, 225428217, 540337376, -105998837, 1042393510, -1917656879, 463892662, 1538295541, -308485388, 2080307752, 1061947171, 1163379624, 1194083, -113374462, -1330147043, 1090522176, -1567709733, -2092423377, -1144857856, 558189930, -976483918, 46923003, -81114297, 283694929, 1881028758, 1665838038, -209717553, -1275426898, 752448664, -2137170267, 424502134, 164677751, -1404048981, -2132669916, 1280371466, -1718012362, 85641241, 157725408, -757255869, -71643720, -1835237313, -572235038, 227987488, -1579738360, 665615374, 1737836273, 523571421, -830393279, 229405465, 1993767440, -946457979, -443276901, 1577812515, -416496637, -771134790, -2127699236, -35571943, -801822726, -1670943300, -2134337648, 1952919897, 202901704, 1124008764, -1468699612, 1586556803, 1399037427, -684670070, 736290090, 501246536, 529227144, 1282323829, -1363326555, 23853788, 1176511065, -1806194252, -1113956873, 1859034201, -1756647737, -291130420, -891021337, -346547034, -1550782011, 291989271, 244658645, -1452833234, 294409465, 430049971, 269884701, -1188989415, -2092746440, -923597532, 476186754, 796965944, -1785436225, 637116774, 362493511, -1807701712, -1627343172, -814523217, 478219390, 25170178, 2052423920, 902249143, 708439288, 667844509, 1339930496, 685723360, 1778308756, 889419963, 907379325, -1343165105, 430592925, 1609424285, 1832887556, -313924462, 1853645296, -2008158936, 1150714057, -894538137, -720811347, -1012781151, 76034619, -2135835862, 1078872372, -2143167404, 554254810, -1363708659, 494662762, 411276748, -1491199486, -326193452, 963556272, 1888865479, -421747958, 1508203684, -61679675, -1529039985, 1287678400, 1026717258, 2071332901, -750575187, 1153065644, 1855977126, 954757002, -1426103546, -212514125, -109392830, -1014885421, -1610102929, -125105233, 1264282624, 52001792, 700755051, 1661542968, -1120917207, 1831790149, -374203459, -891740120, -299766594, -1599122222, 822056284, 1821912925, 88704845, -744495863, -80559237, 1184155151, 211660309, -1555570423, -624365472, 1523561558, 510621853, -125099236, 298461206, 834807091, -1094394303, -1240579959, 2144291031, -610168712, 503489906, -871071142, 1944831103, -237434077, 1253407488, -2085771543, 1510719716, -128883981, -753628720, 1535785082, 105642385, 912936379, 361568060, -1251200991, -596892858, 1862234310, -596846940, -744660197, -1943202375, 450207543, -1002558767, 1265953843, -548896102, -2046008632, -383722407, 1787666316, -1678716241, -6443412, 278762796, -1845988427, 1864650783, -1887510456, 1770468804, 1709845752, 1463303239, 1959288167, 1670670828, -1876180522, 188202814, -456938523, -1569568373, 1832103518, 702344528, -893131227, 1218270066, 1755093355, 1453234941, -589473242, 1234573087, -545921276, -49386519, 1612901418, 1265994294, 947735401, 818760169, 708170101, 1692396594, 971867388, 1821237276, -1558086829, -1864568084, 2107833463, -1262135690, -1444078115, -881391415, -1924025329, 519936606, 1515785208, -1943576864, 2072051899, -699539246, -1967612762, -1583881383, -941273559, 243616825, -1567257298, 553784242, 1248046357, -1502211005, -1705277867, -191124886, -250441443, -1498628457, 1903791983, 1952086633, 292094105, 1791150911, -1581925543, 138602090, -1465405818, 2050560030, 2043999943, -1678309355, -605413883, 1744053301, -1439656197, -825160169, 953560255, -1988830231, 1499005348, -1246008468, -1211341923, -820430895, 1304316197, 298108918, 736703581, -460212574, 1371800144, -1783810001, 1697603676, 1772964387, 744351528, 1495028920, 1754454778, 144688812, -1133592680, -2026492352, 988358136, -921850986, -1722908367, 1820547939, 73061059, 698907759, 560972673, 1796004256, -903698321, 400666340, -1203958724, -1181153604, 1353871094, -1655691060, 1220078804, -1613099666, -2034651685, -1592992498, 1573839224, 586566598, 1281392326, 891807799, 1348396918, 845405299, -1148770962, 152267593, 1204555417, 1171626968, 1430859436, 54885305, -1039087771, -135963596, 878542717, -525447367, 1028850701, -1990638005, -20756250, -244684620, -38468914, 1790533603, -540884077, 120554885, -1236470900, 708837616, -1446818403, -117810156, -1253483742, -528487086, -1375066216, 131631165, -552134158, -828794820, 555778314, -1827061305, 1858674443, -120526173, 710820446, -552882611, 506906336, -1904726513, 1409002118, -1182109753, -1939216392, 2057270449, -749486094, -952280026, -620097019, -1197139819, 568270766, 1245592764, 604773656, -1802034803, -361064215, 1500405474, 295458454, 648742119, -1025068411, -127907048, -306753542, 739455210, 1087838313, -617430097, 912221180, 311906609, 1261407547, 1532491089, -899967696, -204946408, 576359297, -1509745960, -768567820, -1859388679, -98379909, 445895686, -305447864, -1430035625, 890019291, -305536285, 308684301, -1045975736, 1882346411, 536740250, -212193249, 1468631409, -1923341501, -526771233, -552932457, -1021344410, 244194281, -791786789, -907016975, 386061402, -1778001782, 98097637, 1860566984, 2050320246, -1661254823, -1902706603, -32358252, -120316691, -1746454383, 808646945, 2033360818, 1623327300, 2074618006, 1098217376, 346484557, -2012406860, -1816425775, 734421048, -1562444357, -1446215324, 1364834294, 1682490220, -1273395371, 145217957, 443492006, 1904863292, -915209357, 1579234974, -1792397866, -893627779, -1647755565, 1142413093, -1828270359, 441413932, -704564636, 790516438, -144920583, 104637320, 715572057, -2037215533, 171153654, 645129819, 1475548509, 2017028657, -516684418, -1008379462, 459351336, 1522922812, -1325519807, -2049703476, 1011475288, 2072104052, 471106987, -511017910, -826153342, -1175558221, -620457105, 101635327, -1546614145, -578992237, 705005296, -1991206344, -695099874, -1934532523, -154887403, 222902218, 1874936908, 146949805, -1701434852, 1624403258, -1383964723, 993790840, 1262332562, -1749202194, -2014781703, -1734276729, -279182394, -315596772, -1033335821, -330963057, 1273698871, 731479783, 1245927982, -918019904, -681357218, 1048091793, -666945164, 1185423216, -169162930, -1659220943, -789547046, -180050926, 899373421, 482838682, -280203187, -258820360, 229691802, -798880574, 1559197678, 1511490284, 1140878069, -520400243, 1208915382, -446698591, -1040229512, -401304793, 617672463, -52406776, -1981893481, -1569335071, -1257351482, -716736079, -2064073088, 1030111109, 713191416, 496112296, -999506669, -537608596, -1488566498, -512419693, -1143341785, 1665598659, 1486124344, 553728637, -1885253995, -357239576, -2083770758, -1520870400, -987671073, -1377967636, -504361702, -200955605, 1458203116, 656230254, 2097495799, -1303721794, -377090101, -446449054, -1722316109, 794459180, -1243416605, -1793836507, -84527531, -1427546030, 1509115369, -1835970469, -2112857547, 1094361396, -262643833, 1356474029, -468962899, -473441419, 614776374, 878808902, -892443583, -225045906, -1619727603, 1487253119, 557093027, -1044065109, -748982284, -1490536711, 1746915867, 536276813, -748450480, -1143718045, 1239304377, 1535866815, -299185191, -719414237, 1842915206, -1148152699, -935695296, -269991304, 39915377, -922880754, 478881597, -2146911267, 814061985, 783386526, 1369862008, 640320621, 129564483, -1652939495, 1652654813, 1104481256, 1409591755, -1031216958, -1687094299, 698043404, -1841039496, 1424609768, 1770667993, -300250684, 688850063, 485433743, -981648872, 1899649399, -608057536, -724547713, -494344102, -1148971849, 1508059791, -1297522348, 1166823041, -460295838, 1836872755, 1376016084, 1258670777, 142790970, -1312112043, -197064584, 242587591, 227116373, 1503246162, 363332689, 35613273, -884797403, -1174251924, -861829545, 985337820, 1492090422, -1265232163, -2055421110, -353487428, 732742082, -1188204774, -1374624323, -971346887, 427157993, -569918116, -933379695, 2000490131, 1963418917, 2026069195, 1483556166, 191396977, -1272407816, -118922147, -1652498324, 923185899, -1512708883, 175521973, -1612765282, -501185386, 49565599, -1286596695, -1566736628, -85024918, -231325672, 1153367713, -709194230, -1238408518, 1701599233, -1377642274, -1029815448, 1056178919, -888589053, 1356066263, -809233991, 2115993214, 1406763364, 1064698304, 1400068217, -1979481379, -830865979, 1781133999, -1467187856, 1140262453, -654553729, -1767062623, -1203426903, -1142547458, 1269246091, -1196600022, -1523347499, 1243053496, 1614576828, -166712214, -1181945928, 1965911374, 1814063599, -1541498687, 1578669752, 1211322356, 178811414, 767380825, -1929449406, 1739194950, -986379661, 1004512920, 432994779, 663148173, -592867644, 700409920, -1582792857, -724844395, 1401331490, -646465703, -2077538161, 1078484763, 2058593916, -590706693, -2092377298, -1563414844, 1751049141, -1885164088, 644974101, -123029718, -258902325, 261910650, -1420223020, -1715696850, -612741844, -1310415822, 228058619, -431060743, 894329633, 1716619429, 2003659786, 1771690152, -1464890081, 743463413, -776469416, -544631043, 2073087244, -1823174185, 798617178, -1626395092, -1613411465, 86664178, -1779819538, -1661208232, 364102298, 1751294350, -1078910619, 318126899, 1433186768, -657073484, 309414394, 549377320, 2069766907, -1298812013, -752347024, 978402433, 337000405, 119836235, -1966614085, -1976955644, 2028406007, 496646787, 653055704, -552779175, -1055984998, -2110990343, 129137820, -1643039174, -1156606553, 596714043, 411235272, -890002364, -1361427339, 749557536, -639280190, -233733160, -246081440, -1072783618, -1540412639, -323464543, -1309119302, -963811065, -45478688, -107930478, -2080715476, 1048003107, -1050403033, 1037081653, 1220904271, -1093567398, -290314192, -96215321, 32928645, 1647400496, 232972720, -1973192009, 675331267, 568931833, -371640596, -1606311308, 1761628690, 1686095318, 1860282501, 322936552, 1230011734, -1629082904, 526993935, -392597688, 552642423, -665677425, 1377990162, 1818772679, -1098269112, 635611049, 1753445647, -1118561713, -1423480094, 1686951425, -87646555, -658983433, -760627172, -1337341337, 587907301, -1260601684, -31628901, 136283732, 1588772636, -211460651, -970491482, -615638690, -433227919, -585761120, -1451668536, 793592353, -1190660740, -1470766961, -1074977351, 123859819, -1535823330, -1340895759, -1035288307, -1991761858, -930062703, 326689892, 1901872193, 451281088, -308621038, -122223354, -410440715, -1519630752, -1129986335, -1973217661, -2050144062, -519116555, 2016223140, 947185710, -704497563, -1296909498, -812896222, 1274326038, -1430936795, 1571851927, 1074097484, -1043853408, 683513252, -1399799705, 672179564, -584755742, -733158416, -1310368909, -2063807807, -69376436, 1909658332, -118969009, 437713170, -1278236174, -1205564907, -658596469, 421388331, -1357945221, 1009693868, -1852790921, -1955140020, -1572669765, 1675254395, 1990848926, -443942436, 733289397, -390664929, 1403577763, -219651462, -1797351524, 1990301954, -1121486996, 1017375614, 513560583, -1826604956, 2126626150, 2109275790, 2011349430, -2093823748, 1730007338, 371631459, -273508058, -199387840, 1836423435, -1997003787, 699883744, -1213444977, -675953604, 19739343, -906184643, 1908322580, 516176650, 1497480012, -1255603278, -2113267270, 1068227384, -455675351, 87902379, -1603814786, 1689145848, 1846101421, 343481024, -2098324295, 49859032, 1682177875, -2077949911, -1839581908, 1189893589, -1984001166, -1631491113, -612335608, -1962116230, -1539094900, 1014241877, 1694773240, -169865309, 1715617456, 912228614, -1193034485, -558916807, 2074550156, -2126925466, -890648584, -2075768854, 55211, 453855493, -1303768889, 1107941702, -1494919575, 583597644, -1957634226, 291039605, -561193747, 1240346906, -1305563977, -12630280, 1062011705, 1270480545, -406849233, -1378647294, -2064321517, -279340302, -571444632, -855466900, 1784532226, -510195243, -89717461, -1186422486, 1755682868, -2017783986, 491077225, 317435922, 1069367767, 656669954, -1463527212, -1420470116, -1445513296, 1600000720, -863020346, 1665989690, 461053404, 1230417559, -347022785, -1669659849, -732682087, -1461553960, -1020733966, -1309412196, -1245360689, -1434737308, 1369334406, -1650241263, -75297296, -377349620, -1568700002, -340127444, -1405953837, -1389653270, 209013011, -1384447203, 590426648, 1616303033, 942351392, -1346474151, -230268128, 1613965872, 770997413, -517456663, 973692742, 1621337207, 1913021473, 1124439111, 243562576, -1614800033, -1290093998, 1091771275, 1341867870, -1426342179, -2087307984, 1212751037, 1986712540, 1793176467, 1542431082, 790412854, -1917584909, 1164055628, -595190961, 270453687, -984078755, 1464393940, -563222597, 1457251368, -1378170777, 1664667983, -1266911965, 1812046719, 1319193102, 740691057, -1751872626, 454272970, 1332821702, 2075961119, 1414785716, -2132714754, -913841281, 1902508544, 823083352, 941523546, 1283602009, -2141965248, -2070934442, 379486790, 1705269661, -62634462, -27803854, 416741161, -1821823982, -1273273787, 946146332, 449273299, 2079445698, -166664762, -454877931, 1008869889, -1093703509, 1953030561, 1146297249, 1324217890, -1342197327, 1668577936, 1295953240, 1149373949, -331729069, -370163333, 947223637, 26066620, -1074114024, 120319596, 1403805026, 1616591900, 1877405484, -17242848, -73986487, 100804759, 1295438440, -102407838, -752710780, 795178766, -1693228665, -399211773, 1201078494, 478150213, 54708311, -917307204, 634358741, -508144994, -1499756434, -1278083929, 1563891296, -1380610338, 1859555152, -772812210, 1895197965, -1920445047, 801339834, 2049387523, 1833168260, -2120189996, 224761837, 367595350, 1255889241, 1440474433, -1291027958, 1808471636, 636386028, 610916976, -293384390, -333095740, -36785035, -339509176, 1962388052, -2034225414, -375039089, -1463622271, -1448285891, 806653927, -908461171, -507713301, 1570430827, 1583658052, -1860001696, -392636431, -1599713904, -642972267, -1471991534, -780470789, 862407825, -160564215, 431655790, 190103442, 1959075188, 294720188, -1436882519, -797235448, -1931407285, -358354972, -1899257119, 1647677475, -1203683063, 670031539, 807665855, 1586489606, 2097594752, -405881705, 1293699427, 1600730840, -482544757, 1177214678, -2120450105, 370490735, 1156566973, 1471633223, -2013735337, -1427610745, -1061487111, 78251839, 650930938, -775944027, -1462669114, 2071872120, -1961039699, -1184633597, 677181146, -2146695070, -1374752612, 971991100, -1447143875, -1881514208, 616430897, -1469078528, 1024944525, 1367708668, -713338878, -927426453, -690084381, -1842703303, 1353299617, 40144853, -443714296, -1781756979, 1047582035, 1099266126, 877704240, 1576529808, -820720867, 1473523872, -222824618, -888024376, 861944893, 213174152, 907280844, -538908801, -1233209147, 33536512, -1881524137, 1746301941, -1293313953, 1453698454, -1048208405, -130701754, 161731031, 33972590, 2030505119, 950472164, 1153381097, 1195536021, 671999955, 1119267486, -1786857712, 1364678352, -569415895, -97008108, -805114700, -114248542, -1520368131, 975206234, -1371305370, 711878072, 1435959640, -1279239022, -330036780, 972620914, 777654511, 856833459, -650698309, -76286099, 2031641913, -1484955890, -575867011, -1053451091, 476743557, 459989266, 524037057, 880331150, -1377892505, 2122856368, 911683306, 1470616317, 2131227136, 763690317, 1760518697, -267889009, 915543724, 1396666495, 845438494, -559806241, 1169847935, 1171202169, 1286660917, -1421515716, 1926864394, 349959686, -1655785210, 1044511252, -2113883664, -242693203, -301656971, 566583621, 1139551188, -272960427, -413857978, 981689970, -649448211, -1343742288, -1957387918, -1884536266, -313521374, 1335967633, -975113395, -1028376765, -1395005904, 222484445, -1445577530, 1959242689, 1209533859, 63770588, 1078508684, 465554259, 1380123778, -1902356861, 4036300, 1804177885, 267336512, -480459315, -1796678543, -2035732891, 803390505, 2059081392, -172587829, -1483464013, 297232273, -469138360, 532619256, -542681173, 93860463, 1437457245, 898265362, 2082179934, 566955934, -2008170329, -1681633737, -1047100017, -441554521, 979693853, -1930337425, -346763511, -614605018, -1017153412, -459439328, 1073652046, 956510546, -1509774144, 1599918775, -343819596, -887365762, 908342039, -1978820318, 1741951680, -1366037336, 664263843, -260163510, 1471868442, -1841818598, -945116014, 1940550826, -671311356, 1741839219, 1452388831, 1210719684, 64318377, 1615035844, -58648162, 1289359186, 29795924, -1486888220, -106650969, -1335710751, 1721651394, -1379087138, 1746727072, 2133992913, 1589286337, 25786392, 216038735, -1403174920, -1146084609, 1119509664, -1367171895, -965740236, 827726000, -1653749617, -2097731782, 1665015725, 46368356, 1154163122, -1722219064, -886719225, 26544791, -840667418, 353317639, -72726110, 842441904, -1960966536, -1003521342, 656416786, -1514529131, -599182667, 1539186653, -2004157980, -2022356779, 103649619, -2086980277, 1833579179, -1940006118, -317572726, -861286450, -868142415, -2040501654, -1978960467, 144558498, 1490601338, -2137254614, 1326643188, 270230231, -880635115, 458528169, 1077323852, 501910841, -1311599538, 2070118111, -1861018026, -1245465461, -734409347, 1114976491, -819652777, 216879402, 1978239027, 779483343, 1052848276, 3540773, -2132847204, 116082672, 899583990, 207043046, -1360973102, -1137031529, 1709603998, -1005447254, -871922008, 951493839, -1747573811, -1976987658, -1653129709, 1779901383, 404230752, 88307239, 2102582561, 1540199864, 485885310, 982824099, -1860796727, 1305595164, 430499081, -1542376525, 1598655841, -2062461536, 907970303, -1494239012, -1863094090, -889421224, 241860044, -597057070, -677387328, -800742680, 1669940135, 1215809319, -526661275, -2083222598, -637073755, -1521913088, -526188915, 355903643, -1571786508, 1464804932, -904165019, -1677781535, 1872793887, 1053619685, 1841200922, -413992898, 198379157, -321021278, -1976339001, 737179623, -1968590308, -1854984417, -555480782, 1068773725, 650226570, 310191381, 1530268696, 1075315424, -1960650315, -857057955, -333342896, 951185788, -482301423, -71051056, -2083084873, 1939495529, -1198834876, 2020584036, -159895659, 1167882446, -1890500537, -1483202469, -910343958, 1632073605, 168016871, -1550263205, 527443370, 268152019, 115310394, 997647672, 103849602, -1784584910, 632726314, -1124636043, -374341665, -1208743019, -665026079, -389560393, 106006023, -1183187482, 2064667897, 1968231300, -1043462081, 580217850, 1626292973, -1520565459, 236541285, -1627070099, -1162079903, -301733537, -1856703291, 1725362167, -660682356, 1993738692, 1855350124, -1951062004, -373330382, 2088599610, 16658202, 316208037, -882687083, 1172604277, -943502905, -879766299, 1795285860, 755125383, -1849709898, 222325781, 1223814487, 1043171929, -1357717413, 1536586326, -1998628380, 813429995, -427593639, -2036985228, 2066378614, 1487708932, 890432823, -508294106, 724435519, -2104078041, 995956660, -648682700, -1982139866, -762383832, -50058829, 2077265965, -1238458544, 792746871, 470567299, -867454846, -1982024227, 77874152, 2079521388, 1766932073, -1566618737, 451562885, 745441227, 51103634, -1868878840, -2028382100, -2017673022, 306286867, -1677128167, -1818859301, 1120148415, 196811796, -1310237226, -818672131, 1389486864, -359698702, 768882272, 53629896, 1777294131, 1259059814, 1017774948, 1169207325, -1533982024, 1569144768, -604260051, -604363220, 1500329740, 75647191, -1323207355, -1861393186, -14482027, -1702691168, -127972502, 361911859, 567731881, 816139026, 634868215, -1642409179, -752741752, 1660104776, 1236306186, -1498702181, -1912986441, -1040260916, 564294172, 1684056883, 772121510, -1149633333, -2098840365, -1032372382, 2038763302, -355812087, 1066735186, 1575425052, 1312611243, -1253153669, -123362823, -5482985, -796736807, -788794978, 1280607737, 959144561, 1044842288, 2018932159, -483848034, 1634482072, 1337487660, -956000121, -1951973501, -404143819, -156494395, -1479861067, -192753185, -15748828, 1484767441, 807118807, 1920484972, 2004895431, 1759153990, 1781450922, 1225705090, 535250055, 1974399458, -510460706, -496714391, 195563690, 2093912991, 1161619288, -1007121345, -1678367149, -1642747741, -854186174, 2037686106, -1750115922, -45100103, -867984514, -746888458, -204489862, -1481223241, 968926252, -1164351734, 2101378190, 1598199344, 524734196, 413820030, 499689892, 1526182095, 842253067, -107505138, 1796216470, 312273956, 1324958766, -943213769, -1178417127, -499124325, 1528080177, 664198946, -394078297, 762122994, 1124057796, -224444027, -673986516, -1946893399, -564552283, 1363398702, 1455072427, -946930189, -1406355827, 2133181906, -581637495, -1304038213, -798942089, 133863953, -443372092, -1236624104, -446888689, -1804735591, -1147111334, -1770349238, -2033593269, 455198493, 251853687, -1343402423, -501984258, -655000613, -1665259293, -596826179, -1755331474, 889548973, -1660500510, -887318604, 1528311171, 2048748435, 2128175208, -913004317, 635313216, -1830891658, -1377798403, 1304522492, -190144272, 2081149466, 967609465, -1708307712, -1480394296, 562587484, -94554733, 1395911076, 276015583, 1172406055, 1746514925, -1795034376, 158803776, 399824639, -249061671, 62200348, 2072483625, 1848664106, -486858636, 1524313584, -497918523, 1285411628, 839317185, 494210135, -1699889424, -1592171603, -967666811, 838794574, -1752133468, 1094363194, 468655115, -74352004, 1173705859, 223945200, -1289460440, 1253743622, 727343649, 1377815634, 1035082546, 1612218558, 2013115453, -1730767862, -86598313, 1295140069, 863089593, 801268824, -2028139757, -393853675, -1854879028, -1825769620, -1370916032, -418486351, 100898102, 232031109, 1512415001, -130756535, -1439851081, 854653315, 1381795974, -1798362470, 1448544508, -463675693, 907205872, -658015205, -408117691, 731023484, -135414840, 1860861460, -314318835, 1870698819, 1277056485, -1033440573, 369477242, -1701199341, 923799434, 1846223533, -556647192, -212356143, -1831493671, 1203653347, 848559213, 1170845199, 483559309, 1193867597, -315730724, 1338927166, 1123909773, -2079038312, -673532798, 66179275, -647434343, -278303489, 1983563874, -607090769, -1521669047, 562745770, -859088602, -1590704879, -680117588, 1626905486, 74636240, -1242099917, 1764927854, 119665524, -1245009510, 762692317, 1968215402, -768430153, 1450005631, -588800015, -438762667, -193819769, -376003862, 675468814, -1428018431, -105582155, -276710059, -86659900, 1495765151, -950978442, -1552937321, 799717092, -1784413981, 1718209040, 1493975499, -8455717, 1181013442, 1322447164, -1148684401, -893775064, 887586367, 256188787, 999384375, -1906223382, -755510567, 1296393422, 29426835, 1188575840, 987312846, 622776849, 1138566513, 1868500486, -180172846, 1148390827, -607549272, -820505471, -315296567, -805843545, -1206109740, 289556250, -1674879177, 998440219, 287173135, 1638655082, -19487466, 346333854, -1401448151, 444291242, 844307980, 1607845379, 892226511, 722842103, -1821300119, 1009936831, -308814794, -762607021, 51846034, -1986794985, -2079864476, 656839234, 1732856964, -2117863541, -510425562, -128881860, -2059544206, 1172573902, -710814686, -1298779687, -861624816, -1520259430, -1754252831, -512372094, 1085597979, 1623532035, 382284285, -1678970982, -1339399227, 552495530, -988770500, -1531574147, -802496227, 1201898157, 1293698015, -932610041, -58974828, 55227564, 324687433, -1442080063, 1349023211, 1663662029, 1657599005, -1297597270, 1257212611, 1852896751, 1686458913, -418753851, 487406907, -94581467, -581965422, -1512620749, 744303816, -285229352, 1846463199, -1892137359, 1323403459, -1129713380, 1332536431, -1209763707, 1382838272, -1116933080, 1244957958, -1775528945, -136428595, -756213943, 871231319, 1058024799, 825903789, 1872833846, 1157543570, -1738638734, -1880391992, -1330254330, 126982548, 563242985, 1074724738, 512673626, 357556881, 211027876, 952684641, -1272660346, -970838428, 573098504, 907529170, -780685501, -2015899162, -539778259, 851583786, 1324127810, -1968569667, 1146133949, -736504338, -1525828929, -1166520998, 427186528, 1449915987, -1482952987, -1874917302, 2047428268, -1754140801, 1498454147, 1796733839, 681862673, -275542444, -1003139304, -1317167460, 1588596936, 789708906, -738396787, 953203263, 804664111, 1917663755, -1460904710, -638657190, 1205019763, -1822419481, -1431018491, 76405786, 488980707, -937395379, -622319270, -1259706067, 1884443500, 502841473, -1887204598, -1417645365, 1712653390, 553276292, 1315011317, 1361617618, 864020248, 68949006, 150516681, -579833391, -775594771, 1504319863, 1781292886, 1345366591, 665263498, -1470820137, -2136827018, -2014843659, 958522513, -1466176038, 381537157, -709493295, -1976060759, 468542553, 1231708346, -1684045242, -1673857664, 127354640, 1776278236, 1407631275, -817136274, 2021966403, -1806292598, 511030193, 59869412, -2011825546, -53432344, -2105911174, -467570683, -1052320889, -679398700, 1707617225, 253786759, -1483724413, -1842877072, 1791343213, 1275011959, -946839237, 550300337, 1949058535, -1206822322, -1670864253, -1274225424, -721815197, -1503323121, -370937873, -63838267, -2090608856, 1694965977, -887113478, -1622270845, -1951143039, 1003251336, 267270219, 1180637297, 2003298281, -1308312855, -1917952405, -409940814, -685196451, 952681394, -2047071174, -1330063827, -1457449023, 1328869475, 322689100, 234092818, -1661951179, 362941790, 525364956, 1510945750, -566045341, 1379503002, 878397575, -1555641836, -1599616469, 1223899315, 939803259, 1320217438, 880100989, -1595428465, -1289364447, -1014929222, 682863057, 1296658069, 794482059, -384124376, -402443912, 1450619676, -1258181607, -888235404, -249844437, 723284735, 1216630378, 794559729, -1515860678, -1274711791, -1806758152, 1002532395, -1420647400, 543565126, -515394942, -479369687, -1955071587, -801471270, 415214449, 297630200, -233107249, 30089785, -2036923067, -594705765, -420118229, 494660542, -115351821, 4878144, -2108694920, 1902791598, -1917100713, 2108684520, -1474956432, -750863979, -142125896, -634492506, 509357232, -1226947015, 897596361, 1158871792, -1000346307, 440822320, 1478992012, -195202459, -118415383, 1001215362, 1940563298, -1712069126, -423513777, -1913988189, 105014078, 908504792, -256525682, -194262288, -367233318, 476356176, -1985560076, -873847368, 1362110032, 428198321, 810297639, -1867902827, 1388562358, -1678834727, 795625326, -1249839499, 1202043290, 1618729819, -349514192, 1136293381, -62054616, -827150486, -304879294, -1844147011, 1503327998, 2020821991, -324675558, 1580827357, 12275698, -1442050220, 295552533, -594224406, 2104654023, -998287893, -1038533376, 1279722459, 806517511, 579139415, 1885934761, 1238139472, 470360266, 2019626231, 929388031, 508706467, -1288035866, 1463007349, 1842485618, -437139488, 1176943751, 250063146, -497144463, 442428625, 255314415, -1142391977, 1599097180, 362329419, 29198626, -2078188636, 1287787975, 200735355, -1891350928, 2108503232, -1130012033, 2018624047, 768626614, -8783885, 1322214868, 1345156505, 1023281126, -775829876, 1124920333, 805373094, 1604043281, -1421330440, 55747601, 1969727746, 1618418007, -1010578746, -1293918168, -487174212, -777323086, -1606106352, 558896159, 1499779192, 876800055, -1592050759, 918775828, -551310797, -1228068638, 313758951, -678171825, 291688319, -1210081631, -224544018, 651094460, -1721230873, -234896982, -187616085, -1160359917, 1529644459, 89738174, -2122608291, 1238731047, 329462599, -519468141, -2056911, -853423305, -560179589, 207217869, 1241552318, 718589146, -1519521279, 1344334905, 199646239, -204071504, -130569783, 211870408, 1798870187, 1647441000, -1449394014, -739160427, -1726958033, -1558289457, 1820728815, -1236380336, -442760974, -973839095, 1989516122, -195976695, 993471992, -1569849247, 255222049, 801289572, -392806237, 1561161717, 1020894728, -1901000488, 1777536028, 1457717155, -234186585, 655921718, -1473471871, -414273102, 1936452682, 697018981, -1198400067, 423015433, -733368587, 1576206592, 731734056, 629437928, -1566075762, 277282800, 157898290, -905244401, -1905834786, 1367574176, -341931727, -1181163650, -1012633041, 276335909, -435504254, 2081979810, -549257077, -868015801, 433480823, 1632522639, 294087041, -865814116, -1650786745, 781828059, -526690468, -1898772309, -54611089, 2106314416, 291780328, 403479453, 1179439311, 486599874, -1648822523, 2104179160, 1451224138, -1581692481, -1768846471, -2520997, -1087192857, 1569332260, -1237645573, 1742179921, -1214760673, 920916536, -734909178, -265393039, -879944697, -804966357, 1385173358, -1884943340, 1827904786, 750827666, 126233811, 1435599076, -1529812174, -265370765, 934871974, -931333307, 1634379855, -286142303, -230724423, -601372559, -247670754, -1304021455, 600931043, 422220084, -647540976, -1569037857, 1831486085, 58355243, -1552105450, 925627422, -1920649001, -2107211196, 1891784230, -1129787295, -21635073, -666552491, 1423967908, -751091156, -921844731, 1355122823, 1722013761, 15549537, 233166701, 1636491652, 572788883, -1140716633, -970001371, 1845658908, 1844270610, 13674955, -1569853576, -619427704, -1026014949, 1722198328, 1404595758, 1176771105, -1402886557, -35520974, 1190199840, 1673065870, -1723202050, 1610974278, -161453612, -593958373, 1138517084, 1106734098, -1859806650, -1050899200, 1361456168, -2039336828, -1773131970, 1621572588, -1809003119, -1072904512, -1443963853, 1859919349, -410237946, 544387833, -1930312713, -765385957, 359497963, 863441058, 1844095315, 2125052087, 713555879, -2004157599, -1567625570, -642811000, -1078461254, -1472361398, 1956821303, 453795183, 1902882928, -1696092033, -331261098, 1026063680, 443973424, 1505173469, 1694753751, 864425135, 138892120, -1311244239, 970919913, 803372664, 1038622292, -474097468, 33339324, 1464704056, -197477208, -1006711163, -132032214, 120989529, -653861466, 107452365, -589988226, 1224871617, -422388972, -1437422052, -1584192188, -1077303213, 394277408, -306376194, -99357704, 422383982, 726349961, -1688251708, 1160223189, 360719681, 586309013, -337256922, 2144179847, -1178414068, 764081686, 77128981, -714881359, 759975907, 614001125, -3885441, -982153570, -946614321, -1180959737, -544093162, 716075491, 1359186800, -461829504, -1402091488, -1042603971, 1675287630, 889450164, -2134672716, 24435281, 1840112987, -1557756602, 1071011716, 889173361, 479077969, -1802355864, -360107760, 887543114, 506559415, 1405395356, 2139146277, -112766727, -444891476, -1638652170, 512779936, -1473680419, 1057973937, 249872458, -1300008410, 1115205472, 933823199, 768138017, -64388397, 789177360, -1189460798, 1749553005, 686145529, -1323541924, 2089253549, -1498689397, -2030090233, -713034098, 1973247699, 922757718, -607517348, 543883095, 1845916876, -1669560473, 427655733, -1163715896, -1048335169, 742411575, -1593665894, 989329263, -1419858409, -541747871, 1393010678, 1407453238, 1690446423, 1099462715, 1091476429, -1307221197, -884517016, -1128001989, 1934962869, 1937357651, 127695886, 1776525501, -1236738152, 1758702670, -83554254, -2062368363, 1134327218, 26123546, -1575855489, -648220905, 90610618, 1275137563, -641912547, -1829541812, 1470971543, 279702578, 1563041137, -2051193651, -1003296413, 1101173593, 1652018837, -1889036426, -781750844, 937238210, 1824172178, -849476902, 512384371, 14430610, 129662282, -345669996, -451754340, 383511638, 713697902, -1783862558, -199233771, -1324249911, 999081334, 1176661690, -435926551, -1009879544, 834507685, 650195326, -1280300791, 1889897096, 2119112552, 1250561956, -1901834122, 1774520198, 2104676155, 1262516984, -1905987424, 1997100832, -339111436, 91730849, 2014822, -287260053, -881828473, -1351127946, -1391377490, -1317972574, 340398169, 1075291580, 1013682892, 293074250, -152057459, 571114641, -546968400, 2010061083, 369352279, -258313407, 893783774, 2014915243, -1775841405, -1232412590, 859732125, -1597179656, 1090258632, 306989473, -2432520, -861752338, -1985631117, -1541675024, 1810683289, -312297952, 1982953207, 1839923859, -1059097742, -1220583474, -985615230, -840601982, 856841839, 1996992306, -327082316, 968102280, -1893771496, -1038636916, 146265789, -1570783632, -1526810920, -668789296, 1389228906, 753183867, -1119096587, 161707726, -1731606644, 1616371802, 1523920403, 58070698, -131087823, 1604181226, -2041717740, -1693265975, 1443064684, -1032808287, -1783324543, -1456701524, 1547998417, 1099154263, -1759882380, -36398992, -480367412, -57274879, -1342177520, -1896410446, 1783021138, -1014547335, -1858744769, -1183024985, 2092742389, -379759486, -1867886899, -628364261, 659397094, -1109812499, 505824297, 970695436, 947406295, 877521209, -2079790251, 1096003776, 156395671, 105301804, -144804827, 621958688, -166457152, 1611699717, -1111338068, 1944465514, -306619883, 2093866193, -1048427967, -1469081682, -2094880254, 760905548, 1240599168, -1283942840, 1293950411, 852817363, 732920197, 538487285, 986914441, 1670251755, 1666909168, -1246485080, 581623764, -1684669476, 992546944, -315261947, 759029131, 1827525867, 579726243, 59481998, -1132721174, -273890494, 1818747735, 1844862297, 2103011851, -1005883060, 1748235671, 1408762248, 1019183794, 623340057, -1329097027, 2025886142, 1799735484, 400365028, 610634789, 878523130, 1946736408, -836313255, 847589636, 1165686889, 706628291, 1246518554, -85394453, -162776079, 2091878512, 1841292032, 757244989, -49639538, -1754532546, -1663929779, 1612114136, -875377446, -885062003, -345211155, 1757753750, -540537323, -1148780989, -262693430, 212124902, 586437469, 297421795, 39971271, -736934445, -1632638990, 1044239222, -1725959775, 712413954, 277290843, -1571186157, 1668597612, -571382725, -1359170642, -914214830, 1270402889, 1804147761, 41088025, 978862292, 2078690282, -1375666360, 644130444, 728106583, -426673551, 537300673, 1903587824, -1193967076, -195451769, -349719414, -340472324, -590365789, 35618173, -1220563348, 1816210387, -1234635835, -2035332356, 1428998778, 352736107, -391730118, 973448742, 1148287943, -1850835966, 1083834305, -807463827, -193054175, -1448782603, 422828943, 1009747906, -2141835813, -1179645165, -33739200, -1586102341, 1026454955, -1677923076, -1914028560, 1150724060, -656947408, -817088754, -129740114, 703717142, 1241078343, 982565041, 274675829, 1353195730, 1291351250, 1457793829, -1473398669, -1532285260, -367246869, -2048999852, 354582413, 180696338, 755750787, -435754248, 1501481164, 1272244577, 1966230142, 1663311328, -1767353888, -860177642, -1329487576, -248226365, 1662154263, 361762924, 9192158, 1858998432, 2047438867, -36254756, -499871146, -1164297242, 1163102257, -2079215953, 449297628, -124555993, 1337160584, 129107449, 984914560, 1083735965, 1701406571, -1763445876, 1036171062, 1748995975, 2052985192, 1992605961, 1391500673, -516409361, 337066863, 694451586, -2125584911, -630032927, 1543745250, 1978666975, 892997776, 662483160, 591682031, -1481904358, 1246321796, 259255238, 2111867408, -782410527, 612197298, -1283375150, -21387955, 1026638017, 540416872, -1184029804, -1990518435, -1651577640, 82926178, 1447206218, 1438578966, -107038869, -2023420495, -1499899604, 1914352199, -832800618, 153872098, -1763757723, -1982317237, 730206642, 1816993927, 433332472, 880434985, 1588426801, 884827660, -364632482, 360166299, -2033105453, -740950070, 1922573978, -470200442, -26958448, 149799728, -1122326688, -728195676, -1204365874, -232344689, -1438075272, -197441936, -1460386745, 1234886891, -105272848, -182155878, 1277563287, 650990142, -1070801441, -695979593, 195588519, 1609784104, -1523695311, 968618519, 2089879937, 1396238567, -368699619, -1771216401, -1938640014, 154023978, -885579782, -1866752962, -1240488397, 448992090, 1018875699, 1037717349, -2000803673, -468865231, 796620165, -2024416005, 187686171, -434406513, 1335058817, -1401293807, -898011816, 142394261, 1842531790, -2107551765, -652951702, -1823355208, -950207250, -148870193, -211923767, 1307194306, -1654743482, 627195109, -1999379588, 810133079, 1602562507, 120564879, 1585473228, -1831019659, -202196371, 1146461229, -172228958, -1935873014, -750952340, 1032570211, -866339553, 1654325063, -431517580, -548715817, 422757236, 301624124, -1994917883, -178124521, -1474647877, -27290128, 155280926, -2073887676, -80469538, -200660083, -136814687, 1376347659, -116286897, -413062295, -1558056726, -1544448831, 1880767844, 1541102243, -1757729490, -1477921788, 950419148, -1469508513, 1573210476, 1082658022, -264655532, 535201891, 1788738277, 1698996804, -2012906578, -379883074, 1335374280, -1811039060, 595351263, -1928530764, 83823672, 1576452329, -2082488203, 1668617784, -233622554, 1848311435, 46671624, -499294219, 451987922, -2118901642, -920331643, -663520882, 1023180546, 911943750, 1936692910, 1539906848, 1067995883, 162869698, -1059754875, 37623614, 1115695403, -697225410, 89377910, 1640971041, 1996276702, -1180432210, 197673224, -1034102683, 695928487, -194853050, 474809795, 1360033506, -112632813, 919272504, -1355991760, -1839775576, 1540969090, -707124332, 2078235831, 10095529, 909974851, -39723804, 1924286292, 2024939547, -283779329, -1272713993, -1435827928, -1331825238, 2006043967, 566962491, -1292238982, 959132234, 1873656668, 323881554, -2105577595, 652406467, -687269584, 921586946, -1150859286, 1131819173, 1271731770, 1877771542, -1198623889, -1973196158, -1787563206, 1590620705, -1032657569, -539659482, 706571087, 964337959, 104135809, -1885479696, 973363291, 1540365764, -2081630828, 301559483, 1395235184, -810713922, -632460671, 748795512, 542600625, 177648587, -1639411687, 1550427388, 2132282225, -1876650869, -1760031999, 1286015872, -928505118, 1613805091, 449934521, 602788432, 886743911, -1129029181, -925979543, -1718869340, 1952922963, 933108804, 1665901196, -868123292, 1225317604, -1498751164, 1796166039, 1280320859, 1313968257, -1566602148, -856748841, -978764225, 1901540045, 63490261, -1103258864, 1830305052, 302448927, 2091544456, 268426362, 434136884, 9143657, -2021990401, -1250585040, 656540376, -1887681439, -1364493891, 1030755915, -1524813972, -186446530, -404499643, -5219961, -85861207, 1372433475, -557514724, -161758277, -625052840, -42460935, -1319144379, -1963523227, 179711443, 1136536121, -2087946245, 1892319835, -1586336851, 1657881031, 932644185, 1561716718, -1163640374, 456900821, 570231525, -1557187764, 912906066, -252705488, -352871405, -656053632, -1870589872, 536719175, 318899864, 495564781, -187192751, -18960959, -1884346099, 671388585, 1966883811, -1820950507, 721249453, 332395097, -1083793185, -1092392232, -242726025, -29954489, 125987958, 1598349990, -1628354669, -2091440604, 1524897891, 1107791192, 2139578531, 2085289304, 639749415, 750051688, 2082144645, -870518476, 1180070, 1167901081, 387390492, 1983882441, 789927911, -71771257, -795708533, -761076185, 1859061226, 1560856059, 615711319, 1355522029, -1422023642, 1403729329, -816307574, 469585633, 2076900453, -57868781, -1923469602, -405108857, -1400500988, 218245028, -54449217, -1926401514, 1740985898, 1217081715, 1312006688, 1308382983, 1193251558, -1190108985, 793131938, -1846994980, 58773678, 1612031294, -278775976, -2141866895, -1213603984, -1282658959, -215621318, -2124369049, 1889036849, -1738765900, -692252279, -470481254, 1706006254, -1154937151, -2121443115, -676182241, -1295030768, -188429164, -34431541, 1511002264, 1728514145, 568103501, -1238111596, 1995373451, 857357455, -1175900579, -787364131, -1839512623, -2037711992, 833640653, 96037473, 1509490355, -1761213222, 1495982407, -1748308237, -1483427332, 155530905, -1480834335, 1749140965, 2030433728, 1393143348, -800373055, 1247272331, -186806463, 196196853, 2027454907, 482114571, -837124360, -697086756, 158405743, -967965939, -1118243659, -1523834642, -2103648777, -1673131647, -83188452, -2082950630, -910857403, -378874157, 57433590, 1963181726, -1401084023, 2128790085, -1271426218, -78282794, -146723154, 861298897, -1924889531, 832887661, 520392995, -1006471715, 1319291623, 2063529521, -1119005424, -145570022, 1862720859, -598247130, -1414245279, -556075779, 848795415, -301790841, 781375695, 1062633338, -1097777361, -1527529755, -80771341, -1932216241, -1682376557, 1648261681, -562383636, -695311952, 1097166680, 915901111, 94508938, -1355525129, -682631551, -689633464, -391721655, 365744859, -1496147051, 258768291, -679354304, 1767684076, -747115290, -752123763, 551314228, 696945965, 859574056, -315121125, -1390253178, 991580205, 1595907536, -1550711930, 1911520398, -912950567, 1561712667, -2052690749, 203851512, 517618614, -1257197298, -1580561654, -358834835, -458703263, 1508073643, 1418296027, 944473604, -1341696314, -489391521, 1765705848, -1449627201, -753278648, 177621749, 1958510125, -512859618, -795717892, -1727935560, -1886712556, 425681531, -331922305, 2062895522, 1419958500, 1273340227, 953282698, -1025491304, 1697805060, -1847558651, 1966037197, 1847603995, 558892155, 2116464372, 1116075993, -379149775, -622042828, 1819647829, 965107296, 469049110, 1901757303, 367227102, 111137376, 1600263228, -1310773907, -1244628581, -273001940, 1211975454, -844355807, 526485376, -1264691819, 971282252, 554367815, 1406959508, -1200015609, 930255620, -1622490516, -936465757, -1075640657, -1378291262, 1102578051, 1440722530, -1077702283, 845900745, -1099083014, -438579157, -145366655, -308153608, 1798596781, 1163042044, -1650619198, -1876944727, 1257022323, 1918262658, 1725492379, 9582493, 147241497, -694516999, -1754685364, 882371004, 449519491, -1228318873, 2130676042, -2046631246, 1847157713, 459583888, -1178930788, 764839173, 1433165267, -926916640, -655539839, 1568492330, -1142354206, 1596016867, -1309107813, 475345466, 347570061, -6789330, -1545913190, 976144782, 1041032017, -1663961875, 1726266135, 1904401898, 2050003495, -1678188853, 1141740390, -228643260, 1488068406, 889555040, -1343234531, -1850116223, 1155421315, -411573791, 1188878846, -1071825755, 1371340410, 1277017841, -1147648376, -997976711, -776105836, 121465130, -681876838, 1419572205, -55339594, 1993569706, -776304192, -1268651399, -104263612, -339440910, 1493379305, 1579608595, 1392957434, 1763848983, -418727787, 1196511826, -1166607111, 1245979996, -1054980406, -1245836023, 1910462125, 348551606, 351113559, -1437605881, -916753974, -2118257178, 1591027812, 1009475340, 458945378, -795548934, -964618994, -412300724, -1671948829, 1804986071, 1524593597, -956413883, -1577089794, -1757606626, -183165720, -749108914, -355071272, 2051151669, -1868465533, 1354204054, 363455404, 763122611, 824951800, 1722388937, 1767955822, -903655796, -1644723294, -1595410332, 1285484150, -1989471167, -2041874389, -1224444664, 1623049870, -1881163766, -29274421, 1976446771, -1406867427, -693997008, 1578274221, 1807776038, -372663970, -902129297, -825316536, 382731187, 1976824878, 1843209291, 1231110406, 624083595, 83383796, 1914304325, 1109113051, 561080698, 406110274, 925791634, 1614249473, -537336460, 618003614, -125354298, 270396049, -1354448239, -79048514, -793411742, 697641641, -986230529, -1327749073, 1849151853, 550711251, 1779181355, 2135595865, -1536087977, -742081656, 344071557, 1187340551, -1527105964, 282273651, -1337115534, 842618993, 1732867406, 1604955338, -1100865575, -478368096, -2014058714, -16847603, -164441814, 305043555, -259951503, -99934675, 516531334, 259303748, 2072718333, 118498652, 1350965875, -464971909, -1308389170, -690305814, -1813652079, 399458212, -1416273681, 1491751575, -1983720188, -1235198953, 936165313, -518409193, 82582289, 2073395056, -768835639, 687753824, 2025419135, -240582982, -1551139566, 7990319, 1798233398, -281582231, 1509994623, 603097293, -1721774367, 1481755569, -146072680, -1214309996, 1791038308, 2014831856, -1234717633, 1909694592, -365047170, 1519988797, -1370808880, 2005422562, 1067390266, -150445489, 1384737532, -1061905180, 807701811, 1122923790, 1304314435, -380160398, -1215311432, -668903605, 1614622036, 1153485034, 1675898765, -104385064, 1281866728, -1379251775, -201914938, 219940932, -367478261, 234633537, -332740357, 1679550751, 605925243, -1853423878, 986764373, 1421575821, 2108953343, -1815776326, -710814235, -1661373436, -2082115121, -2065983888, -1139174749, 271795481, -1074532621, 611341090, 1102978319, 601243600, 4150686, 1554295493, -406403866, 706096701, -1374492688, -1431265252, -1251679089, 705262971, -788937854, -691549604, -275358955, -221444024, -653125780, 1626028153, -214337933, 744525723, -1565748352, -415269911, -1104355756, 888265235, -32607613, -142675481, -1350633255, -1307912632, 103369816, 371529521, 856577522, -681613761, 160810314, 1737034808, 847840042, -1069034000, 1557803368, -1518292646, 1181163305, -984336898, 451439797, 1689507020, -71564054, 294295382, 136892499, 355612612, 1302890781, 1875617805, 317238705, 1714867628, -1202825633, 1453210583, 1008079533, 1874554461, 949062879, 1840185611, 1069117515, -276215663, -1699368970, 1606282167, -25183094, 387059912, 605498863, -844342043, 1921863297, 1814521962, 1080299142, 415752720, 1921168904, 426395600, 1685687240, 1261735854, -696159137, -467322947, 1267975652, 1695809068, 2111342628, 396276537, -873885105, -955006646, 627050187, -176942861, -1204900491, 1024834737, -567362540, 1864431909, -184170557, 1565216153, 923997428, 1125268523, 310346226, -464099470, 1140592440, 1368395852, -247380548, -1322192454, 1153364037, 1629750592, -1372606385, -782338848, -1292851222, -979567380, -1441601644, 169809295, -939529582, 626285252, 125053527, -1682440550, -734543427, -1339337214, -232780940, -103036319, 219169310, -253714049, -1879003645, 1293494502, -2129661994, -231964510, -732459153, -796564236, -334786655, 1138123437, 2091723525, 1976239538, -770875942, -1423703320, 1678959580, -561726645, -1826483120, 1783644896, 1887472982, -484476111, -315385066, 1736265835, 1320192854, 720191475, 136634142, -620333367, -546539029, -919061450, -746233533, 739725372, 1125341929, -59605744, -1046819002, -353666644, 2079615982, 1996895661, -462658805, -724879635, 986530656, -642166390, 1413886831, 1531445852, -699162213, -1128529331, -976775812, -618426215, 1240528549, 1982825453, 832550980, 1890448937, -1422831794, -768800214, -1018895476, 357111246, -590681608, 1542116461, 792206970, 1082911058, 625129538, -1917137669, 1928040842, 662012142, 417448705, -1425043846, -1524657367, -151102196, 370448430, -1414677502, 1453560556, -2035698539, -2004775452, 649014719, 1057074179, 1818821969, -2097288479, -1742191122, -1048640281, -1567166055, -455834126, -516876603, -1190843292, 1921797750, -774832205, -1143513113, 472288663, 1191681421, -790300096, -937362532, 1900010182, -381757505, 1017367475, -1587450827, 1636982768, -53254282, -1734993895, -933426588, -2099022872, 1618608975, 1192498834, 1785739713, -169832188, -1811309058, 82745808, -807563701, -1214059314, 1353177415, -230049750, -368406533, 1241922992, -31909616, 582058120, -540468214, -1343046231, -1210651529, -2145374115, -322098722, -1354201240, 535665271, 1130316426, 1929745992, 1049453246, 1938393637, -1538342028, -1137305942, 932062539, -14056715, -1935157022, -1158395656, -738559151, 1123732791, 1141149407, -871096996, -2106740917, -1528068546, -2035216815, -1778522152, -2019659797, 1641522844, -975340407, 1453313501, -2083146825, -651619319, 1571418777, -1266086333, 777344290, 1173841592, -250061867, -1551107039, -1231397578, 287769289, 364758709, 269743006, -722035006, -1556935615, -568804351, 517471110, -662864718, 893539765, -752955539, 210367352, 1991615352, -1903255711, -2001144682, -295581036, 401027857, -88791895, 1966325232, 231346858, -424905228, -199795556, -139839027, 1723096015, -1018554989, -1789547111, 1003456793, 771914744, 809040471, 75062093, -505261524, -904719480, 1408268037, -135584773, -1191480179, -256996021, -720553927, 1719332563, 279660982, 131097500, 1333310676, 212791710, -1427782783, -799007221, 878923721, 1512900538, 1132119109, -424564744, -359308264, -267853079, 76701113, 1649296516, -705880982, -1871792839, -678924855, -1705235051, -723938127, 1731438430, 740709855, -1446420764, -702547137, 781147237, 1638212715, -1513213156, -1932538057, 694404657, -1918061764, -2126478826, 606441764, 1685343655, 1113336606, 1496401559, -1150707505, 220675704, 1708788241, 1046308924, -2115173822, -478006539, 1124640124, -635623052, 1176081847, -1165937450, -631873016, 48294336, 81184257, -1190443676, 247874525, -351887507, -1030923340, 1437595188, -1461422486, -1396261377, -172644083, 1738610666, -1764564501, 316054533, -289377470, 1855948827, -1898331881, 1997258431, 1723752783, 1913297618, 1988949199, -697389444, -729074928, 438556649, 1978437773, -386136396, -1050709824, -1876304984, 1336667070, -1063548258, -68144721, -2070535297, -1851474070, 814314633, 1298138763, -2005203432, -1490910363, -17187834, 265512629, 2107493597, 1999942585, 108091076, 652434812, 878085869, 1850182079, 1723598551, 1234508431, -2029512018, 783729980, -1103091159, 1408592581, 372983372, -189791635, -1820026101, -1630510852, -589284441, -590298710, 734251414, 3011026, 1666265470, 918972142, 711448084, 581523429, 467134517, 1084084561, 999691620, 1329012125, 799666025, -1856562259, -1006894257, -1942893463, -1077085932, 601728372, 1622043506, 1247154880, -1794641974, 398558096, 1389913829, 1789144026, 252929301, -611734050, 1899903505, -104903190, -1343294475, 584501184, 1675976823, 402622123, -1280086157, -767004583, -1564014087, -488220161, -61012331, -989072382, 441740409, -1115898655, -1664193039, 1957453410, 536830834, 1705488878, -1078894753, -1048747570, -1968692032, -1516202694, -1827186274, -1838342157, 1509105515, -1693185922, -1674738788, 1807978783, -1681267065, -800141223, -419059288, 408430678, 206090377, 24201564, -2016445124, 1731298398, 1847861918, -1680859372, 2118506429, 55111178, -1831862565, -1254483674, 1117891760, 1627577661, -1279831221, -789217303, -131721670, -1285026910, 100528082, -669497229, 1797895978, 1075980006, -913857407, -2031860027, -1839215094, -1384734371, 1986138819, -29078031, -924519020, -1648382887, 651201049, -31998678, -1921862597, -1787524753, -1616341242, 287367676, 1811476800, -1970375399, 1142237706, 1933518106, 630491270, 684312997, 1407810826, 332794475, 1400926499, -1204194854, -262286178, -1800259127, 1753731302, 1284817867, -190355545, 223852359, -1332407938, -354451222, 1217023971, 1616097574, -262798399, 1346310533, 836049858, 753825694, 154176778, -565444999, 1200290821, -1085135347, -287492091, -817616340, -363143180, -2000710584, -1173535631, 1304577732, 1728141214, -1474490147, -72047818, -1251588328, 806995168, -644066433, 871263295, -2131069618, -2107805214, 681927839, 1150852801, -1670579418, 1212252267, -12672035, -99179857, -994512852, -934901746, 219832799, 1890801918, -2019585779, 1745687672, 974228913, -1878751385, -193364622, 2077575545, 589793623, 983307101, 1325213646, 143681508, 645793256, 1922846998, 772007882, 1544530204, -728737171, -561765444, -1088915712, 585590286, 873709404, -79177394, 1133771516, 1630799123, 1996335831, 985396381, 260757389, 62774306, -342875291, -572217509, 1920931261, 536201927, -495656273, 1553086033, 1044067461, -1984662992, -1290704979, 1573042987, 490794454, 97048493, -2095160240, 315098668, 1399716316, -1674572243, 1334751491, -1880969102, 1076116599, -1052324584, -2129464912, 1125414682, 143593577, 264215790, 1070263034, -1737696922, 51192490, 1901773463, 518291330, -1496924664, -407533361, 1336888749, 626586700, -2114388070, 1877027722, 783000755, 687991460, 1266985558, -1357716599, -1893075132, -1697563127, -1699139431, -1234583213, -1117322539, -405159362, 2111732820, -700462915, 62213352, -1797007887, 205499097, -1458798961, 1588293410, -1777084935, 1796787821, -541188647, 1416658041, 2080197864, -193999765, 680906680, -464873451, -688474132, 764396077, 1807107453, -1634903782, 1104877716, 218102280, 768394775, -2004909458, -191202506, -718317139, 883322100, -1460216355, 1103106803, 1883648235, -1631525372, 1391995865, 337238924, 1897805237, -1042251835, 613244990, -1234125623, 1707946037, -1003740429, -92929478, -480645563, 1578950480, -2077358741, -1205528043, 1547261000, -334743376, -209260843, -1364012908, 710937458, 1805458366, 685288178, 1576360910, -71987391, -47275670, -1428686535, -312695858, 1870313650, 1929100112, 13197737, -1732723921, -494080853, 271690081, -2052430527, -1423554300, 1917221388, -1361343790, -787695202, -1432285346, 1125309181, -1443468222, 411484306, -1410146985, 798266619, 462900519, 200129872, 334920016, -1885885877, -906944602, -1567696970, 1624231161, -1261975203, -1804543866, 125765849, -869418171, 910440515, -682906005, 1050659084, -2030453578, 567443986, -210933485, -497695839, -33157068, 487700300, -1645999819, 1377133773, -2061770467, 198913309, -1571405732, -1802001454, -532861418, 916708331, -616502438, -676836138, 423344502, -1461974385, -1644713713, 576720114, -357718426, 1827706804, -1314730601, 1162197084, -2134096010, 38112118, -1904028835, -566016106, -1594768228, -1982711345, -553933159, 1799055421, -958156370, 408286509, 1907553466, -59044044, 815327119, -1879261698, -1579295346, 580701626, -2126568419, 1519268162, -736820819, 177713472, -584656490, 1166630063, 509447986, -573781692, -312785780, 1361110610, -1355623912, 477537121, -2059379555, 351834553, -1501906476, -205082930, -838649313, -1561262228, -2030381957, -2126287229, -368678324, -214732552, -1713195628, -1197101270, 1505598140, 1038713145, -1393804282, -1195567529, 714513621, 1493059213, -1301884219, 1953237895, 1778894125, -1050272829, 1511443622, -47010724, 1637961503, 325360535, -1634588241, -1602759560, -557285335, -1248355430, -2047726754, -1359352764, -86805255, -1031137763, -1970345684, 1696677843, 700620557, -1634806562, 1312918151, -2004741757, -1730245796, -505103426, -735604652, 2144119570, 1252926320, -2793653, -1756003370, 918384385, -1111504092, 1296904074, 201153299, -1423468783, 1821357059, 1446691032, 1669190068, -2112756977, -1621650217, 1096304030, 970686526, -1206746193, 1502423155, -1310211946, -83479128, 1305256208, -265686239, -942828695, -278591082, -807280573, -94011979, -1131742851, -523620524, 1969058914, -1553045531, -1452287544, -1591565454, -1430800891, -845479174, -1633834017, 1079570570, 869476328, -1695576859, -230112152, -689610634, -358634275, 338946534, 410990734, -224385875, -60756710, -469143841, 111693748, -1601607566, -433873081, -150795040, -66677678, 1035844619, 1760377527, 308992606, 1957767215, -617541123, 534395629, 451109627, -1565921969, -148740353, -95553108, -945574824, -2104569048, 1639883568, 1365916123, -173247311, 688527752, -1298526467, 501263719, -1491749348, 1282873338, -1915163324, -1648471250, 84862987, -1700495651, -838615473, 884934895, -1715376419, -200645325, 1752646255, -234788439, -1210612193, 845211210, -235941310, -303461494, 1798443214, -2007112460, -1483497645, -1717586782, 1242171089, 1600752573, 1468641416, -15384663, 770648402, 1765884890, 790203513, -338112554, 721107546, -878789565, -1420459984, 872609234, 1130175117, 2097618842, 1935857562, 1912463431, 147866824, 1737438651, -1480927740, -1396220845, 1582248166, 1298660024, 1489275685, 444478576, 167973633, 610363833, 48410357, -91369085, 368080423, 790089758, 279717532, -1999646384, 54988230, -1276028428, 444704562, -1927083774, -879408705, 578945731, -1439784136, -930087785, -1435386447, -2035311665, -759802595, 2135923356, -1917832260, -775523295, 1596202821, 523930439, 1561115124, -1576912912, 305593770, 1808896508, 1748148991, -1910118599, 1256283437, -1729371357, -1251212382, -1191226366, -1419027696, -957032271, -1022823926, 514542807, -1797444896, -1543066594, 1178727625, 2106053086, 473847365, -2016923557, 438509914, 240843021, 1656044070, -663871874, 16722291, 1398839233, 58566796, -1172275845, -1520287472, 40070499, -532353941, -1646175765, 741369289, 1621470689, 1814630061, 1554916157, -2121187740, 1417897513, -1437561125, -257557441, -1413701492, -2146805773, 825096233, -963249384, -1241750230, 647455250, 1982159363, 1183226289, -2116017547, -1492904883, -1915529542, 1284729898, -72348796, -1950925377, 931069938, 30815205, 389612139, -29045781, 236513106, 275911964, 1419662618, -1088284607, -877265490, -1242872200, -1918354669, -95216109, 554445808, 1703757733, -496728145, 854136508, 1226989793, -159445111, 556337400, 1523548085, 247176817, 100660182, -1938484961, -1268022921, 1826876069, 1685800809, -725185026, -1689390472, -2124480906, 1226621394, -170272100, -834525922, -691043337, -1064830047, -1392644071, 1919166743, 1958266928, 416370192, -1222008338, 646593463, -1226400034, 1660049727, 1086744795, 200599963, -1446039810, 758853976, -127193490, 987626327, -791105183, -206682473, -1510206059, -1216996316, 119231973, -610351003, 913211157, 1569138723, 1514969365, 1615500996, 1477341913, 1140582645, 1981429382, -1638913883, -1454050802, 499720840, 61852611, 1865221094, -1922697543, -476435695, -2136051464, 322756977, -1865159297, -302398088, 969214582, 1070509556, -540132564, 612467832, -2006343115, 24771715, -1987942905, 2101796556, -527025443, -1293815056, 1810573827, -150099713, -1580873753, -250852698, -789281525, 1650938425, -1742948327, -585774220, -499275294, -1463634601, 1930208081, -590531169, 406673594, -1494323835, -756886669, 1935249753, -1557838130, -1185875621, 23633733, 1659582654, -2104641673, 2097515633, -69666321, 2075640463, -463361360, -1751488028, -680227329, 1112459865, -297620344, -492266595, -161975995, 1558740357, 949945830, 1707992529, -485390490, -925032832, -2072863641, 1986496842, -425773066, 1421113282, -1776302733, 782717170, -602238068, -26355572, -385268954, -1697910262, -269456436, 809385348, -1780009195, -967292367, -267293951, 2121721078, 491969445, 325593000, -2114691692, 1299933976, -1656608980, 1102798982, 1385873603, 924647624, -628054507, -1915724812, -1568396270, 1751071, -1705068823, -1990773243, -1802729899, -1054544330, -1003271881, 46335233, -1829388451, 495082884, 760157266, -1829224351, 819904403, 1827123487, 140756433, -1572612564, -2051653351, -1937043627, -2015840521, -171961291, 925408623, 2021732909, 307099488, -1437263082, 1793870873, -748177281, -1023526759, 1354004061, -1623703018, 1762006474, -341126304, 1095747795, 379976555, 2031882175, 651200347, -701860282, -389704282, 1360405843, -343660903, 1273060150, 1324363012, 1533724900, -465250372, 1809501446, -401409752, 792159261, -1046070437, 1970487344, 419675922, 1719604843, -1674242635, -1000547200, -1720004332, 1178855113, 1932702941, 1549751404, -1231863444, -1354724123, 538149659, -699383293, -512002998, 961646902, -886661330, -1998482125, 1088502575, 426598673, -2008728610, -1538647212, 206446127, -460605176, -1706538355, 1855540698, -1805672910, -717792661, -1212853801, 1128848615, 1143908312, 1311792996, -57295875, -468994954, -600304653, -1566510757, -998141892, 1128021936, 1768221132, -580595306, -929778382, 991564365, -254546511, 1155654428, -22506587, 1821340950, -1524699069, 1338707704, 2013549078, 1944983622, -1123474447, 1013221642, 538862342, -675350358, 1324390801, 19149685, -1778676494, 78529574, 591945511, -1404480046, 632299072, 600613917, -307804639, 575286119, 1071953323, 155384842, 246306804, -559063381, 1489268585, 1465080979, -2060507033, 1024578408, -842443314, -2117642045, -1282387428, 2024570615, 1735202608, 330956912, 1753108541, 1691197754, -1451750862, 262219619, 1059179659, 1596090377, 1371486223, 1383437759, -1225275501, 1139264943, -917741747, 511150958, 1218303443, -910703302, 956792871, 1720146116, 885266738, 247063120, -2139081406, -2043770149, 1746343548, 1374999281, -1212109442, 177777506, -235572728, 63934731, -645338367, 1662124484, -705732139, 388806628, 1918232825, -1080168660, 135909047, -16291066, -1167715364, 960329101, -126753549, 456598072, -325418088, 1809179444, 1923550037, 1603178929, -817560773, -1135381318, -439923640, -492256865, 1165729036, -1770419030, -519342380, -2124125518, 1360357325, -1178598196, -376811831, 79538784, -2066135949, 543750314, -518599982, -13495330, 567045843, -1344871697, -1154614496, 1518386251, -1673863980, -1500670864, 549488333, 36266693, 285590201, -121526952, 948419386, 1873410023, 1692110982, -452395074, 1353407745, -1587581459, -1955156682, -1038384849, 1621718481, 920603606, 699552499, 392369664, -1042975075, 1934278201, 1480451739, -1337050277, 293199976, 1745667728, -1119884147, 1659298567, 1969481440, 407106780, 556485820, 2065641417, -1010093796, 1886374608, 1761265100, 1880752544, 680751630, 692008115, -1605301013, 561964048, -2031781337, 33733141, 989449552, -235452184, -1266431028, 159392754, 998138452, -874387738, 453687607, -110837512, -602475665, 911803444, -532872153, -595538233, -878226302, 1600657962, -136503216, 8768242, -658624374, 27430073, 903643190, -1751253405, -1777747656, 453604562, -314902025, -1196274570, 559636691, 2028420859, 2007470618, -1971346691, -1269989365, 1286838543, 1754461055, -741019745, -2100227402, 1365196727, 2116995021, -1872014530, 162829075, -42337143, -319627439, 2021582421, -1887344397, -277726783, 1109441451, 1728053120, 947691621, 600673786, 110530098, -1024483477, -856351074, -1026171971, 456566795, -2020030905, -1768520655, -2033535013, -1770450593, 2136758065, -1881910201, 1237701088, -2072585951, -668235900, 543644391, 284911739, 2102389636, 1961965205, -72282996, 525389175, 1337108008, 67644362, -1760687779, 384979587, 129383544, 1975601740, 1509751881, -646268485, -1634915447, 523033887, 166558, 1051117482, -1356243062, 2141150852, 1927182215, -374449181, -596062075, -104438133, -861329226, -1078885632, 1620448856, -1373377113, 803945915, 1099632129, 1487495196, -253032602, 1715929683, -318846007, -263202705, -2055444209, 390345095, -973848217, 519658152, -1256590464, -2115842453, 1608434111, -131570775, 813636144, -443794954, 709101954, 350915009, -560811813, -923791308, -1255667431, 592908904, 232125431, -1765301823, -1279173524, 1948726591, 1814414339, 1832375617, -2063027849, 1782304103, 385493230, 1358173913, -627257751, -1355321097, 273363146, -1908045807, 2093301613, 2138305480, -1494153491, 2113761015, 1616920842, 1958123680, -1942801185, -482989799, 444634374, 1927679294, 389729518, 1917344530, 234333048, -265073002, 1324326174, 1055034167, 25102684, -1561045731, 2116332069, 3673238, -1123446081, 1352950471, -345167557, 1600003427, 925836323, 706344188, 368564638, -381020522, -1328621375, 809024186, 458401345, 1786942056, 1814717615, 1609904007, -1492678031, 1064489778, 2118447801, -704810772, -1842587986, 497743013, -1009180972, -766700919, -1094181838, -1810727279, 1990024817, -626715168, -1338903314, 545083747, -714139388, -7259082, 1413145687, -1885464862, 1002968405, -261625545, -874014054, -2070350687, 54093442, 2062551242, 479947228, -220860843, -1578040301, 405417303, -221379122, 89848227, 1038433468, 498998657, 1860550458, 1481501124, -1666756881, -1507788622, 64735427, 908428574, 705811012, -102593740, 569190188, 526197572, 2109246048, -221263672, 1820425794, -839777685, -1837728839, -851679029, -808580000, -1622364091, 1894644261, 1034054708, -802534326, 445821100, -327465219, -1967935876, -1566193292, -702583949, -860849448, 1420807557, 1209319853, -1618356083, -301841631, 166751189, -193081352, -1502354506, 1576580149, -901670820, 1063870242, 2116578831, -199497765, -1692104186, 1068299224, -275625299, -1498720355, 78837263, 1329284041, 640784097, -793958089, 1686739145, -940677642, 666863872, -1326820642, 2146858827, -1353894291, 1140020248, 780079750, 1491251934, 820907378, -822655285, -849680745, 1999021284, 416917995, 958872250, -16200939, -1404029376, 820111218, -1366700441, 1969773760, -1473675758, -508521860, -1035172234, -1527757046, 884437516, 563052919, 1697661538, -64568469, -1717059431, -611040535, 994204316, 1031189226, 1363326676, -1499522417, -2017445322, 1542354709, -1688489677, 1538814588, -1389103604, 343148156, 1428991596, -1188086655, -1792029695, 143544751, -966539341, -465732016, -510467820, -1560321177, -1850690087, 280425163, -1127135473, 933256879, 1818454969, 1546257347, 405003644, -990333618, -1171979025, -672428441, 235438011, 1189213016, -1717160471, 340997209, -1580084502, -280884777, -400563926, -2061573812, 86185202, -374748941, -436087670, 1601384855, -1585872732, -1863834143, -180334816, -672088723, -1521948055, 287825033, 1296796646, 519294440, 1478231439, 916067375, 1411233312, 67397046, -72629793, 1819714429, -364740474, -1449345881, -1859755812, 155684017, 750575885, -427188825, -2032679599, 411559679, 1651695730, -1290801776, 287407933, 766361740, -2118380030, 595389670, -315838137, 635450690, -480671586, 1204709291, 248279909, -2075918503, 223193967, -1820506239, -1756014032, 1040875167, 834136478, -112648165, -282748369, 1848668756, -1414648156, -431220364, 1111753130, -913218308, 52817319, 1688461216, -73381329, 1368355544, 1256844803, -1684979437, 1296794121, 2081977171, 1814772714, -533622402, -440518479, -1965633281, 1831559082, -2130314908, -498660598, 351051378, 635285826, -1352017451, -785799285, 546814955, -990434657, 82000791, 402944030, -2037596729, 1502983659, -1499330104, -1935671377, 876848270, 1471472738, 1407176839, -1340550598, -286537641, 1212206053, -1318872600, 1207336499, 142729084, -708410365, -332950111, 1827257029, 1688699425, -88356668, -930210701, -1036933549, 1335179941, -1484892907, 1207628539, -1199926087, 290025472, -197495839, -500904200, 1072372785, 2045995525, -905359073, -1295076110, -272017194, 551248765, 726190004, 290892876, -1022460057, 180517609, -1049996598, -1057691473, -157099923, -372550066, 1072709140, 1032324677, -448360666, 222317768, 1500242208, 1728842778, 306757964, -1518725477, 1662270843, 1550179116, -1195761947, 541138313, 868674135, 1570767727, -1695663460, -121024206, 1764253845, -735859031, -1198307522, 1654450474, 2124005819, -738957141, 529385568, 1753709152, 1770448066, -649219044, -1956612768, 1215510919, 1740429403, -845144353, 34653430, -28216182, -134910303, 1750805214, -1257616328, 1016493261, -652999610, -171787051, 675597233, -221619154, 2079444229, 719164949, 2096225596, -582221380, 240176617, 1783465525, 884414091, 2119191526, -1708418169, -747457684, -952744194, 1946782641, 1460899273, -1732889345, -1505258664, 1356451460, 762646827, 979964390, -290944638, -365002061, -1985271543, -1656114706, 969465988, 149716684, 915328158, -1889061619, -1321983005, -1663542772, 1672499225, -2083178308, 1885730521, 1622103801, -615453881, -515754543, 1906389759, -82489316, -1920516898, 2138475816, -2053099036, -1407419446, -701004934, -1414281934, -3711841, -1121570789, 237698056, -1543718041, 1565783078, 734635432, 2132334765, 916013687, -1831255901, -353231336, 226607643, 524356077, 1751681421, -22630351, 843993604, 1084614196, 2035799952, -617526506, 620878791, 2061441050, -994217783, 1969306617, -1130240286, 169655956, 951496412, -689758238, -569947143, 480342285, 339658168, 280306202, 926148571, 1365745441, -1666537866, -186385238, -1584681283, 1056200232, -2002738834, -439345936, 1852357258, 1170595335, -727607613, 1411859605, -137979827, 1326408928, -888730836, 1745991405, 1369546408, -1206946685, -1132262022, 874085480, -1661563474, 1218685983, 1382788858, 1372276577, -1885237326, 782165147, 691300006, -790593827, -69687444, 990561733, 1045652579, 1326955564, 793694523, -509747178, -1026039869, -864386435, -178280151, -448896116, -731183226, 1569963052, -313700584, 950353861, -1103427505, 308735677, 806976828, -1048749305, -763975319, 325509457, -464499321, 512237536, -1022293422, 1622952458, -463286112, 400524758, -1681495626, 101668769, -69545640, -190853322, 990058392, 323928932, -1091504141, 798040695, 180898657, 53793748, -996547026, -1496733655, -1350789427, -898560353, -1565616316, 1685098296, -825746486, 409932109, -924653268, 1269614523, -383222643, -132603332, 984139169, -869855860, 35162783, -292477642, 458111620, 1436758365, -572551602, -1503677311, 1734083995, 777388353, -791876734, 1296479515, -1407647228, 408695691, 1841659107, 438037563, 1346192678, -554631082, -1050997446, -1183517353, 936682294, -343909172, 1416254195, -2074174122, 738988844, -69052894, -495843662, 1906588636, -1189985938, -1922922449, 1036067830, -1330991608, 2043383260, 728993016, 1670729812, 741250712, 514571024, -183802881, -1353987412, 1698547554, -2130353861, 793065076, -2106903297, -659164309, -1160279919, -1993815735, 345557135, 874632527, -738245623, 494413152, 648283708, 577772944, 520735400, 797270099, 543475004, -2081725038, -1347809018, -560603504, 1756736923, 267746325, 2077277573, 1965440471, -573086592, 859603524, -1182312919, -1618874355, -2014485660, 1169417786, 1296875690, -597554710, 208843493, -790879410, 1439956918, -790406812, -527878477, 48880765, -1950736682, -2128380079, -381758699, -1267379426, 715293330, 1951744581, -1747746857, -1555610887, 2019708822, -1184532771, 1313967451, 899509982, -1481774735, 1142817517, -977021220, -1637304258, 2095054288, 550063380, -2136172552, -1731232491, -2112936783, 1646423083, 670316246, 1564913354, 1819657714, 2100095006, 860184194, -1017793324, -1902421839, -650810609, 1493155171, 611948398, 1997396886, -1483095951, 104183279, -1142111422, 879122185, 1486857538, 1965335985, 1630821046, 216413886, 1982099474, -710043629, -1796402078, 1920331876, -2063481679, -246645076, -1254280124, 480880679, -707867024, -113893732, 823729517, 1229585652, -1616383462, -389609940, -889854537, 1636625084, -1701766695, 1309616834, -1182786692, 285752452, 2134138559, -1018381780, -1554746397, 1638862243, -127317123, 151530331, -1191473620, -846604933, 1689876068, 921985136, 666962330, 27222597, -1760662989, -1897355191, 897984137, 1984114054, -1310233059, 1547564479, -1238172476, -910573197, -2017129837, -1616752145, 524134104, -1764386988, 29812519, -372539362, -550369558, 1524153136, -1147042214, -1738091954, 869901516, -1688003968, -2040195063, 122571276, 835996911, -108234050, -12371766, -1288459478, 1727329015, -797100958, -1413106021, -1013217198, 931611287, -1539557358, -529662745, -1002332558, 380837109, 1903021914, -963604563, 1639709769, 1554159071, 1840820999, 1184425386, -1145728798, -112011237, 1346166571, 2134883422, -1127673328, 1070945520, 442535111, 924377314, 1263793046, 2050700017, -1025787562, -114204504, -1395542118, 1380843462, 1717797931, -141176083, -1408572917, 1505501476, 1794708316, 1306699063, 1648640201, 1296966413, 995805468, -1141568492, 676769902, -648391840, -1731859987, 813769805, 1024430980, 854869859, -810915, -1932633736, -1030227932, -544971197, 405542030, -1867038058, 1943447076, -710922591, -580870684, 2032887441, 1114735503, 1389953499, -93444738, 947600601, 1637583454, 1083254528, 1217931453, 116140785, -1615508403, -741877528, -396104334, -1091095646, -1450003082, 1475804565, -797850610, 435681561, -73268844, -934380062, 623680069, 696270862, -961702462, -1169243785, -774154250, -215467938, -610891165, 1493715711, 91516379, 2052643328, 763600084, 294297351, -1783370209, -2125237805, -479347134, 1275907979, 1271075181, 1462837970, -737061307, 1650111243, 570278733, 1057933559, 608038675, -892682215, 46452277, 2034005752, 474596656, -1193475638, 1179882240, -960052392, 190156830, 877465177, -232473016, 1860833970, -386987920, 1074971044, -1693171400, -260242730, -2110234374, -2145309359, -442922114, -968476425, -2049857983, 39699326, 1833521195, -1899051133, -1702848251, -482452596, -521664815, -1234388913, 1710595423, 1573442255, -565503533, 1883185262, -2003933906, -779960891, 729217437, 965144565, 1566485848, 895945105, -1956288174, 825733186, 404217047, -937724830, -965524658, -1838996487, -1593908243, -1984025049, 2049856192, 266357520, 1280905947, -93966834, 1466937377, -1035926393, 1409331185, 546482466, -625698692, 418889927, 110208793, -1740425329, 790776900, 1772152727, -1624793609, 843175706, 1890073586, -1970220677, 958108354, -610990284, 1340895400, -1767330904, -975147876, 1937400668, -51453486, 1655238175, 757624741, 1705953154, 889067492, -369118872, -28219878, 1552946192, -1280262975, 548013822, 1486495898, -1962079414, 1652115811, -1214251689, 1638387027, 1976556156, -686803053, -2058058498, 1820015874, -1101928575, -513520627, -1673524607, 427061583, 123163031, -843023226, 282537621, 48843253, -2051067587, -1513880073, -1079779624, 1976515360, -1839765587, -356648409, -783511922, 1426559480, -227364236, -1151522781, 1336565805, -701333050, 1591931128, -248051433, -1860386015, 977807987, -535640251, 1120110518, 317650250, 1568526042, 200645531, 214539343, 1851966393, 1302601283, 1236807973, -1859052227, 100169721, 865079591, -322227979, -1700412184, -1866365537, 1130429585, -1981358980, -1592060038, 308601481, 1378534571, -1138336580, -1711287560, -719758278, 1580331210, -2005969542, 53689933, 1414616464, -443835776, -1400826248, 1531438571, -1371332545, 1395956161, 1495334760, -673635234, -2025867185, -283638496, 419217918, -307742408, -1752953625, -451239372, -1248056287, 2001274425, -125331876, -43591132, -13214929, -1648488758, -1682147609, 1831953679, 310694245, 1629393306, -1455961392, 635412670, -647549041, 1114271138, -1669034624, -1167096558, -1625407058, 96313417, 1834992265, -589021044, 517951995, 1678689530, 1459699855, -273350842, -936635499, -1846392979, 666655013, -1284998174, -186471353, -229148068, -1542533325, -844445254, -636031213, -165766843, -2080520819, 122278885, -841884614, -906664298, -305366979, 78916871, -1901675607, -1137703894, 910364862, 135061660, -25727279, 958552310, 1336593150, 234236858, 1167195941, -180704950, -1416103511, 1538793341, 753073938, -1631613863, -1843731826, -1381180941, -1777194558, 54126555, 1025900069, -929532993, -133940354, -1919380006, -1954203056, 1320055070, 1774266469, -1140659759, -1518712890, 619751332, 1255638645, 974895319, -826460555, -344478288, -501237155, 930099456, -805831492, -55829878, -18164813, 623534808, 1414123845, -710241253, -2052670509, -1737489617, -2040800761, 1896974014, 966501802, 416370751, 675232506, 1796707907, -1861314665, 1549508526, -93574864, 1068485613, -886904999, 856960137, -1817841626, 2109657722, 578385166, -275356562, -407736466, 1335576370, 1734232742, 1364630375, -1636962150, -1794754549, 1843694706, -1535274898, 739880059, 1218526453, -1666785881, -1939444267, -551536105, -945113579, -564952938, 404072823, -121672705, -713723236, 1342496434, -113374890, -1043621457, -2071840984, 770623961, 592829247, 1986150275, -330730555, -1981518110, 1690849956, 1731105466, 1980435062, 77106149, 1252056388, 1912293855, 35736505, -653045074, -1515162481, 851234449, -1054819824, -1489667291, -138129751, 141694583, -1053181969, -933204830, 1321391962, -512101762, 862777679, -1662484348, 1352762687, 1516919419, 1557698354, 1843951576, -782641295, 1624786905, 51042288, -1054107015, -176584985, 1044741541, -1839566861, -54701487, 1299244308, -706289896, -752582425, -725204347, -704344448, -1204430994, 976397940, -314504095, 979189386, 1220967716, -1000831864, 699948104, 1089955291, 1350628149, 2066494049, 1096285866, 326546497, 1855938972, -1741358670, 1281617744, -556440248, 1511541495, -1283938435, 1450949238, -276943922, -1238465817, -1002610113, 1432585437, -1910846972, -2030726509, -2097831117, -1595047711, -827641607, 1123525603, -1224330329, -1477566467, -1940599480, 114347908, -152334052, -992774138, -2095762749, 2071582234, 2059302867, 991042045, 1976137469, -1946849193, -1756537880, 1254189202, 1746563715, -562390487, -1074089189, -352216432, 2015132909, 456760387, -2024608035, -1528610664, 1604404575, -538146817, -719445656, 1729798906, -2141806383, -1017301238, 1014022945, 663287129, 1775358569, -728785242, -1120167231, 1574589582, -670050605, 209375614, -554174298, 1960532912, 840637692, 638580284, 214390793, 1452970740, -1313777324, 1974807892, -1317709842, 1421817408, -428471511, 1574345091, 1936171378, 838955065, 1676520917, 329211992, -1617534973, -1090520963, -1441080721, -2088997601, -416165709, 1200298552, 1088588121, 720192763, -1536341658, -1761936166, 465504847, 1757913370, -429327348, -610862325, 1624119222, 1405476793, 1143982103, -212861964, 1820306209, 1209930076, 1053575243, -924358980, 742537222, 197442293, -1377263768, -1365721241, 614566209, -226972628, 1619631172, -1341045314, 765545651, -1277197816, -89841298, 449119169, -1154401611, 1506589126, 236135215, -1951568461, 1247075608, -1227302539, 1936408839, -1386524614, 1813488173, 400850592, 531682117, 1467176178, 1156760904, 1371163322, 1884343363, -1538695822, -1640341512, -1180489929, 1540969315, 560963669, -1004803004, -151127737, -1412807952, -1097732615, -897295237, -1570137071, -808803941, -437674031, -273011116, -572771117, -1296449449, 193841695, 1853195570, 1501586965, 653315055, 1108758348, 2000969646, -897165044, 1675424447, -2060803814, 558094787, -1587652504, -1119377162, -949651496, -1678409361, 542164840, -1661282355, -1665836208, 806953175, -503799492, -2111000530, -374582394, -2068410196, -1777189420, 1594468718, -269109115, 700098808, 1780953149, -232455585, 28593050, 1939968697, 1014641706, 2010626983, -335019799, -1620646794, -2032818420, 1958457196, -1439110118, 628450367, 266575463, -2014725073, 803456000, 1955263119, -77511661, 1473123333, 1348206702, 1819090578, -1534623541, 1895851841, -1266722119, -1720718613, -835574853, -2106611528, 1554430773, 1797925379, 394258714, 1558940672, -1932352403, -823556625, -1622782839, -352467444, -982306643, 801310735, -2082448267, 2094511353, 162186749, 1718291421, 533015849, 173819194, 1966252547, 653107598, -492468689, -166012667, -300397472, -1942340544, 1977262227, 465255741, 1554964105, 970216678, 1302419292, 872488105, 1431765494, 1973902481, 865212519, 1306055911, -1468702487, 598379424, -1741176172, -921913171, -1512327010, 2056146948, -478337761, -1202611956, 1974673016, -1625194152, 789526247, 350065268, -1496099069, 282210413, 1657289764, -1489452565, -1914571585, 310745396, -1900168492, -812270461, -1673036832, 1642577067, -1821998388, -839167731, 2028191611, -90679797, 83046762, -218921166, -1642041013, -665865091, 743949400, -465902600, 1381260359, 543986523, -1096340275, -1650693659, 315018680, -957334866, -752342395, 249618861, 47251244, -1233478315, -1636974416, 971270888, 175321730, -922878402, -900892744, -2031849919, -680652840, 1851194693, -158854856, -2085027951, 258667810, -22655822, 1183941553, -621754488, -553575029, 1358311757, -1996867934, 1821320591, 1968513784, 2103904050, 2113206745, 1784798189, -256596578, -1966791646, -1582445883, 1479471906, -51593866, 51557461, -2098578135, 1102436467, 811054913, -2052512546, 1441053471, -926747237, -1866469357, -1651384110, -1689510359, -221377894, -1437386455, -1815223353, -595531795, -1785093891, -1553039139, -1596619362, 242811841, 1020612922, 2078784465, 1145321004, 442717160, 2052579759, 1562317513, 372301333, -669484160, 1742982505, -872208343, -1601815815, 2123300394, -170139773, 1318861163, -74925740, -939413907, -530586159, -1934967536, 1517482373, -1399926726, -1831438491, 303169753, -906388562, -2085424966, -924053314, 994783056, -1330807732, -2084427821, -1174870142, -1716082440, -1986745786, -1244996785, 648690709, 633842038, 833432461, -567341406, 946162566, 997360524, 118720261, 1260439406, -2063821573, 173015381, -504304429, 306259631, 2064338765, 1134502274, -1749787981, -1151014696, -1405960712, -1501491154, 1624572687, 432367725, 2003849709, -26236674, -625275056, 639980182, -675317674, 1264160784, -2097926603, 928270347, -681137532, 870055831, -2068845988, 1627643909, 1882208804, 520438540, -517201240, 1409355259, 1403836715, -1804126911, -818683557, 181543821, 1201728765, 444526320, -1563552477, -830447777, -228286444, 1277885516, -172964529, -292381570, 1630842546, 47790238, 428551822, -1974056527, 1810634732, 1005980967, 1431102321, 461988398, 1641741006, 665162649, -55144744, -274823795, -1243516647, 247070864, -337444377, 798539058, -2144991624, -2090907324, -1690302884, 1948835879, 624648266, 591434716, -113512133, 1626353050, 725012803, -197261688, -1617487760, -1826106709, -13716964, -276499551, 710481114, -878599490, 1560037728, 424111268, 307787760, 926820422, -1708067733, 398293514, -1995101192, -1779882142, -1554654772, 60677063, -133926101, -1410315636, 577452747, -1197850972, -1703600855, 2093145130, -346878327, 968169750, 1496048844, 1685638798, 683215723, -115882912, -1213652961, 1563704016, -114897698, -1728927945, 1668984239, 1652151604, -1120870825, 699030135, -1126854123, -920921636, 200409238, 373508084, -1509467660, -1263059946, 11375411, 915698069, 1618210426, -381699154, 999001604, -1722468638, -1749339280, -947393330, -724065504, -1519454769, -1069020976, 1607003918, -592698980, 748428259, 183196642, 1046175964, -506225588, 817548721, -1517282124, -408296520, -832493424, 1390036773, -630642997, 1440926123, -1472970440, 2120254900, -421213864, -65401922, -1963879208, 1062594638, -1237281303, 1749996287, 272113422, 377432166, -1915288450, -807137400, 1215436534, -358417445, -1052266626, -577662014, 2012690844, 134674755, 708384756, -1212273843, -1508810417, 198742385, 1046395029, 1734680718, 1174913919, 1210109522, 21275356, 246713222, 218980491, 1695726706, 917610310, -328649094, 1582974576, 1011229333, 2071048782, 747055309, 1587202176, -1421989801, -373183052, 1243461635, -1694390278, 598926415, 1224650201, -591477319, 380232147, 934369157, -1749654306, -1634793832, -1023900087, 2035254540, -1261166846, 1338318950, -714408842, -1656172203, 302595205, -1053452365, 171679623, -652685614, -19566656, -459710300, -1859205872, -767582528, -1918634663, -1924246265, -1404386846, 1248811409, -1814381698, 1022693244, 184920350, -1410209676, -1949041980, -212276917, -1263738504, 1584568029, -670619972, 1123208715, 1955248019, 1435735416, 1274290544, -1179838208, 178389194, -1999559073, 1443468380, -1902162159, 77982553, -761130758, -567620678, 1056961955, 768725458, -593064237, 459687547, -757945373, 772106795, -1750805926, 2134886862, 86549012, 1033850229, -1728075689, 797530866, -633572855, -166204733, 1114833518, -86510945, 42139936, 1608344739, 2083886546, -683378029, -1381312326, -642587576, -258400349, -1415944693, -909701169, 1718373190, -884698817, -1780442315, 1694170798, -1165645720, 1050377415, 764968050, 157455762, 1354832696, -99446953, 197232336, -1928280298, -732264467, 195420657, 1292091139, 107588043, 644933953, -238395363, 1286494993, -317453224, -1480849903, -975344456, -1723342660, 1849038878, -504521605, 2111826790, -1327297508, -1198995878, -661864920, 970088891, -462396786, 935800181, 1604184647, 1272618480, 1129462287, 1120527725, -80312733, 1373355348, -82602202, -170154090, 904944865, -824598764, 50106864, -1575746423, 1982001981, -186639884, 1079367426, -1546792998, 1037552682, -916463911, -1732579475, -1982189683, -562431391, -1399041612, 1167194555, -613441593, -1494132726, 884699864, 440058831, -482886844, 1965236987, 1421332297, 456838187, 245622077, -1816697389, 860554632, 1515263392, 1273026168, 1755676644, -1953770724, -1146481658, -529795429, -199804616, 134783111, 1068344713, 2067764099, 1115016531, 1149382456, -450623380, -1301810880, -495337154, 374165796, 898938724, -52041102, -2097890294, 1394957054, -818058377, 119858088, -1179865759, -1239753373, -1363633618, 361176315, -1347554684, 1327084262, -1491830806, -23085090, 788093643, -918805891, -1761195606, -744092872, 70258795, -436623656, 76999637, 1432044529, 811334387, -82081722, 1407809206, -1105921569, 1829326895, -738778386, 362716285, -733697932, -1835524546, 1575033430, 140981918, 709578641, 1929264622, 538558376, 1422541471, 625085902, -286900733, -909368651, -1998527722, -15718913, -289175553, 1681534900, -1050744280, -713271011, 1883432506, 380812810, -1985206677, -263520287, 1621245323, -702994589, 638460730, -893804083, -625542394, -214055461, 513069996, -198690636, 1268797061, 1411583824, 464205685, -1690888483, -1900110643, 719005179, 466424004, -202731511, -159411521, 1592937088, 1184805921, 1178041870, 1421856281, -1223230877, 1063220, -817188027, 1826358219, 544104404, 413293264, -1535195463, 1690974017, -2034254414, 1669858858, 2108677627, 1619436495, -1082647262, 81686028, 1983669402, -315671582, 550850622, -1491772871, 909797041, 1919236325, -772706272, 516853203, 2032648470, -1489687680, 1607692341, 1907012249, -107321302, 1237603481, 1476601832, 2066087834, 1362828793, 73810402, 1223330595, 1417866728, -380288546, 938969496, -645425205, -2120996810, 1632049368, -800537281, -1365220498, -834855538, -1678525958, -478059395, 819098112, -87896315, 844291226, -1348221749, 1205535085, -45042389, 202025078, 1763344880, 1284855821, -632698598, 1628920359, 396009172, 630940179, 1699772878, -1819330082, 1480032269, -1093655661, 1242330732, -606868093, -595693027, 1305575320, -2007270969, -953571185, 1869966322, -1614661393, 442802060, -689893223, -1289817101, 1309978261, -748846982, 1085284788, -749041392, -1639050961, 1808071996, 1447455561, -976258620, 965177093, 631116708, -1689190484, 466492502, 1970107624, 423822509, 1936558051, -289745497, 127872207, 391939928, 295007243, 1097840856, -1357829574, 804601648, -1304307727, 1229786151, 320867386, 2086734158, -21678572, 295007024, -303370105, -2062114071, 854898654, -1553993306, 1035469006, 482651121, -1698087694, -1947274374, 52397322, -651453147, -982695983, 1274918542, -523350474, 117692296, 1888416519, -406461144, 505831547, -1239861980, 1997085061, 1915731352, 1206499661, 1582437135, -1365939178, 183291211, 1671304403, 756094406, 1895231192, -579052068, -892458735, -1625461036, -1078430545, 1502280965, -1625237631, -311203130, 1403010685, -332948702, -2115411391, -1628729448, -406944016, 2136716290, -1616704155, -973158642, -135392569, -1199024799, 120930594, -1893912851, 783145940, -1905719039, -1213483744, -1692142996, 776070440, 1915129070, -1541898125, 1581052293, -1328321409, 2071420301, -1268858591, -909137906, -534437860, -591124961, 1034339096, -1053299705, -1963124010, -894345027, -594487354, 1248834818, 1554965726, 1186794860, 1491629766, 1521713488, 643970967, 817868180, 521189689, -1356876644, 1491938279, 104161331, -586842964, -2009045516, 1794784699, 588444589, 1422744009, -80740134, 201419944, 1204092197, -1792603561, 941441409, 500971046, 1162357084, 1536128731, -886168528, 419005948, -1929224775, -90534622, 234102163, -1286828647, -1372787353, -1025412972, 2110371614, 820075272, -307751254, -1191783933, -1306792459, 181126874, 715198771, -1808643290, 193672931, 2015341266, -293096440, 61508361, -691531887, 473223884, -700038558, 2112084200, 42221929, 1990703492, -2029844896, 80858307, 1001296273, -905276563, -1352156037, -2134869929, -240429593, -1980115166, -503693174, 2026735868, 1552385515, -1558213044, -58576925, -1682710029, 2108590878, -1417204409, 1470569908, 80839851, -1284736557, -1970391274, 1190088966, 722179651, -2016171738, 136703346, 682595619, 2093756087, 712355453, 844764741, -1001138071, -838302346, 1822010208, -1366220285, -2087841457, -349762751, 1809524446, -473942088, -1316403093, -1626633455, 1067423771, 1092251102, 872017972, 1924602042, 55707018, 513146797, -1372793655, -649311289, -2031204088, -21342252, 1868778127, -1691165771, -1043262686, 924818292, -1948107921, -246789196, -59687611, 797198693, -2096922535, -1402150525, -857461785, -727617160, -1365371755, -1032629461, 257098640, -666635606, -1926153864, 1992616309, 2133995389, 318440905, -1226942585, 129513621, -1365245464, 476861733, 508296363, -1209112535, 1697800082, -2018454127, -246097702, -1087183189, -1994400814, -1180602649, -468826625, 448334325, -1064689211, -1609030362, 226291401, -867661425, -848179707, 793496460, -1891152354, -147339077, 359022249, 62219495, -1850315087, -1874236624, 297015664, 2049999509, -1633399673, -757340474, 193261482, 2047096240, -1413559806, 2097983643, -1885637199, 166247027, 1719364801, -803299335, -1603418535, -253536180, 1948822470, 1864133630, -1087599775, -1488788414, -1919655734, -1960949336, -1954172747, 451614076, 1331057299, -355463959, -1428376778, -1051453349, -2107070685, -1642464425, 1360030549, -1766293862, -1524363138, 2084445207, -1347031319, 1724415114, -644783607, -133499674, 2077664047, -579321328, -379514763, 1272416183, -552721483, 943448513, -1426321076, 1966819593, -331483823, -158351323, 1489965178, 1599757942, -354738437, -1151345711, 1486213439, -239812067, 670082144, -520651356, -1391852736, 1881310330, 1217957103, -1278917284, -380794787, 1749445789, -1205991878, -1408821148, 911113148, 1930018359, 747369946, 1238802448, -1265925880, 1505384940, 665205379, 1966510017, -1847663633, 15830103, 796606541, -215115308, -303798550, -1552834931, 2061449943, 428200913, -1724529156, 1505177827, -164013591, -1357175370, -645261248, 431115646, -2121578732, -425901992, 960324668, -358101697, -1888000585, -1223458831, 491688519, 1805427563, -1687706861, -575671417, -412141996, 1271909725, -689529754, 1865109575, -1565437093, -749381599, -1683321436, 2115555777, 1331237548, 1503020046, 1486082293, -2075511425, 332813046, 828789209, -891112230, -1823234070, 2092027673, -337984958, -1741042896, -794639547, -1286882898, 1326224494, 14304483, 41291186, -193316453, -2135387446, 1902716760, 1730568634, 1218465722, -1362469841, 1320589565, -536142971, -1363633135, 1492395128, 389369350, -29665873, -1163020726, -2135980248, 1329046724, 2032000260, -1081545314, -572384201, -236935542, 570620028, -727694162, -1308195085, 40687633, -157232097, -1702817047, -1347038746, 1655971833, 1636667446, 145979628, -1938004298, -1756300440, -702886528, -742506795, 641049730, -43633439, -1159874061, 1800746792, -1418904638, 1707757146, 663993390, 1363651458, 1102340146, -1606535797, 1130441104, 1026300494, -614896235, 2066524690, -1512640445, -489841177, -1666596027, -1155956487, -2002905537, -735565120, -1792982442, 1974848314, -783239446, 97597095, -1103018888, -1665963410, -787897354, 471170639, 442491712, -1390261661, -1237027927, -332267282, 1376851114, -1472372445, 1158604146, -1103005429, 673958003, -612478166, -835358871, -76156452, 940728138, 402101457, -421039376, 1336301955, -579621540, 491580495, -751673979, -652822002, -1434213468, -167125788, 947909263, -849248395, 1904203902, 1379999058, 1005625262, -618534681, 2072394004, -204670854, 631936540, 545645835, 661047203, -41636497, -1807425090, 816962143, 465566970, -2135670077, 589001261, -1887711583, 701992554, -1478439691, 708475257, 1624378146, -1927382317, 383671480, 917947894, 1072563485, 1489344785, 1455580366, 1386980186, 1210971193, 1021099529, -228086750, -882862685, -1743896810, 1608969607, 708464549, 1355892726, -1319560763, 936899237, 1738017867, 1884327941, 340026516, -793809165, -607647597, 1326458551, -1695132545, -1816908904, -1905360191, -727834704, -1721090620, -1046505218, 677571702, 1034071926, -1859464108, 1693365270, -1257778190, 1577691028, 672505053, -1266616440, 5011090, 1874805200, -866297410, 1264128823, 1892491672, 2002983834, 256076505, 867209713, 1159060429, 1535883889, -549095709, 2128274775, -236061973, 639553702, 613174, -2001419453, -316125196, -728668415, 397336129, -332816855, -1455544347, 919448777, 1291586533, 1996863600, 776793221, -2119763211, 1080093840, 1944277147, -1829085672, 1282268705, -1834603225, 1592582234, -717521192, 1100742416, -36082908, -125729951, 291339031, -582186054, -564571070, 1248935106, -1812852123, -815667027, 212449109, -1431248946, 659838453, 2007961578, 1117364900, 204450757, -1444113575, -361042251, 1087282358, 242523240, -766179116, 545835502, 146100906, 1039603646, -359721747, -1891848570, -846259577, -1540331479, 1832805106, 1110869330, -760182623, -1471293408, -1738781499, 1553188787, 2663646, 1848473152, -1375634122, -422085547, -797870357, 272537985, -2060438888, -1480038901, 1678414399, 11613716, 1991012335, -1376813225, 2117777119, -395530941, -592821235, 182288635, -1579324800, 92988092, 1277629530, 1325859582, -1248231850, -225876778, 1258874284, 830747713, -1512577665, -2032128701, -405562153, 864849203, -278050197, -421547578, 63833857, -1684964356, 309800147, 1083541657, -1247984035, 1105765107, 1510369326, 292828978, -986979503, 9674567, -1484406337, 1955163059, -1915908026, 1218548314, 1624813767, 1498765798, -84513074, -871291565, 124830713, 1839549714, -538070210, -1055345582, -1196963991, 2005926929, -1329216931, -2125392119, -1513051015, -269401210, 992999532, -548917449, -729875486, 2034807211, -970253603, 1905490552, 1135214986, -338202039, -1964285793, -947286344, -1443474985, -686695714, 1067076405, -1482120339, -1203158395, 1225038319, -1158230711, -962518885, 963422169, -1242571305, 640569846, 957730526, 1889101796, 1437332328, -928049324, -854322819, -2064079174, 1641827232, 270131868, 483122359, -1033057735, -1361677349, -1505835289, -576207309, -1020172291, 1977462097, 583123432, 1674879598, -746267039, 824136175, 1549989956, -452848345, 1855905480, -1126482852, -1338825873, -1794618204, -272438243, 1419561223, -1735840967, -55175420, -282991108, 590225074, 617893514, 1403443415, -926911123, 957614394, -258834249, 524554156, -858104528, -795765150, 773844619, 2005749481, -1158674818, -276784813, 1736567484, 1326757912, -814678168, 2110416235, -574678570, -103540540, 115281726, -758562847, 960575457, -103170009, -148122386, 661000972, -1642811282, -1583628699, -1709987056, -1971464658, 1428185437, 49075896, -962004788, -1038658370, -1124649074, 1312964519, -1664925324, 439081191, 155464860, -1048062193, 2023664249, -1387628760, -1825257515, -1134089455, -2086848534, -2139720993, -863294874, -625047158, -648324079, -1192132786, -1608052456, -98269163, 139967762, -1776948304, -124706481, 1923923354, -8688826, 489845851, 1647762467, 614487232, -872187500, 1650662201, -1641343884, -1951444265, -1320583164, -622379633, -187025621, 1016566045, -726740708, 375137889, -988016320, 2035583128, -1279139183, 1675875399, -1465811336, -71301259, 1584427219, -496897521, -503421217, -1814150182, -673509735, -2027260570, -1017209341, -1949551923, -603436649, -1650098766, 2052823652, 453616317, -1706400405, -415819967, -1901545647, 454682675, 1607095559, -1165190482, 160872334, 1949903521, -1562121966, 2113598822, 744340310, 1394771645, -711622474, 111879550, -1927916456, -185338881, -899197818, 671389917, -761656286, -181359288, 221985671, 197023228, 2004374998, 1288057327, -1208115869, -2019995281, -1827638576, 1928756123, -1062586013, -564218809, 1151565763, 1620248150, 1316777070, 1834443352, 331585755, -1890710880, -1004976229, -403875464, 664049338, -1453922777, -1544742513, 1236168829, -1033750213, 43606063, 1397907903, 1393237627, -1709736136, 244790616, -1791409651, 1302532819, -241595079, -2142811830, -179427157, -620508832, -1552329581, -970868703, -1655092591, 1193031829, -26409072, 855254296, -804903675, 1835254599, 752947118, 1893269537, 1680242111, 1777035542, 527776523, -674722647, -1231759902, -868847134, 125723796, 583841690, 381391170, 422816437, 2101969153, 229746778, 78431615, -2137460235, 1484657515, -769864455, -1604180220, -1303446192, 1508667704, -1218054477, 67186433, -2112999990, 162718143, 266209153, 1261631630, 111075743, 1054380708, 894710007, 1585717186, -96558975, 1663796451, 1310219324, -1962243740, -1698062243, -879244820, 145943720, 831991267, 431805450, 1329803194, -14247555, -1214588183, -1929694550, -1391625589, 2101124628, -66160381, -839327039, 323533697, 333509269, 712529078, 103193574, 389856064, 989346533, -486037176, 431131752, 1956757223, 1886103614, -526014481, -1531630883, 516454675, 1798016857, -833140347, -1171697575, 1646098251, 1990958548, -1985477898, -81535558, 1191862352, -1285572854, 834197444, 1397340073, 1639332663, 1430065973, -379794557, -298509246, -1251522348, -2037913002, 904117222, -1408239640, 205582934, 562940664, -1184832904, 598367130, -1686955324, 2085809655, 1310784966, 1953936802, 312451543, 1707466273, -1976442676, -1675071780, 1371056082, 2078705449, 1977831552, -609158548, 1418803990, 444152292, 1381097260, 1971628002, 1115550421, 934736744, -649258677, 2022505844, -43545367, 1987324136, 1460183390, 1032840302, 1696512791, -708207046, -1396054770, -512181706, 164976968, 1553578109, 1228043084, -676376699, 2079491288, -1910590885, -2063817200, 1994580543, -1353617113, 1635061244, 998688855, -1398037591, -842720459, 1887282929, -1150529118, -165604428, -1904916727, -1181126509, 1285287732, 1158164756, -2009958092, 1457099566, 532452070, 668612313, 58656715, -1797231356, 367250974, -232824545, -1724843111, -113868626, -2139260108, -1749673482, -1270203107, 1341829311, -1965046053, 1083872784, -1750171115, -832251597, 1708373648, 1396565177, -1159562964, 439045550, -1494694534, 381327846, 1820831114, 758309850, -1813817263, 44888692, -703827047, 656239167, -760710521, -448249320, 10906121, 1896820541, -1873782657, -183227754, 56567376, -494599363, 186962970, 953736975, 205442163, -1933027055, -1545534919, 254544711, -1722970964, 1932669915, -506171250, 414979318, -781661968, 2109958070, 1061021490, 321387033, -853913421, 1859730261, 1520130255, -542779846, -1321650911, -1785422248, 915327754, -2099140314, 42109804, -335222565, 1772195346, 803450037, 1750707882, -1634506932, 878736971, 1618004039, 1559050114, 1537078755, 804893865, 1052572518, -1541910668, -1491682865, 724376261, 73154129, 1831725466, -14563495, 664832091, -554836709, 1769610971, 385761230, 369905468, -178319968, -964517780, -21024597, -1685264322, -648947622, 474521521, -1478898599, 724156097, -55441261, 1997543846, 70376185, -370141586, -870039763, 220299384, -1903937185, 358904485, -96755029, -954578538, 1414835241, -1104065431, 330669543, -2052665538, -694463559, 647269692, -1701585686, 343278579, 2128446203, -1722269634, -1503087621, -585632748, -118144245, -611766109, 1611220075, -197648932, 658473703, -765787815, -1981209937, 1597943873, 1148191955, -1201130220, 1071336959, 2002958300, 1287978844, -990620839, 393784208, -624233451, -1014283521, -1030507523, 1619180653, -656151544, 236433740, -1940140565, 1828873243, -937066524, -730582903, 1558585565, 2073226899, -1712305315, 1412483390, -313210333, 349990056, 1684646208, 1954072135, -776716265, 567074912, 66177527, -1237174868, 780126334, 2142855531, -725268912, -181604867, 1123178917, -780195174, -2074249676, -1671771639, 1537367368, -1909067667, -1493744044, 2035094042, 1522177934, -1832918140, -1252489146, 14773704, 233376241, -1618617199, -591417370, 1020638386, -1853029308, 915683378, 839980292, 781711281, 1945023652, 476109495, -566473230, -1475595558, -1634974900, -1116848467, -202067848, 1590591429, -2051376481, -1087188166, -1563823259, -384791948, 1732290711, -2069478857, -271269564, 1874794382, 1434414810, -915113530, -391071888, 214772447, 901395510, 1899852369, 1776836007, 1909553413, -531121923, 920484916, 1884920459, -385301061, -1299252456, -1171783464, -144430267, 763761833, 1130251386, -562451698, -600512242, -1346949893, 786466688, -1733582334, -1108770898, 939240798, 203365796, 971172362, 604830554, -1317825366, 329004798, -2012544300, 2076085001, -952642912, -705642475, -70805934, -1479617793, -1224062081, -1618131677, -1999688587, -1762583773, -685700507, 1792908971, 474078489, -1225879591, -308721467, 1322584832, 466224319, -66171443, -305746010, -115132942, 902241580, 1136454523, 920164583, 1387712197, -986493517, -641810196, -656825495, 25795825, 136806985, 1457319933, 1740192720, 366355560, -1895309920, 344042597, 404766370, 1419523412, 1607642031, 1520363953, 1952396015, -810068484, -1714440080, 1070252175, 1103178789, 1733289730, 104428601, -1568418676, -1141983307, -490698823, 41453275, 2084936015, -424930427, -1435899527, -1714787648, -1527450875, -2007705387, -125410653, 1968165726, 895404228, 1628492460, 1817538954, 1238086764, -1690383712, 1043953368, 1963162583, -653326207, 1219153806, -1449075530, -1416945257, -1569126370, -744939058, 2121573271, -888104887, 2076722206, -1236749001, 855692756, -544045203, -35169229, 1267708969, 1542595836, -1294230868, -1685972444, 668067284, 1206392359, -2004485940, -1509910755, 1143852960, -387878069, 1163153937, -1355937044, 1117103498, -1195172325, -1544985933, 1343229364, 1906212157, 156517042, 771231270, -1859015703, 1924587607, 489019563, -666054200, -313878686, 1924916056, 1759320689, 408393523, 1669573165, -919675424, 850027654, 675457499, -376064529, 1857471502, -429101056, 1099370455, 1625393185, 827063336, 1366270982, 1081651710, 294389729, 1108067690, -1838028856, -175417041, -997640294, 1907604134, -1410218924, 1924399302, -437758689, 681686457, 749404097, -889834453, 228891393, -789430876, -1791511545, -145978868, 542515153, -1332836794, 58750939, 1004459629, -1286847635, -1003670100, 1205446832, -1131425177, 288529616, 40956925, 1173043600, 1410480708, -864359196, -1688380607, 1709628909, 1290232148, -804915982, -1684861551, 1091308377, -622526628, 236398936, -104621426, -1795380690, -1813062403, -534320563, 1997427622, -887755502, 234330777, 1815716174, 283443084, 981105245, 847320505, 134145051, 1104181463, 664296143, 233901865, 199814895, 495447249, -957498405, -860805645, -931607891, -1662911981, -1049207804, -1935482130, 524519332, 836736174, -671817808, -430620145, 363347498, 1263481007, -1815412656, -1784647114, 86982393, -526835549, -1272168523, -1662192740, 1426870337, 1455951994, -1795451385, -388544963, -718817703, 1153193575, 1731644373, -643125909, -884654038, -1368852485, -1719284202, 1059467871, -1482917578, 1036591140, 1968813191, -1489105513, -1801728017, 776272150, 624726940, -153140014, 1553015129, 545079730, -1690943530, -1396777724, 35747728, 189375293, -2054146387, 278429119, -1158266695, -694174983, -144387501, -1209133348, -1299575804, -1292082277, -597900422, -1634759092, 265578740, 1414028287, -317914835, -1151950692, -1969609177, 1773540874, -647864361, -1683502247, 1268809067, -802729447, 300374082, 1831455874, -1901292061, 1526838288, -1078691244, -2001988920, -1700836164, -1112629511, -1795086410, 1615272282, -1350344578, -932908835, -1194580649, 1725123725, -1120372422, -479376300, 1445270088, 495418964, 1482385629, -1565625040, -826394297, -278429767, -730440537, 1531374246, 1123858877, -296796107, 33102633, 1153252037, 55370069, -1095603555, 1650015519, -1994260730, -6647452, -605394533, 756554211, 252231107, 37939678, 2119598689, 479047728, -492570442, 1237330462, 1420533573, 639256149, -1359862591, -515453815, -1606621974, 506058514, 1476872720, -1302683904, 228439707, 378451835, -1852025173, 1991203170, -681922926, 760592910, 131006721, -554742344, 1268047320, -162207467, -771575551, -898892961, 1461501240, 340850603, 479274052, -1261608101, -1548741291, 670951378, 858834133, 475276411, -1948458339, 1033882116, -1286781143, -64574492, 1123765078, -1562629982, -268427460, -1270121685, -585909560, 1164395633, 806284152, 997712512, 272409817, 264152861, 1542855366, -2089311147, 1315092929, -660540489, -1605924968, 685790185, 1628890004, 389319378, 936100725, 1982093956, 753159860, 761053484, -673210607, -656373270, 555214976, -22421927, -1628588149, 237363585, -1860554263, 1920386198, 466108085, -504892530, -614394870, -488273725, -1144297025, 1992972914, 152101152, 1552614159, 12554277, 1459000257, 29188035, -753938962, 1815986891, -8698094, -854886590, 1677134553, 1923597443, -1507944299, 631721161, -424494156, 122153911, -1373963599, 294348026, 2032081646, 1184220846, 706507072, 377765096, 271413311, 1919386648, 73917469, -233666433, -2118250055, 2029203988, -1664407824, -1192292954, 1416452896, -1508582741, -1505994448, 2139466953, -70604999, -127519432, -1835036008, 1875300162, 1220418516, 108716759, 784418215, 417950098, -1591710531, 733607383, 1843073739, 1769404324, 20942498, -1474419261, 396556427, 175493302, 1286628382, 308843604, 1778920771, -2009455319, -749166997, 1231086695, -1085969187, -1308913992, 1737719973, 236322803, 1575428509, -1367037218, -1608698631, -1169923860, -309937679, 1918073280, 1334488116, 1781916975, 207499158, -574531011, -935113410, 810836167, 639589167, 50436129, -1920827706, -965102567, 72240177, 2111086777, -576155420, 1577532309, -1763343198, 1275940643, 999457006, 888795433, 165223103, 457275065, 1857865906, -2144558532, 1985508360, -52207512, -440803358, -852447724, 1941830964, -1563375715, 189763480, 921850742, -1126333541, 2058054390, 1928784554, 261725760, 239536008, 1439746205, 1227387822, -384220839, -278674836, 642577756, -1687616014, -745039710, 790165175, -1748411471, -1335374794, 1657484758, -705503409, 313374355, 2134330854, 1955245393, 1524720562, 624659783, -1780644972, -1122067684, -1458321639, -2056146221, -64407136, 1454747978, 1917393343, -1981667193, 883589705, 1765562996, -1262765637, -1403609158, 197449922, -1021344521, -317406146, 1668822306, 1397866059, 374857927, 379712411, 420573919, -973405780, 159432609, 981246881, 1731691509, -1741153085, -485457152, -1497787545, 23810479, -1918474796, -438952804, 1909137895, 239897665, -2145624374, -20615969, 12712263, 1020123460, -818427322, -1458094612, -980279017, -1897069489, 1682615060, -136900097, 97443572, 238314109, 120163524, -2142994668, 189895269, 939474069, -593192060, 1325917327, -1433538924, 1822034445, -747580059, 135266265, -1641761091, -413191853, 227978514, 1956740587, -1771672390, -1969868343, -451363637, -998127139, 362064117, 485093671, -2078219858, 1299481872, -1243232316, 1819392471, 1997434254, -1724636569, -536727547, 425490150, -456969815, 2087181935, 1630646434, -2054680607, 1251495454, 1303962072, 674952199, -1778833107, 607008922, -590097658, 56179754, -671892015, -923190505, -20379508, 627694323, -1708527033, -626595246, 623796936, 127825901, 674429084, 1832562578, -387898006, -1141717303, -924486098, 1327591123, -2029244796, 613836265, 1994090396, 1639863720, 1562643328, -1375016998, 1622928059, -367518563, 677954679, 1096209989, -1243103735, 1496740705, 1211503562, -1146069543, 1411086413, -497104841, -1898020604, -1970507109, -736245640, -1163740898, -1929371075, 2098766211, 74937535, -498651703, 3073787, -2121292911, -42423828, -1668694641, -2067777074, 1103411274, -393311821, 1682357592, -106877137, 1115426736, 359178658, 736328994, -335507488, 780402377, 1167243877, 1979193379, -522193885, -384445656, 875945217, -1481912921, -1328608013, -1255164072, -196368006, -1929933533, -1586763126, 1162816630, 485382196, 1528357100, -308577654, -806763922, -76522574, -811734863, -1045073126, 734252550, -2104435323, 676237229, -651417323, -646896038, -1433473888, 1332082581, -896110607, 984863955, -470726901, 1772083393, -937207529, 94050651, 34188703, 1071750290, -1675929169, -879970722, 1102760346, -141467584, -87789929, -1492654404, -800051823, -1440239780, -1013218264, 482878819, -1408839676, -411008855, -579598135, 1002768808, -1670369703, -1995535386, 1935113617, -248862359, -1036510987, -1015534771, -1145341618, 2053545994, 1913533448, 1343588549, -1206918651, -778369172, 592082995, 236008859, -2084830759, -1612045971, -2093551912, -1468841047, -109682873, -47248285, -511753390, 550303734, -731167133, 691356674, 911745359, -1030514376, 1109980764, -1894150743, 1212634335, 243599813, 120070147, 915856856, -686122586, 268602898, 604394670, 793028129, -1332300656, -223035669, -1988188263, 1319626958, -999882620, -1519865386, 1574156417, 883310693, -1425501358, 1278302138, -795811207, -710778468, 1223760181, 95711749, -1981444665, 1587718328, 2141869274, 1441904988, -427325937, -1243071034, 1740758178, 1715307198, -1519922286, 987285878, -1745298430, -733519781, 425014291, 852395407, 297994704, -74829045, -853450760, 2000064654, -2036360928, -1072516027, -1852849848, 1313412711, -403445506, -1517844342, -183690757, 724751793, -341773044, -740243471, -1977948397, 1351679530, 155763470, -1854189217, -1694682771, 1552044341, -188960153, -918112927, 2013595760, 1683003406, -1721299672, 20052071, -1109167159, 343815449, -232707771, -2058915913, -1558490614, -1591226799, 615675657, 235279945, 191741014, -1909365817, 611006000, -129846336, -11608141, 525227009, 522051269, -763942244, -1841077034, 952234115, -1571896316, 84119762, -143837121, 1351799055, -1381738535, 1867131139, -1701286103, 1262702823, -1113032911, 1533023028, 258709410, 509992815, 1965602068, -2087868505, -1944238881, 1769997190, 259211270, -1815445291, -19537248, 593189588, 974482164, 1702525650, -1619265777, -121157259, 1235812540, 630918997, -1030293197, 537087381, -1533346907, 1961810627, -58917241, 1546528653, -498818264, 745553157, -1466232105, 1638480739, 842264628, 632834873, 978667854, 639368850, -77945505, 1924266737, -482633012, -1174424951, 955948571, 868922209, -465091587, -1372756659, -419891337, -1055801351, -1269672835, 96599694, -1538099508, 385042042, 1241052242, 505805242, -1078712957, 1567074778, 982128022, -1517644370, -1653627475, 1272043070, 1005895716, 1915171993, 725175261, -1340217337, -1209198052, -857933913, -1502476943, 70124665, -1453131831, 384166101, -1546718558, 1648840066, -1283916740, -2050736670, -1983990144, -1964037099, -582792080, -1504251550, 1236498916, 1698272655, -798063547, 722892063, 826931947, 881212407, -1081402317, 1787832099, 607197063, -1192474071, -392429178, 2098262251, 1674466011, -1687051441, -256911339, 260139802, -1119037632, -1588839470, 542300096, -1460115169, -346292993, -1640805847, -1675396569, -499111321, -1516654286, -678980539, -318261838, 678509438, 786638534, 715632466, 422288127, 1958221296, -508217019, -1428935045, -280928868, 1230316332, -1057959289, -606590714, 488147913, 1877497372, -448082052, -286208576, -1648510589, -1053780081, -402038718, 1702430171, 1996288586, 1041002668, -870110271, 145355956, -635208697, 926508402, -1094778328, 956771991, -2124741889, -1359971074, 1502441772, 439556858, 155158543, -9594359, -83273509, -970381739, -94562873, 1792410358, 1262866958, -95586148, 1168996364, -1485273030, 660605961, -1188113638, 634223207, 1682459735, -1950690050, 739951621, 1519964211, 1993699284, 999074105, -1996571137, -721265985, 82727419, 1529560163, -1750659906, 991579341, -290692596, 2083500498, -1283684989, -1729077296, 1545187757, -1298894172, 1831087869, -881109167, 575130450, -1913607290, -61949298, 2010094569, -714679194, 558792297, 967304812, -1123269481, -1596945385, -1109351349, 1895591345, 318689825, 1397433692, -391813334, -511613946, 36250642, 956536266, -1450486043, 1118611912, 961001542, -224820292, 236754977, 1669009975, 567300480, -1716107598, 247142342, 578743361, 1646624028, 661097012, 631768558, 933408245, 2066638290, -1738912739, 181578766, -1934960927, 853010174, 420197436, 1657603408, 653904326, 1131156892, -2132710263, -262859326, -1703882011, -1477328830, -1093995254, 2004502683, 1302675696, -194392542, -1342271007, 1214853497, 901989433, 477124505, 1836439881, 1891817291, -1271128076, -1277053163, 2104229591, 609811596, 277456666, 661562613, 1340386058, 633372210, 1181184899, -1511659037, 1666582903, 2047183983, 1553840917, -1818929733, -143314546, -864310576, 1765850261, 244206586, -628808996, 253568677, 783136055, 1530732101, -183376589, -835175088, -1190579117, -1105156991, 1929556277, 1192265944, 918365084, -1920161479, 106846216, -1348459691, -1620402383, -1099195686, 14001229, 1451575568, -1029992915, -178099414, 336924746, 237748573, -1794614813, -1056909218, 881578480, 1899911839, -1219135492, -1804028582, -1212752008, -1715327677, 775557380, 1772474381, -427126348, -1574311408, 392658413, -749242003, 1663421606, -45956446, 116721459, 1173928197, -1104004558, -930638362, -1249368237, -121203986, -458191302, 456201214, -1392538236, 794278046, -1744220863, 1167892990, -2123673768, -346352731, -1947476573, -703590904, 1249359878, -1505160660, -919159761, 299694577, -2084808318, -1791541798, 2070040372, -593538099, 398296808, 2132294132, 1520635373, 1255010021, 1848258184, 1662780949, -2055319956, -1006702437, 1119456520, 1517368419, 965174050, 690614404, 2068112586, 119151396, -1165258089, 1076008562, -1029294402, 1665932447, 461717297, 1912487619, -1809172332, -1216127932, 353366714, 2097494844, 448573707, -1507493030, -1580263754, -253303299, -800661515, 1095928204, 1221298293, -575421759, -53833977, -1969492095, 1924435162, 1290384265, 323533451, -717658462, -103686097, -1259368639, -987722355, 233862898, -1241920424, 704005203, -767032630, 1624511415, -1047484936, -434800411, -1833355152, -981146978, -37944178, 531390876, -1458059973, -257134033, 1806952735, 1186589178, -541913368, 1920259167, 1152698596, 1355204409, -1537627396, -427904566, 1107337069, -545908875, 1884974811, -1447395787, -397564951, 527514798, 474734836, -1826692801, 1615648963, 660083053, -1137655592, 1267770397, 375333812, -748676886, 1775937587, -2023709398, 2096150839, 1075982909, -521720286, -1026797773, -1046246632, -917442579, 1157189549, 303826277, 2087156741, -1642826785, -11354986, -1198474072, 112518545, -1427819945, -101375718, 299556977, -1637678271, 521929487, 383914355, 921860577, -2115970395, 1345058567, 1799164586, -1574244474, 624204561, -499311682, -1789423090, 1427375913, -371132364, 1850429235, 1530332004, 504316374, 684689903, -1052715996, 1857120335, -511594536, -1318123027, 956742273, 185845579, 1806759295, -1843937, 1183435445, 179168376, -2014295604, -875430251, -1969317551, -168525281, -297772681, 759559038, -610925680, -909306108, -1738802677, 1334144199, 2124285580, 1360655169, -1337780848, 2058718416, -1541340758, -1334770844, -1940866760, 256494182, -54538277, 790088974, -652652461, -2124809782, -1476520537, 1312559252, 764146693, -417169660, -811891740, -294153479, -1585825591, -1397626404, -1536169471, -1761524507, 401737431, -592893152, 1735531234, 1520550323, 749639511, 881895854, -867612846, -1351339760, 1825645107, 1265789436, 1629632619, -2023154669, 642674312, -1319309599, -1126289874, 1114692144, -312486321, 368404994, 1356115124, -404385652, 1166388379, 1997557084, -1221217153, 128484785, 1148321786, -268993795, 507986079, 1841032232, -816747390, -1511794585, -331354651, -158783694, -686611664, -514916339, -507135372, 359082736, -1131967421, 831080758, 1650893300, 770186901, -1681304112, 2101966594, -58668207, 617764087, -2014677069, 1829780586, -2051777026, -1422299632, 1345367768, -89518592, -2063166130, 1533303735, -468816370, 1574161371, -1135672489, -1116928699, 1477688491, -496189914, 1743341285, -676324536, -2118091587, -1448995751, -1177543703, -1374812674, 1166037366, -1114210152, -1585041718, -1725569831, -548209293, -1035563144, 1124070547, -1770439093, -921999102, 342218704, -1901022978, -1050948723, -808001034, -1295019415, 329336127, -1797686712, 1830449096, 230556435, -374349957, -308598891, -1240453397, 531233861, 220555569, 464182858, -783651406, 1109931726, 1392534203, 1279444409, -714527281, -1987020098, -195273400, 1283316886, -327372964, 1038726563, 405047542, 583088801, -1275345193, -214853470, -847478350, 2006802805, 1527274766, -608943092, 1044392056, 945076278, 360411853, 1238885541, 1299273154, 1946953744, 2118943089, -1795922690, 1049019466, 709696715, -739739274, -1614914414, -1601825721, -164042777, -1946447439, -125749115, -562383748, 604030295, -133989693, 1899126298, -249481281, -465025204, 2005805553, 1158354294, -351543157, -591908768, 376401463, -1305092680, 696647551, -1860845026, -255043156, 712793539, -188885497, -739499555, -813421737, -1861095662, 1175488086, -325801584, -696328400, -2087079972, -283418569, 795618469, 118519711, -1287942989, -677115270, 977324957, -1059772495, -80784757, -556306448, 253023301, -507242494, 1186776915, -535881570, 367603063, -781121740, 1097316080, -1695007702, -835293837, 217911448, 933799168, 1965305199, 1651112043, 2034964500, 375299047, 686414164, -531375183, 1146004774, -1890918660, -741744209, -1496574516, -1991386813, 1339247136, -442958282, -1305107797, 2131790624, -509747091, -217151152, -993704011, -1310006207, 926461431, 614049832, -712637391, 2043394913, 1381281488, 250086187, 565025949, 271247610, -3435031, -972049308, -549913277, 355145714, 740297334, -1327048989, -1617919937, -885449092, 1774354686, 319562745, 1084102089, -1609751835, -2081418235, -818889323, 1602426153, 1991467225, -18597953, 1986986109, -245585632, -374265233, 1032278358, -1417786760, -1434369484, -292857495, 656958668, 374163765, 195401852, -1846751542, -914323889, -154606582, 1961481497, -932197100, -1776232970, 118020300, -517157531, -1534314983, -2115604663, -1540366395, 1609695996, 1144819618, -1665245191, -2126404195, 1198625931, -1295768359, 1702321964, -660209452, -404982628, 2118426541, 240526082, 728325287, -107785483, 1430621119, -1409246786, -1134025, -672489043, -1659032385, -1902359381, 303727700, -1128985960, 520149109, -123737019, -1706621965, -1000603923, -1880822135, -747211207, -146322375, -1784050168, 1701395872, 225245658, -1387624417, 401234767, 1340818377, 1038778429, 1796166597, -330738112, 1103967375, 771169441, 1840015339, 634844821, 1731655445, -59437747, -1645552843, -364138634, -122200222, -1687299454, 1479810247, 210110998, 879038216, 1785546360, -216148582, 148368, 1554221254, -1654498640, 122329290, -2009396827, 1208441534, 51950380, 1869983469, -1846191812, 1666611990, -2115420496, -1824926768, -556586950, 1055126568, 418672623, 1265911451, 1895223435, 1905986194, 961843145, 538011196, 458827451, -1231477427, -766004586, -1013024999, 315647148, -861460578, -1413237054, -13878643, -647318760, 1255545904, -1264199689, 722841688, -1271439344, 582445377, -1992854287, -606447814, 377975526, -366399708, 424808592, 2092711530, -27546008, 686077201, -2112606778, -1131376169, -2048211321, 1070856822, 341049360, 171657733, -2049283671, -333464257, -549496623, 507981614, -1964682727, 613762053, 1984718149, -181029517, -353020353, 1221125053, 465257333, -1152312085, 462344147, -1674631282, -930778414, -745769863, -225467114, 2095334693, -2055297513, -374983739, -1374772519, 163462034, -48089132, -19352622, 81201997, 1890773413, 1721365725, -1725357041, -103952055, -1849832504, 1478997956, -773788001, -1852386380, -1195155951, -1585313684, -977679674, 2052366156, -421529808, -1493737987, 1941977877, -1350605636, 368832208, 861700276, -1999625043, 1354202437, 655403873, 497580735, -1654302224, 2130033004, 1950453444, -1734336484, 835493375, 1849809480, -404385472, 837706392, -807383516, 1856512425, -442915728, 1083276770, -840636394, 254325037, -1926661935, 984437561, 221613294, 49115622, 451061914, 1239354680, -423977749, 1225252427, 2126477484, -1951936904, -1380304456, -286763290, -1125450502, 1858594546, -412811253, 1915553542, -420006295, -638366412, 586548059, 1389199842, 1139556463, 1177973924, -1514601785, 769083909, 2018544575, -1181875840, 5757660, 163301544, 1453108581, 170498585, 1293690129, -789330968, 489402699, -429766106, 77765526, -1510682840, 18399440, 331486431, 853133363, -985265277, 583096998, 1205078707, 487686363, -139347728, 591470597, 598591643, -733958184, -153531185, 978485013, -1086228740, 1676699492, 1233299681, 1363036378, 939467609, -1129464551, -1887538755, 2104894511, -412854534, -678272196, -1936676239, -60266318, 313396012, -383537962, 1095986055, -2009831282, -469566058, 1561517340, -1623937930, 1490340972, 777228412, 102638942, -1791662469, -973824591, -905204757, -1538215926, 817201461, -619985733, 2018432253, -1853542737, 1296961326, 1102789228, -975203462, -35277656, -886247865, 806087178, -1833580521, -369672666, -1361037659, -1839809188, -380063155, -1128326196, -2057471664, -414527343, 744326435, -1967583521, -786742974, -1672508248, 1648697531, -335712026, -1857587607, -339636251, 783488759, 1847943042, -518218781, 1416660545, -1052005811, -886314306, -182878753, -1135411637, -284744307, 1189361471, 681529609, 1709740267, -731100741, 1362485547, 2048220035, -1071347935, 769496516, -1979965944, 1504009469, -1870267146, -1819148622, -878980252, -380162435, 1776540699, -1601020796, -1793172827, -1313686036, -1257228699, -7827649, 376500530, 1407446804, 2097545298, -1646829864, 1145012234, 513288276, 329589201, 913576666, 177086308, 342490148, -1793489366, -1463617371, -1842930504, -1416399607, 777531064, 2105889635, 506344251, -1151396193, 1546376417, -2145430116, -1881339840, 624378542, 639845983, 1031741447, 1737609690, -990127107, -1457217745, 319269781, -2126728303, 1136258881, 1190165262, -1999242670, -2090542160, 1054571774, -1214193471, -712315535, -339767906, -924837489, 1492701688, -1516121061, 1524476382, 811383937, -275640445, 584320017, 1166812551, -511586210, 2122020432, -1969970354, -665699689, 731506155, 397324361, 56579270, -578972728, -1976682723, -1236791193, -934137143, -1656065003, -1862167959, -581745809, -230473510, -244899102, 1339694565, -998061707, -1961436080, -1961942803, -1811275128, -1122585938, -824573207, 635361888, -647872475, 421371209, -1117048307, -1664155080, 126257795, 1359877897, -435988172, -808376149, 1839879683, -1048614691, 893049971, -573972416, -2057189333, -1625556206, -109815534, -1394176451, 313112432, 1127421, 628160017, 1619800051, 210988108, -1990427032, 1676242088, 301480495, 1091548214, -786048556, 1500130099, -1097668909, 1724798146, 1004270113, 767649524, -1215671255, 1949743555, -1260064570, -1067006355, 788570830, 172498430, 1771689443, 211062919, -1649290782, 226283035, -41723288, 2133812747, -1644777492, -762582639, 415910481, 425642319, -1355117685, 310093397, -1753293147, -909825124, 766389083, -794573338, -1374365586, 61861276, 1233103447, -1338203064, 634281417, -854553685, 1653034236, -715667890, 939119347, 975464245, 2132392118, -1045124316, -1007491392, -641968673, 255653192, 590425933, -710368471, 1396580427, -1479856612, -1936374569, 1973177628, 823848461, -2103033572, 1551068267, 1845105870, 1566958904, 1828453281, -985669849, -902228060, 1838052747, 1164296367, -709326576, -1817544757, 344721725, -176593984, 776596186, 1155283848, -1507464126, -345783873, -639868677, -999217565, 296833947, 1850466074, 404463259, -14033387, 1930144341, -337569393, 998643263, 2058330114, 533704157, -1118904055, 112714687, -1459272247, 2127588604, -997028648, 1656701586, -139676436, -1269089129, -1541936547, -1001029615, 643542565, 2087543964, 806260909, 740245720, 744290666, -1621884770, -1435643989, -101016536, 105651042, -1084551688, -755833643, 139230310, 2063333819, -1552177760, 1678618863, -1885439536, -2114053195, -873592295, -1437361449, 1924005244, 1373086452, 1862941917, -323002107, 379686408, -2109888180, 1130144760, 489513756, 677092078, 1168907104, 1710927717, -1298450904, -1355812233, -1351092279, -2016659, 1524601483, -1095130948, -1764038628, -160147414, 125251995, 1332346072, -2096668956, -1525603178, 1458416461, 2113603607, -2115448331, -754609855, -103932522, -1253560929, -1472832596, 1957478146, 1807623439, 2015356025, -573372503, 1424326079, 1553664727, 1927798838, -101404148, 1504068710, -146509987, -1170877749, -535733828, 83018628, -1250775101, 2127131918, -1985058224, -819978936, 847431357, -1156155365, -1656734379, -1520471863, 2023545044, -1522721706, 161840654, -872159717, 1875745424, 1122755553, -371649762, -2006231327, 114225914, 37832641, -242410479, -2080239963, 1905635511, 1716389374, 1510137228, -1502148562, -485640457, 113011243, -1203761345, -1920948497, 1518439549, -752814026, 95041229, 192636017, 1587740329, 105057400, -1220582241, -1992052592, 359375265, 381308554, 1751132521, 1991245290, -1796530588, 482972628, -147788521, -780548828, 1511546326, -497960608, -1617007707, 2086720517, -248001268, 517930528, -131123704, -1652285898, -1364462809, 875502222, 1134731062, 236084358, -1640082185, 1451432515, -1645254060, 1513508383, -153771438, 1512002291, 62541099, -1129723036, 344664400, 447224130, 628746882, 1597155795, 568104140, -227946753, 23115489, 1452435219, 1510616020, 829918840, 1057516287, 727769113, 898601957, 1799080024, 339383012, 397715985, 310143277, -539924291, -950419938, 156486241, -673174785, -499139134, 1391455324, -1160484106, 400463856, -591586666, -346836006, -406377571, -1817804092, 768670893, -165261188, -1239401919, -998658907, 614999017, 1652917209, -865086425, -1230267057, 1476221894, 9136401, 1492617224, 912989922, 1240688632, 1657552612, -679117774, 1244877839, -1357030562, 297441492, 659311275, 2036996380, 1220701865, -1759634866, -684516339, 1890663498, -633341607, -1260196799, -1298534519, -230712253, 984827345, 539088728, 400428340, 1781101792, 890821888, 667691209, 979629715, 1563266982, -1867133600, -1924081792, 962170015, -98654378, 136493811, 1943231959, 2041857067, -939439976, 1812239815, -1849974739, 727367415, 741336794, 771937282, -1346636309, 430316746, -980818679, 2061912867, 1171322635, -1538547778, 1936707867, 1807394379, 1178905223, 921701454, 1311589511, -1612973371, -73195700, -994330224, -483643579, -879570438, -1279560252, -784018274, 873792341, 524651383, 2059812697, 451315173, -1057012415, 677706602, -464576246, 68213345, 1925736133, -304703143, -2067956657, -505170846, 2082845546, 1643712714, -1228027701, -2084592671, -1913714468, -114600420, -1664554655, -1489760780, 684419382, -754454515, -940208403, 1903173611, -427068851, 1295487648, -811414823, 23255949, 2146714570, 1251471865, -102330051, -543094156, -2295519, 829625268, -945060165, 1135571987, -1675746528, 1452192588, 1918222916, 72469528, 1215424360, 1121016456, 429979858, 1323737149, 1342147415, -1094040697, -1887068915, 1048671920, -334802349, 1919663141, 609543859, 155044031, 1361187201, -1325711990, -2074745338, -860184692, -532814340, 433408193, -891542599, -1240923546, -1756519919, -705005192, -450120806, -2040180311, 581993811, 1002392859, 919503103, 1221741214, 1851779316, -1154707717, -1122913783, -2089983877, 396596252, 773287963, 270048949, -1603981779, -408618236, 902415911, 1516325394, -388464281, 1134090050, 1882394282, -342455592, -822568651, 1279739962, -1151114534, -548286256, -100651635, -1740700630, 1709100447, 1086549732, 873053317, -1972796244, -870308615, 1979242284, 891793180, 1359487903, 411328847, 609011265, -1853827667, -1805961046, 1915075965, -348758962, -2081041386, 704076029, -398652372, 358956369, -535084023, 351927733, -1473992594, -1939796045, 1203129611, 1129189532, 1647409847, -2078130778, -112745014, 691800057, 645709173, -1558632847, -1512818189, 1453862687, 1867720389, 1023789096, -158833802, 1353754725, 599358934, 597985173, -475885382, -1351536416, -1388925325, 39711196, -1644463353, -268269398, 1387018995, 206195593, -1540209670, -2067981086, -470788187, -1588919122, -622884768, -1426026924, 998711716, -1892590130, -1596551573, 2031460065, -822662134, -396881304, 1123430171, -721332440, 1455967006, 530567289, 1789061051, -980191198, 1530689413, 2079095409, 757476731, 1967348242, -1940825341, 1949314109, 959966049, 1091446793, -462672863, -1052732627, -1035435668, 1581356840, 2056306116, 1198378613, -1961622955, 2002670186, 1024799642, -36271006, 1110943397, -1576715795, -1635063385, 648723907, 1354321612, 1461173588, 391395118, 950200784, -850171183, -1015033020, -1124878668, -59412262, -538098709, -1737229156, -152527865, 478123637, -1276406611, 221731341, 578218605, -1045684083, -346875651, -418574180, -47074913, 1224888982, -1683613210, 593944907, -917708502, -1714707326, 2047908900, 1613277136, 1001799237, -908794649, 1075448707, -1612847563, 2139105851, 1556322761, 256720720, -467780574, -1483878391, 467674087, -745759672, -175393891, -927587727, 922676998, 866932826, 54510951, 2045258384, -92515080, -957266474, 1054686874, -1370304379, -1702646248, -1976316655, 36698536, -1827078979, -127581115, -1628569785, 387202336, 1178574389, 1963155901, -1618066461, -2005134267, 882479005, -773375829, 1726916682, 909279228, 1710958739, -1068554281, 584151134, 209470472, -1546545300, 1988183201, -148476322, 797658105, -769073532, 432983080, 1024429592, 500477330, -2078667619, -1039138140, -1785833773, 1226874248, 378298164, 731543633, 1291976428, -2084530391, -48158491, -1570424129, -704360616, 178103221, 1260485463, 1011589875, 1949294133, -1413219292, -634036016, 1727033718, -945448759, -1088942653, -1100652498, 1537881797, -1946795854, -1159144811, 1303608715, 1271128525, -134330046, -1027181410, -969925304, 1719110388, 1758286695, -117169048, -720233030, -1892372861, 584359369, -1149583637, 728610209, 181906230, -631062465, -1783322474, -556393212, -1364884595, 203478336, -1889595130, 1291027185, -578164979, -919135559, 1617552219, -1249189194, 753577748, -665019643, -424695134, -760117389, 1076895236, -1417083157, 676838977, -621888587, -1347426449, -1397152033, -1966246738, 1108049056, -736475337, -1383089840, 1516560471, 471680297, 773933960, -1513035552, 777801848, -1296700943, -1519247410, -888038838, -1792047118, 1305918906, -130765842, 990806434, -2107928075, -616329736, -1293419484, -49473675, -562432267, -1364389634, 531640882, 847634542, 1773684989, 1900194589, -2012611584, 925450518, 1068021484, 582830346, -252414645, -957061962, 1273028184, -540455982, 1922513868, -1168321669, -575575373, 1140854551, 1290124363, 994685618, -1874809358, 259782779, 1606882761, -697795007, 533303726, 959456583, 532365180, -1980212604, 1695666485, 1760072118, 642550560, -2025993766, 2065309791, -667044648, 21812655, -1303376749, 821813739, 58091635, 895960636, -1757383840, -1658799956, 726969675, -1027596653, -1753100679, 103397278, 2011326170, -907113607, -1327768253, 1242442246, -1136739560, 287921228, -1302312768, -515387164, -1265574520, -593018300, -449556380, 179519959, 650384130, -2021904912, -1761730785, -1817172943, -1749124866, 1399556910, -2011325638, 103374334, 1956547489, -1516598463, -1569092153, -229073426, -1951845098, -2029971968, 1306911256, 1710828247, 1995693941, 1105676289, -2031715120, -1037647541, -1466441026, -1965525157, 2123809502, 865428376, 949064866, 2067493306, -589740607, 1477933291, 1565193421, -1336138554, -2019650495, 155708244, -583846874, -1215314880, 230769561, -1480828177, -1062183994, 1788817699, 1273210588, 897382358, -1287823977, 1053910134, 602586856, -476568456, 400723843, 866644949, 1408964355, -1726156831, 1458090760, 1359887217, 2042753132, -1072664692, -1302331578, -960733892, 21234963, -931805224, -1839836794, -1631078925, 1933245934, -1468806187, -1355122722, -1531713211, 1096802969, 586899789, -837306452, 1825014647, 1289959865, 631599862, 651835723, -2068726382, 189378178, -619260746, 1059277950, -424061072, -821242457, -923662658, -1843993895, 1524386222, -380487343, -247295825, 927063017, 2091351725, -988114952, 2090035833, 663226912, -2013071872, 5207838, 401768433, -1258881076, -1953849883, 1161102732, 1764573228, 310701082, -919109235, -366062362, 287623333, 34926893, 1863219718, -1421612162, -753999120, 1361552980, -1402156173, -666160863, 522906601, 1367406456, 832893771, -258799801, 1824285184, -782428718, 1018476852, 652416094, -1884641528, -1619997751, 1486494427, -1807909247, 1909139180, 384525347, 356634209, 837671625, -2143525917, 2080089547, 688054331, -1569030384, 1422148604, 446566616, 1413652586, -534788167, -77400840, 1978907860, 1481538826, 1445307983, -1800204833, -1674923894, -415990547, -617360435, 1882086888, -859081322, -1883274904, -180443830, 998100047, -1486926507, -867288751, 394710027, 104606193, 779106159, -1962087583, -2099502285, -1159883248, 507835510, 51190188, -852565964, 808765573, 1258058711, 1943010626, -19186659, 1673342976, 1148839701, -1163144175, -50825315, -1975191022, -694587087, 1393172377, -1449501502, -1818729884, 1213671712, 1412060183, 1215122650, 1670675057, 50019193, -410236121, 69561722, 1916799209, 1688054468, 491645898, -2056647725, 555705961, -2079553240, -1813705061, 454344727, 2001980006, -1313608519, -81279141, 1697550149, -1789394807, 693641989, -427375117, 550424424, 93442745, -39685984, -1337228283, -1227410060, 217838930, 1146850572, 1187321753, 1895959308, -2076054732, 198171077, 1770213146, -58998731, -2145163086, 1962159349, 713932003, -619931781, 1544414791, -1171884131, 2142445488, -1059215976, -1250005428, 1145173646, 1312880219, -864593854, 253744687, -289062535, 1697954109, -1657218006, -1875380842, 881857193, 90377928, -1407573265, -1701867711, -407109630, -158367230, -201217868, 1438822396, 1716657745, 596103999, -761736104, 1772794023, 547124868, 667662255, -1910248741, -884780388, 18652916, -1230773149, -1712801724, 1882334082, -1896702739, -572410545, 502377659, 55814758, -944452658, -849199460, 511763296, -185953713, 1371396551, 1101507125, 1739842935, -967747794, -1921570609, 1336245833, 2014726814, -1995840126, -262326457, -1318182853, 1615313831, -1659675782, 1536097654, -386083233, -1320478682, -1794646481, 1113787052, -660622920, -843279352, -1570839119, 1775453845, 289079871, 1341962726, -334893627, -1478920287, 410611379, 611170414, -1223400198, 379717506, -999148107, -1560183240, 1346717051, 530585427, 1296650586, -413661831, 2028244649, -387614521, 408220412, 1736527800, 1606231475, -1257006923, -2040341943, -1721105986, -118616688, 1961746701, -1575522463, 729884745, -25019527, -2110710794, 1880200892, -166698057, -382885963, -656316444, 991126143, 1166396587, 1783289463, -2014675891, 662075542, 1094261216, -1287067492, -1861221292, 870614194, 83722491, -1761829867, 1253313045, 1588062070, -445685676, 209814355, 1294018148, 438725744, 130465910, -993584358, -1023883294, 454228315, -2108270083, 1150348484, 814750187, 1701992738, 1627391473, 1538386440, -1281573167, 1170851268, -860196159, -834339658, -755476962, 1197866786, -2139261106, -458865759, 1134122834, -673138086, -76182366, 1306914726, 956809861, 2054485538, -106448945, 356031566, -209998303, -1235919899, -1755621712, -1352198881, -1016878175, 262167469, 2085184869, 1710279370, 878701030, 1298629416, 1746076906, -1592363680, 968518899, -1066980104, 185779076, -787939497, -1522399389, 1821206476, 652046508, 661015622, 202630702, 1622683401, 2029401184, -2034193771, -1284381262, -1998988784, 1261165962, 1312562769, 1015113024, 788366477, 942839584, -1318593136, -402150979, 2065439392, -271365722, 1455923660, -807327600, 1502542670, -2029035900, 98296045, 1282601286, -428749096, -1559516894, 176794930, -1879828130, -805863526, 2145588972, 696884711, 1955145258, -2030126427, 2079167576, 381838174, 1689715843, -1490389373, -1734735597, 243706984, 700639039, -1997832694, 665780577, 506687045, 32918803, -1859800456, -2109986929, -766383828, -107305645, 1299601690, -496967240, -1859503750, 1682590177, -117997010, 851817337, -266323038, -837881578, 1413618085, 336836983, 1586398212, 2083507035, -1296666113, -1617429583, -940615943, 821665345, -533973264, -1316945391, 1738831978, -1142679447, 407324666, 893977156, 1779925536, -497296877, 293906656, -271229824, -1062859746, -2130255663, 947931451, -669186996, -1158449974, -387108967, 1402296500, 522368478, 23341269, -291329808, -210939776, -12106883, -492717895, 1996939794, 895588067, -1948479522, -154176729, 2029451323, -931887991, 2131630519, -2031064193, -1831238836, -1502620565, 586717239, 793848478, -1286356984, 1620434818, -831187291, -1522525207, 1480127968, 301000883, -715938181, 101387627, 342499106, 1149274237, 164195570, -950472827, -1482244719, 318400039, -1507011055, 742013823, -1613161667, -798312285, -767520268, -851367195, 830159189, 1670453368, 1258685311, 881634355, -690244615, -992602748, 944684904, -987792330, -661637995, -1165413499, -1785846200, -118014550, -1894391097, -1710171721, -1552705445, 257396235, 86281083, 1792904793, -413770313, 513507433, -944235932, -121824272, -1192816379, -1661307285, -275086132, -985886491, 976124553, 709215663, 654820125, -1504448609, -1867909342, 1816089721, 530507977, 2073411806, -965510800, 1554606510, -302764129, -217166580, 799027175, 1369964084, -288225555, -130529794, -634310544, -2024221431, 884960993, -80166139, 1120884468, 1520318580, 806276222, 101182448, 1960524198, 592074214, -1929629610, 1294709036, 1461884479, 1351827610, 519366574, -651366535, -1644593570, 1704294331, -1198146086, 652803444, -1528363386, 2103984683, 202079124, 1574964493, -1263214017, -1939161322, -1548180520, 477356885, -464270050, 2133184356, -324568434, -366226823, -1198391878, -844533867, 1856787992, 383002621, -1756369695, -308354152, -757558426, -846855153, -57546976, 144929364, 47685713, -1910229874, 2112623258, 1554969262, 1759845110, -477286048, -1294827432, 590008917, -979528187, 165009014, 1334997170, 1384067542, -1135965186, 581369786, 513059498, -674704746, -1678725690, 1982547164, -1995831066, -1748088140, 1529860395, -1677107319, -1992985559, 1422685628, -1476938048, 901876158, 652623035, 381960215, 1808678307, -40857857, 386823938, -293721131, 773596115, 2078383974, -443117692, 1830538427, -759230416, -269448897, 1043279548, 1691695829, 1599829777, 1989572766, 1444666926, 770343710, -1746920043, -602931020, -1248187244, 1161087016, 836136696, 1587166583, -1174143141, -1040970920, -1521837133, -156938410, 231655316, 1452840433, 2015712668, 460954944, 2055738254, -1114254699, -1439044322, 684243191, 1893181352, -892264977, -133699924, -262034483, 545499616, 1028281036, 1084763080, 133538711, 1467979358, -721578039, 599341286, 1586029175, -37480837, 872930485, 2056792571, -583664135, 179149609, 730883222, 2094255252, -1673263299, 956655151, -1659530508, -690623139, -1452816656, 210138307, 829272976, 738250441, -1848779585, 1538424064, 757159931, -373801198, 1432826242, -1085058193, 417915619, 1594410659, -958315675, 193917637, 1678335292, -860145703, 1113874225, 2066540407, 1293475115, 1541395125, 982539027, 664088143, 112861861, -838718662, -326282061, -1978377740, 1195447678, -1368261565, -1176426237, 1022631505, 1989812119, 581711563, 133566448, 1461498041, -1922509863, 850168753, -642020234, 474333301, 1172761880, 1894755357, 1919025287, -1968717739, -947835071, -54990423, 203464508, 967180584, -345687028, 1950940214, -765943088, 103855509, -1423380431, -1885987247, 1515722267, -313357308, 1917374359, 1990777501, 919943411, -980542, 608354475, -800736242, 1142810383, -1385996769, 1234569659, 330745492, 529200180, 1144479665, -744926405, -1776415989, -785617602, 573853051, 1730866144, 1035655689, -1139796226, 2003383023, 252755109, 164584970, -1454000313, 88108355, 37016922, 237966700, -1767912796, 725035172, -1314869740, -1644564441, 461339580, -2005437237, 1162386414, -1800564244, 658397184, 1498998135, -1199996995, 211032481, -950932909, 1973610340, 1927648416, 465229628, 1185794588, -873326165, -1887296853, 1013551638, -1601096897, 490938808, 2137013771, 1482332905, 1373317070, -49551085, 437157187, 1215638180, -166450283, -1494287828, 669019805, 1177105002, -583167813, -1849117882, 1645080489, -1338616662, -1998388886, -475169833, -1918520065, -122158481, -940674695, 1157274160, -2131966856, -1839806848, -1755760143, 978810885, 1083502318, -1826072151, -1919981781, -1937897286, -1953497683, -1657294498, -1612273202, -1411617556, -2137368002, -180261972, -522885240, -26066266, -127100151, -928068421, -1820967408, 332803585, 1241920933, 199480676, -1345570424, 1591387047, 1864549914, -586406438, 855306613, 1222824905, -416433819, -608332807, -1437316523, -1674377172, -1770902335, 1046258624, -1557436518, 1981174597, 1732214697, 2124637388, 464670542, 454420082, -1807206670, -999490126, -485172540, 900236649, -251534777, -1062185756, 117304808, 545926758, 5394565, -879075960, -30768508, -1755228449, 735237098, 1686603773, -1312084132, -546116018, -211613343, 440475200, 1165052656, 922354115, 1592393565, -1072804994, 774535455, -1632243997, 949111344, -198579044, -1178026158, -694838261, 77806014, -1901500700, 1687548046, -1414533755, -1136196028, -1557278484, -1500910928, -938948113, -1896518561, -503362675, 712765481, -209016821, -1704155530, -1561726527, 1866845063, -43912781, -351015410, 799420406, -1570756384, 2111850115, -545431394, 921292134, 2091362798, -703901291, 540593039, 1156880287, -312282211, 1193763318, 304632612, 991841593, 550921138, -1862327296, -141701388, 766318386, 783732027, 176056215, -1714970621, 1239802422, 1134933386, -619452129, 710542749, 1975121791, -1036633966, 318751668, 1117905966, -27023399, 438533393, -1137983953, -1489193155, -1411894300, 244011608, -2082503615, -2064500016, -1078352064, 940146790, -1254618888, 314135523, 2075597657, 1124159507, -1016429532, 992288749, 503849507, -1416702011, 1350917035, -786122924, -660495241, -2020184234, -1384987055, -768555233, 907848816, -532326983, 1400698756, -1850718666, 128254907, -188862748, -1590508159, 459412666, -1641122021, -1714250025, -995072108, 1435257756, -1794423409, 1202471437, -2099163034, -598210611, -1455785860, 1442140807, 444379198, 1788393805, -1768685880, 1574502149, 1735485730, -1270762754, 1307843444, 1284672867, 205365878, 1726172109, 442850886, 144323047, 1811870453, -1248579187, -708997931, -285130346, -1106900013, 38882978, -2044329584, 1178046136, 313005233, 440616041, 1338471224, 1816669464, -921505959, -1480490545, 602318420, 585609337, 944333581, -379525430, 1229144924, -885466869, -364528868, -953833834, -2146715103, 149088657, -1401119957, 1657902927, 1874360377, -1103957, 1532274966, 1660383117, 2069716601, 1783688620, 1575108670, 1711619396, 1946950299, 946629404, 78046554, 2103076644, 241907623, 678453596, -534373013, 697289933, -1159478205, 405302019, -368467345, -1463448611, 1310360812, -1049432998, 524811224, -594367723, -1564685922, -183422941, -1708006999, -1241204817, 1537758694, 1413510678, -605887355, -2032298877, 1943106725, -1408102531, -1381893794, -1075939742, -904452953, -1636917396, -39535522, 382706254, 899231233, -1728800665, 1496201841, 875539378, 1988618978, 1979137968, 1534037301, 2101630, -307615980, -1457388059, 833161767, 1955456834, 2000109190, -1387074775, -16428643, -648745556, 855857820, -92614218, -821083295, -716996415, -1279928202, 1720016125, 94651894, 891433488, 537118920, -275357947, -87964368, 869289293, -1170228410, 125905596, 1216425066, -1039774440, 781074126, 64708181, 1366838398, -781970122, 1287696234, -490121330, 30336224, 826425553, -676687483, 13572692, 476235115, -1992187748, -188643558, -237174699, -624017670, 1517080046, 577456413, 1336328888, 1404802729, 291532594, -1992189226, 128468139, 459994076, -661457842, -1632249428, -1339069114, 1917915728, 838589955, 1044514714, -2058113935, -4779224, -1153592564, -275066941, 1258049115, -1616940807, 400410678, 803258365, 817384777, -1127565863, -731566690, -285366868, 328371916, 1776916943, -800732027, -104884509, -906797765, -1171905821, -1783715163, -1050866690, -1871233897, -326982563, 247016054, 100535082, -138354619, -224845220, 1755402267, 399797711, -1974153540, -40268146, -933181000, -1404904020, -1335820286, 2114365841, -1552636472, 1876503989, -156442612, -533365570, 999399948, -540125687, -1857032429, -1458630312, 1410407226, 1093730467, -261765205, -1103571144, 1224856771, 287533689, -497406221, -539746060, -830878960, -813609183, -1181419978, 100659409, 1904980460, -517897763, -1560230265, 1265350036, -541497357, 1444696028, 504029920, 231473321, -1924074405, -894567552, 1541904061, -1395729282, -1928262724, 1346550479, 1021173220, -2075867417, 2110413109, 495933305, 630272547, 632400576, 1442616718, -729631827, -1542860659, -352189493, 874564996, -1032320620, 421790375, 956033407, -1297015364, 914043603, -1270314514, 1886072434, -812870333, -26376368, -772570379, 553394631, -529407728, -23794044, 998593732, -1101681295, 528330850, 2056267609, -1511813477, -1709002728, -196698790, 998868098, -1664984898, -740215473, 533621344, 1683518493, 2076036568, 668466561, 41197357, 553052335, 280525524, -1743175122, 1191782356, 1351048581, -1028061634, -371454108, 778070535, 570877612, 787026799, -2088545000, 1242489201, -1189389423, -228288271, -1907232950, 1012899909, 1626878147, 1993817108, -1828825712, -2133356544, 246549328, -880696405, 672976410, 1644360810, -1198493321, 2009042233, -1775399755, -1974827472, 1522094653, 357456791, -1803146067, -914300130, -1531470330, 1372503344, 464035089, -1583488616, -314108867, -1848299633, 1926374135, 1658482584, -1982526056, 509460469, -2103170191, -1974120490, -1351381639, 1293913205, 939528003, 852481366, 1624923850, 1211284768, -1819284461, -958951513, 1366644103, 400757890, -2057428256, -1597922892, -1524629001, 1013703316, -1778767739, -1221583105, -1906503855, -552548241, -1029426520, 1444003576, -641264353, 35958891, -1540723979, 1262042457, -318783483, -1826373269, 1728811644, 816068229, -321316971, -1164927537, -335229354, 1913810955, -183208761, 15390034, 221737997, -1878594120, -24422632, -1257158528, 1336207650, 1139136602, -2054511048, 1393578992, -1086285440, 607787487, 1824021986, -96823230, 1556496806, -693953076, -290627678, -270248864, -867401000, -440360947, -401238515, 1352150299, 1663549071, -1707333442, 1627333917, -1913904737, -2054650522, 680117976, 903448411, 2020034864, -648187383, 561206993, -1085997898, -1088653179, 1942177709, -22037661, 1494403119, -2024098401, -528916380, 1944660966, 1331437063, -1052732866, 1331932500, 1725294733, 539755173, -1115176592, -427751115, -896508425, 588337804, 1853479014, 422008037, -2081576419, 2001557068, -55496075, 1711244531, -1820744008, 1814715046, -1702525620, 473515063, 466324267, 1484119264, 1411349337, 1829839005, -1320275001, 1690572649, -1504115090, -59191514, 1963043204, -1006632300, 581652518, 1456297764, -1484068236, 1076169045, 1337253316, -1084739578, 559642760, -98806224, -724752299, -209449713, -2045661691, -795299860, 13048574, 335286354, 869687006, -847373371, 1084912344, -1745441872, -497216527, 1420626944, -1530050253, -205575252, 20980546, 603440116, -1939525798, 52073484, -375444040, 317968092, -1638885277, -184521493, 1156210912, -49501695, 129087152, 781431205, -476470596, -1394180189, 978780743, 1600437261, -855452976, -409143773, 1761749619, -910955833, -1648724865, 360095620, -56888071, 1147359737, 1047397500, 1296220296, 1488591602, -617166731, 315435838, -766853783, 151006429, 1915180866, -1611488005, -849531647, 614539357, 2100934644, 1444599836, 1649303898, -549210063, 875741014, -1365226078, -236122054, 587681876, 441630954, 839311219, -1134307231, -1192194641, -1117685662, -472104606, 825010138, 1507806821, 1414125320, -752240490, 573700469, -406414052, 919800543, -1526990567, 257575335, 192193281, 2015522768, -888597647, 491056161, 1408132956, -1245627051, 88440224, 1275710475, 1508293588, -943978430, -563296749, 773724624, 1735981420, -38605088, -1180901247, 790572965, -654886786, -1707783913, -334972330, 29750719, -891192221, -1942734312, -283364566, -1339911742, 738012231, 2112180160, 1037593526, -1593301715, -1726463722, 1962537421, 264961210, -387472169, -131947586, 1285480282, 993703626, 955410397, 1649799548, -191372817, 1454919007, 1046132474, 529615444, 1969767063, 1027482877, -273040121, 97918306, -678554684, -1677831263, -208363657, 1106402313, -60631752, 1430863135, 1814979859, -1122969991, -277537943, 930831047, 259988265, -1993179719, 689628548, 1050404533, -1583233735, 1706423356, 201191427, -1526925507, -1212566867, -695237997, 1863235214, -620505300, 2077083942, -565310275, 403010051, -1806604285, 773885494, -2113383865, -1372420753, -1745576010, 1194710571, 2042381344, 623908660, -1642422588, 649787936, -593283215, 1438000068, 1084881542, -1887698246, 1361458121, -185598677, -382820610, -532161877, -341549139, -600649073, -1678274496, 1258390404, 759943180, 722697591, -88745290, 13510312, -154106548, 335068698, -850983883, -272699899, 629811738, 835203363, -2062424376, 1770944712, 571458868, -1039369679, -883865265, 1414825098, 2038036157, -1652452036, -1565671013, -1593431839, -1205026364, -1836547775, -2091637340, 1764708701, 1015741413, 1314891464, -1970453176, -512006718, -1183249834, 1611754802, -1893568839, -1586258343, 1550962486, 359890321, 2015904781, -1803923310, 635076899, -211728839, 1101983670, -2031587940, -1584872281, -872151365, 800535490, -678836387, -951254761, -1471386213, 234356995, -101379992, -170395314, 1048151652, 1853821449, -1017191709, -205156257, 126788616, -934262201, -552293815, 1669909850, 1468059724, -1990122109, 1180715726, 335702070, 1521699129, 1456032891, -918741963, 1981691348, 190341774, -1563150620, -1805184134, -920104457, -1843219505, -1249226838, 1289153742, 1206744429, -1809644709, -1058291486, 1002692751, -970673268, 794192769, 943720590, -992355059, -1993773093, -1347132012, 1263306015, 135150167, -69690177, -1526793743, 354644622, 292127068, -1009201167, 1844635620, 1123063877, -638558716, -86150526, 1184614840, -865172171, 1518999378, -1658595128, 857568285, -1103679284, -463525242, 263564121, 1230524229, -192811747, -374793827, -1619258659, 655687304, 1935508793, -89128384, 1826174634, -874043917, 1715886628, -715158021, -235188899, 251411263, 1208539219, -909248970, 1767428467, 1244698725, -1087151654, 918945137, 622983469, -111292645, 132957382, 1463745579, -2041396762, 1605605912, -587853260, 1330812344, 295775371, -145767510, 1105899907, 1434287653, -637823926, 1843006937, -537710575, 1193787735, -870750835, 2053218260, -1992548429, -1686541790, -646567459, -1310757937, 2048342748, 1925408873, -1356044044, 1271131189, -990220462, 1255335596, -2125356926, 1003413740, 1067853010, -2004152432, -542439872, 945877382, -1457290739, -2079963064, 1468258534, -569189858, -1465125203, 1749987771, 567968723, -986164880, -1808133505, 1653957480, -1067161691, -517962074, -1300114546, 2028067501, -1896255063, -1458106257, 1994288078, 239706292, 1354668906, -1171853612, 1062673458, -704676271, 340388337, -276559922, 71512748, -2043331195, -1226146120, 739857919, 652285307, 1719814421, 692157752, 363677607, 1853057208, 513229512, 431443522, 1810204650, 1504784475, -308615670, -1187667541, 709903312, 2136443555, 115532529, -1325428861, -429434329, -808343510, -2014695421, -1978184216, 1638781808, -1667757727, -994705069, 1671068853, 1573481647, -1218379303, -852884983, -11555846, -1032610804, -1241473732, 2125788555, 772996872, 1105315963, -381813586, 520569606, 1065136727, -1126582865, -1761570837, -1398942221, 535226378, 1614063119, 2068934434, 404689303, -2143936662, -1976985147, -823565142, 1873002023, 778377315, -1213714255, 979978107, -1392835445, 1736886299, -194103697, 1795182931, 615599615, -971976929, 1066712861, -526901341, 789806770, -1718621900, -1488529818, -826181910, 615912461, -1455622674, -1376018405, -541953629, 1888252885, -808002820, 1032663964, 1203163073, 367709574, -1485914974, 294260599, 1416293602, 2053463673, 1098025481, -1267603137, -2000074982, 608204580, 1926345807, -1311307107, -1840043404, -983726725, 546693092, 1470752655, -1177170354, -1987317746, -220842377, 145341028, 1513862304, -1402020553, 546300404, -1056649891, 564630560, -265349474, -287262292, -2125357987, 1460702513, 2034230072, -1761987669, 1653783906, -679960299, 992452752, -2080480771, 205746197, -764311714, -1137022461, -1413269327, 540522310, 522830496, -1443608746, 909280382, -1729473781, 1683976650, 1857115518, -765224162, -1795965423, -2084786325, 1105748256, -2147184837, 661219911, -2029677958, -1366338200, 932941516, 1577969156, 300174905, -842187770, -252941111, 2118194448, 1262780260, -737521441, -1909447815, 1778547756, -159753116, -1498491854, -21014288, 574224672, 1936946342, 530968633, -1822810614, 1832128173, 900271257, -2023013130, 2095097933, -877142329, -641452521, 1385088793, 1343599115, 880162764, 1005610686, -1997931724, 1720749187, -1694315694, -154681214, -1456455531, 37133544, -2926782, -266013400, -119017648, 183779714, 987096643, 1904692670, -288268148, 1277609648, -1945755096, -1287109375, 1193412917, 282049951, 1149356502, -348444607, 303204639, -1537970249, -445482543, -1601098450, -981321101, 1703217510, -2056769161, -748904960, -1349365014, -519657314, 106786594, 639124205, 649934496, -1491177891, -1843815250, -633429584, -512963866, 706876392, 1301550548, -150108314, 227273153, 541614748, -2001961283, -892408916, -767685757, -1274970714, 1249502675, -1052008465, 125963336, 46451060, -654196, 2043011525, 1359114613, -1947155846, -1059498292, -259025939, 388859374, -549379518, 622845671, 1458904180, -1555700296, -1752144536, -267219907, -670013430, 772792777, -1953013848, -1208221316, -458993441, -811894851, 1991669516, -567389210, 1741022639, 65908914, -1029263870, -1684059977, 1887569511, 1532500014, -369736569, 79210186, 1075357993, 1254073077, 1301989505, -563456341, -1565063574, 1581307432, 1521586104, -1958169027, 307114240, 500787768, 2044987965, 197856183, -416511990, -480987811, 537071402, 1236221632, 600967798, 1539628917, -1161499350, -217475280, -729411916, -2147178248, 673315358, 1389070832, 568467954, -642515344, 1988249891, -1986649685, 409677480, 1435212526, 1847498700, 8584132, -1081603738, 917090063, -1011343087, 1349805997, -140573402, 28061507, 2069682548, -1529319089, 707891084, 1432942342, -301612356, -464840361, -784987460, -2135439380, 707117506, 1965235034, -1652260811, -4807847, 1173478483, -69136099, -1957719514, -938715578, 763082375, 305004472, 534393747, 795132246, -929906727, -1813975561, -778803411, -1565232515, -840058556, 654823032, -484788701, 71564232, -588453794, -678468071, 1054009110, -2109025483, 1433731329, 2075502115, -1615608113, 683844095, -1025358729, 1825785340, 616185201, 1089365636, 1672765403, 1214361250, 418481272, 1709507881, -1878153515, -482028686, -637269129, -1817865009, -1121527812, 614310867, 2077037887, -371850421, -1407507789, 1060838878, -17288477, 1594644711, 1636384394, -1325526596, -1517807477, 2055082036, 2015008621, -1983787050, -756983958, -243542900, 369594384, 698165310, -411768447, 1341447809, 1028264826, 6928182, -199792291, -175154451, -263513512, 1048504788, -345486299, -1532998147, 1112564827, 1566932607, 2020134210, -1740590396, 447308110, -13942830, 2087646413, -2010999036, 2039538045, 556455424, 1117467855, 1525696486, -283804295, -185134395, -2038400896, -1287208710, -174809677, 439229837, -260580520, -1884790320, -406131519, 931798822, -2001495968, 521057951, -1346700892, -797945546, -215714493, -1584084452, 1149708094, 864145893, 745450120, 1999238375, -1695513763, 478718487, 889969719, 1215103921, 557929687, -1211502016, 1395659143, -1797107970, -1853130631, 675610064, 1878281886, 1897182964, -1277612179, 1511522489, 713141515, -1707049190, 1615142178, 1744286174, -1933008959, -287353129, -67423537, 2097057433, -775300296, -1260618749, -970620005, -56575452, 1635732079, -1281866494, -1737560375, -617001109, -241083335, -1570016786, 2040253877, -1690673469, 1623359490, 232090949, 158007369, 482684039, 33395389, 1899162745, 333003750, -1289688392, 1555552041, -1798912268, -1785464153, 1373607484, 822942488, 40257577, -552633370, 1354993823, -1137605966, -1315949414, -177173876, 1017468903, -660280763, -1775511460, 256243838, 1834829108, -720788908, 389288321, 1790409125, -792672979, -1317255741, -845372506, 673237353, -130769566, 102666961, -335283817, 434058144, -1481054651, 1143047083, -768870493, 500107152, -2009218183, -413896940, 1319915470, 975306065, -2052567180, 64115212, 387452357, -49899043, -607957168, -121701933, 1604430413, -1200969290, -1583154623, 1145146610, 1183919876, 1381474852, 1217754899, 402369432, 521381255, 1208232545, -1993024878, 1221739514, -2055248563, -669859482, 1332042874, 1378054120, -939474680, 881010716, 240035751, 861933895, -1798608789, 1800145624, -1299792545, 611206091, 1298703264, 644795905, 448790120, -1447162976, -1605734670, -2061759019, 1656010392, -223257208, 1434822253, 2081594420, -440132448, -1344380760, 670971034, -2028483397, -687276795, 1979778558, -297900245, 1232376710, 1672736491, 1993454564, 2137136690, -1299668203, -1812673862, -1272710014, -1593055036, 861383380, 105148535, 998417288, -1482515412, 1933576510, 1319122769, 341472723, 1379999246, 217450041, -1696592316, 1515303491, -212053519, -953074532, 2009714657, 617568173, 1573379316, -191727122, -1940176993, -71842326, 23522408, 1375095637, 427058686, -1512691233, 1289390315, 784362988, 385647418, 913188273, 1669422105, 522273885, -1919366901, -2071446608, -530431326, 2141877806, -2027746530, -1011869083, -884398380, 871657243, -101333448, 441034160, 1414349589, 705656861, -1518565296, -465551463, -947961044, -815277961, -138755149, 1120481108, 1321588328, -114354180, 181442127, 1807815617, -659960780, 2128560154, -781651649, 413706812, 629488515, -1256278587, -138666687, 1319018113, -1430264055, 1754595668, -1822472039, -329765466, -1589931714, -1177161018, 1565409185, -698715758, -1207540259, -915034004, -917679767, 2139587242, -1058270558, -869838231, 1090512766, 521342866, -348671058, -2128095011, -2134987451, 1106404587, 248816489, 1467526679, -1540055459, 324465618, -824524496, -1862597008, 53573747, 774074358, -788389820, -993724778, 1992046729, -1360883723, 1069094856, 1441639503, -894276341, 161517902, 561923190, 897268973, 406521587, -1052319672, -1521978900, -688515459, -363148503, -1897254588, -927323578, 2123833950, 1989429297, -1533642956, -1949442343, -1142091957, 1931505221, 1524957884, 244923152, 913174295, 1506078322, 375517596, 1678853187, 951000052, -1286186292, 1331336040, 180496857, 2126974396, -521715987, 930463587, -1826850370, 1717229627, -1434805223, -1911923117, -1017242207, 811235587, 1852039500, 830640560, 311272771, 1272823014, 1630863240, -784905464, -2080500539, -552989875, 1289376395, 390789829, -995579714, 53843778, 1964233665, -629770766, -1658856292, 207104310, 851268429, -1933883277, 1145277208, -1681485905, -1658977886, 1481765326, -1189839833, -1522613653, -1584652339, 860796152, -651057526, -2138004776, 654817468, -1325338536, -1049576617, -608456340, 662016568, -1892024035, 1712775350, -891508056, -1538019987, 1628982510, -1718003233, 142797450, -88480553, 2016876661, 1956430486, 1102758068, 1895943784, 796609611, -784925330, 1403279752, -656424967, -1794732707, 48739441, 368698970, -67129636, -152188633, -516132826, -1045340173, 2051906328, 1056691958, -857915906, -1278717352, 1033482549, -1628282798, -375851839, 1647141786, 575223494, -1750987270, -181078541, -1342668547, 176085523, 1709319492, -587458074, -1576906784, -980004521, 364452952, -1393901599, 966052677, 1842846522, 926541648, 781425610, 145544946, -88887107, 531178005, 273916187, 1541131760, -554426793, 1542774010, -43246454, -276675029, -1903099721, 247785723, -65902557, 432488272, 80906886, 1196051327, -996461770, -51071842, 1925312441, 2058126312, 198459659, -1988338424, -1059041462, -119241448, -1139519876, -1332255739, -1858227721, 1430855151, 146341128, 579693180, -918864188, 608252556, -486258146, 1232793553, -2082000212, 952992756, -1198444779, 1223348832, -1204593254, -1748414516, 1196476785, 276537703, -1965086044, -108325924, 1472625323, -283212144, 1044521212, 1560241935, -1137989350, 1833608881, 998642091, -431022906, 577311220, 1997315300, -1762162545, -963585177, -772198443, 379544246, -1892183581, 187885709, -539919236, -830217250, -523087318, 1183148844, 2089091187, 1070774654, 547176486, 219897901, 1801944780, -1566896296, 13523652, 839400985, -1610248156, 638272686, 985201791, -429209387, -451879350, 1267668916, -2066387937, 1168239980, 1013646168, 1763257378, -666442641, -1416636437, -1911724448, -1903963602, 355694860, -185894071, 751140827, -1883043697, 1052056918, -1890842958, -629730073, 1288132379, 881108785, 482964600, 85287676, 1239519054, 1523798464, 1147558328, -2142288178, 1161574057, 573820756, -1986966054, -277034723, 100358251, -1509951075, -1500814699, 1963598510, -1008659950, -1709612974, 997859190, -275093594, -927826902, 333756834, -262743773, -851181292, 1053763659, 1934482498, 2114972465, 1918251267, -1106989458, -2127005109, 924083985, 504739033, -1234260649, 346952327, 1442234063, 1014457819, 547433384, -1957177335, 2090817263, 810161252, -1465001123, 518497738, 199269284, -358798171, 1932674204, -1037205504, 2128758810, -1284138778, 1430362047, -2048274316, -2066555395, 56292830, 662969792, 1707079569, -838265760, 927985197, -1533486676, 1092170256, -164125843, -857253021, 1254861968, -1847468525, 1633587193, 1541228239, -1132049029, -1418032908, -405879346, 1202224883, 499285869, -697043805, 401426560, -686485898, -1091798909, 1266016590, 1213888557, -676893360, -984882866, -1442261490, -668918727, -1626777479, 600437355, -1807760438, 1028752823, -1665393373, -1897424490, -1114858975, -1219061250, 76982286, -695832711, 338223722, 965008462, 1600928441, 656478308, 1764581537, 700596278, -434491218, -1617958645, 1337895527, -432099341, 1397386699, -346502325, 771573316, -896395042, -1093561738, -9255976, 130085924, -875819050, -1370981658, 1618666937, 1371523147, -247637663, -1435567151, 578622164, 370568406, 222165874, 847884988, 1450394234, -782102929, -759200996, 118238456, 776497240, 163884401, -1442111034, 264289719, 158721536, 2009367790, 587104036, -1068813698, -2090408334, -1102842931, 305995796, -1789574892, -832124484, -764782011, -506251246, -1028835233, 913675475, 291650746, 680491853, -83172001, -1806363780, 1620597757, -2079878250, 135437096, 669945840, -1849517, 1812935615, -193171294, 436147868, -628128642, -692829595, 526779000, -2050022960, -1045435932, -525205928, -104398444, 356486021, 424847169, 372286368, 1114756182, 1616204412, 1109131024, -84267858, -672640589, -1225166604, -1070125307, 1530189083, 2076891163, 506276209, -91458708, 539970692, -602149693, -643134801, -304244619, 1757036061, 1663485052, -1031243068, -737165816, 1153678911, 795316524, -878819115, 1026808516, -18577881, -1581239594, 1899303785, -603421507, -1450360700, 1761382914, -1786175380, 1407814169, -758705685, -1134353175, -2102565721, 1008913750, -1008420199, -496912649, 433113958, -509441887, 656134427, -814611792, 196885789, 1119626037, -742228283, -321630977, 1861976138, -1057037443, 1454289884, -1110623119, -2006912824, 467273208, -255045187, -1330680594, 1238512419, -219513631, 2063011215, -1813110694, 390266619, 2019550563, -1813971731, -959205762, -1132290365, -1668585334, -1122990110, -1426473194, -539547163, -1071289032, 488094512, -474270107, 1443489677, -1685947625, -708118638, -409886203, 968894402, -1948459323, -360783068, -1634812240, -1730049974, -1256616403, -873293272, 141102502, 1810839393, 940175638, 1645326995, 1482869205, 393302180, 1403877098, -1129002877, -244805417, -108639496, 1510606911, 1419116069, -1018422209, -2063482395, -460568830, 1308969421, 1426372539, 1557196529, -363974643, -1135902945, -2001720565, 1575267946, 1649756898, 160795556, 750008009, -893574409, -666569694, -679433374, 873022759, -1374693032, -2019856061, 769070671, -186497561, 1416227599, 1041955129, 129260856, 607237199, 391306522, 1907562018, 846230194, -989259507, -197404562, -1537511825, 52986027, 701033111, 54090037, -645367181, 127168660, -620484632, 219377017, 1537579553, 1443790839, -1317005643, 189943632, -1582166451, -818406057, -1961404688, -1675770114, -455744697, -886349118, -1815721158, 1497024176, -154008938, -2131003543, 339985001, 1365330026, 1555161295, 978193457, 631215295, -702364558, -577919660, -1510112923, -842784018, -1906237070, -1368207219, 1418190884, -2096314183, 1263131363, 1339171157, -1887762341, -1926265767, -2080804799, -1406024227, -202436927, -1277077788, -1090905463, -1726330493, -1739903223, -1715038462, -1181321964, -701512380, 1335311987, 752366290, 1975693934, 1787026531, 1284507843, 419445761, 1087023222, 1287399556, -380743220, 452250481, -747400561, 616373304, 1323294391, 1946043281, -530069222, 213542758, -2040153167, -1494954607, -1871628561, 274858968, 805270648, -679243084, 1979756260, 2067932924, 1036851335, -1309181279, -383159838, 1485090834, 256684643, -72269195, 1723138173, 782283235, 2048592071, 185718857, -166386425, 1433318731, 2006048072, -1677544213, -447758152, 1353490801, 1807743655, 3508078, 1641552062, 1680830136, -2112765360, 1171414353, 405313765, 1906133655, -1847447031, 1377205004, 1018010174, -1085288632, 1748360340, 1388741596, -699982516, -1433297922, -232519045, -233841219, -826128031, -29596944, 2075012547, 4061566, -788664697, 1246571378, -1592073590, 66398994, -176503196, -17105266, 1594159423, -440653230, -1156307019, -1316467927, -2044033578, 1242919335, 1616165193, -706627364, -1700064976, 714139247, 699974748, -1809050027, 717148805, 715499830, 40249506, 243124305, -242048321, -114254320, 892246018, -443976992, 1045677730, -1495275960, -894864275, 1947100611, -262741003, -1898385589, -106585593, 1271499035, 777483993, -626698503, 1269885311, -1303120499, -1557367862, 32850211, 269277712, 50684934, 1523422913, 1274903831, -1523770047, -1760792348, -538122166, 895004096, 1854325448, -2073342892, -571461614, 170326421, 1340813235, -328376710, 730072267, 52611419, -10534005, -1507535011, -1629559797, 1997806127, -1427596586, -227516408, -24554882, -804458281, 230158148, 758321864, -2091093114, 50132721, -632187958, -47161926, 699216006, 1941281876, -693556101, -1743683486, 622406098, -1110781980, 1149598806, -1712993325, 1332686621, 391282296, -2140170529, 1215366488, -125135639, 1813844455, -443779760, 1532972439, 238567783, -1243566076, -385507288, -401585360, -1853710141, 194714724, 509555848, 1332350925, -1473455397, -551097010, -171565321, 453661454, -537423236, -519218901, 562902771, 1328465347, 334932963, 719868207, 777796977, -1259278023, 1113688815, 2079845853, -1517978861, -1774331284, -1643826329, 311517211, 556592686, 1355649187, -542597811, -1358946465, 73900957, -1377445180, 374684604, -1682788020, 1254044825, -941778332, 721052471, -438599243, -456809170, 1730867328, 2012235470, -1623012466, -1311511421, -1947594308, -169599599, 2072731969, -1118967379, -1387645129, -647678023, -2049667068, -1176687310, 2011291862, 1567532268, -446245388, 3447872, -1862490681, -1875503559, -976263144, 1816873845, -1731577952, -1657101973, 1716454018, -1351120703, -1782007831, -291385578, -2127434196, 968068551, 1695130331, -345041084, 261988945, 1452350408, -2087161554, -1776286337, 111557265, -1538665709, -1600124053, 1606262932, -2085603226, 112167265, -556398103, 1546830298, 1683465346, -1446483943, -299194308, -329754922, 837091707, -1413592390, -1458149621, 910102744, 1747148714, 822351690, -401460261, 1972905664, -1335023565, 777660497, 832017973, 1686200410, 688946889, 1019862370, 1196105899, -201464724, -911333552, 718809894, 2107230954, -1074535880, -236321700, -1032816655, -274338113, 1925363881, -1522911100, 1045156685, 1321119376, 560537425, 1100297470, 926623375, -16389166, 1178736219, 757519366, -1891019160, 1141697804, 205248977, -962350145, 1882008812, -1714055561, -478126237, -71340253, -892314031, 2065838933, 2007045876, -878103426, 274589188, -1647063534, 817844808, -189086403, 2123777537, 1821170352, -219231393, 1369293351, 581831781, -1141864839, -2066889759, -1524865676, -613065882, -973132672, 540945627, 1044493389, 688241821, 199878562, -635243405, -1251128456, -141717545, 318808904, -1900343257, -270263694, -396027856, -1822489669, -1176356219, 1500530875, 440488508, 1119144110, -818737284, -1179594586, 52709452, 912787813, 1976819742, 1328877746, -1018329011, -1400042563, 481220541, -2147080918, 952194821, 1994650973, 1598822371, -553968803, -318636277, -748941717, 992627278, -400196104, -975228684, 1160030875, 1451430457, 1886651100, 1771914675, 708334494, -711173880, 986287608, -1724888822, -438415268, 103604741, 817924712, -1771462587, 2103759763, -593794813, 267095236, -1360497617, 936852298, 765360012, -51619282, 196057798, 340313452, 546270066, -937724545, 1042603530, -418662861, 515607486, 1217468167, -1047558237, 1189509195, -1881126252, 987851824, 1818974786, -669008909, -102286746, -1376633489, -657211800, -1216839339, -1825007245, -64847869, -1216552767, -320617933, 1154506996, 906449206, -2129047894, -1324086597, -1458232810, 210418309, -1056014015, 859045243, 1601782410, -942469357, -1300290769, 599552957, 642670651, 839039998, -1907732916, 117657472, 1264797081, -2054140011, 141968240, -1398222871, 1956035516, -1409403617, -2107652046, 1185318523, -941949152, -1759806053, 1349192087, -55514526, 2032190907, 1639557073, 420249665, -2137001083, 521794188, 2125255755, -1137698774, -1422211998, 1471121733, 1664888347, 512517480, 1207867618, -2008556129, -1222278572, -1596157072, 19634115, 1355954009, 2055751819, -580983805, 1304347565, -258085327, 850815802, 777031501, -2133025874, 59993660, 671479369, -1058027747, -1937345133, -273950304, -1223697911, 669509197, 1084325099, -765246113, -657290334, 1953504251, -1006386386, 699250856, -1717213462, 1811023975, 2065246776, 1649030184, -836640286, -1968906520, -1734618444, 1337367553, -398756209, 1145690447, -1372895597, 581301558, 499307886, 1975150232, -844814069, 1665084082, 1060609651, -307043426, -304318633, 94200272, -717816379, -527649645, -2041188695, 1843492821, 352671728, 872269809, -818089594, 341125096, 2128439554, -443368698, -139762830, -1317611768, 1363928555, 1982931681, -602466436, -1791599269, -1892378182, -5947174, -1300186724, 313581229, 2101952639, -1494172342, 962440004, -168870116, -1156590599, -651014059, 1459608727, 987927313, -2026211792, 1512058445, 818161115, -1626134769, -1436158076, 1783091626, -1720007929, 1072764329, 894472403, -1847049933, 174992429, -70356083, -2099654425, -1145319959, -1599835726, -31200408, 2107775132, -148035074, -1217418788, 1481329202, -1720357689, -1224865078, 285149737, 1701122715, 1920201574, -1496050062, -2073122221, -1596286969, 144319445, -949237736, 1599806509, -1833722837, -1366899533, 344536658, -1952419962, -1204745147, 2011823563, 1104612151, -1867137789, 1650566254, -1229227083, 973355838, -1866755843, -334518638, -495778199, 1099746671, 230709737, 434850455, 2015890403, -1544658483, -210434121, 1969462331, 1526027546, 1224293850, -544670304, 1857388917, 964630704, -1457868617, 1064898038, -1032318211, -1708253872, -1398437750, -1537483744, -266099981, -1637475852, 68724992, 322374925, 703746651, 1755558133, 388331873, -1206225232, -1208780996, 1858731105, 326384505, -1967943847, -889848761, -1291392169, 73916592, -313957566, 1447269920, 1801624538, 1155494213, 578469776, -1575045553, 505313231, -1772025459, 2081755534, 1103799276, 1575679971, -1553393574, -1897098749, 136609768, -171634740, -1036373301, 342038427, -1558592427, -90069729, -1160170253, 1031706377, -817956695, 1534141921, 581820213, 2127117474, -1849551347, 2024693234, 660332142, 1100680454, 758337943, 827323727, -1526325116, -1165977275, -1502523376, -1530966171, -998014596, -1889071876, -1534272730, -1121132884, 487477182, 1491622222, 467585517, -602428797, -2125289807, -1015868981, -1418897720, 896815750, -947355795, 1743012874, -942885201, 2053381151, 1665665248, -10229440, -1671387996, -1580696920, -652681158, 357033325, 978033722, 50883609, 1143134641, -1738360763, -1381789806, -114737355, 298329138, -1102896563, 764733764, 1720101158, 1386407506, 951531802, 1713166419, -534171418, 1292907669, -582174674, -208639826, 1781403056, -1940199860, -1102551606, 1044787528, -1900683004, -173366984, 370296826, -82378743, -1641006471, 2029804749, -109724790, 382796012, 158283551, 1773693289, 139540986, 1746186157, -2014310865, -1510930430, -928944956, -696528968, 719464421, 1343670327, 1364918097, 1048549607, -1028856905, 138283994, -90542918, 920494560, -206169565, 985613773, 1154947525, -1408857735, -2127737110, 133623097, 1849568103, -1657373376, 2075730891, 1928313194, 615494796, -1776517212, -1251314307, -1819947599, -663326089, -376173641, 970266506, 1261186790, -1251176031, -215477934, -1555354839, 786268212, 2000874614, -912735233, 1536012025, -677091930, -1740852279, -1008577593, -370059131, -1279784678, -1586448932, 294743622, 781450918, -1869572975, 457789772, -876898210, -396384674, -1832287981, 657463710, 2096787753, 1363209304, -2003215556, 580412325, -1386516884, -1312255581, 751072858, 1276944396, -1972349058, 1380664084, 16380221, -1045133974, 358677320, 1583761844, -209823263, 453391902, 290650138, -882509387, -1213095422, 1846575534, 2114890646, -154144102, 1195209728, 59590881, 393609859, 107718682, -1524272936, -407857601, 936067325, -1515600254, -1537804221, -1127147855, 673160733, -1390630166, -1655576951, -1127607041, 170923406, 234110894, 409863518, 1776216647, -1554127255, 1075818411, -1058988118, -2003410081, -1266803420, 132136857, -273563962, 782937015, -1579415298, -1586453677, 511535728, -932895172, 848319413, 2037660668, -1503039729, 831245217, -184152521, -508923481, -1028083555, -678234238, -899264619, 33712964, -141244049, 1025069716, 273486189, -1010269384, 917291383, 173921822, -1355136155, 68057745, 917842881, -602100807, 1342933674, 1253922063, -2119388808, 1617146865, 811511972, -1861643624, 1202167708, -2130192829, 1055823939, 1953183234, -296411287, 277429500, 1148389726, -1892740224, 1897508508, 739682935, 1707843454, 765325234, 2136163216, -1248128321, -2116310190, -1338455344, -318812734, 188300886, 670153086, 1047432341, 89544535, -863684037, 233732677, -216572357, 1953903722, 389036429, 1737897298, -625609288, -1094923030, -1727908875, -565809355, 309624592, 420534954, 476915257, -484994602, -146291173, -1954350481, 1173819739, 641705068, 1704617869, -1663705641, -1053817947, -607769327, 6152301, 1320292892, -1944929429, 1409682980, -339370967, 795504594, 1648755796, 511005187, -1474888369, 2077032202, 992172358, 834815669, -45496451, 1029515604, 338718337, -1773074193, 684407878, -1343154020, 1931845415, -1033431478, 604766598, 2126362644, 1452492053, 1722296909, -720123037, 720699749, 1816173103, 603872892, 1675861017, -402096447, 2146865100, 2036928844, -518434552, 1313852030, 1310563026, 1081150052, 1789623089, 2136639056, 1827789009, 382420807, -787028955, 989597585, 761115506, 364118383, -852822981, 2100471896, 641622314, 2116212600, -1526955721, 1953389987, 394570215, 1149009747, 2129361812, 2008452619, -290610426, -583216627, -877997394, -50884085, 1668077849, 1008299281, -708731944, 776426155, 170366987, -334220852, 233806870, 1412954121, 1402743170, 1726385427, -392249609, -81506941, -1781374619, -832669396, -327672512, 51105752, -204162400, 832256089, -227748966, -1499785602, 1337033531, -452729742, 1378294312, 548021441, 1987176747, 490858007, 94942570, 1914634743, 2130861922, 288252919, 1146379786, 1538245977, 1305546820, -786035269, -854032954, -1967578380, -441328828, 1725367623, -1064439231, -553133525, -531399443, 1907420306, -740283306, 871758505, 54602936, -1814660917, -1098856645, 1109135287, 2025859395, -536945439, 830514894, -1308771761, 1368133053, 1805714644, -552827183, 18463615, 846266801, 1832634509, 1624788537, 2009690941, -1530757521, -1343330744, -244621569, -579831039, -838154523, -176872860, -1039215814, -1574061916, 640657426, -1416828349, -782476307, 604007273, 239291406, 1649636097, -1350141731, 95042624, -244539025, -857294166, 1271062235, 290880215, 1615029789, -682454960, -2102540914, -1232851104, 777902311, 1988381626, 1752601054, -1745089862, 1460000659, -1923180070, 2108869017, -362851191, 1676473991, -949397663, -694855281, -1640681887, 1622575956, 1801475333, 704203993, 1721700427, -941839878, -651225593, 2129040917, -1913170416, -842736541, 873564256, -1096710754, 401107474, -570247000, 946044962, 729420616, 22160459, 1195839702, -1135735198, 1507314455, -1812201605, -2037268419, 1145117364, 474714226, 1144255846, -473092235, 329716104, -460231328, 237174661, 702201179, -37145175, -291556414, -513173780, 1912018286, 1800708730, 699621804, -766466156, -1834645597, 1644608964, 1196427725, -1164872631, -929627341, -198782024, -88737925, 473193800, -1283030786, -1996722294, 456596145, -269142216, 482512493, -1669997070, -501203191, 2111514307, 199312297, -450656525, -892909239, 1180551952, 2076332484, 448969886, 1825048447, 1254866326, 1144836249, -423310341, 1092825677, -607420799, -35689479, 1356659759, -838890406, -761673322, 485161333, -568630128, -1853607747, 1089893082, 13478466, 631817496, -768418502, 1593086077, 792562207, 1442339190, -353123750, -479833960, 2021734389, -673128339, 2007232941, 287726165, -745002895, -2074711754, 1071073035, 2100184005, -1051712624, -38350790, -1112397422, 1756007074, -1467519035, 1866395620, -871556988, 1807847601, -1731571646, -780131303, 1584396453, -1443794609, -1671241591, -215870124, 2098867045, -783891351, -1459788952, -1290791266, 669645963, -1851221967, -1186930484, -46751939, -1681794718, 922060454, -1875619528, 1529266006, 1419151662, -501181208, -391873452, 1548217873, -129938500, -1703697798, -2016312864, 947826304, 1061905237, -142694296, 610528760, 1969720327, 1140757135, -528809671, -592614536, 1267071013, 124168410, -286393559, 188644751, 402033875, -429484295, -587085067, -1715264981, 1724410242, -649358875, -1808121796, -197725451, 482179904, -1657444260, 336043107, -919894795, -1520678058, -628871821, -107864166, 1845717615, 1746549717, 562509653, -300519864, -872209179, -218475127, 1436283611, 1689946580, -1690344534, 1234223088, 942631853, 1512997923, 1530680906, -984901396, 2078495305, -1792233323, -2024796935, 1660595082, -1851395796, -1993727329, -1865821359, -1097944232, 228504090, -1872916049, -1557400496, 1283886849, -930777970, -1803088106, 1061969318, -1722721967, 1551884020, 562949781, -1241712556, 90665740, -2114655155, -2087921324, 1542514017, -1284779930, -247289406, -1819729567, 146228995, -984027588, 545212168, 589147122, -1879615443, -19725499, 1367487616, 1788913726, 15457233, -832176379, 1346634828, 1556325376, -350244192, -1061100563, 1283449852, -907245358, -868043171, -1896592814, -555780242, -946146864, -502229401, -1733197444, 1040949548, 1737873862, 534010271, -1037925468, 88804631, 1159169040, 317468564, 1679846783, 95151758, -1682288809, -1226734754, -1803618722, 110064492, 59007035, -301467327, -1906955058, -1309655716, 804790986, 446704220, -19385488, 2012080851, 714464989, 1608564624, -144671772, 43274490, 613639897, 1314539480, -1686980190, 131524208, -155139310, -1553075801, -832065573, 728270170, -1024770063, -899946256, 1596980735, 1010964085, -1193275992, -128266394, -632465207, 383553724, 394708823, 361924107, 452267816, 495170699, -241592568, 1880784692, 1865340053, 280339625, -2132404216, 760512728, -301327442, -1920787789, 1435275780, -588759357, -254336704, -319662986, -753981090, -851021452, -1332136862, -2079409286, -1818602268, -16197703, -339574636, -1842378981, -1849052383, -716103001, 1406573125, 1784426094, -797669799, -366083354, -633449243, -1431549349, 1545192114, -344585474, -2074540072, 1299564055, 597067833, -385220571, -423100270, 1453901687, 1689288475, 2122785810, -853998204, 1366045475, -1457516090, -874149954, -321210003, 1205906080, 248821375, 1786198449, 255491708, -1483956599, 363015852, -196917981, 1781948081, -1603500631, 254927042, 1864809227, 176420919, -946282151, 280382312, 525692779, 388652947, -983840361, -298049338, -1202354395, -2070502485, -543403685, -1740748908, 1830546183, 228046831, -1518353107, 1510616207, -1700037372, 1301439827, 2140543797, -621690517, 1922561108, -1067626533, 916363997, 1796207548, 551145834, -1367757162, -1965533251, 1953758403, 1635791149, 384135505, 1265995468, -459001902, 226762909, 1292952530, 1301780510, 516752617, 462310155, -403917797, -1314683268, -1457683363, -409296984, 936482401, 854627768, -1260775761, 468621726, -76129545, 596295234, 759821017, -1635351848, -435857497, 1315580922, 758747456, -719567510, 408022062, -1050457648, 147150129, -406116219, -1180483951, -1198164309, -1122052410, 1463028901, -2083454355, 509332648, -53770125, -1633334177, 1174168678, -145648376, 2002879306, -1218798640, -271664986, -322271150, -1106185811, 1958841672, -246568598, -1579771586, -1966527092, 1674163245, 397814745, 1040662924, 1349758766, -2059901383, 518388384, -1070596654, 1032089410, -1064608528, 308419521, 1095465694, 1590221331, 16909890, 1875876227, 524956790, 2102546145, -1576146084, -1046170188, -434272871, 820981971, -817100897, -1943490422, -1276632307, 418227978, -1961834793, -2028475568, 880525749, 174092129, 1369682152, 1951215466, -370273404, -2090707126, -1522112761, 961501097, 1124558141, -63013189, 394710399, -1472917206, 440713354, 56440672, -781869631, 1398814559, -1452709118, 1623550796, 1063757860, -844283815, 806041497, -780817159, 175565823, 2029623804, -606838829, -1784398182, -847027118, 28021597, -745705202, -1477106129, -2107280135, 1459499704, 311103770, -2067638146, -803509548, -115310883, -1340040933, 461008589, 542163615, -792864923, 5749314, -863619891, -1406704522, -1845734065, -1823398157, -620150752, 1845301625, -4926848, 229943204, 1541482682, -397425509, 1526557426, 901057523, -982911748, 2085092306, -448375894, -1983993901, 1925748307, -952208377, 1371042564, 1099308026, -1517975454, -1700357459, -2100570007, 27371395, -2051406639, -1890905615, 29566764, 2038836666, 429641100, 1738148089, -1603323720, 363359674, 350124656, -803675942, -408035639, -68858207, -428420006, 464086395, -1921349019, -1366949487, 677956012, -1619266562, -251072025, -512476595, 25765024, -1413485560, -1660201199, 1066578620, 873121240, -771730838, 963313071, 642752650, 518387639, -682346138, -119137663, 1472454073, -972934399, 1441545211, -1452657240, -1648215903, 442550653, 1939696613, -2140700405, 81948795, 1881798870, -1540230695, 1248308425, 1137664870, -1146685581, 304822303, 204152863, 1243389202, -2098450792, -483762554, 1809695983, -1326027535, -1939376947, 493364722, 1282935673, -1495366419, -1314575195, -504028251, -509512053, -637655796, -1188738819, 696027558, 1300021166, 1680297734, -517272632, -956224564, 718431891, -263925706, 784880359, -2142539044, -369069013, -33547528, -1977701481, -806996075, -578727752, -1865674347, 891517444, -1494321622, -1141633737, 266742791, -558577215, 1178512320, 1489781080, -1173752401, -671040140, 1546869231, 1986570741, -1163685075, -570167470, -1545674854, 2146548324, 556284296, 910798211, -1629233108, 1449281193, -591701734, 318376273, -101616558, 1914340522, 773632165, 773537639, 83420414, 1209023716, -1216136738, -946669277, 1964912130, -710384505, -247959903, 309307196, 1918569585, -1449554780, -1525597680, -267759162, -216757061, -418265938, 1412629449, -785935768, 2065210165, 2069641496, -7919621, -1748138218, 1611290972, -602409419, -1946203988, -389574433, 1342798931, -423454218, -1447353131, -2090305133, 1920825605, -393838882, -1202526291, -90116833, -128284981, -1347879247, 612958209, -1201130561, 1593113797, 59260669, -1165521519, -2063792372, 299078249, -353745821, 741620406, 168644672, -103537472, 2102718904, 2112427045, -280243952, 1584846967, -1179023106, -364430955, 1650991618, 1447859026, 382453169, -970746228, -2127414251, 2113269997, 2107961641, -1675438093, 478022125, 1262380937, 771494478, 2131016848, -403750313, 476619602, -984357148, 1903070663, -30162795, -1025526053, -223696849, 1166783636, 1891290640, -1240789318, -891846931, -1435900262, 2049918140, 1663024704, 1695205623, 209717778, 317646747, -1694718761, -1328341621, 1356805679, -997856064, -1155495976, 448064778, -1104282476, -2032648875, 85129998, 389888588, 484803091, 262631277, 1397846623, 1472746928, -1305308840, -1328345097, 314572330, -1366949063, -1714659477, 836555031, -77646083, 1210903489, -889040280, 545394970, -569662922, -354960617, -1311203190, -1932212937, 1427856093, 1201846310, -270071057, 1155623004, 469747517, 1194475025, -1187655679, 698731619, 1099752519, 872564412, -200654955, 1947399625, 489865692, -2129931202, 1099422593, -1682689094, 1442937051, 1129761969, 168966829, 1669407783, -86625846, -564796610, -579290150, -1229577007, -190553895, 696640097, -1492973388, -1935298993, 289195975, -1902683548, 814435566, -949680227, -518340960, 450912737, -1166801219, -2117541638, 1855820953, -2051782929, -1608546083, 1990553379, 1718090996, 1188620792, -115523415, -147061891, -1382870091, -214376004, 81445447, -868802590, 1974295000, -1166489785, -711047964, -944925706, 747544812, 1421504909, -209105949, 1122117739, -604200794, -715677704, 2136130913, 803320581, 923682916, -1465562202, -993753912, 809078319, -479796226, 1333552047, -1090098908, 1636137928, 1370005520, -2024007915, -700235606, 389790739, -1211709922, -1392676128, 1908728903, -439130602, -998247909, 1866426437, -1884401972, -999291751, 1040054189, -186092586, 612518919, 1834695956, 303886146, 893614295, -7330592, 50142697, 1967545404, 1449424655, -803705144, 1169726147, 1807316898, 2075417224, -1127341774, 1395478548, -1983908212, -475721202, 733613916, -2125198184, -305820094, -1872511747, -1353777044, -130990802, 1780588369, 876314951, 1966282316, -468601571, 666799576, -278928941, -285642146, -720495685, 625882438, -1295203645, -56334807, 621973575, -786584082, -1517585087, 804082754, -154829089, 28228407, 1567897954, 79278357, -1968428397, 223307196, 1278261077, 991618876, 372296756, 745604952, 1942656377, -1049168943, -1385489734, 1424138956, 1677508797, 1727480012, 1355194782, -2109214504, 662013219, 1503349682, 926380517, 945124304, -1320573585, -2133614137, -1976360516, 1495183391, 373972614, 1422718069, -1951255909, -470135917, -719793202, 541980795, 604353694, 1067558561, -2007139598, 188984310, 1451566286, 557690320, -1184617985, 849081456, -945435934, -84937984, 1807199109, 757685972, -1104835149, 27666269, -2128154057, -1960982195, 1634373196, 1793194941, -1961538309, -360586005, 211418157, -37047406, -260012252, 667845959, 1168793817, -795461975, 705450313, 1683252090, -1893602851, 433841938, -1967653785, 1159883966, 1416795911, -590749780, -415924779, 1352594187, -398533309, -1923193249, 439801813, 1740554176, 619337737, -875008452, 254224026, -824861121, -1834334811, 1096643741, 1652353402, -1247623228, -1212638079, -1264446962, -1088353601, -2131832893, -1931198107, -676045177, -893652640, 189190988, 450935954, 1297939244, 1464873694, 1548299678, 105594994, 1161656198, -436866516, -2004388416, 1951445164, 948803062, 567178581, 1604794340, -70277976, 108723609, 953804101, 1721823826, 881641706, -1282678401, 1941136122, 258691017, 1790167374, -1281697359, 1225476499, 717299776, -1930756900, -2140108849, -1242969589, 1701385534, -289641991, -522731027, -587790146, -1581663225, -580358105, -644477262, 428305218, 1759484364, -582876795, 1101781151, 2025933254, -663505004, -114620174, 360998270, -570767239, -1420855599, 1264109935, -919970008, 1046254950, -549488177, -1312615059, 438032726, 942988635, 545487202, -1393321788, 931040906, 1452923347, 163219659, 1606357360, -1155198391, 978545090, -1925190743, 784814444, -1681121482, -950689282, -1454014906, 626328415, -1226679876, 1920485148, -1292045522, -383402595, -728906165, -603016613, -1192588236, 1131717378, 1207342360, 228020488, -1307768069, -1846990762, -644237927, -394111640, -866205922, 1222931995, 150717413, -1918699959, 1005669141, -404039336, -1170172666, 519202501, -829888959, -663095448, 1688479759, -390950192, -717065099, -1067165901, -1857205235, 1796481507, 258818131, 253630944, 1023928602, -511015171, 1154453982, -2132370924, -646156730, 394850123, -780951132, -1650270642, -1863776171, 806481102, 895775233, -1132421201, -1863209915, 377583762, -1016212849, 1059458487, -736734590, -1264334131, -112086956, -269788845, 712617539, -459839944, -1636878778, 2058220116, -1878205203, -849105400, -422237794, -668437315, -1381567706, -563551853, 1723266336, 47765215, 1496186422, 1503550057, -125578142, 1100862626, -985079489, -229982027, 1111529665, 825613918, -1978514766, 963776113, 1284549101, -359399809, -1037746999, -439704035, 1652117092, -830299392, 1744106886, 2143641866, -2085591175, 2000150091, -314217062, 227511412, -1387249433, 960404034, 1046449123, -2106534884, -587805728, -1919793625, -480496189, 337123311, -1020657195, 907875004, 124542507, -1780434528, 388704115, -831131438, -1592781525, 386539664, 1110413080, -1905966667, 1634898457, 1648622891, 1804154210, -379419726, -1825839844, -572307638, 2142642457, 1061172721, 1891978512, 4624657, -1851418573, -1679942049, 866779344, 1225389324, -2048978341, 1060073495, 714495597, 1538646405, 511647427, -1967797470, 1568889959, -1495888586, 583528755, -162685899, 1498822729, 1439781451, -236964190, 627584945, 1308481198, 129801311, -672920394, 931655449, 1498727318, 2107633825, -142079252, -1174193931, 1497835734, 1831804579, 958195144, 37853681, 906911034, 367372173, 1723934243, 170827652, 959883967, 1836691899, -644474517, 776163394, 1253280081, -313587646, 1825642510, 1513922723, 135156070, 559034688, 490296190, -1358119030, 990459247, 48944914, -470548024, 2004271283, -265023728, -519084868, -1296855632, 1495932932, 721252037, -923345591, 2114192665, 183027883, -1268998262, -598957944, -1115247878, -1575578340, 2032348581, -517071494, -768636283, -1225317708, 2135415147, 1562974572, -893300652, -72260661, -1738011382, 99706926, 1709813671, 690368621, -1198406633, -955759845, 693896663, -957704843, 1835653459, -987532910, -1312939609, -2142663388, 1002994576, 1587703247, -1209786461, -1627119363, -638524933, -2123469024, 566491660, 2030866040, 423221588, -1836204545, -722344737, 489356874, -1882607149, 631175395, -675968916, -1158255414, -1885230835, -1309259465, -768892771, 124814633, 928668904, -1452252012, -603838256, -1295673794, -1463281206, 1337400020, 1512700402, -1491853080, -580738227, -2089610523, 1944003790, -1898246656, -1761098828, -23539193, -493452986, -1737724666, -183549507, -862022286, -700192924, 1890810339, 452746615, 1986196376, 395172442, 1658738571, 655297208, -1090025052, -695778340, 1538336324, -784555045, -1119803335, 473416771, 1859709551, 1574315978, 1016481366, -414640434, 1069674980, 696391877, 364234264, 1075569750, 570296741, 168713113, -290948820, -171521457, 2005507964, 1770290632, 1437734707, 2073037050, 1331731973, 964596280, -859345009, 490424759, -1066985826, -1628327668, -22488054, -1069719867, 1073599985, 1356245452, 724175644, 1203774163, 498883626, 174971448, -269670189, -1437495243, 2021007183, 301539292, 21983808, -1104865907, -1532104476, -1129125249, -927191023, 1237932550, 534267259, -302150750, 781319099, -756906233, 309894062, -588906123, 1141663721, -958268050, 1154197756, 527538970, 1397619793, -1385930208, 115148942, 963261013, -856116620, -1948570194, 1492566691, 449479633, 1572632730, -760794688, 1506574586, 310266631, 1708123868, -365064214, 1391620122, 1734995851, -1094995937, 134033848, -1649824162, 1273954158, 793218589, 749070227, 621165833, 541605246, 1543256771, -189620375, -891615263, -538118527, -575318922, 114212509, -1867960973, 177624847, 163723515, 576697073, 924576492, 1736781818, 1244234021, -742876105, -2119734823, -1860219311, -428003428, 1895890760, -2063265639, 381162652, 617426098, 1400070062, -430686797, 226909888, 1041198762, -156954869, -352778839, 761829847, -1801513366, -1197711290, 1386005591, 252691761, -1368604635, 1414032745, -1468072074, 1586039731, -326630320, 1373259660, -128643635, -2005079605, 1478832775, -174542941, 1170423344, 845676809, 74161063, -538806516, -2034761264, -426387303, 952105052, 1562593153, 666765638, -1896124171, -125869045, 1680592242, 224426702, -601540224, -1693966380, 1575233237, -1004451096, 1637328591, -2036781366, -424865281, 1965434933, -298989152, -601333195, -807166317, -1775487796, 1944948436, -829211454, -676905446, 75847837, -2141102173, -1548810865, -824960110, 1104428980, -1277542418, -2061761740, -1461031804, -1955363633, 1874307169, 1719308435, 397738282, -1374067884, 287506422, 276308804, -1279787202, 1483713089, 1069834334, 1027006143, 270051053, 302293394, 475130203, 76024651, -1466437690, 1292852338, 1084308315, -1968476804, -1744893400, 2024055784, 964156537, 1026299374, 1807534178, 1503364751, 377496453, -1034422309, -1936137450, -1137666766, -1600951737, 2082302552, -2068487877, 1949398040, -1003150183, 644241020, 1232269624, -1053093749, -2045784004, -833447625, -812177016, 1873826464, -2057482371, -1453556943, 1471949989, -779895890, -1700528399, 287491150, -1438988012, 2047132969, 1315904010, 2076146374, -24304945, 985573139, 229462976, 159245162, 2091612109, -996819937, -1091829900, -703671860, -1449517283, -1583451623, 1391926053, -881869957, 164314566, 100272621, -1298763483, -913706577, 215988655, -1548875413, 1652843222, 1011039614, 1442018224, 1095825648, 1697711728, -1695399170, -2096327520, 983250546, 1661838846, -2099583487, 360497980, 843848120, -1486334794, 1290341080, 1071288734, -713554896, -408876060, 2089401029, 757021179, -251878220, -281884348, 581419982, -1586812832, -1077450665, 1382117099, -1424143269, -1321068337, -543630581, 957294443, -1835273059, 1963155222, -1120400937, -1631069321, 212554361, 101822772, -1846802587, -1416910909, -1101946315, -2007473134, -211581129, 91369193, -1107631786, -1043407276, 693035544, -440498734, -1700973671, -1541680443, 689955716, -1632341273, -1105398010, -1460171278, 92491781, -1589307443, 572044900, 875380771 };
            //]],[-760627172]
            //   var rp = new RandomPick(picks);
            //   var r = rp.MyPick(-760627172);
            //4857.



            // var mcw = sol.MostCommonWord4("Bob hit a ball, the hit BALL flew far after it was hit.",new string[] { "hit" });








            // var s = sol.solution(529);


            // var r = sol.rotateRightKtimes(new int[] { 3, 8, 9, 7, 6}, 3);
            //  var up = sol.FindUnpaired(new int[] { 9, 3, 9, 3, 9, 7, 9 });


            // var me = sol.FindMissingElement(new int[] { 2, 3, 1, 5 });

            //  var fc = sol.FrogRiverOne(5, new int[] { 1, 3, 1, 4, 2, 3, 5, 4 });


            //  var s = sol.findsmallest(new int[] { -1, 1, -2, -99 });

            //     var lkf = sol.LicenseKeyFormatting2("r", 1);

            // var sa = sol.sherlockAndAnagrams("abba");

            //    var ts = sol.twoStrings("hi", "world");

            // sol.ShortestReach();

            //HackerRank hard question:
            //var root = new TreeNode(1);
            //root.right = new TreeNode(2);
            //root.right.right = new TreeNode(5);
            //root.right.right.left = new TreeNode(3);
            //root.right.right.right = new TreeNode(6);
            //root.right.right.left.right = new TreeNode(4);
            //sol.levelOrder(root);


            // var queries = new List<List<string>> { new List<string> { "add", "hack" }, new List<string> { "add", "hackerrank" }, new List<string> { "find", "hac" }, new List<string> { "find", "hak" } };

            //  sol.contacts(queries);
            // sol.runningMedian(new List<int>() { 12, 4, 5, 3, 8, 7 });

            //    sol.searchSuggestions(new List<string>() {"bags", "baggage", "banner", "box", "cloths"}, "bags");

            //     sol.searchSuggestions(new List<string>() { "mobile", "mouse", "moneypot", "monitor", "mousepad" }, "mouse");




            //sol.countAnalogousArrays(new List<int>() { -1, -3, 2 }, 2, 8);


            //   Console.WriteLine("Should be 0: " + sol.numWaysSplitParen("(((?"));
            //   Console.WriteLine("Should be 1: " + sol.numWaysSplitParen("(())(?"));


            //  sol.RemoveElement3(new int[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2);




            //sol.arrayManipulation(10, new int[][] { new int[] { 1, 5, 3 }, new int[] { 4, 8, 7 }, new int[] { 6, 9, 1 } });




            // 1->4->0->1-> null
            // ->89 null
            ////->89->65->6
            //  var n = new Node(1);
            //  n.next = new Node(4);
            //  n.next.next = new Node(0);
            //  n.next.next.next = new Node(1);
            //n.next.next.next.next = new Node(89);
            //  var v = sol.GetMidItemValue(n);



            //var ipn = sol.IsLongPressedName2("alex", "aaleex");

            // ipn = sol.IsLongPressedName2("saeed", "ssaaedd");

            //ipn = sol.IsLongPressedName2("leelee", "lleeelee");



            //   var m = sol.MinDeletions("ceabaacb");

            //var m = sol.MinDeletions("aab");


            //   var m = sol.MinDeletions("aaabbbcc");







            //  var m = sol.MinDeletions2("bbcebab");

            //   var md = sol.getNoOfSwaps("mamad");




            //var l = new ListNode(1); 
            //l.next = new ListNode(2);
            //l.next.next = new ListNode(2);
            //l.next.next.next = new ListNode(1);


            //sol.IsPalindrome(l);



            //var root = new TreeNode(1);
            //root.left = new TreeNode(2);
            //root.right = new TreeNode(3);
            //root.right.right = new TreeNode(6);

            //sol.TreeOutline(root);


            //  var e = sol.StringEncode("aabcc");

            // var cw = sol.CanWinNim(5);
            // var mp = sol.MaxProfit3(new int[] { 1, 2 });


            // var ms = sol.MaxSlidingWindow3(new int[] { 1, 3, -1, -3, 5, 3, 6, 7 }, 3);

            //var ms = sol.MaxSlidingWindow3(new int[] {1, 3, 1, 2, 0, 5}, 3);



            //var root = new Node4(1);
            //root.left = new Node4(2);
            //root.right = new Node4(3);
            //root.left.left = new Node4(4);
            //root.left.right = new Node4(5);
            //root.right.right = new Node4(7);

            //var c = sol.Connect(root);

            // var bs = sol.BuddyStrings2("ab", "ba");
            // var rv = sol.ReverseVowels3("hello");

            // var max = sol.rob(new int[] { 1, 2, 3, 1 });



            //var root = new TreeNode(2);
            //root.left = new TreeNode(1);

            //var d = sol.DeleteNode(root, 2);

            //  var cc = sol.CountCharacters(new string[] { "cat", "bt", "hat", "tree" }, "atach");



            //var root = new TreeNode(3);
            //root.left = new TreeNode(5);
            //root.right = new TreeNode(1);
            //root.left.left = new TreeNode(6);
            //root.left.right = new TreeNode(2);
            //root.right.left = new TreeNode(0);
            //root.right.right = new TreeNode(8);
            //root.left.right.left = new TreeNode(7);
            //root.left.right.right = new TreeNode(4);
            //var lc = sol.LowestCommonAncestor(root, root.left, root.right);


            //var lRUCache = new LRUCache(2);
            //lRUCache.put(1, 1); // cache is {1=1}
            //lRUCache.put(2, 2); // cache is {1=1, 2=2}
            //var r = lRUCache.get(1);    // return 1
            //lRUCache.put(3, 3); // LRU key was 2, evicts key 2, cache is {1=1, 3=3}
            //r = lRUCache.get(2);    // returns -1 (not found)
            //lRUCache.put(4, 4); // LRU key was 1, evicts key 1, cache is {4=4, 3=3}
            //r = lRUCache.get(1);    // return -1 (not found)
            //r = lRUCache.get(3);    // return 3
            //r = lRUCache.get(4);

            //var ii = sol.IsIsomorphic("foo", "bar");


            //  var fi = sol.FindOcurrences("alice is a good girl she is a good student", "a", "good");

            //  var fi = sol.FindOcurrences("obo jvezipre obo jnvavldde jvezipre jvezipre jnvavldde jvezipre jvezipre jvezipre y jnvavldde jnvavldde obo jnvavldde jnvavldde obo jnvavldde jnvavldde jvezipre", "jnvavldde", "y");

            //var fi = sol.FindOcurrences("we we we we will rock you", "we", "we");

            // var fi = sol.FindOcurrences("ypkk lnlqhmaohv lnlqhmaohv lnlqhmaohv ypkk ypkk ypkk ypkk ypkk ypkk lnlqhmaohv lnlqhmaohv lnlqhmaohv lnlqhmaohv ypkk ypkk ypkk lnlqhmaohv lnlqhmaohv ypkk", "lnlqhmaohv", "ypkk");


            // sol.GameOfLife(new int[][] { new int[] { 0, 1, 0 } , new int[] { 0, 0, 1 }, new int[] { 1, 1, 1 }, new int[] { 0, 0, 0 }});
            // var d = sol.DietPlanPerformance(new int[] { 1, 2, 3, 4, 5 }, 1, 3, 3);

            // var d = sol.DietPlanPerformance(new int[] { 6, 13, 8, 7, 10, 1, 12, 11 }, 6, 5, 37);

            //  var d = sol.DietPlanPerformance(new int[] { 6, 5, 0, 0 }, 2, 1, 5);


            //  var lsw = sol.LastStoneWeightII(new int[] { 2, 7, 4, 1, 8, 1 });

            //var tm = new TimeMap();

            //            tm.Set("foo", "bar", 1);
            //            tm.Get("foo", 2);

            //  var lcs = sol.LongestCommonSubpath(5, new int[][] {new int[]{0, 1, 2, 3, 4 },
            //             new int[]{2, 3, 4 }, new int[]{4, 0, 1, 2, 3 } });

            //var me = sol.MissingElement2(new int[] { 4, 7, 9, 10 }, 1);

            //var r = Result.foo(new List<string>() { "apple", "apple", "banana", "anything", "banana"}, new List<string>() { "orange", "apple", "apple", "banana", "orange", "banana"});

            //   var r = Result.foo(new List<string>() { "apple", "apple", "banana", "anything", "banana" }, new List<string>() { "banana", "orange", "banana", "apple", "apple" });


            //    var mu = sol.maxusertrafic(new List<int>() { 1, 5, 5 }, new List<int>() { 5, 10, 5 });


            //  var mu = sol.maxusertrafic(new List<int>() { 4, 10 }, new List<int>() { 8, 20 });

            //   var p = sol.findpassstrength("test");




            //var root = new TreeNode(5);
            //root.left = new TreeNode(3);
            //root.right = new TreeNode(6);

            //root.left.left = new TreeNode(2);
            //root.left.right = new TreeNode(4);
            //root.left.left.left = new TreeNode(1);

            //var ios = sol.InorderSuccessor3(root, root.left.left.left);

            //var nwb = sol.NumWaterBottles2(15, 4);


            // var ndt = sol.NetworkDelayTime(new int[][] { new int[] { 2, 1, 1 }, new int[] { 2, 3, 1 }, new int[] { 3, 4, 1 } }, 4, 2);


            //  var ndt = sol.NetworkDelayTime2(new int[][] { new int[] { 1, 2, 1 }, new int[] { 2, 3, 7 }, new int[] { 1, 3, 4 }, new int[] { 2, 1, 2 } },3,2);


            //  var md = sol.monthDiff(new DateTime(2021, 1, 5), new DateTime(2020,12,5));

            //            var trie = new Trie();
            //            trie.Insert("apple");
            //            var s = trie.Search("apple");
            //            s = trie.Search("app");
            //            s = trie.StartsWith("app");
            //            trie.Insert("app");
            //            s = trie.Search("app");

            //var sb = sol.solutionbalanced("azABaabza");


            // var ri = sol.recentitems(new List<string>() { "smartphone", "television", "smartphone", "television" });

            //var ri = sol.recentitemslinkedlist(new List<string>() { "book1", "book2", "book3", "book1", "book3" });
            //double length = 10, width = 20;

            //  sol.abc();
            // var class1 = new c1();
            // var class2 = new c2();


            //var t = sol.ThreeSum(new int[] { -1, 0, 1, 2, -1, -4 });



            //var iv = sol.isValid2("ebhcgicceggecgdcibbeicigehhebabiehbdgaeaigihghbhigihfebgabicbgfhhedgbfehiahchcecedffhccebifcbdfcfaecicafahfiecceeaabbecfhgbfifabbffadcieeaiidddhfdeccaedbgcfdehbadihheieidgcfbdiiicgahebfbbdfeffegbdhgdagefhbgafaabfghdcbfdhabhfahbdhgifbghhafcieachcbeabccbiigdcfegcccfafehegbiecbdhabcffggiifaabfagbfdfbfacdcafabccgibiidgabiabigbgbbaideeagaaffcddhieicehhchfedfgbgbfhgedhacegaieeedggacbbgadeibbbcdhbabbieibcfbhgdbbiecdhbffaghhchhddcihgdgbgdcfgfggeaahffgiddeadgcegaiddhhdgagdidgacafececiebeigcbdfaedibbgbhciihcdifbacdagfbcefifefchhddadeaiegbfaidbeebiefghfghhdabdeegabagfbbdgbeaiiigeaadhbgebedddfihagdeiccdbcfchgadhgfaidaebfabbagdghebgagbfhfbgeagdgecbhfchebdgafceaffabagedbhcgcedaecdbiifefchcbgfbbibhiahchhfadffeacfbgeigaccedadaafhcieficdfhfheibfdhbgbfhhdfcghabacggchchbdaigbcihhdbifcdeggicgacehebadbdaibhdciefdgfhfeggdhgcaeeeidfebbaicgagcaiachffhadbddhhdbcehciagfdgeadidfcaaiafeadefbbbaidgiagbeacchbdaifgccgcfigefcachiiggbghfhbifciafgfigaabidhdgffcbgicbidibacbgfhddafbegdaagbhddceeifecciddigfiehdbdabahgaechffidebhicfcciahhchebdbeieafficbbgefddeaaeacbhcfcdfhheifbecacffghihgiffiibghgiaffighgbfaggahfdcffhefdeccaabgeifdbefabibebdciacaiidhdicbadiehhbfehbhbeadehcghfhheifgghiaifgedhhabgcgaaghaecdiehihfhgebhfchcacdddaaghddifcacabfeefdgbadeigbagififffcaegdbdbdibdcbfcehahchfigeabdiecbhgaiefchhgibagedaddegficgcbbddahddiiegeifafiaffbfacgchhhdiccgaccefabbdcgibicahabebifegfgihaiaddiifbcedicbdcigbcehecbdgebfhidifibcdgdgffheachhhcihfdbbiaaheihidacfeiabefbgbedgigiieebdbeibhfcifeccdbefgeeeecdidgibdeidcecadbidbahabieheheedidaicbfadhebfdeibbeeiigddefbccbiacdfgbecadeicabeacbdfefahbaaecdggfbhbbiebifgfcbbaigdhdcgfhdcbcbebcfhiaahfdiegghgcdcabdaigbdhgahecgfgheahifdbechebhbgheibebbaicigbgbhgfdcgchidcgebgbecifeaafhcfffehddifeifbdfcgfefdhhaadfeaaefaegfifgaeaicdhdbcfhbhabacihgeahbcchbhhchebefcbhiiibedaeifdfaggfbadccgbggfgffbfbibhidfagidiagdhcegcbfgadchfhdifadabaffbcidedeifcefdbegceahgfghabeefghichechbdcbdefeafbacgadegedadcbaggafbabfbegabggeahghfadecffcbhahdbhccagciegbgacbabfcbiffabcfbaghafghchcaigfhiededeefagdahafggigfeaghabbcbcbfdhfgdififdaadidhhdcigdgbahgbbfbfiiciacdicifedaigchiaaagdcigaiehdeagicigidibecieefbhadgfcgbdebefhffdgfdfiegbdcbbggbeccbbcbbdadagdaiggbdacdchgfigefchcbdbbicachfhceccidcgchdafdichghgfbbihhadbhccceggcgedfahgapgieacfdeffcddcadcgabhadhhfgfdacbhabggbedbhgfbidgfadeefbcigdaebcbehfgeaiebgiefbhidcdfhbbieahhddehgceicicfefahiaicciddhaifegciddeaedfgehddcafgihbfdgabebaifaeibhcaabifiecbcbdbhcidihggebfgadfhbbecfciegeeibfcdcdfaiedaacgdefbbiacbbcffdgahgachddiefeceffaabbfbaadbhgiidcffihihedhfdefeecdbgiibbbbahchfffhfbdaifiieebcfhfadgiaabccdchghehchcegdcghddcbffbbbhheeagaceighcdfhfhdhgchchehchadcadcidhebefgfafcihigfdigfahcdafffgadbfadccgddeccifecabicecefaiadgibfhgigbbdegfdcicfehhffeifcieeedfbeiccfefecbghifbbebcaiecachgaagfhaadehhdfhcahcediefdbcbhgbaghdfgacfgibacaggcedfbgfdcbfiiiihhheiehaehidbdaafehgefhfcbfeacifcgicbbdbfaddafhcdfiacggbeffcgbagccadeeiagfafaiiiehddfaccgceifbbdgfddeifhiibfgebcbfdeghgbbaegeeaigcbabcdgacacfbigiahiighbacdcdbadahdfigcffhbeccgfihegidgahehbdgehdfhebcaaieahbigdaidifhcdbcegichdfagedibegfhacdfibiceecbciagbefchegddehaddcdhbedcbfdgaabcgfgigcgidcifighbififhgeecgihhehichadibafggedcdbeaaaegibbffadaaeeagebibibabddbciihciegfdbaegahfdidfeaddebehibfiahggiibgchebafggcdaahdidiigigiigagfbhiadgcacddceidcifcdcegiahdgbgieegbgifhaiihbcbebgbfifedbieefdefbfdheidghehidhihddbhahiffegbahgcgbfbeeacdfeefifehaadhdibfigaebgebdaahbebidhhfeihcadbabgcagceibcedbbfgbfifgcedeacfffccdeafabdfdgifbebhghfihacdfhaacbfhgcgbehbicghicbfbbdbcgdiedgcgiibfcahcacegdeefiiefgabedchdfecfddecdeheacdhcficecdhidhbgigceachieadaffafccgdcdhffcacbgdagacdacadeefgheifhbciehehafcbhdbhafdaidbbfdeadiddiecaacbeifgcefdfieiabhffeiiigdhicgadbdafiagcheigiihaaaaafdhafhehacgfhhhihdbagbgibggcgeaghccdgbcicaichgfceicadagahgcecgdfdcegieedidfbcdfabiacegaeecddbaeecfiafibbicibcggdhgfgciddhhbdhidebaabiabeccfgfbiffhgcfcgibceecfhhcbdcbccchbfcedefhfahfffgbedbffidahibfehcghcighgifcdihhfcaeagfbfbegbfciaehcaegeffffghbaacfdacadegeehidechhhdbicffbchhehachadcgghaidgeciibhhhgchhedaddgbgcdfhhddgchbbfaeechhiggifhgabgfdghfadgigbfggbibghbebhdifceafghghdgfhhihfegdghfcgfghibghcdgddifbchgibaeicffahgbgacifhgfdafggieiifhgaifhffddeidgicdddehiiihdheeafcagfiaigbcgeaadfbddacbeiiiigchhaedehebcbhhefifccdfggfiabfhicidfebgacbgaehhceaiffdfhhaghdghhdadccaddahccidhhehgciiigebghedfcchfaeggfagahiaecbidieeffhegbgbehhggdbeggeeadifchfhcibgdgabigebgbcfgiefcdadbibefahehchdaifeecdchichcaecebefiifbdecffichhdceadiegchcfaeagiigaebcaifbfhggddfcgghdddgedhibfcafidgeacahfhbffaefedcbhchcgbbccfffibighcechgbhdhcdefhfcccciaaghihccheihafgfbdbecdfddiaebdihdhbhacfbfbaccffcaabigicdedaeadeaabghhfdeidgbicgehfceefieffheebedbhgafceibhgiecgafdhicdhieeaihcabbifgeiibhbeefacieechddebgheacabcffeagecaihcdbddicfddhgbcceiggdhcagifcaaeaeeabhaghaiiaffcidedfagceiaaagechibdehebdbghfddhceiiiehggfcfagfeibeifhgbhiicccifibdghccgbafeghbgfgicdceagdcgcfibhbgffefcgiebigigcbiicbcdfibbhiaghhhebhfgabgeidihgcbehiagggbdbadbgbdebihfghcihhgbdhafcccbhehfffhehchiicidddcgidffbieciafegiahgbciegifachfaahfifbcdigfeehhcgfigiechedddigagbchffbgihigdbcigbdiidafahbafeeggeiiafcaacifehihfbdbbfceaedbdbghfififadchaigfbgcdacbbfdgehicfbecdfbdaegchifihdeehheddbhcggabddahiiahdieecdagadheaeeahdhaaidgicheeegdefhgafdbgciegiceaieaefiadifbdidgddcadegiacefbeaaedgibfiehechidaaaiiaiieeaeafgceeegdicaachdeffhcfahbedehccbefchcechdfiaegbhahiegdigbahciicadedcbfefecbgbefaahifhdefgbhgahffiihbeabeigeiahfidfbdciabgeefhegecefbdeifggcdfiffcchidgcihicehfgfdffcehbifgafdgfgaciadccabeefaiahhceafgceacdhaihbhfcegaehfcaecbbbeggagaeeebchagcdigagbdaeieechdcahheigefefhfhebcdggebdifedgdacbgghfcbicdbceeecgcfihieiggaghfaebegdghcbfcgfagiheadhhcdchdhahgdefghfeabbhbeibagfabgdiaafhcffebhdccihhcdabghaiehefcbgiahecffgigciheahgdaebeieaaghbeeafbbdcfdhbahdbgegbigagighcibbhbdhaigcfedcdhbeeccabfieghaibgihhefigcbcbbbbabiebhhdhbahabdbggaeggciddfagabfaagaadcefdhhhchacbebidchdhgfaffccefbahcdddhfbeibdcidcihcceiccgcbfiagcgidehfbaheeggdffhdigbdebcbdhddbdgieefgeffchgbhhbeidifdefgafbbhchhgiefeebfdadggdbbagbhhaeciiefdiigaiacgfaaedhhdaechbhaacdcbheeaebfcgdigacficbahdgbgiahihdfhdbcebedghbegdiabgfeagafiegbhgbieebcadgfgbfchcgfhdhcecaihdhgdhfchcbhecigcaahfegcdihieadfgaeaghfadgabhfhaeabiiefihhegccgchddhhbdiebfcefbggddbheaceeagfibaahigedhbahhbcdabibdcaigeigabichcaeigbebddedchdcdidegagidgaififabbcdibfcahffbhhfgebiehiddchfeedeihecibagfbdiggigheebhddbffhiciidiaicdacgcaeffcccaibgdeacfdibecccdbggcgdihhhbibaiahbbaghffhhdfegddchgbgchbchidfihbchcbbchdficifcaagbbbhdedeidigbbgdaafciehficiagdhgfiehdiabdbfgdegdgacebdbbcfedahihbibfefgbfbbhdiihhhbhdhfbchcaffdeegbdggccebhecdeahdeeficabacgebcegbedagacdhhheibacghhdeeigabhgfbiafhifbhfafhiedgibceacicbdbabfgfahaecbifdabidgfdebdcefcfbaccdhdhihcffihacbaaiihaeiggehehegiiicbafdacgggcidgaadchbcbgaibefbcbbbbciceedihcgaecgdgaaadcbaiafiideabdgedghaegaeeahefechhgedbdifacifgbcgebgcdfddbhbfhcaecdbiaecdeeabacfabfcgiffgeaheaaiicbeedibgcciicfiiahaiibfeigahhabfaaaacaiabghfaefggddbbehechdcibacdhgeieccehidacbghigbciddiefhhidgddifebbbafaiihaehgceedhdchaicdgiefeadfefedhhcecedddigagdiiigdeggbbcichcbhhahghhccebafcgcacicifeecdchbehegeeaicicchgfhfcaeddeffaiebighigghigibicagaefifbiahiaiidibacchaedbdagiaeafgahaigdfhhhifbeficeabaafahhcgbhigcedahfaegfdecehbehcfcbeibgbdcciafhhhcfgcabhbhbccdhghfiefbgfhhbggdebhcehbgfdihegbhcihafihcdaeddddidfhiifbbdbacaabaeggaeahdaefgedcbbddbedaeigggbhecaffcafhfiabbcigfehcdecafdahcfigigddgehigdeegfibgegeieficaaaggfdagcagbifgabagfciaieebagigdgdcihdhdddhhdebcaehifafgggfgdddhbhhifbfdfiegfifcccddgeaagciebidaagdbghahgbidegbadgghdcgeafcgeidghcghehaigcgehiceicihgdbgggbigehfbfecggbcacfaeddfbecaiaghcggiagdaebhibhiebdfaiifehfbecgdcdbhdifheeeacaggcagbfcabadcdgidifgefaegfdeehcffcbdbcecihfacfhibhhgafbebgbdffibccfgaacadfbgccfcdbcfehhhifchhifhaghaaehgcbebhadegciaebcgchghgdgeebcbbciabhifcifigbihifedgcfcggdbfchgdbhidgihbiacfebfhfbiciedhggaeiiefidahfdcbbibhigbcehdigaicffagcddebcbcefidhbaediiaedddhgedgafcceceedagciacigeahegfefcceggbdeddaeeaehgfacdeifhfcehiiffcbibdcgcdacccciaigbcabbigbhiaaceddfahdidhiedcefaccafbcedfahidfdecedeeicedediaebhhegbgfefdidagicadihbfbegfhecagaecgfchicdfdcieehicdcfhfbigceficifggciggghdbhhgecbdiecdibhdbgaiagghdhfcahabiccbeccgfbabbfgibgehhggaicgdecaadfgeeaabagcieiiahchdcfdcfcgcbeabffggfagfcadbegbifbgfdhebcfdgcdcgdbifgaffdaigfighfabecghccdihigcchdaeddeffbgabfgegiiggccfebfcefbhfahfiiceahbedaggdfchbidaehacbacafdfhebfbggeahfadiibfbafegchaciieaiffhchbaabgdccgaafbahcbhgbgegiadaiehbidgiedddeceeiidiggafabicfhihaacaebeccgdfdfbeeheiiiaahehigeigighbfcehedfheafffcdhhgageheccfhaiafeehbaacacfifihgiibhaedidhfbiedbfedibgiaidadgdeegdbedabiehbiabiaebgdbadiefbeiabbcbichfggafceecehbaaccchhaifagcdgdahceefhebiaadgcigaeegcgehdbgfbffdibbeiegdfddidhbfchihbdgcggbifibbgddhfhfhggaagdgicdgfigdcdcahgicghdfhihbgdcdgfacfbifbbaaeagbfbfhcfhdhffeedeffaahebcbdecbbcedbaigicdfdhfhieggffdghbhbcbegihbgfbbgbgbgechbigebdefdcfadibfggadhfafbbbgiddgaeggbaceaebbchdcfcbdefaeahbbacggcacdbfaedeghcfgddgbhbgfaedbbefadbiieeccdfdcgccehbggcgegbebaecfhhcbadebfbafgefehfddbbebifbiegihheagdfaifhfbbbhggbdcchafehccbfdfceeffbfadhghdabghbfigcfccebidbcegidfifaedfbbfciaedhgcbbebeefcefdehdgdddcefbiggghdcdagcdgacbhcficacheghcbadhceehfbbcgeiedbaiiaidfaccieeccbgiaddhdiighgbbfdhbhaddcahbheibdbghhdchibagfcecccbdccidgcebbigdddcafheaiedfceidfhecchahgiadghcdgaideedcbaihdceaadfbiedhhdhdafcdcecgfaiecagieffbdbfighfffhfifhhcdcfbhabaafifhbdedaehiedagfagefeffigcfbefebieffeddfgccdcihieafcfeiaaebegahcagcgagfegfieaeaheaccdaeagdfiegdeaabgcbihhhcabichgbdeebgccheiegecdididfegghhibaadchfibbcdhcchbfgiaccgiibfebefhecbhbbgcbgicbgaafdcffbdegfichcghafabaafigfgigaeadeehgbdecbdcghchhicigcddabdbcfheddhbhhggebegghaihcdghhcfccdieacacfaadaadciigeeedaieaddaieegbfbaciiicegibfaahdbbfhffbdcgdeabfegfifcfigghfbdbfdcffieiiggeaeeghdedcbeagibfcbdbdcbgidggdidddbdeeabbaaefdhifceddghiifaehecghgehgefdcbcegebehaceaheifhbieiedgchaaihabfbcgieccffhidihbcaeaffbcefghaebcbfaccfahdedciadcghbahfdfbehdbececiaegdbbdhcffcahfhiihhedacbdhegadfacfbggbihidicagaghhbhbhfchchehhieeiehiecahdegcbaccbhehdacbfgecdgigeibedghihiccgbccedgegddiegeddhbecgcbificagbadehachgccfchdfaigdihhbdfdieidbceacgeccbdibcecgbhceidchdichehbiebhiheedaahfgiehfhabfiffhdccfabdhhhifehefibagbbaecfgfddhbbiegfccadfachggigdeiacdiffgfbcebdihchhffbihifgdfchgahfigiecdfacceihhaaacdheichdhdicadbdeiggbhhfaiabceibdfhhieciefefghgheaeabgibbiahhccbegcgbdcghfiiiaagiheacgdcaefabehdbadgeadghiegcdhehgchfaahgddeafiahdhiifadehchhhbghhihiabchbdgeihihbhfbifggbhhaaiiabddcefbdbfhegecacicdhcdaegacfibbbdgefcdbadbeehadhhgabhfeeaehbiciahfhfbehcedgbbdbeaedehaeeeffbhabidcdhgdageeiagdbfcgebfdabdbigebdfchiihdhfgcdceihdbabedfihbeccbaebeafceahibicieaigfdchghefiihhhcfcfgacbcdggaigifhhcdaaddfdcfbcdbbhfhdghhhgcbifbfgiibbcaegfcifbceeaefgfcehfecibafgefiabdhhabidfhhiggfdfiedfaagcggaaiccgecacbfegebehgiaecicagbgcebaacehbaeibieghbfadfhcddbahefdcghgfehidhfidafeccihdiaggdffbdcagbeeieebbbdccfffiaacghiigcdhicbadceggbccdbhgfacaeheadeeafdcggdfefbagigdcgaadacggdibcdgedaahgccgedhicgabiigchigiefaiaibficbffffbaiahahbhbghhhafbiiebhbhhdacdbiedghidhdadbahfcifieiddegifggdgbiahhdbcffhdbhbacibfeccgaichegghchfdeidigheieadddacifdeidicciabfdgdiacichgiahbfhaddbeahfcfhcggbeaacdifiegeihdcdcfbfegifghibhcicdebbgchaaaccgcedbcceaiaeiaegcehhaebdahfbhhhfbgafcifbfeiiagfbchfaceeiaghbiedichhhacbbicaifhcahgagbhfdbbbiagbadfieciaaecdghciigcgcfgbgcggegcfebeagfeaebafadfghaihaghgghibgdedfddhbcacieaecdeihhffaebdigceifgbifeidcfiedgaihfgbebdghidigdifcehhbfbeeadhagdfhhfcchacgifbeddehfadgbfghfdaafbehgbbcegdebchbghgafddefggggghhcehabicafbfhieabaaehbdbifhhcdgifafbcgfgeighbgdbeaechciaiaeiedbgfiadfeacgedfeaiehgffdhaahdhiheabhhidcihhaggdfdddffcabbagaafddceifgfdgccfieeehfiahaihbgdcbaaffebacfgffgbhghfiebcbcfhddfaifadeefhabbachhggedchgbdafhhghgeddaicefbificiggdbbbfiidifadibbbihhghaffcfggffffgigcbfggcgdhiheeghaddhhahiaibaachhfaiihagchdbdgcgiafaeiccabdebcfdfgeheebhaddhehbhaddhhgadifbcihbheiagdieiehcdefdieifciihbgfcddhceiaghhacehacididaiifceccdgdhaiiafaieagfdedifdichabegegiihfghggfhfibfhbbfdaiahaidgbfcibceadeieabbgdhacfgcadfgahcbdfbiaaafeehaiibafdbbfhhfagbeahdbfadgiiebgfagchefcifdfcifegfccfahhdifdgghgdfhfibfaedcdeceecfghiacddffgfdeeddacehbdbcecddehcfihicddbidedfdahheaeibihhfbgbhaedehccegghbgedaggchheaghgdegdichdgiabahccgfchcheaicdghhggdbdiaafeabhecfagcdahcafafffbebhibbddciiihcacbaaaefihafiiifigabcgceddehbdgghdcdgecbghfhcdgfabgifhcghfbifidchdeihiaiifbcihgcehabgffbbebaccigicfdghdhiaeccaididihaghaddaaihebdicahfbbccdchbacfgbdahagbgdigdibiggccibfaachiecccibfbbigegebccgddfeiibgihfcfbefiefbedfhiacgeeifgagbefegcgdaidciifddediafiaifhdecfaagibgeeidehbgghdifgafaeaddifafiebcddbiadehffbiacidhaibgegeidaibfghhgdgaheedehfedhbffggcdgdfaagebgafchgeghgddhhibdehhebbbfabbccfaagdfiafaffggibcahaegbbahhfeheghcaefhaehdfbcbefabcfacbaddaddghebchaiagaaaabaafidecaahdffecdgaeeibcdaddedcicdaedgbidefiiafieeeigifdhdddfcbhedbgeeehedgecdggchcibiddhedfbiddgfifbecadedhefeibechhfefiecbhaihaibghfbfaehgahagbghfifgidaiadiaeahhadbieahebdbggefbaiebhhdhafbgahddhfiaegfcdgcbhhdgehigebfbefaggbahabcecibdgdfifeeebchgabhgdeacgcbiiddegbcehegdfiadafadehcghhiigebifehhighfhidagaecdaahgebcihgidgeebieadggefccdicfehebbbdiaggeifiicdiihabfigeadgfagadadgecgcfgcaicfabigeffediffcchgcaeichcfccbhihdbhdibbfdbfcehiieaafhhabahdhcdfffihaihhehibffdbiafgcbabfcaefdbdcedhdacffehdaighdibefeghgbicecfegbbdefiedcifdegiibcdeihccheaciedeiiiedfgcbcdfbcghhdfgddbicicdgbedagiahgebiebbfecccedhcabgcchieabaghabbbfdgedcdeccicdgfafafdhgfcfafbfebaddgdhfafachgdaifdiafbfecbccadigigeccieabeghhbdhdhchdhaebggabfccchdaddficaiceebhbiiiibceaegcbhbiaagehgaddeiedefcbceddddabbhaachbhgheaaafibdggihcgfhfbiieeafeadfhibegaifdbccfficfghaagghfdbfbiaadbdfcchbhaagaifedaadabeibhghbaahiiiacdbfccbhcaediicfhdgaagaeagieaaceheaciiebffgcdafgeahfadchiicghedhaigegedhbggcigfahdfafbeegebdbiacchaabagfeiaiddebehfbcehffgehbbbeebdbgaeebfdabcibeebbhbeadfggbhhcdiagihifihbafiedehidfadbffiegabicddidibgdgfhfidiaiddbgadebhifgegggafaeghdiehadfadagifacffhaadhbieaffggdbaiidgecfiidechdgbgagicaiciaieeefafcdebgadigaeeaafaigbhbheidfccfddddggafcghebeficdgbgcideaaghafbcdhcdecdeichhfdfdcfiaebcidgfhbcfihbabfeaahhadfbeccceeegahahicecagaffehachefhddfgbfcacacedffbegdiacffachdacddeciddhgedehihhbdchihhggfchacdfdegbibchdbiddceddeegbdifgeaibcegaighaehabdhedgeffdbbiadahcabbhcfefhdibgcbiiacibeaagchaediceaddacfiehgdgbbbabibbccecdadgahebbchhaahcifffefbcfgdbddgbbdfehgghccffgfhdagbdgghcbiiaiddcbaefefcdeiheiahechdeecgfihgiffbchacdebedgfbfdbhehdbeiadbgbbcifbdhgdigfghdgadcghhfgicfhdabbbgihifbcchecdgbhbficchfiigbcgdeigeecggdifdfdddgiaedaddehbeebiffihceghdahdhggggibbihchghehhieicadfgggdgdcebiaibiebdigiceaiegggdbeiecgeifieaiagfeebhagceibcahicheccbdhgfbhhaahfeeccgbhegdadheddabibfggciihccegegceieicfdfeifeaiibbfaafgehfgddaefbihfbieaahcgcfcfgiaaafgifgedchfeghdafidfeggebcfabdiieghaifaifhbadfafebefddddhaiibgidhghaigccgfhfehiebchheiiggaiefgbcdfhbiffaebegcaaceeaaeahdicccgffddafafeddbdiagbcechbiafabaeaccdiababdgedededibfbaabbebiigihhdhagfbgiadeehecedaihhahgiidibbfigdhagdcecifigciedffhfgbgbchbhdahaahdhhfbefbafdfegdadfghefhiicdidfggfheidbchhchiciicbgaaaciiecfihbcbgcghfidhgchbgaffibfadighiacadcgihiegbhgeebedeadihiicacdgcdibicghdhbibeaacfffedebdchbcfhegdhfgacghhaghagigieicfhigahfgegfhghiccabaihfehabbbhfbhaeieffegehgbhhgcdgiacficiigffgddfbbfdaaeigcdfaeahcecbgedfihegcifhgghahifcddbghbfbfhbhbgfdaiecccghieddffcdaicibbeddgbhhcefiifhafbcichgiehegfdfhfgcbdabhdeddiecbgaifeibcfdfgbdieecgcahddibebaeaehhbfaibbbcediagbbghaebefdficcdggbhdibfcbhchgdeabheihgdbachgbgbgcecifaafigaffgbfaffagdihfdibfdebieeibbcffaafeihiafahhggfiahbbeiffgbabidhgicdagafgcahdbhahcdiefagigibffdaagebdbcgcfdhgidfeehcdeiaehibbfgifcedihdccfchgggfcebgbifgagccagbcdbgbbcgiaidbaciadfihbagghcbcfihfbhhacicifeaeiaddghegcagghccbgdhaidficihcadfhbhhbefbaddcbahghdghgddhcdifahafdicdfhiebbaadafafeadcgebcfggbdaeeabegieaggafecdahhbgaebebgeefdcdhhdgfacfiigcacgdibieddafdcebhgcbefaedcgieeigiddedhbaggiiigiiedefebdghbdagfhfbefebcfdfbafhcbgbefbbeghbhbgacgaifhggggccfeihchhdbfeggbfcdbcdgifddhbhihbdafhgffegcbhafccdcchagfdagihgiibbcdgigffhgaegffhcdfeefafchihhiihbfheibfdadaegdbagciebcgebbcicdibdcfbghhehfiegcaaheggageefiddbgiccghdihfcegficgiedgaeeidfhfadbdgbhfdcaagbcifbdcddhachfidficbcafbgiafacfgidefbhdaegfhfgifeccgchceecfhceahhibaefifbicedhcgahhehbecaafddgcbfaigaehfcgiagieideibighfecacfffgageigffdecieihgcehcahgiieihbbcdbacfgedagdaecheehbihhceacichefcaigbbdachahehefedbiddabeaadibdgchddgeidfaefafihaeadahfefiadghhhbdcgfgadgfaaagacgcdiiaabffcdfhiegichbahhbdfhgfgiadceieeaecdhachaggbdcdfbcfgigdaahcaagbbbacfceededgihceibaafbafcfiibgdcccbghhhhiebdhffifcieiafbcbfbhehcfhgfacbicehfedbfhbagahgcddffecgcdahfeabhaecibebaaifdiiagacaciidahiedabehgebcecabaeaegbhfebdibbaeahbfbcgeicfaebgeeabcdhabaeaebccffdfccbficdcaegiaigddfheaaiicacgheabeiiieichcdedbcefiibaighafefgabaagbeihhgagabbahicdbieddfdhiaeheibegceccihiadicfihchghgdcbecfccgdhaaicbdeccgighbcfgbcfaediaeeibabihigaagehcggcfdagehgeiahfegcdcafbehidcdbfbaihicbdahfdbaefgdaffedeadadaeghfdcaddbfagcieicbfbbhhgcidgbbgdgcdcaheebchgdadeiedadceaefcaigadefhacbafgdffbbecgegadhbgbbdiaggdibhahihchgbdeaabchaegfdafbgccgbafffabfddfhieachafbdebgbeefffecdbceafeebggdgefbcgbhachgeifcicfecggheiafedffaghbagahcgdebcgibbghdhcefcihdfibgcecabigdchiecaidadaghabibbghcddhgehehffbcebdacbhigedgicefaiiagdgghggddffidcbddhbhhifeiffeeafcfggchdbchaafffgebfhibbecciigcahhbgbicfcadfigiagdcicafefiieccahgfibeiddfcagfhdcgbfifcfhaiffchfifdbaagghfabciagefgcgeacifbdfacadiafbegfgadiaigcdaagfdafgfcgbdbgiggbhcfhaaigffadhebhhdiagbgahgdfihcacebgihhdgicgffgfceaaibefadeaiehaeahidfdeaeeffafeaehdggedcibibhfhiccfedcaaebcffcdagfbaiaiaiegfdcdaafaegicehhdcdiagbgdddehegiffahibhgibhichbdbeibeahacaagieaeeebbfefabiachdfgefcdegciedfddgdgiaifedgficibafbegigbafgfhbicbidehheffgabcchbggdhchhhbgdcaccbfiaahdiieggdbbacgfecagfiaedeiebdcfcdgegbhhgbgbfdhffhiigdifgehiahfheiaichhghcccdiifegehidafbhibeecddaghaddcihfiiffacggghbhiahfgaeahbciciedecdgdciddhdaeabhbfdiefbcegafffhcacefdiefabacifgbabdcgiadacdfcbecgdfdcgfdgdhidagfaahcbdbgfhdcaiceibibhfdgfihiddcccfhbfbaeahidfhaiegbehgiebchbahbbidccaeaeigdfchcecdagehdiegefeicdbcdihaaebeaebiibeebhehiicgdfhfifaeeheddihdaeheafiegdaidaggbcgaeahhgabiaeieggfdceddbdcfgiccahfhbdhebgdfbdfgdbechiddehcibibaheeieghadhfefhhcidhececbiihfdiggfhebiedecebcfhccdcaffaibfchadiaggefdecdifeiciieaebgihgfhgaaeibeagfeaeegabhaiicfghhhcchhbgbgbcbeaichbdggaihcbehhhecficcdggagfgfgggieiaihfefccehfgfaaebhfbbdddgbffbdebggfhdihifcgighbaceegddfaeafdidibdgdiddbcebhiiiecifegiedfibcdaibfhaggdficgcccdbghaddifiibfaihbdegdhiaheidbifdeeciiechcbcacicbigfbahgcdfedfidaghhadgbbfdeheiieddbhdiahdccbgigaaghbdbfcabfgadaagigaaechfbdfhihfedhhgabehiafbfdcfchghgeaiiabcfbafhfigffgehicibiiiadfcebciadgacdgbbfgigebchiagegegggdadaghfchidieifcccafdcacceeehhgehiffeadafibgehfgbhbehcfcafcihfdceifafecdhfagbhbfdabbhhhgiidefifiadhdibchgcgeehacafhgeaihdhfehbefebigiebbffacfahdeceaechdhdediebbgehicbcbdcggahicbbagacdibbiheagebcfdhiefafghahheehbbiaeebhfebibdgeeadcfidcfccbgaiecfdhbgdacdacbiafhaaibhgidighfaifcfcegfcacefcaeafcigcdggchbfhgeefefbbeabhhfifehhffhgihgcffabficgciafhcdcidffbfebicfcaecfebfbbbccdibdgbicbgfddhhhcgfgbcbaicdfiicifhgeceegffgdbghcihhidbgdbigeghiaaaeaccfabdadfagbeiidafcdheceafgiigccdfbhafcicgfaiccgfgagdiggcbehdbcbbbgfgdhdaddbificafddhdffgdghigiihciibfeihgaahbgcghiadagacagbeheecdadgeiaadaedebedfccbchfgabfhhdgfcbdhgcchiehdegbdfcieccbfhegcaedgecahdbiggiicedhcdgdbgeegdgbeieabaidibcbgbcicbeaffdhhhegbfeifcacecgiefhcaddbfiicfgaehhabcggfdficggeccedchgfciahfghcfbihceegfeceffifhahfiadfeeabgghhfccagebecfcbhhfhbdigbchfaebiidbbdeeahcgabhdegaaheecicffeghbeccdfhcgcgihdefcgddbihfccdfbeeehgbbfeibecdhgehbehecggbbagedafibffcbfgigifaefbffaehiiadhhdaghagbddhcahgcdfegehcdichbcdcgeeiiibgfgcfbiedicacgagadaeibgfhhcefiaaghadeaededdedcfecihehaiifcdhfchhgafheefbebfddadfficdcggaeaidegfabdbgahbchdhcfaibfifiefdgcicebcegbaceiaggahbfhffhaafacfeeahchabedciiefedicdidiafecacgdieifebebabddbaebegbigcebgggcfiabcdbibfaeccbfggheccdeedfiefbhaiaahdhabbiaedhfebgbceifcchcicchgfbghdagdffecidbgbgdceagicafhgdegbifhdhbfdgficgeffdbfieiibcbfecfaieaccddbhechhecdecdhhahihcecehchdibfgbeceigfddeffbhafbdaefdedhhahdbgdcacbaiifhchgcgigcacbfdididicgicghdihcedgehidbfdfaeecbffcdafiagidhhfihabfebceeababadebafcefhcafgdfcaiagaffbfaacedahcggedegaaaaiggeegdididfchdbbaecdibghcghadigdiffdacddfggbidbhfhcaeffdhghahfefhigidgeagciabdaiifaghfhadggefgihdbbddgdaghiaceaaiedggegfigbighcgahhhifefhceffgiaibgccdffaaffaidadhechiafdcfagdbaaeebbcbhcfigebddbafdfcgeiiaeeciiadbagfhefehachgddecddffaciidbdciccdeheiihfbfccidfefdbcfefchbgfiaghefeafdffichaahfheahabchchggegafcbbdbdabcehaefaaehbgadgifgfdfefbiffdhidcebecffdaieabahfgdfagbafhdcbaaebhiffbbiibicbggdbaghgacbdiaggbfegifbbbiedgfcihfeaedbhdhicgdfdgbbbgeibcbddedagieeeeecgehgebaddgfifcifbcbchghddfaifadfgecdbchgeabibigbbhigghdgbfaghacdfacebgeeifbgeehgggficdcghaiedihafefiicedeiahihfaghfbbhefdceabdcbcbeegeabbiegbfeecffehdabccefhibdcdaefhddeehiedhffhidfcgcabbeieaehahcbieicgigfdhfbdeeiaccigiigcebigcgbficcbhhcgfieaciihiafidadbdehhacadihciaahehhfafhadbibcafhcbcgghefggdcfghagdbaebeabbaffadbgcaehbhffgadafgdgehidafbcbedeihegaedhhihcbheecbcgbcfhaibbbhaaaffeehebhhfhidbeffcgcbecfegiedidfchfcadgibaheghdghhghfdcaifhgbbhebhibdiiddebccdeieiefdhhecifdbfchadafagbgbeebdabhgeffefahaidcfdacebgbhafhehebbgdhfgggdbbeggbahfabfafihhfhagaagifcddfieieiacabgdihbgigbeceeibchaiheifhgfbegbabhdfcbeefdchcbaedcgiaiegigheacddhcchdgfbbbceiegchbaegihaabgceahhibfdieigffdggebdfcaaaedcgghfaidhicghafcbefahahifaiefidhefcdehffcbbhgadgbhhiachghcbgbbchffcecchbdeddcegfibaiabaaieheiffbegdggibcahicihabdhhgaaaggidbbfheegeefcahbgdbhdabdagfhcadaiichhafbaagcdgfaiighegiabafahcaiidahhhbaheiehifbcachcedbbehfieghhiiicdifchihdgidicheiegdcbifgebgifchadbgibaagadgdefefbfhbeiehhhddffahchdideeiicabhicifffbafiedgieeacehcbeichgfaidddgbchchbggehcbbbccafibebggefdadecfghbiddcbihiddbbhgeiibifbecabffedfagedfichbgdaiddfbfbcigddaagfiadiicfhdiibigceehfdccacfhbgifbfdabfgegaidcebaeachhaedfacaigddiigabadeacfiggifgbfcdadiibhefdibebcbicehehhdddbihifbafggffibfdabacidffecffdbedgfadgfbibgeafaiefaghfbebdhhhagaecbbeeaaghedgghebceccbecggedieehbghdceagaabeaicbffeiffegaigfdgaehacehbcdigihabhchegecafbiibfhbeidhheebffdhafeiggbhihibadbfhiccbdffadgiefbcacgfdeagcfedciadahagieiaabidafgagibefggfiihbiiegggedeihbbigadcfgeiahabfeheadcabeffigiiiaffiaehebabhebgieaighbechbahfaeibfdaidgdhaiediggbbabgaaccffcehhihafeddgbhgddabbchfbiiddgffiheahacbicficgbdcdgecaadafcddcifbdbbchbddecdfiebhicgbabbdgaabiedgffecdcdhbcdhihhaaiaabagiiiehgdaabegefbicacidfecfdbicidbhgfiiaegddfgiicgghgihfgaddaaagdidfgfchacgffidadcdbecebdadbeiecbcdffffhccgeaeihffbcecaacbecgdaeahabddhbgchbhfgebehfgdicfigiahgegehehdcbicghhcheefbgdbaaahfbedgffadcaeeadcaaibghehgcdegfiaffbbefcegihbeghibaedfidgcihdieeiaechgaigdheedhbcbedihdcdeeideiihbibdebdabcefgfhiihibfibegcfiaegcffdhfabcbccfbbbicgaddhcbgadhfhbfbihcfbegddghechddedbfedcfggicegdehecdaddggccaaeafdaddfbfbdiececbacicgiedegfcdbeghffggifcifehaebicbhabhdffhhhfbifbhaiedbbedheahcghadaaadhefieidehibcfcchiceghbfhbbbiidfegdghhbhgeabgbhifhdgchgecbgbiheaibecgdbdegehgcihbbhfihaghaagfffhdegebeidbhhcaeahiifcaedddigcdefhecfaegbgieggccagehaeediafefghbehicceccgebbddhcfdbdachehhbacdbhgeahgagbchaciddbdhfiihfdbaehdgibhcacfaihgfdhbfgfhgbieafaeefaghefdheihfgihhgdieccbafbigafbheaddbfeehhegccdehcbebhgcfdgagidhdhddfehbgdibhcifhhdhgdgddcabiddcagihhafadbibccaibgaicdcdhbcfidiihgebgcigchecciadhidgcgcddeicgcbbdcagchbibfheedehcbfcbhgicaachgebahdhefihhfabibdecgfhgfddidicdbidgfcihcfccdbhghcgcchehacbgabgdchcgehfchiaedgbbbefifaaagceehahbegcieadfgichdieefdhcgabebiehgehbdhegheafhhdgbidfcghieeifadhieddedddhfebbcifdeegehideiagbceigcidfhacfgciaffdhbchhgdhhbgcadhgbcfaeehfdegdabbchchefbdddgehbghbgbbicbdiadhdbahagideghgihchiibfcbbibaedcbahfcebafihbiaeafhbfgibiheheigiaibeabhidhbcidacahdiiagcfeaicaiihagbcdaagfbheiehbfdbefabdbgegfeeaaibdhffgeefdahfifciicedibbbadfgbicefcifgfichfbadbhcahgfeihgafbihhefebfeigffiddffhddhbiidbaigfdebcfeicceabadieddigdehiigeiahdddgfgdadacbhabgeihbbgghffehbehbebghiahdeahdbfggdbgaeedfaahgdeefifbdcfbcdbeagafdiceadcghahehddbifcgabhegffaicfaibcdccfigffgcdfiffbgcccgiggibifcdhcfeacfagecdbhiffegheafaaghdbihcgfbdihbbbffagfaegedfcdgffchgffihffdgfiebbbicafaaahbccicggeiaeaafdhcccigbdheedbagdgiehigedcbiehbicffigiiigchchaagihbgiifhdiefgagdffcgbcbihifehehhgbdidfeefhgdcbhhfhffhcchdfihfedgghdiggbfihhcdahiagcgegfbbhcighgiccffidebghdbdicicihbfcfiecgibbfbbgeafgeddcaehbhhecbeidbccigdcdegdiacgghiehegedddabgbabfgebggicbgehdacddfahbfibfbecbgibiehigidhadgdcibdbeefhhdcedeegbfaidhbdcebhhfccighgcbchciigfffbdgcbafbehgccaddaaebbfciahbecgbcebahddgeedigfdcifaafgfbdaahifffiidfhafieggiaigfiaafgbeabcgbaheggeceiciedddcadffhfbicahhhhcifieiafdedfbchbggeeebcgebhihadbagbggdggghbegheccfafgichdafaicahfihiehfbaecgiaafhehcicifhbcgiffaacaeibbifedghhaafbigccabdaifchcbhddafebbaieiifgaghigfdcbgehhcagdcdhehgdhiabhiieeeieaaedahdgcdiiacgaffffebccgdbbigfhedddiaghiihaihdegihdgdhhbcbhbafchefbdeeghcbfecgchbagaafeeefaiaiiecddfbcgcddfeibaidifhfdbidbafhebfciehddacihgceeddibiageiiicehegifafaaiecafbcehfahhhaigffigcechgfidhcgegacccedhbhbgcihchbchadcbahagfaagggghahgcfgchfigbcbfhdieihhbhadccgeffiachegfbchiecfbfdgiececgfbheahbichihhbbihggdefbcdgbebbicehcbcdbiadfebbcdaedeacfaegeagedgfcaifcaheebehdfaihffiebfhcigcbaifeadafghfbihbdbhbhheecaihacbeibbbacbdgefhddggaeacggbhiiecbcifcafbadgfhaghgaafebcafghdahgbhcffbbgdebggfibefdaidghffadbahicdefacaadibbabiidbieaffdbaiheiefiabgfgcgicdhifhffabccfbffebffgbdihgcdfgdigfiigfedcdbddgifficdefdcabheacdbafgficifbbdaieiieehagfichdcbeabebbfaehedbgbhbcdfhchhbagifdihgfdbfehchdeifgafcebdiedcgfdfidgidfdibicbbcggabbfeffhbbcbiiihibhihgaiccafihibdhceigahefehbbcgcicedbegbadhhedbdhdcacgabiabhedceahgcfhfbiifbcgcihbccgcfibbheicagdbadgfeegicacbibbbcbgdahihiahehgibgbihhghcbgdeaedgiaacahdhhbdihchieedhhhiebeieafeeahdbdebhdgahefbdfdccffhiifihhfbgddchbagaegbbabieabadbddbfhaebagdgcfcfadeegihfhbiigfhchfcehfgieiahbhhdiidhaagibffcchddicdccfhedcfchebbadcgdadgfeeaaeadibhdfhdegeeedfaichicihbiaiibefbiagihcciabibfabhdhhhcehcdfifcfafcidfhacagcbdeifgigbefahgciffdfihgbbchieiiaegifffidbedbfgheadgeafbcfciifiddghebbecadfehiegddgeibgfgaeggibecbaceigdebgdcgaaeificadfggabcdegchcheddfbeegffbahaadahgeiafaiiabgiahfeefgdeeiebdihegcdebachedgegighaafaigeheedaefcddiccgafdfghaiahihdaacbhbgbhbcabghbcbhbbgeadggiagffcecebahgdhibhggfdghhadibichffdhfediieiggaidgbfefidfhdbcdfdigibdhdegcffdeabbcafghachbegbbcdfeahefeccgdgcihfgicafighgfgbddggiabfbgehdaedcfhedfaidebggfiebfbbichhiihbfdaifabghgacgbeeghhecfgagffbafddihfbgbdidgededdbacbcebbfhfbabgffigbbdgfefdbaacabgfgbffcdigfedghabhidbcadhaabdaeeieegeaeecefegghafidhbicigebfabggfihehhaiddfffcaeiihibiddaceciieeihfhaebggigchihgfabcbhbdaifbaaggcdaddccfcgidddacahbegicedbgfdbcgbehfbdhbhbegiceecihgfbeddgfcdbigbidgbaigfhifcddeiiiceaageicabadhiafgefehebaebhfchcffhibadgacdgbeaedfcacfgedggfgiaddhiiibffegcdigaghgecefaeeaadgfhefihggcgefiefcihdahecgcgfgaeafdcceicfficciebidcehhdccbdegiebedghaggacfaffaebbchdbeefhhhaihagcchhdihbciefhiaecicdhgficghhahabhecidhdhfciiidicafidfdbefbcibbefdiebgefedcbgaeidgdecgabbbeifigbcdbagibeebgcfbddegegbahgbibddgahcbbefadgbibcfhfifidihgbcgfhiiecfadhbeaaigihcghebibdfcebddficdefcgaaaecgehacfhcdbbbegchfifeieadcbbddcddciaiehaihdbehefehediacibeaeacaheeiadidhbhbiechcbifedabghfabgdidbaabdeibdeebeidgfegbghhbcehfhiieagecgifaieabaagbcefgadafbbhdafcebcdgadcebgeigdfegfabeaaebhicfhgcceaaagciebghbeggacffbiihihbifefcacfgbccfifaaafefdhbdgedhhgiibafhbbhcaheciaaacefdibdhcgggdgcbafieeifgcdhdafbcebebgeffdeadicbgdacgfggbegfdiigfehfeihggcgbefhaaeciiggfafgcagcficfideffiaafdieefhhecabaceecdcfgigcgbabaiahcecfcfghabcbbhdcbbigfhahcdggeehaggdeeaecgefbehbgicafaibefbdgaddedabegaiebibiaeegdegahdeidigdiggaifiibebifhbhgebciigeedecdgbhffbbfagcbgebchcbeedigfcigaggaafeaadeaabichgcadgddggdabgcheghhdiiighhciabdbcgdffgghbeahhhcfgieebfgbhfgcafeifhcaeiafgecicdhhdchcgadihiafeiiefgbciabichgfggdbggbbefdabdbffgdgeeccgfeeiebihigfghgfaibaffcdhchghhgcfdidccbgiabbifgfacfbhfagaceafbighggeaebbhiccbgbhbhfhhidecdeaheddibcgcacbdicaeghigicegegihhdbbffeehcdcffegeaaafgcbehgeeiihfhhcdfidbdcfggcfcdahecbcghifefhbafhgeifafiahdiigahhhgcdaebfbgfbagibhibebcdhicahdggicaedhehhceihhebciechgagbcfffcegdehgicaaaieibhfdibdfdcdceabebceafciadebechhcaiehfdbcfffdhfdeagcehcccdiebhehgdhechbgeiffcgdhahhghihbcfecefccdhcgdeaiagggbgbbgeeebfabgfaebgaaiaicibgacbhbchabhcbbdbgbffaihdgiidacdhhfhegafbbihgeedhchhbahhfedhiibdcgggfbigeceidcbbdfidbhfhbicihhdggghdcahcecgafafdafhgifbbdbfhhchegghegcffbghheeddhdfcgcgcedifdcdchigifcehcdaiehccgaafgbfeeigbggfhbhbcfbhiabhieegbibbagbbfdacdcdgabfcebbiggccgadhefabeiadhdafdhhafabccidfeaaefhiafhbciiadgihdcebbfebhbbgcbgcibcbchcedifcifhagifagfahgciaicbcgeefbhifffgccebfaffdebbbebbdggdccieddchbcbbbbheggbhccbabdegifgbefciiegihfideagfhbgegdahebdbeacgdbdhcaibaaacggiabfbceeaciggbggifiieaeceeagaihhbfdaihgeceefdaihccabefffdbigfhfcabiibbcebfdhgibihbiehbchaaeegbabaaaigcchcddidggidiebhgddcadfifeabbhibdedfieideecfhbfhhggdfheffeiiehdgfcfddeibbefghhbfgcfhbichbghaaffdfahddcagcaigbdhdfehghhacbdcabfbhcedeiadbfghihihafadeeabdggbhbhaigedfghaabecbieabfieddcfcihddgcaeibbigdbiiifdgcdeficbffdfadgfbihbbfccbdiaabgeafaacciebicigfdihaiaeagbdiabciehbiagadcbifgedfagbibidddheggbfhfdhfdeficcfihiicddcceedfadfdfichdgaabedhhhcdeedbeabdhdhhgheiecchachfgghghhdhggicdefbdcfghbcgaddaffchgehbgibbhhbiahddhffgeccdbdiaibbhidcghchhdacbadichccgdaegeaechhdfbdgagegbaicehbeedagdfiaifeaafbhdcdbigchbbeebchaihbaheeagdaedebhgccabicfhebbaedifaadihadgehddabfcddidfheagegbcbgifgiacaaidggfddiafadhibfhefaeaddehceaiechhhgfifeebhfgbfheddiicgebafeibbhaffeaihbfhhhgbeggbgihfafagdaddbdcaeeecdffdbfffieiffbcbideihcedifdffaaiahcgidhceigcgieiiidaiiahebihidheeccgfdiehhffacicbhfbfhhghiaidageihagidhihhfecaehfibbiefbhhdffaabadfgdahdccedbiibaafaibgedcdecccaheahfdagidgdhidbhgdehegihedahaeeeidghcifagcgfciigabeehfcbigidfdcddgadigahaeahbeiedegegagadiidefibbcebcadehgdicdabcgfgcchgeebcdeiidaihdhbddageebfaficggchbahdbgdggficiifehadddcfddfaffhhfcidgbiiadehbhbcibiecbcehhffhbbabiehicafhgidabdcebfbaiedabccgbcacgaabbiceaaahgafiicgghheaaeechhfgaeidbfafabacbfgeieffbebcieiieebcfiaidcfhacgicfchgagccddaeebbeieheagcgcecbbgefacafgfgfabdecfecaaaibgicccafighigbbbfbaafgedgdhihagccceaaadbdfgacdcfccgceiggfaadfdahfdaceeaaegbhdgbeccbgagbfciafgfeibchigaecfabiifgafdchccdbdegfhgefhdbgfebafdiagfdiffbhehgcddahfdabeabcihecfbbghheaagicdahgfciadbebeifgfaebieigaabggfcbgeiiidfagbdhhghefidaccgccaafdihdfddecfdbfdcaiebfffgficaibgeceeeihbiddgihhchbdahgghchddeaaifieghedbdeadceaaccicbfgfhdfabcghecaidchgbgaddhahgghdgceffgdeaibchebgigihhhhhgeahgibbcgdbecheifeicggchedhcgccegdicfhchedaeiiecbaaecdbdfdbigagihgaaihggadagfaeaeciabibaagifacgiibfigbiafdbgcgbhciceefhcaeagabacgiacfiahahcffficichddgbfahgfeedeeceeaibhbcicfaihaehecadeghgbeggdgfdfhigfcggeigdcbegahfdgiiihhifdfifegbehhbiddafgfeccfcdcacifafbgeecicfdfbhfcibfcdecegdbfgdefeghcaceegidbafbadbfabhceicbdfecccbcheifccabghbfgfdbdaggcchhidagfdbacaidcggbifbhiagdcibhicccgcdbfaefcgcghghciedhgbhefhfdebhecbfacfbbbbacfedaeaaddiiiegaiffcgcgbeghcbebdcfbbhgifaebifihhcihdecfhhihbhhdehehgiiegifciceaigfabffcbebcedebdhfbcadieeafifcadcgbhddeieccgbfgdfdhcaicegheffieihhddchcbgdbaibfabihcddefiiacdghihcegeddaeeecccbchbaagfageigfcbgidbaegcaefadaidedfiigeadfbacfbffbfhfhfidadbchchgiadhcficgaafafgfceeffigaffcdifdgechfcgciggdbhcbfahdibfgcigidfiafibiegachafcefadcehbheaghibeebaaigcdhdffdgfaiiidbcbbeachhgebgfdaecbfghfbbciaeaiaaiffhdbfihaifcbagghabhhhbafcidgbeibdaedbcdfcfeedehiddeacdhaefdgbhdbfeggcafhcebdbaeghgehciefhbbcegfegegbaachibeggiehahhghecafibffcdchdgbfegdhcddahabhibfbedgdfafiefhdefahfgadgcfgfbaafgebfdegbbdgefidebdbaaiedahcefdffbabfefgghieeadgbdcdhggfebdfcchhedebhggbdegibcdciefieffafefhhcbdeadfggghdcigfbaddbiaheabfgciiicchbieeibcabbdhfeebeicdeahbeicchgabeichdbhdafdbfcdfehachddfibechecfhaadifchgbgdfffaibdifdfhciibicfaigeebgffgbdibddbcdbhbbdbdabacidfgcfgegaehifeiiechgegbbffeigehebgdegcgcecciefgeahfhbgbhebagieegaehdbigecdfibgacbfhdgaeafadbdffaaigdbhgihifgadciafiaeecbdgfaececbabbhehgebcbefcififecgfhddfhbccihfffecihedcgccdfidhdceegchddiddhhaicdiiheddheheedaihaabdbadbgiaededffefcdfidigdahiadeeaicacaeccbdhchibcchffcdhgiieecbgdcfagccdcdffabigfgaffhhcbchibbaghedffgfcagichbiaahiefcgahehdbbcfdhbehedafgedagdifaahhhieighgdcciehigfhaeafeccdadeiidfcdheibbbifgbghdgiahceicfcgehgiadbbaggibicdbadcacgfifhfbhdhbbbhiiacggichebfgdhbbbhebcgaahhcaifgbciddfaihaehgfcahcifaiaaaaaahdgdfedfagcafeaefabahiaiebcgfadbdhibehheegcfifhcdiebidefgdfgiceieeiegghigachbacghahgebfcgighecbafeefegifaaafdgagdfbgfgchaaghhcbedhgbdcbfbgbagggcdibcchggefagbceheicaaeihhicfahbidbfgcbfcddiibghdfgiffbegdfbcihagdceidhdeeibdhfdafddfcbafcibbaichicigbffdihbahbfcdhcbdhhfchddfcdceedhcfhihbccbiegeccieahibddcchafagffdiehibfgaiibfdcgbegeggaacecfagfiebccfbehfaghchbigahbehbfgdhbhfbadddeigccbcebggiaeddgafcffgbeafdeeddeaaffdhdbcdffgcdieiccafbhgdacfidhcfchgieifcadebifcdeihbgficcgffiiaibhdefgedhfgaaigibfehecdefgedagaachfhiffachcfcgchaaehiacghcebaeeigfhabhaeeidehehidiggigchdiacbbchcabcdgfhaffhffhafdfihhbhdhecbiceaadbccaiacbcbcidedheadegfgdigigfbedeacbigcibhgfhedfcdigabhgbidedeecdfefifeffiiafhddeifedhaabidiecdhhceghcfcdeagdhbcdchbccegggdihhdfhffeghddaihibceicdbcdcbggeafdcdgbbgfecgifbedegiiaeihcacagefeebcbbiabacehibcheecciiccfgdafcfggcdehdacchabehdhhbdaiedaacfffaedefccddbaidhchhgeeedaaccicahahiggfdagiaccghceadfdieecehecfecfdhbdhigdibcfgggicdchgbafdfgiaaaicgeaahchibefafhaeabdcacfihcadfbgccdheihgbhbhafciadgfibiiabeafdhafhheaiciibedifabagichfcgfdbhcbbfedehidcbhffhbfahacdhcgeecahbddeafdheghebdgghcbdceccffgbcdhhdegddghidecafgffadhbfbefgccgeehigcfhgccdbiggdbiggehaicdgghagieciiihcefbeafhbdfdaaeddhbhafccbaghcgggifecbdgfbefgbchibdcgehcbbcehfdchcbfcffcbhbefgcgagidcagiadabceicdigeifgeidcfidahcehaahiehedgccehdehegfcfcgffaadidiidacbggedhagiecaibfgihhcbfbgagbhiheefcafebdgcfihbbccgibgfdicbgiiifcehfaadccdcahagbggahecefehghfibiiagidfhcedegfcdegiecbgbecebfcgfafegdacihecbgadgihcigbbbdfbcfcideddfiehgdciicfhhgdehiigcaiehhbgbiicfggadhfbeibfceefiidgbaebbhhgcdedeaddbgifgcacggfagefgbcedebiicaehfddagcebcbaeeiaachehgfacfbbhceggcgbeegfigbcfgcibigchbgciidgachcdiibffhggffhfcfdacbagabfdaicbeeicbbebahagggiahgigfaabhbaddhfidgbcdbchffieefffbdfacfhfebdafhebcahiabadededhhieachhfaffedahcahedeafdgbicbddgdafgeefcbcfahhfbfhbfeeahbcfhaifhbcehiibibdeciaeigfbcdchdcbdbfhhfacbicigdffecihfhbhddhghbgchifabgadcghbgbhhhheiaibggbgfccgcbbhdccbhhgciighbbihdeaehheghiheiffcccfhgbfhebaeididgeffabghhafbdaiaigicbabgicigcggaafhacbabhhgbcbhabhdgficebbaiiddfgigbfegbaibdeddbbafeaggdiabghhehgidcibgcihddhcfhghigieihaccdahdfbcedbbiehhabdfcdbgdabfbccccdggagfifafgegbhbaifdbdecccbfabcbcibabhcbdafabhecdbbhgdbgihefidbibdfdgaahfhfechibeafiaiiaecfgfihaidehechdffffgdedagfeehifhdcidggicfiahbeegdcidgfeebffbgcgddhhbfaigffbdhecbgecdecgggidaiddfhcfahefeafedfhbbdccgbheifiafigebggcccdbfdeibebbeaafcdcdbfihcgfbifgcecaeihhgaieeadfgaccfefbhiggaifeheccbdedghadbgidaihgeaccagihghfgfbeibaecabdcgbicbaeebgigcbacgdihciiegifeccbaiaghihabagaahaffhigghccagicgbgfgfidcbgfgcgibdiiiabccibbfdhecfdiabfiigfageebacbidedbfbffehefieabbhhachdchdbcbfaghechbhagiafdffbfbdbgbgiiiediicddfhdhgdibeddcgihdeehiidefgidfihebcdbbahfdggdeieedcegdbbfagbfefcfiegchbchdaeiedcchdiicifihiaaeahahddcihcadgahcaeibecdcafhfcichgeigahedgbedeeahiifdbhghfgigddaddhhfeiifcafaaicefhfbghfdgbbghhdieefhcabgcacgfhfifgciahaehhfdbchfbfcbddidacciagcgeeeedfddiafagdffiiecbgbifbhhbgbbdghhdifghfihcddeedbbbgfeicdfecgibfaadddfefbgcgddcfhbbbaifbaibghbdgbfcffdadedaecihbececcgheceehhhdieabbfafdgchicbaihhffdffaadfeagebaifdhcibaabcdifahcgaaaiaieahgiagbaeggbbaadiigcfiiddciceicffiibgidebbdcghggbaeagigacfcfeaahhhigfifeieedhccechfhadfchhacgefcicbhaiiaghhcbfhhiffaagcfaagfcgaaeidehdihfehgefiffcihcacggghgeggdabdbeiaabceghiccbegcdihaiefihfghhhfibgbgehcdffgfihcbhibegigdbhicceaaibgebgcegehghehcfhefgihigiebcaffeeiiiidhdheedhebgedbefhgeabfcfadaffbgabdiebdhgcgiighhaegiiecagceiadidhdhedafddeggieeedbcihhdficbefefcaeagiabefdfaagfefeaebeegfhddehhdfcdibifhecaaiighhhiehedgeaegbehdefgfaeiiihcfdbchcaeicagehhifiaachadeichibidcggdicbibdidhdifaghhcdaachgfiedfccfhfcbgaffgcfcdceeibabgeigchfcafihcfihdcfhgabgaiiiggacghgbhiihhchafhdedhbfhecfcbfghifbbchcefdbbdgafgahddbhgfffcbdeaahfgiafiigcefcicbdfchiddadhaeehdgbdeabadgiigchbhbhfgidcedddcggdfiffhffcfaedcifgcfiafgbdgcbhighccbabaaecigggceiiecffhdeaachibehbhebfdibgbfiadeibaebbdehaaggebihhffhfchdeheieifcahcggaafciggiffeabdegeebggbbceiaggifiebfaeehdcadabeagahbdgdceddhieffcadgfbcegecedadfaagefcefdggdighdadicdicaffeeidhbiafebadifddchibdbbiadfaafbifcahheaeeigdhcebeidehddeaihgheafacgagbigffdahiigdiggieehcbciecibefibhdheaibdagiaafgeehdiaebdefcchabcibdcicahhhhhaffhfcahcbieegcgcigdbdfgibdhiheeaeiiedhadcedafgchbciciihacfebbfcfdcgfeaegdigffcbibiebbafaedicadgffaghdgicahdffaaeggafiaibaieaehahcagiigfbiadagfdidceiahgiigbcbcedgcfchgdhcchiieccaghibehfaahafifbgcfdicbecdddcdddieddgiagfeiabeihfgcedeihdfibahggcfeadaccceefhccbgddcgiihbcgbfgfighidaigbgecgehehbfedgcceffdaeiafhafiahheidgaaiggddeeacaccibeeghfbhafifgddaehgfaichhhgdafbdgegigihbcdbigacfdifdeebfhgdigebggeahaghaebdeaidhggecheiafbehbgfgihgciggbgaieafgbdicgachfabfgecibicbahfacegaabifdaifceafbfbgdebhihdiiaabcgfcccgagbciiigefachcibeecfhgbibffchefibehhieecbbghiaiffhabadigiefidabegifedfbdeafeedfdaiebdifchfgdigdhabihagcahbhggcbgidabhghcafcgbfgcaddcfegechhafcihihebaaacadfdheibiichhiehegacbghhfgeeaaefeebicffadefebfdiefhhieeidggabhbhhdiieeddebfibffafcfddcihdbbhdhfiiafcbbedgfeeihdfegicbiggiggcabfdhahehffdigbdafdbcibgaghfcdgdechffggbdbiegihibcigddaagbaiiidhebdfbbfeigcbhaddaiififgggidaeeaidbgdigghhaihehbdfchbdcghbgdcbdgaahbgeddbadiheebigiagbcedaecifdidaaaeacfiefaacegdfbchcefadgbceahccefafhfdfagegiggdfibghfcehdifdbhfgaaciceafagdfbgadgfdebfgddddhfgfgbccceeghfibcgbacgeifbigieiigfdedceaheihiacfcddcabheedgiiahcfgdccibedhcaeaafabddgadibghhfgiaecebbhhbbhcfefhaihifibhabggadfeifdihgebacgifgcbiedcfgibggfcgfffgaidfdebicdbbghfigebcecdbeeaaefceceaafffcfeccahiieigehebbfhgigdefbicdfdbefcbfhdgicbeegbhgbbdfifgefiaheafdbadifefdfihhbaffahbbahiichagcfdfcdcihgadacafgeabieadfiddaahaigddgeahhdaeaegchhhfgbhfabccdfbeghbhbfehdcbcbiadbcgigdcaidhfegagiiadhaahfaeahbgbeghebaaciihhdfceibahfihgcchdidcfieideaafafdegahhdgehefcibgbabcaibbdchabbhfdggcacihaebeecbeadcicdfgbgihccadfbhdhfagddfddaaibfbeiaedehhggfhbcedacddhifeehfdehchiaaaaicaeieefadhgbgbgbgeaefgabfacggaficdbfgdfgdeccbifghgfadihaahgfgdabcaiichbedicfecidfgecffefechgdedgaebhicifadfgfebagdedchbbhcgadefdgdbgdagabbadcfhgcbgiggdacdfecdfchfafaaadiceibahiecgdahdecggciigdbeecdbifbcgecegbciiihiddehceheeiiecgdeadhbabiegafbgfhebcbcdgddcbedcddcgghacgifhiffhgghfaffbhebhgdgfgdbaffchegggedfghiaedfaeidadaiaggbcaahediibihgigfehfebaaeecagffgebeggfdfecidigddcagiaghbegbffgedehiggigegieifggfcfhddecehcaebggcecgfbecfadgcffadgeicghaegfafdbadhidaabifaiiahiebhaiidfeiecbdgbdegdfhbfabgbdefgehigcbeicadgiiahfbegggbdafcfcbhdaaeaedhchahggfcbaaegdbfefgffagbbhieaecbfebgeafceheibbccegbbbhahhbidaadfaficaacffidfdechedbcecbedeciiidaifcaefihdedcifhgddehcdcaafbaifabiidfbbhehfbificigdbefcfhhgeideiicceffhagfdabigfhadhceafhdidfbbdhbhhafhbgdcifaifbddefcacbcbahaihiiihiccgdhecdafadabccefgcadghdiibiiabfeicgecchccccichghbeiecdaefgabhebfcehdaacbgciafecaacfabghffaegbffdifbgdihfihegidggadcafefbfefbcbdgfhgeghccfhhihcgcibgdgahdhacgifddcbhfacfcfeadfaidccgfdgdcbbcefcccddbfhdbihefabacafgggfabhdiebabciechdcfhigeaebachabbhahfbdfdabfafigabhbbbhdecaiiiiccddeccccagbheifhhiefideigbcgaecgbgghgceebgfdhaabdbcadeecfddcbdggddigeagdidhgcihahghcbidhghadhfbhhgdfahbggdefifefigdgcehfacecihihaigidfecdcigfgcibaabdhaigedgiafbfiibgehdifchchegfbifcgaceebchegigiacdefahacceaadddgdhhaiecagfichcahggbghbebgdcgfcaechgcecifgiiiciaegdiibhbiffgdciccihedacdacddbehifbhcicgcigdicffebaeggedbcfbdefhecaibfgafaccgbebfaggffabedeeecefafeebdebfggcgchbfahabifeccbgcaeiadfiihiebgifahccaecadcfgbaehhdaidcghhcgchdceaaaiihgeddcdiigbbcabeibchifafecagahfgehcdbceficfefigffeddbbafcbdgehebdfcgcfeehiiffciahghagiehfefghbigbgifgafbbiegdgbahbffdhfaeiebbbgddcafgdahbhdcaibgigdiaeichfhdiaaaichdbehdgdgdcdifdagehbhbibgbgbfdihgfdidhaecgiaahahifgfbaehfigchchffddhffbabgbghfdbafcahibhgahchddibiiceeegiaacbfceiiiceehbccbfaghgggdcfgcegfbcfhhgagbgfaiiadhafhicicadicaadfhecahgcfgbfgeccbcchbbebabbibbcbcgdeigdbeihfaciaedgaebdcbabgabggebcigefiacfcfdfcfeibcfaahbhahcfbdddggffahdhhfeiechdbefiigcibgedideacdghddabfbedeedeeedahbebbbghiadggdaeegghahgfgfbgeaefdhdeiacfcdgbiccceafdicbdieedbbchaehgacffdbdebeaabcbdgiibadfieddbcaibhfiiehfggebeiddegafibaeegiadeihaibgadghgaffbbedciheghagadeceegcccgccdeeafegeeedfhddadhbccaedigdbdghbdedefhfhegghahdafbhdacacideeaacdaheahebaggcefbacddiegbbfaeagcddachfefgcffahifagaffdeefifhgihhiddiiagcceaihafgciaaebedfifiigifdigahbgeegeebdafcgggabgbaiahdhabaaiichehhcgaeigieiaacaeddfgihhheebbccfbdiieiggeggfgeicedadchfhhidhhafiffgahdiecidcbbadeiaadieegfgihigbifcebabfdciigdgcdhbgcciiceggfehfcddfgabhdcgdadeaagihgfbcgfifagcbbgdacifdgacbfcacchchigdcebegbiibagghggbhfaiiigbiedbfdiabddedgafdddbefigidifechcihaggdbbacieiaibbbfieddhbiagggiegdghcecggacfhhfbghidhbhhgagheedheeegcbhhacbcbifghibheceecidhgibgieebedageabciebifcabbibbdgehbdefgachcdeeacfhagafhcdfgbdgidgfiegbiddfgbgeiaeebgbafbcgecefaiedebcgbihdefeiggdfaddacffiegfhdagffchgabiiiigaeageaaabdahbbhchefcahdcigdedfabdbbdcifigeegaacacecbaigcdecbgabgidabbfdbabeeheahdghecfeagadcffhgfcfcabdadafacbebddgacaeebifhihcbfgcfgeiadfahbachbaabggacgcbbiebdbhcfbdadieeddaidedadadgdhdbhfeghbifhfiidbefcibcbdadfdcciedhifdcidgbcfigdbeicgihihaegecifhedigdeggbhcgbbfdhehbbacehbifhcehciaaehcccgadbabbhdfihhdgeacedgbgbdcbhbffcagcfbeggedgbbbfcibigdcggcfaiafidhibabahdddafabdadbadadihaihdbbhhhehbdehicgifgdifdffeigbhgeiddgchaaaegefgdachdhhfabbbgcdhceffibahehbdfeeegeaceiheffddaiehegacadgagdecdechbcabgcfehcchcddaaidggcdabgeefheeheiifagfacgebedbfdahdbeigaidiiibbfcdgdaefggfbcebdeaciibaddhefhicbfdgbgdgegdbggefdfhfhfbciagcfibcgbgiaaiibedeaeegdaabebdaccagfibaefcbdddbceefcfeibeeccigceifdhifciicaciffcibiihedgdhgehceggibahdggaabhbdfgccfebifchbgfdhhhcbdffedgcbbfbgcfdifhihibiddeadfhbihbhiiidcdciiaahdfiigidcfcfehheeigddiiaihebfifbbbbicfbafeeffecicicfcbhcfaefcccecdbiiigieadheeehaibfbhhichedgdcafbgiebfbhahfaahdghhgcaggagfdieicdgihdfafaeebhddidcdcifbbgbdfehgddbgdahgbfehhicadahfiehfihbfegcebhafdfbgadhcafafbafdhiaficibhgffifebhfeihdfgcebhehbfgifhhgcdhcgiafbhgbggfcacifeegedafcdachfgddeciifdfbdhdghaigfaeeiidhehaabebichffedheehgegdaeabfdhdhcehfchahecaggcgccdgefeagdagbdagiciabbccehdiagfgaacfaebigigiaeeiahiefdebhbfebdeaiibhdhfbeaacfdhgahebiageecggehdchbccdghbafibabehfafagffigiggaddbideccbeacdbdeecacidgegaicbhhfhadgeadgfcdbehddfgfihghghbcadgagfhabfgicbahbgbcbdegcfcbfiahdeaidchadieffehcifdihfieghecfbdfdbbacgddeahbfidfeabbafgbhdaaeibeahfifhdaeefcfafiagehifaecbciehdehafbhhbcfhhhcdcehcgghaifbcfdedefcggihcbhaccgihaeiegcaihagbhcfihgdgffdgdfibfacaeifbgbbcbigabgagdcfadeecdhhfgcgcfaebiefehggggbdeidabdaegegaefbigfgcceeaehgageacddfabgghaeddafigfebieddccfheiggfihbgfadicfafchihdcigbgddgbgcbfagigfcigcihchcdhgeggbihbfedgahihafabiahdedchbefhcgbecbhhdiffhahaaghehbgdhhbfhiaicagdbhbdcedcdddabedhdghadeiigaaeecbhfhcihbfcdebedgiaacfdcebcegfcbbiacgbbibgchdgfaihafdihdiafefedhcgidcchgbifhfhgbeeigaiigdbggcdggaefffcdhabcggidbibhcagbiicfchgfchgbaibhbcgegcgabfadgbdbagiiigbgbgehiccibbafahbaibhbefchiehacfdeidedafhfdghaccidfacbadigihhbhdeaccahichbhceaiacbidfgcbhigbcaebhdfebihebegaahachegdfhaedfddbbhgecgaafdicgeiedgghigcfdfaddeabchgfdieddhghefdcfdebbidaafdfhfafdeagidddhdabffdaaigdggahgchedababgieaiheeagheccfhcficifcbeebgfcdgcffaaiaahbegiigbffecichfigabdbbhhdfbaaheedabbhbedfcdacghibchidhdgfeeehbbcfgcaggbchgdgghhaafggicaacbagbdchbedbhhedgfcfcbifafiihhcfcdhhdcdeddbcfbdgaidadigbieefbchhaebfhideaabiicgcggihehghfigahgeigfbheeabchifcgcfhiieiibfibfacgheabhabechbbabdhdfihedfbebecfceefcbbhdebdeiabffdegbaiedaabcfaheceaabbgdeeigbhiiaffhhfcaacfgfbdbiecbccafheidhadhbbbdefiaaficdbddafgdeiidgcaifaaibfdiagfdggicgiacaecefbhgfgehiiggdeegaiciicdcihegdaafchibhcbacaiichhbbebihcghfeeegfaggedgficeiffgfiedfhbfagbgichhicehbcgeacgbhffiihcfbibiggabefgdfhfgagdfdbceafefbfbfgfhfihdcgbhgehcchaagebigahddbcgiicdehgbaieefdcadhiehifafediccgeabfcgeebiahfdiabffaedahbagiagefihddiggdgaacgfadahffgcgbafbibbcagafiaecbabfafdbaghdfidbcdifgdhdeaedbeadbdaecbbiefeggedfghdebghgficecbfdihgbiacagbfeaafgibaehgebhbedaeacibeeciiigieigfdbcdeddgcegigibeedbgciehehcfafgccechddbgbcehgeaficagfdiifdhchhgcieiefhgcfcbcffdaieadicaigicbccaegbhbaebadedgbcadbgfaegbcafaigbaficabibfgedehbhhefbbbgedfbbidgadfceggabagfaibibeheigcgaaicfebaeebdiiafdahcddacedbdihcbidefffhbaefddebgdhfhcaiahhbeghfdbbbhcghdheafdhhihhiaedecbcicbegiibbdagbiidefdehgdgciafcbfeedggageaeifddhbdgidcbiccfifchgecddcahgeaighicaeibbdciiigaddeibfiadggbeecaachgdfhigagadcdggaafbffhibhcffeiibiebdcbgechafheddacidfhefbeifcffaidibhaieeibeiefgeegfdbfeahgbefgiheeciccefcbceaeghgehgeibdebfedaaachbdcgeghcdcgbbgefagfbegfbiicdbcgageahegigaaaecfhfdefdhihcaggedbbdeibcdfaieegafeacacaeabbefcifeeahbgdcbhhgbhiacbhehigbdggaieecaaaedhifefbcdabcibhacgehdfhecfgidchabcgadbicdaadeidbhhbdbdiiichiagaigbebchcddgfifeaedhbegdgfcdhhbciehdidagegifdihibcgdcgcafdehcebgdgdafieafchaiddeiaagebfccibehfgfacaaffdageefaiggeecfcaaccdffhfgbiddggeigdbhbeebabifcbaggchccdicaeciceefbbcecbbfgagdhggfhehabffgfebabbdcddihfefgeehfdaaiaaiaigcigacdcaifabieihcghiidfifcdcdcfggcicdecidhddfbifhbahbibdbhcaefcacidfighhihgggfeegighffiedafgcbgcdiaebdcgeecdacaifhdcadfgbahcfhedciefcfihcbbcadeagghfihihahadagdgggdhffehgbeieahgheiabbccfcdaihafifadcdbfbgaacaiaahifhddcbhbaehhdafifhcggffhfbbdgedefcachhiadfefbbfihhigchhiahbgcgafeahhehcceddbhgbfiiidghiafbbaidcaciiaaaghiebiabcfigdfhhedecceidgdhdeagegadaefbchbbiibghggfeieadigceidiagihhfadbhiegaddbahccaebeffiiafehbafahgccbcfbiiehhdhidghahdchehcafbbaigggeeecehcecffgghbdhdhacgagigchaaebceccdbaffbbdbefeaadcebbcbffbebebabgaaeihhhahfhedfehhacgacibiffhahdebieibebcciafigggfcbghadhhgdfbiegaiccgefaiddeidafggdaacegbageghaiegfhcaihbahbagheagdeahaiggbhedecfaefhdcficdecgbcfgfcfehfeaebccdghefggigehaeehdehgahdbbfcdebifagbbhgadbdieihgdfhgcgfcgiaebgcbeeagbbegiaiiiahdfedhceagehdefihdchiedcedhddefdachfgfhfebdebdeabhddgahadgeffchafcdebeafcgaaghbbagehbghcageiichhbhgacgagdchbdcfahaedaeicegfccbghadhbfffiibbfcdhdeaahfdccgcdiigfebefaacgiahcfabbddaddhdcibaciaaficiadfdihgfiecdcdhgdgfahahfichegaaggebgdfdbieaagdgbiedbecfgfcaccheahbifdifbehfecabagbdagbcdccfcaeiaedhhegefhghaifediefeihfdhebgebggficaeacadhehedefehebebddhfbgdgeaeeaicbdhhfcfehbhfhbaiacefcbgicdecdccebadfifbbfbdgdgcdgggdhefgedaccadbdaccgdfggchbbffffbefdeaficdbbeeaegidecdebbffgcegaccacddfdaifcfbbggiigigihbechgcdcgchadcbdiibaggghdhahffaeheiebcefecdbeceddhabdfgheahhddaifefbbafchibgchiicbhfdbaiehebfgdicbgfahaccafficfhcdgfgibadgcgbaghfihfcebhaifgghiabefeabhdbfeeaafifhdfgababhedhdahaichbehfcddbeebhaabcehiccbceaghfhhebcbbbeddffcefbehafeihfcgghbehdfbchicifaadifcciidbacgeifbbabfcidgcihggbgiihiffegfafdhfhichieeabhbghgfehbaacfabbhfiigabhfhfbefageeegcffddfdhacaaghfhfaceffgibgbcbhehhfhedibdecafdfcfgaibiadhhgdigiifhfbecfgdbhhaabdceabfhfaiefidbgihgcchibbhfbcfecfhbibiafgacaeidciffigiaddbhgegbbhigefhdaiahbffehhddgafaebchfafieefadbdaegbaaceehbceddehbfifhfcddeehiacgifdahheghcaecdbhfhfdhdadcbecghefhhbdeachbhacgdcheccgabbicgigfhididgcabahfdicbeggefcchchdfibfcffbfabdgifbaghhagddbfhibhiabidcfhfccfeecciadhcbchcaebifcfgidehfdheacbgfhfbacbicedhcgicfgifgahbddeghddighbbaiigdcgdddghcehdehgahibfcdfbfafgafdihghfhfbifgbhibhfcebcfibefefbedgghcaighdaccdgeegicdhdeiaaigegahffadgiaacifdcahafgccgcaaceichbedfdbiaeahhfchcbcfahhgdiffhhhiabcbiieeigfehgddhabgefifbehhifhdfebhdfdahdcehfgiaiacgcedbfceiifghdhibehacbbhhgcddcadcchdeabbiiihecibafhfigbcaichhaacagbhdhedfhdibegaefggidchhdfeeichabeedehhgcbffbbgbhfahgdcgbhdidhdefggafihbbbbbcdhbgacacdfhcagbchbcadicdfecfaiecaaebdedddidbgficaeefdadhdhifahighbgeicghaacchddeifgbgicigdgbaehadhidfgbaedahfbeggdbcighebibfigeicegcadgceecghehggccdacdghfahcifabggfecfhgfdbaghfhidihhabbddhhcebhbehideefhccecadciiddbdcbhfciiiiaichfffidccdcdhcaedheifihcaebdhddeacgdehhabechfehiffcecgehgabgacecfefabeebaegddddaadheadaeadahbdaahghceidhdbhbahieebdfdfiageggbffaffbgcacihbbidbbegibgbgfihcedhdaacedcaccigfdggcicbhccagheidahccfhfaggihdfadhhifhahbaiiibgidcidahdcbiabhafaigbbeeafidbcfaibaaaeibgheegccbcbiabhhcgaebhbdccefadgfhbgfhihgfghefabebbeigbefbecbaahdfdceedhfdaiagcafdgedhehfcgadfahgbfadifdcdchafgfehbeahbchcihcfhghbcadceigbicgeedabbcdfdgbddhbgcidbafibhgcfdhcbdgcbbhbahiegbdhaahhbgcdbgdbaeccedehhfbbcdficbdgfhadeghahfcccieeefheeagegaifgafgfcgghifacfccfbghfibehfdebfbgehhaceifigfegbhgbcgafiiehcibfgaedbbfddicaeadiidhadciaibahfdihabeficchhefcgagdddhhcdibecebeaagdhhagdhfagegibeaidaedbhcbibcehghdbhhfgaegdhiihhgihihadfhhefbccbhdcabbiiieeefaighfggciehegiidbdabddaddffiffiieegeibagcgafdfhcihfbihiegiaadcicffegbdcbfiibcfegfbfdcdbhbegfgbhebbeidbfeccfechbbadfafcbicaebadebhaiihfeehffaehffdhcccdbbhiehgdgcfcdehccceehfeahfgbfdbhdbcabiihhibdaibhcgadfffihigggbhgfffieaccgaadbfageeiccbigbibcifcccbfbgbgifdcefdihedagbgbcdebefeciiffaacfcgdggaddfieeggdiahfhhbhafeacageddicfbcgeigfhbdciefdgfadgbbfibaabbbgghagcbbdibaifdaebadbdedihfdagecbedaaifbaehgeaehffebgcfdgbdbhbfbadheeecaecighgedcfdebaceeachcaiadcbgehcgeebieheadfeegfhdedcgeafceagaaifeggidchgghdiggggfccaehdhieafgceagchbihfeidbffefcbgecddagcfbgbcgddebiegfgiffdeabceaaggihfaafhhgfgfaicahhhbggacfdgiiedbfceeceafdffigdbeccdaecdeafbhfgbaecbbfiaicebfbgdbebihegcicgacbihaaghhihaaidgcecddchggfgiiiigfefaddgaffdifhibaiggbaebdbecheibdbggfddbcifbigchehaiecdcagificcbiiebadbegcgceebfgibhdbfaegegghcccigcbgfgegffigdfhidegchcaigaicafghedbibciddgaafgfbebgdbihafadedfcgdghgchfigcfeiihhfghffcigdaccgfcadhedegdeefahadidadhifcaiifibbbebacbefdffcbfgbaffbidfcfhgcaefhhedaibiiebegaidhgdefdhcgfhbgbiceebhgcegfababiicdaaifccfaaddbagbhddgagbdchehgadgacieghibihbafdffcdggiahdbaehfhdfgabdeiebefcfiabbdebhbdedhcdgiicacbbbbbiaccbhbhccgbchbbhhdffcghiicfecdgeafheheaaciefhfgbfhffffaebibcicbcahacigbbhddicghfegfhachdediiaedagfhicdhghhfgbfddhbbfhfcgicbccfidfdcdhgedgfggbcfehgbdibhffdicbgaaggefeehachchddcaccgfihcegbciabdcgfgbbdbiiafhhhgbbbgaeibaggaeigcdhdbfbdhbgifiaghdififadaggchhebbhifcdfhiggachbdbaggbdifgefagdebbifghggcdhaiaadfggiaghbcidadiccdadhegdbbcdfafciahaihieagiagfegidibeehfffibcaaeeggbebcdiahhfchaeggebecccdafidfdebbcefdiffffegahgigfeebhihfefbafggbahfcibbaagbidbibgccbhhiddieeafgccddfbdabcdbgibhfceedfahafdicfcecfhhbgddeeciheacbdechgcdehhghabadaifeffgifihdghdbggbfifeagcdhgiehbghfbiaehhefgdgacbcfcbigcegaffichebcecegdicbahdfdcbagcchiecgihgdbeigihabcchiecadchaghgbhfeifdbgbaccccfhfeiiidbefehhadegcecbgcbbigeaahibiicfdacifbidcffdhheeihcbbbbigcaiegbhdebeggdbbbeaaheigeighfdaedgdgafidbffbcbcfbhchfbhbegcbificiecffhcgggfiaagibfhfbhigifeedhcidbfdhfhcbiabfbefcgcbcfigbaaidaecheedeafebhchdfgfaigahiehiebifcgeeccgaehaicfhfhffbabgfedbhdabdbbcbbfagdibhceicchbfehifcdbiaaaffbefbfahecabbahibbchfbdggieifabdgbdeiefdhbbcdadcbihefhiggggagfeiffbccddgecfggbbfaaefhcggdebgadagfhfbaahbidcabcbgibcaehgbciifchacifabdgdhdgfhigbagbgfhiebcehiffdibhaihcfcdcffggdbdacdcegabeheggchhiihibahfdgcdcdccidigcbfbadighdhchegcbffafdhdhfchhcchdighiacafbghidbdhechbbdiegbaegcaidccdifeeeecabhfdgcefhchbiddahiafhcfaadcfhfegdfdgdcfacedabghhabgbiddadieaifcagadbibicchdhadgdbhadedggffgffhbhgfbhfhaeifbgedaeefcceffigdchebdcdgciibgcbeebbbhahgedgedcffgicagdcgbgeechdcfeedagbidhifigbdeigiadecgeddacficbfeabeeigiebcehhedccbecifhaehgcehbgedbfbbfiafbchgciccfbhgfbeaghbgbfchgcabchccecechdcfedibaebacfbgihieciccehchhbhdiaaddedbibdbebbacdaehgegffehfcahgdgcehihgchfhhicaafahfhadgbiihebffdffffaifefbgfeibbgabcbehdddggbbffhcfddedcdgbcbbbidaibbgbibecbcgggihihfiaefdbbhgdigihcaiaffeidedbhcgaeebgiddfefeicaabdgdfgffcbhfgbibgeacbaeeciaibifbhedcidbgcebgaibifbfdhcgcibgedeifdeihfhhebidbbiafadgaagiicghiibgadcgiaghfddcccdhiigdcgchhecdaccafdficgdbhbbacbebicgghfbeieggidaeefiacedahhdbfegedbfgigieihdhgbhiabdgchbagehfabhgaggeeehhhihfigicefdichedagdebfhgefhcfabcageffgagcaafbiggbeecebihdbagdeehfiaebgicbcadhichchbccbfaggaaebcffdiegdgabdcccdacafdefaeegdihfeaefffbgdchdaaeegacehhgihdfhfafhhhehideecbagadbfbfddadefcidbgficdbbeghgageeiahbbbbhcbgfaffichahchdeagabaaachgfgbhgacibfibbagiaadgaibggfihcgahadfichebddgehefgeadchdghihcfchfciffffghbgbgdaefcfhcebffhadbcifdehbhcicfbehhgchhcicaegfaahifhhchcdhbggcdabeeigadibddaeffcachgfichbdidieihgaeaiahbfgghgffbiggcichfgbdaebhdedigcghaidggaiihhfaebccigdhaecbfdgbabgbfiiccbecdeeaccdifihffhccbcifhcedhegfhgfcfbffcdbaahdieahdcahgabbdcfhbhaifffdibaaiehgfhhfdibabbhgcegiabahagicigceaghfacacccabbabaiabaafccacdcbceichgbfgdgdgggihfcbdcifibaeaffcdbhhahhccgffgggefbicehfaacfghibaaaffhahciidieiidiicfcaaffdgagibhahiaafgbfdcaegdibgedhibiidgdcbbecedghhhfbcdcdcfdidaiecabidcehfdiagcdfggbiagchgeaecfefcheiagbebfififbiabbihddacgiaiiehhbdgfbafiaefefebfacbiagihghhfehbifgfdcbfgacbghifeagiacafgfhcccggigbgcebfhgfdigciccdgaebcabbgbgfaehibffghfgdeaibihihbibbibfbgaieegbacaeebhfebceafcfeidbahhbciegfehddibdbbficahadffccebhdeeagdfibffifigeebhidfcgbdhdhhaccfcdcdhdcdihheagcaidegdgbgeeafecaccdefeibicaihedhgechcggeebehaciggfahdhhhadbgachcgfcefecacdhgbhffbafdcbbaahcecdigheaicihfbbeidaeggigfgifchggefbeacccdghcdgbiegfbacbchgggbghdbcbdbigaacifbbbedeaeifebigibcahbicgaiihghbceahichggcbebdcbfcdhfbcahaiebbfifhiidcabibcfchageaebcagighfceddcebbhiiddfifhfhaefifghibhdefeffdadcebhahcahigcedgehhibagddbbhgehidfbeaafegffhcbhbfffgdadfhibgcbchheihahihaeedfddaggagibchabgahdgehigdfageaefcbebdedgfgfhhcdiccdbfbidagadiaedbgbdficeciefhbgbhhceibgghaicaigicfhbacibecefehhcedgfdabdhgidffbabbdieabacabdgbgdbbabccbegfiahgefgbbbdgicecfgcbedcegghbdeiiaabbfhbccehbdffiefchfbibdhgeacfhfcahagfggadhigafehadfheeffgghgieagdgiadecdbbbfecciahabbheiheeedageaaidcbgddaffhaffffichbidgaffecfbdfhbfghgfcgcfdhgifbbgddfffaiibdiidhaaaeefaaafabhhebcdebiiacihfbidifcddefgaheafeefcaiehddecfaaigabcdecbigcdcbfbaidbfbcaihiafgcbebbefdibddccggeachebdahadeheaecicafidadgcicicbffghefcedcaieidbbdhgaahhfffafgiffdghabeagebeiiecgddagcihifacccfggeaiggddieecfcfcehbdfaagdfgbefeghafhbcbhgdecdbeefbcgidhffghdabgadehgeafeadegdfbgiddbfebdgfbhbbhibgheiaebdeddfciggbdfagciheihbiggbbggeaaddaadcehhiiddcefbhaeidggaceciaebbgffcigaeihbhchiaifghdhifbdbggecfhbgdiihiddcddachbdafcfafbdfhfihcdcbcbidgehbbfcehbbdhgdbghbcadfaegbdedhdahdbcfachhifbbiiidbhaieificfhdeedchicheaecegdgbcbcbcieefihghcfhhhbfageicdcecbdffaeifhiacfdhehbbhbidgbcaacbfiaddcadbfefbdhafgigbabdfgfgbfedgcagbhciadeibcfcceddagdafiihieaghcaiabhgbhhcieibbabafbbcdahhggdeaiiiabafdghgdiiidifiehbdfebhciiifeifecbagegiahhehiibebfegedebaheefhdcieeadehfagbdffgdbigaeddgdiciedhggchaaieidahbabcchacheedbadfahdgdcaecfgbfhhahefiddiacbhebccifdcidcbbechddciefigdfebbaaaedcggheagaeaicfcbehgbeefhaaeegdbigchdccihibbefhhgacieeffchcghdhbbgbdfcdefadcabbeceghhdegdaibhcbceafbahchdeaigbfdgdifadidcaefaefeiecedcbicdhedfbbfgifihifiaccedgbchehbbihfihdfacbacdhacgdgbeffdicfaihaeddidgiffghdhhaiedceedebafgghhaabgifcighhhbbfecfdehebgebbgffaccfbgccecbigdfaiigabfbdefdbfceadhieadhghihggedacfbhdbdedagggabcfacfdehabebiiigeaggbgaaahaeeghfcfeffghichgdcdbahbdhaadacfedhgedaecdbbaiabehedhhciffbabghhidbdeaacaciaebcebfifiaghdadacaebdcbdeacigahdfiefabggdefccigeeihdbaaeebgfegeeaecdheeicdaihcacgdicehhcacdiffcegbfaececihfgbdbgddfefbedbadabiecggbhffcegeagbddcfihehcabfeadaaghchhbgeiabidfbcbdcbccggchhbbdebefacieecfdibeegadcfihgcbegieiecahbfgdbadiiibbifdfgadcfaefeedebcehdgeagbbaifbfiedeaaacfhgeabgegadeaafgebccfffggagbeegbgdgeidcgecgigieeghbieihhchdhagffebcaeecihcedafdfdhbidggehefbbbhebahhicfaecgbggbiichfeicehagacgbddghgfadegdahcccceebhgfiheaagdabadddbcdebieifbgahfaieehahighaiccecbegbhchecifaaffeddbhcebgagafdbcaiggiihgideaggghgaaeefhbbbcegdfbcahgdchfcghafcadibdcfbdhieacibdebfgdhehcbefbbiieibegecfdhfeibhbfbdhcbcgbbabbhffedfaifebaiehdgiegbfedeegbabgbdibdcheiaigeedfhabgicbbggcdghbdbehfegacdahcaadeceifefgadcacehifbbgifihbcdbcdhcbegdbdbfaaiabfhacdccdgihdeaedadbhebifggfihfcaaefefahiiceeiedegaibhibiaadfiidgdddfgafiiibfafaaigfaifiaihhbfbddhgfhiachebedefghafbbabcgbbifdffiecgfgiifhiacaiiiiddaigchcdciicbdhfaebaidficgegfbdehfhiiaghhdecdihafcagcbhegacdfagabhhdfgeafhbifdbegedgceceehdbfffaecccaebgfgeaebhafibiebgbbececddgggccdcfdffhiaffebbbbccgbichabiahgcdbddbffdhdiicbhiehcdefchgddddhhiidcbdhcihfegbddhidbbbhfdgigfeebhfchfghfhhibegccbdgaeidccfaiciaiaedeiichhbfaedaeeifbeddhbbdgdgdbeedecdecfibgbgfafgiabbbibgegbebfigfbbgdebhibfbbhgbdfebegbgibbgdeebacfcfdefcfhbbdggbffchefhehfadbdghbgfcdbfafhffeiihcgiegdfbdfdaghehcfbcbacciiehbfabecbfeiagficbahiaaidddibicbfefigdfaheddcdabffeaebfgeeebhaefbfcegffbiaahcccfcfaidacdcbagbbcdhdcdfghcigdigcdbgdbceedaicdedaedffgdfghfehaeafcicdfiadefeheehcgbheaeaeibcabaeehgcebchbbhfgibdbghebaididhiiagigedacbhbdbiibhdgiefgbhigfabfbgfcfcdiibbfdciiaeibdidciiahfdeiidgfchbfiehbaicgiadfbfbcicggighegaccdabehceagigebcaaafddfeeghgcidfaachcbgdhfbcaeahcbggceaghefggdhceechfcbeagcicdggccbcibbihddcfcahhiiddcaaegegbfhfgabbgibiccfhadgeaegcggfafbhcdbgfgfffgfgaabceicchcbdafhicabciadeegbiiahaiebcgdbabdciigfeggaeifcffiiigihbhdechahcbcbadiedfachbhdddgcghdhgacidecbegeadecgfhdafffdhecfddcicciafbccagfffhicihccghdbicggaeghbbeaagbfdhbdeceaedeiahahfaaebabechgaabdbfggfghfghbgbffefcageaacebfcfabdgahchfgheebaagfeeccieagdighaffccbfgdfdbadheadcgehbghcaaeicidafchgbhddeeececcfiecaaficihifafdecffhaffhfadifaghhaghieegccaacgbfdaifagcfgabeibdahbbcagfecbbaifgcfcccafbaagahcfdghcgbcccbaehghagaececigdafbaiegbghedccgdffiaadgcgcgaefhefcighhiifciicihgeeachaffibbeeeahhifggegbgiaaddgfifcbgbedeahhccbacbbbhiiidhdgedhafahdiafaghgfddchdcbgeadhbcaifdhfifbgbeegeaccahhhafcahfbiafigfheegabcaighaihcbefcffdcbifdbccddahifdffhhbdicggeiafibbehadcchaagdbeebiicaigfbfhcadibaagifdahfdchbfebbhidadehadbdgdibcbbehiahacidagbfafihbicbdhfiageighbfafafaafacbbeaieghgeeghgfgabbhcdihicagbciadhffchaddhgfggfbidaifaiceddabcdgdahbdbdhbfgecefcfbffbbgaahadbgbaaggaeihaabbabiibfggegcafgdhaabcabegcddchacgecgfafdbddgibgfcbbgigcgidcddhacbahcdffcebebdfghbdehfbfdidhbhdbfdidhffegicegedddggcggcfgiaghccgfecaecfgeedabfhadgefbhgbffihihheebgfadeabiiggibbegfghigbbfbiffadbiiigbdafiiaaaedfiacaiihgdgbacidhiidaigfdfifgbgihifdgdeigiahcfgfbdagddifibcdadhaebdaifhggchebagdgfaiigeadeedcgiedieaiafgdcdidhfecabbbbfhiiaafadiichhfhdgghgdaaggghhdieahdhgihbfffdecifacdhabbghhcahfcbggbbihedadhbacchffgfefhciihbbaifgahhbacbgeahiahcgeehdghdabagaiigaeeheehaffadfhbbfgfiigaieghaddeecdfacfefiechhcidgdfabheedefchbaaiegacbbifbaificafafficidgefcccfbdichbecaaeihgdhfciedhhdaigcdedigiggaegcdacaeahgdffdihhcahibaiegcebdffbfiigcicgfdfdgfhhadiadcceedefabchighfbicabccbecicdhieaihibegihbigcieiafaffedbaefeifdigbcaaffeefbeabicegfgcehgeaagfgdcehadcbcdfgecehchcafiacedgideiiffbacichgidaeaagicgghdefcgaifdcichhdceggffahafggbbdgigbbdhgbadeiebhhfabahaccghifgidfdgccgfgdhibahfccbbbdcbcdgciiiadcaiaighebbccdaidceichchbigeeibfcdgcieccgagicgbegffbhfcciifbdbeciigfbdaccfbecfdhgafhacdbahbdddbaehefigddceiggdgidchihghadffbiedacdicacaabeedcfehiighfidgebabcciadcihaehfeeahhdcbdebecaaighcgcffiidebabfbdidcghchgfbhiegeicghaigabigihefcgggfbfdbgdeiebbgfiedeigeiidebfagdigehhfaaggaecgaccdiagaifhaeadigiacagdeieghbcaciigagdbfcaahaddaceacfhdgbhcaacdhegeceadfhdhdbifigdcefcbhhcdcdfiabccffiedfiaaccbiiigdagfdadhfabheacghbciefdgedgbbiggighggihcdbfhefdahdigaiddbcgbgadbaegedifbifabaehghdgficcfhebhbdeggeeiegcdbchdcaiacccbdgcecidaedicbhfcgbdiifhgahfbhiehbgfabcaaacacdbcecieabibdidabbhhibacihedcfcacaiefdaebbdaddhdhedgebebeadfbhhbhdgdghcgeeaahhcfhcdggcaagbgigfegdieabhedfiebhbhafcdifcfhhiiadifhiahchhecedibfgdibficacfdfaagegehbfebciihaeibeaadciecfeibbeafgfbhcbhgdhhhbigfiaaegbeabfiebhdbichehabcchefdaghidcheaigghhcechdhicdcbdadeidbdhghiidacdbbfcihhfadhgadiffaafdhdicacagfabgigcdabdgfchicbhdheihgedhgfbcighafhcedhbiibihfgdhaiggccfigcbiicaahiccghdgbagaifbcicccbfbdbcahebdadifghbefhheaebegfaaecebcbibiiiaiahhdcgghfghbchahbgibdciaacegddghibgcacbacfhgcabedbahgicfafgecccgcadaaddbdaeggibecfgabbeaccfdfbcgbdebiehifgagidhdghghchceiaefeibbhchdddaicigdegfeiagfbbdaigihhaehcghacebgchagdeffgedbddfgacdcahdbadiaabfddbcadaagdghbiafihbgfaecggbhfcbicchifdbeghbaghhffdbhbgcdhagdeehdddgegcefgeicadadgbibdadiabecgfafdiffhccgghaicaaaihddfeghehachdfhgeffbchhabbgdaechicaeiibabcbddgbbaechdafggefihagieebfihggbggdgiafhdahcgdecaedhfeeicgahbcbbbfgdcbgacihhfaiaibffiahdiadicgbidiicedfhbcbageecgfbdecaifcbdehcdbcbhabdfbidggaiaidgceggcgchchagigdigaeiiiddefaiagdbfcbdgdaddcaifdidhaicaafghgfbchahbfgeibibaeiibhcbaahifdaihhfbieeigacicecidacbefgeieehddfebcdfbafeeafgehbggcffbbgdbiifcghiehbhdhgibhffdfcahebacgiagadchaiacdiggbbeefbaiddgffebbiefddebdceaiiidbhhdbcddbdbehibihbeaeefaiacehfcfhbdfhigebifbhdiaafffcbdfcegdgaibhbacaaafahacdcbggcedbiadicbiachchdagbgdbbhacbcfhcbbdcdffbccfchgdefebbcegbbaicfdbfgffacebdehbhbccecghdhgichgecccfafheceahcbadhcccbfcehehahdgeefahccfbgbedfgbfefccgccdeibdadfacbidgagbggcfehfchhhaihibgichefadffadcaecgigaieicbgacbadbbhbccbiciafdgedicedecigdhafccdchcehigafgibddbfifecahhdgfbcbiiicgcbdibehacddcbebhchecaebedhbgbcccfgccaegbhcbhcicdafbdfaeabcddeeiebhdeaecifhiiahgbgaachibdceahfgedidafbiggehdfahhighhibdigghehafcfcifieaeeafcaddiagcdgdcdebhbhiidhhhhdeihgefgcacfffgfagabgdibciahhhhibhfiheffgdbdehbhbefhidbdabecfcdiaaggcagdigeiechiegddfiaebbfadhchedhhggfhadhbgfgfcgcbgegfbfgcgfcafigfhheaffhcibdbeffiaefhfddacdgiagihiedafhbhbfbdhhchddifchehhibaiadiaiifgabhfdchhcbcifbaeegdiedeiaefbagcfiifhhgbdicgdhiihieiacbdacddgahigfehdhibibcecdefgaiihhcdihahcaacdaadbdigehfbhecgiiaeahihheeficbdbdfaefehaggcchahfcaeafebbaafbaiadhbbdeigcadffcbeceafghggchbhghgbebcfcfedegdhgeiffdhidhhdcfgfdgdcebecfchhddchfiaeiedidfgabcfhcebiieeaiccbbedfacdhegbeedbegicgheghgeehfgiididedffgihcagghdebcfcgccehdhdfaaefgcdagadibbhcfbiidciddcfgcefdhfcdhhdiieecafchbhahihicbhicfbebhgeheaefddahiahfaebicdciicddicbeicibeaaefddacgafbaigceafehfichfidddiiidecbhfbbidegfegebgdadcccbbihefhaidichaidcegahaigabiiffcgfbdibfiibhichfahghbcbbecdbcciaadcehbaeaehcidfbcffhcahhhcchdhfeefbbcgbeadibbgceibeffbgfafiieabggcfhchbaagebgcgdfeheabdgghdeciefgiabchcieddeigiaegfagdiehbhcbbbicbigcfdbhibeihfbggafcgeegcegbahgifdghbeebfbhdicidbdgcibbchaicabbhficfhbbcdhcdbiifcchaifiddggdbbdffiecbdfdbehhaihcecadegibicehdbibeaecdbeabedfcchicdhchidhbfbedcdbidcgbdhcahfdaihccbdehfbcagededaichbcdiacicdfeifagadaidfgibgeeichcfdaedabgcachacdffffdbfidhfagfgdhdhbdhhgceaaggbbabiiefdehaadhdafabeciiebdgcgcfegecieabeggeibgfbaeggehcchidgacffgihgeggdgbbichdicgebddidhgeggfcabhgdedbdcafgihbhdihfbhhcdfbafgbcafcgbchdgdeebfeidafaddiibbdhecaeaffdfhibhgbaidbifehagagbcgbhcaecdbhabbahbebgadhihbdiebafcchficebceagbgbiccfdaadahefgehcfgbgdgddfeiiefgbdgddccgiadddedegiciahdgafbdeffbeagbeagfbicfhehbddebeigdhibhcfaaagiiiifhfefaiagaieiibihidcbcdcihabcbddgiibifhaddgehfciefgdhbdbdehiacddcddicibbfhceehgifaidbedchficgaaiiifehdegibceabdgihbhgggigfdcachfaaiddagbefhabieafcichiahefbcafbcciefaigddeebaahbadgbhifhgdedhbgaabfiigecgdadaiebcdiedceefihaeefahgagcicihedfcfdedbcfffggfbacighadbhdcibgifhieehdagcbiaigfghgidgiagdiaeaecgaegaeibeceffeegcfgdggabccdedfbhchhgefdabdeeciedfibheigffigaiebehahahhhgbcgahggaiaecghbehifdcifahdichcbibfhcbfhchhhcfcifcfahabfbahdabgeabfgddhfihcceefeedciffhgfagibdifahbifcibebeeiifceheegfcdabicbhicehgagebahfihbdifchcdebbbffehhggdefchdedcgcebigdefbichadfihbbicbigiabeccbeaifhaidbfgabdbaabcchiebeaecggbbfdahehbhecidcbagcdhcecbbeegchdaaddhhhbfadfaifcaaebhihdbbiiehhegfhbgiiibaaebcfahcfbacbbheibiieddhdcgegdhhbcigdiecfcfaeedfhieffbefagfecgfhadiifbfcbbcifgebiiifbhcaifeeiagheehgebhhgehdgabhicbghgicgfbadhebabbggaahciiefcefcbgddficbacdhahegadhigifiibdffcfhecgccieheifedafchcibbdbhefbgiabiehccfeabcgbhdghefgcaiffeeaicbchchcbiibadgcdhgfffeaaebdegcbdccgbbgahebieaigifidgdfghbaefgaicedecaggefbhhabfidfahbiibdhbgihidhghigdhibhheiebchagefgabfghdhaaddbehigbacedcdfecgceacfihhafgdgcbfefadegeceafadgbhhgdiefebcfgiecabehbebbaagbchfdbbhefidbbeacaggaeidhgbgbbeacdfafdgdafhedaachbifiheicfchffcdfadaadbchbbebibgabhiiihbdgbdibbbgbhgidehihibheifibibaaaghedegfgfaihcehghgihafcabighchfifbbbachfbcighbiaiheidhbdchhafgdighccaciefeaaadebbgbiiabbeibgghghgibfaibaidfaigggcfbgdegedbfehcfadahfihiicachedebhdheachbiadfdhhgcfaidichafgdghccaceeadfhedgdacfdhgcacbacachfchdadfccggfeigafeccieheegdeaceidgfihfgifehidfafafehcdacehfedgifbhiigdhcaghhcahagaaicafifighdhgfhedeahfbaafiebiaggcbdcdfbbggdheaiceicbcceghibihdfcecaacdgbiiieidiecbbbaeddecfbchgfhbgafcdhdbfdiabhdfeigbiidbeadaeghdgfheeeadiiiefacedadgbifdaeaicffdagbifahhafhcbiighbadcdcibchfffffbfgadggbdaiiibdefabbgadfgfcigfdeaidbgahgefhbaicdfccffhaheegibaghaifbebdacbfghhehhaggebicegafafifcfghgadbhafgfdihaacahgcbbegificgadibhdgdccifiifhgfccfahbbdhbbgehedifaficcgcicaieeaaeddgibibeafggcfabciaaabbfebegdeffaibcahbhgbbifaffdbgfabbabeibdfafafceidcicaggcdcfagaahdfdcdgadgcdddhgheagebdacgdgcehcgbaecfhhbffaggeeggccabhgbddacaebfahaebhffcfgbhhgdeiadbagcifeafahcahcicdbccadcgghdbdcehcagfbheifccidddggeacfigeacbaiaedifcfaadiabdahbbidagaaaeigeehhichecbfdehiadcaagiaehgegchhcghgggaaagcebchgdbffhedfebbhfhhdebbahhehffibiggccedebfgdehbgffageabibfiafcfegfcifchgeacgicgegbhibhabbiagddbieicfdaeegefifidaiagdaidceeehchfbfbfeedhbegfibibdfbidifibaeacgfiiddbcchibdieigbfgifcbbgaehgggaigfddhebehedhdaiaeebheibdidccgbaghacccgdeffeeagfehdaacggcdidichdbgbccccfhffghbiahecabbigbaecidefeaceaciefedbfdacehbifeefecfedcifdcbhggdacdeadeifgbehchbaadcadcggieceabbegiegdfhdfhdcbghdfhfafibecdccdeddeabebgcfeghehaggdiigeggdebdifdgeaeafdciichdaehahgecdiigfgafdcdbdedfghihigaebacihieggachcgihdidefghdeafdifhagehcabhfibcgabbifbfaceaggdegfecfgchcacgigfcdhbdfgbiaeeidbheibaiffhcdagbhaabbagegfafhcffidaefbcdiedghbbgccgbbeghaiiedebcadceeeebdbedaibbdighaccihifdhbbhiiefgbbgbghddfdcfcbbbfdbbdiidhifbedfehbicgihaehiagedfeggcgafbhbdiabdcggiecificceeideebfabgfgihbifdefieefcdaieifaaefdfcbfaacicihgbdfbaciahehigebdidfhhafcecdbabccdhfeefdgihiedaibbfabafacfghdeagiicehcibhdbddgificdeeafdgehdfdcdaffafcagebfgeaagidfdcihccagaafgifaffiieaeafbbcihbhehihecghcidafachfddcebaicegificbaahhidegighdcgfhcddfbchffhehfdhbhdbfdfdbbbahddcabcgihaafgaeacdbcachhdiifhggbcegacbddbfagahcacbiiebbechdgfddiccfafebhcehceafgbghgbiabbbbbhdgbiihfbfecifeacbfifeabgcehfcddicdcadeigabdbfcgiacadicbcgefdbafbgieciebbgheahhicbdfefbbbfhdbdcfffihdhiaddifhidbfagghbgiaccciahgiifcifbcihhdffhceidhhfdbdeahfiicicbaeiiacfgdciidefciihdfddgcdicdabihifdifdbefhechefhecbfcaafhdaaahbiggfedgiaeddehgchbhfgfdehdddagafiacggacdchchghaabechdagidhfdbgghifaedfbdgdbdfihhbaacbbiccecgcdeggcebaidfdhcbibbdbiihidhcdeababiihcbibiegeadecaffadcehiheieacdaibgicehihidffbdchdbhgbicbeaibbdcebdgidiagbhbdeiafghfffifecicafbecgbgdbfgcifcidahefbechgbbfhgbhfaiccaceedadcbbhggfffceegcfebibacaiidacehfggbeabeibfdecbgbcgaafabgbdgebgiecgchcefhecgabigedhiagfiggihfdeifgbieeegfaaahfhbgfdafiedgihdgfafdecccaihbfbidfdaahbgdghiaiaffcfaahbgbadbcfdifbhbdahfddbhegigdbhicfgcicheheaidbadcbbiidbfhdefcgahhfcdighdihaifgcdcccgigicgdecbiceecgdaaeidgcccfhgicafgdebhbbfdfdiedgecbfcfdccchbddeicgcifegfhdfabefdeddbbciahdcgbfdcebceegidfidffdcfeifebdhiccbefdbahhichffccegifchbecgahdcgdaebieeigbeifeehhfaeaagigafabaabahfgdadibcichhiaacehbibdhbicegdaebidcgciaagfcffgfdfifdfibibdcgbidcihfhggaegeehciifgiieiiiaefdgabheigdddacecebigahheegbaibbgfiieiggbiahggdgagegdhbaaeaedbbigggaedebcbfdegaiicaabggciaagaffeebhdechbhcbcdbhabefabfdaffigbfabeigbideidiigbbgdibggeieagdifbghihfdfafafefgfgdibgefieecefgbdfhhffhfeifbahadafhhaabdfeebdaccaaidceadiebheeggffaaigccifffabceieiefegbcfbdfdaadbhabdghagababfdhgdfabahgdbdhcgecaheagabbiiidggadgbhahdcddchbfhiddheigdfadicbbegbdceehhdafdcheffegebigacdbgegibdiccfibcgaefhbhfdaaaafhfagfggiiedgaecabbfegcdgeeicibigchchheffhhaddaefegbceadaiabaegdbbhgcdadiaghigfggbidbcchbfhciaebiiagbgaecdhechgaeidcifiecigaihciiifbeddbbedbfhhahgggihbicggdcabafhiebagabafcahcabigbhhdfaffhceiidcfccbchbgdihfihcgghfahehccafgbceicebiffachacbccaidbbhbfhdgfaafagfchgifcdifacdfccaieffbagbgadegfceigcechigifedfhafgdgfgiidfagadeiedhahigbeecdhhdeieiehigbddaeggfbefadffbfahddgbdiecagfeacacgagebebcgcghhahdedebbefhabiedhefciafehadcebiadfaceaifdiefeiiccafbhaeddfecgghdccbebcbdidfdchcadiafbfdeeefhieiaegaffebehaeiehgdehdbiifihgiifdhhcdfbdchiecghhedidfgbbgdegiddacegiibdfdabgdieehbcgahdeagbiffhgdgbfifecedaaiccghbhihhecbgidehabcdbedchdbacccdfhieciffdfaiceechddebhhdfhefdcbfcecaiififdgghfedacadccabbbcfcbheaachiahheagbiafciabfdfbfdagfeiaagifbbeghacaihdaighihbfeecccbacahbhfehicgibdgabfigcfacaeebffbdhaifdddcdcbhbegdhbaggccafhbigieageeihhdddffdcaeabeabhgdfeggfcdhdcicchicffbfdhfbabiaegigbeihbdiaffghdgiigefahffbcbhdhigeighfecfffdgbdfaidabdbegicgdighbfeeccahcigfegehcaibfcbiaihhcaibaidhfgfgiccadhbeieiahgbibddchcbaigeaifhcechihahehaifbfbgbhbgcabibfdbddbhiifhgacehhdhhcfeigbhiihaacgfahhaeiehhahhaieaeihiaehdgiabfecbdhgaabcaiiadghiccidcghabeifigifacibafaheabdabigfeghagehcegichdefhbihdfgfhgifgifbfifcdahfgcaadghiacgbabcbfaacadceddeegachbcicdgcacedcdcccbdcdhgdhcbaicbaibifffbhgcgebccacgciebbfdcddadagagggfidadefefbcbhhgadaigchcagffeaaifaeaadefaaiebbbfbfgbagcfbeiheaeeggdgeagiieagdffahaecgddbceebafbbihbhecighgbbcdbhcibaedfhfhdaiechbfeibgdabgbffdgecdiigihieefgeihgccefgfibidbigeiccciaigbebiabdcfccfacaiaecbcaecddiaibhabhiecaigggcfedgacighgffheiiegfdgbacdchgeccbfdhahgcgaaiciidfeegdheghfibdhgbdbbhcedaicacbfeigccigcggedbeagdbbbeiaeefdchddeiegadaeieaedffiagibhdcedidiiehibhacebdiifhcgbiaahahigbfcfehhiicefefhgfaahdfdedgdbeaccbdaddhagfdgaafffefffahhhecdfhchfdffgdhegbgghddcebdffbabgfadciddcgghbhbcgaaeeeaaciggcccidgedfadddddaebidhfhagdeaggbddddecbcgechedgcebfcccbgebcbdfefdfggeachehhafcdbcgdddiihehdcfifiaaeegcdiiecideabidbihceihcchagggbfgaeecceggefigfheeigfegdfdibfbhadfdbedbifgbigchccfeeiaiaffehgciibbbfchbgahgihbddhhibdcgaaecbhcehgdgibaeeefidfdiibifaieiagfceadcdbfifdfgadcicabcedefaacdbdchaihdhafaefcgiafcifggfgfdgaahgiacaefcfaahadibaedcfabdgiefdeidibeficibfeidiccbicffgfibdggbcgidaafdefbhddidbhfeifdgacicdcbdfiebbgcdbbhbdhgdecaccggbabdbbbdiaeeifaibbidbgideecigeafaeedhiihgfcibbicefeiddffgiiaibddchdieaegghfghdfhgbbiedegabeficeafieaiddiefddhicffecdbcbeaebbccadgbdchhdbeacafifbegficebfifgaedidbaefhgbffdidddbaggddfhcdcgebifhcafahbfafiihadfbbgfhdiecfceehdbdcefeadbhdbdacgbagbbgabgfihigihhfeegidibdbdaicighhddhgiegedgfgfabfchaibfhcgahbiedabgfahbdhaeehhbceaeichefgibcdghdfagcifaiadiahefdacfdgfdgeieieiceedhbfbgighffdbgeabigegiecfiggafiibadidbdeeeihbdfihicigfbhhibheegedhhcdiifddbdeihcabifafgfcdhccdagcheiafdcaadhggeiggaeabbcfaafbfchdiacabggffehbaedaiieeiahdaiafehgchedbbedcgfhbgacidfifaebbcefccdhadhiheffagdcihehbheiciihcdccaheeieafccgdbeachfhedgebccbggbieafahdddfggceddiggiffbbhdadfgahhchiabbfhdedigfeabacdifegifgccabihbdcfiehhhbdedehggiicicdbeegeghafeiebhddhabhhbhiefcebadbddhbigghhfgchegchbdhbfheciabgeidcibdhgfbgcaheheefbegdcabfheideffabefhgdfdgchbhfhdbaghehaahgiaigafichahbiibifaifgahbibgbheffihhbeeaageiaieaidhdgfafieggaadbiihaaiheaiccbhfechihiadaiifheahhgdefbiiehbdbigfbffhcbadafefdbcbhecbfeeehbhaicfgcbhffcaeaihedchgbbbfabgciccbbihacghifdgedddhabfdfgagbiahbeheadcaeahaecbdgbfafidiahhbbgcfhachacibhchbfceffafgcagiibghcehgfhacbihibieefbdiecfbdadffddhcdhihcgfhfbaahcbifhhhbfegbaifhfeibecfhgiffbdiieibegffbcbideeefeabefbdbhbiedchdegbggbdaidddiaabfbbaaadaeaebhedegfibhhaffgghfacfbhhfigagebebfbaeciaifhhdggfahaedggibcicahcigecbdidecbfgcebbdegiibggaaifbbaddcddefaidifcbeahagccgfadbgahgabhfdffcaacfcfbbafihefahagdhagbbbidadchciibceeedfeidhifdeciccifgfbicdcecidebebiahcaifhafafdheihbhahechicdafcbegecbdicfgebddccedfbdbiaabddhbchagcbbfdfebfbifhdhdbaeaaghfdbaedbbegcadcddhddgdeieefediiahfbeiecbehdeihcffgcgiagdecfhaaehheidhgfchigfaebbfeaggbacbgdgcidhfabhddaighagiidgiabachcgdfchaeafcefhhbgaffhcffdaefadhcgehcbfdbdcfgdahcdcbchfdefhbifedgabaddhchcdcddhffhdbbgcheahchgbcifhfaiidbibbebhidaddfceacbcaidhadefegbgfcgeahaideadbghdbficagbbcdcfabdaibacadhidbfgfdgibfbgchabbfegeeeddigddhhiigiibhfdifbffaebhgigiibiigcfdgaiiihgegaaghdgedcghiecceghgheafdefiabfaiifhhdiegfhedaeeidcbficaaidghacdhhaaifghcfddgcgdeaidceebfffhaebfhdhgfefdichgfafhfhbcgiaiaciceghbchiadhcedicfaiahacihgcdcegddhgccfbdagbhhbigahihdaaeaaciadecaaebfibeiicchdgbfefaegeigadhgbcicifadcbhcafegbgghdbiiffcbfcdibhihdgafbcbacbifcgdfiidgefiifaegdheagaggcdhiiibeidbegeahhdafecccfefeicfffhidchbigebegadbiihacgaahdebicfcbfhaabbeegebabbchhbefcbfeibghiegeaghahfedaeggdbcifaiebfcfhafggdccfieadgcbbcefcfahbdeefhdhbifdbeeegaceiibgefacddbdhhebacfddeaceadeiebifcaebfhbbiigdebgdgiacdbaebehgeeefdaagdhgfgaebagbhdbcgihcdcafigaffghcbgehdchfcbhcdgccebiaiddifeihciicaedeghfaaiiebahddeahghhbcgbghbgeahgfcifiegdfegcadhfheaedebeacdcgaicdgfdffhhhdbcfdafbhafhcdhdhedchhgeifabichediccabchhfahcfhdcdhecbiafggcgebgabbbfeifghdibgeficiiicdhgibeehdhficibibgedgfchafeiiebehiddcdfbecdfhiebcedaeagahiffhcagfchbedcgfaacbedbfigifbifhfabgfiefaifddeddicgedbhbciefdafchcfcedacdficgdgbhhdgahbbebdcgcfgheagdedhifchegcfegdidfeechahdahbbdagdgebdefeecdeabheifeacgideaebaicdabebehhicigdiefdaehbhfafhbbhebfbhicihddfiaeehceagibeeddfdcfefcadeebdhddhhfaibcficcgiiedeeeaafdaaeiicfiiaeciheiiebgiceiiighahageiaibfagfibibdiihcggdadbigaebibeadfaeaehcededbfhhbfaeadciebgbgehgiaffeacggbcidfcacbeifficdacfecaehibeieaacfiadgicfcceegagegghheeagfhdebachebadffgbibfbbffdgcgghbdiiieedabchbdeigcfgfieigcbaabebiaheebbibhgbbghffadgbafcihbabeefcbfcgfgdibcdhhfdgchaagacgicahghacchbbbbfgfbadefggichdbhbgbehfdeffhfgbcfhbgggabeiciffhhdgdefabigbbchgfdiehaeachcagghdecgchebeibafficdchadedibibficeeifgidhebhdaddcbeabdhabaiafeeebafeibfedchabidbbheddeceadacbdhaecgbiffgbgichbcacdeeeffdbdiheedgbdcdgfcaahcadedaidihiegdahbefgfeeedfihcfbbhagfdchhfhdhbdaaddfdghciehabcgdcibfgicagggcgefiebigddgigfbaieabbbcghegaghhbgdfaeeihfiidfceegaccifgchbbabacgabdigeddgbaibdfgaigdaddgfaidhhdgfeaebfdheehbdgifieeccfcadhaehgafaiabccibfbagcagbdfhifhgaidddaacebicdbfegihdegdhieccidahdeghbdffaifchbfaiggaahafagabciciieghgegbafaigchceaabfefecghffdhacdbfafdecciefeefghidafedagchfbhbafaeebgcggffddchbiaehgdhbdieefifabhhiibeadhaiiebfgadcahdeagfhhdgidihfbahdgffcbgcdhhdfgbifbhgbdchhfafhddibagbeifghdcghbccfbbhedibibfhcdihhhagciccaagcbifdfdfdiiihcbdhgihigfdiechbedchffbebbeffighcahehgfiedbgaagcebgecbaciebbhedcdheidgggcaeedbheacbhfiaccaebbiehaecabfcgehahchdgcgagdfhaehgcigefiehiadgidicfaebiiacgbifaibiaccfhabbfdafhaegiaaacadabfddbcggaifbhfhggbdahegfgibhiidbiicfgfidiidiihhfcihidddibegdbcbdgcddigcdidhiefgeeabcbbadggbaafbeagbdfebeciefeefbhcbcadhhebiaebhbafihahgfchabdhfhdaaihecabhagficeggbagebcfiggdbbdgbgiaadhbgdbcdcighgiehaehieghheiaaffgifeggciaiafdhgcgcehicfdgabccccfhhiggaiifihbgehihgdicfagdgghdghdcecideiahcabbghafgfghihiffifhdceehhdhabgfdeiichiiceccbiieedcadebhgigaccfeadgiaehehfhhhebccadceibefdeahedgfebeheffdfbigfdhfggagbbedgbhgdgedeaidifdafidggdbdggbihfiiihgagababdiggdbiehiediiigdeaaidbiggfehecgfdhdeifheffhbfghccigcbfbfdeigahfefggagfahbefdcefbiaidfcdbfbigffhccggaccifihchbcgdeiigcdgchcigdabcgcedhbaeedfdfiebiebafdbfhdheadbdcidhbgdccehhhcciibbbcideagdbbebfffcgggdgiiifbhebgefdgaeiciedhcfcgafheacbeacechhifagighiiccheigachdcegbighgdibdfahihhdigdedgcifdebhabceddegabadbefcidaidhbbdffigifabdcciefabebccebdigciadgaccbffdgiadhbcbffddgcihfbfefcbaegfdiadeihdbigdhgdddghhbdiabcdegebbbdefheddhedcdedabhechcgegfeibfdecihbacdhhcdibdadifdehiaccaffhecgcfcfhbfhbcchcdiahaceedaeacggahgbhichhcibfgfbidafidiacaiaigcdghbgehigaiegafcbigfbfddfdgadbcafafbafaiahdbcbagcafgcebbhheihgecifcgaibgibhfgigbighffiifbgggbbedhdeadcadfhhchdhbcehdeafcbafcghgiedfedeahgehbdhibfgcegeedfdibecigbcbheggcchaehgcicdeibdhbigbidgeaiagcdbcgihgcgaceecgadcdecbfehifaifidbffahfaidcacgbacggdibggceabgdbiahhdcfehagffdhdiggigfghbgfeabecihehfiddebcggcfiahgfcgcbbabgacegdbdbdccdbccabfeadfcfaghfdafedhgdeiigefgbddbddhbbcechchbcddideaefaaahgaegbdagecagdbffbdfagidhhhbibgiebaffbaidciafhdahcegbfgchafbaeidceffgdcgihaaaaigfidaefaigdeahcagacgcfbaedhacagcbeghcgcaagdcdcidhfbdgadgidabacfechcbifadfhibhadhgbidbagidadiaiadibiaddbbciehbgcaeacibhcfidbheabadhadhhgbgchieacdiahbfbihdaddcigfbgefeiihediiicfdibfigeieaagafaibhecfebfgdgbahbceghdebihhddecffchghiefidaaiddfcicfhdcbgdbhegcifahgafiacihegcgddghgfehgaffafhaiefhbacidcgcieeiagfdecefbgbgafiiddcfdigfbigfahdfghhichafefifaihdgggidedhahbaddeeabfadeggfifhhehcffbhgdgiahffagfbceccecefiaddcbfiefehfdgdhaifhfiahgaicfgecadgbchegeibfefffbgbbghicfhhdaidficgaegifbeieefdcdigihfccdfaigbcebicgcabgbdchfffhhhbfeiicdfddeefhegiggcdhfchbbdegbiaehddhcieiddciehcfddffebbdcddcgcceafceggibggdfcfcihchaahadgafbfghehdcciehcfbgccceihcaeaaacdecfgfbaidfdbfdehhafcegiihibegfhcegbichcdaegfchcdfiabffghiabbaafghebbgdihbgghedeedgbbfgcgigafahehdibdidicdgigehhbbhecdacgcdadddchfbficeagfaicegeaccfdhgadaddaiadfbiiegbdeacdihdbgebffeffgecfhdigaeicabhhebbeciaibeeegdbibbgghahbchhifaagefefhcafifachabdiahbageidihagcghheedcbhaiiabhibfffefahbicagfbdabgdbdbdfgiiaahafaabhgcdecfagceibbabaagiaififbfcacfdgceeadadahaegffadiiheaaicgahdfbcbgdfaidbbefgbfhefbfcfbggegaecgaihdbidgcddefbdgggieibbgcaggdgefhbbidbedfhbhhaaigcdfgccachhcfacgieeegbehfghffeabafdddabfhfbacegaeiachbfhgefccdibibccbgfihiiihfbigfaadichaddgeafdfbidghagichfggddeaacfbccffchaiafcgdfehccbdfegiihicddaagebiaaeiahideffdfdbcabaedihideadcgaahgdgdacaiaigfahhhbeabeihidcghbabgachidhfbcgadigahgaehhfbdhiahbbdeibiecihgbgdbeefbcahicbecifeghfdhcgaibcebhieggiceddaefbhabdddbacdaagachdaagfigedbidadbihdafigbhecfadbhbedhfefhfgfiddicgdgdghbaeiefcibcicgaeihdbcbddeihfideibhdaeffecdeaeaeghbgcafdbdgadgiaicdbffedfhibcgdefehdehfbbbeiiffacihdahicaadgaaaadaigccfgiebihdeebdegdidbdbfabiihbhfbebiaegdhidcfegiaiabehgchffiabbdhagfhdacdhgfhheficbiggfbhfagaaaciiidffifgaegdbiegdfaghiefdeihfhbcgfdebabcfbihhgfcicagiiicaeddcafgehacbdccegigcbdhebdgaecdiiebcbgifgebddbddecfedibagbfbcfcedaabfdaghichbbgfbdhfaebbdfgchecfaiceabgaagihcbegehfgichibaibibfabfafefbheedgigefdebagggfffgibdbidfihibgiahdaadbbhgghibgbiiidaaibaiefdhbdfciaggcgehahdiffbgigfhgbbgiagbafhidabbidgiciibgahafhdfihbciebccbadbfbfifadhbbicgbedcdhciiacehgabicdhdiihhbbcbghachfgddhgabbdfhdiegbebbhbaahhbfbefiiefhifgiaeaicdfgichhiagdgeiedfgcccffgagdahhdccdhbcbidcegbeffafddgcdffcfaaecfghadchfbfcgihcgighbhfbecfffhafdfchffccggbchcegeecafbgcbcbcdciacifeagebbfdghefgbaebeafhdgccigeicbicabehgchiadibagaecgdfbcgidfihebdefccgfhchiahfcaaigbggiibifaiibhigbdbihhgfafadfbbagbffeefgdcdafeigaiciddibcfbfaegehbecaadahfaggghibiggbfbihbdacaieicbieggabfabdcidafddhfcidecfaebedghbegfccffdhafecfcadgfebdbhicgfggdgadgaicbafdhbheeiehghbhfgefbcaehbedgdchggcbadfacefigfhcgebhddechcefdfgahggdhhfedhahibhhgdgdcdaghebcfedgcdaiaahdfaaeacdciedaiacieiibbecfcidgdihcbfdabcfdachigbbgdcahigaadcdebifdighcghgacfbfbeechheddhieabchiaacehffcgficaaifcdcfacfbaedbdehfbhagebaaiaifeaadbdbeahahaiahghchdaeceibaefgbggaffdegghedbigeigdgbadafbhbdcfcdcbiceefafccaceffhcibhbcfbhfdhifehdafbbhdhdfgbhaieadciadiicbdieggefbcbecbbdeeedbffcdeefdbcffifddicacbaibbedhhffacegicbdcagihidaeeaicbihddefbdeghgcffidhccgadheecefghhhdghafcbadfhfcdafahfhifbgcdaggbgfebgfacbahgcdbeheeadecfcehgdfchdeechbieegbfadacbbcbiadbicbcfiaheebafefafhihfacedihhebifeefghgehfiahgafgiabedhfhedehghbhbhegicibaicfaicdgiechcbighdbbgaabhdgdbcfefahbiccibihfgfegccggaffhcgdfbifgcaibegegbebaagdbeaebefefdddfcafcihbdabcbeehbccgiibeaadhhehahabffeehhgccgdedhbdbhchagggfhdehdifcbgibddggabfcchgiaabibcbbhhibdhbdfgfeahgfccgbfaigccdeicdheddhfgdhggffbhbehgcgdbeafcgceihdiagecadegadiabccdiidhdahffibheiiehfchefdcefhdbcigchgedhggbigdhafhhcdahbciifhcefigggabagdbgefdabediafbffiefgfedbcdaadbgcidheaddibihaabddhfahceacfefgfegedgfadaabbhchegfaghddagbdaedcghaehihddiehebaiididgihaheeceedhfhgbaefgfhgdfedacgechaceceadadedhgecidifhbddffcghfebibdeighhagbeebhiicaicdcifacgeficfbdgibdhaiiggeecegbdcgebbafaaefihhiaabhebabhigffabhbahibihiddgiaeicihefaggdcbfbegdfeghciifbhfahfedchcbdbhafciifdegafaadeegeigcdcbdhbebiabdgbaaggahcdghgcicegdfhfbcehdcedfehbebcdgebefbhifbihcbiaegbdigbcfgchegcbiddbccfcfihhegbdafdihdiceiahdiebfdafceiiciideghbaddffhcgdcfcciaeadgbefifaefddgbdhggbbiahcdhchahffhfcgeehchhaceehhfdhdadhaafgcfchhheaegdegdcidddechgghhebgfdageigaebaedehiiegaffffebihifcbacidheggbciicihbeieihhgfcfeiibhbfcgaidghadbbcgcbaibfdeffafchbebagacbabgdccaahagdbicbbfhbadefeidcaifgahbchaaccdhghcfcbheedidebceagbbbhedhhfebicbebchfeifabeecgghhafegcgbaffhffediachgcffdgdbhbcddgaafdbfbedehbgdfhhggfihichghaffbbdicggefgfehebadafgdebediadeaihaaiddffafafhafbfgecihigbddfihffbhbaiegcgiihbccgieeeihbaifgeggihhheibicchhffbgacaafiebfbchbccffeiihieihhdaibeiiecficbhffaefaaaabhiebhegbggcgfhdhhgcfgffhgeddcebheeaaiaehbiigedffgfeieidbfgfidbfgaiffedgcbbgccifddfhdcaigiabghbibgihiagdciccbfebchacdeiacfichffaeagidgabffciibihabgigeahigibbihcegifbecebfbcebefgfhfhggdbidhdadghdidachiehddbiaaaacfibhbfahagdeifaddigdbdgbabdggfbbdfhfbiabfccghfbbggdbeffcfdcahbaffefcfbchgcebighbgbbgibiefhfdgccagffficdegagbdebiebbaebgadeciiacbhiidegeahgfdfcdcceahfbgdibgggbbgafgghbgcciccgbgebfgbcgeebahgdgcaebeafhhieghiaaibiegcfabfaiefbcafgihebgbcfcfiabifdbhafbbaccgbihfabdicadfgdfdhicbbdcabdgcdfhadeheafcddchcdfdbcfdaafhfghadccicgafhdccbegihihbebbbcdifaceihhhagcfifgbdhhcadffgeeafhdebidfaefafbeaiefbagagcicbchhhgfdeccdhebbdadhegfeciaagigfdhdiadehabahdacbdadideedeifigdbchiigbahdagfagcgbaaefabfhdghgeccabdheaeabcabciaiiebhdacedehddbgahahhdhhbbiiiheiafhdfdahbchfceiebgahceiahbdahigghdaffaadahchbcfbgifgagbhacbdefbbibfahfdeibidgbiigacfhacchfdfcgdfbfgfeceiccafcbgbidfhagbgiaabfachgigefagdcbdbdeccfegdghfdfdcebbadhaedebhehidggcaghcbhghchgdcbadghabbcdcihiiiigbdbdihigiegeheicahgihcgfgibihgbgfhdiaagihieddgcgbhbdcabfaceaegddgagddafbafgfgibbdbcdbihhgciegahcahaidcfcegghiabhadhdeffghbiicgfdhhcafeabheifgdcheddeadahfcbibehgdbgchdbehdiafgehcaicdedechccdbcgaabdcciigeddfhgabhcafdagcedehfadbhiaibahdceiiefiihhicfeghiehbcghachahhdihgbfabefgbghhdgidbidigehfggbhgeefdeghbbdghdfchaddaddddefhfggagchbhgggaibdiadbihghcadechcbhhfbgifaadahdfegefciafgbhedegghfeiiffbgbchidficdibdehbbeafagiggdiehchcfggbififghchfeadefdhddfgfhiaigbbchagcieaaagggbdfhhiifedehgcidfcgicbbaededhbhfdgebbaceccdbgahahifedefcfdagigccicigibffbaigeicghhdfidhbdihicaefgiaddafhchigdhehhaicfbdfgcibhiaeahhgibcagfbfaibdibdcieiefefeaidddideiccabcdihghaaadihddhdahhfgdgfadegafgdfbabciehbgfagadfaefcaafbefidigacgchiedficccdidadcchbaicgfadhgdeaghgeeibdbhbgefgaiaiifeccecbgehhecchdafghecaccbggdfaiddgfdhfebcahfdageefaiaiefdgcegdhhehfbcdeaeiihcdeggefdbdhecbfffcfgdbahbiifcgfhcbchibhdbgcfaacihfbehbcbicgddchhbaaghhfdichaccgbbhibfhahficgeedchiaaagdddbhccgedgecaigfdeddaaccidbcfgecihciaidhhgcehhbgbicffeedfgbciieihiefdfabcggccebabgcdcfbfcehbhhcbbahbigidchchbfbageeahidiadgbdebiiddgbabfffdehbdgdebahdiifaedgfhhhcggdhhddibdagcceiggehcdgidfdaacadfageecbbeddcihghghechefgicficfeigfgfdfffgecfbidhahhebgdiehhadfadedaebhfedagddaacifiecddfbiahghibdidggdhicfhaefdghhabacfcigebcfghhehbeeefcgceiehiddfhfgddgcehbfcacfefegiidgcdaaibebdhfcahgdhgfghebicgggeafeiebieedgffihcdfibbdhabhfddcccagebdaiabhefhcdgcdeceaffhidgaghgegghhafdcdehbbfbchedaffdgaebiecfadfhaaiecefadghcfgecdfddacbhghgbbibageaehhhgicfggehhbidcgdffcahdcciaecbdfcahibiecdceibdeiifdggfcdbhiabfbcifeeafgcfgedebgegehfedcbfcbeifgdgfgiddhagddffeceabbadgibffhhhfggabedahcececfefiahfgaehfdbbdbeadbfbdbgafgggdfhghfhaeefhghdgfbifefehbdfegfheffafcgiabeacbibighibhhefdeaachdifhghbdfbibceghbfhfebdhhefcbdbeabdgcfagbfcedaiibeceafhfeebgdabcgfgdidiidfcedhbhgccafiafehaeddddfcacbaefcbdehadaiiahcdgciibfggfcbdfhageedacfigecibafheieaghefbbaeefgiccaghdfggbbgaaghidcegcfighbbcahdccffacihdffgdcaffhgbghdaahfidiageiidghiebcbheabcccadifghchhiciggfgaehdgadehaciiiahhdhdefdccahccccgagbehgccahgcdcdiaidceghfagidaeceecgigdebfafecchageegibdecdihgbbghbdbghfbgbgcabgbcifefcchhhfhhehfihadghbdhigihfgggdhfedhfagbedaciicgdafiabgbbdbciebhbhgiibgcigiigibceccdieabgfaiieafeiihiaiafhgiffbaiafafefcecadbfcdbefheecgfdafbdgaaabgaiedeccidhchfbbhabagfgcgbhichaagihdiaihfdghhciehhfdffbfiaggihhadghhibdigcbiebabifeifeaibdaghdfadghbfagggbhbfghieidcbeieiaabgdbcgdbfaccbiagfdcfabdfhfbgadcfaiegiihfedbbcccgchbdiffiibfheeehbafchedgifffbcchbgccgfegifcdacfbbgdbfcbcbgecdihfhhdgbhhihdefaigiffghicfdggeacfddfbdifadfehbdiabdbahdigehdeahgedgiiehhiidacgdaddigcdcfghbaaagdahidcbcdddfcehhehgfidfgcgcbabafahcagcgchfgdahcfffeedcdifahfddhecbffggdbhidbfabadebfdeiacgfbaagheehieibgbchcdghgdhbiffggedbihfceafeeceibededbggfdfbcddbiabicehgcfhhicghihcbbddcfgighbdaibgfbghahageheaifdifgggcaafdecffbdahhbbfeggieghfgccchggbiacedagadbedffffedifiahahfaafdfedfigaahiceigcadbedcdbieaddecgcbbcgbbgiicddbafaebbicidibgbiafhfbgbbcgcaggedfieidcedcahiddeecgiidbafehabicebifdigfdcaigighhibdiecebgehcchaecfdgdbhgaeebhgeebiiccgfabhcchfbcbbcbgdfbfhcehdgiegicdibhbhhbecigdfdbfibiaeciebdfgddbfedcdacggccidgihfefhfhhffgcahbaeaccigihagacccddhaaehbihdiabfhbgicfchighhfggffadcbcebcgbgiiggehdichhfdibhcaifefaedbbeafaaaaabicihfachdddbficacaeeafbfbagcidfiigcdageiiigigibfccdfhbhhfiaaadcehadaciehihbcgieddgdecdfbchiaaghdahicgdccefbggaecdaiidgghafcihgfcbegeehgdfiagdeccdiadafiieiiiaeaghbbegdgggeibecagihcdfagaaaaedbadfbhaebcighdbeehidbicacihgcegicdbgeghddhdgbadgbgfaihbbddbcfgacbedbihacahbgeeabfcdegfbhaicgghfdachcchffhgdgaahfhdbhibbgfaehehahbaaddbibeagebfgcggehfdcaficcedebefigaehfhgcghcgbdceacbbggeichhbhfebhebihbhedbfihgadhhcbcgibicfaagcgeffgbhdghehhbcigieabiififcibgeeccfhegececfifffcggebhbdgaciagfibabaggbceadhdbcfhgbhaaacdchbfdghbabggabbidghigdeefbihcgbechbgebabifiebadfdcahaihfbfafidbhcffafbfceediffggegegfiheiabiiiifaggcggadbbhiifigaeafaccdicaehaahfafegiehagggfagahdddagchiaciecegfafigbbfbgbaaccacacfgaddhgedcgcbhccfaifhibcbagdbffbbiddaeihfadgeaebhhfahaibaiabfagdhabeahcfadhcfcfhefaaafcdbhdgbehcfdchccchbebcgfcahcbggaahcadfdidccehfaeidhaahahgfgfchgebcafdfbfafdcfhegcahhedegcefgicbcbedacffaechgggfabdahebiciigaeghebeaceahibibcdfbghdchieeihdcdibbcfifgfeeacddhfgbdbafeddbdcgihbhggfhfchabbbefbhfgcgfagefaidhadhdcagebedhgcdfefidgbdhcigbfafbagggcdgdgeehcfafhahhddhdaffhbhedeaibhhabhadfcgbigicighefeafcegiibffgagceigdadafhdgaeebihicdidafhedgaibbgiehdaedeagfbcaeahifebciabbhgeebgehbddcghbhadacahdgachbfefgcgdfffafifgegbdhifdhedgeibhbbbhfdbaehgbceadcbeidchbghbhahfafaehgfgaefcffdfgahfahfegeieaiehhgachfdegegahabheiibbhdgebhbadibhdhffaaaiiegdfggfhggafaegfhdeaiabchdecbaecdcibgcgcgedbbcadacaaiehhadhaeebdfeehffiicffcchifgeciedfbfhafhibedacihegaeffcidhceghieciececcdhfgibbdbcfdeeaddbeeghbeehcbhecideidchgdadcaabefciecceeifgafcfeghiiacdehdbedahibhfddhcffgebigagadfihhhaehaicieeeahfhghcbcchiidcehccecigiiddgbhcdcbgfhiahbceadhihahefdebdbgbbgibddcfhhghchdeahheddcdbccdidgaddcfgccebfiifhaefeiccigdddfbdcgiahgceifbagcagbcbeaebhffdhgbdagecifiiihafibeggefefidafbeifihdhccdafabfagdbegacaebcdgfidicfcdbedidgaecdedgcbacbecbfciihbbgcfdfbebgfedhddebbgbiddbghgdcfbibigahgicaeecghhffgbiahicfhidedggehaggeahgddhgaieabdeifegdafeehceeieifadggahibhdidfcddchhbbffeiggiaahgifhgghdacdeicehecagagbdbdcbdaggfafgefdcdhihcgicceaigdgadcfdaffgaedfdiciecacheceiccidgbfeffhcfdbiifbeagbfeebbhfdicaccbaiiibgffgiaihhaeaadfciichfeabhigaibfacfciabageageigecbiibgfeaidadbdcaahihffdbabccefcefahhadecdaacfgeaghddgihcgaagciigcihidchggafefhabgcfbgigegehbgefbfhicaefggaiccdhbccfffbfaaeceigcgifciggfahdfdfhhgaddhhcfbdabfhgfagdadhgbabciaiecaefidghcgidaghhegagbbiecgfebiccgifccbidgiedbecdcidddhgiihahgbfigbefedhidaecfdgfhdhcifdbbhaddedbcdibdeahdafhahfghgcfgeceiacgfiegacbbgaifhbgfbibgfachgaecgcdcgbghaidiaehfgcidefhbaaigadabeeiciaddiebidcecdccefebaehfbdacgadiccefcgbhaccghdegbgaeigfbegdbiagfiibdhgididhecbfgegggaihccbefacdaahibhhabdiigaedifcedabichabffedaabhgffabdbcieaibcfgeaeeaacbafahdhdfefchiahiddcfdcdigbigffidbadheiiiifcegiecdbgichdaechafciiabgcaadiabhcbcaeggaeciaiabcfbbdfiibhdhcecifdacadeehgehhfhafgiaghiigfbbhcgeeehhbeechbgfbicdbeebccciehibhcgdbaibfadicehigcafffibgicaghagbehabfaecbiadaddihebbfheifbhdibcfccbaebdbbagaihcbbcgegbdbegfcifcagefgdedcaehibhdbbbfeeagadbcbffeeeaheagfbdfagcdhdiihadbdaggeihbhdgfhiifihdegbbfghffgcdhadceiaeecggichfhacffcegaeebicbeieeifacgbgfbhchidccachhcggeiafhadieeeddhehicahccaifeiiedcidahcgiacbdbccfchhggbdegdahadhcgecdcgighdfbadhhehhcdcgciabafffhhfegehifbhdgbgaihhddfiadgfefbbfcdhfegcegeffieagdgaiihbeegahgagfefceigfgiagadgeddihcagahiehiacabiagebahgcbebheacibedbaccfeddiidfbfbcgbdgcgbhiabegdcgdaidbdagbefdheaidaicdcaicdidefefdgfggaahdhahhdafehdehfggfheadicbgddbcdgddbaehgfbhbbbhebffhaafcgfbeachcdhgadhhaecbiefgdiaibbgiidbidffhdcgeadeiecabdgdheiafagddebabegdhccddhaghgfgdcehgfacfaidifcddabadfeiiabbfeaahighdafibbahgefhffhccaceigbfbbbehdecefaihgfddifahgddcfabdbgfiecbehfbfecidgeifgeaeceheghdefgcefghccfiaieahdbidggffaccdcefgeaiigebcadggfhebffcicdegdadeabdebebedaeecefghhfeihgbdfgehciagchbfhebfafcfcbfhbeeiheiebhicecdahedhchbddeiaihcedfeedfbhbebcgffcfcccbeibibdcehhbfacfifdeccgeidbiaiacegdeibdcaabadgibdfhdhbbegfdgifdehggfggeaedbhgfcddifbebiigfdgbiahfedahgbbahigedaiahcceaeeeegifeihccgaihieadggfgaihdgaicgabaddceeghibegdaefdgibifaiacacfigdfadfiabecadacfedadaebegcechbeceebddhhebhbabfgfefdidabffhccdcdiediadfgbfchggibbehiffecfcedabfbabifdibhbdigfcicifgighgfbgifhcghahheaabieigiaeeaceegccafiddiceedchecaibcaebfagifffihegfaieaiggahddghagaecddciffdedhigiceagebhacihbbhbhicdedbfeeagbdgcgbehbedcccfffeedggiaadbccechcgibbhgbegadciecgiiebhhagebgiageefcfcdahdhfecafaccccgdhabibbggafbghidfbibiccbfficecghbegihfccfhdhiefhcifbfcgebfcgcifaafheeebdchgegcgchiaciiedgbhecifcdhbadffghgffdhaechdbfhbabhfgdedfehihiighefceecffdbdagadgdadghfbabfbfabaiheebhcgebhhcbicgiedbeebdhcfheedbehibbdiciiihbbeecdhbdhbhdhagcebhahabaadcihahddcibdiefihfichhbiechddffcbhaehhaiehdaggedhahgiihbfiefbdgifiddadadahbehhcbhgacddaebeieaeffgaabhceefeafbdfcgfcgccccgbhdgidcedfcbciaiedfchhcddbgaebaeibidaabffdgiehfdfidcdfifcabiihfbfdfdddhhaihgdiidebceaahafiecifcbbaaaibfcabahiadccbbhbeeceafceghcehdfdifhdgafaddbfhadgidaggahdgcfhiefbfgdbhbdcegedfgighifbdefaeacbgaigdbeedfcdiihabafggdiddahcfcfaffefgibbgiefgbchfifiebcbaaafebhdcgefihghcdfibegbbcfdgcddgigeefeeigdeehgfahedgfdccegbieefdbadhhddfbbcegccddecfiehiicbedcgihfabcbgbcccidccaccaheaecbhhbbegdhifbabihcaiegedeaiaicgeebciicbgbffhghefeficidedehaddicigabahddeechdchceifefiehafhbbgfhccffbggbcggbffeidhiddddgdfcaggeacdeehgcfdhgbecfffgiaecddbgfhfhffgfiaedheegafbbgcccedeehcgegdeifbihcfdahgabchgdeciighfbeigfcibgeiheaifdacabhgcfdgheehagidcbfdigieafafdiccigabedicabhgbdhcfhidgdcbbcecgcdbfcfibeghdhdchbgbdebhigehehicdchhhhfafbfgefgggiffebfdggfaeddbeegibgbdgecefcfdgfadebgbihaahhachhedicahffhdichagebgcafcdagfhadchcaffacehecdicacafhebbfighaadefabiecadfgheibeecadahcdgaggefhgaiigddcacibaieffbigihhabaehhaiidhgbfbffdbcbabefedibgabhggaiididbeefeibeiieabefhgchhaahicccbgcehbhifffadihafeifcffedfegchiebdiebgigeihabahcdddaachccfhgggaeaafebigefhedecfifdeaggfihihfidagadhgcaicbachacaigcdfbdcichdfihfbhabgdgdehigeieddaeaiihhgaghcciigcefcdefdhebihbdccehcchfeefiidciibfegdehbbhhdhebeffagbehhgbbghiechdeibahaeiaagecdhgcbfihcdfgifbbehbhihdcddcacgdfegcbidcaefbfbbhegfgchdchehihafdfacafcbigdcfhdgdecdiiggbbbdfcbaebfdiceecfeebhcgdcfhidacagfdhebifdachigadedaebdibcgecdaccbdffbadagcihbgbiedeagabfiiaaeieceafchhgdcaaeigfeddahbiebbhgggeibcbfaggbffdhgbhbedabdhacihiidfedaafcfhedbiiahhhceebbhcficdchgcfdiciiaibchaaaedfegfafaahficdfgifdihdgabceecgahgefbihghfiibffeeagifbfdecebiafdahfeiefccaeceiaegdbedbaeaiifidbfgciabdegiicagdaaifccbhghdibaehidedhhdeehbgdiffbfifhadhdaceifcfcgaecfghedhfbhfacfihddafhdbbfifhbhgiidiahgabdecaihcbaiddgehidfecicfaehbagddgacghaabcdggeiecbcfcgcdbagbbcbfcicfahahbcdbedfdbehiihcibbebefgibeaadgcbebbfiececbeghchcchcdeicafiafihagdegegdcgchdahgdbdgfegegdiaffhafceaghhihgaadidifchheaeggahdahgifdiccebiecbheegichefdbaffgadcbcdafbdihgaafiiehcaieadiihiaahbhecafcaeedfdbfdgfiabgdhdbciefiacchiaiiifibhggddbfdigcccifagfihcifbhfgicdghbgdahechfafgggfcafffbcfeiahhdffhdgiaefdieaicciahhgfegaccggichfbhhibhddiegdehegbcihbffcagfgceebccdfeagefgbchcgfhbggdcidbichicghifccahedhiaaidecibeaghgebhifhhahfgiifdiggdbghbaigcgeaefaccfccifagdhegfffgiaahdefbdhbeehgadgbhefcidhbahchddcbcdibaiigcadfbbeggggecifgbacbdabeecbihcgiabggfdicdgcddaihbiiidhfifaddgfheaaadghgfdafbihgchaechafcbdahbghdgcgfbbibdiifcebdhegbfcghcdcbbbhefhffedchbffcchaagefeegfdigfhbiddhheacbgfffhcbdhfhgbgibfaddbidebcfgehigbeghcihcahfhcgghhaeeaheecchcebefdffdeccagegficecgdcbcidifffdehihgbghhbeaedabaeeiabaicgcaabggifcegidcaighfcaacdhgcgbaecgciiegbfgacieheeaahhgihgeafadbffhhhaacaebbaicdaghccebahabhgddaibcaidcbgfdbfdbifaibbdhbbggigaibgabedfghhhgbifiabbddefagaccaffdeiafihifeceeeachedhcfechghbiaicbcibdhebbehhdegeeeaiccidhfaidgchibicfigidciafhabedbafcddcgiccbdgefdafaadbdecgefifbiabfeihfcgbebfgdicdbcgeiiaghghbfeihggdbfcccadfhcdfcichdadegdhihfeiegheffgbaffafafeegehidfaeadaeciiabfibggcecehhddbhdigadgfefeicififibhibefceggbdahgceeahgbgadbgibffdgeeffifchidabgicaacggffiehifidcfhiiddcbiggfafieaaceecdihhhbfgefcceaigeddafabeigcihgafcfchbaiibegbhaiacifgacbffdiddgehecahgchbfacedgebaiidbagehadehgebbahaeagdffaidghdceccaicbbhcdfhhdhbebfcgdahdgibhedaaicibdgadadabhdhbfbgdccgageediaiccadgbgdgbgbfbahcefddcgigdbhghgfdbgbbdihfdffcegigcghfdcebahdhdcfhdfcgihddeidffhehbcbegbefidecgiddhggeihicidgihaheddgihgdggddhdhcbagegiaechebedbabdcabcfccbeebfigchbcdaabecgaadbiegfaiefheiaeaegbgdcgdhheiihibheifaiaddafdfgihgdeeadbbhecigaicbhgfdcfdgefaiagffgcbagdhafceddggaiihfggbechghagidfececehbebhcgigabdfbfbhfghiigdfhdhfaiagbcicacacbdbdiagiedficecagefggcbbbaddddhifcifghgiadgfgdbefhidcfbcefgcbdbcgeabceebiacdhcbhcbefgeehcecaidddhdacgdfhahaedagdddebgbiacfbhffcbhcdfffgdefacggeibbfdfaabdgccgffbdfiddbecdeiffcfffdbidbfddbefgccaeeehhhfdbcechabhfchhheiaddgghdeghhgfchdigeidfabhdddifgifdhfgahaggahiiadaefaiicfifehfaibaeaadaidgdabdegbaccihigieeicbdacbichdbefeigihcbeehffgdhbddfbdigacbfdeehbbfcfbacheddiaiegaaddchcafeidgiaeihbacddfgadefiaegechhbhghbahcachbahfcegbgbefiiiiaggecbfdhdgdifafaefehhigchagcffdhdebbhgbgfggdchhgggeaagcedfdcbccicgdebffadegedcggiedbhhbiaggghchhebggebdcahgahebgecgedhdicgdicafdhdibdfageagbihdigdbbbccdebfdacigdghibfchegbcegichciabacfecahghebeehhehcdffeiichbdaiagagifafhigfdeheefffggeceebdefffdgbggafceaicbbhiabagegibieeegdghbiggifcihibibahabbghighafifedeeadafdhehhfhddbicdaghghbhbcbbadahbdecbggfaacbeecbegaccedfcgbefeiefggdbidigebdbgagedaighbegadbiiiceaiieccefdbaeihhbedfgghebcdihchbaaeagbcccdgcaafcfbcacedcbfdgaiheaaegfbifcbdahibebfhbcffhfieieigfhieeiabeiiiaiehcdddgdciebebgebggefiihafhfcdbhdicaieaefigiggefdibddeigadafgbgiichfhffdddbchhcbdhcifagggghahgbgedfdgcfahibbgabiacgdbbgdgcchbgbagbiggbffigdaidiighhaheddcgcbegecihcbahcibgccfeifachhiadbiaebaadaagcbfacbdihaaffefhfiahbchhhdibeififighiecaeaieabiebcebgffebghbbaafhiadfdecbeggeadihihffdeeifcegecgcdeeciccggcbgbdcbigghicfbehhcddgdfbafigdiccieafgbafbfbgeceedhhibhcaeediedgecfbigbcebcifhhhgebedbeeeihfeehfbaciefegcahdcdadhifegfifeecchdebebegieagiddfagcfahehhfficgbihdehcgdgadbdabfefgciaiccfiffdagdfcfahhhihgcigeggigegaagiddeaeagihfabeeddfbhibchefddeabghhhhdcbiificdieifidheifefdggagdbfbgifihgibeeaffacieaeghfdeeehifaifceehbdhgbhbihcdiaedefifcaidhadehdgfhdiahaeceeegbdgbccbibcaaegidhbbccadbeacacbaafaabdbcbgedcecdidhhgdhghdafieadcbhfabbhgdfdggdafgcgdcaacfdicicdhciadagggccbifbcibgbhdiedbcdaddgcaegdfiggcgaghhaeefdcfeegidghgbhfcieabigagfchhadfafgeffcbdiefidccagfgheghffgcgdggcifbdcfaabeeihdbichgcdgdhidgbdbbiifggbighfigceehhdbdbgccgidafehbecebbihaidheahicfdfddccbhhdfigedcigficbdhhggffcbiahcddicfbhfedgfeifggfbhfcccfbdfaaiiecfgghichdhghhifidadaecaaaifbehdgedfgegbeihdhhbafegdgcahdfdiedbfbadbdaggffidggeceacbagdicbdgbfdeegfdefeccbahdcggchiadegeiicdbabgcghdhchhiabhbaagdddcafgicgbebdchiadgdiahcehaeecigbgdaiigdbedbhfhadhgfcdafcfbgaaiedgcfffhgacfifcciddigcbghgccbggdbhebfafigaibhadfhgghehcgfghcdecggabfciiiiaeaiaghbiedhbhedibcbbcaabeaaiffaacifbfecadeehdehecafccgcghegaefhdebafchbediaigihdcaceehbgicccegaccdibicbhdehghbadhiddbfeeefdfgeifeghhaiihhfaiaffbeiifggifdffiaebdfcdgecebcbddaaaihhfeeicbhfhhieifaafidbfdcecdebiffiigbidffggghaieheihdcchhfcefgahbddhhahiaidageidcddehccccebaecdhibieebihfbeeccbeeadfggcibchghfehaahhhdfbafiffadgiecbhcbhidfefficehhaehiebgicfaedcgcbafeghcdgfdffiihcgbbfdiddbhiidghiccbeeihigbadciedhddifdfcebeciccgeiicdhffaggdbfbeggdahdfadgaghiihibbiedgcgaghhccfcfgaaeahebaaiiihagadahcgbiebfcbhchhgiiebifhcdcagffeeaffbbciaigaffhaichcdhhddchdebfiidachffbhbgiebifcgddhgfccciiecaggdhaedbdbdedegaddbigiaheeiafifbgagfhfeibieacbgibedbhhaabgiigdbfhbfgcgfifbeegfachfdfdddbbfcdfgdaccaeafaegfgihicaifcgcfiggdiaeeceiegeigfheadbfhhagcgadbidfhafehhfgdddceccfbfgbifhfgheadidbebhiahfaedaibibeiaihgdgibgigaiedabifefgfdgfcibhbbbgieibhdigiihahaafdadffccfdibfahaibfffbaabgigddhbdigddcadfdedeigfibaidbccffciegacicchiiegigbdicihecbcidbceaehgahdibbiihibgdffgaahgcaagihaddidedfgbdaaffeeddefchhdibidabcdhbbhbgdaffgahfdiffeeacbcaghgggecdhegcgfhebbgfdffhgbcdbbdaeffgfcghfcadifihbgahhccafaahbcgeeaeagciieachdgccfcdhehfihbaeeciiheffcgbihieeiefeiaihfefiahchcfbhfcdhfihebeeffefiafcghbhiiahgeebcgbacgdageiiibhbihbgchgdiafacfabcaihgbhheaafagddfhhefffcigehccedifcdhebdcfciahdieabcbifhaffdcifcecdeihgifeebggaaiacgcdheagichihefceihcecddicgighachiebhbfdddhddaagidcfabfhbggdhbgiebebebbcafhefaeiahgcggiiacadaicchbdiaeachddefdigidiebcghcdfdaaibfcecihbdcdbieheaedaificfhiibifcdeeccbhgcigcebbcbbdebabhicdcgcedfbfidcghbaaehfiiicbggdhfbacbghceiiefifghhhahcghddedghbhcaefgddibchhihhhcacgcdhcibeahabebhcbicicbdifhdgfhhheceadeibbebgfchfaiiecaiahcghcaeadhdiicgaeibabbgibhigbiebiacgfeiidgdgfddccedecdfdcehaiecacabigcfadhhaiihbhhieegdagdichcdefcefbhiiigfebhghfediihbcggafaccaiebeidabhddhhhaiifiigichegfhghhcdcbahiifeieeafdgffcbgefdfidfhdidihdchdbcbhfdhggihdfdgcgcbdeifefcigafhfcbhehhgaiaaicchhhfiffffdhiiiebhacgbdbdahhigfdeiigageeiaahceiiehaechcegiicbigidficbaeaaiffebfaichffhiagfghgffedhciegeidfedecidcficicihcbedhbgheiegihhabdghdigcdhhabifbcdhdciageaccdhdfhfhdcdeibaffigbecihiiifegagbebehicdiaegaefaecichdfehcaheefaccbchbahgdahagcidacegggbdfefgeacdffcbhaddidgifdgfcbibifegbggiabcfadbafeiceagbgdabcgiieheeheahdhbeaifehggdhbehfeaefffhfccfdfeficcdeceghefacgdahceciafhebehdhbahiihdhggbchhgbedcgdhdfhbhedidhcacdigadggcfhdcbiedgihfbdbgedhiidiigfbdfifigfheeidhcbeefideeaaebgebdhccaddfficcdefibhbdabggeihgegdehfahehiciceeabhegchhigcggadddieaicgdeedhdehdidifgbccieddagbaeefifgafgiciggeecfbicfihdciafdceaiahhebgiaedeiaieiccdhhcehbbfghgdebahhiccfaagafbehbaiifgegfbfhaaeegechhcdaahehabhchchihhbabigfffdagciiidefbhabfeeeegihcddeacacdfadhhbfidcfbgaedfabceabhgdcadegfigedghedeabhbdbeiheebcdbfaiacccdcgdchgababihbedagffbchefdchecgfhecfabceffhafbgebceeaahcdgfegafggbabbddadbadbibadgfafhbfcgghccgcfffgdhhigaafdehchdbhaabbfgddfeiiibbhecfcfcbbibcggeafcgehdghaechfbhdbfedcdgeicgfdgafdfdifbhcaacibeagfgbichagdbeggeddiadeheaheaciagafcfdheehbcdacchgbgdecdcadacbfceaeiabhfccgaafihdbfdggiibbhihdaahbcfedbaiibadiceggbicbabchdhbhiachiciefcehigeieibdicheeccdhceeafiggcgbidhddgchfceaddcaffdbcegbbafghgecageeciagihfagbgidhafafefcahggbgbfehhfbahddebficgeaggeefhigfabcegegfaffdicceigahibhhaghiegddhfghaaaeaiacggdbhaddcgcfdbecfddagffihehcbhcdehhaiafgccdfigecifbfhdafbbbbbdfdehedidhchbddfhbidfgfddacdggcgdaehddgbgdhdcidgbdcgfdfhbbghiggbhibeghacieeabhghigciibecbbeihihebbaacdeadedfecchidciffdaigbabchhdcdbbiiaihgifhgfdiabbceiggigehibeafhhhiegibadfcbggfbieccdbceaeegchadgehaaiaafgadfecbihffhdfabiidbaafafbghfeacdgcbbbbgiebgbeehghcgeadffghcbbigbdbaehihbaedicfeehcgichiecgecebbcaifccgcfigifcfacddigbhhgffgihcigfgcddihbdagadbhbecheghdabieidgdheiigddaabhcbggcgcebehgggchcfiadbibfdigcfgffdicdicagcecdibabdabaeehhihcibdhfgdddagfhhghehbebachbciigfacaggdhaghfcaefbbeaeibggeacgbfffbgdhhifcidbffeedcaeghicdcddgdiiihbagdifaafgghbgdcefdihegecaeaifihaebgbaeagbdahdcfeiieibgicfcbifaeccabfiihbabdfedgdhbbifgfcidacdbdhhicfegiggbeifibciifhfbeaeiabgeigagfbchhefiiafbaiegagecfheifbifgedbgbdbfdahabhhdibebgdegageaigiaecgiiiabghiiafiihgaehdcbficegfahhdhdeageeighaageaihigieifiieedbeeeiiggeahhfhfigeacecghghbadiffcadiccgefehifecfgdgcgddcbaidgeiaiedbahaedegebiieieffbibabaaahhaeiiffffgfabbeefhehcddeigdibaahfcbibfeafhhacdcfiddcbhigbhdhhdbidfcffdaahhdhhbachgdagbaeiaaddbcbehdefdfidiihhdfcieehgfbggfdccbdghhhhihcbebdcebibhbhdiiddeegifdfiideefghabcaacgcfiecdhadiecaaifdgfaebfafcfgaaddebbcaafiacafbdbdeebaihiibgfhcighbgaicehdgigbidfgghaeddegbeghihdibidbbgbghhfhcbdaiccahhheaifcfhacaagaagefadgiaedhgidcdgihghbhaedggfchighihehdfgfeceiedeahbgddgbbicaaheebbdifhbdiebieghdgheggeedigicchiggigehdbeddfeefdhfgigichchigchcgbgieacehbehecefhgceibadbcdecafdafaiggiigcahiafihafcaieegbgccddfecfeieihdibeifehbddagibhfhbggagfefhiehchbchegddfichahabhhfeehffdicifaegcbbccefbfadabdicdcefgigaciiibdebadhiahdfciffdfighhacbeabhahbhfhgdiccegcfchgihhgiffgbbagfhhihhbggiidhahgeedhdifhbdcagdcdiidefgehfbaaebgaaaecffgbigaddefcbdidbihadghiiibgiibffieidefccfgdgggdagibifbgfhebebidbhabdcfedbaicfhdahaidaghdfgghbecehdfadehbbeheifhagebaihbfifibgfddecdgddhihbddhcciheiaefgbegdaaebeafbdhhfadffhgidigehfcfiiieadafcibidcbiehibcbhgeadggeaedhfeggccaeafceiecdhcegiiedccbgbiadfaicaggagbafhefaddbbagbhcheiagcigeffehfbfdgdcihdieifgiaeiecdgebehebbcaieihfacighfebedfedgifihfiehfdfaeeegeiggdhfadcigcdccgiaiggfccadgfiiifichdbiaifgefbfieaaaaiffahdhecddiaiebfihbdgfbcdcabidifdddeheddidbfbdcfbagchhedfddcbhheabidbcebccihfegfbcaigdfaidffhcefghbiibfhgegfbgebiidieffgaafdcgccfaahhgaigfaeiihahicabhahefbdigagggigbbeiiaddbhidcgbigecggcahcgebgddbccbagagbddgghbbchacgffddhffdbhefhbhdcdfdacfaggghaahaiefbchddaibiahiahdbhbigfcceiifggcbihaabbbiedabciafdgibgaaggfidhicahaeheggdebfcccgefefaicahfbigbhfbeddagibadehdddbagiaibafegigdaahageabaddheehhahfeggigbedaebgggaebiehcbgbbaehbgdbadcdcgicgbfhebgihedefhhgbacgahahabhebaibdfigeiddbgbabgcbbeegcgfefdhehbghecbheeddfeeebachbgcibfgdcbebfiiigibdacihededhcdhdbhedeecchdiihfdebedgbgbiibfedegcaiaacdihcbbccfhbddcibachidbihbcbgbgfbibifgcfggfieigccfafcbfdeaihdgidgfidcahfbaaffegchbcabfcebfifdabdccigebhhedhebcbbhfafebcbfbhhbedicfabdhgdahaggbgchedbibhdfcfeaiahcggiifeihheieheegciihghhihhdhhfggggddadaeeecfdbgchfceahehefcdihefcfhbehbbhbeefbbeeigieaegchiibfhidaaddicdiacihaaecfggfihbefaegihfiifeggcccdefafcidfgiebidbhacbehfifegagddgdcfigdghchbedffafgcghfbghddahbfdegeaiabafdhgehicfeehdafacfadggaiahddafgdfaiigcghceffaedabciafdgdedddabbebfdibdeifbbcebfgceaaedhgbaieadfiibbbfddggicgcdgcdfcciegdegbbaibggeihhfdfgbahaehaieehcdiiihbdcaahdchdhiefhcaacgbdcbihhbebccgahehcbfgdhciacefbbgadfhagebidhiegeiffcfcdahhifbhfehggcbedceahibiigiffhbecffhghciccaibeffaffccbdbeighcecgdheehdchbgadiidbgfhdfacbgceddgcfcdgcfhcgbeddbhdfdehefeicchcggibhegifdfchgbgegeccfcfbcgdcbbhcfdcdacbaeefhhfgibbeihahaidcgchfcbafbccfgcafhfhcdbhffgefbhbfhfhiagchccbhfaifebfaiabchghdeiffebidfeafigcfgggagddheacdebidbbifgdidficbcdidggghigfbfceigbgbacfbaibfhdedabhdabhgbgiifebidbafgghecaegcaghdgbgadebecgafihhafghhddchebdagbcdggidhigdbaghdhiedcefggidfggegffhcbaeidgcgfhbdgifgchhaahfhbbdadbaccgiighdehcceifidafhgeacfafbfghfadfdhaadfgcahccaheggggaeddgebfgcgceadegdabfcaggigahcdgffdhdeggibigdeihchfcbaghhebecefcgggeabaagbaiibifcabgdacfiebbedgidfahgbaciggdahbcfaahfggcahdigfaebifhahghdiidagiadbiibcfihahcifcifcacigabddfgihcdhgdhggcbfdbffcehfaefaeggaihdbgghhbeigagciaidchcgebcibffdhigfiiicfhbhdgfacbibiaeeifffdfbchfbcgiiigdhhghffefdahaffececbghgfbaahaedfiecgbfcghhhcicidgebcbegbeahfggdgifffcbbhgebagaifiaeihhgiibigfbhdbhehhdiicfehbabidaccghhhacegebahcbchhibfecegcgcghbfadabdaidbheafcbfecdfehghbeafefgefecadcfdbiaahigcccdhfeeiehcdbfgebgcfffchdbidfbaeaaeheihciceffiffahcgacfbfdadeeaahhfdgibbbaabgffbbahehfcgchedcedgaaeaeghgidedghhdhceiiiheghacfacgfgddfdiihddefiggcbigahggecbdiaabibgdbaedfgiaecbhaeacfgfbhghgfhgbaafedididdfciecfhghgefaagiebibbcbicdfhadgceiggfgdcceehbbbdccbacgighfghacciegfccaefdhbhigccfbfcfiacegbeedbiddchbacbffcdeibbgceiaidhfdhhdbiahbeifgdaaiffeebiacbdidhhebbbcbgdddiecabfiicccihidaggacgbadhaiddibfhfhfghhbdhbbbcafgidegbicdfhhfbabheagbcidfbahbhgbfdahiaaffbbbgigeaccdicfhiichahhcfhbdafbhfidhfddggegacgahgecfieabbdfdcechcedihcihbfgbaghgfghhihghheaghgdddegffaddaeddhiiahdhieicbfffgfihaddbdcgeidgfagghiaaieghchchggbbcbggcadeeihafheebcbchbceghihcccihcfadbhcfhdeadafbgfdahghhffaciaffeibccaabiabcbhfeaffdegehaiefecccehhcfifbefabhifadffidehcegggedfdfaafhaafgddihgcbhhfehdieeiecdcgafbafhdheccfhefgigaahggecaheaeeiidbfeedagceecbachaiiegghcahifediadbfhgcbaigibhhbcfhbfaccdibiechaghefeaihhaadaeaefbffghfbabeiifgiaafieedghbgbcfbcaeagfhgaffdafdghefhceiagegfahdcdgdiigibefgacccbffhdghaecdbifhcihffdifdicdicacbfddidihgbbfghbeaighihegedhdababdcbahebigeegbdahdafeceecffiigegghebffigceddedgbdhfdeah");



            //var iv = sol.isValid2("aabbccddeefghi");


            //        var iv = sol.isValid2("aabbccddd");


            //var iv = sol.isValid2("aaaaabc");


            //var iv = sol.isValid2("abcdefghhgfedceba");


            //  var r = sol.countDecreasingRatings(new List<int> { 2, 1, 3 });


            //var r = sol.countDecreasingRatings(new List<int> {3, 2, 1});


            //   var r = sol.countDecreasingRatingsCPP(new List<int> { 2, 1, 0 });


            //var ms = sol.MinSwapsPalindrome("ntiin");
            //ms = sol.MinSwapsPalindrome("asflkj");
            //ms = sol.MinSwapsPalindrome("mamad");
            //ms = sol.MinSwapsPalindrome("aabb");

            // var cr = sol.CanReach(new int[] { 3, 0, 1, 2 }, 0);

            //  var p = sol.generateParenthesis(3);

            // var mr = sol.MinReorder(6, new int[][] { new int[] { 0, 1 }, new int[] { 1, 3 }, new int[] { 2, 3 }, new int[] { 4, 0 }, new int[] { 4, 5 } });


            //            var cc = sol.CommonChars3(new string[] { "bella", "label", "roller" });
            //  var g = sol.Generate2(5);


            //var root = new TreeNode(1);
            //root.left = new TreeNode(3);
            //root.right = new TreeNode(2);
            //root.left.left = new TreeNode(5);
            //root.left.right = new TreeNode(3);
            //root.right.right = new TreeNode(9);
            ////1,3,2,5,3,null,9]
            //var w = sol.WidthOfBinaryTree(root);


            // var u = sol.NumUniqueEmails2(new string[] { "test.email+alex@leetcode.com", "test.e.mail+bob.cathy@leetcode.com", "testemail+david@lee.tcode.com" });
            //var tf = sol.TotalFruit2(new int[] { 0, 1, 2, 2 });

            //  var f = sol.foo2();

            //var c = sol.countMaximumTeams(new List<int> { 5, 1, 2, 1, 4, 5 }, 2, 2);



            //var c = sol.countMaximumTeams(new List<int> { 4, 1, 8, 3, 6, 9 }, 4, 5);

            // var c = sol.countMaximumTeams(new List<int> { 10, 42, 58, 22, 51, 6, 63, 3, 9, 98, 97, 95, 23, 68, 27, 70, 29, 1, 22, 49 }, 3, 12);
            //var l = sol.countFamilyLogins(new List<string> { "corn", "horn", "dpso", "eqtp", "corn" });

            //  var i = sol.findTotalImbalance(new List<int> { 4, 1, 3, 2 });

            //var te = sol.texteditor(new string[][] { new string[] { "APPEND", "Hey" }, new string[] { "APPEND", " you" }, new string[] { "APPEND", ", don't" }, new string[] { "APPEND", " " }, new string[] { "APPEND", "let me down" } });

            //  var te = sol.texteditor(new string[][] { new string[]{ "APPEND", "Hey, you!" }, new string[] { "BACKSPACE" },  new string[] {"APPEND","? Impossibel!" }, new string[] {"BACKSPACE" },
            //  new string[] {"BACKSPACE" }, new string[] {"BACKSPACE" }, new string[] {"APPEND","le!" }});

            //var gc = sol.gridChallenge(new List<string>() { "mpxz", "abcd", "wlmf"});
            //var sd = sol.superDigit2("9875", 13);

            //  var sd = sol.superDigit2("7404954009694227446246375747227852213692570890717884174001587537145838723390362624487926131161112710589127423098959327020544003395792482625191721603328307774998124389641069884634086849138515079220750462317357487762780480576640689175346956135668451835480490089962406773267569650663927778867764315211280625033388271518264961090111547480467065229843613873499846390257375933040086863430523668050046930387013897062106309406874425001127890574986610018093859693455518413268914361859000614904461902442822577552997680098389183082654625098817411306985010658756762152160904278169491634807464356130877526392725432086439934006728914411061861235300979536190100734360684054557448454640750198466877185875290011114667186730452681943043971812380628117527172389889545776779555664826488520325234792648448625225364535053605515386730925070072896004645416713682004600636574389040662827182696337187610904694029221880801372864040345567230941110986028568372710970460116491983700312243090679537497139499778923997433720159174153", 100000);

            //sol.minimumBribes2(new List<int> { 2,5,1,3,4});

            // var tt = sol.truckTour(new List<List<int>>() { new List<int>() { 1, 5 }, new List<int>() { 10, 3 }, new List<int>() { 3, 4 } });
            //var l = new SinglyLinkedListNode(1);
            //l.next = new SinglyLinkedListNode(2);
            //l.next.next = new SinglyLinkedListNode(3);


            //var l2 = new SinglyLinkedListNode(3);
            //l2.next = new SinglyLinkedListNode(4);
            //    var ml = sol.mergeLists(l, l2);

            //var bf2 = sol.bfs(5, 3, new List<List<int>>() { new List<int>() { 1,2}, new List<int>() { 1, 3 }, new List<int>() { 3, 4 } }, 1);

            //var bf2 = sol.bfs(4, 2, new List<List<int>>() { new List<int>() { 1, 2 }, new List<int>() { 1, 3 } }, 1);

            //  var bf2 = sol.bfs(3, 1, new List<List<int>>() { new List<int>() { 2, 3 }}, 2);

            //var hp = sol.getHeaviestPackage(new List<int>() { 30, 15, 5, 9 });

            //            var bs = sol.BuddyStrings3("ab", "ca");

            //var bs = sol.BuddyStrings3("abab", "abab");

            //var re = sol.RemoveElement4(new int[] { 1 }, 1);


            //var vp = sol.ValidPath(6, new int[][] { new int[] { 1, 0 }, new int[] { 0, 2 }, new int[] { 3, 5 }, new int[] { 5, 4 }, new int[] { 4, 3 } }, 1, 2);


            //var vurlp = sol.ValidURLPath(4, new string[][] { new string[] { "a", "b" }, new string[] { "b", "c" }, new string[] { "c", "d" }}, "a", "d");

            //var pl = sol.processLogs(new List<string>() {"527771506 111186861","507336886 451913864","274673668 56172121","507067818 451913864","507336886 507067818","274673668 831696632","274673668 451913864","451913864 56890051",
            //        "526393340 646024821","615008389 274673668","554316372 809815918","507336886 615008389","615008389 76731002","656564087 906342698","253313766 753290919","274673668 76731002","831696632 507067818","154194267 658732874",
            //        "56890051 274673668","637700023 793696384","56890051 56172121","451913864 507067818","76731002 274673668","864250034 864250034","507336886 451913864","507336886 507067818","554316372 791817798","131049042 376719871",
            //        "507067818 831696632","811497682 63100538","507067818 507336886","274673668 76731002","56172121 831696632","864250034 615008389" }, 2);
            /*
    891331683 851362051

    507336886 274673668

    816891240 801259225

    321211429 80068912

    615008389 274673668

    855293372 451913864

    309581888 376679307

    56890051 56890051

    718869660 525695655

    611948363 86215482

    831696632 451913864

    507336886 615008389

    274555361 980027280

    445111193 87790742

    451913864 56172121

    309467897 808623872

    486270921 226543047

    831696632 451913864

    56890051 831696632

    639793930 181963137

    766959001 416586784

    698479963 391957985

    952789397 142779469

    507067818 76731002

    771097814 809043720

    56890051 507067818

    367840959 947130171

    56890051 76731002

    507336886 56172121

    507327697 988331486

    34798966 67233364

    507336886 507336886

    855293372 864250034

    451913864 76731002

    507067818 507067818

    73750713 972379732

    670116400 828958973

    855293372 56890051

    272791300 905306209

    831696632 76731002

    78927007 602453299

    386644769 973723585

    529459882 398034046

    839176288 649960685

    948823530 372013379

    85613955 974654491

    56890051 507067818

    56172121 76731002

    507336886 451913864

    507336886 615008389

    831696632 864250034

    860777366 975374128

    883682166 37747493

    842530005 563618035

    864250034 507336886

    855293372 76731002

    310407851 310407851

    76731002 76731002

    628256963 771501375

    56172121 864250034

    56890051 507336886

    319587773 347425295

    855293372 615008389

    855293372 864250034

    855293372 507067818

    451913864 274673668


            */






            //  var cc = sol.caesarCipher("middle-Outz", 2);

            //   sol.minimumBribes3(new List<int>() { 1, 2, 5, 3, 4, 7, 8, 6 });

            // var gc = sol.gridChallenge3(new List<string>() { "ebacd", "fghij", "olmkn", "trpqs", "xywuv" });


            // var nsr = sol.nearlySimilarRectangles(new List<List<long>> { new List<long> { 2, 1 }, new List<long> { 4, 2 }, new List<long> { 10, 7 }, new List<long> { 9, 5 }, new List<long> {6, 9 }, new List<long> { 7, 3 } });

            //var tt = sol.truckTour2(new List<List<int>> { new List<int> { 1, 5 }, new List<int> { 10, 3 }, new List<int> { 3, 4 } });


            //var l = new SinglyLinkedListNode(1);
            //l.next = new SinglyLinkedListNode(2);
            //l.next.next = new SinglyLinkedListNode(3);


            //var l2 = new SinglyLinkedListNode(3);
            //l2.next = new SinglyLinkedListNode(4);
            //var ml = sol.mergeLists2(l, l2);



            //var l = new SinglyLinkedListNode(8);
            //l.next = new SinglyLinkedListNode(11);
            //l.next.next = new SinglyLinkedListNode(17);
            //l.next.next.next = new SinglyLinkedListNode(20);
            //l.next.next.next.next = new SinglyLinkedListNode(20);
            //l.next.next.next.next.next = new SinglyLinkedListNode(42);
            //l.next.next.next.next.next.next = new SinglyLinkedListNode(83);
            //l.next.next.next.next.next.next.next = new SinglyLinkedListNode(94);
            //l.next.next.next.next.next.next.next.next = new SinglyLinkedListNode(95);


            //var l2 = new SinglyLinkedListNode(1);
            //var ml = sol.mergeLists2(l, l2);

            // var p = sol.pairshash(2, new List<int>() { 1, 5, 3, 4, 2 });

            //sol.noPrefix(new List<string> { "aab", "defgab", "abcde", "aabcde", "bbbbbbbbbb", "jabjjjad" });


            //sol.noPrefix(new List<string> { "aab", "aac", "aacghgh", "aabghgh" });

            //var mq = sol.maximumQuality(new List<int> { 2, 2, 1, 5, 3 }, 2);

            // var mq = sol.maximumQuality(new List<int> {89, 48, 14}, 3);

            //var ftp = sol.findTotalPower2(new List<int> { 2, 3, 2, 1 });


            //var ftp2 = sol.findTotalPower2(new List<int> { 2, 1, 3});

            //var ftp3 = sol.findTotalPower2(new List<int> { 2, 4 });



            // var bsf2 = sol.bfs2(4, 2, new List<List<int>>() { new List<int>() { 1,2}, new List<int>() { 1, 3 } }, 1);
            //var ib = sol.isBalanced2("}][}}(}][))]");
            //var ib2 = sol.isBalanced2("[](){()}");
            //var ib3 = sol.isBalanced2("()");
            //var ib4 = sol.isBalanced2("({}([][]))[]()");
            //var ib5 = sol.isBalanced2("{)[](}]}]}))}(())(");
            //var ib6 = sol.isBalanced2("([[))");

            //var ib7 = sol.isBalanced2("[([{{}}]{[[][][([[]]){[]}{}]]}[]{{}}{})[[]]]{{}}(()[[[[[(){}[]]({}{[]})[][[][]]]]{}]{[{}]{[{[][](()({{()}}){([]({({{[]}([([()]{()[[([({{{[]{(){}}[][]({{[([])()](())([{[]([()]{})}]){}([]){()}{}[]([[()]])}()})[{}]}()}(())}){{}()}[]]{{}})]][[]({{[{}]}})({{}({{[]{()}([][{[()]}]{})}()})}{{}}{})]()(){}}(()({()}[([](){[]()}[])])[])[])][{[{[]}]{}([])}]()(()))}){([{}])}[(([]){[]{}})]{}({}{})}){}({{}([][](){{[][{()([[{}()]]{()}{{}{[()]}})[()[]{}](){[{}()[]][{{}}{[{}][]()}[]](())[[][]][]()}}[({}([[{([]){}}]()([()(){}]){([()]())}](()))(()))]]{}()[][{[{}(([]){([()]{()()}([{}][[[]{[[(({([([]){()[]}]){(())}[]}))][((([]{})[{}[[()]({({[()[]]{}(()[{}[][[{}][][]({()}[{([])}][])]][]{})([])}){}{((){})}}){[]}[]()(()(()))(()[{{}}]){}({{{((()([](()[][]{}){({})}{(([{({{}})}]))})))}}})]]))]]}]]))})]}]}})}))})}]}}])");

            //3
            //    2147483647
            // var fb = sol.flippingBits(1);


            //var sm = sol.sockMerchant(9, new List<int> { 10, 20, 20, 10, 10, 30, 50, 10, 20 });

            // var zz = sol.findZigZagSequence2(new int[] { 2, 3, 5, 1, 4 });
            // var fm = sol.flippingMatrix2(new List<List<int>>() { new List<int>() { 112, 42, 83, 119 }, new List<int> { 56, 125, 56, 49 }, new List<int> { 15, 78, 101, 43 }, new List<int> { 62, 98, 114, 108 } });
            //var cc = sol.caesarCipher2("middle-Outz", 2);

            //  var cc = sol.caesarCipher2("Hello_World!", 4);


            //  var m = sol.maxMin(3, new List<int>() { 10, 100, 300, 200, 1000, 20, 30 });


            // var da = sol.dynamicArray(2, new List<List<int>> { new List<int> { 1, 0, 5 }, new List<int> { 1, 1, 7 }, new List<int> { 1, 0, 3 }, new List<int> { 2, 1, 0 }, new List<int> { 2, 1, 1 } });
            //    var records4 = new string[][]{
            //    new []{"Raj", "enter"},
            //    new []{"Paul", "enter"},
            //    new []{"Paul", "exit"},
            //    new []{"Paul", "exit"},
            //    new []{"Paul", "enter"},
            //    new []{"Raj", "enter"},
            //};

            //    var sl = sol.SecurityLog(records4);



            //            ppp

            //ypp

            //wyw

            //5

            //lyivr

            //jgfew

            //uweor

            //qxwyr

            //uikjd

            //1

            //l



            // var sd = sol.superDigit3("148", 3);

            // var sd = sol.superDigit3("593", 10);
            //           string[][] queries =

            //               ["ADD", "0"],
            //["ADD", "1"],
            //["ADD", "1"],
            //["ADD", "11"],
            //["ADD", "22"],
            //["ADD", "3"],
            //["ADD", "5"],
            //["GET_NEXT", "0"],
            //["GET_NEXT", "1"],
            //["REMOVE", "1"],
            //["GET_NEXT", "1"],
            //["ADD", "0"],
            //["ADD", "1"],
            //["ADD", "2"],
            //["ADD", "1"],
            //["GET_NEXT", "1"],
            //["GET_NEXT", "2"],
            //["GET_NEXT", "3"],
            //["GET_NEXT", "5"]]



            //           var queries = new string[][] { new string[] {"SET", "employee1", "city", "Annapolis" },
            //           new string[] {"SET","employee2","id","0123" },
            //           new string[] {"GET","employee1","city" }
            //           };



            //           var queries2 = new string[][] { new string[] { "SET_AT","foo","bar","baz","160000000","50" },
            //new string[] {"GET_AT","foo","bar","160000020" },
            //new string[] { "GET_AT","foo","bar","160000030"},
            //new string[] { "GET_AT", "foo", "bar", "160000050"},
            //new string[] { "GET_AT","foo","bar","160000080"} };


            //           var queries3 = new string[][] { new string[] {  "SET_AT","foo","bar","baz","160000100","0" },
            //new string[] {"SET_AT", "key", "key", "value", "160000170", "680" },
            //new string[] {"GET_AT","foo","bar","160000400"},
            //new string[] {"SCAN_AT","key","k","160000700" },
            //new string[] {"DELETE_AT","foo","bar","160000800" } }; 





            //var s = sol.solution2(queries3);


            //var sp = sol.solution6(new int[] { 1, 3, 2 }, new string[] { "REQUEST", "REQUEST", "REQUEST", "FAIL 1", "REQUEST", "REQUEST", "REQUEST", "REQUEST"});

            // var sta = sol.solution7(new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, new string[] { "L", "L", "C0", "L", "C3" });

            // var tt = sol.truckTour3(new List<List<int>>() { new List<int>() { 8, 6 }, new List<int>() { 5, 5 }, new List<int>() { 5, 6 } });

            //sol.testqueue();
            //   var ops = new List<List<string>>() {new List<string>(){"1", "abc" }, new List<string>(){"3", "3" }, new List<string>(){"2", "3" }, new List<string>(){"1", "xy" }, new List<string>(){"3", "2" }, new List<string>(){"4" },
            //       new List<string>(){"4"}, new List<string>(){"3", "1" } };

            //   sol.testeditor(ops);


            //sol.cookies(7, new List<int>() {1,2,3,9,10,12 });

            // var bfs = sol.bfs3(5, 3, new List<List<int>>() { new List<int>() { 1, 2 }, new List<int>() { 1, 3 }, new List<int>() { 3, 4 } }, 1);
            //var hn = new HuffNode();
            //hn.frequency = 5;
            //hn.data = null;

            //hn.left = new HuffNode();
            //hn.left.frequency = 2   ;
            //hn.left.data = null;

            //hn.right = new HuffNode();
            //hn.right.frequency = 3;
            //hn.right.data = 'A';

            //hn.left.left = new HuffNode();
            //hn.left.left.frequency = 1;
            //hn.left.left.data = 'B';

            //hn.left.right = new HuffNode();
            //hn.left.right.frequency = 1;
            //hn.left.right.data = 'C';

            //sol.decodeHuff("1001011", hn);

            //var words = new List<string> { "aab", "defgab", "abcde", "aabcde", "bbbbbbbbbb", "jabjjjad" };


            //var words = new List<string> { "aab", "aac", "aacghgh", "aabghgh"};

            //sol.noPrefix2(words);
            //   sol.findMinimumNumberOfPages(new List<int>() { 2, 3, 4, 5 }, 5);

            //    sol.countkSpikes(new List<int>() { 1, 2, 8, 5, 3, 4 }, 2);
            //var twos = sol.TwoSum5(new int[]{3,2,4}, 6);
            //var twos = sol.TwoSum5(new int[] { 3, 3 }, 6);

            //var root = new TreeNode(1);
            //root.right = new TreeNode(2);
            //root.right.right = new TreeNode(5);
            //root.right.right.left = new TreeNode(3);
            //root.right.right.right = new TreeNode(6);
            //root.right.right.left.right = new TreeNode(4);
            //sol.preOrder2(root);



            //var queries = new string[][] { new string[] {"SCAN","employee" },
            //                                new string[] { "SET","employee","city","Annapolis" },
            //                new string[] {"SET","employee","id","0123" },
            //                new string[] {"SCAN","employee"} };



            //  var queries = new string[][] { new string[]{"SET_AT_WITH_TTL","foo","bar","baz","160000000","100" },
            //   new string[]{"SCAN_AT","foo","160000025" } };



            //            sol.solution(queries);

            //  var m = sol.getMaxAdditionalDinersCount(15, 2, 3, new long[] { 11, 6, 14 });


            //var m = sol.getMaxAdditionalDinersCount(10, 2, 3, new long[] { 2, 6, 7 });

            //            var g = sol.getArtisticPhotographCount(5, "APABA", 1, 2);

            //  var g = sol.getArtisticPhotographCount(8, ".PBAAP.B", 1, 3);

            // var m = sol.getMinCodeEntryTime(10, 4, new int[] { 9, 4, 4, 9 });

            //var mddc = sol.getMinimumDeflatedDiscCount1(5, new int[] { 2, 5, 3, 6, 5 });

            // var gM = sol.getMaxExpectedProfit(5, new int[] { 10, 2, 8, 6, 4 }, 3, .15);


            //var G = new char[,] { { '.', 'E', '.' }, { '.', '#', 'E' }, { '.', 'S', '#' } };
            //var gsr = sol.getSecondsRequired(3, 3, G );



            //  var G = new char[,] { { 'a', 'S', '.', 'b' }, { '#', '#', '#', '#' }, { 'E', 'b', '.', 'a' } };
            //  var gsr = sol.getSecondsRequired(3, 4, G);



            //  var G = new char[,] { { 'x', 'S', '.', '.', 'x', '.', '.', 'E', 'x' } };
            //var gsr = sol.getSecondsRequired(1, 9, G);

            //var gmv = sol.getMaxVisitableWebpages(4, new int[] { 4, 1, 2, 1 });

            // var m = sol.getMinCodeEntryTime(10, 4, new int[] { 9, 4, 4, 8 });

            //   var cs = sol.ClimbStairsKstepsSpaceOptimizedRedStairs(5, 2 , new bool[] {true, false, true, true, false});

            // var csp = sol.ClimbStairsPaid(3, new int[] { 0, 3, 2, 4});


            //  var mpp = sol.MostProfitablePath(new int[,] { { 0, 3, 2, 4 },
            //                                                { 1, 99, 100, 200 },
            //                                                { 1, 1, 1, 2 },
            //                                                { 2, 3, 4, 5 }});


            // var ts = sol.TwoSum7(new int[] { 2,3, 3, 7, 11, 15 }, 6);



            //var root = new TreeNode(1);
            //root.left = new TreeNode(3);
            //root.right = new TreeNode(2);
            //root.left.left = new TreeNode(5);
            //root.left.right = new TreeNode(3);
            //root.right.right = new TreeNode(9);
            //var it = sol.InorderTraversal(root);


            //  var ts = sol.twosum(new int[] { 2, 7, 11, 15 }, 9);


            //sol.MultiMapTest();

            //  var se = sol.getSecondsElapsed(10, 2, new long[] { 1, 6 }, new long[] { 3, 7 }, 7);


            // var mdd = sol.getMaxDamageDealtbetter(4, new int[] { 1, 1, 2, 100 }, new int[] { 1, 2, 1, 3 }, 8);

            //var sums = sol.runningsum(new int[] { 2, 2, 2 }, 4);
            //Console.WriteLine(sums);

            //var sums2 = sol.runningsum(new int[] { 3, 2, 1 }, 3);
            //Console.WriteLine(sums2);

            //var sums3 = sol.runningsum(new int[] { 2, 2, -4, 1, 1, 2 }, -3);
            //Console.WriteLine(sums3);

            //var root = new Solution.MultipleChildrenNode();
            //root.id = 1;
            //root.children = new List<Solution.MultipleChildrenNode>() {
            //new Solution.MultipleChildrenNode(){ id = 2, children = new List<Solution.MultipleChildrenNode>() { new Solution.MultipleChildrenNode() { id = 4 }, new Solution.MultipleChildrenNode() { id = 5 } } }, new Solution.MultipleChildrenNode(){ id = 3 }
            //};
            //sol.assignUniqueIds(root);

            //Solution.LLNode root = new Solution.LLNode() { val = 5, next = new Solution.LLNode { val = 4, next = new Solution.LLNode { val =3, next = new Solution.LLNode { val = 2, next = new Solution.LLNode { val = 1, next = null } } } } };
            //sol.printllreverse(root);

            // var fs = new Solution.FileSystem();


            //var vfw = sol.ValidWordAbbreviation("internationalization", "i12iz4n");




            //var root = new TreeNode(3);
            //root.left = new TreeNode(5);
            //root.right = new TreeNode(1);
            //root.left.left = new TreeNode(6);
            //root.left.right = new TreeNode(2);
            //root.right.left = new TreeNode(0);
            //root.right.right = new TreeNode(8);
            //root.left.right.left = new TreeNode(7);
            //root.left.right.right = new TreeNode(4);
            //var lc = sol.LowestCommonAncestor2(root, root.left, root.left.right.right);




            //   var ts = sol.ThreeSum4(new int[] { -1, 0, 1, 2, -1, -4 });

            //  var ts = sol.ThreeSum4(new int[] { 3, 0, -2, -1, 1, 2});

            //var fw = sol.findWord(new string[] { "P>E", "E>R", "R>U" }); //PERU
            //findWord(["P>E", "E>R", "R>U"]) // PERU
            //findWord(["I>N", "A>I", "P>A", "S>P"]) // SPAIN)


            //var vp = sol.ValidPalindrome3("aguokepatgbnvfqmgmlcupuufxoohdfpgjdmysgvhmvffcnqxjjxqncffvmhvgsymdjgpfdhooxfuupuculmgmqfvnbgtapekouga");


            //  var vp = sol.ValidPalindrome3("ebcbbececabbacecbbcbe");
            //var bc = sol.Calculate("3+2*2");
            //var bc = sol.Calculate("2*3-4");

            //  var bc = sol.Calculate("42");
            //Output: 7

            // var kl = sol.FindKthLargest(new int[] { 3, 2, 1, 5, 6, 4 }, 2);
            //  var kl = sol.FindKthLargest(new int[] { 3, 2, 3, 1, 2, 4, 5, 5, 6 }, 4);


            //sol.Merge2(new int[] { 2, 0 }, 1, new int[] { 1 }, 1);

            //  sol.Merge2(new int[] { 4, 5, 6, 0, 0, 0 }, 3, new int[] { 1, 2, 3 }, 3);

            //var lls = sol.LengthOfLongestSubstringTwoDistinct("eceba");
            //   var lls = sol.LengthOfLongestSubstringTwoDistinct("ccaabbb");

            //var fs = new Solution.FileSystem();

            //fs.mkdir("abc/def");
            //fs.mkdir("abc/def/ghi");
            //fs.mkdir("abc/def/jkl");

            //fs.addContentToFile("abc/def/file.txt", "contentsoffile!!!!");
            //var dirs = fs.ls("abc/def");
            //fs.addContentToFile("abc/def/file.txt", "morestuff");

            //var file = fs.readContentFromFile("abc/def/file.txt");


            // var queries = new string[][] { new string[] { "GET", "dept4", "floors" }, new string[] { "SET_OR_INC", "dept4", "floors", "10" }, new string[] { "SET_OR_INC", "dept4", "floors", "4" }, new string[] {"TOP_N_KEYS", "1"}};
            // var re = sol.solution(queries);



            //var r = sol.solution6(new string[] { "notion:180", "voyage:185", "sample:180" }, new string[] { "circles:360", "squares:180", "lines:37" });


            //var m = sol.Merge2(new int[][] { new int[] { 1, 3 }, new int[] { 2, 6 }, new int[] { 8, 10 }, new int[] { 15, 18 } });

            //  var m = sol.Merge2(new int[][] { new int[] { 2, 3 }, new int[] { 4, 5 }, new int[] { 6, 7 }, new int[] { 8, 9 }, new int[] { 1, 10} });

            //Created a new class (Solution2). now loads faster, as loading solution slowed right down with too many methods in it.
            var sol2 = new Solution2();

            //var lvs = sol2.LongestValidSubstring("leetcode", new List<string> { "de", "le", "e" });

            //var pbc = sol2.PlatesBetweenCandles("**|**|***|", new int[][] { new int[] { 2, 5 }, new int[] { 5, 9 } });

            //  var pbc = sol2.PlatesBetweenCandles("***|**|*****|**||**|*", new int[][] { new int[] { 1, 17 }, new int[] { 4, 5 }, new int[] { 14, 17 }, new int[] { 5, 11 }, new int[] { 15, 16 } });
            //sol2.miniMaxSum(new List<int> { 256741038, 623958417, 467905213, 714532089, 938071625 });
            // sol2.miniMaxSum(new List<int> { 1, 2, 3, 4, 5 });


            //var l = new SinglyLinkedListNode(1);
            //l.next = new SinglyLinkedListNode(3);
            //l.next.next = new SinglyLinkedListNode(7);


            //var l2 = new SinglyLinkedListNode(1);
            //l2.next = new SinglyLinkedListNode(2);

            //var ml = sol2.mergeLists(l, l2);

            //var rb = sol2.maxSetSize(new List<int> { 5, 625, 4, 2, 5, 25 });
            //var rb = sol2.maxSetSize(new List<int> { 2, 3, 4, 9, 16 });

            var ls = sol2.findReviewScore("FastDeliveryOkayProduct", new List<string> { "eryoka", "yo", "eli" });

        }

    }
    class Solution
    {




        public int[][] Merge2(int[][] intervals)
        {
            var len = intervals.Length;
            Array.Sort(intervals, (a, b) => a[0] - b[0]);
            var results = new List<int[]>();
            results.Add(intervals[0]);
            for (var i = 1; i < len; i++)
            {
                var rlast = results.Count - 1;
                if (results[rlast][1] >= intervals[i][0])
                    results[rlast][1] = Math.Max(results[rlast][1], intervals[i][1]);
                else
                    results.Add(intervals[i]);

            }

            return results.ToArray();
        }




        //Crossover  4 Feb 2024 - passed with 40% passing rate, LOL, this function was almost working though:
        public int[] solution7(int[] memory, int[][] queries)
        {


            var results = new List<int>();
            var allocated = new List<Tuple<int, int>>();
            for (var i = 0; i < queries.Length; i++)
            {
                if (queries[i][0] == 0)
                {
                    var alloc = queries[i][1];
                    for (var j = 0; j < memory.Length; j += 8)
                    {

                        if (memory[j] == 0)
                        {
                            var iszero = true;
                            for (var k = j + 1; k < j + alloc; k++)
                            {
                                if (memory[k] == 1)
                                {
                                    iszero = false;
                                    break;
                                }


                            }
                            if (iszero)
                            {
                                for (var k = j + 1; k < j + alloc; k++)
                                {
                                    memory[k] = 1;


                                }
                                allocated.Add(new Tuple<int, int>(j, j + alloc));
                                results.Add(j);


                            }
                            else
                                results.Add(-1);


                        }
                    }
                }
                else
                {
                    var eraseindex = queries[i][1];
                    if (allocated.Count >= eraseindex)
                    {
                        var allocstart = allocated[eraseindex - 1].Item1;
                        var allocend = allocated[eraseindex - 1].Item2;
                        var result = allocend - allocstart;
                        for (var l = allocstart; l < allocend; l++)
                        {
                            if (memory[l] == 0)
                            {
                                result = -1;
                                break;
                            }

                            else
                                memory[l] = 0;


                        }
                        results.Add(result);

                    }
                    else
                    {

                        results.Add(-1);
                    }
                }

            }
            return results.ToArray();
        }











        public string[] solution6(string[] songs, string[] animations)
        {


            var output = new List<string>();
            for (var i = 0; i < songs.Length; i++)
            {
                for (var j = 0; j < animations.Length; j++)
                {
                    var songi = songs[i].IndexOf(":");
                    var song = Convert.ToInt32(songs[i].Substring(songi + 1));

                    var animi = animations[j].IndexOf(":");
                    var anim = Convert.ToInt32(animations[j].Substring(animi + 1));

                    if (song % anim == 0)
                    {
                        // Console.WriteLine()
                        var times = song / anim;
                        output.Add(animations[j].Substring(0, animi) + ":" + times);
                        break;
                    }
                }

            }

            return output.ToArray();

        }



        //string solution(int[] numbers, int pivot)
        //{
        //    var a = ":123";

        //    var b = a.Substring()
        //    var sumright = 0;
        //    var sumleft = 0;

        //    for (var i = 0; i < numbers.Length; i++)
        //    {
        //        if (numbers[i] > pivot)
        //            sumright++;
        //        else if (numbers[i] < pivot)
        //            sumleft++;



        //    }

        //    if (sumright > sumleft)
        //        return "greater";
        //    else if (sumright < sumleft)
        //        return "smaller";
        //    else
        //        return "tie";



        //}



        //Crossover 3 Feb 2024  passed 50%
        //ran out of time.  copied and pasted this from older assessment, full of bugs



        public string[] solution(string[][] queries)
        {



            var output = new List<string>();
            var container = new Dictionary<string, Dictionary<string, Field>>();


            foreach (var q in queries)
            {


                if (q[0] == "SET_OR_INC")
                {


                    if (!container.ContainsKey(q[1]))
                    {
                        container.Add(q[1], new Dictionary<string, Field>() { { q[2], new Field() { value = Convert.ToInt32(q[3]), mods = 1 } } });
                    }
                    else
                    {

                        if (container[q[1]].ContainsKey(q[2]))
                        {
                            container[q[1]][q[2]].value += Convert.ToInt32(q[3]);
                            container[q[1]][q[2]].mods++;
                        }
                        else
                        {
                            container[q[1]].Add(q[2], new Field() { value = Convert.ToInt32(q[3]), mods = 1 });
                        }
                    }
                    output.Add(container[q[1]][q[2]].value.ToString());
                }

                if (q[0] == "GET")
                {
                    if (container.ContainsKey(q[1]) && container[q[1]].ContainsKey(q[2]))
                    {
                        output.Add(container[q[1]][q[2]].value.ToString());
                    }
                    else
                    {
                        output.Add("");
                    }

                }
                else if (q[0] == "DELETE")
                {

                    if (container.ContainsKey(q[1]) && container[q[1]].ContainsKey(q[2]))
                    {
                        container[q[1]].Remove(q[2]);
                        // container[q[1]][q[2]].mods++;
                        output.Add("true");
                    }
                    else
                        output.Add("false");
                }


                else if (q[0] == "TOP_N_KEYS")
                {
                    var mods = new List<Tuple<int, string>>();
                    foreach (var k in container)
                    {
                        var m = k.Value.Values.Select(v => v.mods).Sum();
                        var k1 = k.Key + "(" + m + ")";
                        mods.Add(new Tuple<int, string>(m, k1));
                    }
                    var o = mods.OrderByDescending(m => m.Item1).Select(m => m.Item2).Take(Convert.ToInt32(q[1])).ToList();
                    output.Add(String.Join(' ', o));
                }

            }

            return output.ToArray();

        }





        class Field
        {

            public int value { get; set; }
            public int timestamp { get; set; }
            public int ttl { get; set; }
            public int mods { get; set; }
        }





















        //public string[] solution(string[][] queries)
        //{



        //    var output = new List<string>();
        //    var container = new Dictionary<string, Dictionary<string, Field>>();


        //    foreach (var q in queries)
        //    {


        //        if (q[0] == "SET_OR_INC")
        //        {


        //            if (!container.ContainsKey(q[1]))
        //            {
        //                container.Add(q[1], new Dictionary<string, Field>() { { q[2], new Field() { value = Convert.ToInt32(q[3]), mods = 1 } } });
        //            }
        //            else
        //            {

        //                if (container[q[1]].ContainsKey(q[2]))
        //                {
        //                    container[q[1]][q[2]].value += Convert.ToInt32(q[3]);
        //                    container[q[1]][q[2]].mods++;
        //                }
        //                else
        //                {
        //                    container[q[1]].Add(q[2], new Field() { value = Convert.ToInt32(q[3]), mods = 1 });
        //                }
        //            }
        //            output.Add(container[q[1]][q[2]].value.ToString());
        //        }

        //        if (q[0] == "GET")
        //        {
        //            if (container.ContainsKey(q[1]) && container[q[1]].ContainsKey(q[2]))
        //            {
        //                output.Add(container[q[1]][q[2]].value.ToString());
        //            }
        //            else
        //            {
        //                output.Add("");
        //            }

        //        }
        //        else if (q[0] == "DELETE")
        //        {

        //            if (container.ContainsKey(q[1]) && container[q[1]].ContainsKey(q[2]))
        //            {
        //                container[q[1]].Remove(q[2]);
        //                output.Add("true");
        //            }
        //            else
        //                output.Add("false");
        //        }


        //        else if (q[0] == "TOP_N_KEYS")
        //        {
        //            var mods = new List<Tuple<int, string>>();
        //            foreach (var k in container)
        //            {
        //                var m = k.Value.Values.Select(v => v.mods).Sum();
        //                var k1 = k.Key + "(" + m + ")";
        //                mods.Add(new Tuple<int, string>(m, k1));
        //            }
        //            var o = mods.OrderByDescending(m => m.Item1).Select(m => m.Item2).ToList();
        //            output.Add(String.Join(' ', o));
        //        }

        //    }

        //    return output.ToArray();

        //}





        //class Field
        //{

        //    public int value { get; set; }
        //    public int timestamp { get; set; }
        //    public int ttl { get; set; }
        //    public int mods { get; set; }
        //}















        //Facebook phone screen:
        // 1) merge as per below
        // 2) three way merge but merge two sorted lists of lists like the following:
        // A=  [1,2], [3, 9], 
        // B=   [4, 6], [8,10],  [11,12]
        //Write this one above .  you had the first 2 use cases, but bombed the last 2 use cases!!!!!!!!!


        public void MergeFBPhone(int[] nums1, int m, int[] nums2, int n)
        {


            var a = m - 1;
            var b = n - 1;
            var c = m + n - 1;
            while (a >= 0 && b >= 0)
            {

                if (nums2[b] > nums1[a])
                {
                    Console.WriteLine("2");
                    nums1[c] = nums2[b];
                    c--;
                    b--;
                }
                else
                {
                    nums1[c] = nums1[a];
                    c--;
                    a--;
                }

            }

            while (b >= 0)
            {
                nums1[c] = nums2[b];
                b--;
                c--;
            }



        }





        //Interviewing.IO Mock interview:
        //implement a file system using Trie.
        // as your implementation below is not good, you just used
        // a dictionary and not complete.

        public class FileSystem
        {

         

            public FileSystem()
            {
               
                root = new Node("/");
            }

            /** Inserts a word into the trie. */
            //public void Insert(string word)
            //{
            //    var node = root;
            //    for (var i = 0; i < word.Length; i++)
            //    {
            //        if (node.children[word[i] - 'a'] == null)
            //            node.children[word[i] - 'a'] = new Node();

            //        node = node.children[word[i] - 'a'];
            //    }
            //    node.isfile = true;
            //}


            public void mkdir(String path)
            {
                var node = root;

                var splits = path.Split('/');
              
                foreach (var split in splits)
                {
                    var next = node.children.Where(c => c.path == split).FirstOrDefault();
                    if (next == null)
                    {
                        node.children.Add(new Node(split));
                        next = node.children[0];
                    }
                   
                    node = next;
                }
            }


            //inputs:    abc/def/ghuj/sdfsdf.txt
            //           abc/def/
            public List<string> ls(string path)
            {
                var node = root;

                var splits = path.Split('/');

                foreach (var split in splits)
                {
                    var next = node.children.Where(c => c.path == split).FirstOrDefault();
                    if (next != null)
                        node = next;
                }
                
                var results = node.children.Select(c => c.path).ToList();
                return results;

            }



            //* If filePath does not exist, creates that file containing given content.
            //* If filePath already exists, appends the given content to original content.
            public void addContentToFile(string path, string content)
            {
                var node = root;
                var splits = path.Split('/');

                foreach (var split in splits)
                {
                    var next = node.children.Where(c => c.path == split).FirstOrDefault();
                    if (next == null)
                    {
                        node.children.Add(new Node(split));
                        next = node.children[node.children.Count-1];
                    }

                    node = next;
                }

                node.isfile = true;
                node.content += content;

                //abc / def/File.txt"



            }




            public string readContentFromFile(string path)
            {
                var node = root;
                var splits = path.Split('/');
                foreach (var split in splits)
                {
                    var next = node.children.Where(c => c.path == split).FirstOrDefault();
                    if (next != null)
                        node = next;
                }

                return node.content; // children.Select(c => c.path).ToList();
                


            }





            /** Returns if the word is in the trie. */
            //public bool Search(string word)
            //    {
            //        var node = FindWord(word);
            //        if (node != null && node.isfile)
            //            return true;
            //        else
            //            return false;
            //    }

            //    /** Returns if there is any word in the trie that starts with the given prefix. */
            //    public bool StartsWith(string prefix)
            //    {
            //        return FindWord(prefix) != null;
            //    }

            //    private Node FindWord(string word)
            //    {
            //        var node = root;
            //        for (var i = 0; i < word.Length; i++)
            //        {
            //            if (node.children[word[i] - 'a'] == null)
            //                return null;
            //            node = node.children[word[i] - 'a'];

            //        }
            //        return node;
            //    }


            private Node root;

            public class Node
            {
                public Node(string path)
                {
                    this.path = path;
                    isfile = false;
                    children = new List<Node>();
                }
                //char c;
                public string path;  //   / for root?
                public bool isfile;
                public string content;
                public List<Node> children;
            }
        }

     


    public int LengthOfLongestSubstringTwoDistinct(string s)
        {
            var len = s.Length;
            if (len < 3)
                return len;
            var left = 0;
            var right = 1;
            var dict = new Dictionary<char, int>();
            dict[s[left]] = 1;
            if (!dict.ContainsKey(s[right]))
                dict[s[right]] = 1;
            else
                dict[s[right]]++;
            right = 2;
            var max = 0;
            var count = 3;
            while (right < len)
            {
                if (!dict.ContainsKey(s[right]))
                    dict[s[right]] = 1;
                else
                    dict[s[right]]++;

       
                if (dict.Keys.Count < 3)
                {
                  
                    max = Math.Max(max, count);
                }
                else
                {
       
                    while (dict.Keys.Count > 2)
                    {
                        var v = 0;
                        if (dict.TryGetValue(s[left], out v))
                        {
                            if (v == 1)

                          // var del_idx = Collection.m  //Collections.min(dict.Values);
                            //dict.Remove(s.charAt(del_idx));


                            dict.Remove(s[left]);
                            else
                                dict[s[left]]--;
                            left++;
                            count--;
                        }
                    }
                }
                right++;
                count++;
            }
            return max;
        }







        //Leetcode 88. Merge Sorted Array

        public void Merge2(int[] nums1, int m, int[] nums2, int n)
        {
            if (n == 0)
                return;
            if (m == 0)
            {
                for (var i = 0; i < n; i++)
                    nums1[i] = nums2[i];
                return;
            }
           
            var a = m - 1;
            var b = n - 1;
            var c = m + n - 1;
            while (a >= 0 && b >= 0)
            {
              
                if (nums2[b] > nums1[a])
                {
                    Console.WriteLine("2");
                    nums1[c] = nums2[b];
                    c--;
                    b--;
                }
                else
                {
              
                    nums1[c] = nums1[a];
                    nums1[a] = nums2[b];
                    c--;
                    a--;
                }

                Console.WriteLine("c = " + c + " A = " + a + " B=" + b);

            }

            while (b >= 0)
            {
                nums1[c] = nums2[b];
                b--;
                c--;
            }


        }



        //Leetcode 129. Sum Root to Leaf Numbers

        public int SumNumbers(TreeNode root)
        {

            var nums = new List<int>();
            //Traverse(root, new StringBuilder(), nums);  //stringbuilder was O(n) space to store current number
            Traverse(root, 0, nums);    //int is O(1) much better, and faster too.
            return nums.Sum();
        }

        //private void Traverse(TreeNode node, StringBuilder sb, List<int> nums)
        private void Traverse(TreeNode node, int sofar, List<int> nums)
        {
            if (node == null)
                return;

            //StringBuilder sbclone = new StringBuilder(sb.ToString());
            //sbclone.Append(node.val);
            sofar = sofar * 10 + node.val;
            if (node.left == null && node.right == null)
            {
                //nums.Add(Convert.ToInt32(sbclone.ToString()));
                nums.Add(sofar);
            }
            else
            {
                //Traverse(node.left, sbclone, nums);
                //Traverse(node.right, sbclone, nums);

                Traverse(node.left, sofar, nums);
                Traverse(node.right, sofar, nums);

            }
        }



        //LeetCode 215 Kth Largest Element in array
        //PAsses 37/41
        //Implement quick select to fix this
        //You are NOT allowed to sort!!!!!!
        public int FindKthLargest(int[] nums, int k)
        {
            var largest = new int[k];
            for (var i = 0; i < k; i++)
                largest[i] = -10001;

            for (var i = 0; i < nums.Length; i++)
            {
                for (var j = 0; j < largest.Length; j++)
                {
                    if (nums[i] >= largest[j])
                    {
                     
                        var temp = largest[j];
                     
                        largest[j] = nums[i];
                     
                        for (var l = largest.Length - 1; l > j + 1; l--)
                        {
                        
                            largest[l] = largest[l - 1];
                       
                        }
                        if (j + 1 < k)
                            largest[j + 1] = temp;
                     
                        break;
                    }
                }
            }


            return largest[k - 1];
        }

        public class MyStack
        {

            Queue<int> queue;
            public MyStack()
            {
                queue = new Queue<int>();
            }

            public void Push(int x)
            {
                queue.Enqueue(x);
            }

            public int Pop()
            {
                var q2 = new Queue<int>();
                while (queue.Count > 1)
                {
                    q2.Enqueue(queue.Dequeue());
                }
                var returnval = queue.Dequeue();
                while (q2.Count > 0)
                {
                    queue.Enqueue(q2.Dequeue());
                }
                return returnval;
            }

            public int Top()
            {
                var q2 = new Queue<int>();
                while (queue.Count > 1)
                {
                    q2.Enqueue(queue.Dequeue());
                }
                var returnval = queue.Dequeue();
                while (q2.Count > 0)
                {
                    queue.Enqueue(q2.Dequeue());
                }
                queue.Enqueue(returnval);
                return returnval;
            }

            public bool Empty()
            {
                return queue.Count == 0;
            }
        }








        //Leetcode 226. Invert Binary Tree

        public TreeNode InvertTree2(TreeNode root)
        {
            if (root == null)
                return null;
            var temp = root.left;
            root.left = root.right;
            root.right = temp;
            InvertTree2(root.left);
            InvertTree2(root.right);
            return root;
        }




        //Leetcode 227:   Basic calculator II
        //passed all test cases, but can be improved if you remove stack

        public int Calculate(string s)
        {


            if (String.IsNullOrEmpty(s))
                return 0;
            var len = s.Length;
            var stack = new Stack<int>();
            var currentnum = 0;
            var operation = '+';

            for (var i = 0; i < len; i++)
            {
                var currentchar = s[i];
                if (Char.IsNumber(currentchar))
                {
                    currentnum = (currentnum * 10) + (currentchar - '0');
                }
                if (!Char.IsNumber(currentchar) && currentchar != ' ' || i == len - 1)
                {
                    if (operation == '+')
                        stack.Push(currentnum);
                    else if (operation == '-')
                        stack.Push(-currentnum);
                    else if (operation == '*')
                    {
                        var popped = stack.Pop();
                        stack.Push(popped * currentnum);
                    }
                    else if (operation == '/')
                    {
                        var popped = stack.Pop();
                        stack.Push(popped / currentnum);
                    }
                    operation = currentchar;
                    currentnum = 0;

                }
            }


            var result = 0;
            while (stack.Count > 0)
            {
                result += stack.Pop();
            }


            return result;
        }


        //Leetcode 227:   Basic calculator II

        //PAssess 60/80 test cases
        public int Calculatesux(string s)
        {

            var sign = 1;
            var len = s.Length;
            var curnum = new StringBuilder();
            var subexpressions = new List<int>();
            var expressions = new List<int>();
            var operations = new List<char>();

            for (var i = 0; i < len; i++)
            {
                if (Char.IsNumber(s[i]))
                {
                  //  Console.WriteLine("1");
                    while (i < len && Char.IsNumber(s[i]))
                    {
                        curnum.Append(s[i]);
                        i++;
                    }
                    var num = Convert.ToInt32(curnum.ToString());
                    subexpressions.Add(num * sign);
                    curnum.Clear();
                    if (i == len)
                        break;
                }

                if (s[i] == '+')
                {
                    sign = 1;
                    if (operations.Count > 0)
                    {
                        Console.WriteLine("2");
                        var expression = CalculateSub(subexpressions, operations);
                        expressions.Add(expression);
                        subexpressions.Clear();
                        operations.Clear();
                    }
                    else
                    {
                        expressions.Add(subexpressions[0]);
                        subexpressions.Clear();
                    }


                }
                else if (s[i] == '-')
                {
                    sign = -1;
                    if (operations.Count > 0)
                    {
                        Console.WriteLine("3");
                        var expression = CalculateSub(subexpressions, operations);
                        expressions.Add(expression * -1);
                        subexpressions.Clear();
                        operations.Clear();
                    }
                    else
                    {
                        expressions.Add(subexpressions[0]);
                        subexpressions.Clear();
                    }

                }


                else if (s[i] == '*')
                {
                    operations.Add('*');
                    sign = 1;
                    //var expression = Calculate(subexpressions, operations);
                    //expressions.Add(expression * -1);

                }


                else if (s[i] == '/')
                {
                    operations.Add('/');
                    sign = 1;
                    //var expression = Calculate(subexpressions, operations);
                    //expressions.Add(expression * -1);

                }


            }

            Console.WriteLine("before  last if");
            if (subexpressions.Count > 0)
            {
                var expression = CalculateSub(subexpressions, operations);
                expressions.Add(expression);
            }

            return expressions.Sum();


        }

        private int CalculateSub(List<int> subexpressions, List<char> operations)
        {
            Console.WriteLine("before calculate");
            var result = subexpressions[0];
            Console.WriteLine("after calculate");

            for (var i = 1; i < subexpressions.Count; i++)
            {
                if (operations[i-1] == '*')
                    result *= subexpressions[i];
                else
                    result /= subexpressions[i];

            }

            return result;
        }




        //Leetcode 1570
        public class SparseVector
        {

            private Dictionary<int, int> dict;

            public SparseVector(int[] nums)
            {
                dict = new Dictionary<int, int>();
                for (var i = 0; i < nums.Length; i++)
                {
                    if (nums[i] != 0)
                        dict[i] = nums[i];

                }
            }

            // Return the dotProduct of two sparse vectors
            public int DotProduct(SparseVector vec)
            {
                var sum = 0;
                foreach (var i in dict.Keys)
                {
                    var v = 0;
                    if (vec.dict.TryGetValue(i, out v))
                        sum += dict[i] * v;
                }

                return sum;
            }
        }











        //PAssed all testcases.  easy to understand now!:
        //Leetcode 680 Valid palindrome
        public bool ValidPalindrome4(string s)
        {
            var len = s.Length;
            if (len == 1)
                return true;
            var left = 0;
            var right = len - 1;
            while (left < right)
            {
                if (s[left] != s[right])
                {
                    if (isSubPalindrome(s, left, right - 1) || isSubPalindrome(s, left + 1, right))
                        return true;
                    else
                    {
                        return false;
                    }
                }
                left++;
                right--;
            }
            return true;
        }


        private bool isSubPalindrome(string s, int l, int r)
        {
            while (l < r)
            {
                if (s[l] != s[r])
                    return false;
                l++;
                r--;
            }

            return true;
        }








        //Leetcode 680 Valid palindrome 2
        //passes 464/469
        //need to improve!!!

        public bool ValidPalindrome3(string s)
        {

            var count = 0;
            var len = s.Length;
            if (len == 1)
                return true;
            var left = 0;
            var right = len - 1;
            while (left < right)
            {
                // if (left == right && count == 1 && s[left-1] != s[left] && s[left] != s[right+1]  )
                //     return false;
                if (s[left] != s[right])
                {
                    if (s[right - 1] == s[left] && s[right - 2] == s[left-1] && s[right - 3] == s[left-2])
                    {
                        count++;
                        if (count > 1)
                            return false;

                        right--;
                    }
                    else if (s[left + 1] == s[right])
                    {

                        count++;
                        if (count > 1)
                            return false;
                        left++;
                    }
                   
                    else
                    {


                        return false;
                    }

                }

                left++;
                right--;


            }


            return true;

        }






        //Leetcode 1762

        public int[] FindBuildings(int[] heights)
        {
            var results = new List<int>();
            var len = heights.Length;
            var maxtoright = 0;
            for (var i = len - 1; i >= 0; i--)
            {
                if (heights[i] > maxtoright)
                    results.Add(i);
                maxtoright = Math.Max(maxtoright, heights[i]);



            }
            return results.OrderBy(r => r).ToArray();
        }

        //Leetcode 15:  3Sum  
        //Beats 96.94% !!
        public IList<IList<int>> ThreeSum6(int[] nums)
        {
            var results = new List<IList<int>>();
            Array.Sort(nums);
            var len = nums.Length;

            for (var i = 0; i < len - 2; i++)
            {
                var l = i + 1;
                var r = len - 1;
                while (l < r)
                {
                    if (nums[i] + nums[l] + nums[r] < 0)
                        l++;
                    else if (nums[i] + nums[l] + nums[r] > 0)
                        r--;
                    else
                    {
                        results.Add(new List<int>() { nums[i], nums[l], nums[r] });
                        while (r > l && nums[r] == nums[r - 1])
                            r--;
                        while (r > l && nums[l] == nums[l + 1])
                            l++;
                        l++;
                        r--;
                    }
                }
                while (i < len - 1 && nums[i] == nums[i + 1])
                    i++;

            }
            return results;
        }


        //doesn't work

        public IList<IList<int>> ThreeSum5(int[] nums)
        {

            var dict = new Dictionary<int, int>();
            Array.Sort(nums);
            IList<IList<int>> results = new List<IList<int>>();
            var len = nums.Length;
            var left = 0;
            var right = len - 1;
            var i = 1;
            while (i < len - 1)
            {
                var sum = nums[left] + nums[i] + nums[right]; 

                while (sum < 0 && left < i)
                {
                    left++;
                    if (left == i)
                    {
                        i++;
                        break;
                    }
                        
                    sum = nums[left] + nums[i] + nums[right];
                }
                while (sum > 0 && i < right)
                {
                    right--;
                    if (right == i)
                    {
                        i--;
                        break;
                    }
                        
                    sum = nums[left] + nums[i] + nums[right];
                }
                if (sum == 0)
                {
                    var list = new List<int> { nums[left], nums[i], nums[right] }.OrderBy(l => l).ToList();
                    if (!results.Any(r => r[0] == list[0] && r[1] == list[1] && r[2] == list[2]))
                        results.Add(list);
                }


                i++;
                if (i == right)
                    right++;
             }



            return results;
        }











        //First question was to read an extremely complex json file using quicktype (read quicktype)
        //TOPTAL  find string out of ordered precedence list of letters chained to gether:
        //
        //findWord(["P>E", "E>R", "R>U"]) // PERU
        //findWord(["I>N", "A>I", "P>A", "S>P"]) // SPAIN)

        public string findWord(string[] words)
        {
            var sb = new StringBuilder();


            var nodes = new List<ChrisNode2>();

            for (var i = 0; i < words.Length; i++)
            {
                var next = Array.IndexOf(words, words.Where(w => w.StartsWith(words[i][2])).FirstOrDefault());
                nodes.Add(new ChrisNode2() { precedence = 1, c = words[i][0], next = next == -1 ? nodes.Count + 1 : next });
                if (next == -1)
                {
                    nodes.Add(new ChrisNode2() { precedence = 1, c = words[i][2], next = next });
                }
            }

            var lastletter = nodes.Where(n => n.next == -1);
            var a = nodes.Where(n => n.next != -1).OrderBy(n => n.next);

            var final = new string(a.Concat(lastletter).Select(a => a.c).ToArray());

            return final;
        }



        public  class ChrisNode2
        {

            public int precedence;
            public char c;
            public int next;
        }


            public IList<IList<int>> ThreeSum4(int[] nums)
        {
            var dict = new Dictionary<int, int>();
            IList<IList<int>> results = new List<IList<int>>();

            var r2 = new Dictionary<ISet<int>, int>();
            //  var test2 =  new List<IList<IList<int>>>();
            var len = nums.Length;
            for (var i = 0; i < len- 2; i++)
            {
                for (var j = i + 1; j < len-1; j++)
                {
                    var diff = 0 - nums[i] - nums[j];
                    if (dict.ContainsKey(diff))
                    {
                        var list = new List<int>() { nums[i], nums[j], diff }.OrderBy(l => l).ToList();
                        if (!results.Any(r => r[0] == list[0] && r[1] ==  list[1] && r[2] == list[2]))
                            results.Add(list);
                    }
                    else
                        dict[nums[j]] = j;

                }
            }

         
            


            return results;
        }


        public TreeNode LowestCommonAncestor2(TreeNode root, TreeNode p, TreeNode q)
        {


            if (root == null)
                return null;
            Console.WriteLine(root.val);
            if (root.val == p.val || root.val == q.val)
                return root;
            var left = LowestCommonAncestor2(root.left, p, q);
            var right = LowestCommonAncestor2(root.right, p, q);
            if (left != null && right != null)
                return root;
            return left ?? right;



        }






        //Leetcode125
        public bool IsPalindrome3(string s)
        {
            if (s.Trim() == "")
                return true;

            var left = 0;
            var right = s.Length - 1;

            while (left < right)
            {
                while (left < right && !Char.IsLetterOrDigit(s[left]))
                    left++;
                while (left < right && !Char.IsLetterOrDigit(s[right]))
                    right--;
                if (Char.ToLower(s[left]) == Char.ToLower(s[right]))
                {
                    left++;
                    right--;
                }
                else
                    return false;

            }
            return true;


        }


        //Leetcode 339
        //public int DepthSum(IList<NestedInteger> nestedList)
        //{

        //    var sum = 0;
        //    foreach (var ni in nestedList)
        //    {
        //        sum += GetSum(ni, 1);
        //    }

        //    return sum;
        //}


        //private int GetSum(NestedInteger nestedInt, int level)
        //{

        //    var sum = 0;
        //    if (nestedInt.IsInteger())
        //        sum += nestedInt.GetInteger() * level;
        //    else
        //    {
        //        foreach (var ni in nestedInt.GetList())
        //        {
        //            sum += GetSum(ni, level + 1);
        //        }
        //    }

        //    return sum;

        //}




        public bool ValidWordAbbreviation(string word, string abbr)
        {


            if (word.Length < abbr.Length)
                return false;
            var i = 0;
            var j = 0;
            while (i < word.Length && j < abbr.Length)
            {
                if (word[i] == abbr[j])
                {
                    i++;
                    j++;
                }
                else
                {
                    if (Char.IsNumber(abbr[j]))
                    {
                        var testzero = abbr[j] - '0';
                        if (testzero == 0)
                            return false;
                        var sb = new StringBuilder();
                        sb.Append(abbr[j]);
                        j++;
                        while (j < abbr.Length && Char.IsNumber(abbr[j]))
                        {
                            sb.Append(abbr[j]);
                            j++;
                        }
                       
                        var inc = Convert.ToInt32(sb.ToString());
                        i += inc;
                       
                    }
                    else
                        return false;
                }
            }
           
            return i == word.Length && j == abbr.Length;

        }



        //Leetcode 1249
        public string MinRemoveToMakeValid2(string s)
        {
            var sb = new StringBuilder();
            var stack = new Stack<Tuple<char, int>>();
            var rl = new List<int>();

            for (var i = 0; i < s.Length; i++)
            {
                switch (s[i])
                {
                    case '(':
                        stack.Push(new Tuple<char, int>(s[i], i));
                        break;

                    case ')':
                        if (stack.Count > 0)
                        {
                            var last = stack.Peek();
                            if (last.Item1 == '(')
                                stack.Pop();
                            else
                                rl.Add(i);
                        }
                        else
                        {
                            rl.Add(i);
                        }
                        break;

                    default:
                        break;


                }
            }

            while (stack.Count > 0)
            {
                rl.Add(stack.Pop().Item2);
            }

            for (var i = 0; i < s.Length; i++)
            {
                if (!rl.Contains(i))
                    sb.Append(s[i]);
            }

            return sb.ToString();
        }


        //Leetcode 314
        public IList<IList<int>> VerticalOrder(TreeNode root)
        {
            var results = new List<IList<int>>();
            if (root == null)
                return results;
            var dict = new Dictionary<int, List<int>>();

            var queue = new Queue<Tuple<TreeNode, int>>();

            queue.Enqueue(new Tuple<TreeNode, int>(root, 0));
            while (queue.Count > 0)
            {
                var t = queue.Dequeue();
                if (!dict.ContainsKey(t.Item2))
                {
                    dict[t.Item2] = new List<int>() { t.Item1.val };
                }
                else
                {
                    dict[t.Item2].Add(t.Item1.val);
                }
                if (t.Item1.left != null)
                {
                    queue.Enqueue(new Tuple<TreeNode, int>(t.Item1.left, t.Item2 - 1));
                }
                if (t.Item1.right != null)
                {
                    queue.Enqueue(new Tuple<TreeNode, int>(t.Item1.right, t.Item2 + 1));
                }
            }



            results.AddRange(dict.OrderBy(d => d.Key).Select(d => d.Value).ToList());
            return results;

        }





        //I.io
        //Given an unsorted array of unique integers(size n + 1) and a first array identical to the second array but missing one integer(size n), find and output the missing integer.
        static int findMissing(int[] list1, int[] list2)
        {
            var i = 0;
            while (i < list1.Length || i < list2.Length)
            {
                if (i == list1.Length)
                    return list2[i];
                else if (i == list2.Length)
                    return list1[i];


                if (list1[i] != list2[i])
                    return (list1.Length > list2.Length) ? list1[i] : list2[i];


                i++;
            }
            return default;
        }



        //Interviewing.io:  
        //Given an input string (s) and a pattern(p), implement wildcard pattern matching with support for '?' and '*' where:

        //'?' Matches any single character.
        //'*' Matches any sequence of characters (including the empty sequence).
        //The matching should cover the entire input string (not partial).
        static bool match(string s, string p)
        {

            for (var i = 0; i < s.Length; i++)
            {

                if (i < p.Length && p[i] == '*')
                    return true;

                if (i < p.Length && (p[i] == s[i] || p[i] == '?'))
                    continue;

                else
                    return false;
            }

            return true;
        }



        //Interviewing.io:  Traverse the boundary (outer edges) of a tree:

        static int[] boundary(TreeNode root)
        {
            var leftlist = new List<int>();
            var leaflist = new List<int>();
            var rightlist = new List<int>();

            traverseleft(root, ref leftlist);
            traverseleaves(root.left, ref leaflist);
            traverseleaves(root.right, ref leaflist);
            traverseright(root.right, ref rightlist);
            return leftlist.Concat(leaflist).Concat(rightlist.OrderByDescending(r => r)).ToArray();

        }

        static void traverseleft(TreeNode node, ref List<int> list)
        {
            if (node == null || (node.left == null && node.right == null))
                return;

            list.Add(node.val);
            traverseleft(node.left, ref list);
        }

        static void traverseleaves(TreeNode node, ref List<int> list)
        {
            if (node == null)
                return;
            if (node.left == null && node.right == null)
                list.Add(node.val);
            traverseleaves(node.left, ref list);
            traverseleaves(node.right, ref list);

        }

        static void traverseright(TreeNode node, ref List<int> list)
        {
            if (node == null || (node.left == null && node.right == null))
                return;

            list.Add(node.val);
            traverseright(node.right, ref list);
        }









        //find longest non-repeating substring.
        static int substrlen(string s)
        {
            var max = 0;
            var dict = new Dictionary<char, int>();
            var left = 0;
            //var right = 1;
            var len = s.Length;
            dict[s[0]] = 1;
            //var count = 0;
            for (var i = 1; i < len; i++)
            {
                if (dict.ContainsKey(s[i]))
                {
                    dict.Clear();
                    dict[s[i]] = 1;
                    max = Math.Max(max, i - left);
                    left = i;

                }



            }
            return max;


        }





        //Facebook mock interview (2 questions):  

        //1.
        //Linked List Iterate Backward
        // Iterate over a singly linked list backwards calling function print(node) on each node.

        // Example: A->B->C 
        // Output: “CBA”
        //Solution 1 was to write with a stack.
        //Solution 2 was to write with modifying pointer to point backwards.
        //Solution 3 was to write with counter, then just iterate

        //Write functions for this now!

        public class LLNode
        {
            public int val;
            public LLNode next;

        }
        public void printllreverse(LLNode root)
        {
            var p1 = root.next;
            var p2 = p1.next;

            root.next = null;
            while (p1 != null)
            {
                p1.next = root;
                root = p1;
                p1 = p2;
                if (p2 == null)
                    break;
                p2 = p2.next;


            }



            while (root != null)
            {
                Console.WriteLine(root.val);
                root = root.next;
            }


        }

               
        public class MultipleChildrenNode
        {
            public int id;
            public List<MultipleChildrenNode> children;
        }

        //Facebook mock interview question2:
        //assign unique ID's to tree.

        public void assignUniqueIds(MultipleChildrenNode root)
        {

            var counter = 10; // int.MinValue;

            Traverse(root, ref counter);

        }

        void Traverse(MultipleChildrenNode node, ref int counter)
        {

            if (node == null)
                return;
            node.id = counter++;
            if (node.children != null)
            {
                foreach (var child in node.children)  //DEF
                {
                    Traverse(child, ref counter);

                }
            }

        }

        
        //how many combinations of nums add up to k
        public int runningsum(int[] nums, int k)
        {

       

            var dict = new Dictionary<int, int>();
            var subarrays = 0;
            var sum = 0;
            dict.Add(0, 1);
            for (var i = 0; i < nums.Length; i++)
            {
                sum += nums[i];

                var diff = sum - k;
                if (dict.ContainsKey(diff))
                    subarrays += dict[diff];

                dict.TryGetValue(sum, out int count);
                dict[sum] = count + 1;

            }


            return subarrays;

        }




                public int[] indices(int[] nums, int target)
                {


                    var dict = new Dictionary<int, int>();

                    for (var i = 0; i < nums.Length; i++)
                    {
                        var diff = target - nums[i];


                        if (!dict.ContainsKey(diff))
                        {
                            dict[nums[i]] = i;
                        }
                        else
                        {
                            return new int[] { dict[diff], i };
                        }

                    }

                    return default;


                }



                public int[] subs(string s, string[] words)
                {
                    var results = new List<int>();
                    var slen = s.Length;
                    var wordlen = words[0].Length;
                    var wordcount = words.Length;
                    var totallen = wordlen * wordcount;

                    var dict = words.ToDictionary(w => w, x => 0);

                    // foreach(var d in dict)
                    //     Console.WriteLine(d.Value);

                    for (var i = 0; i <= s.Length - totallen; i += wordlen)
                    {
                        var substr = s.Substring(i, totallen);
                        //Console.WriteLine("substr: " + substr);
                        for (var j = 0; j <= substr.Length - wordlen; j += wordlen)
                        {
                            var subs2 = substr.Substring(j, wordlen);
                            // Console.WriteLine("subs2: " + subs2);
                            if (dict.ContainsKey(subs2))
                                dict[subs2]++;
                        }
                        if (dict.Where(d => d.Value != 1).Count() == 0)
                        {
                            results.Add(i);
                            //  Console.WriteLine(i);
                        }
                        // else
                        // {
                        //      Console.WriteLine("nothingfound!! i=" + i);
                        //  }
                        //   foreach(var d in dict)
                        //       Console.WriteLine(d.Value);
                        //  Console.WriteLine("*********************************");
                        dict = words.ToDictionary(w => w, x => 0);
                    }

                    return results.ToArray();

                }

                public void countnodes(TreeNode root, ref int count)
                {
                    if (root == null)
                        return;

                    count++;
                    countnodes(root.left, ref count);
                    countnodes(root.right, ref count);



                }


                //interviewing.IO find 2 lines with the greatest surface area
                public int find2lines(int[] heights)
                {
                    var len = heights.Length;
                    var maxwater = 0;
                    var left = 0;
                    var right = len - 1;

                    while (left < right)
                    {
                        var dist = right - left;
                        var minheight = Math.Min(heights[left], heights[right]);
                        var height = dist * minheight;
                        maxwater = Math.Max(maxwater, height);

                        if (heights[left] < heights[right])
                            left++;
                        else
                            right--;


                    }

                    return maxwater;
                }


                //PAsses 12
                //need a better technique.

                public double getMaxDamageDealtbetter(int N, int[] H, int[] D, int B)
                {


                    var warriors = new Tuple<int, int>[N];

                    for (var i = 0; i < N; i++)
                    {
                        warriors[i] = new Tuple<int, int>(H[i], D[i]);
                    }


                    warriors = warriors.OrderByDescending(w => w.Item1).ThenByDescending(w => w.Item2).ToArray();

                    double maxdamage = 0;
                    double totaldamage = 0;
                    double prevdamage = 0;

                    for (var i = 0; i < N - 1; i++)
                    {
                        for (var j = i+1; j < N; j++)
                        {

                            totaldamage = ((double)warriors[i].Item1 / (double)B * ((double)warriors[i].Item2 + (double)warriors[j].Item2)) + ((double)warriors[j].Item1 / (double)B * (double)warriors[j].Item2);
                            if (totaldamage < prevdamage)
                                return maxdamage;
                            maxdamage = Math.Max(maxdamage, totaldamage);
                            totaldamage = ((double)warriors[j].Item1 / (double)B * ((double)warriors[j].Item2 + (double)warriors[i].Item2)) + ((double)warriors[i].Item1 / (double)B * (double)warriors[i].Item2);
                            prevdamage = totaldamage;
                            maxdamage = Math.Max(maxdamage, totaldamage);

                        }
                    }

                    return maxdamage;

                }



        //passes 24. best algo so far, but need to understand it!!!
        public double getMaxDamageDealt(int N, int[] H, int[] D, int B)
        {

            List<Tuple<int, int>> warriors = new List<Tuple<int, int>>();
            for (int i = 0; i < H.Length; i++)
            {
                warriors.Add(new Tuple<int, int>(H[i], D[i]));
            }

            double GetMax(int i, bool isHealth, double allMax)
            {
                double curMax = 0;
                int curJ = -1;
                for (int j = 0; j < warriors.Count; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }

                    int h1, d1, h2, d2;
                    if (isHealth)
                    {
                        h1 = warriors[i].Item1;
                        d1 = warriors[i].Item2;
                        h2 = warriors[j].Item1;
                        d2 = warriors[j].Item2;
                    }
                    else
                    {
                        h1 = warriors[j].Item1;
                        d1 = warriors[j].Item2;
                        h2 = warriors[i].Item1;
                        d2 = warriors[i].Item2;
                    }

                    double damage = h1 * d1 + h1 * d2 + h2 * d2;
                    if (damage > curMax)
                    {
                        curMax = damage;
                        curJ = j;
                    }
                }

                if (curMax > allMax)
                {
                    return GetMax(curJ, !isHealth, curMax);
                }
                else
                {
                    return allMax;
                }
            }

            return Math.Max(GetMax(0, true, 0), GetMax(0, false, 0)) / B;

        }



        public double getMaxDamageDealtsux(int N, int[] H, int[] D, int B)
        {
            //passed 7 / 24 with one wrong answer and rest too slow
            var warriors = new Tuple<int, int>[N];

            for (var i = 0; i < N; i++)
            {
                warriors[i] = new Tuple<int, int>(H[i], D[i]);
            }


            warriors = warriors.OrderByDescending(w => w.Item1).ThenByDescending(w => w.Item2).ToArray();



            //var besthealth = H.Max();
            //var besthealthindex = Array.IndexOf(H, besthealth);
            //var bestdamage = D.Where(d => Array.IndexOf(D, d) != besthealthindex).Max();
            //var bestdamageindex = Array.IndexOf(D, bestdamage);

            double maxdamage = 0;
            double totaldamage = 0;


            for (var i = 0; i < N - 1 && i < 2; i++)
            {
                for (var j = 1; j < N && j < 3; j++)
                {

                    totaldamage = ((double)warriors[i].Item1 / (double)B * ((double)warriors[i].Item2 + (double)warriors[j].Item2)) + ((double)warriors[j].Item1 / (double)B * (double)warriors[j].Item2);
                    maxdamage = Math.Max(maxdamage, totaldamage);
                    totaldamage = ((double)warriors[j].Item1 / (double)B * ((double)warriors[j].Item2 + (double)warriors[i].Item2)) + ((double)warriors[i].Item1 / (double)B * (double)warriors[i].Item2);
                    maxdamage = Math.Max(maxdamage, totaldamage);
                }
            }

            //        totaldamage = ((double)H[i] / (double)B * ((double)D[i] + (double)D[j])) + ((double)H[j] / (double)B * (double)D[j]);
            //        maxdamage = Math.Max(maxdamage, totaldamage);
            //        totaldamage = ((double)H[j] / (double)B * ((double)D[j] + (double)D[i])) + ((double)H[i] / (double)B * (double)D[i]);
            //        maxdamage = Math.Max(maxdamage, totaldamage);
            //    }

            //}


            //double totaldamage = 0;


            //    totaldamage = ((double)H[besthealthindex] / (double)B * ((double)D[besthealthindex] + (double)D[bestdamageindex])) + ((double)H[bestdamageindex] / (double)B * (double)D[bestdamageindex]);


            //  return totaldamage;
            return maxdamage;

        }


        public long getSecondsElapsed(long C, int N, long[] A, long[] B, long K)
                {

                    Array.Sort(A);
                    Array.Sort(B);

                    long tpr = 0;
                    for (var i = 0; i < N; i++)
                    {
                        tpr += (B[i] - A[i]);
                    }

                    long revs = K / tpr; 
                    long rem = K % tpr; 
                    long result = 0;


                    if (rem == 0)
                    {
                        result = C * revs - (C - B[N - 1]);
                    }
                    else
                    {

                        var i = 0;
                        while (rem > 0)
                        {
                            rem -= B[i] - A[i];
                            i++;
                        }



                        result = C * revs + B[i - 1] + rem;


                    }

                    return result;
                }


                //Service Titan interview"

                //create a multimap class with all the functions but generic multimap<K, V>(){}
                //Add, list, flatten, remove element, remove value, remove all keys and values, etc.
                //unit tests to test every possibility
                //do it here as the multimap created here is crap.

                public void MultiMapTest()
                {
                    var mmap = new MultiMap<int>();

                    mmap.Add("test1", 1);
                    mmap.Add("test1", 1);


                    var multiMap = new MultiMap<bool>();
                    multiMap.Add("key1", true);
                    multiMap.Add("key1", false);
                    multiMap.Add("key2", false);

                    foreach (string key in multiMap.Keys)
                    {
                        foreach (bool value in multiMap[key])
                        {
                            Console.WriteLine("MULTIMAP: " + key + "=" + value);
                        }
                    }


                    var k = mmap.Keys;

                    foreach(var kk in k)
                    {
                        foreach(var val in mmap[kk])
                            Console.WriteLine(kk + " " + val);
                    }



                }


                static List<int> leftboundary = new List<int>();
                static List<int> leafnodes = new List<int>();
                static List<int> rightboundary = new List<int>();


                static int[] findBoundary(TreeNode root)
                {
                    leftboundary.Add(root.val);
                    traverseleft(root.left);
                    traverseright(root.right);
                    rightboundary.Reverse();
                    return leftboundary.Concat(leafnodes).Concat(rightboundary).ToArray();

                }

                static void traverseleft(TreeNode root)
                {
                    if (root == null)
                        return;
                    leftboundary.Add(root.val);
                    traverseleft(root.left);
                    traverseleft(root.right);

                }

                static void traverseright(TreeNode root)
                {
                    if (root == null)
                        return;
                    if (root.left == null && root.right == null)
                        leafnodes.Add(root.val);
                    else
                    {
                        rightboundary.Add(root.val);
                        traverseright(root.left);
                        traverseright(root.right);
                    }


                }


















                public int[] twosum(int[] nums, int target)
                {
                    var dict = new Dictionary<int, int>();
                    var result = new int[2];
                    for (var i = 0; i < nums.Length; i++)
                    {
                        var diff = target - nums[i];
                        var found = 0;
                        if (dict.TryGetValue(diff, out found))
                        {
                            result[0] = i;
                            result[1] = found;
                            break;
                        }
                        else
                        {
                            dict[nums[i]] = i;
                        }

                    }
                    return result;



                }



                //inmterviewing.io AI interviews:
                public int[] frequentelem(int[] nums, int k)
                {
                    // var result = new List<int>();
                    var dict = new Dictionary<int, int>();

                    for (var i = 0; i < nums.Length; i++)
                    {
                        if (!dict.TryGetValue(nums[i], out _))
                            dict[nums[i]] = 1;
                        else
                            dict[nums[i]]++;

                    }
                    // var q = new PriorityQueue<int, int>();

                    var top2 = dict.OrderByDescending(d => d.Value).Take(2).Select(d => d.Key);


                    return top2.ToArray();


                }



                //inmterviewing.io AI interviews:
                //2 pointer solution.

                public int findHeights(int[] lines)
                {
                    var result = 0;
                    var len = lines.Length;
                    var left = 0;
                    var right = len - 1;
                    while (left <= right)
                    {
                        var area = Math.Min(lines[left], lines[right]) * (right - left);
                        result = Math.Max(area, result);
                        if (lines[right] < lines[left])
                        {
                            right--;
                        }
                        else
                        {
                            left++;
                        }

                    }


                    return result;

                }



                public IList<int> InorderTraversal(TreeNode root)
                {
                    var list = new List<int>();
                    var stack = new Stack<TreeNode>();

                    while (root != null || stack.Count > 0)
                    {

                       if (root != null)
                        { 
                            stack.Push(root);
                            root = root.left;
                        }
                       else
                        {
                            var popped = stack.Pop();
                            list.Add(popped.val);
                            root = popped.right;
                        }


                    }
                    return list;
                }

                public int[] TwoSum7(int[] nums, int target)
                {


                    var d = new Dictionary<int, int>();


                    for (var i = 0; i < nums.Length; i++)
                    {

                        var diff = target - nums[i];
                        if (d.ContainsKey(diff))
                        {
                            return new int[] { i, d[diff] };
                        }
                        else
                        {
                            d[nums[i]] = i;
                        }
                    }   

                    return default;

                }

                public int MostProfitablePath(int [,] grid)
                {
                    var m = grid.GetLength(0);
                    var n = grid.GetLength(1);
                   // var profit = 0;
                    var dp = new int[m,n];
                    dp[0,0] = 0;

                    for (var i = 0; i < m; i++)
                    {
                        for (var j = 0; j < n; j++)
                        {
                            dp[i,j] = Math.Max(i > 0 ? dp[i - 1, j] : 0, j > 0 ? dp[i, j - 1] : 0) + grid[i, j];
                        }
                    }

                    return dp[m-1,n-1];

                }   

                public int ClimbStairsPaid(int N, int[] P)
                {
                    var dp = new int[N + 1];
                    dp[0] = 0;
                    dp[1] = P[1];
                    for (var i = 2; i <= N; i++)
                    {
                        dp[i] = Math.Min(dp[i-1], dp[i-2]) + P[i];
                    }

                    return dp[N];   

                }


                public int ClimbStairsKstepsSpaceOptimizedRedStairs(int N, int K, bool[] redstairs)
                {
                    var dp = new int[K];
                    dp[0] = 1;


                    for (var i = 1; i <= N; i++)
                    {
                        for (var j = 1; j < K; j++)
                        {
                            if (i - j < 0)
                                continue;
                            if (redstairs[i - 1])
                                dp[i % K] = 0;
                            else
                                dp[i % K] += dp[(i - j) % K];

                        }
                    }


                    return dp[N % K];
                }




                public int ClimbStairsKstepsSpaceOptimized(int N, int K)
                {
                    var dp = new int[K];
                    dp[0] = 1;


                    for (var i = 1; i <= N; i++)
                    {
                        for (var j = 1; j < K; j++)
                        {
                            if (i - j < 0)
                                continue;
                            dp[i % K] += dp[(i - j) % K];

                        }
                    }


                    return dp[N % K];
                }


                public int ClimbStairsKsteps(int N, int K)
                {
                    var dp = new int[N + 1];
                    dp[0] = 1;
                    dp[1] = 1;

                    for (var i = 2; i <= N; i++)
                    {
                        for (var j = 1; j <= K; j++)
                        {
                            if (i - K < 0)
                                continue;
                            dp[i] += dp[i - j];

                        }
                    }


                    return dp[N];
                }



                public long getMinCodeEntryTime3(int N, int M, int[] C)
                {

                    var c = new int[] { 0, 1 }.Concat(C);

                    int Cost(int i, int j)
                    {
                        return Math.Min((C[i] - C[j]) % N, (C[j] - C[i]) % N);
                    }

                    List<int> dp = new List<int>(new int[M]);
                    dp[0] = Cost(0, 1);

                    for (int i = 2; i < C.Count() ; i++)
                    {
                        dp[i - 1] = dp.GetRange(0, i - 1).Select(k => dp[k] + Cost(k, i)).Min();

                        for (int k = 0; k < i - 1; k++)
                        {
                            dp[k] += Cost(i - 1, i);
                        }
                    }

                    return dp.Min();


                }



        //works with MEMOization
        //Only works for one timer clock. needs to work for two.

        public long getMinCodeEntryTime(int N, int M, int[] C)
                {
                    // var memo = Enumerable.Range(0, M).Select(_ => new Dictionary<int, long>()).ToList();

                    var memo = Enumerable.Range(0, M).Select(x => new Dictionary<int, long>()).ToList();
                    long dfs(int left, int step)
                    {
                        if (step == M)
                        {
                            return 0;
                        }
                      //  if (!memo[step].TryGetValue(left, out long result))
                     //   {
                            int right = step == 0 ? 1 : C[step - 1];
                           long result = Math.Min(
                              moves(left, C[step]) + dfs(right, step + 1),
                              moves(right, C[step]) + dfs(left, step + 1)
                            );
                         //   memo[step].Add(left, result);
                      //  }
                        return result;
                    }

                    int moves(int x, int y)
                    {
                        int min = Math.Min(x, y), max = Math.Max(x, y);
                        int fwd = max - min, rev = min + (N - max);
                        return Math.Min(fwd, rev);
                    }

                    return dfs(1, 0);



                }







                //Passed 18/18.  Need to understand this 100% tho


                public int getMaxVisitableWebpages(int N, int[] L)
                {


                    L = Array.ConvertAll(L, x => x - 1);
                    int[] indegrees = new int[N];
                    foreach (int l in L)
                    {
                        indegrees[l] += 1;
                    }
                    int[] levels = new int[N];
                    bool[] visited = new bool[N];
                    Queue<int> queue = new Queue<int>();
                    for (int i = 0; i < N; i++)
                    {
                        if (indegrees[i] == 0)
                        {
                            queue.Enqueue(i);
                        }
                    }
                    while (queue.Count > 0)
                    {
                        int i = queue.Dequeue();
                        visited[i] = true;
                        int j = L[i];
                        levels[j] = Math.Max(levels[j], levels[i] + 1);
                        indegrees[j] -= 1;
                        if (indegrees[j] == 0)
                        {
                            queue.Enqueue(j);
                        }
                    }
                    Dictionary<int, int> roots = new Dictionary<int, int>();
                    Dictionary<int, int> cycleSize = new Dictionary<int, int>();
                    int CountCycle(int start)
                    {
                        if (roots.ContainsKey(start))
                        {
                            return cycleSize[roots[start]];
                        }
                        int count = 0;
                        int i = start;
                        while (true)
                        {
                            count += 1;
                            roots[i] = start;
                            i = L[i];
                            if (start == i)
                            {
                                break;
                            }
                        }
                        cycleSize[start] = count;
                        return count;
                    }
                    int maxChain = 0;
                    for (int i = 0; i < N; i++)
                    {
                        if (!visited[i])
                        {
                            maxChain = Math.Max(maxChain, levels[i] + CountCycle(i));
                        }
                    }
                    return maxChain;


                }





        //Passed 4/18.  suckssss dude  - should try Kahn's algorithm and find the longest cycle and incoming edges.

        public int getMaxVisitableWebpages1(int N, int[] L)
                {
                    var ndegree = new int[N];
                    var maxcount = 0;


                    //Add incoming edges to each node
                    for (int i = 0; i < N; i++)
                    {
                        ndegree[L[i] - 1]++;
                    }
                    var q = new Queue<int>();
                    for (int i = 0; i < N; i++)
                    {
                        if (ndegree[i] == 0)
                            q.Enqueue(i);
                    }

                    var index = 0;
                    var order = new int[N];
                    while (q.Count > 0)
                    {
                        var node = q.Dequeue();
                        order[index++] = node;
                        ndegree[L[node] - 1]--;
                        if (ndegree[L[node] - 1] == 0)
                            q.Enqueue(L[node] - 1);



                    }

                    return order[N - 1];






                    // Write your code here
                    //return 0;

                    //create array of neighbours with all neihbours for each node


                    // start at each node and find out what is the longest distance with a distance of 1 from 1 node to any other node.

                    //   return max distance.

                    //Passed 4 / 28:  works but slow as all failed on time
                    //for (int i = 0; i < N; i++)
                    //{
                    //    var count = 1;
                    //    var visited = new bool[N];
                    //    var j = i;
                    //    visited[j] = true;
                    //    while (true)
                    //    {

                    //        j = L[j] - 1;
                    //        if (visited[j])
                    //            break;
                    //        visited[j] = true;
                    //        count++;


                    //    }
                    //    maxcount = Math.Max(maxcount, count);
                    //    if (maxcount == N)
                    //        break;

                    //}

                    //return maxcount;



                }











                ////Passed 31/31 in java.  convert to C# to understand!

                //int R;
                //int C;
                //char[][] G;

                //Map<Character, List<Vertex>> portals = new HashMap<>();


                //public int getSecondsRequired(int R, int C, char[][] G)
                //{

                //    this.R = R;
                //    this.C = C;
                //    this.G = G;

                //    List<Vertex> currentMoves = new ArrayList<>();

                //    Vertex startPos;
                //    // find starting pos and build portal map
                //    for (int i = 0; i < R; i++)
                //        for (int j = 0; j < C; j++)
                //        {
                //            char cell = G[i][j];
                //            if (cell == 'S')
                //            {
                //                currentMoves.add(new Vertex(i, j));  // Add starting cell to the current moves
                //            }
                //            if (cell >= 'a' && cell <= 'z')
                //            {
                //                portals.computeIfAbsent(cell, c-> new ArrayList<>())
                //                        .add(new Vertex(i, j));
                //            }
                //        }

                //    int moves = 0;
                //    while (true)
                //    {
                //        moves++;
                //        // iterate through all available moves
                //        List<Vertex> newMoves = new ArrayList<>();
                //        for (Vertex v: currentMoves)
                //        {
                //            // try to move left
                //            if (v.canMoveTo(v.row, v.col - 1))
                //            {
                //                Vertex leftCell = new Vertex(v.row, v.col - 1);
                //                if (leftCell.isExit())
                //                    return moves;
                //                newMoves.add(leftCell);
                //            }
                //            // try to move right
                //            if (v.canMoveTo(v.row, v.col + 1))
                //            {
                //                Vertex rightCell = new Vertex(v.row, v.col + 1);
                //                if (rightCell.isExit())
                //                    return moves;
                //                newMoves.add(rightCell);
                //            }
                //            // try to move up
                //            if (v.canMoveTo(v.row - 1, v.col))
                //            {
                //                Vertex aboveCell = new Vertex(v.row - 1, v.col);
                //                if (aboveCell.isExit())
                //                    return moves;
                //                newMoves.add(aboveCell);
                //            }
                //            // try to move down
                //            if (v.canMoveTo(v.row + 1, v.col))
                //            {
                //                Vertex belowCell = new Vertex(v.row + 1, v.col);
                //                if (belowCell.isExit())
                //                    return moves;
                //                newMoves.add(belowCell);
                //            }
                //            // try to use a portal
                //            char cell = v.getValue();
                //            if (cell >= 'a' && cell <= 'z' && portals.containsKey(cell))
                //            {
                //                List<Vertex> portalList = portals.get(cell);
                //                for (Vertex portalExit: portalList)
                //                {
                //                    if (portalExit != v && portalExit.getValue() != 'V')
                //                        newMoves.add(portalExit);
                //                }
                //            }
                //            G[v.row][v.col] = 'V';  // mark as visited
                //        }
                //        if (newMoves.size() == 0)
                //            return -1;
                //        currentMoves = newMoves;
                //    }

                //}

                //class Vertex
                //{
                //    private final int row;
                //    private final int col;

                //    Vertex(int row, int col)
                //    {
                //        this.row = row;
                //        this.col = col;
                //    }

                //    private boolean canMoveTo(int newRow, int newCol)
                //    {
                //        return (newRow >= 0) && (newRow < R) && (newCol >= 0) && (newCol < C)
                //                && G[newRow][newCol] != '#' && G[newRow][newCol] != 'V';
                //    }

                //    private char getValue()
                //    {
                //        return G[row][col];
                //    }

                //    private boolean isExit()
                //    {
                //        return getValue() == 'E';
                //    }
                //}



                //passed 30/31:  still no good:


                public int getSecondsRequired2(int R, int C, char[,] G)
                {
                    // Write your code here
                    int startX = 0, startY = 0;
                    for (int i = 0; i < R; ++i)
                        for (int j = 0; j < C; ++j)
                        {
                            if (G[i,j] == 'S')
                            {
                                startX = i;
                                startY = j;
                                break;
                            }
                        }
                    return getMinSeconds(R, C, G, startX, startY);
                }

                private int getMinSeconds(int R, int C, char[,] G, int startX, int startY)
                {
                    bool[,] visited = new bool[R,C];
                    Queue<Move> q = new Queue<Move>();
                    q.Enqueue(new Move(startX, startY, 0));
                    int minX = -1, minY = -1;
                    int minSeconds = int.MaxValue;
                    while (q.Count > 0)
                    {
                        Move move = q.Dequeue();
                        if (G[move.x,move.y] == 'E')
                        {
                            if (move.seconds < minSeconds)
                            {
                                minSeconds = move.seconds;
                                minX = move.x;
                                minY = move.y;
                            }
                            continue;
                        }
                        visited[move.x,move.y] = true;
                        if (move.x > 0)
                        {
                            makeMove(q, G, move.x - 1, move.y, move.seconds + 1, visited);
                        }
                        if (move.y > 0)
                        {
                            makeMove(q, G, move.x, move.y - 1, move.seconds + 1, visited);
                        }
                        if (move.x < R - 1)
                        {
                            makeMove(q, G, move.x + 1, move.y, move.seconds + 1, visited);
                        }
                        if (move.y < C - 1)
                        {
                            makeMove(q, G, move.x, move.y + 1, move.seconds + 1, visited);
                        }
                        if (G[move.x,move.y] >= 'a' && G[move.x,move.y] <= 'z')
                        {
                            for (int i = 0; i < R; ++i)
                                for (int j = 0; j < C; ++j)
                                    if (G[i,j] == G[move.x,move.y])
                                    {
                                        makeMove(q, G, i, j, move.seconds + 1, visited);
                                    }
                        }
                    }
                    return minX != -1 && minY != -1 ? minSeconds : -1;
                }

                private void makeMove(Queue<Move> q, char[,] G, int x, int y, int secs, bool[,] visited)
                {
                    if (G[x,y] != '#' && !visited[x,y])
                    {
                        q.Enqueue(new Move(x, y, secs));
                    }
                }

                class Move
                {
                    public int x, y;
                    public int seconds;
                    public Move(int x, int y, int seconds)
                    {
                        this.x = x;
                        this.y = y;
                        this.seconds = seconds;
                    }
                }


                //My code:  passess 24/31.  needs work!!!

                public int getSecondsRequired1(int R, int C, char[,] G)
                {
                    var visited = new bool[R,C];
                    var q = new Queue<ChrisNode>();

                    var minseconds = int.MaxValue;
                    var minr = -1;
                    var minc = -1;
                    //Find the starting point
                    ChrisNode start = new ChrisNode(-1, -1,' ', 0);
                    for (var i = 0; i < R; i++)
                    {
                        for (var j = 0; j < C; j++)
                        {
                            if (G[i, j] == 'S')
                            {
                                start = new ChrisNode(i, j, G[i, j], 0);
                                break;
                            }
                        }
                    }


                    q.Enqueue(start);
                    visited[start.r, start.c] = true;

                    while (q.Count > 0)
                    {
                        var n = q.Dequeue();


                        if (n.val == 'E')
                        {

                            if (n.seconds < minseconds)
                            {
                                minseconds = n.seconds;
                                minr = n.r;
                                minc = n.c;
                            }

                        }
                        visited[n.r, n.c] = true;


                        move(n, q, G, R, C, visited);

                        if (n.val >= 'a' && n.val <= 'z')
                        {

                            //var found = false;
                            for (var i = 0; i < R; i++)
                            {
                                for (var j = 0; j < C; j++)
                                {
                                    if (G[i, j] == n.val) // && (i != n.r || j != n.c))
                                    {
                                       // visited[i, j] = true;
                                        move(new ChrisNode(i, j, n.val, n.seconds+1 ), q, G, R, C, visited);
                                    }
                                }
                            }

                          //  continue;
                            //Find next node with same letter and add neighbours to queue if exists
                        }

                        //if (n.val == '.' || n.val == 'S')
                        //{
                        //    visited[n.r, n.c] = true;
                        //    move(n, q, G, R, C, visited);
                        //}
                    }

                   return minr != -1 && minc!= -1 ? minseconds : -1;

                }


                private void move(ChrisNode n, Queue<ChrisNode> q, char[,] G, int R, int C, bool[,] visited)
                {
                    if (n.r > 0 && G[n.r - 1, n.c] != '#' && !visited[n.r-1, n.c])
                    {
                        q.Enqueue(new ChrisNode(n.r - 1, n.c, G[n.r - 1, n.c], n.seconds+1));
                    }

                    if (n.c > 0 && G[n.r, n.c - 1] != '#' && !visited[n.r, n.c-1])
                    {
                        q.Enqueue(new ChrisNode(n.r, n.c - 1, G[n.r, n.c - 1], n.seconds + 1));
                    }

                    if (n.r < R - 1 && G[n.r + 1, n.c] != '#' && !visited[n.r+1, n.c])
                    {
                        q.Enqueue(new ChrisNode(n.r + 1, n.c, G[n.r + 1, n.c], n.seconds + 1));
                    }

                    if (n.c < C - 1 && G[n.r, n.c + 1] != '#' && !visited[n.r, n.c+1])
                    {
                        q.Enqueue(new ChrisNode(n.r, n.c + 1, G[n.r, n.c + 1], n.seconds + 1));
                    }
                }


                private class ChrisNode
                {
                    public int r;
                    public int c;
                    public char val;
                    public int seconds;
                    public ChrisNode(int r, int c, char val, int seconds)
                    {
                        this.r = r;
                        this.c = c;
                        this.val = val;
                        this.seconds = seconds;
                    }
                }



                //Passed 24/24 test cases on metacareers portal;
                //What is the BigO notation of the getMaxExpectedProfit2 below? 
                //O(N^2)  - 2 nested loops.  N^2 is the worst case scenario.  Best case is O(N) if all values are the same.

                public double getMaxExpectedProfit2(int N, int[] V, int C, double S)
                {

                    var stolenpercent = 1 - S;
                    var DP = new double[N + 1];

                    for (var i = 1; i <= N; i++)
                    {
                        double total = 0;
                        double P = 1;
                        for (var j = i - 1; j >= 0; j--)
                        {

                            total += V[j] * P;
                            P *= stolenpercent;

                            DP[i] = Math.Max(DP[i], total + DP[j]);


                        }
                        DP[i] -= C;
                    }

                    return DP.Max();
                }


                //Solved 6/33 test cases. but wrong approach.  need backwards loops  Use Dynamic Programming to solve.  
                public double getMaxExpectedProfit(int N, int[] V, int C, double S)
                {


                    //maybe working?
                    //const int n = v.size();
                    S = 1 - S;
                    double[] dp = new double[N+1];
                    for (int i = 1; i <= N; ++i)
                    {
                        double sum = 0, w = 1;
                        for (int j = i - 1; j >= 0; --j)
                        {
                            sum += V[j] * w;
                            w *= S;
                            dp[i] = Math.Max(dp[i], dp[j] + sum);

                        }
                        dp[i] -= C;
                    }
                    return dp.Max(); // *max_element(dp.begin(), dp.end());




                    //garbage:

                    S = 1 - S;
                    double total = 0;

                    double[] dV = new double[N + 1];
                    // dV = Array.ConvertAll<int, double>(V, x => x);



                    for (var i = 0; i < N; i++)
                    {

        //                if (V[i] - C > V[i] * (S))
                            total += V[i] - C;
                        if (i < N - 1)
                            dV[i + 1] = Math.Max(total, (double)(V[i] * (S)));
                    }

                    return dV.Max();

                }






                public long getSecondsRequired(long N, int f, long[] P)
                {
                    P = new long[] { 2, 3, 4, 5 };
                    var min = P.Min();

                    return N - min;

                }




                    public int getUniformIntegerCountInInterval(long A, long B)
                {


                    var total = 0;

                    for (var i = 1; i < 13; i++)
                    {
                        for (var j = 1; j < 10; j++)
                        {
                            var num = Convert.ToInt64(string.Concat(Enumerable.Repeat(j.ToString(), i)));

                            if (num >= A && num <= B)
                                total++;

                        }
                    }

                    return total;



                }



                //PAssed 32/33
                public int getMinimumDeflatedDiscCount1(int N, int[] R)
                {
                    if (R[N - 1] < N)
                        return -1;

                    var total = 0;
                    for (var i = N - 1; i > 0; i--)
                    {
                        if (R[i - 1] >= R[i])
                        {
                            if (R[i] > 1)
                            {
                                R[i - 1] = R[i] - 1;
                                total++;
                            }
                            else
                                return -1;
                        }

                    }
                    return total;
                }

                //Facebook metacareers.com - passed 34/34 test cases!
                public int getMinProblemCount(int N, int[] S)
                {

                    var isodd = false;
                    var total = 0;

                    for (var i = 0; i < S.Count(); i++)
                    {
                        if (S[i] % 2 > 0)
                            isodd = true;

                        total = Math.Max(total, S[i] / 2);
                    }

                    return total + (isodd ? 1 : 0);

                }


                //Passed  32 out of 32 test cases


                public long getMinCodeEntryTimeOneLock(int N, int M, int[] C)
                {

                    var current = 1;
                    long result = 0;
                    for (var i = 0; i < M; i++)
                    {
                        var pick = C[i];
                        if (current == pick)
                            continue;



                        long forward = (N + pick - current) % N;

                        long back = (N - pick + current) % N;

                        result += Math.Min(forward, back);
                        current = pick;
                    }

                    return result;
                }






                //Facebook - passed 33/33 test cases on Meta careers coding questions

                public int getMaximumEatenDishCount(int N, int[] D, int K)
                {
                    // Write your code here
                    var dict = new Dictionary<int, int>();

                    var total = 0;

                    for (var i = 0; i < N; i++)
                    {
                        var v = D[i];
                        if (!dict.ContainsKey(v) || dict[v] < total - K + 1)
                        {
                            total++;
                            dict[v] = total;
                        }


                    }


                    return total;

                }






                //Facebook meta careers:  passed 32/33 - need to fix this!!

                public int getMaximumEatenDishCountSLOW(int N, int[] D, int K)
                {

                    //Prefix Sum + dictionary is most efficient, as Q.Contains is very inefficient.
                    //use a dictionary and then set Dictionary I to eaten counter running total;
                    // Write your code here

                    var q = new Queue<int>();


                    var total = 0;

                    for (var i = 0; i < N; i++)
                    {
                        var v = D[i];


                            if (q.Count > 0 && q.Count == K)
                        { 
                                q.Dequeue();
                            q.Enqueue(v);
                            total++;
                        }
                        else
                        {


                            continue;
                        }
                    }


                    return total;

                }




                public int getArtisticPhotographCount(int N, string C, int X, int Y)
                {

                    var P = new int[N + 1];
                    var B = new int[N + 1];
                    var result = 0;

                    for (var i = 1; i <= N; i++)
                    {
                        P[i] = P[i-1] + (C[i-1] == 'P' ? 1 : 0);
                        B[i] = B[i-1] + (C[i-1] == 'B' ? 1 : 0);  
                    }

                    for (var i = 0; i < N; i++)
                    {
                        if (C[i] == 'A')
                        { 

                            var beforeEnd = i-X+1 > 0 ? i-X+1 : 0;
                            var beforeStart = i-Y > 0 ? i-Y : 0;

                            var afterEnd = i + Y + 1 < N ? i + Y + 1 : N;
                            var afterStart = i + X < N ? i + X : N;
                            result += (P[beforeEnd] - P[beforeStart]) * (B[afterEnd] - B[afterStart]);
                            result += (P[afterEnd] - P[afterStart]) * (B[beforeEnd] - B[beforeStart]);
                        }
                    }
                    return result;


                    //Passed most test cases, but bad attempt!!:
                    //for (var i = 0; i < N; i++)
                    //{
                    //    if (C[i] == 'A')
                    //    {
                    //        var forwardP = 0;
                    //        var forwardB = 0;
                    //        var backwardP = 0;
                    //        var backwardB = 0;


                    //        for (var j = i-Y > 0 ? i-Y : 0; j < i -X + 1; j++)
                    //        {
                    //            if (C[j] == 'P')
                    //            {
                    //                forwardP++;
                    //            }
                    //            else if (C[j] == 'B')
                    //            {
                    //                backwardB++;
                    //            }

                    //        }

                    //        for (var k = i +X < N - 1 ? i + X : N - 1; k < N && k < i + Y + 1; k++)
                    //        {
                    //            if (C[k] == 'P')
                    //            {
                    //                backwardP++;
                    //            }
                    //            else if (C[k] == 'B')
                    //            {
                    //                forwardB++;
                    //            }

                    //        }
                    //        result += forwardP * forwardB;
                    //        result += backwardP * backwardB;




                    //    }   
                    //}






                }



            public long getMaxAdditionalDinersCount(long N, long K, int M, long[] S)
                {

                    Array.Sort(S);
                    long result = 0;
                    long spread = K + 1;
                    result += ((S[0] - 1) / spread);
                    result += ((N - S[M - 1]) / spread);
                    for (long i = 0; i < M - 1; i++)
                    {
                        result += ((S[i + 1] - S[i]) / spread - 1);
                    }
                    return result;



                    //Below works but onlyh passess 29/32 test cases on Meta careers coding questions
                    //var dict = S.ToDictionary(s => s, t => t);

                    //var result = 0;
                    //long i = 0;
                    //while (i < N)
                    //{
                    //    if (dict.ContainsKey(i + 1))
                    //    {
                    //        i += K + 1;
                    //        continue;
                    //    }
                    //    var found = false;
                    //    for (long j = i + 1; j < N && j < i + K + 1; j++)
                    //    {
                    //        if (dict.ContainsKey(j + 1))
                    //        {
                    //            found = true;
                    //            i = j + K + 1;
                    //            break;
                    //        }
                    //    }
                    //    if (!found)
                    //    {
                    //        result++;
                    //        i += K + 1;
                    //    }



                    //    return result;


                }





                public int CalculateDaysBetweenDates(string date1, string date2)
                {
                    var d1 = DateTime.Parse(date1);
                    var d2 = DateTime.Parse(date2);

                    return (d2 - d1).Days;
                }

                void preOrderTree(TreeNode root)
                {
                    if (root == null)
                        return;

                    Console.WriteLine(root.val);
                    preOrderTree(root.left);
                    preOrderTree(root.right);
                }

                void postOrderTree(TreeNode root)
                {
                    if (root == null)
                        return;

                    postOrderTree(root.left);
                    postOrderTree(root.right);
                    Console.WriteLine(root.val);
                }



             
                //Crossover - passed step 3 - 20/22 test cases.  need to debug
                //dEC 3 2023


            


        //class Field
        //{

        //    public string value { get; set; }
        //    public int timestamp { get; set; }
        //    public int ttl { get; set; }
        //    public int mods { get; set; }
        //}


        //public string[] solution(string[][] queries)
        //        {

        //var output = new List<string>();
        //            var container = new Dictionary<string, Dictionary<string, Field>>();


        //            foreach (var q in queries)
        //            {


        //                var mods = new List<Tuple<int, string>>();
        //                 if (q[0] == "TOP_N_KEYS")
        //                {
                    
        //                    foreach (var k in container)
        //                    {

        //                        var m = k.Value.Values.Select(v => v.mods).Count();
        //                        var k1 = k.Key + "(" + k.Value.Values.Select(v => v.mods).Count() + ")";
        //                        mods.Add(new Tuple<int, string>(m, k1));
                        
        //                    }
        //            //var mods3 = container.SelectMany(c => c.Value.Values).OrderByDescending(v => v.mods).Select(v) .Count();


        //            //var mods2 = container.SelectMany(c => c.Value.Values);
        //            //   var nummods = mods.OrderByDescending(m => m).ThenBy(m => m.Key).Take(Convert.ToInt32(q[1])).Select(m => m.Key + "(" + m.Value + ")");
        //            //  output.Add(nummods != null && nummods.Count() > 0 ? string.Join(", ", nummods) : "");


        //                    var o = mods.OrderByDescending(m => m.Item1).Select(m => m.Item2).ToList();
        //                    output.Add(String.Join(' ', o));

        //                }
        //                //else
        //                //{
        //                //    output.Add("");
        //                //}
                   



        //    else if (q[0] == "SET")
        //                {


        //                    if (!container.ContainsKey(q[1]))
        //                    {
        //                        container.Add(q[1], new Dictionary<string, Field>() { { q[2], new Field() { value = q[3], mods = 1 }
        //                    }                 });
        //                    }
        //                    else
        //                    {

        //                        if (container[q[1]].ContainsKey(q[2]))
        //                        {
        //                            container[q[1]][q[2]].value = q[3];
        //                            container[q[1]][q[2]].mods++;
        //                        }
        //                        else
        //                        {
        //                            container[q[1]].Add(q[2], new Field() { value = q[3], mods = 1 });
        //                        }
        //                    }
        //                    output.Add("");
        //                }

        //                else if (q[0] == "SET_AT")
        //                {


        //                    if (!container.ContainsKey(q[1]))
        //                    {
        //                        container.Add(q[1], new Dictionary<string, Field>() { { q[2], new Field() { value = q[3], timestamp = Convert.ToInt32(q[4]), ttl = -1 } } });
        //                    }
        //                    else
        //                    {

        //                        if (container[q[1]].ContainsKey(q[2]))
        //                        {
        //                            container[q[1]][q[2]].value = q[3];
        //                            container[q[1]][q[2]].timestamp = Convert.ToInt32(q[4]);
        //                            container[q[1]][q[2]].ttl = -1; 


        //                        }
        //                        else
        //                        {
        //                            container[q[1]].Add(q[2], new Field() { value = q[3], timestamp = Convert.ToInt32(q[4]), ttl = -1 });
        //                        }
        //                    }
        //                    output.Add(""); 
        //                }


        //                else if (q[0] == "SET_AT_WITH_TTL")
        //                {


        //                    if (!container.ContainsKey(q[1]))
        //                    {
        //                        container.Add(q[1], new Dictionary<string, Field>() { { q[2], new Field() { value = q[3], timestamp = Convert.ToInt32(q[4]), ttl = Convert.ToInt32(q[5]) } } });
        //                    }
        //                    else
        //                    {

        //                        if (container[q[1]].ContainsKey(q[2]))
        //                        {
        //                            container[q[1]][q[2]].value = q[3];
        //                            container[q[1]][q[2]].timestamp = Convert.ToInt32(q[4]);
        //                            container[q[1]][q[2]].ttl = Convert.ToInt32(q[5]);

        //                        }
        //                        else
        //                        {
        //                            container[q[1]].Add(q[2], new Field() { value = q[3], timestamp = Convert.ToInt32(q[4]), ttl = Convert.ToInt32(q[5]) });
        //                        }
        //                    }
        //                    output.Add(""); 
        //                }




        //                else if (q[0] == "GET")
        //                {
        //                    if (container.ContainsKey(q[1]) && container[q[1]].ContainsKey(q[2]))
        //                    {
        //                        output.Add(container[q[1]][q[2]].value.ToString());
        //                    }
        //                    else
        //                    {
        //                        output.Add("");
        //                    }

        //                }

        //                else if (q[0] == "GET_AT")
        //                {
        //                    var timestamp = Convert.ToInt32(q[3]);
        //                    if (container.ContainsKey(q[1]) && container[q[1]].ContainsKey(q[2]) && (container[q[1]][q[2]].ttl == -1 ? true : (timestamp >= container[q[1]][q[2]].timestamp && timestamp < (container[q[1]][q[2]].timestamp + container[q[1]][q[2]].ttl))))
        //                    {
        //                        output.Add(container[q[1]][q[2]].value.ToString());
        //                    }
        //                    else
        //                    {
        //                        output.Add("");
        //                    }

        //                }



        //                else if (q[0] == "DELETE")
        //                {

        //                    if (container.ContainsKey(q[1]) && container[q[1]].ContainsKey(q[2]))
        //                    {
        //                        container[q[1]].Remove(q[2]);
        //                        output.Add("true");
        //                    }
        //                    else
        //                        output.Add("false");
        //                }

        //                else if (q[0] == "DELETE_AT")
        //                {
        //                    var timestamp = Convert.ToInt32(q[3]);
        //                    if (container.ContainsKey(q[1]) && container[q[1]].ContainsKey(q[2]) && (container[q[1]][q[2]].ttl == 0 ? true : (timestamp >= container[q[1]][q[2]].timestamp && timestamp < (container[q[1]][q[2]].timestamp + container[q[1]][q[2]].ttl))))
        //                    {
        //                        container[q[1]].Remove(q[2]);
        //                        output.Add("true");
        //                    }
        //                    else
        //                        output.Add("false");

        //                } 


        //                else if (q[0] == "SCAN")
        //                {


        //                    if (container.ContainsKey(q[1]))
        //                    {
        //                        var p = container[q[1]].Select(p => p.Key + "(" + p.Value.value + ")").OrderBy(x => x).ThenBy(x => x.Length);
        //                        output.Add(String.Join(", ", p));
        //                    }
        //                    else
        //                    {
        //                        output.Add("");
        //                    }
        //                }


        //                else if (q[0] == "SCAN_AT")
        //                {

        //                    var timestamp = Convert.ToInt32(q[2]);

        //                    if (container.ContainsKey(q[1]))
        //                    {
        //                        var p = container[q[1]].Where(c => timestamp >= c.Value.timestamp && c.Value.ttl == -1 || (timestamp < c.Value.timestamp + c.Value.ttl)).Select(p => p.Key + "(" + p.Value.value + ")").OrderBy(x => x).ThenBy(x => x.Length);
        //                        output.Add(String.Join(", ", p));
        //                    }
        //                    else
        //                    {
        //                        output.Add("");
        //                    }
        //                }




        //                else if (q[0] == "SCAN_BY_PREFIX")
        //                {

        //                    if (container.ContainsKey(q[1]))
        //                    {

        //                        var p = container[q[1]].Where(c => c.Key.StartsWith(q[2])).Select(p => p.Key + "(" + p.Value.value + ")").OrderBy(x => x).ThenBy(x => x.Length);

        //                        output.Add(String.Join(", ", p));
        //                    }
        //                    else
        //                    {
        //                        output.Add("");
        //                    }
        //                }



        //                else if (q[0] == "SCAN_BY_PREFIX_AT")
        //                {


        //                    if (container.ContainsKey(q[1]))
        //                    {
        //                        var timestamp = Convert.ToInt32(q[3]);


        //                        var p = container[q[1]].Where(c => c.Key.StartsWith(q[2]) && (q[2] == "" ? true : c.Key.StartsWith(q[2])) && timestamp >= c.Value.timestamp && (timestamp < c.Value.timestamp + c.Value.ttl))
        //                          .Select(p => p.Key + "(" + p.Value.value + ")").OrderBy(x => x).ThenBy(x => x.Length);

        //                        output.Add(String.Join(", ", p));
        //                    }
        //                    else
        //                    {
        //                        output.Add("");
        //                    }
        //                }

        //            }

        //            return output.ToArray();

        //        }






                public void preOrder2(TreeNode node)
                {
                    if (node == null)
                        return;

                    Console.WriteLine(node.val);
                    preOrder2(node.left);
                    preOrder2(node.right);




                }

                public int[] TwoSum6(int[] nums, int target)
                {
                    //efficient beats 68% on leetcode
                    var dict = new Dictionary<int, int>();

                    for (var i = 0; i < nums.Length; i++)
                    {
                        if (dict.ContainsKey(target - nums[i]))
                            return new int[]{dict[target - nums[i]], i};
                        else
                            dict.TryAdd(nums[i], i);
                    }
                    return default;
                }

                public int[] TwoSum5(int[] nums, int target)
                {

                    //dictionary working but inefficient.
                    var dict = Enumerable.Range(0, nums.Length).ToDictionary(n => n, n => nums[n]);
                    var result = new int[2];
                    for (var i = 0; i < nums.Length; i++)
                    {

                        var value = target - nums[i];

                        var key = -1;

                        var keys = dict.Where(pair => pair.Value == value).Select(pair => pair.Key).ToList();
                        for(var j = 0; j < keys.Count; j++)
                        {
                            if (keys[j] != i)
                            {
                                key = keys[j];
                            }
                        }

                        if (key != -1 && dict.ContainsValue(value)) 
                        {

                            result[0] = i;
                            result[1] = key;

                            break;
                        }

                    }

                    return result;


                }



                // Amazon OA - Passed 6 / 18

                public int countkSpikes(List<int> prices, int k)
                {
                    var len = prices.Count();
                    var leftmax = 0;
                    var rightmax = 0;

                    var l = 0;
                    var lstart = 0;
                    for (; l < k; l++)
                    {
                        leftmax = Math.Max(leftmax, prices[l]);
                    }

                    var r = k + 1;
                    var rstart = r;
                    for (; r <= k + k; r++)
                    {
                        rightmax = Math.Max(rightmax, prices[r]);
                    }

                    var spikes = 0;


                    for (var i = k; i < len - k; i++)
                    {
                        if (prices[i] > leftmax && prices[i] > rightmax)
                        {
                            spikes++;
                        }

                        lstart++;
                        leftmax = 0;
                        for (l = lstart; l < i+1; l++)
                        {
                            leftmax = Math.Max(leftmax, prices[l]);
                        }
                        rstart++;
                        rightmax = 0;
                        for (r = rstart; r <= i+1 +k; r++)
                        {
                            if (r == len)
                                break;
                            rightmax = Math.Max(rightmax, prices[r]);
                        }



                    }
                    return spikes;


                }




                //AMAzon OA - passed 12/18
                public int findMinimumNumberOfPages(List<int> pages, int days)
                {
                    var len = pages.Count;
                    if (len > days)
                        return -1;

                    bool checkpages(int x) 
                    {
                        var res = 0;
                        foreach (var p in pages)
                        {
                            res += (int) Math.Ceiling((decimal)(p / x));
                        }
                        return res <= days;
                    }

                    var left = 1;
                    var right = pages.Max();

                    while (left < right)
                    {
                        var mid = (left + right) / 2;

                        if (checkpages(mid))
                            right = mid;
                        else
                            left = mid + 1;
                    }
                    return left;

                }



                public void noPrefix2(List<string> words)
                {
                    var trie = new TrieWithCheck();

                    foreach (var w in words)
                    {
                        if (trie.Insert(w))
                        {
                            Console.WriteLine("BAD SET");
                            Console.WriteLine(w);
                            return;
                        }
                    }

                    Console.WriteLine("GOOD SET");

                    //var found = new Dictionary<int, string>();

                    //for(var i = 0; i < words.Count; i++)
                    //{
                    //    var subs = words.Where(w => w.StartsWith(words[i]));
                    //    if (subs.Count() > 1)
                    //    {
                    //        var sublist = subs.ToList();
                    //        var index = words.IndexOf(sublist[1]);
                    //        found[index] = sublist[1];
                    //    }

                    //}

                    //if (found.Count() > 0) { 

                    //    var word = found.OrderBy(w => w.Key).Select(w => w.Value).First();


                    //    Console.WriteLine("BAD SET");
                    //    Console.WriteLine(word);

                    //}
                    //else
                    //    Console.WriteLine("GOOD SET");



                }



                public void decodeHuff(string s, HuffNode root)
                {

                    var ss = new List<string>();

                    var t = ss;


                    var node = root;
                    var sb = new StringBuilder();

                    for (var i = 0; i < s.Length; i++)
                    {
                        if (s[i] == '1')
                        {
                            node = node.right;
                            if (node.left == null && node.right == null)
                            {
                                sb.Append(node.data);
                                node = root;
                            }

                        }
                        else
                        {
                            node = node.left;
                            if (node.left == null && node.right == null)
                            {
                                sb.Append(node.data);
                                node = root;
                            }

                        }



                    }


                    Console.WriteLine(sb.ToString());




                }






                static void preOrder(TreeNode node)
                {
                    if (node == null)
                        return;
                    Console.Write(node.val + " ");
                    preOrder(node.left);
                    preOrder(node.right);
                }


                public List<int> bfs3(int n, int m, List<List<int>> edges, int s)
                {

                    var graph = new List<List<int>>();
                    for (var i = 0; i <= n; i++)
                    {
                        graph.Add(new List<int>());
                    }

                    foreach (var e in edges)
                    {
                        graph[e[0]].Add(e[1]);
                        graph[e[1]].Add(e[0]);
                    }

                    var distances = new List<int>();
                    for (var j = 0; j <= n; j++)
                    {
                        distances.Add(-1);
                    }
                    distances[s] = 0;

                    var mult = 6;
                    var q = new Queue<int>();

                    q.Enqueue(s);
                    while (q.Count > 0)
                    {
                        var node = q.Dequeue();
                        foreach (var neighbour in graph[node])
                        {
                            if (distances[neighbour] == -1)
                            {
                                distances[neighbour] = distances[node] + mult;
                                q.Enqueue(neighbour);
                            }
                        }

                    }

                    distances.RemoveAt(s);
                    distances.RemoveAt(0);
                    return distances;


                }





                //passess all test cases.  array does not.
                public int cookies(int k, List<int> A)
                {
                    var operations = 0;
                    var q = new PriorityQueue<int, int>();  //do we need priority?  seems to need priority on older .NET versions?

                    foreach (var a in A)
                        q.Enqueue(a, a);

                    while (q.Peek() < k)
                    {
                        var c1 = q.Dequeue();
                        if (q.Count == 0)
                            return -1;
                        var c2 = q.Dequeue();
                        var sum = c1 + (2 * c2);
                        q.Enqueue(sum, sum);
                        operations++;
                    }
                    return operations;

                }




                public void testeditor(List<List<string>> ops)
                {

                     var a = new List<int> { 1, 2, 3 };

                    // a.Remove(0);

                    var q = new PriorityQueue<int>();


                    q.Enqueue(3);
                    q.Enqueue(1);
                    q.Enqueue(2);

                    var test = q.Peek();

                    //var test2 = q.PeekMax();
                    var test3 = q.Dequeue();



                    /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */

        //  var n = Convert.ToInt32(Console.ReadLine());
        var ed = new editor();
            //for (var i = 0; i < n; i++)
            foreach (var op in ops)
            {

                //var op = Console.ReadLine().Split(' ');
                switch (op[0])
                {
                    case "1":
                        ed.append(op[1], true);
                        break;

                    case "2":
                        ed.delete(Convert.ToInt32(op[1]), true);
                        break;

                    case "3":
                        ed.print(Convert.ToInt32(op[1]));
                        break;

                    case "4":
                        ed.undo();
                        break;

                    default:
                        break;
                }


            }


        }

        internal class editor
        {

            internal class operation
            {
                // public int index {get; set;}
                public int op { get; set; }
              //  public int? num { get; set; }
                public string? text { get; set; }
            }


            StringBuilder sb = new StringBuilder();
            List<operation> operations = new List<operation>();


            public void append(string c, bool addundo)
            {
                if (addundo)
                {
                    operations.Add(new operation()
                    {
                        op = 1,
                        text = c // sb.ToString()
                    });
                }
                sb.Append(c);

            }

            public void delete(int n, bool addundo)
            {
                if (addundo)
                {
                    operations.Add(new operation()
                    {
                        op = 2,
                        text = sb.ToString().Substring(sb.Length - n, n)
                        //text = sb.ToString()
                    });
                }
                sb.Remove(sb.Length - n, n);

            }

            public void print(int n)
            {
                Console.WriteLine(sb[n - 1]);
            }

            public void undo()
            {
                //  sb.Clear();
                //  sb.Append(operations[operations.Count - 1]);
                //  operations.RemoveAt(operations.Count - 1);

                var len = operations.Count;
                var oper = operations[len - 1];
                if (oper.op == 1)
                {
                    delete(oper.text.Length, false);
                }
                else
                {
                    append(oper.text, false);
                }
                operations.RemoveAt(len - 1);
            }

        }
















        //could use binary search which is O(N 2) ?
        public int pairs2(int k, List<int> arr)
        {
            var count = 0;
            var left = 0;
            var len = arr.Count;
            var right = 1;
            arr.Sort();
            while (right < len)
            {
                if (arr[right] - arr[left] == k)
                {
                    count++;
                    left++;
                    right++;
                }
                else if (arr[right] - arr[left] < k)
                {
                    right++;
                }
                else
                {
                    left++;
                }

            }
            return count;
        }




        public string isBalanced3(string s)
        {
            var stack = new Stack<char>();

            foreach (var b in s)
            {
                switch (b)
                {

                    case '{':
                    case '(':
                    case '[':
                        stack.Push(b);
                        break;


                    case '}':
                        if (stack.Count == 0 || stack.Peek() != '{')
                            return "NO";
                        else
                            stack.Pop();
                        break;

                    case ')':
                        if (stack.Count == 0 || stack.Peek() != '(')
                            return "NO";
                        else
                            stack.Pop();
                        break;

                    case ']':
                        if (stack.Count == 0 || stack.Peek() != '[')
                            return "NO";
                        else
                            stack.Pop();
                        break;

                    default:
                        break;


                }
            }

            if (stack.Count > 0)
                return "NO";
            else
                return "YES";
        }

  



    internal class myQueue
        {


            Stack<int> instack = new Stack<int>();
            Stack<int> outstack = new Stack<int>();
            public void enqueue(int n)
            {
                instack.Push(n);
            }

            public int dequeue()
            {
                if (outstack.Count == 0)
                {
                    while (instack.Count > 0)
                    {
                        outstack.Push(instack.Pop());
                    }
                }
                return outstack.Pop();
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
                return outstack.Peek();
            }




        }

       
        internal void testqueue()
        { 

            var queue = new myQueue();

            var n = Convert.ToInt32(Console.ReadLine());

            for (var i = 0; i < n; i++)
            {
                var ql = Console.ReadLine();
                var q = ql.Split(' ');
                switch (q[0])
                {
                    case "1":
                        queue.enqueue(Convert.ToInt32(q[1]));
                        break;

                    case "2":
                        queue.dequeue();
                        break;

                    case "3":
                        var v = queue.peek();
                        Console.WriteLine(v);
                        break;

                    default:
                        break;

                }
            }


        }








        //very efficient.  Can use a normal list to just add everything to it, then sort, then convert back to a linked list.
        private SinglyLinkedListNode mergeLists3(SinglyLinkedListNode head1, SinglyLinkedListNode head2)
        {

            SinglyLinkedListNode pointer = new SinglyLinkedListNode(-1);
            SinglyLinkedListNode head = new SinglyLinkedListNode(-1);
            while (head1 != null || head2 != null)
            {
                if (head2 == null || (head1 != null && head1.data < head2.data))
                {
                    pointer.next = head1;
                    pointer = pointer.next;
                    head1 = head1.next;


                }
                else 
                {
                    pointer.next = head2;
                    pointer = pointer.next;
                    head2 = head2.next;
                }

                if (head.data == -1)
                    head = pointer;



            }

            return head;

        }





        //circle  1st is fuel, 2nd is distance.

        public  int truckTour3(List<List<int>> petrolpumps)
        {
            var sum = 0;
            var i = 0;
            var len = petrolpumps.Count;
            var startindex = -1;
            
            while (true)
            {
                sum += petrolpumps[i][0];
                sum -= petrolpumps[i][1];
                if (sum < 0)
                {
                    if (i == len - 1)
                        i = 0;
                    else
                        i++;
                    sum = 0;
                    startindex = -1;

                }
                else
                {
                    if (i == startindex )
                    {
                        break;
                    }
                    if (startindex == -1)
                        startindex = i;
                    if (i == len - 1)
                        i = 0;
                    else
                        i++;
                }
                


            }
            return startindex;
        }







        //WORKS FOR LARGE DATASETS!!!
        public static int superDigit4(string n, int k)
        {
            if (n.Length == 1)
                return (Convert.ToInt32(n));

            var sb = new StringBuilder(n);

            while (sb.Length > 1)
            {
                long sum = 0;
                for (var i = 0; i < sb.Length; i++)
                {
                    sum += sb[i] - '0';
                }
                sb.Clear();
                sb.Append(sum);

            }

            var finalnum = Convert.ToInt32(sb.ToString()) * k;
            sb.Clear();
            sb.Append(finalnum);
            while (sb.Length > 1)
            {
                long sum = 0;
                for (var i = 0; i < sb.Length; i++)
                {
                    sum += sb[i] - '0';
                }
                sb.Clear();
                sb.Append(sum);
            }
            return Convert.ToInt32(sb.ToString());
        }



        public int palindromeIndex2(string s)
        {
            if (isPalindrome(s))
                return -1;

            var len = s.Length;
            var start = 0;
            var end = len - 1;

            while (start < end)
            {
                if (s[start] != s[end])
                {
                    if (isPalindrome(s.Substring(start + 1, end - start)))
                        return start;
                    else
                        return end;

                }
                else
                {
                    start++;
                    end--;
                }

            }



            return -1;

        }

        private bool isPalindrome(string s)
    {
        return s.SequenceEqual(s.Reverse());
    }





































    public int flippingMatrix3(List<List<int>> matrix)
        {
            var len = matrix.Count;
            var half = len / 2;
            var sum = 0;

            for (var i = 0; i < half; i++)
            {
                for (var j = 0; j < half; j++)
                {
                    var maxvalues = new List<int>() { matrix[i][j], matrix[i][len - j - 1], matrix[len - i - 1][j], matrix[len - i - 1][len - j - 1] };
                    var max = maxvalues.Max();
                    sum += max;
                }
            }

            return sum;
        }






        public  int lonelyinteger3(List<int> a)
        {

            var unique = a.GroupBy(l => l).Where(l => l.Count() == 1).Select(g => g.Key).FirstOrDefault();

            return unique;



        }




        int[] findZigZagSequence3(int[] arr)
{


            //Code to read from console:


            var cases = Convert.ToInt32(Console.ReadLine());

            for (var i = 0; i < cases; i++)
            {



                var len1 = Console.ReadLine();
                // Console.WriteLine(len);   
                var teststr = Console.ReadLine();
                var test = teststr.Split(' ').Select(t => int.Parse(t));

                //var result =  findZigZagSequence(test.ToArray());

                //Console.Write(result[0]);
                //for (var j = 1; j < result.Count(); j++)
                //    Console.Write(" " + result[j]);

                Console.WriteLine();

            }









            var len = arr.Length;
    if (len == 1)
        return arr;

    
    var curr = len / 2;
    
    Array.Sort(arr);
    Array.Reverse(arr, curr, curr + 1);
   

    return arr;
   


}





public  int lonelyinteger2(List<int> a)
        {

            

            var dick = new Dictionary<int, int>();
            foreach (var b in a)
            {
                if (!dick.ContainsKey(b))
                {
                    dick.Add(b, 1);
                }
                else
                {
                    dick[b]++;
                }
            }
            var c = dick.Where(d => d.Value == 1).Select(d => d.Key).First();
            return c;
        }


        public string solution7(int[] state, string[] operations)
        {
              
                    var list = state.ToList();

                    foreach (var o in operations)
                    {
                        if (o == "L")
                        {
                            var index = list.IndexOf(0);
                            if (index >= 0)
                                state[index] = 1;
                        }


                        else if (o.StartsWith("C"))
                        {
                            // var index = list.IndexOf(0);
                            // if (index >= 0)

                            Console.WriteLine(o);

                            var index = Convert.ToInt32(o.Substring(1));


                            Console.WriteLine("index: " + index);
                            state[index] = 0;

                        }


                    }

                    var sb = new StringBuilder();
                    foreach (var s in state)
                    {
                        sb.Append(s);
                    }

                    return sb.ToString();


            }







        public int solution6(int[] serversPowers, string[] events)
        {

            var servers = serversPowers.ToList();
            var serverusage = new int[serversPowers.Length];

            var currentserver = 0;
            foreach (var e in events)
            {
                if (e == "REQUEST")
                {
                    while (servers[currentserver] <= 0)
                    {
                        currentserver++;
                        if (currentserver == serversPowers.Length)
                        {
                            currentserver = 0;
                            for (var i = 0; i < serversPowers.Length; i++)
                            {
                                if (servers[i] != -1)
                                {
                                    servers[i] = serversPowers[i];
                                }
                            }
                        }
                    }
                    //if (servers[currentserver] > 0)
                    // {
                    servers[currentserver]--;
                    serverusage[currentserver]++;
                    // }
                    // else
                    // {
                    //currentserver++;
                    // }
                }
                else if (e.StartsWith("FAIL"))
                {
                    var f = e.Split(' ');
                    servers[Convert.ToInt32(f[1])] = -1;
                }




            }

            var max = 0;
            var index = 0;
            for (var i = 0; i < serverusage.Length; i++)
            {
                if (serverusage[i] >= max)
                {
                    max = serverusage[i];
                    index = i;
                }
            }
            return index;



        }











        int solution5(int[] numbers, int zerosToOne)
        {
            var list = numbers.ToList();
            var sec = 0;
            while (true)
            {
                if (list.Where(l => l == 0).Count() >= zerosToOne)
                {
                    for (var i = 0; i < zerosToOne; i++)
                    {
                        list.RemoveAt(list.Count - 1);
                    }
                    list.Insert(0, 1);
                    sec++;
                }
                else if (list.Where(l => l == 1).Count() >= 1)
                {
                    for (var i = list.Count - 1; i >= 0; i--)
                    {
                        if (list[i] == 1)
                        {
                            list[i] = 0;
                            break;
                        }
                    }
                    sec++;
                }
                else
                    break;
            }
            return sec;
        }








        int[] solution4(int[] target)
        {

            var output = new List<int>();
            if (target.Length < 3)
            {
                foreach (var t in target)
                    output.Add(t);

                return output.ToArray();
            }

            output.Add(target[0]);
            for (var i = 1; i < target.Length - 1; i++)
            {
                if (target[i] > Math.Max(target[i - 1], target[i + 1]))
                {
                    output.Add(target[i]);
                }
            }

            output.Add(target[target.Length - 1]);
            return output.ToArray();
        }








        class Field3
        {
        
          public   int value { get; set; }
            public int timestamp { get; set; }
               public int ttl { get; set; }


         public   int mods { get; set; }
        }


        //public string[] solution3(string[][] queries)
        //{





        //    var output = new List<string>();
        //    var container = new Dictionary<string, Dictionary<string, Field3>>();
        //    var mods = new Dictionary<string, int>();
        //    foreach (var q in queries)
        //    {
        //        //       0       1    2       3
        //        //q = setoring | A | field1 | 2 
//                if (q[0] == "SET_OR_INC")
//                {


//                    if (!container.ContainsKey(q[1]))
//                    {
//                        container.Add(q[1], new Dictionary<string, Field3>() { { q[2], new Field3() { value = Convert.ToInt32(q[3]), mods = 1 }
//                        }
//                    });
//                    mods.Add(q[1], 1);
//                                        }
//                                        else
//                    {

//                        if (container[q[1]].ContainsKey(q[2]))
//                        {
//                            //var val = Convert.ToInt32(container[q[1]][q[2]])  + Convert.ToInt32(q[3]);
//                            container[q[1]][q[2]].value += Convert.ToInt32(q[3]);
//                            //container[q[1]][q[2]].mods++;
//                            mods[q[1]]++;
//                        }
//                        else
//                        {
//                            container[q[1]].Add(q[2], new Field3() { value = Convert.ToInt32(q[3]), mods = 1 });
//                            mods[q[1]]++;
//                        }
//                    }
//                    output.Add(container[q[1]][q[2]].value.ToString());
//                                    }



//                else if (q[0] == "GET")
//{
//    if (container.ContainsKey(q[1]) && container[q[1]].ContainsKey(q[2]))
//    {
//        output.Add(container[q[1]][q[2]].value.ToString());
//    }
//    else
//    {
//        output.Add("");
//    }

//}


//else if (q[0] == "TOP_N_KEYS")
//{
//    // if (container.ContainsKey(q[1]))
//    // {
//    //var mods2 = container[q[1]].OrderByDescending(c => c.Value.mods).Select(c => c.Key).FirstOrDefault();

//    var nummods = mods.OrderByDescending(m => m.Value).ThenBy(m => m.Key).Take(Convert.ToInt32(q[1])).Select(m => m.Key + "(" + m.Value + ")");

//    output.Add(nummods != null && nummods.Count() > 0 ? string.Join(", ", nummods) : "");
//    // }
//    // else
//    // {
//    //     output.Add("");
//    // }
//}




//        else if (q[0] == "DELETE")
//        {

//            if (container.ContainsKey(q[1]) && container[q[1]].ContainsKey(q[2]))
//            {
//                container[q[1]].Remove(q[2]);
//                mods[q[1]]++;
//                if (container[q[1]].Count == 0)
//                {
//                    container.Remove(q[1]);
//                    mods.Remove(q[1]);
//                }
//                output.Add("true");
//            }
//            else
//                output.Add("false");
//        }

//    }
//    return output.ToArray();


//}






//Crossover

//        public string[] solution2(string[][] queries)
//        {


//        var output = new List<string>();
//        var container = new Dictionary<string, Dictionary<string, Field>>();

//            foreach (var q in queries)
//            {
//                //       0       1    2       3
//                //q = setoring | A | field1 | 2 
//                if (q[0] == "SET")
//                {


//                    if (!container.ContainsKey(q[1]))
//                    {
//                        container.Add(q[1], new Dictionary<string, Field>() { { q[2], new Field() { value = q[3], mods = 1 }
//    }
//});
//                    }
//                    else
//{

//    if (container[q[1]].ContainsKey(q[2]))
//    {
//        container[q[1]][q[2]].value = q[3];
//        container[q[1]][q[2]].mods++;
//    }
//    else
//    {
//        container[q[1]].Add(q[2], new Field() { value = q[3], mods = 1 });
//    }
//}
//output.Add(""); // container[q[1]][q[2]].value.ToString());
//                }

//                if (q[0] == "SET_AT")
//{


//    if (!container.ContainsKey(q[1]))
//    {
//        container.Add(q[1], new Dictionary<string, Field>() { { q[2], new Field() { value = q[3], timestamp = Convert.ToInt32(q[4]), ttl = Convert.ToInt32(q[5]) } } });
//    }
//    else
//    {

//        if (container[q[1]].ContainsKey(q[2]))
//        {
//            container[q[1]][q[2]].value = q[3];
//            container[q[1]][q[2]].timestamp = Convert.ToInt32(q[4]);
//            container[q[1]][q[2]].ttl = Convert.ToInt32(q[5]);

//            //  container[q[1]][q[2]].mods++;
//        }
//        else
//        {
//            container[q[1]].Add(q[2], new Field() { value = q[3], timestamp = Convert.ToInt32(q[4]), ttl = Convert.ToInt32(q[5]) });
//        }
//    }
//    output.Add(""); // container[q[1]][q[2]].value.ToString());
//}











//else if (q[0] == "GET")
//{
//    if (container.ContainsKey(q[1]) && container[q[1]].ContainsKey(q[2]))
//    {
//        output.Add(container[q[1]][q[2]].value.ToString());
//    }
//    else
//    {
//        output.Add("");
//    }

//}



//else if (q[0] == "GET_AT")
//{
//    var timestamp = Convert.ToInt32(q[3]);
//    if (container.ContainsKey(q[1]) && container[q[1]].ContainsKey(q[2]) && (container[q[1]][q[2]].ttl == 0 ? true : (timestamp >= container[q[1]][q[2]].timestamp && timestamp < (container[q[1]][q[2]].timestamp + container[q[1]][q[2]].ttl))))
//    {
//        output.Add(container[q[1]][q[2]].value.ToString());
//    }
//    else
//    {
//        output.Add("");
//    }

//}



//else if (q[0] == "DELETE")
//{

//    if (container.ContainsKey(q[1]) && container[q[1]].ContainsKey(q[2]))
//    {
//        container[q[1]].Remove(q[2]);
//        //if (container[q[1]].Count == 0)
//        //{
//        //    container.Remove(q[1]);
//        //}
//        output.Add("true");
//    }
//    else
//        output.Add("false");
//}

//                else if (q[0] == "DELETE_AT")
//                {
//                    var timestamp = Convert.ToInt32(q[3]);
//                    //  if (container.ContainsKey(q[1]) && container[q[1]].ContainsKey(q[2]) && (timestamp >= container[q[1]][q[2]].timestamp && timestamp <= container[q[1]][q[2]].ttl))

//                    if (container.ContainsKey(q[1]) && container[q[1]].ContainsKey(q[2]) && (container[q[1]][q[2]].ttl == 0 ? true : (timestamp >= container[q[1]][q[2]].timestamp && timestamp < (container[q[1]][q[2]].timestamp + container[q[1]][q[2]].ttl))))

//                        {
//                        container[q[1]].Remove(q[2]);
//                        output.Add("true");
//                    }
//                    else
//                        output.Add("false");
//                }



//                else if (q[0] == "MODS")
//                {
//                    if (container.ContainsKey(q[1]))
//                    {
//                        var mods = container[q[1]].OrderByDescending(c => c.Value.mods).Select(c => c.Key).FirstOrDefault();

//                        output.Add(mods);
//                    }
//                    else
//                    {
//                        output.Add("");
//                    }
//                }
//else if (q[0] == "SCAN")
//{
//    if (container.ContainsKey(q[1]))
//    {
//        //      var mods = container[q[1]].OrderByDescending(c => c.Value.mods).Select(c => c.Key).FirstOrDefault();
//        var p = container[q[1]].Where(c => c.Key.StartsWith(q[2])).Select(p => p.Key + "(" + p.Value.value + ")").OrderBy(x => x).ThenBy(x => x.Length);
//        output.Add(String.Join(", ", p));
//    }
//    else
//    {
//        output.Add("");
//    }
//}

//                else if (q[0] == "SCAN_AT")
//                {

//                    var timestamp = Convert.ToInt32(q[3]);

//                    if (container.ContainsKey(q[1]))
//                    {
//                        var p = container[q[1]].Where(c => (q[2] == "" ? true : c.Key.StartsWith(q[2])) && timestamp >= c.Value.timestamp && (timestamp < c.Value.timestamp + c.Value.ttl)).Select(p => p.Key + "(" + p.Value.value + ")").OrderBy(x => x).ThenBy(x => x.Length);
//                        output.Add(String.Join(", ", p));
//                    }
//                    else
//                    {
//                        output.Add("");
//                    }
//                }






//            }

//            return output.ToArray();



//}




//string[] solution(string[][] queries)
//        {
//            var output = new List<string>();
//            var container = new List<string>();
//            foreach (var q in queries)
//            {
//                if (q[0] == "ADD")
//                {
//                    container.Add(q[1]);
//                    output.Add("");
//                }
//                else if (q[0] == "EXISTS")
//                {
//                    if (container.Contains(q[1]))
//                    {
//                        output.Add("true");
//                    }
//                    else
//                    {
//                        output.Add("false");
//                    }
//                }
//                else if (q[0] == "REMOVE")
//                {
//                    var i = container.IndexOf(q[1]);
//                    if (i >= 0)
//                    {
//                        container.RemoveAt(i);
//                        output.Add("true");
//                    }
//                    else
//                    {
//                        output.Add("false");
//                    }

//                }
//                else if (q[0] == "GET_NEXT")
//                {
//                    container = container.OrderBy(c => c).ToList();
//                    var foundlist = container.Find(c => Convert.ToInt32(c) > Convert.ToInt32(q[1]));
//                    if (foundlist != null)
//                    {
//                        output.Add(foundlist);
//                    }
//                    else
//                    {
//                        output.Add("");
//                    }


//                }
//            }

//            return output.ToArray();

//        }



//NOT WORKING FOR LARGE DATASETS!!

public int superDigit3(string n, int k)
        {


            var sb = new StringBuilder();
            for (var i = 0; i < k; i++)
            {
                sb.Append(n);
            }

            if (sb.Length == 1)
                return (Convert.ToInt32(sb.ToString()));

            
            while (sb.Length > 1)
                {
                    long sum = 0;
                for (var i = 0; i < sb.Length; i++)
                    {
                        sum += sb[i] - '0';
                    }
                    sb.Clear();
                    sb.Append(sum);

                }

            return Convert.ToInt32(sb.ToString());
        }



        public static string balancedSums(List<int> arr)
        {
            if (arr.Count <= 1)
                return "YES";
            var leftsum = 0;
            var total = arr.Sum();
            for (var i = 0; i < arr.Count - 1; i++)
            {
                var rightsum = total - arr[i] - leftsum;
                if (leftsum == rightsum)
                    return "YES";
                leftsum += arr[i];
            }
            return "NO";
        }

        //works fastest!
        public string gridChallenge2(List<string> grid)
        {
            var colordered = true;
            grid[0] = String.Concat(grid[0].OrderBy(r => r));
            for (var i = 1; i < grid.Count; i++)
            {
                var s = String.Concat(grid[i].OrderBy(r => r));
                for (var j = 0; j < grid.Count; j++)
                {
                    if (s[j] - grid[i - 1][j] < 0)
                        return "NO";
                }
            }
            return "YES";
        }



        //Amazon  phone: (october 28th, 2022)


        /*
We are working on a security system for a badged-access room in our company's building.

Given an ordered list of employees who used their badge to enter or exit the room, write a function that returns two collections:

1. All employees who didn't use their badge while exiting the room - they recorded an enter without a matching exit. (All employees are required to leave the room before the log ends.)

2. All employees who didn't use their badge while entering the room - they recorded an exit without a matching enter. (The room is empty when the log begins.)

Each collection should contain no duplicates, regardless of how many times a given employee matches the criteria for belonging to it.

records1 = [
  ["Paul",     "enter"],
  ["Pauline",  "exit"],
  ["Paul",     "enter"],
  ["Paul",     "exit"],
  ["Martha",   "exit"],
  ["Joe",      "enter"],
  ["Martha",   "enter"],
  ["Steve",    "enter"],
  ["Martha",   "exit"],
  ["Jennifer", "enter"],
  ["Joe",      "enter"],
  ["Curtis",   "exit"],
  ["Curtis",   "enter"],
  ["Joe",      "exit"],
  ["Martha",   "enter"],
  ["Martha",   "exit"],
  ["Jennifer", "exit"],
  ["Joe",      "enter"],
  ["Joe",      "enter"],
  ["Martha",   "exit"],
  ["Joe",      "exit"],
  ["Joe",      "exit"] 
]

Expected output: ["Steve", "Curtis", "Paul", "Joe"], ["Martha", "Pauline", "Curtis", "Joe"]

Other test cases:

records2 = [
  ["Paul", "enter"],
  ["Paul", "exit"],
]

Expected output: [], []

records3 = [
  ["Paul", "enter"],
  ["Paul", "enter"],
  ["Paul", "exit"],
  ["Paul", "exit"],
]

Expected output: ["Paul"], ["Paul"]

records4 = [
  ["Raj", "enter"],
  ["Paul", "enter"],
  ["Paul", "exit"],
  ["Paul", "exit"],
  ["Paul", "enter"],
  ["Raj", "enter"],
]

Expected output: ["Raj", "Paul"], ["Paul"]

All Test Cases:
mismatches(records1) => ["Steve", "Curtis", "Paul", "Joe"], ["Martha", "Pauline", "Curtis", "Joe"]
mismatches(records2) => [], []
mismatches(records3) => ["Paul"], ["Paul"]
mismatches(records4) => ["Raj", "Paul"], ["Paul"]

n: length of the badge records array
*/






        public List<List<string>> SecurityLog(string[][] accesslog)
        {

            var dict = new Dictionary<string, string>();
            var exitviolations = new List<string>();
            var enterviolations = new List<string>();

            foreach (var log in accesslog)
            {
                var user = log[0];
                var access = log[1];
                Console.WriteLine("each:" + user);



                if (access == "enter")
                {
                    if (dict.ContainsKey(user))
                    {
                        if (dict[user] == "enter")
                            exitviolations.Add(user);

                        dict[user] = access;


                    }
                    else
                        dict[user] = access;

                }
                else
                {
                    Console.WriteLine(user + " exit");
                    if (dict.ContainsKey(user))
                    {
                        if (dict[user] == "exit")
                        {
                            Console.WriteLine(user + dict[user]);
                            enterviolations.Add(user);
                        }


                        dict[user] = access;


                    }
                    else
                    {

                        dict[user] = access;
                    }

                }




            }

            //on exit, remove user from dictionary
            //at end of loop, add any user in the dictionary to the exit or enter violations and remove duplicates.

            return new List<List<string>>() { exitviolations, enterviolations };



        }













    //    static void Main(String[] args)
    //    {
    //        var records1 = new string[][]{
    //        new []{"Paul", "enter"},
    //        new []{"Pauline", "exit"},
    //        new []{"Paul", "enter"},
    //        new []{"Paul", "exit"},
    //        new []{"Martha", "exit"},
    //        new []{"Joe", "enter"},
    //        new []{"Martha", "enter"},
    //        new []{"Steve", "enter"},
    //        new []{"Martha", "exit"},
    //        new []{"Jennifer", "enter"},
    //        new []{"Joe", "enter"},
    //        new []{"Curtis", "exit"},
    //        new []{"Curtis", "enter"},
    //        new []{"Joe", "exit"},
    //        new []{"Martha", "enter"},
    //        new []{"Martha", "exit"},
    //        new []{"Jennifer", "exit"},
    //        new []{"Joe", "enter"},
    //        new []{"Joe", "enter"},
    //        new []{"Martha", "exit"},
    //        new []{"Joe", "exit"},
    //        new []{"Joe", "exit"},
    //    };

    //        var records2 = new string[][]{
    //        new []{"Paul", "enter"},
    //        new []{"Paul", "exit"},
    //    };

    //        var records3 = new string[][]{
    //        new []{"Paul", "enter"},
    //        new []{"Paul", "enter"},
    //        new []{"Paul", "exit"},
    //        new []{"Paul", "exit"},
    //    };

    //        var records4 = new string[][]{
    //        new []{"Raj", "enter"},
    //        new []{"Paul", "enter"},
    //        new []{"Paul", "exit"},
    //        new []{"Paul", "exit"},
    //        new []{"Paul", "enter"},
    //        new []{"Raj", "enter"},
    //    };


    //        var results = SecurityLog(records4);
    //        foreach (var r in results)
    //        {
    //            foreach (var l in r)
    //            {
    //                // Console.WriteLine(l);
    //            }
    //        }

    //    }


    //    static List<List<string>> SecurityLog(string[][] accesslog)
    //    {

    //        var dict = new Dictionary<string, string>();
    //        var exitviolations = new List<string>();
    //        var enterviolations = new List<string>();

    //        foreach (var log in accesslog)
    //        {
    //            var user = log[0];
    //            var access = log[1];
    //            Console.WriteLine("each:" + user);



    //            if (access == "enter")
    //            {
    //                if (dict.ContainsKey(user))
    //                {
    //                    if (dict[user] == "enter")
    //                        exitviolations.Add(user);

    //                    dict[user] = access;


    //                }
    //                else
    //                    dict[user] = access;

    //            }
    //            else
    //            {
    //                Console.WriteLine(user + " exit");
    //                if (dict.ContainsKey(user))
    //                {
    //                    if (dict[user] == "exit")
    //                    {
    //                        Console.WriteLine(user + dict[user]);
    //                        enterviolations.Add(user);
    //                    }


    //                    dict[user] = access;


    //                }
    //                else
    //                {

    //                    dict[user] = access;
    //                }

    //            }




    //        }


    //        return new List<List<string>>() { exitviolations, enterviolations };



    //    }



    //}







    public List<int> dynamicArray(int n, List<List<int>> queries)
        {
            var arr = new List<List<int>>(n);
            for (var i = 0; i < n; i++)
            {
                arr.Add(new List<int>());
            }
            var lastAnswer = 0;
            var answers = new List<int>();

            foreach (var query in queries)
            {
                if (query[0] == 1)
                {
                    var idx = (query[1] ^ lastAnswer) % n;
                    
                    arr[idx].Add(query[2]);
                }
                else
                {
                    var idx = (query[1] ^ lastAnswer) % n;
                    lastAnswer = arr[idx][query[2] % arr[idx].Count()];
                    answers.Add(lastAnswer);
                }


            }
            return answers;
        }


        public  int maxMin(int k, List<int> arr)
        {
            var dict = new Dictionary<int, int>();
            arr.Sort();
            var len = arr.Count();
            var min = Int32.MaxValue;
            for (var i = 0; i < len - k + 1; i++)
            {
                min = Math.Min(min, arr[i + k - 1] - arr[i]);

            }

            return min;
        }




        public  string caesarCipher2(string s, int k)
        {
            var sb = new StringBuilder();
            for (var i = 0; i < s.Length; i++)
            {
                if (!char.IsLetter(s[i])) 
                    sb.Append(s[i]);
                else if (s[i] <= 'z' && s[i] >= 'a')
                {
                    var c = (char)((s[i] - 'a' + k) % 26 + 'a');
                    sb.Append(c);
                }
                else if (s[i] <= 'Z' && s[i] >= 'A')
                {
                    var c = (char)((s[i] - 'A' + k) % 26 + 'A');
                    sb.Append(c);
                }
                



            }

            return sb.ToString();
        }


        public int flippingMatrix2(List<List<int>> matrix)
        {
            var len = matrix.Count;
            var sum = 0;
            for (var i = 0; i < len / 2; i++)
            {
                for (var j = 0; j < len / 2; j++)
                {
                    var max = Math.Max(Math.Max(matrix[i][j], matrix[i][len - j - 1]),
                               Math.Max(matrix[len - i - 1][j], matrix[len - i - 1][len - j - 1]));

                    sum += max;

                }
            }

            return sum;


        }



        public int[]  findZigZagSequence2(int[] args)
        {
            Array.Sort(args);
            var len = args.Length;
            var j = len - 1;
            for (var i = len / 2; i < j; i++)
            {
                var temp = args[i];
                args[i] = args[j];
                args[j] = temp;
                j--;
            }

            return args;
        }


        public int sockMerchant(int n, List<int> ar)
        {
            var dict = new Dictionary<int, int>();

            for (var i = 0; i < ar.Count; i++)
            {
                if (!dict.ContainsKey(ar[i]))
                {
                    dict[ar[i]] = 1;
                }

                else
                    dict[ar[i]]++;
            }

            var count = dict.Select(d => d.Value / 2).Sum();
            return count;
        }



        public void strings_xor(string str1, string str2)
        {
            var sb = new StringBuilder();
            for (var i = 0; i < str1.Length; i++)
            {
                if (str1[i] != str2[i])
                    sb.Append('1');
                else
                    sb.Append('0');

            }
            Console.WriteLine(sb.ToString());
        }

        public int birthday(List<int> s, int d, int m)
        {
            var left = 0;
            var ways = 0;
            while (left <= s.Count - m)
            {
                var sum = 0;
                for (var i = left; i < (left + m); i++)
                {
                    sum += s[i];
                }
                if (sum == d)
                    ways++;
                left++;
            }

            return ways;
        }



        public string twoArrays(int k, List<int> A, List<int> B)
        {
            A.Sort();
            B = B.OrderByDescending(b => b).ToList();
            for (var i = 0; i < A.Count; i++)
            {
                if (A[i] + B[i] < k)
                    return "NO";
            }
            return "YES";
        }



        public string pangrams(string s)
        {
            var l = s.ToLower().Replace(" ", "");
            var dict = new Dictionary<char, int>();
            for (var i = 0; i < l.Length; i++)
            {
                dict[l[i]] = 1;
            }
            if (dict.Count < 26)
                return "not pangram";
            else
                return "pangram";

        }


        public List<int> countingSort(List<int> arr)
        {
            var results = new int[100];
            for (var i = 0; i < arr.Count; i++)
            {
                results[arr[i]]++;
            }
            return results.ToList();
        }




        public int diagonalDifference(List<List<int>> arr)
        {
            var left = 0;
            var right = arr.Count - 1;
            var leftsum = 0;
            var rightsum = 0;

            for (var i = 0; i < arr.Count; i++)
            {
                leftsum += arr[i][left];
                rightsum += arr[i][right];
                left++;
                right--;
            }
            var diff = Math.Abs(leftsum - rightsum);
            return diff;

        }


        public long flippingBits(long n)
        {

            var flipped = ~(uint)n;
            var flipped2 = ~n;
            var f3 = ~(ulong)n;
            var f4 = ~(int)n;

            return flipped;

            //ulong f = ~(ulong)n;
            //long g = ~n;
            //var h = (ulong)n ^ ulong.MinValue;
            //return (long)f;
        }


        public int lonelyinteger(List<int> a)
        {
            var dict = new Dictionary<int, int>();
            for (var i = 0; i < a.Count; i++)
            {
                if (!dict.ContainsKey(a[i]))
                {
                    dict[a[i]] = 1;
                }
                else
                {
                    dict[a[i]]++;
                }

            }
            var r = dict.Where(d => d.Value == 1).Select(d => d.Key).FirstOrDefault();
            return r;
        }

        public List<int> matchingStrings(List<string> strings, List<string> queries)
        {
            var counts = new List<int>();

            for (var i = 0; i < queries.Count; i++)
            {
                var count = strings.Where(s => s == queries[i]).Count();
                counts.Add(count);
            }
            return counts;
        }



        public string timeConversion2(string s)
        {
            var ampm = s.Substring(8);
            var t = s.Substring(0, 8);
            var hour = Convert.ToInt32(s.Substring(0, 2));
            var sb = new StringBuilder();
            if (ampm == "PM")
            {
                if (hour < 12)
                    hour += 12;
            }
            else
            {
                if (hour == 12)
                    hour = 0;
            }
            sb.Append(hour.ToString("00"));
            sb.Append(s.Substring(2, 6));
            return sb.ToString();
        }

        //always check precision.  go for long or BigInteger for massively large numbers
        public static void miniMaxSum(List<int> arr)
        {
            long min = 0;
            long max = 0;
            var len = arr.Count;
            arr.Sort();
            for (var i = 0; i < len; i++)
            {
                if (i > 0)
                    max += arr[i];
                if (i < len - 1)
                    min += arr[i];
            }

            Console.WriteLine(min + " " + max);
        }



        //use double for floating point high precision
        public static void plusMinus2(List<int> arr)
        {
            var len = arr.Count;
            var positive = 0;
            var negative = 0;
            var zero = 0;
            foreach (var n in arr)
            {
                if (n < 0)
                    negative++;
                else if (n == 0)
                    zero++;
                else if (n > 0)
                    positive++;
            }
            var posratio = (double)positive / (double)len;
            var negratio = (double)negative / (double)len;
            var zeroratio = (double)zero / (double)len;

            Console.WriteLine(posratio.ToString("F6"));
            Console.WriteLine(negratio.ToString("F6"));
            Console.WriteLine(zeroratio.ToString("F6"));



        }



        private static void preorder(TreeNode tree)
        {
            if (tree == null)
                return;
            Console.WriteLine(tree.val);
            preorder(tree.left);
            preorder(tree.right);
        }

        public  string isBalanced2(string s)
        {
            var stack = new Stack<char>();
            var good = true;
            for (var i = 0; i < s.Length; i++)
            {
                switch (s[i])
                {
                    case '{':
                    case '(':
                    case '[':
                        stack.Push(s[i]);
                        break;

                    case '}': 
                        if (stack.Count > 0)
                        {
                            if (stack.Peek() != '{')
                                good = false;
                            else
                                stack.Pop();
                        }
                        break;

                    case ')':
                        if (stack.Count > 0)
                        {
                            if (stack.Peek() != '(')
                                good = false;
                            else
                                stack.Pop();
                        }
                        break;
                    case ']':
                        if (stack.Count > 0)
                        {
                            if (stack.Peek() != '[')
                                good = false;
                            else
                                stack.Pop();
                        }
                        break;
                    default:
                        break;
                }
                if (!good)
                    return "NO";

            }

            if (stack.Count > 0)
                return "NO";
            else
                return "YES";


        }






        private void findZigZagSequence(int[] arr)
        {
            //Console.Write("dude, called zigzag!!");
            var len = arr.Length;

            Array.Sort(arr);
            var mid = len / 2;

            var end = len;
            for (var i = mid; i < end && end < len; i++)
            {
                var temp = arr[i];
                arr[i] = arr[end];
                arr[end] = temp;
                end--;
            }
            for (var i = 0; i < len; i++)
            {
                Console.Write(arr[i]);
                if (i < len - 1)
                    Console.Write(" ");
                else
                    Console.WriteLine();

            }

        }



        //Build a graph from the edges, create a distance array, then use  a queue, to ensure the neighbours are queued for each iteration.
        //discard all distances with array element 0 and distance 0.

        public List<int> bfs2(int n, int m, List<List<int>> edges, int s)
        {

            var graph = new List<List<int>>();
            for (var i = 0; i < n+1; i++)
            {
                graph.Add(new List<int>());
            }

            foreach (var edge in edges)
            {
                graph[edge[0]].Add(edge[1]);
                graph[edge[1]].Add(edge[0]);
            }

            var distances = new List<int>();
            for (var i = 0; i < n + 1; i++)
            {
                distances.Add(-1);
            }
            var length = 6;

            var q = new Queue<int>();
            q.Enqueue(s);
            distances[s] = 0;

            while (q.Count > 0)
            {
                var node = q.Dequeue();
                foreach (var neighbour in graph[node])
                {
                    if (distances[neighbour] == -1)
                    {
                        distances[neighbour] = distances[node] + length;
                        q.Enqueue(neighbour);
                    }
                }
            }

            

            var results = new List<int>();
            for(var i = 1; i< distances.Count; i++)
            {
                if (distances[i] != 0)
                    results.Add(distances[i]);
            }

            return results;
        }












        //amazon OA Sep 5 / 2022  - passed 6 / 15.  Need a O(n) or better than O(n2)
        public int findTotalPower2(List<int> power)
        {

            BigInteger result = 0;
            var n = power.Count;
            for (var i = 0; i < n; i++)
            {
                result += (BigInteger) power[i] * (BigInteger)power[i];
                BigInteger sum = power[i];
                BigInteger min = power[i];
                for (var j = i + 1; j < n; j++)
                {
                    sum += (BigInteger)power[j];
                    min = min <= (BigInteger)power[j] ? min : (BigInteger)power[j];
                    result += min * sum;
                }
            }
            return (int)result;
        }
                    



        public int findTotalPower(List<int> power)
        { //O(n2)
          // Write your code here
            var MOD = 1000000007;
            var n = power.Count;
                
            var dp = new Pair[n,n];
            long totalPower = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i > j)
                    {
                        continue;
                    }
                    if (i == j)
                    {
                        dp[i,j] = new Pair(power[i], power[i]);
                    }
                    else
                    {
                        long sum = dp[i, j - 1].sum + power[j];
                        long min = Math.Min(dp[i,j - 1].min, power[j]);
                        dp[i,j] = new Pair(min, sum);
                    }

                    Pair minSumPair = dp[i,j];
                    totalPower += minSumPair.sum * minSumPair.min;
                }

            }
            return (int)(totalPower % MOD);
        }


        private class Pair
        {
            public long min;
            public long sum;
            public Pair(long min, long sum)
            {
                this.min = min;
                this.sum = sum;
            }
           
        }




//        You are given a list of packets of varying sizes and there are n channels.

//Each of the n channel must have a single packet
//Each packet can only be on a single channel
//The quality of a channel is described as the median of the packet sizes on that channel.The total quality is defined as sum of the quality of all channels(round to integer in case of float). Given the packets[] int32 and channels int32 find the maximum quality.

//Example 1:

//packets := [] int32{1, 2, 3, 4, 5}
//    channels := 2

//// Explaination: If packet {1, 2, 3, 4} is sent to channel 1, the median of that channel would be 2.5.
////               If packet {5} is sent to channel 2 its median would be 5. 
////               Total quality would be 2.5 + 5 = 7.5 ~ 8
//answer := 8
//Example 2:

//packets := [] int32{5, 2, 2, 1, 5, 3}
//channels:= 2

// Explaination: Channel 1: {2, 2, 1, 3} (median: 2)
//               Channel 2: {5, 5}       (median: 5)
//               Total Quality : 2 + 5 = 7

// Explaination 2: Channel 1: {5, 2, 2, 1, 3} (median: 2)
//                 Channel 2: {5}             (median: 5)
//                 Total Quality : 2 + 5 = 7
//answer:= 7


        //amazon OA Sep 5 / 2022  - passed 15 / 15. 
public long maximumQuality(List<int> packets, int channels)
        {
            // Write your code here
            var n = packets.Count;

            double answer = 0;
            if (n == channels)
            {
                for (int i = 0; i < n; i++)
                {
                    answer += packets[i];
                }
                return (long)answer;
            }
            packets.Sort(); // Collections.sort(packets);

            for (int i = n - channels + 1; i < n; i++)
            {
                answer += packets[i];
            }

            n = n - channels;
            if (n % 2 == 0)
            {
                // odd
                answer += packets[n / 2];
            }
            else
            {
                //even
                double value = packets[n / 2] + packets[((n / 2) + 1)];
                answer += value / 2;
            }
            return (long)Math.Ceiling(answer);
        }





        public  void noPrefix(List<string> words)
        {
            var dict = new Dictionary<int, string>();

            for (var i = 0; i < words.Count; i++)
            {
                var starts = words.Where(w => w.StartsWith(words[i]));
                if (starts.Count() > 1)
                {
                    var sl = starts.ToList();
                    var io = words.IndexOf(sl[1]);
                    dict[io] = sl[1];
                }
            }

            if (dict.Count > 0)
            {
                var bs = dict.OrderBy(d => d.Key).Select(d => d.Value).First();
                Console.WriteLine("BAD SET");
                Console.WriteLine(bs);
            }
            else
                Console.WriteLine("GOOD SET");

        }




        public void texteditor()
        {

            var line = Console.ReadLine();
            var sb = new StringBuilder();
            var history = new List<string[]>();
           // var ops = new string[];
            while (!string.IsNullOrEmpty(line))
            {
                var ops = line.Split(' ');
                if (ops[0] == "1")
                {
                    sb.Append(ops[1]);
                    var len = ops[1].Length;
                    history.Add(new string[] { "2", len.ToString() });
                }
                else if (ops[0] == "2")
                {
                    var n = Convert.ToInt32(ops[1]);
                    var str = sb.ToString().Substring(sb.Length - n, n);
                    sb.Remove(sb.Length - n, n);
                    history.Add(new string[] { "1", str });
                }
                else if (ops[0] == "3")
                {
                    var n = Convert.ToInt32(ops[1]);
                    Console.WriteLine(sb.ToString().Substring(n - 1, 1));
                }
                else if (ops[0] == "4")
                {
                    var undoop = history[history.Count - 1];
                    if (undoop[0] == "1")
                    {
                        sb.Append(undoop[1]);

                    }
                    else if (undoop[0] == "2")
                    {
                        var undon = Convert.ToInt32(undoop[1]);
                        var undostr = sb.ToString().Substring(sb.Length - undon, undon);
                        sb.Remove(sb.Length - undon, undon);
                    }
                    history.RemoveAt(history.Count - 1);
                }



                line = Console.ReadLine();
            }


            void append(string op)
            {
                sb.Append(op);
            }

            void delete(string op)
            {
                var undon = Convert.ToInt32(op);
                var undostr = sb.ToString().Substring(sb.Length - undon, undon);
                sb.Remove(sb.Length - undon, undon);
                history.Add(new string[] { "1", undostr });
            }
        }


        //O nlogn
        public int pairs(int k, List<int> arr)
        {
                
            arr.Sort();
            var matches = 0;
            var len = arr.Count;
            for (var i = 0; i < len - 1; i++)
            {
                
                if (arr.BinarySearch(i + 1, len - (i + 1), arr[i] + k, null) > -1)
                    matches++;
            }
             return matches;
        }


        //O n
        public int pairshash(int k, List<int> arr)
        {
            var matches = 0;
            var d = new Dictionary<int, bool>();
            for (var i = 0; i < arr.Count; i++)
                d[arr[i]] = true;

            for (var i = 0; i < arr.Count; i++)
            {
                var target = arr[i];
                if (target - k >= 0 && d.ContainsKey(target - k) && d[target - k])
                    matches++;
                if (target + k <= Int32.MaxValue && d.ContainsKey(target + k) && d[target + k])
                    matches++;
                d[target] = false;
            }
            return matches;
        }



        /*
    * For your reference:
    *
    * SinglyLinkedListNode {
    *     int data;
    *     SinglyLinkedListNode next;
    * }
    *
    */
        public SinglyLinkedListNode mergeLists2(SinglyLinkedListNode head1, SinglyLinkedListNode head2)
        {

            SinglyLinkedListNode node = null;
            SinglyLinkedListNode head = null;

            while (head1 != null || head2 != null)
            {
                if (head1 == null || (head2 != null && head1.data >= head2.data))
                {
                    if (node == null)
                    {
                        node = head2;
                        head = node;
                    }
                    else
                    {
                        node.next = head2;
                        node = node.next;
                        
                    }
                    head2 = head2.next;
                }
                else
                {
                    if (node == null)
                    {
                        node = head1;
                        head = node;
                    }
                    else
                    {
                        node.next = head1;
                        node = node.next;
                        
                    }
                    head1 = head1.next;

                }


            }
            return head;
        }


        /*
            * Complete the 'truckTour' function below.
            *
            * The function is expected to return an INTEGER.
            * The function accepts 2D_INTEGER_ARRAY petrolpumps as parameter.
            */

        public  int truckTour2(List<List<int>> petrolpumps)
        {
            var complete = false;
            var petrol = 0;
            var i = 0;
            var startindex = -1;
            while (!complete)
            {
                petrol += petrolpumps[i][0];
                if (petrolpumps[i][1] > petrol)
                {
                    petrol = 0;
                
                    startindex = -1;

                }
                else
                { 
                    petrol -= petrolpumps[i][1];
                    if (i == startindex)
                        {
                            break;
                        }
                    if (startindex == -1)
                        startindex = i;
                }
                i++;
                if (i == petrolpumps.Count)
                    i = 0;

            }

            return startindex;
        }











        public static List<long> findSum(List<int> numbers, List<List<int>> queries)
        {

            //for (var i = 0; i <)

                return null;
        }







        //basically add all ratio pairs to dictionary then see if there are duplicates or greater and add to results if so as per below


        public  long nearlySimilarRectangles(List<List<long>> sides)
        {
            var rows = sides.Count;
            
            // Initialize the result value and
            // map to store the ratio to the rectangles
            long res = 0;
            Dictionary<double, int> ratio
                = new Dictionary<double, int>();

            // Calculate the rectangular ratio and save them
            for (int i = 0; i < rows; i++)
            {
                double rectRatio
                    = (double)sides[i][0] / sides[i][1];
                if (!ratio.ContainsKey(rectRatio))
                {
                    ratio[rectRatio] = 0;
                }
                ratio[rectRatio] = ratio[rectRatio] + 1;
            }

            // Calculate pairs of similar rectangles from
            // its common ratio
            foreach (KeyValuePair<double, int> p in ratio)
            {
                int val = p.Value;
                if (val > 1)
                {
                    res += (val * (val - 1)) / 2;
                }
            }

            return res;


            //junk:

            //var pairs = 0;
            //for (var i = 0; i < sides.Count - 1; i++)
            //{
            //    for (var j = i + 1; j < sides.Count; j++)
            //    {
            //        var result1 = ((double)sides[i][0] / (double)sides[j][0]);
            //        var result2 = ((double)sides[i][1] / (double) sides[j][1]);

            //        if (result1 == result2)
            //        //if ( (double)(sides[i][0] / sides[j][0]) == (double)(sides[i][1] / sides[j][1]))
            //            pairs++;
            //    }
            //}
            //return pairs;
        }


        public string gridChallenge3(List<string> grid)
        {
            var sorted = new List<string>();

            for (var i = 0; i < grid.Count; i++)
            {
                var cs = grid[i].ToCharArray();
                Array.Sort(cs);

                sorted.Add(new string(cs));
            }

            for (var i = 0; i < sorted.Count - 1; i++)
            {
                for (var j = 0; j < sorted[i].Count(); j++)
                {
                    if ((sorted[i][j] - 'a') > (sorted[i + 1][j] - 'a'))
                        return "NO";
                }
            }

            return "YES";
        }





        public void minimumBribes3(List<int> q)
        {
            var i = 0;
            var swaps = 0;
            for (var j = 0; j < q.Count; j++)
            {
                if ((q[j] - (j + 1) >= 3))
                {
                    Console.WriteLine("Too chaotic");
                    return;
                }
            }
            while (i < q.Count - 1)
            {
                if (q[i] > q[i + 1])
                {
                    var temp = q[i];
                    q[i] = q[i + 1];
                    q[i + 1] = temp;
                    swaps++;
                    i--;
                    if (i < 0)
                        i = 0;
                }
                else
                    i++;

            }
            Console.WriteLine(swaps); 
        }






        public string caesarCipher(string s, int k)
        {
            var r = s[0] + 1;

            //Console.WriteLine(s[0] + ": " + r);
            var sb = new StringBuilder();
            foreach (var c in s)
            {
                if ((c > 'Z' && c < 'a') || c > 'z' || c < 'A')
                {
                    sb.Append(c);
                }
                else
                {
                    var shifted = new char();

                    if (c >= 'a')
                    {
                        shifted = (char)('a' + (c - 'a' + k) % 26);
                        
                    }
                    else
                    {
                        shifted = (char)('A' + (c - 'A' + k) % 26);
                    }
                    Console.WriteLine(shifted);
                    sb.Append(shifted);
                }
            }

            return sb.ToString();
        }






        /* Imagine we have a page that displays logs from our website in a table. Given these logs, write a function that tests whether a one URL
is linked to another URL, even if it take more than one link to get there. For example:

areURLsLinked("/", "/search") => true
areURLsLinked("/", "/reviews") => true
areURLsLinked("/", "/robots.txt") => false

#
# URL            Session ID                           Timestamp      Referrer
#
# /              C4CA4238A0B923820DCC509A6F75849B     1625153267     NULL
# /              C4CA4238A0B923820DCC509A6F75849B     1625153254     /
# /search        C4CA4238A0B923820DCC509A6F75849B     1625153298     /
# /detail        C4CA4238A0B923820DCC509A6F75849B     1625153298     /search
# /reviews       C4CA4238A0B923820DCC509A6F75849B     1625153298     /detail
# /help          ECCBC87E4B5CE2FE28308FD9F2A7BAF3     1625153314     /
# /              ECCBC87E4B5CE2FE28308FD9F2A7BAF3     1625153320     /search
# /cart          C4CA4238A0B923820DCC509A6F75849B     1625153325     /detail
# /cart          ECCBC87E4B5CE2FE28308FD9F2A7BAF3     1625153332     /search
# /robots.txt    C81E728D9D4C2F636F067F89CC14862C     1625153340     NULL

*/
        //Javascript attempt.  Need to finish.  Try in C#
        //    class Urls
        //    {
        //        url: string
        //        SessionID: string,
        //Timestatmp,
        //Referrer
        //    }

        //    function areURLsLinked(url1, url2)
        //    {

        //        let alreadyvisited = [];
        //        for (let i = 0; i < urls.length; i++)
        //        {
        //            if (urls[i].Referrer === url1)
        //            {
        //                if (urls[i].URL === url2)
        //                {
        //                    return true;
        //                }
        //                else
        //                {
        //                    return areURLsLInked(urls[i].URL, url2);

        //                }

        //            }


        //        }

        //        return false;
        //    }



        public  List<string> processLogs(List<string> logs, int threshold)
        {



           
                var results = new List<string>();

                var hash = new Dictionary<string, int>();

            for (var i = 0; i < logs.Count; i++)
            {
                var l = logs[i].Split(' ');

                // Console.Write(l[0] + " " + l[1]);
                //  Console.WriteLine();
                if (!hash.ContainsKey(l[0]))
                {
                    hash[l[0]] = 1;
                }
                else
                    hash[l[0]]++;
                if (hash[l[0]] == threshold)
                    results.Add(l[0]);

                if (l[0] != l[1])
                {
                    if (!hash.ContainsKey(l[1]))
                    {
                        hash[l[1]] = 1;
                    }
                    else
                        hash[l[1]]++;
                    if (hash[l[1]] == threshold)
                        results.Add(l[1]);
                }
               

            }


            return results;




            //        Console.WriteLine("threshold: " + threshold);
            ////var results = new List<string>();

            //var hash = new Dictionary<string, int>();

            //foreach (var log in logs)
            //{
            //    var l = log.Split(' ');

            //    Console.Write(l[0] + " " + l[1]);
            //    Console.WriteLine();
            //    if (!hash.ContainsKey(l[0]))
            //        hash[l[0]] = 1;
            //    else
            //        hash[l[0]]++;

            //    if (l[0] != l[1])
            //    {
            //        if (!hash.ContainsKey(l[1]))
            //            hash[l[1]] = 1;
            //        else
            //            hash[l[1]]++;
            //    }

            //}

            //foreach (var h in hash.OrderByDescending(h => h.Value))
            //{
            //    Console.WriteLine(h.Key + ": " + h.Value);
            //}


            //var keys = hash.Where(h => h.Value >= threshold).Select(h => h.Key).OrderBy(h => h).ToList();
            //return keys;
        }










        public bool ValidURLPath(int n, string[][] edges, string start, string end)
        {

            var hash = new Dictionary<string, int>();

            var a = hash.Where(h => h.Value > 2).Select(h => h.Key);




            var graph = new Dictionary<string, List<string>>();
            foreach(var edge in edges)
            {
                if (!graph.ContainsKey(edge[0]))
                    graph[edge[0]] = new List<string>();
                graph[edge[0]].Add(edge[1]);

                if (!graph.ContainsKey(edge[1]))
                    graph[edge[1]] = new List<string>();
                graph[edge[1]].Add(edge[0]);

            }
            var visited = new Dictionary<string, bool>();
            foreach(var key in graph.Keys)
            {
                visited[key] = false;
            }
            return URLDfs(graph, start, end, visited);
        }


        private bool URLDfs(Dictionary<string, List<string>> graph, string start, string end, Dictionary<string, bool> visited)
        {
            if (start == end)
                return true;
            visited[start] = true;
            foreach (var node in graph[start])
            {
                if (!visited[node])
                {
                    if (URLDfs(graph, node, end, visited))
                        return true;
                }
            }
            return false;
        }


            public bool ValidPath(int n, int[][] edges, int start, int end)
        {

            List<int>[] graph = new List<int>[n];

            for (var i = 0; i < n; i++)
            {
                graph[i] = new List<int>();
            }

            foreach (var edge in edges)
            {
                graph[edge[0]].Add(edge[1]);
                graph[edge[1]].Add(edge[0]);
            }

            bool[] visited = new bool[n];
            if (urldfs(graph, start, end, visited))
                return true;

            return false;

        }



        private bool urldfs(List<int>[] graph, int start, int end, bool[] visited)
        {
            if (start == end)
                return true;
            visited[start] = true;
            foreach (var next in graph[start])
            {
                if (!visited[next])
                {
                    if (urldfs(graph, next, end, visited))
                        return true;
                }
            }
            return false;
        }



            //   fastest.

            public int RemoveElement5(int[] nums, int val)
        {
            int i = -1;
            for (var j = 0; j < nums.Length; j++)
                if (nums[j] != val)
                    nums[++i] = nums[j];

            return i + 1;

        }




        public int RemoveElement4(int[] nums, int val)
        {
            var l = 0;
            var len = nums.Length;
            var r = len - 1;
            var k = len - nums.Where(n => n == val).Count();
            
            while (l <= r && l <= len - 1  && r >= 0)
            {
                if (nums[l] != val)
                    l++;
                else if (nums[r] == val)
                    r--;
                else if (nums[l] == val && nums[r] != val)
                {
                    nums[l] = nums[r];
                  
                    l++;
                    r--;
                }


            }
            return k;
        }
    






























    public bool BuddyStrings3(string s, string goal)
        {
            //add code to test dupe and equal strings like a 3rd dict.


            if (s.Length != goal.Length)
                return false;

            //var firstchar = s[0];
            var allequal = s == goal;
            var dicts = new Dictionary<char, int>();
            var dictgoal = new Dictionary<char, int>();
            var dictequal = new Dictionary<char, int>();

            var ha = new HashSet<int>();
            for (var i = 0; i < s.Length; i++)
            {
               
                if (s[i] != goal[i])
                {
                    if (!dicts.ContainsKey(s[i]))
                    {
                        dicts.Add(s[i], 1);
                    }
                    else
                        
                        return false;

                    if (!dictgoal.ContainsKey(goal[i]))
                    {
                        dictgoal.Add(goal[i], 1);
                    }
                    else
                       
                        return false;

                    if (dicts.Count > 2 || dictgoal.Count > 2)
                        return false;
                }
                else
                {
                    if (!dictequal.ContainsKey(s[i]))
                        dictequal.Add(s[i], 1);
                    else
                        dictequal[s[i]]++;
                }
                    



            }
            var dupes = dictequal.OrderByDescending(d => d.Value).FirstOrDefault().Value;
            
            var matches = dicts.Where(k => dictgoal.Any(d => d.Key == k.Key)).Count();
          
            if (matches == 2 || (allequal && dupes >= 2))
                return true;
            else
                return false;


        }



        public long getHeaviestPackage(List<int> packageWeights)
        {


            // long heaviest = 0;
            List<long> longweights = packageWeights.Select(p => Convert.ToInt64(p)).ToList();
            //foreach (var w in longweights)
            //Console.WriteLine(w);

            var list = new SinglyLinkedListNodeLong(Convert.ToInt64(packageWeights[0]));
            var head = list;

            for (var i = 1; i < packageWeights.Count; i++)

            {
                list.data = packageWeights[i];
                list.next = new SinglyLinkedListNodeLong(packageWeights[i]);
                list = list.next;
            }


            while (true)
            {
                long maxweight = 0;
                var maxindex = -1;
                long first = -1;
                long second = -1;
                for (var i = 0; i < longweights.Count - 1; i++)
                {
                    if (longweights[i] != 0 && first == -1)
                    {
                        first = longweights[i];
                        continue;
                    }
                    else
                        second = longweights[i];


                    if (first < second)
                    {
                        if (first + second > maxweight)
                        {
                            maxweight = first + second;
                            maxindex = i;
                            first = -1;
                            second = -1;
                        }
                        else
                        {
                            first = -1;
                            second = -1;
                        }
                    }
                }

                //foreach (var w in longweights)
                //    Console.WriteLine(w);

                //Console.WriteLine("end");

                if (maxindex != -1)
                {
                    longweights[maxindex + 1] += longweights[maxindex];
                    //  heaviest = Math.Max(heaviest, longweights[maxindex + 1]);
                    longweights.RemoveAt(maxindex);


                }
                else
                    break;

            }

            return longweights.Max();







            //results.Sort();
            //var list = new SinglyLinkedListNode(results[0]);
            //var head = list;

            //for (var i = 1; i < results.Count; i++)
            //{

            //    list.next = new SinglyLinkedListNode(results[i]);
            //    list = list.next;
            //}








            //while (true)
            //{
            //    long maxweight = 0;
            //    var maxindex = -1;
            //    long first = -1;
            //    long second = -1;
            //    var i = 0;
            //    while(i < longweights.Count)
            //    {
            //        if (longweights[i] != 0 && first == -1)
            //        {
            //            first = longweights[i];
            //            i++;
            //            continue;
            //        }
            //        else if (longweights[i] != 0 && first > 0)
            //            second = longweights[i];


            //        if (first < second)
            //        {
            //            if (first + second > maxweight)
            //            {
            //                maxweight = first + second;
            //                maxindex = i-1;


            //            }


            //        }
            //        first = -1;
            //        second = -1;
            //    }

            //    //foreach (var w in longweights)
            //    //    Console.WriteLine(w);

            //    //Console.WriteLine("end");

            //    if (maxindex != -1)
            //    {
            //        longweights[maxindex + 1] += longweights[maxindex];
            //        //  heaviest = Math.Max(heaviest, longweights[maxindex + 1]);
            //        //longweights.RemoveAt(maxindex);
            //        longweights[maxindex] = 0;

            //    }
            //    else
            //        break;

            //}

            //return longweights.Max();

        }

        public  long getHeaviestPackage2(List<int> packageWeights)
        {
            long heaviest = 0;
            List<long> longweights = packageWeights.Select(p => Convert.ToInt64(p)).ToList();
            while (true)
            {
                long maxweight = 0;
                var maxindex = -1;
                for (var i = 0; i < longweights.Count - 1; i++)
                {
                    if (longweights[i] < longweights[i + 1])
                    {
                        if (longweights[i] + longweights[i + 1] > maxweight)
                        {
                            maxweight = longweights[i] + longweights[i + 1];
                            maxindex = i;
                        }
                    }
                }
                if (maxindex != -1)
                {
                    longweights[maxindex + 1] += longweights[maxindex];
                    heaviest = Math.Max(heaviest, longweights[maxindex + 1]);
                    longweights.RemoveAt(maxindex);

                }
                else
                    break;

            }

            return longweights.Max();
        }







        private void AddEdges2(List<List<int>> graph, List<List<int>> edges)
        {
            foreach (var edge in edges)
            {

                graph[edge[0]].Add(edge[1]);
                graph[edge[1]].Add(edge[0]);
            }


        }

        public List<int> bfs(int n, int m, List<List<int>> edges, int s)
        {
            var graph = new List<List<int>>();
            for (var j = 0; j <= n; j++)
            {
                graph.Add(new List<int>());
            }
            AddEdges2(graph, edges);



            var edgedistance = 6;
            var distances = new int[n+1];
            for (var i = 0; i < distances.Length; i++)
            {
                distances[i] = -1;
            }


            var queue = new Queue<int>();
            queue.Enqueue(s);

            distances[s] = 0;
            while (queue.Count > 0)
            {
                var node = queue.Dequeue();

                foreach (var neighbour in graph[node])
                {
                    if (distances[neighbour] == -1)
                    {
                        distances[neighbour] = distances[node] + edgedistance;
                        queue.Enqueue(neighbour);
                    }

                }


            }

            var k = s > 1 ? 1: 2;
            var results = new List<int>();
            var count = 0;
            while (count < n-1)
            {
                if (k != s)
                {
                    results.Add(distances[k]);
                    count++;
                }

                k++;
                if (k > n )
                    k = 0;
            }

            return results;

        }







        public SinglyLinkedListNode mergeLists(SinglyLinkedListNode head1, SinglyLinkedListNode head2)
            {
            var results = new List<int>();
        
                while (head1 != null || head2 != null)
                {
                    if (head1 != null)
                    {
                        results.Add(head1.data);
                        head1 = head1.next;
                    }

                    if (head2 != null)
                    {
                        results.Add(head2.data);
                        head2 = head2.next;
                    }



                //var h1v = head1 != null ? head1.data : 0;
                //    var h2v = head2 != null ? head2.data : 0;
                //    if (h1v != 0 && h2v != 0)
                //    {
                //        if (h1v < h2v)
                //        {
                //            if (list.data == -1)
                //            {
                //                list.data = h1v;
                //                list.next = new SinglyLinkedListNode(h2v);
                //                list = list.next;
                //            }
                //            else
                //            {
                //                list.next = new SinglyLinkedListNode(h1v);
                //                list = list.next;
                //                list.next = new SinglyLinkedListNode(h2v);
                //                list = list.next;
                //            }


                //        }
                //        else
                //        {
                //            if (list.data == -1)
                //            {
                //                list.data = h2v;
                //                list.next = new SinglyLinkedListNode(h1v);
                //                list = list.next;
                //            }
                //            else
                //            {
                //                list.next = new SinglyLinkedListNode(h2v);
                //                list = list.next;
                //                list.next = new SinglyLinkedListNode(h1v);
                //                list = list.next;
                //            }
                //        }
                       

                //    }

                //    else if (h1v != 0)
                //    {
                //        if (list.data == -1)
                //        {
                //            list.data = h1v;
                //        }
                //        else
                //        {
                //            list.next = new SinglyLinkedListNode(h1v);
                //            list = list.next;
                //        }

                //    }
                //    else
                //    {
                //        if (list.data == -1)
                //        {
                //            list.data = h2v;
                //        }
                //        else
                //        {
                //            list.next = new SinglyLinkedListNode(h2v);
                //            list = list.next;
                //        }
                //    }

                //if (head1 != null) head1 = head1.next;
                //if (head2 != null) head2 = head2.next;


                }
                results.Sort();
                var list = new SinglyLinkedListNode(results[0]);
                var head = list;
            
                for (var i = 1; i < results.Count; i++)
                {

                    list.next = new SinglyLinkedListNode(results[i]);
                    list = list.next;
                }

                return head;


            }



            public int truckTour(List<List<int>> petrolpumps)
        {
            var petrol = 0;
            var count = 0;
            var len = petrolpumps.Count;
            var i = 0;
            var start = -1;
            while (count < len)
            {
                petrol += petrolpumps[i][0];
                if (petrolpumps[i][1] > petrol)
                {
                    petrol = 0;
                    count = 0;
                    start = -1;
                }
                else
                {
                    if (start == -1)
                        start = i;
                    count++;
                    petrol -= petrolpumps[i][1];
                }
                i++;
                if (i == len)
                    i = 0;
            }
            return start;
        }



        public void minimumBribes2(List<int> q)
        {
            
            

                var i = 0;
                var swaps = 0;

                for (var j = 0; j < q.Count; j++)
                {
                    if (q[j] - (j + 1) > 2)
                    {
                        Console.WriteLine("Too chaotic");
                        return;
                    }

                }
                while (i < q.Count - 1)
                {
                    if (q[i + 1] < q[i])
                    {
                        var temp = q[i];
                        q[i] = q[i + 1];
                        q[i + 1] = temp;
                        swaps++;
                        i = (i == 0 ? 0 : i - 1);
                        continue;
                    }
                    i++;
                }
                Console.WriteLine(swaps);
        }


        public int superDigit2(string n, int k)
        {
            var sb = new StringBuilder();
            for (var i = 1; i <= k % 9; i++)
            {
                sb.Append(n);
            }
            if (sb.Length == 1)
                return Convert.ToInt32(sb.ToString());

            
            while (sb.Length > 1)
            {
                long sum = 0;
                for (var i = 0; i < sb.Length; i++)
                {
                    sum += sb[i] - '0';
                }
                sb.Clear();
                sb.Append(sum);
            }

            return Convert.ToInt32(sb.ToString());
        }

public int superDigit(string n, int k)
        {
            var newstring = "";
            for (var i = 1; i <= k; i++)
            {
                newstring += n;
            }


            return recurse(newstring);
        }

        private int recurse(string n)
        {
            if (n.Length == 1)
                return Convert.ToInt32(n);

            var sum = 0;
            foreach (var c in n)
            {
                sum += c - '0';
            }
            var newnumber = sum.ToString();
            return recurse(newnumber);
        }


        public  string gridChallenge(List<string> grid)
        {
            for (var i = 0; i < grid.Count; i++)
            {
                grid[i] = new string(grid[i].OrderBy(l => l).ToArray());
            }

            // var ascending = true;
            for (var i = 0; i < grid[0].Count(); i++)
            {
                //Console.WriteLine(line);
                for (var j = 0; j < grid.Count - 1; j++)
                {
                    if (grid[j + 1][i] < grid[j][i])
                    {
                        return "NO";
                    }

                }
            }

            return "YES";
        }


        public int palindromeIndex(string s)
        {
            var start = 0;
            var end = s.Length - 1;
            while (start < end)
            {
                if (s[start] != s[end])
                {
                    if (isPalindrome(s, start, end - 1))
                        return end;
                    else if (isPalindrome(s, start + 1, end))
                        return start;
                    else
                        break;
                }
                start++;
                end--;
            }
            return -1;
        }

        private bool isPalindrome(string s, int start, int end)
        {
            while (start < end)
            {
                if (s[start] != s[end])
                    return false;
                start++;
                end--;

            }
            return true;
        }





        public static int flippingMatrix(List<List<int>> matrix)
        {
            //1) find the n largest elements
            // 2)
            var n = matrix.Count / 2;
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    sum += (int)Math.Max(Math.Max(matrix[i][j], matrix[i][2 * n - j -
                    1]), Math.Max(matrix[2 * n - i - 1][j], matrix[2 * n - i - 1][2 * n - j - 1]));
                }
            }
            return sum;
        }



        public string AddStrings3(string num1, string num2)
        {

            var carry = 0;
            var l = num1.Length - 1;
            var r = num2.Length - 1;
            var sb = new StringBuilder();
            while (l >= 0 || r >= 0 || carry > 0)
            {
                var n1 = (l >= 0 ? num1[l] : '0') - '0';
                var n2 = (r >= 0 ? num2[r] : '0') - '0';
                var sum = n1 + n2 + carry;
                sb.Insert(0, sum % 10);
                carry = sum / 10;
                l--;
                r--;
            }

            return sb.ToString();

        }



        public string[] texteditor(string[][] queries)
        {
            var results = new List<string>();
            var result = new StringBuilder();
            var stack = new Stack<string>();
            var cursor = 0;
           
            var right = 0;
            var copied = "";
            foreach (var q in queries)
            {
                for (var i = 0; i < q.Length; i++)
                {
                    var op = q[i];
                    Console.WriteLine(op);

                    var len = op.Length;
                    if (op == "APPEND")
                    {
                        if (copied.Length > 0)
                            result.Remove(cursor, right - cursor);
                        if (cursor < result.Length - 1)
                            result.Insert(cursor, q[i + 1]);
                        else
                            result.Append(q[i + 1]);
                        cursor = result.Length - 1;
                        results.Add(result.ToString());
                    }


                    else if (op == "MOVE")
                    {
                        cursor = cursor > result.Length - 1 ? result.Length - 1 : Convert.ToInt32(q[i + 1]);
                        results.Add(result.ToString());
                    }
                    else if (op == "BACKSPACE")
                    {
                        if (copied.Length > 0)
                            result.Remove(cursor, right - cursor);
                        if (cursor > 0 && cursor < result.Length)
                        {
                            result.Remove(cursor, 1);
                            cursor--;
                        }
                        results.Add(result.ToString());
                    }
                    else if (op == "SELECT")
                    {
                        cursor = Convert.ToInt32(q[i + 1]);
                        right = Convert.ToInt32(q[i + 2]);
                        results.Add(result.ToString());

                    }

                    else if (op == "COPY")
                    {
                        copied = result.ToString().Substring(cursor, right - cursor);
                        results.Add(result.ToString());
                    }

                    else if (op == "MOVE")
                    {
                        copied = "";
                    }


                }
            }
            return results.ToArray();
        }




        public long findTotalImbalance(List<int> rank)
        {
            var imbalance = 0;

            var len = rank.Count;
            if (len == 1)
                return 0;


            for (var count = 2; count <= len; count++)
            {
                for (var i = 0; i <= len - count; i++)
                {


                    var arr = rank.GetRange(i, count);
                    arr.Sort();
                    for (var j = 0; j < count - 1; j++)
                    {
                        if (arr[j + 1] - arr[j] > 1)
                            imbalance++;
                    }

                }
            }

            return imbalance;
        }











        public static IEnumerable<(T, T)> GetAllPairs<T>(IList<T> source)
        {
            return source.SelectMany((_, i) => source.Where((_, j) => i < j),
                (x, y) => (x, y));
        }

        public int countFamilyLogins(List<string> logins)
        {
            var count = 0;
            var len = logins.Count;


            foreach ((string x, string y) in GetAllPairs(logins))
            {
                // Execute code
                Console.WriteLine($"Pair: {x}, {y}");
                var equal = true;
                for (var k = 0; k < x.Length; k++)
                {
                    if (x[k] != (Char)(Convert.ToUInt16(y[k]) + 1)
                    && y[k] != (Char)(Convert.ToUInt16(x[k]) + 1))
                    {
                        equal = false;
                        break;
                    }
                }
                if (equal)
                    count++;


            }




            //for (var i = 0; i < len - 1; i++)
            //{
            //    for (var j = i + 1; j < len; j++)
            //    {
            //        var equal = true;
            //        for (var k = 0; k < logins[i].Length; k++)
            //        {
            //            if (logins[i][k] != (Char)(Convert.ToUInt16(logins[j][k]) + 1)
            //            || logins[j][k] != (Char)(Convert.ToUInt16(logins[i][k]) + 1))
            //            {
            //                equal = false;
            //                break;
            //            }
            //        }
            //        if (equal)
            //            count++;

            //    }
            //}
            return count;


    }




        public static void plusMinus(List<int> arr)
        {
            Decimal positive = 0;
            Decimal negative = 0;
            Decimal zero = 0;
            for (var i = 0; i < arr.Count; i++)
            {
                if (arr[i] > 0)
                    positive++;
                else if (arr[i] == 0)
                    zero++;
                else if (arr[i] < 0)
                    negative++;
            }
            Console.WriteLine((positive / arr.Count).ToString("N6"));
            Console.WriteLine((negative / arr.Count).ToString("N6"));
            Console.WriteLine((zero / arr.Count).ToString("N6"));

        }



        //Amazon SDE Online assessment Question 1.  Passed most test cases, but came up with solution at last minute:

        public  int countMaximumTeams(List<int> skill, int teamSize, int maxDiff)
        {
            var len = skill.Count;
            skill.Sort();
            
          //  var maxcount = 0;
            //  for (var i = 0; i <= len - teamSize; i++)
            //   {
            //var i = 0;
                var start = 0;
                var end  = 1;
                var size = 1;
                var count = 0;
                while (end <= len)
                {
                    if (size == teamSize)
                    {
                        count++;
                        if (end == len || len - end < teamSize)
                            break;
                        size = 1;
                        start = end;
                        end = start + 1;
                    }

                    if (end < len && Math.Abs(skill[start] - skill[end]) > maxDiff)
                    {
                        start++; // += teamSize;
                        end = start + 1;
                        size = 1;
                        continue;
                        
                    }
                    end++;
                    size++;
                }
                //maxcount = Math.Max(maxcount, count);
            //   if (maxcount == skill.Count / teamSize)
            //       return maxcount;

            // }


            return count; 
        }













        public string timeConversion(string s)
        {
            var hh = Convert.ToInt32(s.Substring(0, 2));
            var mm = s.Substring(3, 2);
            var ss = s.Substring(6, 2);
            var am = s.Substring(8, 2) == "AM";

            if (am && hh == 12)
                hh = 0;
            else if (!am && hh < 12)
                hh += 12;

            var sb = new StringBuilder();
            var hs = hh.ToString("00");
            sb.Append(hs);
            sb.Append(":");
            sb.Append(mm);
            sb.Append(":");
            sb.Append(ss);

            Console.WriteLine(sb.ToString());
            return sb.ToString();
        }


            public int foo(List<string> codeList, List<string> shoppingCart)
        {


            var hh = 0;

            var hs = hh.ToString("%010d");

            var codes = codeList[0].Split(' ');
            var row = 0;
            var col = 0;


            for (var i = 0; i < shoppingCart.Count; i++)
            {
                if (codes[col] == shoppingCart[i] || codes[col] == "anything")
                {
                    col++;
                    if (col == codes.Length)
                    {
                        col = 0;
                        row++;
                        if (row == codeList.Count)
                            return 1;
                        codes = codeList[row].Split(' ');
                    }
                }
                else
                {
                    col = 0;
                }
            }
    
        return 0;

    }


    public int TotalFruit2(int[] tree)
        {
            if (tree.Length == 0) return 0;
            int fruit1 = tree[0];
            int fruit2 = -1;
            int res = 1;
            int cur = 1;
            int start = 0;
            for (int i = 1; i < tree.Length; i++)
            {
                if (tree[i] == fruit1 || tree[i] == fruit2) cur++;
                else
                {
                    res = Math.Max(res, cur);
                    fruit1 = tree[i - 1];
                    fruit2 = tree[i];
                    cur = i - start + 1;
                }
                if (tree[i] != tree[i - 1]) start = i;
            }
            return Math.Max(res, cur);
        }




        public int NumUniqueEmails2(string[] emails)
        {

            var results = new List<string>();
            for (var i = 0; i < emails.Length; i++)
            {
                var sb = new StringBuilder();
                var isdomainname = false;
                var isplus = false;
                for (var j = 0; j < emails[i].Length; j++)
                {
                    var c = emails[i][j];
                    if (!isdomainname)
                    {
                        if (c == '@')
                        {
                            isdomainname = true;
                            sb.Append(c);
                        }
                        else if (c == '.' || isplus)
                            continue;
                        else if (c == '+')
                            isplus = true;
                       
                        else
                            sb.Append(c);

                    }
                    else
                    {
                        sb.Append(c);
                    }
                }

                if (!results.Contains(sb.ToString()))
                    results.Add(sb.ToString());


            }


            foreach (var e in results)
                Console.WriteLine(e);

            return results.Count();

        }




        public int WidthOfBinaryTree(TreeNode root)
        {
            List<int> lefts = new List<int>();
            return DFS(root, 1, 0, lefts);
        }

        private int DFS(TreeNode n, int id, int d, List<int> lefts)
        {
            if (n == null)
                return 0;

            if (d >= lefts.Count)
                lefts.Add(id);

            return Math.Max(id + 1 - lefts[d],
                            Math.Max(DFS(n.left, id * 2, d + 1, lefts),
                                     DFS(n.right, id * 2 + 1, d + 1, lefts))
                           );

        }

        public IList<IList<int>> Generate2(int numRows)
        {
            var results = new List<IList<int>>();
            results.Add(new List<int>() { 1 });
            if (numRows == 1)
                return results;
            else 
            {
                results.Add(new List<int>() { 1, 1 });
               
            }

            if (numRows == 2)
                return results;
            for (var i = 2; i < numRows; i++)
            {
                var result = new List<int>();
                for (var j = 0; j <= i; j++)
                {
                    if (j == 0 || j == i)
                        result.Add(1);
                    else
                    {
                        var n = results[i - 1][j - 1] + results[i - 1][j];
                        result.Add(n);
                    }
                }
                results.Add(result);

            }
            return results;
        }





        int sum3 = 0;
        public int SumOfLeftLeaves3(TreeNode root)
        {
            if (root == null)
                return 0;

            DFS3(root);
            return sum;

        }



        private void DFS3(TreeNode root)
        {
            if (root == null)
                return;
            if (root.left != null && root.left.left == null && root.left.right == null)
            {
                sum += root.left.val;
                DFS3(root.right);
            }
            else
            {
                DFS3(root.left);
                DFS3(root.right);

            }


        }







        public IList<string> CommonChars3(string[] words)
        {
            var results = new List<string>();
            var dicts = new List<Dictionary<char, int>>();

            var lists = new List<List<string>>();

            lists.Add(new List<string>(new string[] { "Test1", "Test2", "Test3" }));
            lists.Add(new List<string>(new string[] { "Test1", "Test2", "Test4" }));
            lists.Add(new List<string>(new string[] { "Test1", "Test2", "Test5" }));
            lists.Add(new List<string>(new string[] { "Test1", "Test2", "Test6" }));


            var listc = new List<List<char>>();

            foreach (var w in words)
                listc.Add(new List<char>(w));
            


            var aggregate = listc.Aggregate((x, y) => x.Intersect(y).ToList());

            var aggregate2 = listc.Aggregate((x, y) => x.Where(y.Remove).ToList()); 

            //find intersection including dupes!!




            // var lists = words.ToList();
            // var ints = lists.IntersectAll();

            //  foreach (var i in ints)
            //       Console.WriteLine(i);


            for (var i = 0; i < words.Length; i++)
            {
                var dict = new Dictionary<char, int>();
                for (var j = 0; j < words[i].Length; j++)
                {
                    if (!dict.ContainsKey(words[i][j]))
                        dict.Add(words[i][j], 1);
                    else
                        dict[words[i][j]]++;
                }
            }


            for (var i = 0; i < dicts.Count; i++)
            {


            }

            return results;
        }










        //Leetcode medium.  But, was easy LOL
        //public IList<IList<int>> FindSolution(CustomFunction customfunction, int z)
        //{

        //    var results = new List<IList<int>>();

        //    Console.WriteLine(customfunction.f(0, 0));

        //    Console.WriteLine(z);

        //    for (var x = 1; x <= z; x++)
        //    {
        //        for (var y = z; y > 0; y--)
        //        {
        //            if (customfunction.f(x, y) == z)
        //                results.Add(new List<int>() { x, y });
        //        }
        //    }

        //    return results;
        //}





        public int MinReorder(int n, int[][] connections)
        {

            var dict = new Dictionary<int, HashSet<int>[]>();
            foreach (var connection in connections)
            {
                var u = connection[0];
                var v = connection[1];
                if (!dict.ContainsKey(u))
                    dict.Add(u, new HashSet<int>[] { new HashSet<int>(), new HashSet<int>() });
                dict[u][0].Add(v);
                if (!dict.ContainsKey(v))
                    dict.Add(v, new HashSet<int>[] { new HashSet<int>(), new HashSet<int>() });
                dict[v][1].Add(u);
            }
            return DFS(dict, 0, new HashSet<int>());
        }


        private int DFS(Dictionary<int, HashSet<int>[]> dict, int current, HashSet<int> visited)
        {
            var result = 0;
            if (dict.Count == visited.Count)
                return 0;
            visited.Add(current);
            foreach (var next in dict[current][0])
            {
                if (visited.Add(next))
                    result += 1 + DFS(dict, next, visited);
            }

            foreach (var next in dict[current][1])
            {
                if (visited.Add(next))
                    result += DFS(dict, next, visited);
            }
            return result;
        }


        ////Study graphs, as you should be able to do this one in 20 minutes;
        //public int MinReorder(int n, int[][] connections)
        //{
        //    var visited = new HashSet<int>();

        //    var graph = new Dictionary<int, HashSet<int>[]>();
        //    for (var i = 0; i < connections.Length; i++)
        //    {
        //        var u = connections[i][0];
        //        var v = connections[i][1];
        //        if (!graph.ContainsKey(u))
        //            graph.Add(u, new HashSet<int>[] { new HashSet<int>(), new HashSet<int>() });
        //        graph[u][0].Add(v);

        //        if (!graph.ContainsKey(v))
        //            graph.Add(v, new HashSet<int>[] { new HashSet<int>(), new HashSet<int>() });
        //        graph[v][1].Add(u);

        //    }


        //    return DFS(graph, 0, visited);
        //}


        //private int DFS(Dictionary<int, HashSet<int>[]> graph, int current, HashSet<int> visited)
        //{
        //    var result = 0;
        //    if (visited.Count == graph.Count)
        //        return result;
        //    visited.Add(current);
        //    foreach (var next in graph[current][0])
        //        if (visited.Add(next))
        //            result += 1 + DFS(graph, next, visited);

        //    foreach (var next in graph[current][1])
        //        if (visited.Add(next))
        //            result += DFS(graph, next, visited);
        //    return result;

        //}






        //Go through this!! to understand all solutions:
        // https://leetcode.com/problems/generate-parentheses/solution/
        //Leet code 
        public List<string> generateParenthesis(int n)
        {
            List<string> combinations = new List<string>();
            generateAll(new char[2 * n], 0, combinations);
            return combinations;
        }

        public void generateAll(char[] current, int pos, List<string> result)
        {
            if (pos == current.Length)
            {
                if (valid(current))
                    result.Add(new string(current));
            }
            else
            {
                current[pos] = '(';
                generateAll(current, pos + 1, result);
                current[pos] = ')';
                generateAll(current, pos + 1, result);
            }
        }



        public bool valid(char[] current)
        {
            int balance = 0;
            foreach (var c in current)
            {
                if (c == '(') balance++;
                else balance--;
                if (balance < 0) return false;
            }
            return (balance == 0);
        }


        public string[] ReorderLogFiles(string[] logs)
        {

            var letterlogs = new List<string>();
            var digitlogs = new List<string>();

            for (var i = 0; i < logs.Length; i++)
            {
                var log = logs[i].Split(' ');
                if (BigInteger.TryParse(log[1], out _))
                    digitlogs.Add(logs[i]);
                else
                    letterlogs.Add(logs[i]);
            }

            letterlogs = letterlogs.OrderBy(l => l.Substring(l.IndexOf(' ') + 1)).ThenBy(l => l.Split(' ')[0]).ToList();

//            letterlogs = letterlogs.OrderBy(l => l[(l.IndexOf(' ') + 1)..]).ThenBy(l => l.Split(' ')[0]).ToList();


            letterlogs.AddRange(digitlogs);
            return letterlogs.ToArray();

        }



        public bool CanReach(int[] arr, int start)
        {

            var visited = new bool[arr.Length];
            var queue = new Queue<int>();



            queue.Enqueue(start);
            visited[start] = true;

            while (queue.Count > 0)
            {
                var current = queue.Dequeue();
                if (arr[current] == 0)
                    return true;

                var next = current + arr[current];
                if (next >= 0 && next < arr.Length && visited[next] == false)
                {
                    visited[next] = true;
                    queue.Enqueue(next);
                }


                next = current - arr[current];
                if (next >= 0 && next < arr.Length && visited[next] == false)
                {
                    visited[next] = true;
                    queue.Enqueue(next);
                }



            }

            return false;

        }

        public int FirstMissingPositive(int[] nums)
        {
            Array.Sort(nums);
            var missing = 1;
            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] <= 0)
                    continue;
                if (nums[i] == missing)
                {
                    missing++;
                }
                else if (nums[i] == missing + 1)
                    return missing;
            }
            return missing;
        }





        //Check whether length is even then has to be at least 2 of each character. if odd then only one char can be unique.
        private bool IsValidPalindrome(string str)
        {
            var isodd = str.Length % 2 == 1;
            var dict = new Dictionary<char, int>();
            for (var i = 0; i < str.Length; i++)
            {
                if (!dict.ContainsKey(str[i]))
                    dict.Add(str[i], 1);
                else
                    dict[str[i]]++;
            }

            var oneodd = false;
            for (var j = 0; j < dict.Count; j++)
            {
                if (dict.ElementAt(j).Value % 2 == 1)
                {
                    if (oneodd == true)
                        return false;
                    else
                        oneodd = true;
                }
            }
            return true;

        }


        public int MinSwapsPalindrome(string str)
        {
            var len = str.Length;
            if (str.Length <= 1)
                return 0;

            if (!IsValidPalindrome(str))
                return -1;
            var strarr = str.ToCharArray();
            var count = 0;
            var isodd = (strarr.Length % 2) == 1;
           
            
            
            for (var i = 0; i < len / 2; i++)
            {
                var right = len - i - 1;

                while (right > i)
                {
                    if (strarr[i] == strarr[right])
                        break;
                    else
                        right--;
                }

                for (var j = right; j < len - i - 1; j++)
                {
                    (strarr[j], strarr[j + 1]) = (strarr[j + 1], strarr[j]);
                    count++;
                    if ((i == len / 2 - 1) && isodd && strarr[i] == strarr[i + 2])
                        break;
                    {

                    }
                }
            }

            

            return count;

        }

        //Faster than 88%.  uses hashset<T> and list.
        //Tried Dictionary<int, int> instead of list, actually slower, about 57%.
        public int MinDeletions88(string s)
        {
            if (s.Length == 1)
                return 0;


            var hash = new HashSet<int>();

            var freq = new int[26];
            for (var i = 0; i < s.Length; i++)
            {
                freq[s[i] - 'a']++;
            }
            var count = 0;
            for (var i = 0; i < 26; i++)
            {
                while (freq[i] > 0 && hash.Contains(freq[i]))
                {
                    count++;
                    freq[i]--;
                }
                hash.Add(freq[i]);
            }
            return count;

        }



        internal int countDecreasingRatingsCPP(List<int> arr)
        {
           

            

//            var sort = dict.Where(d => d.Key == d.Value).OrderByDescending(d => d.Value).Select(d => d.Key).FirstOrDefault();



            float p = 42.7f;
            object op = p;
            int np = (int) (double) op;
            Console.WriteLine(np);


            int count = 0, length = 0;
            for (int i = 1; i < arr.Count; i++)
            {
                if (arr[i - 1] > arr[i])
                    length++;
                else
                {
                    count += (length * (length + 1)) / 2;
                    length = 1;
                }

            }
            count += (length * (length + 1)) / 2;
            return count;
        }








        //Should pass.  Use DP, and NOT recursion.
        //Just set the first DP values as hardcoded.  Then you can calculate the rest as DP[n] = DP[n-1] + n;
        public long countDecreasingRatings(List<int> ratings)
        {

            var count = 0;
            if (ratings.Count <= 1)
                return ratings.Count;
            var len = ratings.Count;
            var remaininglen = len;
            var start = 0;
            var subs = new List<List<int>>();
            for (var i = 0; i < len; i++)
            {
                if (i == len - 1 || ratings[i] - ratings[i + 1] != 1)
                {
                    var subarray = ratings.GetRange(start, i - start + 1);
                    subs.Add(subarray);
                    start = i + 1;
                }
            }

            var dp = new int[len+1];
            
            dp[1] = 1;
            dp[2] = 3;


            for (var i = 0; i < subs.Count; i++)
            {
                var curr = subs[i];
                remaininglen -= curr.Count;
                if (dp[curr.Count] != 0)
                    count += dp[curr.Count];
                else
                {
                    var j = 3;
                    for (; j <= curr.Count; j++)
                    {
                        dp[j] = dp[j - 1] + j;
                    }
                    count += dp[j-1];
                }
            }

            return count;

        }









        public string isValid2(string s)
        {
          
            if (s.Length <= 1)
                return "YES";

            if (s.Length == 2)
            {
                if (Math.Abs(s[0] - s[1]) > 1)
                    return "NO";
                else
                    return "YES";
            }


            var dict = new Dictionary<char, int>();

            for (var i = 0; i < s.Length; i++)
            {
                if (!dict.ContainsKey(s[i]))
                    dict.Add(s[i], 1);
                else
                    dict[s[i]]++;
            }

          

            var group = dict.GroupBy(d => d.Value).ToDictionary(d => d.Key, d => d.Count());

            if (group.Count == 1)
                return "YES";

            if (group.Count > 2)
                return "NO";

            if (group.Values.Contains(1) &&( group[group.Min(g => g.Key)] == 1 || (group.Max(g => g.Key) - group.Min(g => g.Key) == 1)))
                return "YES";
            else
                return "NO";
        }



        public int sherlockAndAnagrams2(string s)
        {
            var dict = new Dictionary<string, int>();

            for (var i = 0; i < s.Length; i++)
            {
                for (var j = i; j < s.Length; j++)
                {
                    var subs = s.Substring(i, j + 1 - i).ToCharArray();
                    Array.Sort(subs);
                    var ana = new string(subs);
                    if (!dict.ContainsKey(ana))
                        dict.Add(ana, 1);
                    else
                        dict[ana]++;

                }
            }

            var count = 0;
            foreach (var k in dict.Values)
            {
                count += (k * (k - 1)) / 2;
            }

            return count;
        }

    


    public string LicenseKeyFormatting3(string s, int k)
        {

            var sb = new StringBuilder();
            var count = 0;
            for (var i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] != '-')
                {
                    sb.Insert(0, s[i]);
                    count++;
                    if (count == k && i > 0)
                    {

                        sb.Insert(0, '-');
                        count = 0;
                    }

                }
            }

            return sb.ToString().TrimStart('-').ToUpper();



        }




        public static int Codelist(List<string> codeList, List<string> shoppingCart)
        {

            if (codeList.Count == 0)
                return 1;
            else if (codeList.Count > 0 && shoppingCart.Count == 0)
                return 0;


            var row = 0;
            var col = 0;

            var currcodelist = codeList[row].Split(' ');

            for (var i = 0; i < shoppingCart.Count; i++)
            {
                if (shoppingCart[i] == currcodelist[col] || currcodelist[col] == "anything")
                {
                    col++;
                    if (col == currcodelist.Length)
                    {
                        col = 0;
                        row++;
                        if (row == codeList.Count)
                            return 1;
                        currcodelist = codeList[row].Split(' ');
                    }

                }
                else
                {
                    col = 0;
                }

            }


            return 0;
        }







        public int LengthLongestPath3(string input)
        {

            var paths = input.Split("\n");
            var max = 0;

            var route = new List<string>();
            var curr = "";
            var level = 0;
            for (var i = 0; i < paths.Length; i++)
            {
                curr = paths[i];
                level = curr.Count(ch => ch == '\t');
                curr = curr.TrimStart('\t');
                while (route.Count > level)
                {
                    route.RemoveAt(level);
                }
                route.Add(curr);
                if (curr.Contains('.'))
                {
                    var currlen = 0;
                    foreach (var s in route)
                        currlen += s.Length;

                    max = Math.Max(currlen + route.Count - 1, max);
                }

            }

            return max;
        }




        //sux??
        public IList<IList<int>> ThreeSum2(int[] nums)
        {

            var result = new List<IList<int>>();
            if (nums == null || nums.Length < 3) return result;

            for (var i = 0; i < nums.Length - 2; i++)
                for (var j = i + 1; j < nums.Length - 1; j++)
                    for (var k = j + 1; k < nums.Length; k++)
                    {
                        if ((nums[i] + nums[j] + nums[k]) == 0)
                            result.Add(new List<int>() { nums[i], nums[j], nums[k] }.OrderBy(l => l).ToList());
                    }


            var distinctlist = result.Select(o =>
            {
                var t = o.OrderBy(x => x).Select(i => i.ToString());
                return new { Key = string.Join("", t), List = o };
            })
        .GroupBy(o => o.Key)
        .Select(o => o.FirstOrDefault())
        .Select(o => o.List);

            return distinctlist.ToList();

        }





        public void abc()
        {
            int value1 = 10;
            Single value2 = 5.4f;

            Console.WriteLine(value1 + " " + value2);

            var h = new Hashtable();
            h.Add(1, "sdf");
            h.Add(2, "tuv");
            foreach(DictionaryEntry d in h)
            {
                Console.WriteLine(d.Value + " ");
            }


            var dict = new Dictionary<int, string>();
            dict.Add(1, "sdf");
            dict.Add(2, "tuv");
            foreach (var e in dict)
            {
                Console.WriteLine(e.Value + " ");
            }







            int? p = null;
            int? r = 0;

            int t = 10;
            Console.WriteLine(p is long);
        }




        public List<string> recentitemslinkedlist(List<string> logs)
        {
            var items = new List<string>() {logs[0]};
            var item = new StringListNode(logs[0]);
            var head = item;
            StringListNode newnode;

            for (var i = 1; i < logs.Count; i++)
            {


                if (!items.Contains(logs[i]))
                {
                    newnode = new StringListNode(logs[i]);
                    newnode.next = head;
                    head = newnode;
                    items.Add(logs[i]);
                    
                }
                else if (head.val != logs[i])
                {

                    var prev = head;
                    var curr = head.next;
                    
                    while (curr.val != logs[i])
                    {

                        curr = curr.next;
                        prev = prev.next;
                    }
                    prev.next = curr.next;
                    curr.next = head;
                    head = curr;



                }

            }
            var results = new List<string>();
            while (head != null)
            {
                results.Add(head.val);
                head = head.next;
            }
            return results;
        }

        
        public List<string> recentitems(List<string> logs)
        {
            var dict = new Dictionary<string, int>();
            var result = new List<string>();
            


            for (var i = 0; i < logs.Count; i++)
            {

                if (result.Contains(logs[i]))
                {


                    result.MoveToTop(result.IndexOf(logs[i]));

                
                }
                else
                    result.Insert(0, logs[i]);

                

                      
            }

            return result;
        }

        public  int AmazonFreshPromo(List<string> codeList, List<string> shoppingCart)
        {
            if (codeList.Count == 0)
                return 1;
            var clrow = 0;
            var clcolumn = 0;
            var currrow = codeList[0].Split(' ');
            foreach (var r in currrow)
                Console.Write(r);
            for (var i = 0; i < shoppingCart.Count; i++)
            {
                if (currrow[clcolumn] == shoppingCart[i] || currrow[clcolumn] == "anything")
                {
                    clcolumn++;
                    if (clcolumn == currrow.Length)
                    {
                        if (clrow == codeList.Count - 1)
                            return 1;
                        clcolumn = 0;
                        clrow++;
                        currrow = codeList[clrow].Split(' ');
                    }

                }
                else
                {
                    clcolumn = 0;
                }


            }
            return 0;
        }


        //Amazon demo test
        public static List<List<string>> searchSuggestions(List<string> repository, string customerQuery)
        {
            customerQuery = customerQuery.ToLower();
            repository = repository.ConvertAll(r => r.ToLower());
            var results = new List<List<string>>();

            for (var sublen = 2; sublen <= customerQuery.Length; sublen++)
            {

                var substr = customerQuery.Substring(0, sublen);
                var result = repository.Where(r => r.StartsWith(substr)).OrderBy(r => r).Take(3).ToList();
                results.Add(result);

            }
            return results;
        }


        //MS Online assessment question # 1 - Codility
        //check if string is balanced, eg return the length of the shortest substring where there are an equal amount of lowercase and uppercase characters.
        //******************************************************************************************************************
        public int solutionbalanced(string S)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)

            for (var i = 2; i <= S.Length; i++)
            {
                for (var j = 0; j <= S.Length - i; j++)
                {
                    var ca = check(S, j, j + i - 1);
                    if (ca)
                    {

                        return S.Substring(j, i).Length;
                    }

                }
            }

            return -1;
        }

        private bool check(string S, int start, int end)
        {
            var chars = new HashSet<char>();
            for (var i = start; i <= end; i++)
            {
                chars.Add(S[i]);
            }


            var a = new List<int>();
            var b = a.ToArray();
            foreach (var c in chars)
            {
                if (c >= 'a' && c <= 'z')
                {

                    
                    if (chars.Where(d => d == char.ToUpper(c)).Count() == 0)
                        return false;


                }
                else if (c >= 'A' && c <= 'Z')
                {
                    var test = chars.Where(d => d == char.ToLower(c));
                    if (chars.Where(d => d == char.ToLower(c)).Count() == 0)

                        return false;
                }
            }
            return true;

        }
        //Question #2 codility MS online assessment
        //Any unique numbers in a range to sum up to zero.
        public int[] SumZero(int n)
        {
            var result = new List<int>();
            for (int i = 1; i <= n / 2; i++)
            {
                result.Add(i);
                result.Add(-i);
            }

            if (n % 2 == 1) result.Add(0);
            return result.ToArray();
        }
        //******************************************************************************************************************


        public static string appendAndDelete(string s, string t, int k)
        {
            if (s == t && k % 2 == 0)
                return "Yes";

            if (s == t && k % 2 != 0 && k > (2 * s.Length))
                return "Yes";

            var count = 0;
            for (var i = 0; i < s.Length && i < t.Length; i++)
            {
                if (s[i] == t[i])
                    count++;
                else
                    break;
            }

            var numtodelete = s.Length - count;
            var numtoadd = t.Length - count;
            var minops = numtoadd + numtodelete;

            if (k < minops)
                return "No";
            if (k >= s.Length + t.Length)
                return "Yes";
            if ((k - minops) % 2 == 0)
                return "Yes";
            return "No";
        }



        public bool IsValidSubsequence(List<int> array, List<int> sequence)
        {
            // Write your code here.
            var seqpos = 0;
            for (var i = 0; i < array.Count; i++)
            {

                if (array[i] == sequence[seqpos])
                {
                    seqpos++;
                    if (seqpos == sequence.Count)
                        return true;
                }


            }

            return false;
        }

        //Leetcode medium!  dijkstras algorithm to go through graph multiple times.
        public int NetworkDelayTime2(int[][] times, int n, int k)
        {


            var paths = new int[n + 1];
            var max = 50000;  //arbitrary number greater than max possible sum of all edges.

            Array.Fill(paths, max);
            paths[k] = 0;

            while (n > 1) // this is needed
            { 
                foreach (var edge in times)
                {
                    paths[edge[1]] = Math.Min(paths[edge[1]], paths[edge[0]] + edge[2]);
                }
                n--;
            }

            var total = 0;
            for (var i = 1; i < paths.Length; i++)
            {
                if (paths[i] == max)
                    return -1;
                total = Math.Max(total, paths[i]);

            }


            return total;

        }


        public int NumWaterBottles2(int numBottles, int numExchange)
        {
            var count = numBottles;
            var empties = 0;
            while (numBottles + empties >= numExchange)
            {
                var rem = (numBottles + empties) % numExchange;
                numBottles = (numBottles + empties) / numExchange;
                empties = rem;
                count += numBottles;
               // empties = numBottles;
               // numBottles = 0;
            }
            return count;
        }

        //https://leetcode.com/problems/add-two-numbers-ii/
        public ListNode AddTwoNumbers22(ListNode l1, ListNode l2)
        {
            var s1 = new Stack<int>();
            var s2 = new Stack<int>();

            while (l1 != null)
            {
                s1.Push(l1.val);
                l1 = l1.next;
            }

            while (l2 != null)
            {
                s2.Push(l2.val);
                l2 = l2.next;
            }

            var result = new ListNode(0);

            ListNode head = new ListNode(0);
            var carry = 0;
            while (s1.Count > 0 || s2.Count > 0 || carry > 0)
            {
                var sum = (s1.Count > 0 ? s1.Pop() : 0) + (s2.Count > 0 ? s2.Pop() : 0) + carry;
                carry = sum / 10;
                sum %= 10;
                result.val = sum;
                head = new ListNode(0);
                head.next = result;
                result = head;


            }

            return head.next;
        }








        TreeNode successor3 = null;
        public TreeNode InorderSuccessor3(TreeNode root, TreeNode p)
        {
            
            DFS(root, p.val);
            return successor3;
        }

        private void DFS(TreeNode node, int i)
        {
            if (node == null)
                return;
            Console.WriteLine(node.val);
            if (node.val > i && (successor3 == null || Math.Abs(i - node.val) < Math.Abs(i - successor3.val)))
                successor3 = node;

            DFS(node.left, i);
            DFS(node.right, i);
        }



        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {

            var i2 = n - 1;
            var i1 = m - 1;
            var i = nums1.Length - 1;

            while (i2 >= 0 && i >= 0)
            {
                if (i1 < 0 || nums2[i2] >= nums1[i1])
                {
                    nums1[i] = nums2[i2];
                    i2--;
                }
                else
                {
                    nums1[i] = nums1[i1];
                    i1--;
                }
                i--;


            }



        }


        public bool DivisorGame(int n)
        {
            if (n % 2 == 0)
                return true;
            else return false;
        }

        public string RemoveOuterParentheses(string s)
        {
            if (s.Length <= 2)
                return "";
            var state = 1;
            var result = new StringBuilder();
            var tempsb = new StringBuilder();
            tempsb.Append(s[0]);
            for (var i = 1; i < s.Length; i++)
            {
                if (s[i] == '(')
                    state++;
                else state--;
                tempsb.Append(s[i]);
                if (state == 0)
                {
                    tempsb.Remove(0, 1);
                    tempsb.Remove(tempsb.Length - 1, 1);
                    result.Append(tempsb);
                    tempsb.Clear();
                }


            }
            return result.ToString();
        }



        //Amazon Online Assessment 25Sep 2021
        //brute force
        public long findpassstrength(string password)
        {
            long lengths = 0L;
            for (var i = 1; i <= password.Length; i++)
            {
                for (var j = 0; j <= password.Length - i; j++)
                {
                    var str = password.Substring(j, i);
                    var dist = str.Distinct().Count();
                    lengths += dist;
                }
            }

            return lengths;
        }

        //Amazon Online Assessment 25Sep 2021
        public int maxusertrafic(List<int> login, List<int> logout)
        {
            if (login.Count == 1)
                return logout[0] - login[0] + 1;

            var min = login.Min();
            var max = logout.Max();

            
            var dict = new Dictionary<int, int>();
            for (var i = min; i <= max; i++)
                dict.Add(i, 1);


            for (var i = 0; i < login.Count-1; i++)
            {
                if (login[i+1] <= logout[i])
                { 
                    for (var j = login[i+1]; j <= logout[i]; j++)
                    {
                        dict[j]++;
                    }
                }
            }

           // var highest = dict.GroupBy(d => d.Value);

            var g = dict.OrderByDescending(d => d.Value);

            var count = 1;
            var topval = g.ElementAt(0).Value;
            for (var i = 1; i < g.Count(); i++)
            {
                if (g.ElementAt(i).Value < topval)
                    break;
                else
                    count++;
            }

            return count;
                
        }

        //passed 17/17.  good solution but can be optimized.
        public static List<List<string>> searchSuggestions2(List<string> repository, string customerQuery)
        {
            var results = new List<List<string>>();
            var lcq = customerQuery.ToLower();
            for (var i = 1; i < lcq.Length; i++)
            {
                var s = lcq.Substring(0, i + 1);
                var curresults = repository.Where(r => r.ToLower().StartsWith(s)).OrderBy(r => r).Take(3).Select(r => r.ToLower()).ToList();
                results.Add(curresults);
            }
            return results;
        }


        public int MissingElement2(int[] nums, int k)
        {


            int index = 1;
            for (int i = nums[0] + 1; i <= int.MaxValue; i++)
                if (index < nums.Length && nums[index] == i) index++;
                else if (--k == 0) return i;
            return 0;

            //failed time too long:
            //var missing = Enumerable.Range(1, int.MaxValue).Except(nums).ElementAt(k - 2 + nums[0]);
            //Console.WriteLine(missing);
            //return missing;


            //if (i < nums.Length -1)


            //    var elem = k;
            //    var start = nums[0] + 1;
            //    var missing = new List<int>();
            //    for (var i = 1; i < nums.Length && elem > 0; i++)
            //    { 
            //        while (nums[i] > start && elem > 0)
            //        {
            //            missing.Add(start);
            //            elem--;
            //            start++;
            //        }

            //            start = nums[i] + 1;
            //    }
            //    return missing[k - 1];
        }


        public int LongestCommonSubpathincomplete(int n, int[][] paths)
        {

            var dict = new Dictionary<List<int>, int>();
            for (var i = 0; i < paths.Length; i++)
            {
                var len = paths[i].Length;
                for (var j = 0; j < len; j++)
                {
                    for (var k = j; k < len; k++)
                    {
                        var values = paths[i].Skip(j).Take(k + 1).ToList();
                        var l = new List<int>(values);
                        if (!dict.ContainsKey(l))
                            dict.Add(l, 1);
                        else
                            dict[l]++;


                    }
                }
            }
            return 1;
        }
        /// <summary>
        /// ///////////////////////////////
        /// </summary>
        /// 

        long bass = 100001;
        long mod = (long)(Math.Pow(10, 11) + 7);
        long[] pow;

        public int LongestCommonSubpath(int n, int[][] paths)
        {
            int res = 0, min = Int32.MaxValue;
            foreach (int[] path in paths) min = Math.Min(min, path.Length);
            pow = new long[min + 1]; pow[0]++;

            for (int i = 1; i <= min; i++)
                pow[i] = (pow[i - 1] * bass) % mod;

            for (int st = 1, end = min, mid = (st + end) / 2; st <= end; mid = (st + end) / 2)
            {
                if (commonSubstring(paths, mid))
                {
                    res = mid;
                    st = mid + 1;
                }
                else
                    end = mid - 1;
            }
            return res;
        }
        private bool commonSubstring(int[][] paths, int l)
        {
            HashSet<long> set = rollingHash(paths[0], l);
            for (int i = 1, n = paths.Length; i < n; i++)
            {
                var rolling = rollingHash(paths[i], l);
                for(var j = 0; j < set.Count; j++)
                {
                    if (!rolling.Contains(set.ElementAt(j)))
                        set.Remove(set.ElementAt(j));
                }
                //set.RemoveWhere(s => set.Contains(rollingHash(paths[i], l));
                if (set.Count == 0)
                    return false;
            }
            return true;
        }
        private HashSet<long> rollingHash(int[] a, int l)
        {
            HashSet<long> set = new HashSet<long>();
            long hash = 0;

            for (int i = 0; i < l; i++)
                hash = (hash * bass + a[i]) % mod;
            set.Add(hash);

            for (int n = a.Length, curr = l, prev = 0; curr < n; prev++, curr++)
            {
                hash = (((hash * bass) % mod - (a[prev] * pow[l]) % mod + a[curr]) + mod) % mod;
                set.Add(hash);
            }

            return set;
        }




        public int LastStoneWeightII(int[] stones)
        {
            var sums = new HashSet<int>();
            sums.Add(0);

            foreach (var stone in stones)
            {
                var nextSums = new HashSet<int>();
                foreach (var s in sums)
                {
                    if (!nextSums.Contains(s + stone))
                    {
                        nextSums.Add(s + stone);
                    }
                    if (!nextSums.Contains(s - stone))
                    {
                        nextSums.Add(s - stone);
                    }
                }
                sums = nextSums;
            }

            return sums.Where(s => s >= 0).Min();
        }



        public int LastStoneWeight(int[] stones)
        {
            var slist = stones.ToList();
            while (slist.Count > 1)
            {
                var y = slist.Max();
                slist.Remove(y);
                var x = slist.Max();
                var remainder = y - x;
                slist.Remove(x);
                if (remainder > 0)
                    slist.Add(remainder);
            }
            return (slist.Count == 1) ? slist[0] : 0;
        }



        //amazon

        public int DietPlanPerformance(int[] calories, int k, int lower, int upper)
        {
            var num = k;
            var count = 0;
            var total = 0;

            for (var i = 0; i < k && i < calories.Length; i++)
            {
                count += calories[i];
                num--;
            }

            if (count < lower)
                total--;
            else if (count > upper)
                total++;


            for (var i = k; i < calories.Length; i++)
            {
            
                count += calories[i];
                count -= calories[i - k];

                if (count < lower)
                    total--;
                else if (count > upper)
                    total++;
            

            }
            return total;
        }


        //amazon questions
        public bool IsRobotBounded(string instructions)
        {

            var position = new int[] { 0, 0 };

            var orientation = 'U';

           
                for (var i = 0; i < instructions.Length; i++)
                {
                    if (instructions[i] == 'G')
                    {

                        if (orientation == 'U')
                            position[1]++;
                        else if (orientation == 'D')
                            position[1]--;
                        else if (orientation == 'L')
                            position[0]--;
                        else if (orientation == 'R')
                            position[0]++;



                    }
                    else if (instructions[i] == 'L')
                    {
                        if (orientation == 'U')
                            orientation = 'L';
                        else if (orientation == 'D')
                            orientation = 'R';
                        else if (orientation == 'L')
                            orientation = 'D';
                        else if (orientation == 'R')
                            orientation = 'U';

                    }
                    else if (instructions[i] == 'R')
                    {
                        if (orientation == 'U')
                            orientation = 'R';
                        else if (orientation == 'D')
                            orientation = 'L';
                        else if (orientation == 'L')
                            orientation = 'U';
                        else if (orientation == 'R')
                            orientation = 'D';

                    }
                }

                //as long as orientation changes were good!
            if ((position[0] == 0 && position[1] == 0) || orientation != 'U')
                return true;
            else
                return false;

        }

        public void GameOfLife(int[][] board)
        {

            var rows = board.Length;
            var cols = board[0].Length;

            for (var i = 0; i < rows; i++)
            {
                for (var j = 0; j < cols; j++)
                {
                    //get # if neighbours
                    var liveneighbours = 0;
                    for (var k = i - 1; k < i - 1 + 3; k++)
                    {
                        for (var l = j - 1; l < j - 1 + 3; l++)
                        {
                            if (k >= 0 && k < rows && l >= 0 && l < cols && (k != i || j != l))
                            {
                                if (board[k][l] == 1 || board[k][l] == -1)
                                    liveneighbours++;
                            }
                        }

                    }
                    if (board[i][j] == 1 && (liveneighbours < 2 || liveneighbours > 3))
                        board[i][j] = -1;
                    else if (board[i][j] == 0 && liveneighbours == 3)
                        board[i][j] = 2;


                }
            }

            for (var i = 0; i < rows; i++)
            {
                for (var j = 0; j < cols; j++)
                {
                    if (board[i][j] > 0)
                        board[i][j] = 1;
                    else
                        board[i][j] = 0;
                }
            }




        }






        //Leetcode hard.  O log(m+n) because binary search = O (log n).
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {

            var numslist = nums1.ToList();

            for (var i = 0; i < nums2.Length; i++)
            {
                var n = numslist.BinarySearch(nums2[i]);
                numslist.Insert((n >= 0) ? n : ~n, nums2[i]);
            }
            if (numslist.Count % 2 > 0)
            {
                return Convert.ToDouble(numslist[numslist.Count / 2]);
            }
            else
            {
                var half = numslist.Count / 2;
                return (numslist[half - 1] + numslist[half]) / 2.0;
            }


        }


        //public void test()
        //{
        //    var l = new List<int>();

        //    l.AddSorted(3);
        //    var a = new int[5];


        //    var i = 5;
        //    var j = i / 2.0;
        //    var k = (double)i;

        //}


        public bool IsRectangleOverlap(int[] rec1, int[] rec2)
        {
            if (rec1[0] == rec1[2] || rec1[1] == rec1[3] ||
               rec2[0] == rec2[2] || rec2[1] == rec2[3])
            {
                // the line cannot have positive overlap
                return false;
            }

            return !(rec2[2] <= rec1[0] ||   // left
                     rec2[3] <= rec1[1] ||   // bottom
                     rec2[0] >= rec1[2] ||   // right
                     rec2[1] >= rec1[3]);    // top
        }



        public string[] FindOcurrences(string text, string first, string second)
        {
            var results = new List<string>();
            var ts = text.Split(" ");
            if (ts.Length < 3)
                return results.ToArray();
            var fir = false;
            var sec = false;
            
            for (var i = 2; i < ts.Length; i++)
            {
                if (ts[i - 2] == first && ts[i - 1] == second)
                {

                    results.Add(ts[i]);
                }
              
            }
            return results.ToArray();
        }

        public bool IsIsomorphic(string s, string t)
        {
            int counter = 1;
            var dictS = new int[127];
            var dictT = new int[127];
            for (int i = 0; i < s.Length; i++)
            {
                if (dictS[s[i]] != dictT[t[i]])
                    return false;
                else if (dictS[s[i]] == 0)
                {
                    dictS[s[i]] = dictT[t[i]] = counter;
                    counter++;
                }
            }
            return true;

        }





        public bool SearchMatrix(int[][] matrix, int target)
        {

            var row = matrix.Length - 1;
            var col = 0;

            while (row >= 0 && col <= matrix[0].Length - 1)
            {
                if (matrix[row][col] == target)
                    return true;
                else if (matrix[row][col] < target)
                    col++;
                else if (matrix[row][col] > target)
                    row--;

            }

            return false;

        }



        TreeNode lca;
        public TreeNode LowestCommonAncestorrecurse(TreeNode root, TreeNode p, TreeNode q)
        {
            Traverse(root, p, q);
            return lca;
        }


        private bool Traverse(TreeNode node, TreeNode p, TreeNode q)
        {
            if (node == null)
                return false; ;

            var left = Traverse(node.left, p, q) ? 1 : 0;
            var right = Traverse(node.right, p, q) ? 1 : 0;

            var mid = (node == p || node == q) ? 1 : 0;


            if (left + right + mid >= 2)
                lca = node;

            return (left + right + mid > 0);




        }


        //do this from scratch.  Essentially 3 loops d, f, t

        public int NumRollsToTarget(int d, int f, int target)
        {
            var dp = new int[target + 1];
            dp[0] = 1;
            for (int dd = 1; dd <= d; dd++)
            {
                var tempdp = new int[target + 1];
                for (var ff = 1; ff <= f; ff++)
                {
                    if (ff > target)
                        break;
                    for (var tt = ff; tt <= target; tt++)
                        tempdp[tt] = (tempdp[tt] + dp[tt - ff]) % 1_000_000_007;
                }
                dp = tempdp;
            }

            return dp[target];
        }





        public int CountCharacters(string[] words, string chars)
        {
            var dict = new Dictionary<char, int>();
            var total = 0;
            for (var i = 0; i < chars.Length; i++)
            {

                if (!dict.ContainsKey(chars[i]))
                    dict.Add(chars[i], 1);
                else
                    dict[chars[i]]++;
            }


            for (var j = 0; j < words.Length; j++)
            {
                var count = 0;
                var whole = true;
                var dict2 = new Dictionary<char, int>(dict);
                for (var k = 0; k < words[j].Length; k++)
                {
                    if (dict2.ContainsKey(words[j][k]) && dict2[words[j][k]] > 0)
                    { 
                        dict2[words[j][k]]--;
                        count++;
                    }
                    else
                    {
                        whole = false;
                        break;
                    }

                }
                if (whole)
                {
                    total += count;
                }



            }

            return total;



        }


        public TreeNode DeleteNode(TreeNode root, int key)
            {
                if (root == null)
                    return null;

                if (key < root.val)
                    root.left = DeleteNode(root.left, key);
                else if (key > root.val)
                    root.right = DeleteNode(root.right, key);
                else
                {
                    if (root.left == null)
                        return root.right;
                    else if (root.right == null)
                        return root.left;

                    root.val = minvalue(root.right);
                    root.right = DeleteNode(root.right, root.val);


                }



                return root;



            }


            private int minvalue(TreeNode root)
            {
                var min = root.val;
                while (root.left != null)
                {
                    min = root.left.val;
                    root = root.left;
                }
                return min;
            }

     

        public int rob(int[] nums)
        {
            if (nums.Length == 1)
                return nums[0];
            var len = nums.Length;
             var dp = new int[len];
             dp[0] = nums[0];
            dp[1] = Math.Max(nums[0], nums[1]);

            for (var i = 2; i < len; i++)
            {
                dp[i] = Math.Max(nums[i] + dp[i - 2], dp[i - 1]);
            }
            return dp[len - 1];
        }


        public int findMaxAmount(int[] nums)
            {
                if (nums.Length == 1)
                    return nums[0];
                var len = nums.Length;
              
                nums[1] = Math.Max(nums[0], nums[1]);

                for (var i = 2; i < len; i++)
                {
                    nums[i] = Math.Max(nums[i] + nums[i - 2], nums[i - 1]);
                }
                return nums[len - 1];
            }
       


        public bool IsOneBitCharacter2(int[] bits)
        {
            if (bits.Length == 1)
                return true;

            for (var i = 0; i < bits.Length; i++)
            {
                if (i == bits.Length - 1)
                    return true;
                if (bits[i] == 1)
                    i++;
            }
            return false;
        }


        public int MinCostClimbingStairs2(int[] cost)
        {
            var s1 = 0;
            var s2 = 0;
            for (var i = cost.Length - 1; i >= 0; i--)
            {
                var cur = cost[i] + Math.Min(s1, s2);
                s1 = s2;
                s2 = cur;
            }
            return Math.Min(s1, s2);

        }

        public int MinCostClimbingStairs(int[] cost)
        {
            for (var i = 2; i < cost.Length; i++)
            {
                cost[i] += Math.Min(cost[i - 1], cost[i - 2]);
            }
            return Math.Min(cost[cost.Length - 1], cost[cost.Length - 2]);

        }


        int sum2 = 0;
        public int SumOfLeftLeaves2(TreeNode root)
        {

            Traverse2(root);
            return sum2;

        }

        private void Traverse2(TreeNode node)
        {
            if (node == null)
                return;
            if (node.left != null && node.left.left == null && node.left.right == null)
                sum2 += node.left.val;
            Traverse2(node.left);
            Traverse2(node.right);
        }



        public string ReverseVowels3(string s)
        {
            var sb = new StringBuilder(s);
            var left = 0;
            var right = s.Length - 1;

            while (left < right)
            {
                var l = sb[left];
                while (left < right && l != 'a' && l != 'e' && l != 'i' && l != 'o' && l != 'u'
                    && l != 'A' && l != 'E' && l != 'I' && l != 'O' && l != 'U')
                {
                    left++;
                    l = sb[left];
                }

                var r = sb[right];
                while (left < right && r != 'a' && r != 'e' && r != 'i' && r != 'o' && r != 'u'
                    && r != 'A' && r != 'E' && r != 'I' && r != 'O' && r != 'U')
                {
                    right--;
                    r = sb[right];

                }
                if (left < right)
                {
                    (sb[left], sb[right]) = (sb[right], sb[left]);
                    left++;
                    right--;
                }
            }


            return sb.ToString();
        }







        //too slow but works
        public string ReverseVowels2(string s)
        {
            var dict = new Dictionary<int, char>();
            for (var i = 0; i < s.Length; i++)
            {
                if (s[i] == 'a' || s[i] == 'e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u'
                    || s[i] == 'A' || s[i] == 'E' || s[i] == 'I' || s[i] == 'O' || s[i] == 'U')
                {
                    dict.Add(i, s[i]);
                }


            }

            dict = dict.OrderByDescending(d => d.Key).ToDictionary(x => x.Key, x => x.Value);
            var sb = new StringBuilder();
            var j = 0;
            for (var i = 0; i < s.Length; i++)
            {
                if (s[i] == 'a' || s[i] == 'e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u'
                  || s[i] == 'A' || s[i] == 'E' || s[i] == 'I' || s[i] == 'O' || s[i] == 'U')
                {
                    sb.Append(dict.ElementAt(j).Value);
                    j++;
                }
                else
                    sb.Append(s[i]);

            }
            return sb.ToString();
        }







        public bool BuddyStrings2(string s, string goal)
        {
            var sdict = new Dictionary<char, int>();
            var goaldict = new Dictionary<char, int>();
            var isdupes = false;
            var isequal = true;
            for (var i = 0; i < s.Length; i++)
            {


                var key = s[i];
                if (i < s.Length - 1 && key == s[i + 1])
                    isdupes = true;

                if (key != goal[i])
                {
                    isequal = false;
                    if (!sdict.ContainsKey(key))
                        sdict.Add(key, 1);
                    else
                        sdict[key]++;

                    if (!goaldict.ContainsKey(goal[i]))
                        goaldict.Add(goal[i], 1);
                    else
                        goaldict[goal[i]]++;
                }

            }

            if (isequal && s.GroupBy(x => x).Where(g => g.Count() >= 2).Count() > 0)
                return true;
            if (isequal && isdupes)
                return true;
            if (!isequal && sdict.Count == 2 &&  sdict.OrderBy(s => s.Key).SequenceEqual(goaldict.OrderBy(g => g.Key)) && sdict.All(s => s.Value == 1))
                return true;

            return false;
        }
    











    public Node4 Connect(Node4 root)
        {
            if (root == null)
                return null;
            var q = new Queue<Node4>();
            q.Enqueue(root);

            while (q.Count > 0)
            {
                var count = q.Count;
                var dummy = new Node4();
                for (var i = 0; i < count; i++)
                {
                    var node = q.Dequeue();
                    dummy.next = node;
                    dummy = dummy.next;
                    if (node.left != null)
                        q.Enqueue(node.left);
                    if (node.right != null)
                        q.Enqueue(node.right);
                }
            }
            return root;
        }




        //my version.  75% on leetcode both time and memory!
        public int[] MaxSlidingWindow3(int[] nums, int k)
        {

            var len = nums.Length;
            var results = new List<int>();
            var q = new LinkedList<int>();

            for (var i = 0; i < len; i++)
            {
                if (q.Count > 0 && q.First.Value + k <= i)
                    q.RemoveFirst();

                while (q.Count > 0 && nums[q.Last.Value] < nums[i])
                    q.RemoveLast();

                q.AddLast(i);

                if (i >= k -1)
                    results.Add(nums[q.First.Value]);


            }

            return results.ToArray();
        }


            public int[] MaxSlidingWindow2(int[] nums, int k)
        {

            int len = nums.Length;
            int maxArrayLen = len - k + 1;
            int[] ans = new int[maxArrayLen];

            var q = new LinkedList<int>();

            // Queue stores indices of array, and 
            // values are in decreasing order.
            // So, the first node in queue is the max in window
            for (int i = 0; i<len; i++)
            {
                // 1. remove element from head until first number within window
                if (q.Count > 0 && q.First.Value + k <= i)
                {
                    q.RemoveFirst();
                }

                // 2. before inserting i into queue, remove from the tail of the
                // queue indices with smaller value they array[i]
                while (q.Count > 0 && nums[q.Last.Value] <= nums[i])
                {
                    q.RemoveLast();
                }

                q.AddLast(i);

                // 3. set the max value in the window (always the top number in
                // queue)
                int index = i + 1 - k;
                if (index >= 0)
                {
                    ans[index] = nums[q.First.Value];
                }
            }
            return ans;
        }


      //  List<int> _nums;
      //  int _k;
        
        public int[] MaxSlidingWindow(int[] nums, int k)
        {
            var results = new List<int>();
        //    List<int> currentnums = new List<int>();
        //    currentnums.Add(nums[0]);
        //    var max = nums[0];

            var pq = new PriorityQueue<int>();

      //      _nums = currentnums.OrderBy(x => x).ToList();
      //      _k = currentnums.Count;
      //      results.Add(_nums[_k - 1]);

            for (var i = 0; i < nums.Length; i++)
            {
                if (pq.Count() >= k)
                    pq.Dequeue(); //   (nums[i - k]);
                //if (_nums.Count == 0 || nums[j] > _nums[_nums.Count - 1])
                pq.Enqueue(nums[i]);
                if (i >= k - 1)
                    results.Add(pq.PeekMax());
            }
            return results.ToArray();
        }

        //private void Add(int val)
        //{
        //    if (_nums.Count < _k || val > _nums[_nums.Count - _k])
        //    {
        //        var i = _nums.BinarySearch(val);
        //        if (i < 0) _nums.Insert(~i, val);
        //        else _nums.Insert(i, val);
        //    }

       
        //}



        public int MySqrt(int x)
        {
            if (x <= 1)
                return x;
            var i = 2;
            var result = 0;
            while (true)
            {
                long d = x / i;
                if ((d * d) <= x)
                {
                    result = (int)d;
                    break;
                }


                i++;
            }
            return result;
        }






        public int MaxProfit3(int[] prices)
        {

            if (prices.Length <= 1)
                return 0;
           
            var buy = Int32.MaxValue;
            var sell = 0;

            for (var i = 0; i < prices.Length; i++)
            {
                if (prices[i] < buy)
                    buy = prices[i];
                else if ((prices[i] - buy) > (sell - buy))
                    sell = prices[i];


            }
            return sell - buy > 0 ? sell - buy : 0;
        }

        public bool CanWinNimcheat(int n)
        {
            return (n % 4 != 0);
        }

        public bool CanWinNim(int n)
        {
            var dp = new bool[n + 1];
            dp[0] = false;
            dp[1] = true;
            dp[2] = true;
            dp[3] = true;

            for (var i = 4; i <= n; i++)
            {
                dp[i] = !(dp[i - 1] && dp[i - 2] && dp[i - 3]);
            }

            Console.WriteLine(string.Join(",", dp));

            return dp[n];
        }


        public string StringEncode (string s)
        {
            if (String.IsNullOrEmpty(s))
                return "";

            var sb = new StringBuilder();
            var counter = 1;
            
            for (var i = 1; i < s.Length; i++)
            {
                if (s[i] == s[i-1])
                    counter++;
                else
                {
                    sb.Append(counter).Append(s[i-1]);
                    counter = 1;

                }
            }
            sb.Append(counter).Append(s[s.Length-1]);


            return sb.ToString();


        }




        List<int> leftlist = new List<int>();
        List<int> rightlist = new List<int>();

        int curlevel = 0;
        public List<int> TreeOutline(TreeNode root)
        {
            if (root == null)
                return null;

            TraverseLeftTreeOutline(root, 1);
            curlevel = 0;
            TraverseRightTreeOutline(root.right, 1);

            leftlist.Reverse();
            leftlist.AddRange(rightlist);
            return leftlist;

        }

        private void TraverseLeftTreeOutline(TreeNode node, int level)
        {
            if (node == null)
                return;

            if (level > curlevel)
                curlevel = level;

            leftlist.Add(node.val);

            TraverseLeftTreeOutline(node.left, level + 1);

        }

        private void TraverseRightTreeOutline(TreeNode node, int level)
        {
            if (node == null)
                return;

            if (level > curlevel)
                curlevel = level;

            rightlist.Add(node.val);

            TraverseRightTreeOutline(node.right, level + 1);

        }

        private ListNode forward;
        public bool IsPalindrome(ListNode head)
        {
            var backward = head;
            forward = head;
            return Traverse(backward);
        }

        private bool Traverse(ListNode backward)
        {
            if (backward == null) return true;
            if (!Traverse(backward.next)) return false;
            var result = backward.val == forward.val;
            forward = forward.next;
            return result;
        }




        // Minimum Steps to Make Piles Equal Height
        public int minSteps(int[] piles)
        {
            Array.Sort(piles);
            int sum = 0;
            int n = piles.Length;
            for (int i = 1; i < n; i++)
            {
                if (piles[n - i - 1] != piles[n - i])
                {
                    sum += i;
                }
            }
            return sum;
        }



        // Minimum Adjacent Swaps to Make Palindrome
        public int getNoOfSwaps(string s)
        {
            if (s == null || s.Length == 0) return -1;
            int totalSwaps = 0;

            if (isShuffledPalindrome(s))
            {
                char[] chars = s.ToCharArray();
                int p1 = 0, p2 = chars.Length - 1;

                while (p2 > p1)
                {
                    if (chars[p1] != chars[p2])
                    {
                        int k = p2;
                        while (k > p1 && chars[k] != chars[p1]) k--;

                        if (k == p1)
                        { //When no matching character found
                            swap(chars, p1, p1 + 1);
                            totalSwaps++;

                        }
                        else
                        { //When Matching character found swap until K reaches p2 position
                            while (k < p2)
                            {
                                swap(chars, k, k + 1);
                                totalSwaps++;
                                k++;
                            }
                            p1++; p2--;
                        }
                    }
                    else
                    {
                        p1++; p2--; //When the characters are equal move on
                    }
                }
                return totalSwaps;
            }
            else return -1;
        }

        private static void swap(char[] chars, int k, int i)
        {
            char temp = chars[k];
            chars[k] = chars[i];
            chars[i] = temp;
        }

        private bool isShuffledPalindrome(string s)
        {
            int[] occurrence = new int[26];
            int oddCount = 0;

            for (int i = 0; i < s.Length; i++) occurrence[s[i] - 'a']++;
            foreach (int value in occurrence) if (value % 2 != 0) oddCount++;
            return oddCount <= 1;
        }








        public int MinDeletions(string s)
        {
            if (s == null || s.Length == 0)
                return 0;

            // record unique frquencies 
            HashSet<int> freqSet = new HashSet<int>();
            int res = 0;

            // calculate frequencies
            int[] freq = new int[26];
            foreach (var c in s)
                freq[c - 'a']++;

            for (int i = 0; i < freq.Length; i++)
            {
                // if there is another character has the same frequence
                // we need to keep delete the current character until its frequncey is unique
                // example 1: input is {(a,3), {b,3}, {c,2}}
                // then we need to delete 2 a or 2 b
                // example 2: input is {(a,3), {b,3}, {c,2},{d,2}}
                // then we need to delete 2 a or 2 b, then delete 2 c or 2d
                while (freqSet.Contains(freq[i]) && freq[i] > 0)
                {
                    freq[i]--;
                  
                        res++;
                }
                freqSet.Add(freq[i]);
            }

            return res;


        }


public int MinDeletions2(string s)  // my solution.  works, but a little slow.  Passed in leetcode!
        {
            var dict = new Dictionary<char, int>();
            for (var i = 0; i < s.Length; i++)
            {
                if (!dict.ContainsKey(s[i]))
                {
                    dict.Add(s[i], 1);
                }
                else
                    dict[s[i]]++;
            }
            var ordered = dict.OrderByDescending(d => d.Value).Select(d => d.Value).ToList();
            var count = 0;
            for(var i = 1; i < ordered.Count; i++)
            {
                while (ordered.Where(o => o == ordered[i]).Count() > 1)
                {
                    ordered[i]--;
                    if (ordered[i] >= 0)
                        count++;
                }
            }
            return count;
        }

        public bool IsLongPressedName2(string name, string typed)
        {

            if (name == typed)
                return true;

            var i = 0;
            var j = 0;
            
            while (i < name.Length)
            {
                var c = name[i];
                var ncount = 0;
                var tcount = 0;
                while (i < name.Length && name[i] == c)
                {
                    i++;
                    ncount++;
                }

                while (j < typed.Length && typed[j] == c)
                {
                    j++;
                    tcount++;
                }

                if (tcount < ncount)
                    return false;

              
              

            }
            if (j < typed.Length)
                return false;
            else
                return true;
        }






        public  int GetMidItemValue(Node head)
        {
            Node slow = head;
            Node fast = head;
           
            if (head == null)
                return -1;
            if (head.next == null)
                return head.val;

//            while (fast != null && fast.next != null && fast?.next?.next != null)

            while (fast?.next?.next != null)
            {

                slow = slow.next;
                fast = fast.next.next;

            }

            if (fast.next == null)
                return slow.val;
            else
                return (slow.val + slow.next.val) / 2;


        }



        int hourglassSum(int[][] arr)
        {
            var max = -100;
            for (var i = 1; i <= 4; i++)
            {
                for (var j = 1; j <= 4; j++)
                {
                    var sum = arr[i][j] + arr[i - 1][j - 1] + arr[i - 1][j] + arr[i - 1][j + 1] + arr[i + 1][j - 1] + arr[i + 1][j] + arr[i + 1][j + 1];
                    max = Math.Max(sum, max);
                }
            }
            return max;
        }


        //best
        public int RemoveElement3(int[] nums, int val)
        {

            int i = -1;
            for (var j = 0; j < nums.Length; j++)
            {
                var num = nums[j];
                if (num != val)
                    nums[++i] = num;
            }
            return i + 1;
        }

        //good complicated
        public int RemoveElement(int[] nums, int val)
        {
            if (nums == null || nums.Length < 1)
                return 0;
            if (nums.Where(n => n != val).Count() == 0)
                return 0;
            Array.Sort(nums);
            var k = 0;
            var l = Array.IndexOf(nums, val);  // n
            if (l < 0)
                return nums.Length;

            var r = nums.Length - 1;
            if (nums[r] == val)
                k = nums.Length - (r - l + 1);
            else
            {
                var start = l;
                while (nums[l] == val && nums[r] != val)
                {
                    nums[l] = nums[r];
                    l++;
                    r--;
                }
                while (l < nums.Length && nums[l] == val)
                    l++;

                k = nums.Length - (l - start);
            }
            return k;

        }


        //good easy - not good.  you can't create a new array.

        public int RemoveElement2(int[] nums, int val)
        {

            var newarray = new List<int>();
            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                    newarray.Add(nums[i]);
            }

            newarray.CopyTo(nums);
            return newarray.Count();

          
            
        }






        public int numWaysSplitParen(string paren)
        {
            char[] chars = paren.ToCharArray();
            int count = 0;

            for (int i = 2; i <= chars.Length - 1; i = i + 2)
            {
                StringBuilder left = new StringBuilder();
                StringBuilder right = new StringBuilder();
                for (int j = 0; j < i; j++)
                {
                    left.Append(chars[j]);
                }

                for (int k = i; k < chars.Length; k++)
                {
                    right.Append(chars[k]);
                }

                if (isBalanced(paren, 0, i) && isBalanced(paren, i, chars.Length)) count++;
            }

            return count;
        }

        private bool isBalanced(string str, int start, int end)
        {
            int parenLeftCount = 0;
            int bracketLeftCount = 0;
            int wildcard = 0;


            for (int i = start; i < end; i++)
            {
                char c = str[i];
                if (c == '(') parenLeftCount++;
                if (c == ')') parenLeftCount--;
                if (c == '[') bracketLeftCount++;
                if (c == ']') bracketLeftCount--;
                if (c == '?') wildcard++;
            }

            if (parenLeftCount + bracketLeftCount - wildcard == 0 ||
                parenLeftCount + bracketLeftCount + wildcard % 2 == 0)
            {
                return true;
            }
            return false;
        }



        //amazon online assessment Aug 2.  passed 13/14 test cases.

        public int countAnalogousArrays(List<int> consecutiveDifference, int lowerBound, int upperBound)
        {
            int count = 0;
            int min = lowerBound, max = lowerBound;
            int prev = lowerBound, curr = 0;
            for (int i = 1; i <= consecutiveDifference.Count(); i++)
            {
                curr = prev - consecutiveDifference[i - 1];
                min = Math.Min(min, curr);
                max = Math.Max(max, curr);
                prev = curr;
            }

            while (max <= upperBound)
            {
                if (min >= lowerBound) count++;
                min = min + 1;
                max = max + 1;
            }
            return count;
        }




        //passes all 17 test caseas on hacker rank
       
        public  List<List<string>> searchSuggestions3(List<string> repository, string customerQuery)
        {
            var results = new List<List<string>>();

            customerQuery = customerQuery.ToLower();
            Console.WriteLine(customerQuery);
            for (var k = 2; k <= customerQuery.Length; k++)
            {
                var currentresult = new List<string>();
                var search = customerQuery.Substring(0, k);

                for (var i = 0; i < repository.Count; i++)
                {
                    var r = repository[i].ToLower();
                    if (r.StartsWith(search))
                        currentresult.Add(r);

                }


                results.Add(currentresult.OrderBy(cr => cr).Take(3).ToList());
            }



            return results;

        }






        //hacker rank
        public List<double> runningMedian(List<int> a)
        {
            var results = new List<double>();
            var sorted = new List<int>();
            for (var i = 0; i < a.Count; i++)
            {
                double median;
                sorted.AddSorted(a[i]);
                var mid = (i + 1) / 2;
                if ( (i+1) % 2 == 0)
                {
                    median = (double)(sorted[mid - 1] + sorted[mid]) / (double)2.0;
                }
                else
                {
                    median = (double)sorted[mid];
                }
                results.Add(median);
            }
            return results;
        }


        //hackerrank

        int count = 0;
        Dictionary<string, List<int>> contactdict = new Dictionary<string, List<int>>();
        public  List<int> contacts(List<List<string>> queries)
        {
            var counts = new List<int>();
            foreach (var q in queries)
            {
                if (q[0] == "add")
                {
                    var s = q[1];
        
                    for (var j = 1; j <= s.Length; j++)
                    {
                        var substr = s.Substring(0, j);
                        if (!contactdict.ContainsKey(substr))
                        {
                            contactdict.Add(substr, new List<int>() { count });
                        }
                        else
                        {
                            contactdict[substr].Add(count);
                        }
                    }
                }
                else
                if (q[0] == "find")
                {
                    var k = q[1];
                    var indexes = new List<int>();
                    var count = 0;
                    if (contactdict.TryGetValue(k, out indexes))
                        count = indexes.Count();
                    counts.Add(count);
                }
            }
            return counts;
        }



        public void levelOrder(TreeNode root)
        {

            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                var node = queue.Dequeue();
                Console.Write(node.val);
                if (node.left != null)
                    queue.Enqueue(node.left);
                if (node.right != null)
                    queue.Enqueue(node.right);
                if (queue.Count > 0)
                    Console.Write(" ");

            }
            Console.WriteLine();

        }


            /***********************************************************************************************/
            public void ShortestReach()
        {
            int q = Convert.ToInt32(Console.ReadLine().Trim());

            for (int qItr = 0; qItr < q; qItr++)
            {
                var nm = Console.ReadLine().Split(' ');
                var n = Convert.ToInt32(nm[0]);
                var m = Convert.ToInt32(nm[1]);
                var edges = new List<List<int>>();

                for (var ne = 0; ne < m; ne++)
                {
                    var edgem = Console.ReadLine().Split(' ');
                    edges.Add(new List<int> { Convert.ToInt32(edgem[0])-1, Convert.ToInt32(edgem[1])-1 });

                }
                var i = Convert.ToInt32(Console.ReadLine())-1;
                DoBFSShortReach(n, edges, i);
            }
        }

        private void AddEdges(List<List<int>> graph, List<List<int>> edges)
        {
            foreach (var edge in edges)
            {
                
                graph[edge[0]].Add(edge[1]);
                graph[edge[1]].Add(edge[0]);
            }


        }

        private void DoBFSShortReach(int n, List<List<int>> edges, int start)
        {
                var graph = new List<List<int>>(n);
                for (var j = 0; j < n; j++)
                {
                    graph.Add(new List<int>());
                }
                AddEdges(graph, edges);
             


            var edgedistance = 6;
            var distances = new int[n];
            //Array.Fill(distances, -1); //Doesn't work in MONO.

            //distances = distances.Select(d => { d = -1; return d; }).ToArray();

            for (var i = 0; i < distances.Length; i++)
            {
                distances[i] = -1;
            }


            var queue = new Queue<int>();
            queue.Enqueue(start);

            distances[start] = 0;
            while (queue.Count > 0)
            {
                var node = queue.Dequeue();

                foreach (var neighbour in graph[node])
                {
                    if (distances[neighbour] == -1)
                    {
                        distances[neighbour] = distances[node] + edgedistance;
                        queue.Enqueue(neighbour);
                    }
                   
                }


            }
            var sb = new StringBuilder();
            
            for (var i = 0; i < distances.Length; i++ )
            {
                if ( i != start)
                {
                    sb.Append(distances[i]);
                    if (i < distances.Length-1)
                    {
                        sb.Append(" ");
                    }
                }
                    
            }
           
            Console.WriteLine(sb.ToString());
        }

        /***********************************************************************************************/



        public  string twoStrings(string s1, string s2)
        {
            //Use dictionary (2) then compare existance of each char and see if it contains in other dict.
            //don't compare char to string, too slow.

                //don't use linq like below: too slow'

            var exists = s2.Any(str2 => s1.Contains(str2));
            return exists ? "YES" : "NO";
            
        }


        public int sherlockAndAnagrams(string s)
        {

            var map = new Dictionary<string, int>();

            for (int i = 0; i < s.Length; i++)
            {
                for (int j = i; j < s.Length; j++)
                {
                    char[] valC = s.Substring(i, j + 1 - i).ToCharArray();
                    Array.Sort(valC);
                    string val = new string(valC);
                    if (!map.ContainsKey(val))
                        map.Add(val, 1);
                    else
                        map[val]++;
                }
            }
            int anagramPairCount = 0;
            foreach (string key in map.Keys)
            {
                int n = map[key];
                anagramPairCount += (n * (n - 1)) / 2;
            }
            return anagramPairCount;

        }


        public long repeatedString2(string s, long n)
        {
            if (s == "a")
                return n;

            long count = s.Where(str => str == 'a').Count();
            count *= (n / s.Length);
            var rem = n % s.Length;

            for (var i = 0; i < rem; i++)
            {
                if (s[i] == 'a')
                    count++;
            }
            return count;

        }


        public string LicenseKeyFormatting2(string s, int k)
        {
            
            var len = s.Length;
            if (len == 1)
                return s != "-" ? s.ToUpper() : "";


            var count = 0;
            var sb = new StringBuilder();

            for (var i = len - 1; i >= 0; i--)
            {
                if (s[i] != '-')
                {
                    if (count < k)
                    {
                        sb.Insert(0, Char.ToUpper(s[i]));
                        count++;

                    }
                    else
                    {

                        sb.Insert(0, '-');
                        count = 1;
                        sb.Insert(0, Char.ToUpper(s[i]));

                    }

                }
            }
            return sb.ToString();
        }




        public int[][] DiagonalSort(int[][] mat)
        {
            int rows = mat.Length;
            int cols = mat[0].Length;
            if (rows == 0 || cols == 0)
            {
                return null;
            }
            int i, j, r, c, ind;

            r = 0;
            c = cols - 1;
            while (r != rows)
            {
                List<int> diagArray = new List<int>();
                i = r;
                j = c;
                while (i < rows && j < cols)
                {
                    diagArray.Add(mat[i][j]);
                    i++;
                    j++;
                }
                diagArray.Sort();

                i = r;  // starting at r == 0 
                j = c;  // starting at col -1 
                ind = 0;
                while (i < rows && j < cols)
                {
                    mat[i][j] = diagArray[ind];
                    i++;
                    j++;
                    ind++;
                }
                if (c > 0)
                {
                    c--;
                }
                else
                {
                    r++;
                }
            }
            return mat;


        }


        public int findsmallest(int[] A)
        {
            int ans = A[0];
            for (int i = 1; i < A.Length; i++)
            {
                if (A[i] < ans)
                {
                    ans = A[i];
                }
            }
            return ans;
        }


        public int asolution(int A, int B, int K)
        {

            if (A % K == 0)
                return (B / K) - (A / K) + 1;

            // A is not divisible by M
            return (B / K) - (A / K);
        }

        public int MissingInteger(int[] A)
        {
            Array.Sort(A);
            var smallest = 1;
            for (var i = 0; i < A.Length; i++)
            {
                if (A[i] == smallest)
                    smallest = A[i] + 1;
                else if (A[i] > smallest && A[i] > 0)
                    break;

            }
            return smallest;
        }




        public int FrogRiverOne(int X, int[] A)
        {
            
            var hash = new HashSet<int>();
            for (var i = 0; i < X; i++)
                hash.Add(i+1);
            
            
            for (var i = 0; i < A.Length; i++)
            {
                if (hash.Remove(A[i]))
                {
                    if (hash.Count == 0)
                        return i;
                }
            }
                return -1;
            
        }




        public int Brackets(string S)
        {


            if (S.Length == 0) return 1;

            Stack<char> brackets = new Stack<char>();

            foreach (char c in S)
            {
                if (c == '[' || c == '{' || c == '(')
                {
                    brackets.Push(c);
                }
                else
                {
                    // return 0 if no opening brackets found and 
                    // first bracket is a closing bracket
                    if (brackets.Count == 0) return 0;

                    if (c == ')')
                    {
                        if (brackets.Peek() == '(') brackets.Pop();
                        else return 0;
                    }

                    if (c == '}')
                    {
                        if (brackets.Peek() == '{') brackets.Pop();
                        else return 0;
                    }

                    if (c == ']')
                    {
                        if (brackets.Peek() == '[') brackets.Pop();
                        else return 0;
                    }
                }
            }

            if (brackets.Count == 0) return 1;

            return 0;
        }

public int[] MaxCounters(int N, int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            int[] countersArr = new int[N];
            int max = 0;
            int index;
            int setAllCountersOp = N;
            int floor = 0;

            for (int i = 0; i < A.Length; i++)
            {
                index = A[i] - 1;

                if (index == setAllCountersOp)
                {
                    floor = max;
                    continue;
                }

                if (countersArr[index] < floor)
                {
                    countersArr[index] = floor + 1;
                }
                else
                {
                    ++countersArr[index];
                }

                if (countersArr[index] > max)
                {
                    ++max;
                }
            }

            for (int i = 0; i < countersArr.Length; i++)
            {
                if (countersArr[i] < floor)
                {
                    countersArr[i] = floor;
                }
            }

            return countersArr;
        }


        public int TapeEquilibrium(int[] A)
        {

            int min = int.MaxValue;

        int sumLeft = 0;
        int sumRight = ArraySum(A);

        for (int i = 1; i<A.Length; i++)
        {
            int val = A[i - 1];

        sumLeft  += val;
            sumRight -= val;

            int diff = Math.Abs(sumLeft - sumRight);

            if (min > diff)
            {
                min = diff;
            }
        }

        return min;
        }

        private int ArraySum(int[] array)
        {
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            return sum;
        }

    //Codility passed 100%  PermMissingElem
    public int FindMissingElement(int[] A)
        {


            var sum = 0;
            for (int i = 0; i < A.Length; i++)
                sum += A[i];

            return A.Length % 2 == 0 ? (A.Length / 2 + 1) * (A.Length + 1) - sum
             : (A.Length / 2 + 1) * (A.Length + 2) - sum ;

        }


        //fails
        public int FindMissingElementsux(int[] A)
        {
            //codility
            var sum = A.Sum();
            var len = A.Length;
            if (len == 0)
                return 1;
            var total = (len + 2) * (len + 1) / 2;
            //for (var i = 0; i < len; i++)
            // {
            //     total -= A[i];
            // }
            var missing = total - sum;
            return missing;


        }

        //still fails in linq on 100,000 elements
        public int FindMissingElementlinqsux(int[] A)
        {

            if (A.Length <= 0)
                return 1;

            int size = A.Length;
            System.Collections.Generic.List<int> missing = Enumerable.Range(1, A[size - 1]).Except(A.ToList()).ToList();
            if (!missing.Any())
                return A[size - 1] + 1;

            return missing.First();



        }





        public int FindUnpaired(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            var dict = new Dictionary<int, int>();
            for (var i = 0; i < A.Length; i++)
            {
                if (!dict.ContainsKey(A[i]))
                    dict.Add(A[i], 1);
                else
                    dict[A[i]]++;
            }

            var odd = dict.Where(d => d.Value % 2 != 0).Select(d => d.Key).FirstOrDefault();
            return odd;

        }


        public void leftRotate(int[] arr, int d)
        {
            var n = arr.Length;
            int i, j, k, temp;
            /* To handle if d >= n */
            d = d % n;
            int g_c_d = gcd(d, n);
            for (i = 0; i < g_c_d; i++)
            {
                /* move i-th values of blocks */
                temp = arr[i];
                j = i;
                while (true)
                {
                    k = j + d;
                    if (k >= n)
                        k = k - n;
                    if (k == i)
                        break;
                    arr[j] = arr[k];
                    j = k;
                }
                arr[j] = temp;
            }
        }

        /* Fuction to get gcd of a and b*/
        private int gcd(int a, int b)
        {
            if (b == 0)
                return a;
            else
                return gcd(b, a % b);
        }



        //crap:  fails test cases  .  Better to just rotate by one, and create function for that, then call it K times:
        public int[] rotateRightKtimes(int[] A, int K)
        {
            if (A == null || A.Length < 2)
                return A;
            K = K % A.Length;
            reverse(A, 0, A.Length);
            reverse(A, 0, K);
            reverse(A, K, A.Length - K);
            return A;

            
        }

        private void reverse(int[] arr, int start, int length)
        {
            var j = start + length - 1;
            for (var i = start; i < j; i++)
            {
                var temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
                j--;
            }

        }

        public int solution(int N)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)

            var a = Convert.ToString(N, 2);
            var max = 0;
            var count = 0;
            for (var i = 0; i < a.Length; i++)
            {
                if (a[i] == '0')
                    count++;
                else
                {
                    max = Math.Max(max, count);
                    count = 0;
                }
            }
            return max;
        }



        public int GoodNodes(TreeNode root)
        {
            if (root.left == null && root.right == null)
                return 1;
            var count = 1;
            if (root.left != null)
                DFS(root.val, ref count, root.left);
            if (root.right != null)
                DFS(root.val, ref count, root.right);
            return count;


        }

        void DFS(int topval, ref int count, TreeNode node)
        {
            if (node.val >= topval)
            {
                count++;
                topval = node.val;
            }

            if (node.left != null)
                DFS(topval, ref count, node.left);
            if (node.right != null)
                DFS(topval, ref count, node.right);

        }



        public int GoodNodes2(TreeNode root)
        {
            var count = 1;
            if (root.left == null && root.right == null)
                return count;

            if (root.left != null)
                DFS2(root.left, root.val, ref count);
            if (root.right != null)
                DFS2(root.right, root.val, ref count);
            return count;

        }

        private void DFS2(TreeNode node, int highval, ref int count)
        {
            highval = Math.Max(highval, node.val);
            if (node.val >= highval)
                count++;
            if (node.left != null)
                DFS2(node.left, highval, ref count);
            if (node.right != null)
                DFS2(node.right, highval, ref count);


        }


        public int ArraySign(int[] nums)
        {
            if (nums.Contains(0))
                return 0;
            Array.Sort(nums);
            var ncount = 0;
            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] < 0)
                    ncount++;
                else
                    break;

            }


            if (ncount % 2 == 0)
                return 1;
            else return -1;

        }


            //Facebook phone interview Jun 16,2021:

            //   1)  https://leetcode.com/problems/add-strings/

            //   2)  https://leetcode.com/problems/random-pick-index/

            //random pick index of largest number in array.
            // test your approach here


            //  https://leetcode.com/problems/cut-off-trees-for-golf-event/
            public int CutOffTree(IList<IList<int>> forest)
        {
            return 0;
        }


        //Works best, and is 56% faster and 52% less memory on leetcode!!
        public string MostCommonWord4(string paragraph, string[] banned)
        {
            var a = paragraph.Length;
            var cleaned = paragraph.ToLower().Split(new char[] { ' ', '!', '?', '\'', ',', ';', '.' }, StringSplitOptions.RemoveEmptyEntries);
            var grp = cleaned.Where(w => !banned.Contains(w)).GroupBy(c => c).OrderByDescending(c => c.Count()).Select(c => c.Key).FirstOrDefault();
            return grp;
        }



        public int NumSubmat2(int[][] mat)
        {
            int r = mat.Length, c = mat[0].Length, result = 0;
            var dp = new int[c];
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    dp[j] = mat[i][j] == 0 ? 0 : dp[j] + 1;
                    int min = dp[j];
                    for (int k = j; k >= 0; k--)
                    {
                        min = Math.Min(min, dp[k]);
                        result += min;
                    }
                }
            }
            return result;
        }



public int FindMin2(int[] nums)
        {

            var left = 0;
            var right = nums.Length;
            var mid = 0;
            //var min = nums[mid];
            while (left < right)
            {
                mid = left + (right - left) / 2;

                if (mid < nums.Length - 1 && nums[mid + 1] < nums[mid])
                {
                    return nums[mid + 1];

                }

                else if (mid > 0 && nums[mid - 1] > nums[mid])
                {
                    return nums[mid];
                }

                if (nums[right] > nums[mid])
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }


            }

            return nums[left];

        }





        //finish this!! - has bugs when adding caching 

        public bool IsMatch(string s, string p)
        {
        
      

        Dictionary<int[],bool> dict = new Dictionary<int[], bool>();




        bool dfs(int i, int j)
        {
                if ( dict.TryGetValue(new int[] { i, j }, out var cached))
                {
                    return cached;
                }
                if (i >= s.Length || j >= p.Length)
                    return true;
                if (j >= p.Length)
                    return false;

                var match = (i < s.Length && j < p.Length && s[i] == p[j] || p[j] == '.');
                if (j+1 < p.Length && p[j+1] == '*')
                {
                    var b = dict[new int[] { i, j }] = dfs(i, j + 2) || (match && dfs(i + 1, j));
                    return b; // dict[new int[] { i, j }];
                }

                if (match)
                {
                    var a = dict[new int[] { i, j }] = dfs(i + 1, j + 1);
                    return a;
                }

                dict[new int[] { i, j }] = false;
                return false;
        }

           return dfs(0, 0);

        }

        public int[] ClosestSumPairs(int[] a, int[] b, int target)
        {
            Array.Sort(a);
            Array.Sort(b);

            var i = a.Length - 1;
            var j = 0;
            var closestpair = new int[] { a[i], b[j] };
            var closest = a[i] + b[j];
            i--;
            j++;
            while (i >= 0 && j < b.Length)
            {
                var currdiff = a[i] + b[j] - target;
                if (Math.Abs(currdiff) < Math.Abs(target - closest))
                {
                    closest = a[i] + b[j];
                    closestpair[0] = a[i];
                    closestpair[1] = b[j];
                }
                if (currdiff == 0)
                    return closestpair;

                if (currdiff < 0)
                    j++;
                else
                    i--;




            }

            return closestpair;
        }

        public bool BuddyStrings(string s, string goal)
        {
            if (s.Length != goal.Length)
                return false;

            var sdict = new SortedDictionary<char, int>();
            var goaldict = new SortedDictionary<char, int>();

            var isdupes = false;
            var isequal = true;
            for (var i = 0; i < s.Length; i++)
            {
                if (i < s.Length - 1 && s[i] == s[i + 1])
                    isdupes = true;
                if (s[i] != goal[i])
                {
                    isequal = false;
                    if (!sdict.ContainsKey(s[i]))
                        sdict.Add(s[i], 1);
                    else
                        sdict[s[i]]++;

                    if (!goaldict.ContainsKey(goal[i]))
                        goaldict.Add(goal[i], 1);
                    else
                        goaldict[goal[i]]++;

                }
            }

            if (isequal && s.GroupBy(s => s).Where(g => g.Count() >= 2).Count() > 0)
                return true;
            if (isdupes && isequal)
                return true;
            if (!isequal && sdict.Count == 2 && sdict.All(sd => sd.Value == 1) && sdict.SequenceEqual(goaldict))
            {
                return true;
            }
            return false;
        }



        public int ArrayPairSum(int[] nums)
        {


            Array.Sort(nums);

            var sum = 0;
            for (var i = 0; i < nums.Length - 1; i += 2)
            {
                sum += Math.Min(nums[i], nums[i + 1]);
            }
            return sum;
        }

        public int Reverse(int x)
        {
            var sb = new StringBuilder();
            if (x < 0)
            { 
                sb.Append('-');
                x *= -1;
            }
            if (x == 0)
                return 0;
            while (x > 0)
            {
                var digit = x % 10;
                x /= 10;
                sb.Append(digit);
            }

            if (Int32.TryParse(sb.ToString(), out var result))
                return result;
            else
                return 0;
        }



        public ListNode AddTwoNumbers2(ListNode l1, ListNode l2)
        {


            var s1 = new Stack<int>();
            var s2 = new Stack<int>();

            while (l1 != null)
            {
                s1.Push(l1.val);
                l1 = l1.next;
            }

            while (l2 != null)
            {
                s2.Push(l2.val);
                l2 = l2.next;
            }
            var carry = 0;
            var newnode = new ListNode(-1);


            while (s1.Count > 0 || s2.Count > 0 || carry == 1)
            {
                var sum = (s1.Count > 0 ? s1.Pop() : 0) + (s2.Count > 0 ? s2.Pop() : 0) + carry;
                carry = sum / 10;
                sum %= 10;
                if (newnode.val == -1)
                    newnode.val = sum;
                else
                {
                    var curnode = new ListNode(sum);
                    curnode.next = newnode;
                    newnode = curnode;
                }


            }

            return newnode;

        }



        public bool ValidMountainArray(int[] arr)
        {
            if (arr.Length < 3)
                return false;
            if (arr[1] < arr[0])
                return false;
            var min = 0;
            var max = 10001;
            var increasing = true;
            for (var i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i + 1] == arr[i])
                    return false;

                if (increasing)
                {
                    if (arr[i + 1] > arr[i])
                        max = Math.Max(max, arr[i + 1]);
                    else
                        increasing = false;
                }
                else
                {
                    if (arr[i + 1] > arr[i])
                        return false;
                }
            }
            if (increasing)
                return false;
            else
                return true;
        }


        public string MostCommonWord3(string paragraph, string[] banned)
        {


            var trimcomma = paragraph.Replace(',', ' ');

            var words = trimcomma.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            for (var i = 0; i < words.Length; i++)
            {
                words[i] = words[i].TrimEnd(new char[] { '!', '?', '\'', ',', ';', '.' }).ToLower();
            }



            var dict = new Dictionary<string, int>();

            for (var i = 0; i < words.Length; i++)
            {
                var lower = words[i];
                if (!banned.Contains(lower))
                {
                    if (!dict.ContainsKey(lower))
                        dict.Add(lower, 1);
                    else
                        dict[lower]++;
                }
            }

            var max = dict.OrderByDescending(d => d.Value).FirstOrDefault();

            return max.Key;
        }





        public int MinConferenceRooms(int[][] rooms)
        {

            if (rooms.Length <= 1)
                return rooms.Length;

            // Array.Sort(rooms);
            //rooms.Sort( ((x, y) => x[0] < y[0]); // nlogn
            var bookedrooms = new List<int>();



            //bookedrooms.AddSorted(rooms[0][1]);
            //test  addsorted
            bookedrooms.AddSorted(30);
            bookedrooms.AddSorted(20);
            bookedrooms.AddSorted(40);
            bookedrooms.AddSorted(10);
            bookedrooms.AddSorted(30);




            for (var i = 1; i < rooms.Length; i++)
            {


                if (bookedrooms[0] < rooms[i][0])
                {
                    bookedrooms.Remove(bookedrooms[0]);

                    bookedrooms.AddSorted(rooms[i][1]);
                }
                else
                    bookedrooms.AddSorted(rooms[i][1]);

            }

            return bookedrooms.Count;


        }





        public string LongestPalindrome(string s)
        {

            var a = new int[4];

           


            if (s.Length == 1)
                return s;
            if (s.Length == 2)
            {
                if (s[0] == s[1])
                    return s;
                else
                    return s[0].ToString();
            }
            var max = 0;
            var maxstr = new StringBuilder(); 
            var l = 0;
            var r = 0;

            for (var i = 0; i < s.Length; i++)
            {


                l = i;
                r = i;
                while (l >= 0 && r < s.Length && s[l] == s[r])
                {
                    if (r - l + 1 > max)
                    {
                        max = r - l + 1;
                        maxstr.Clear();
                        maxstr.Append(s.Substring(l, r - l + 1));
                    }
                    l--;
                    r++;
                }


                l = i;
                r = i + 1;
                while (l >= 0 && r < s.Length && s[l] == s[r])
                {
                    if (r - l + 1 > max)
                    {

                        max = r - l + 1;
                        maxstr.Clear();
                        maxstr.Append(s.Substring(l, r - l + 1));
                    }
                    l--;
                    r++;
                }

            }
            return maxstr.ToString();
        }


        public string AddStrings2(string num1, string num2)
        {

            var carry = 0;
            var i = 1;
            var sb = new StringBuilder();
            while (carry == 1 || (num1.Length - i > -1) || (num2.Length - i > -1))
            {

                var sum = ((num1.Length - i > -1) ? (num1[num1.Length - i] - '0') : 0) + ((num2.Length - i > -1) ? (num2[num2.Length - i] - '0') : 0) + carry;
        
                carry = sum / 10;
                sum %= 10;
                sb.Insert(0, sum);
                i++;
            }

            return sb.ToString();

        }

        public bool IsPalindrome(int x)
        {
            if (x < 0)
                return false;
            var dig = Math.Floor(Math.Log10(x) + 1);
            Console.WriteLine(dig);

            var lmult = Math.Pow(10, dig - 1);
            Console.WriteLine(lmult);
            var ints = new List<int>();
            var multiplier = 10;
            while (x > 0)
            {
                var result = x % 10;
                Console.WriteLine(result);
                ints.Add(result); // / (multiplier / 10));
                x /= 10;
                //multiplier *= 10;
            }

            var r = ints.Count - 1;
            for (var l = 0; l < r; l++)
            {
                if (ints[l] != ints[r])
                    return false;
                r--;
            }

            return true;
        }



        public int LengthLongestPath2(string input)
        {

            var split = input.Split('\n');
            var max = 0;
            var level = 0;
            var levels = new List<int>();

            for (var i = 0; i < split.Length; i++)
            {
                var len = split[i];
                var trimmed = split[i].TrimStart('\t');
                var numtabs = len.Length - trimmed.Length;

                level = numtabs;

                if (levels.Count <= level)
                    levels.Add(0);
                levels[level] = trimmed.Length + (numtabs > 0 ? 1 : 0);

                if (trimmed.Contains('.'))
                {
                    var total = 0;
                    for (var j = 0; j <= level; j++)
                    {
                        total += levels[j];
                    }
                    max = Math.Max(max, total);
                }
            }

            return max;

        }
    







    public string LicenseKeyFormatting(string s, int k)
        {
            var sb = new StringBuilder();
            var c = k;
            for (var i = s.Length - 1; i >= 0; i--)
            {
                if (c == 0) // && i > 0 && s[i-1] != '-')
                { 
                    sb.Insert(0, '-');
                    c = k;
                    i++;
                }
                
                else if (s[i] != '-')
                {
                    sb.Insert(0, char.ToUpper(s[i]));
                    c--;
                }
            }

            
            
            var r = sb.ToString();
            r = r.TrimStart('-');
            return r;


        }


        public int minOperations(int[] arr)
        {
            var s = "s";
            var t = s.ToUpper();
            
            var q = new Queue<Node3>();

            var original = new int[arr.Length];
            arr.CopyTo(original,0);
            Array.Sort(arr);


            if (arr.SequenceEqual(original))
                return 0;
            q.Enqueue(new Node3(original,  0 ));


            while (q.Count > 0)
            {
                var temp = q.Dequeue();
                //var newperm = new int[temp.perm.Length];
                //temp.perm.CopyTo(newperm,0);

                for (var i = 2; i<= temp.perm.Length; i++)
                {
                    var reversed = ReverseThis(temp.perm, i);
                    if (reversed.SequenceEqual(arr))
                        return temp.steps + 1;
                    q.Enqueue(new Node3(reversed, temp.steps + 1));
                }
            }
            return 0;

        }

        private int[] ReverseThis(int[] arr, int index)
        {
            var copy = new int[arr.Length];
            arr.CopyTo(copy, 0);
            var temp = 0;
            for (var i = 0; i < index-1; i++)
            {
                temp = copy[i];
                copy[i] = copy[index - 1];
                copy[index - 1] = temp;
                index--;
            }

            return copy;
           
        }




        // function to find minimum prefix reversal through BFS
        public int minimumPrefixReversals(int[] a)
        {
            // size of array
            int n = a.Length;

            // string for initial and goal nodes
            String start = "", destination = "";

            // string for manipulation in while loop
            String original = "", modified = "";

            // node to store temporary values
            // from front of queue
            Node2 temp = null;

            // create the starting string
            for (int i = 0; i < n; i++)
                start += a[i];

            // sort the array and prepare
            // final destination string
            Array.Sort(a);
            for (int i = 0; i < n; i++)
                destination += a[i];

            // this queue will store all the BFS siblings
            Queue<Node2> q = new Queue<Node2>();

            // place the starting node in queue
            q.Enqueue(new Node2(start, 0));

            //base case:- if array is already sorted
            if (start == destination)
                return 0;


            // loop until the size of queue is empty
            while (q.Count != 0)
            {
                // put front node of queue in temporary variable
                temp = q.Dequeue();

                // store the original string at this step
                original = temp.str;

                for (int j = 2; j <= n; j++)
                {
                    // modified will be used to generate all
                    // manipulation of original string
                    // like if original = 1342
                    // modified = 3142 , 4312 , 2431

                    modified = original;

                    // generate the permutation by reversing
                    modified = reverse(modified, j);

                    if (modified.Equals(destination))
                    {
                        // if string match then return
                        // the height of the current node
                        return temp.steps + 1;
                    }

                    // else put this node into queue
                    q.Enqueue(new Node2(modified, temp.steps + 1));
                }
            }

            // if no case match then default value
            return int.MinValue;
        }

        // function to reverse the string upto an index
        public static String reverse(String s, int index)
        {
            char[] temp = s.ToCharArray();
            int i = 0;
            while (i < index)
            {
                char c = temp[i];
                temp[i] = temp[index - 1];
                temp[index - 1] = c;
                i++; index--;
            }
            return String.Join("", temp);
        }









        public int countDistinctTriangles(int[,] arr)
        {
            
            var hash = new HashSet<int>();
            for (var i = 0; i < arr.GetLength(0) ; i++)
            {
                var newlist = new List<int>() { arr[i, 0], arr[i, 1], arr[i, 2] };
                newlist.Sort();
                var newnum = newlist[2] + newlist[1] * 10 + newlist[0] * 100;
                hash.Add(newnum);
                
            }

            return hash.Count;

        }

        public  bool balancedSplitExists(int[] arr)
        {

            Array.Sort(arr);
            var rightsum = 0;

            for (var i = arr.Length - 1; i > 0; i--)
            {
                rightsum += arr[i];
                var leftsum = 0;
                var j = 0;
                for (j = i - 1; j >= 0; j--)
                {
                    leftsum += arr[j];
                }
                if (leftsum == rightsum)
                {
                    Console.WriteLine("i: " + arr[i] + "J: " + arr[i-1]);
                    if (arr[i] == arr[i-1])
                        return false;
                    else
                        return true;
                }
            }
            return false;
        }


        public int GetBillionUsersDay(float[] growthRates)
        {
            var gr = growthRates.OrderByDescending(g => g).FirstOrDefault();
            Console.WriteLine("top growthrate: " + gr);
            var growth = Math.Ceiling(Math.Log(1000000000, gr));
            return Convert.ToInt32(growth);
        }

        public int[] getMilestoneDays(int[] revenues, int[] milestones)
        {
            var total = 0;
            var results = new List<int>();
            var j = 0;
            
            for (var i = 0; i < revenues.Length; i++)
            {
                total += revenues[i];
                if (total >= milestones[j])
                {
                    results.Add(i + 1);
                    j++;
                }
                
            }

            return results.ToArray();
        }


        //Time:  O(N Log N)  -  Space:  O(N)  new array
        public int minOverallAwkwardness(int[] arr)
        {

            Array.Sort(arr);   //Log N
            var newarr = new int[arr.Length];
            var l = 0;
            var r = arr.Length - 1;
            var i = 0;
            while (l < r)    //N
            {
                newarr[l++] = arr[i++];
                newarr[r--] = arr[i++];

            }


            var diff = 0;
            for (var j = 0; j < newarr.Length; j++)   //N
            {
                if (j < newarr.Length - 1)
                    diff = Math.Max(diff, Math.Abs(newarr[j] - newarr[j + 1]));
                else
                    diff = Math.Max(diff, Math.Abs(newarr[j] - newarr[0]));
            }

            return diff;
        }
    

    public  int[] findMinArray(int[] arr, int k)
        {
            var len = arr.Length;
            var pos = 0;
            for (var i = 0; i < len - 1 && k > 0; i++)
            {
                pos = i;
                for (var j = i + 1; j < len; j++)
                {
                    if (j - i > k)
                        break;  
                    if (arr[j] < arr[pos])
                        pos = j;

                    Console.WriteLine("pos=" + pos);
                }

                //Swap elements if smaller ones found
                for (var l = pos; l > i; l--)
                {
                    Console.WriteLine("BEFORE swap: arr[l-1]: " + arr[l - 1] + " arr[l]: " + arr[l]);
                    var temp = arr[l];
                    arr[l] = arr[l - 1];
                    arr[l - 1] = temp;
                    Console.WriteLine("After swap: arr[l-1]: " + arr[l - 1] + " arr[l]: " + arr[l]);

                }
                k -= pos - i;
            }
            return arr;
        }



        public  int getTotalTime(int[] arr)
        {

            MaxHeap heap = new MaxHeap(arr.Length);
            
            var total = 0;
            var arrlst = arr.ToList();

            for (var i = 0; i < arr.Length; i++)
            {
                heap.Add(arr[i]);
            }

            while (heap.Count() > 1)
            {

                var a = heap.Pop();
                var b = heap.Pop();
                total += a + b;
                heap.Add(a + b);

            }

           

            return total;
        }


        public int[] findMedian(int[] arr)
        {

          
            var output = new int[arr.Length];
            var median = 0;
            for (var i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 0)
                {
                    median = arr.Take(i + 1).OrderBy(x => x).Skip(i / 2).Take(1).SingleOrDefault();
                }
                else
                {
                    median = arr.Take(i + 1).OrderBy(x => x).Skip((i + 1) / 2 - 1).Take(2).Sum() / 2;
                }

                output[i] = median;
            }
            return output;

        }

        public  int maxCandies(int[] arr, int k)
        {
            // Write your code here
            //Create a  max heap (priority queue)  and use instead of max.  ??  Try it out
            var candies = 0;

            while (k > 0)
            {
                var max = arr.Max();
                candies += max;
                var index = Array.IndexOf(arr, max);
                max /= 2;
                arr[index] = max;
                k--;
            }
            return candies;

        }







        public string MinWindow(string s, string t)
        {


            var dicts = new Dictionary<char, int>();
            var dictt = new Dictionary<char, int>();


          

            for (var i = 0; i < t.Length; i++)
            {
                if (!dictt.ContainsKey(t[i]))
                    dictt.Add(t[i], 1);
                else
                    dictt[t[i]]++;
            }
            var minlen = s.Length;
            var minlenstr = "";
            var len = s.Length;
            var l = 0;
            var r = 0;
            var found = false;

            while (l < len && r < len)
            {

                if (!found)
                {

                    if (dictt.ContainsKey(s[r]))
                    {
                        var val = 0;
                        if (dicts.TryGetValue(s[r], out val))
                            dicts[s[r]]++;
                        else
                            dicts.Add(s[r], 1);
                    }


                    if (CompKeys(dicts, dictt))
                    {

                        found = true;
                    }
                    else
                        r++;
                    if (r == len)
                        break;

                }
                if (found)
                {
                    if ( (r - l + 1) < minlen || (r - l + 1) == len)
                    {
                        minlen = r - l + 1;
                        minlenstr = s.Substring(l, r - l + 1);
                    }
                    var valtoremove = 0;
                    if (dicts.TryGetValue(s[l], out valtoremove))
                    {
                        if (valtoremove > 1)
                            dicts[s[l]]--;
                        else
                            dicts.Remove(s[l]);
                    }
                    l++;
                    if (!CompKeys(dicts, dictt))
                    {
                        found = false;
                        r++;
                    }
                }

            }

            return minlenstr;



        }






            public  int minLengthSubstring(String s, String t)  // Facebook Portal
        {

            var dicts = new Dictionary<char, int>();
            var dictt = new Dictionary<char, int>();

        


            for (var i = 0; i < t.Length; i++)
            {
                if (!dictt.ContainsKey(t[i]))
                    dictt.Add(t[i], 1);
                else
                    dictt[t[i]]++;
            }
            var minlen = s.Length;
            var len = s.Length;
            var l = 0;
            var r = 0;
            var found = false;

            while (l < len && r < len)
            {

                if (!found)
                {

                    if (dictt.ContainsKey(s[r]))
                    {
                        var val = 0;
                        if (dicts.TryGetValue(s[r], out val))
                            dicts[s[r]]++;
                        else
                            dicts.Add(s[r], 1);
                    }
                    
                   
                    if (CompKeys(dicts, dictt))
                    {

                        found = true;
                    }
                    else
                        r++;
                    if (r == len)
                        break;

                }
                if (found)
                {
                    minlen = Math.Min(minlen, r - l + 1);
                    var valtoremove = 0;
                    if (dicts.TryGetValue(s[l], out valtoremove))
                    {
                        if (valtoremove > 1)
                            dicts[s[l]]--;
                        else
                            dicts.Remove(s[l]);
                    }
                    l++;
                    if (!CompKeys(dicts, dictt))
                    {
                        found = false;
                        r++;
                    }
                }

            }

            return minlen;

        }

        public bool CompKeys(Dictionary<char, int> dicts, Dictionary<char, int> dictt)
        {
            if (dicts.Count != dictt.Count)
                return false;

            foreach (var pair in dictt)
            {
                var val = 0;
                if (dicts.TryGetValue(pair.Key, out val))
                {
                    if (val < pair.Value)
                        return false;
                }
                else
                    return false;
            }
            return true;
        }



        public int matchingPairs(string s, string t)
        {

            var dicts = new Dictionary<char, int>() { { 'b', 2 }, { 'e', 1 } };
            var dictt = new Dictionary<char, int>() { { 'b', 3 }, { 'e', 1 } };

            var diff = dicts.Except(dictt);

            var sc = dicts.Count();
            var tc = dictt.Count();

            var ss = diff.Count();


            var len = s.Length;
            if (s == t)
            {
                return s.Length - 2;
            }

            var unmatchs = new HashSet<int>();
            var unmatcht = new HashSet<int>();


            var matched = 0;

            for (var i = 0; i < s.Length; i++)
            {
                if (s[i] == t[i])
                    matched++;
                else
                {
                    unmatchs.Add(s[i]);
                    unmatcht.Add(t[i]);
                }
            }

            var dupeunmatched = unmatchs.Intersect(unmatcht);

            var dupescount = dupeunmatched.Count();
            if (dupescount >= 2)
            {
                matched += 2;
            }
            else if (dupescount == 1)
            {
                matched++;
            }
            else if (len - matched == 0)
                matched -= 2;
            else if (len - matched == 1)
                matched--;


            // Write your code here
            return matched;
        }


        static int[] countOfNodes(Node root, List<Query> queries, String s)
        {

            var output = new List<int>();

            for (var i = 0; i < queries.Count; i++)
            {
                var count = 0;
                for (var j = queries[i].u - 1; j < s.Length; j++)
                {
                    if (s[j] == queries[i].c)
                    {
                        count++;
                    }
                }
                output.Add(count);


            }

            return output.ToArray();
        }






    public int VisibleNodes(TreeNode root) //should be a treenode with right and left.
        {
            if (root == null)
                return 0;
            var leftdepth = VisibleNodes(root.left);
            var rightdepth = VisibleNodes(root.right);
            if (leftdepth > rightdepth)
                return leftdepth + 1;
            else
                return rightdepth + 1;
        }



        public int FindMaxPopulation(Person[] people)
        {
           // var sorted = people.OrderBy(p => p.Born).ThenBy(p => p.Death).ToList();
            var alive = 0;
            var max = 0;
            var year = 0;


            var orderedbd = CombineDeathBirths(people);

            for (var i = 0; i < orderedbd.Count; i++)
            {
                if (orderedbd[i][1] == 1)
                {
                    alive++;
                    if (alive > max)
                    {
                        max = alive;
                        year = orderedbd[i][0];
                    }
                }
                else
                    alive--;
                    

            }



            return year;




        }


        private List<int[]> CombineDeathBirths(Person[] people)
        {

            var results = new List<int[]>();



            for (var i = 0; i < people.Length; i++)
            {
                results.Add(
                    new int[2]
                    {
                        people[i].Born,
                        1
                    });

                results.Add(
                    new int[2]
                    {
                        people[i].Death+1,
                        0
                    });

            }

            return results.OrderBy(r => r[0]).ToList();


        }
        
        
        public int[] findMaxProduct(int[] arr)
        {
            var output = new int[arr.Length];
            for (var i = 0; i < arr.Length; i++)
            {
                output[i] = i < 2 ? -1 : arr[i] * arr[i - 1] * arr[i - 2];
            }
            // Write your code here
            return output;
        }

        public int[] findSignatureCounts(int[] arr)
        {

           // var pq = new PriorityQueue<int, int>();

            var len = arr.Length;
            var signatures = new int[len];
            var numsignatures = 1;
            Array.Fill(signatures, numsignatures);
            numsignatures++;
            var yearbooks = arr.ToArray();
            var sortedyearbooks = arr.ToArray();
            Array.Sort(sortedyearbooks);

            while (!IsSorted(yearbooks))
            {
                Array.Fill(signatures, numsignatures++);
                for (var i = 0; i < len; i++)
                {
                    yearbooks[arr[i] - 1] = arr[i];
                }

            }


            return signatures;
        }

        public bool IsSorted(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i - 1] > arr[i])
                {
                    return false;
                }
            }
            return true;
        }



        



        private int[] _denominations;
        public bool canGetExactChange(int targetMoney, int[] denominations)
        {
            _denominations = denominations;
            return doDenom(targetMoney, 0);
        }

        private bool doDenom(int money, int index)
        {
            if (money == 0)
                return true;
            if (index == _denominations.Length)
                return false;

            bool include = false;
            bool exclude = false;

           
            if (money >= _denominations[index])
                include = doDenom(money - _denominations[index], index);

            exclude = doDenom(money, index + 1);

            return include || exclude;
        }


        private static String findEncryptedWord(String s)
        {

            if (String.IsNullOrEmpty(s))
                return "";

            var midx = (s.Length - 1) / 2;
            var m = s[midx];

            return "";
        }



        public string isBalanced(string s)
        {
            if (s.Length <= 1)
                return "NO";
            var stack = new Stack<char>();

            for (var i = 0; i < s.Length; i++)
            {
                switch (s[i])
                {
                    case '(':
                    case '{':
                    case '[':
                        stack.Push(s[i]);
                        break;
                    case ')':
                        if (stack.Count == 0 || stack.Pop() != '(')
                            return "NO";
                        break;
                    case '}':
                        if (stack.Count == 0 || stack.Pop() != '{') return "NO";
                        break;
                    case ']':
                        if (stack.Count == 0 || stack.Pop() != '[')
                            return "NO";
                        break;
                    default:
                        break;

                }
            }
            if (stack.Count > 0)
                return "NO";
            else
                return "YES";
        }


        public int[] findPositions(int[] arr, int x)
        {


            var results = new List<int>();
            var newlist = new List<int[]>();
            for (var i = 0; i < arr.Length; i++)
            {
                newlist.Add(new int[] { i + 1, arr[i] });
            }

            for (var i = 0; i < x; i++)
            {
                var c = x;
                var max = new int[2];
                var templist = new List<int[]>();
                while (newlist.Count > 0 && c > 0)
                {
                    var r = newlist[0];

                    newlist.RemoveAt(0);
                    if (r[1] > max[1])
                        max = r;

                    templist.Add((r[1] - 1 >= 0) ? new int[] { r[0], r[1] - 1 } : new int[] { r[0], 0 });

                    c--;
                }
                if (max[0] == 0)
                    max[0] = templist[0][0];

                templist.Remove(templist.Single(t => t[0] == max[0]));

                results.Add(max[0]);
                newlist.AddRange(templist);
                foreach (var nl in newlist)
                {
                    Console.WriteLine(nl[0]);
                }
                Console.WriteLine("*******");
            }


            return results.ToArray();
        }






        public ListNode ReverseList2(ListNode head)
        {
            ListNode prev = null;
            while (head != null)
            {
                (head.next, prev, head)  = (prev, head, head.next);
            }
            return prev;
        }


        public static Node reverse(Node head)
        {
            var node = head;
            var odd = head;
            while (node != null)
            {
                if (node.next != null && node.next.val % 2 == 0)
                {
                    var stack = new Stack<int>();
                    while (node.next != null && node.next.val % 2 == 0)
                    {
                        stack.Push(node.next.val);
                        node = node.next;
                    }
                    node = node.next;
                    while (stack.Count > 0)
                    {
                        odd.next.val = stack.Pop();
                        odd = odd.next;
                    }
                    odd = odd.next;
                }
                else
                    node = node.next;

            }
            return head;
        }


        public string rotationalCipher(String input, int rotationFactor)
        {

            var sb = new StringBuilder();
            var rf = 0;
            char output;
            for (var i = 0; i < input.Length; i++)
            {
                if (input[i] <= 'z' && input[i] >= 'a')
                {
                    rf = rotationFactor % 26;
                    if (input[i] + rf > 'z')
                        output = (char)(input[i] + rf - 26);
                    else
                        output = (char)(input[i] + rf);
                    
                  
                    sb.Append(output);

                }
                else if (input[i] >= 'A' && input[i] <= 'Z')
                {
                    rf = rotationFactor % 26;
                    
                    if (input[i] + rf > 'Z')
                        output = (char)(input[i] + rf - 26);
                    else
                        output = (char)(input[i] + rf);

                  
                    sb.Append(output);
                }
                else if (input[i] <= '9' && input[i] >= '0')
                {
                    rf = rotationFactor % 10;
                  
                    if (input[i] + rf > '9')
                        output = (char)(input[i] + rf - 10);
                    else
                        output = (char)(input[i] + rf);
                    sb.Append(output);

                }
                else
                    sb.Append(input[i]);

            }

            return sb.ToString();
        


    }



        //Get this working and learn it
        //int[] countSubarrays(int[] arr)
        //{
        //    // Write your code here
        //    Stack<int> s = new Stack<int>();
        //    int[] L = new int[arr.Length];
        //    L[0] = 1;
        //    s.Push(0);
        //    for (int i = 1; i < arr.Length; i++)
        //    {
        //        while (!s.isEmpty() && arr[s.peek()] < arr[i]) s.pop();
        //        if (s.isEmpty()) L[i] = i + 1;
        //        else L[i] = i - s.peek();
        //        s.push(i);
        //    }
        //    int[] R = new int[arr.length];
        //    R[arr.length - 1] = L[arr.length - 1];
        //    s.clear();
        //    s.push(arr.length - 1);
        //    for (int i = arr.length - 2; i >= 0; i--)
        //    {
        //        while (!s.isEmpty() && arr[s.peek()] < arr[i]) s.pop();
        //        if (s.isEmpty()) R[i] = (arr.length - i) + L[i] - 1;
        //        else R[i] = (s.peek() - i) + L[i] - 1;
        //        s.push(i);
        //    }
        //    return R;
        //}




        public int MaxSubArray3(int[] nums)
        {
            var max = nums[0];
            for (var i = 1; i < nums.Length; i++)
            {
                if (nums[i - 1] > 0)
                    nums[i] += nums[i - 1];
                max = Math.Max(max, nums[i]);

            }
            return max;

        }


        //O(n2) - not good
        private static int[] countSubarrays(int[] arr)
        {
            var result = new int[arr.Length];
            var forward = 0;
            var backward = 0;
            var count = 0;

            for (var i = 0; i < arr.Length; i++)
            {

                count = 1;  //all elements have an array of themselves;
                backward = i - 1;
                while (backward >= 0 && arr[backward] < arr[i])
                {
                    count++;
                    backward--;
                }

                forward = i + 1;
                while (forward < arr.Length && arr[forward] < arr[i])
                {
                    count++;
                    forward++;
                }


                result[i] = count;



            }


            return result;






        }
   



    internal int numberOfWays2(int[] arr, int k)
        {
            var n = arr.Length;
            var sum = k;
            Dictionary<int, int> hm
          = new Dictionary<int, int>();
 
        
        for (int i = 0; i<n; i++) {

          
                if (!hm.ContainsKey(arr[i]))
                {
                    hm[arr[i]] = 1;
                }
                else
                    hm[arr[i]]++;
          
                }
        int twice_count = 0;

        // iterate through each element and
        // increment the count (Notice that
        // every pair is counted twice)
        for (int i = 0; i < n; i++)
        {
            int val = 0;
            if (hm.TryGetValue(sum - arr[i], out val)) 
            {
                    twice_count += val; // ValueTuple; ValueTuple; // hm[sum - arr[i]];
            }

            // if (arr[i], arr[i]) pair satisfies
            // the condition, then we need to ensure
            // that the count is decreased by one
            // such that the (arr[i], arr[i])
            // pair is not considered
            if (sum - arr[i] == arr[i])
            {
                twice_count--;
            }
        }

// return the half of twice_count
return twice_count / 2;
}

internal int numberOfWays(int[] arr, int k)
        {
            // Write your code here
            var count = 0;
            for (var i = 0; i < arr.Length - 1; i++)
                for (var j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] + arr[j] == k)
                        count++;
                }
            Console.WriteLine(count);
            return count;
            
        }




        public void Rotate(int[][] matrix)
        {
            var len = matrix.Length;
            for (var i = 0; i < len; i++)
            {
                for (var j = i; j < len; j++)
                {
                    if (i != j)
                    (matrix[i][j], matrix[j][i]) = (matrix[j][i], matrix[i][j]);
                }




            }

            for (var i = 0; i < len; i++)
            {
                for (var j = 0; j < (len / 2); j++)
                {
                    (matrix[i][j], matrix[i][len - j - 1]) = (matrix[i][len - j - 1], matrix[i][j]);


                }
            }
            
        }



        public ListNode AddTwoNumbers9(ListNode l1, ListNode l2)
        {

            var carry = 0;
            ListNode newnode = new ListNode(-1);
            var head = newnode;
            while (l1 != null || l2 != null || carry == 1)
            {
                var sum = (l1?.val ?? 0) + (l2?.val ?? 0) + carry;
                carry = sum / 10;
                sum %= 10;

                l1 = l1?.next;
                l2 = l2?.next;

                if (newnode.val == -1)
                    newnode.val = sum;
                else
                {
                    newnode.next = new ListNode(sum);
                    newnode = newnode.next;
                }
            }

            return head;


        }



        public int UniquePaths(int m, int n)
        {

            var dp = new int[m, n];
            for (var i = 0; i < m; i++)
            {
                for (var j = 0; j < n; j++)
                {
                    if (i == 0 || j == 0)
                    {
                        dp[i, j] = 1;
                    }
                    else
                        dp[i, j] = dp[i - 1, j] + dp[i, j - 1];
                }
            }

            return dp[m - 1, n - 1];
        }


        public int Search2(int[] nums, int target)
        {
            var start = 0;
            var len = nums.Length;
            var end = len - 1;
            var mid = start + (end - start) / 2;
            while (start <= end)
            {
                if (nums[mid] == target)
                    return mid;
                else if (nums[mid] <= nums[end])
                { 
                    if (target >= nums[mid] && target <= nums[end])
                    
                        start = mid + 1;

                    
                    else
                        end = mid - 1;
                }
                else
                {
                    if (target >= nums[start]
                    && target <= nums[mid])
                    
                        end = mid - 1;

                    
                    else
                        start = mid + 1;
                }

                mid = start + (end - start) / 2;
            }
            return -1;


        }



        public int[] SearchRange(int[] nums, int target)
        {
            var low = 0;
            var high = nums.Length - 1;
            var mid = high / 2;

            var results = new int[2];

            while (low <= high)
            {
                if (nums[mid] < target)
                    low = mid + 1;

                if (nums[mid] >= target)
                    high = mid - 1;
                mid = low +  ((high - low) / 2);
            }
            if (low > nums.Length -1 || nums[low] != target)
                return new int[] { -1, -1 };
            else
                results[0] = low;

            high = nums.Length - 1;
            mid = low + ((high - low) / 2);

            while (low <= high)
            {
                if (nums[mid] <= target)
                    low = mid + 1;

                if (nums[mid] > target)
                    high = mid - 1;
                mid = low + ((high - low) / 2);

            }
            if (high > nums.Length -1 || nums[high] != target)
                return new int[] { -1, -1 };
            else
                results[1] = high;
            return results;


        }








        //https://leetcode.com/problems/clone-graph/


        Dictionary<int, GraphNode> dict2 = new Dictionary<int, GraphNode>();
        public GraphNode CloneGraph(GraphNode node)
        {
            if (dict2.ContainsKey(node.val))
                return dict2[node.val];
            var newnode = new GraphNode(node.val);
            dict2.Add(newnode.val, newnode);
            foreach (var n in node.neighbors)
                newnode.neighbors.Add(CloneGraph(n));
            return newnode;
        }


        public GraphNode CloneGraph2(GraphNode node)
        {
            //var table = new Hashtable();
            //table.
            var hash = new HashSet<GraphNode>();
            var root = new GraphNode(node.val);
            
            
            DoClone(node, hash);
            return root;
        }


        private void DoClone(GraphNode node, HashSet<GraphNode> visited)
        {
            if (node == null)
                return;

            var actual = new GraphNode();
            if (!visited.TryGetValue(node, out actual))
            {
                var newnode = new GraphNode(node.val);
                newnode.neighbors = new List<GraphNode>(node.neighbors);
                visited.Add(newnode);
            }
            
            foreach (var v in node.neighbors)
            {
                if (v != null)
                    DoClone(v, visited);
            }
        }


        //Do integer break https://leetcode.com/problems/integer-break/
        public int IntegerBreak(int n)
        {

            if (n <= 2)
                return 1;
            else if (n == 3)
                return 2;

            var threes = n / 3;
            var twos = 0;
            if (n % 3 == 1)
            {
                threes--;
                twos = 2;
            }
            else if (n % 3 == 2)
            {
                twos = 1;
            }
            var result = (int)(Math.Pow(3, threes) * Math.Pow(2, twos));
            return result;

        }
        //get min heap and priority queue figured out.


        //Create in C#:
        internal void GetAllSubSets(int []v, List<int[]> sets)
        {
            //def get_all_subsets(v, sets):
            var subsets_count = 2 * v.Length;
            for (var i = 0; i < subsets_count; i++)
            {
                // for i in range(0, subsets_count) :
                var st = new int[] { };
                for (var j = 0; j < v.Length; j++)
                {
                    if (GetBit(i, j) == 1)
                    {
                        st.Append(v[j]);
                        sets.Add(st);
                    }
                }
            }

        }

        internal int GetBit(int num, int bit)
        {
            // def get_bit(num, bit):
            var temp = (1 << bit);
            temp = temp & num;
            if (temp == 0)
                return 0;
            return 1;
        }



        internal double Power(double x, int n)
        {
            var negative = false;
                if (n < 0)
            {
                n *= -1;
                negative = true;
            }

            var p =PowerRecurse(x, n);

            return negative ? 1/ p : p;

        }

        private double PowerRecurse(double x, int n)
        {
            if (n == 0)
                return 1;
            else if (n == 1)
                return x;
            
            var p = PowerRecurse(x, n / 2);
            if (n % 2 == 0)
                return p * p;
            else
                return x * p * p;

        }




        internal void LevelOrderTraversal(TreeNode root)
        {
            var currentqueue = new Queue<TreeNode>();
            var nextqueue = new Queue<TreeNode>();

            currentqueue.Enqueue(root);
           // var level = 0;
            

            while (currentqueue.Count > 0)
            {
                var node = currentqueue.Dequeue();
                Console.Write(node.val + " ");

                if (node.left != null)
                    nextqueue.Enqueue(node.left);

                if (node.right != null)
                    nextqueue.Enqueue(node.right);

                if (currentqueue.Count == 0)
                {
                    Console.WriteLine();
                    (nextqueue, currentqueue) = (currentqueue, nextqueue);
                   // level++;
                }

            }

        }



        internal int MaxProfitBestVersion(int[] prices)
        {
            var maxprofit = 0;
            var minprice = 10001; //Or whatever the maximum price could be + 1

            for (var i = 0; i < prices.Length; i++)
            {
                if (prices[i] < minprice)
                    minprice = prices[i];
                else
                    maxprofit = Math.Max(maxprofit, prices[i] - minprice);
            }
            return maxprofit;
        }






        internal void move_zeros_to_left(int[] n)
        {

            //1 10 20 59 0 3 0 4 0 88 --> 0 0 0 1 10 20 59 3 4 88
            //2 pointer
            //write pointer, read pointer, etc... start from end move to start.
            var len = n.Length;
            var write = len - 1;
            var read = len - 1;
            while (read >= 0)
            {
                if (n[read] != 0 )
                {
                    n[write] = n[read];
                    write--;
                }
                read--;
            }

            while (write >=0)
            {
                n[write] = 0;
                write--;
            }

        }

        //do this!!  done
        //public string RemoveKdigits(string num, int k)
        //{
        //    var stack = new Stack<char>();
        //    var len = num.Length;

        //    for (var i = 0; i < len; i++ )
        //    {

        //    }


        //}
        //Fibonacci same thing
        public int ClimbStairsnorecursion(int n)
        {
            if (n <= 2)
                return n;
            var dp = new int[n + 1];

            dp[1] = 1;
            dp[2] = 2;
            for (var i = 3; i <= n; i++)
                dp[i] = dp[i - 1] + dp[i - 2];

            return dp[n];

        }



        public int FindDuplicate(int[] nums)
        {
            Array.Sort(nums);
            for (var i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] == nums[i + 1])
                    return nums[i];
            }
            return 0;
        }






        public int SingleNumber(int[] nums)
        {
            var singleNumber = 0;
            foreach (var num in nums)
            {
                singleNumber ^= num;
            }
            return singleNumber;
        }



        public IList<int> FindDisappearedNumbers2(int[] nums)
        {
            var result = new List<int>();
            for (var i = 0; i < nums.Length; i++)
            {
                var j = Math.Abs(nums[i]);
                
                nums[j - 1] *= nums[j - 1] < 0 ? nums[j - 1] : nums[j - 1] * -1; // Math.Abs(nums[j - 1]) * -1;
            }

          
            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                {
                    result.Add(i + 1);
                }
            }

            return result;
        }




        public void SortColors2(int[] nums)
        {
            var left = 0;
            var right = nums.Length - 1;

            for (var i = 0; i <= right; i++)
            {
                if (nums[i] == 0)
                {
                    (nums[i], nums[left]) = (nums[left], nums[i]);
                    left++;

                }
                else if (nums[i] == 2)
                {
                    (nums[i], nums[right]) = (nums[right], nums[i]);
                    right--;
                    i--;

                }

            }
        }

        public bool CheckRecord(string s)
        {
            var a = 0;
            var l = 0;

            for (var i = 0; i < s.Length; i++)
            {
                if (s[i] == 'L')
                    l++;
                else
                {
                    if (s[i] == 'A')
                    {
                        a++;
                    }
                    l = 0;
                }
                if (a > 1)
                    return false;
                else if (l > 2)
                    return false;
            }
            return true;
        }

        public IList<string> CommonChars2(string[] A)
        {
            var dict = new Dictionary<char, Dictionary<int, int>>();
            var wordnum = 0;
            for (var i = 0; i < A.Length; i++)
            {
                
                for (var j = 0; j < A[i].Length; j++)
                {
                    if (!dict.ContainsKey(A[i][j]))
                        dict.Add(A[i][j], new Dictionary<int, int>() { { wordnum, 1 } });
                    else
                    {
                        if (!dict[A[i][j]].ContainsKey(wordnum))
                            dict[A[i][j]].Add(wordnum, 1);
                        else
                            dict[A[i][j]][wordnum]++;
                    }
                }
                wordnum++;
            }

            var common = new List<string>();
            foreach (var dd in dict)
            {
                if (dd.Value.Count < A.Length)
                    continue;

                var min = dd.Value.Values.Min();
             
                    for(var j = 1; j <= min; j++)
                    {
                        common.Add(dd.Key.ToString());
                    }
            }
            return common;
        }


        public bool IsLongPressedName(string name, string typed)
        {
            if (name.Length > typed.Length)
                return false;
            int i = 0, j = 0;
            for (; i < name.Length; i++)
            {
                if (i < name.Length && j >= typed.Length)
                    return false;
                if (i < name.Length && j < typed.Length && name[i] != typed[j])
                    return false;
                if (i < name.Length - 1 && name[i] == name[i + 1])
                {
                    j++;
                    continue;
                }

                while (j < typed.Length && name[i] == typed[j])
                {
                    j++;
                }

            }

            if (j < typed.Length)
                return false;
            else
                return true;
        }


        public int HeightChecker(int[] heights)
        {
            var count = 0;
            var sorted = new int[heights.Length];
            Array.Copy(heights, sorted, heights.Length);
            Array.Sort(sorted);
            for (var i = 0; i < sorted.Length; i++)
            {
                if (sorted[i] != heights[i])
                    count++;
            }

            return count;
        }

       



        public string CustomSortString3(string S, string T)
        {
            var sb = new StringBuilder();
            var tl = T.ToList();
            for (var i = 0; i < S.Length; i++)
            {

                var foundat = T.IndexOf(S[i]);
                while (foundat > -1)
                {
                    sb.Append(S[i]);
                    T = T.Remove(foundat, 1);
                    foundat = T.IndexOf(S[i]);
                }



            }
            for (var j = 0; j < T.Length; j++)
                sb.Append(T[j]);
            return sb.ToString();
        }






        public IList<IList<int>> Generate(int numRows)
        {
            var result = new List<IList<int>>();
            for (var i = 0; i < numRows; i++)
            {
                IList<int> row = new List<int>();
                for (var j = 0; j <= i; j++)
                {
                   
                    if (j <= 0 || j == i)
                        row.Add(1);
                    else
                    {
                        if (i > 1)
                        {
                            var n = result[i - 1][j - 1] + result[i - 1][j];
                            row.Add(n);
                        }
                    }
                  
                }
                result.Add(row);

            }
            return result;
        }


        //Change it to be more efficient in space  so dictionary<int, int, int>();
        internal List<int> getavgeachlevel(TreeNode root)
        {
            if (root == null)
                return null;
            var dict = new Dictionary<int, Tuple<int, int>>();
            TDFS(root, 0, null);
            List<int> result = new List<int>();
            foreach(var d in dict)
            {
                var avg = 1;// d.Value.Sum() / d.Value.Count;
                result.Add(avg);
            }

            return result;
        }

        private void TDFS(TreeNode node, int level, Dictionary<int, List<int>> dict)
        {
            if (node == null)
                return;

            if (!dict.ContainsKey(level))
            {
                dict[level] = new List<int>(){ node.val};
            }
            else
            { 
                dict[level].Add(node.val);
            }
            TDFS(node.left, level + 1, dict);
            TDFS(node.right, level + 1, dict);


        }

        internal void test()
        {
            HashSet<int> b;
            Hashtable c;
            Dictionary<int, int[]> d = new Dictionary<int, int[]>();
            var e = new int[] {1,2,3 };

            e[0] = 23;

            e[3] = 24;

        }

        internal int getMissingNoSucks(int[] a)
        {
            var len = a.Length;
            Array.Sort(a);
            var missing = 0;
            for (var i = 0; i < len; i++)
                if (a[i] != i + 1)
                    missing = i + 1;

            return missing;
            
        }

        internal int getMissingNo(int[] a, int n)
        {
            var total = (n + 1) * (n + 2) / 2;
            for (var i = 0; i < n; i++) 
                total -= a[i];
           
         
            return total;
        }

            public string MostCommonWord2(string paragraph, string[] banned)
        {
            var clean = paragraph.Replace(",", " ").Replace("!", " ").Replace("?", " ").Replace(";", " ").Replace(".", " ").ToLower();
            var split = clean.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            var dict = new Dictionary<string, int>();
            for (var i = 0; i < split.Length; i++)
            {
                var clword =  split[i].Where(w => char.IsLetterOrDigit(w));
                var word = new string(clword.ToArray());
                if (!banned.Contains(word))
                {
                    if (!dict.ContainsKey(word))
                        dict.Add(word, 1);
                    else
                        dict[word]++;
                }
            }

            var mfw = dict.OrderByDescending(d => d.Value).FirstOrDefault().Key;
            return mfw;
        }

        public int[] ProductExceptSelf3(int[] nums)
        {
            var len = nums.Length;
            var result = new int[len];
            Array.Fill(result, 1);
            var product = 1;
            for (var i = 0; i < len - 1; i++)
            {
                product *= nums[i];
                result[i + 1] *= product;
            }

            product = 1;
            for (var i = len - 1; i > 0; i--)
            {
                product *= nums[i];
                result[i - 1] *= product;
            }


            return result;
        }




        public int MaxProfit2(int[] prices)
        {
            var profit = 0;
            var buy = 10001;
            var len = prices.Length;
            for (var i = 0; i < len; i++)
            {
                if (prices[i] < buy)
                {
                    buy = prices[i]; 
                }
                else
                {
                    profit = Math.Max(profit, prices[i] - buy);
                }


            }

            //var profit = sell - buy;
            return profit;
        }



        internal ListNode add_integers(ListNode integer1, ListNode integer2)
        {
            //TODO: Write - Your - Code
            var newnode = new ListNode(Int32.MinValue);
            var newhead = newnode;
            var carry = 0;
            while (integer1 != null || integer2 != null || carry == 1)
            {
                var sum = (integer1 == null ? 0 : integer1.val) + (integer2 == null ? 0 : integer2.val) + carry;
                carry = sum / 10;
                sum %= 10;
                if (newnode.val == Int32.MinValue)
                {
                    newnode.val = sum;
                }
                else
                {
                    newnode.next = new ListNode(sum);
                    newnode = newnode.next;
                }
                integer1 = integer1?.next;
                integer2 = integer2?.next;

            }
            return newhead;
        }


        internal int find_missing(List<int> input)
        {
            //TODO: Write - Your - Code
            //Collections.sort(input);
            input.Sort();
            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] != i + 1)
                    return i + 1;
            }
            return -1;
        }


        public bool find_sum_of_three(int[] arr, int required_sum)
        {
            // TODO: Write - Your - Code
            Array.Sort(arr);


            
            int len = arr.Length;

            for (int i = 0; i < len - 2; i++)
            {
                int low = i + 1;
                int high = len - 1;
                while (low < high)
                {
                    int sum = arr[i] + arr[low] + arr[high];
                    if (sum == required_sum)
                        return true;
                    else if (sum <= required_sum)
                    {
                        low++;
                    }
                    else
                    {
                        high--;
                    }
                }
            }
            return false;
        }


        internal int connectedSum(int n, List<string> edges)
        {
            var iedges = new List<List<int>>();
            foreach (var edge in edges)
            {
                var nums = edge.Split(' ').Select(x => int.Parse(x)).ToList();
                iedges.Add(nums);

            }

            var counts = new List<int>();
            var sqrts = new List<double>();
            var count = 0;
            bool inlist = false;
            var alledges = new List<int>();
            var dict = new Dictionary<int, int>();
            for (var i = 0; i < iedges.Count; i++)
            {
                if (inlist && !dict.ContainsKey(iedges[i][0]) && !dict.ContainsKey(iedges[i][1]))
                {
                    counts.Add(count);
                    count = 0;
                    inlist = false;
                    foreach (var elem in dict)
                    {
                        alledges.Add(elem.Key);
                    }
                    dict.Clear();
                }
                if (!inlist && !dict.ContainsKey(iedges[i][0]) || !dict.ContainsKey(iedges[i][1]))
                {


                    if (!dict.ContainsKey(iedges[i][0]))
                    { 
                        dict.Add(iedges[i][0], 1);
                        count++;
                    }

                    //}
                    //if (!inlist && !dict.ContainsKey(iedges[i][1]))
                    // {

                    if (!dict.ContainsKey(iedges[i][1]))
                    {
                        dict.Add(iedges[i][1], 1);
                        count++;
                    }
                    inlist = true;

                }
               

                
            }


            foreach (var elem in dict)
            {
                if (!alledges.Contains(elem.Key))
                    alledges.Add(elem.Key);
            }

            if (count > 0)

            {
                counts.Add(count);
            }

            var totals = 0;
            foreach (var c in counts)
            {
                var sqrt = (int)Math.Ceiling(Math.Sqrt(c));
                totals += sqrt;
            }

            var remsqrts = 0;

            for (var i = 1; i <= n; i++ )
            {
                if (!alledges.Contains(i))
                    remsqrts++;
            }

            return totals + remsqrts;
            
        }










        private static readonly (int dx, int dy)[] directions = { (0, 1), (1, 0), (0, -1), (-1, 0) };
        internal List<string> doesCircleExist(List<string> commands)
        {
            var initiald = 0;
            var diridx = 0;

            var bwc = new List<string>();

           
            foreach (var command in commands)
            {

                (int x, int y) position = (0, 0);
                foreach (var c in command)
                {



                    switch (c)
                    {
                        case 'G':
                          
                            position.x += directions[diridx].dx;
                            position.y += directions[diridx].dy;
                            break;
                        case 'L':
                          
                            diridx = (diridx + directions.Length - 1) % directions.Length;
                            break;
                        case 'R':
                          
                            diridx = (diridx + 1) % directions.Length;
                            break;
                        default:
                            break;

                    }

                }
                if (position.x == 0 && position.y == 0)
                    bwc.Add("YES");
                else
                    bwc.Add("NO");

            }

          


            return bwc;

        }

        //amazon - failed most test cases?  verify this

        internal List<int> foo(int flightDuration, List<int> movieDuration)
        {
            var sortedlist = new List<int>();
            sortedlist.AddRange(movieDuration);
            sortedlist.Sort();  // can use extension

            var i = 0;
            var j = movieDuration.Count - 1;
            var max = -1;

            var movie1len = 0;
            var movie2len = 0;
            var maxlen = 0;

            while (i < j)
            {
                var sum = sortedlist[i] + sortedlist[j];
                if (sum == flightDuration - 30)
                {
                    if (sortedlist[i] > maxlen || sortedlist[j] > maxlen)
                    {
                        movie1len = sortedlist[i];
                        movie2len = sortedlist[j];
                        max = sum;
                        maxlen = Math.Max(movie1len, movie2len);
                    }
                    i++;
                    j--;
                }
                else if (sum < (flightDuration - 30))
                    i++;
                else
                    j--;


            }



            var mtw = new List<int>();
            if (max == -1)
            {
                mtw.AddRange(new int[] { -1, -1 });
            }
            else
                mtw.AddRange(new int[] { movieDuration.IndexOf(movie1len), movieDuration.IndexOf(movie2len) });
            mtw.Sort();
            return mtw;
        }



        internal void countSwaps(int[] a)
        {
            var swaps = 0;
            var n = a.Length;
            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j < n - 1; j++)
                {
                    // Swap adjacent elements if they are in decreasing order
                    if (a[j] > a[j + 1])
                    {
                        var temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                        swaps++;
                    }
                }

            }
            Console.WriteLine($"Array is sorted in {swaps} swaps.");
            Console.WriteLine($"First Element: {a[0]}");
            Console.WriteLine($"Last Element: {a[n - 1]}");

        }




        internal long repeatedString(string s, long n)
        {
            if (s == "a")
                return n;


            var numas = s.Where(st => st == 'a').Count();
            long count = (n / s.Length) * numas;

            long remainder = n % s.Length;


            for (var i = 0; i < remainder; i++)
            {
                if (s[i] == 'a')
                    count++;
            }
            return count;
        }




        internal long arrayManipulation(int n, int[][] queries)
        {
            var arr = new long[n + 1];

            for (var i = 0; i < queries.Length; i++)
            {
                arr[queries[i][0] - 1] += queries[i][2];
                arr[queries[i][1]] -= queries[i][2];
            }
            long max = long.MinValue;

            for (var k = 1; k < arr.Length; k++) 
            {
                arr[k] += arr[k - 1];
                max = Math.Max(arr[k], max);
            }
            return max;

        }


        internal void minimumBribes(int[] q)
        {
            var count = 0;
            var vts = q.Length;

            while (vts > 1)
            {
                if (q[vts - 1] != vts)
                {
                    if (vts > 2 && q[vts - 3] == vts)
                    {
                        var index = vts - 3;
                        q[index] = q[index + 1];
                        q[index + 1] = q[index + 2];
                        q[index + 2] = vts;
                        count += 2;
                    }
                    else if (q[vts - 2] == vts)
                    {
                        var index = vts - 2;
                        var temp = q[index];
                        q[index] = q[index + 1];
                        q[index + 1] = temp;
                        count++;
                    }
                    else
                    {
                        Console.WriteLine("Too chaotic");
                        return;
                    }
                }
                vts--;
            }
            Console.WriteLine(count);

        }








        public int minimumSwaps(int[] arr)
        {
            var count = 0;
            for (var i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] != i + 1)
                {
                    var temp = arr[arr[i] - 1];
                    arr[arr[i] - 1] = arr[i];
                    arr[i] = temp;
                    i--;
                    count++;
                }
            }
            return count;


        }


        public int sockMerchant(int n, int[] ar)
        {
            var dict = new Dictionary<int, int>();
            for (var i = 0; i < n; i++)
            {
                if (!dict.ContainsKey(ar[i]))
                {
                    dict.Add(ar[i], 1);
                }
                else
                    dict[ar[i]]++;
            }
            var results = dict.Select(d => d.Value / 2).Sum();
            return results;

        }






        /*
 * // This is the custom function interface.
 * // You should not implement it, or speculate about its implementation
 * public class CustomFunction {
 *     // Returns f(x, y) for any given positive integers x and y.
 *     // Note that f(x, y) is increasing with respect to both x and y.
 *     // i.e. f(x, y) < f(x + 1, y), f(x, y) < f(x, y + 1)
 *     public int f(int x, int y);
 * };
 */
        //public IList<IList<int>> FindSolution(CustomFunction customfunction, int z)
        //{
        //    var results = new List<IList<int>>();
        //    var maxj = 1000;

        //    for (var i = 1; i <= 1000; i++)
        //        for (var j = 1; j <= maxj; j++)
        //        {
        //            if (customfunction.f(i, j) == z)
        //            {
        //                results.Add(new List<int>() { i, j });
        //                maxj = j;
        //            }
        //        }

        //    return results;

        //}














        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            var result = new List<IList<int>>();
            if (candidates.Length == 0)
                return result;
            Array.Sort(candidates);
            Traverse(result, candidates, target, 0, new List<int>());
            return result;

        }

        private void Traverse(IList<IList<int>> result, int[] candidates, int target, int start, IList<int> oneresult)
        {
            if (target == 0)
                result.Add(new List<int>(oneresult));
            else if (target > 0)
            {
                for (var i = start; i < candidates.Length; i++)
                {
                    oneresult.Add(candidates[i]);
                    Traverse(result, candidates, target - candidates[i], i, oneresult);
                    oneresult.RemoveAt(oneresult.Count - 1);

                }
            }

        }



        public int[] SortKMessedArray(int[] arr, int k)
        {
            List<int> priorityQueue = new List<int>();

            // add first k + 1 items to the min heap
            for (int i = 0; i < k + 1; i++)
            {
                priorityQueue.Add(arr[i]);
            }

            priorityQueue.Sort();

            int index = 0;
            for (int i = k + 1; i < arr.Length; i++)
            {
                arr[index++] = priorityQueue[0];
                priorityQueue.RemoveAt(0);
                priorityQueue.Add(arr[i]);
                priorityQueue.Sort();
            }

            int queue_size = priorityQueue.Count;

            for (int i = 0; i < queue_size; i++)
            {
                arr[index++] = priorityQueue[0];
                priorityQueue.RemoveAt(0);
            }

            return arr;

        }



public string CustomSortString2(string S, string T)
        {
            
            var result = new StringBuilder();
            for (var i = 0; i < S.Length; i++)
            {
                var search = S[i];
                var count = T.Count(t => t == search);

                if (count > 0)
                {
                    result.Append(new String(search, count));

                    
                    T = T.Replace(search, ' ');
                }

            }
            T = T.Trim().Replace(" ", String.Empty);
            return result.ToString() + T;
        }


        public IList<int> FindDisappearedNumbers(int[] nums)
        {




            return Enumerable.Range(1, nums.Length).Except(nums).ToList();


            //This takes too long:
            //Array.Sort(nums);
            //var result = new List<int>();
            //nums = nums.Distinct().ToArray();
            //for (var i = 0; i < nums.Length - 1; i++)
            //{
            //    if (nums[i + 1] - nums[i] > 1)
            //    {
            //        result.AddRange(Enumerable.Range(nums[i] + 1, nums[i + 1] - 1).ToList());
            //    }
            //}
            //return result;
        }


        public string MostCommonWord(string paragraph, string[] banned)
            {
               
                var clean = paragraph.Replace("!", " ")
                                                 .Replace("?", " ")
                                                 .Replace("'", " ")
                                                 .Replace(",", " ")
                                                 .Replace(";", " ")
                                                 .Replace(".", " ");

                var words = clean.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                var dict = new Dictionary<string, int>();
                for (var i = 0; i < words.Length; i++)
                {
                    var word = words[i].Where(l => char.IsLetterOrDigit(l));
                    var arr = new string(word.ToArray()).ToLower();
                    if (!banned.Contains(arr))
                    {
                        if (!dict.ContainsKey(arr))
                            dict.Add(arr, 1);
                        else
                            dict[arr]++;
                    }
                }
                var c = dict.OrderByDescending(d => d.Value).Select(d => d.Key).FirstOrDefault();
                return c;
            }


            public int SwimInWater(int[][] grid)
            {
                var low = grid[0][0];
                var high = low;
                for (var r = 0; r < grid.Length; r++)
                {
                    var row = grid[r];
                    for (var c = 0; c < row.Length; c++)
                    {
                        high = Math.Max(row[c], high);
                    }
                }

                while (low < high)
                {
                    var mid = low + (high - low) / 2;

                    if (PathExists(grid, mid, 0, 0, new bool[grid.Length, grid[0].Length]))
                        high = mid;
                    else
                        low = mid + 1;
                }

                return low;
            }

            private bool PathExists(int[][] grid, int waterLevel, int r, int c, bool[,] visited)
            {
                if (r > grid.Length - 1 || r < 0 || c > grid[0].Length - 1 || c < 0)
                    return false;

                if (grid[r][c] > waterLevel || visited[r, c] == true)
                    return false;

                if (r == grid.Length - 1 && c == grid[0].Length - 1)
                    return true;

                visited[r, c] = true;

                var directions = new (int x, int y)[] { (1, 0), (0, 1), (-1, 0), (0, -1) };

                foreach (var dir in directions)
                {
                    if (PathExists(grid, waterLevel, r + dir.x, c + dir.y, visited))
                        return true;
                }

                return false;
            }


            public int SumOfUnique(int[] nums)
            {
                var uniques = nums.GroupBy(n => n).Where(n => n.Count() == 1).Select(n => n.Key).ToArray();
                var sum = uniques.Sum();
                return sum;
            }
        


        public int NumSubmat(int[][] mat)
            {
                int[,] grid = new int[mat.Length + 1, mat[0].Length + 1];

                int count = 0;
                int min;

                for (int i = mat.Length - 1; i >= 0; i--)
                {
                    for (int j = mat[0].Length - 1; j >= 0; j--)
                    {
                        if (mat[i][j] == 1)
                        {
                            grid[i, j] = 1 + grid[i, j + 1];

                            count += grid[i, j];

                            min = grid[i, j];

                            for (int h = i + 1; h < mat.Length; h++)
                            {
                                min = Math.Min(min, grid[h, j]);
                                if (min > 0) { count += min; } else { break; }
                            }
                        }
                    }
                }

                return count;
            }


            internal bool HasDupes(int[] arr)
            {
                if (arr == null)
                    return false;
                if (arr.Length <= 1)
                    return false;
                Array.Sort(arr);

                for (var i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] == arr[i + 1])
                        return true;
                }
                return false;

            }




            public int FindSpecialInteger(int[] arr)
            {
                if (arr.Length == 1)
                    return arr[0];
                var percentage = arr.Length / 4;
                if (arr.Length % 4 > 0)
                    percentage++;
                var dict = new Dictionary<int, int>();
                for (var i = 0; i < arr.Length; i++)
                {
                    if (!dict.ContainsKey(arr[i]))
                    {
                        dict.Add(arr[i], 1);
                    }
                    else
                    {
                        dict[arr[i]]++;
                    }
                }

                var key = dict.Where(d => d.Value == dict.Values.Max()).Select(d => d.Key).FirstOrDefault();
                var order = dict.GroupBy(d => d.Value).OrderByDescending(d => d.Key).Select(d => d.Key).FirstOrDefault(); // Values.OrderBy(d => d .OrderBy(d => d.Count).FirstOrDefault();
                return key;
            }



            public int UniquePathsIII(int[][] grid)
            {
                var start = new int[2];
                var emptycells = 0;
                var paths = 0;
                for (var i = 0; i < grid.Length; i++)
                    for (var j = 0; j < grid[i].Length; j++)
                    {
                        if (grid[i][j] == 1)
                        {
                            start[0] = i;
                            start[1] = j;
                        }
                        else
                            if (grid[i][j] == 0)
                        {
                            emptycells++;
                        }

                    }


                Traverse(grid, start[0], start[1], emptycells, 0, new int[grid.Length, grid[0].Length], ref paths);
                return paths;


            }


            void Traverse(int[][] grid, int i, int j, int emptycells, int emptyfound, int[,] visited, ref int paths)
            {

                if (i < 0 || i >= grid.Length || j < 0 || j >= grid[0].Length || visited[i, j] == 1 || grid[i][j] == -1)
                    return;

                else if (grid[i][j] == 2)
                {
                    if (emptyfound == emptycells)
                        paths++;
                }
                else if (grid[i][j] == 0)
                    emptyfound++;



                visited[i, j] = 1;

                Traverse(grid, i - 1, j, emptycells, emptyfound, visited, ref paths);
                Traverse(grid, i + 1, j, emptycells, emptyfound, visited, ref paths);
                Traverse(grid, i, j - 1, emptycells, emptyfound, visited, ref paths);
                Traverse(grid, i, j + 1, emptycells, emptyfound, visited, ref paths);

                visited[i, j] = 0;



            }










            public int CountBattleships(char[][] board)
            {
                var count = 0;

                for (var i = 0; i < board.Length; i++)
                {
                    for (var j = 0; j < board[i].Length; j++)
                    {
                        if (board[i][j] == 'X')
                        {
                            if (i < (board.Length - 1) && board[i + 1][j] == 'X')
                                continue;
                            if (j < (board[i].Length - 1) && board[i][j + 1] == 'X')
                                continue;
                            count++;

                        }
                    }

                }
                return count;
            }

            public int MyAtoi3(string s)
            {
                if (string.IsNullOrEmpty(s))
                    return 0;
                var negative = 1;
                var sbnumber = new StringBuilder();

                var i = 0;
                while (i < s.Length && s[i] == ' ')
                    i++;
                if (i < s.Length && s[i] == '-')
                {
                    negative = -1;
                    i++;
                }
                else if (i < s.Length && s[i] == '+')
                    i++;
                if (i < s.Length && !Char.IsNumber(s[i]))
                    return 0;
                while (i < s.Length && Char.IsNumber(s[i]))
                {
                    sbnumber.Append(s[i]);
                    i++;
                }

                if (sbnumber.Length == 0)
                    return 0;
                long num = 0;
                
                var success = Int64.TryParse(sbnumber.ToString(), out num);

                if (!success)
                {
                    if (negative == 1)
                        return Int32.MaxValue;
                    else
                        return Int32.MinValue;
                }


                num *= negative;
                if (num > Int32.MaxValue)
                    return Int32.MaxValue;


                if (num < Int32.MinValue)
                    return Int32.MinValue;

                return Convert.ToInt32(num);
            }









            public void SetZeroes(int[][] matrix)
            { 
                
                var rows = new List<int>();
                var columns = new List<int>();
                for (var i = 0; i < matrix.Length; i++)
                    for (var j = 0; j < matrix[i].Length; j++)
                    {
                        if (matrix[i][j] == 0)
                        {
                            rows.Add(i);
                            columns.Add(j);

                          //  matrix[0][j] = 0;
                          //  matrix[i][0] = 0;
                           // break;
                        }
                    }


                for (var i = 0; i < matrix.Length; i++)
                    for (var j = 0; j < matrix[i].Length; j++)
                    {
                        if (rows.Contains(i) || columns.Contains(j))
                        {
                            matrix[i][j] = 0;
                        }
                    }
              


            }



            public IList<int> LuckyNumbers(int[][] matrix)
            {
                var mineachrow = new List<int>();
                var maxeachcol = new List<int>();

                for (var i = 0; i < matrix.Length; i++)
                {
                    var minrow = Int32.MaxValue;

                    for (var j = 0; j < matrix[i].Length; j++)
                    {
                        if (matrix[i][j] < minrow)
                            minrow = matrix[i][j];
                    }
                    mineachrow.Add(minrow);
                }


                for (var j = 0; j < matrix[0].Length; j++)
                {
                    var maxcol = 0;
                    for (var i = 0; i < matrix.Length; i++)

                   
                    {
                        if (matrix[i][j] > maxcol)
                            maxcol = matrix[i][j];
                    }
                    maxeachcol.Add(maxcol);
                }


                return maxeachcol.Intersect(mineachrow).ToList();
            }



            public bool Check(int[] nums)
            {
                var numlist = nums.ToList();
                int[] sorted = new int[nums.Length];
                nums.CopyTo(sorted, 0);
                Array.Sort(sorted);
               
                if (nums.SequenceEqual(sorted))
                    return true;
                for (var i = 0; i < nums.Length; i++)
                {
                    var numtoremove = numlist[0];
                    numlist.RemoveAt(0);
                    numlist.Add(numtoremove);
                    if (numlist.SequenceEqual(sorted))
                        return true;
                }
                return false;

            }


            int total = 0;

            public int DistributeCoins(TreeNode root)
            {
                GetTotal(root);
                return total;
            }
            internal int GetTotal(TreeNode node)
            {
                if (node == null)
                    return 0;
                var l = GetTotal(node.left);
                var r = GetTotal(node.right);
                total += Math.Abs(l) + Math.Abs(r);
                return node.val + l + r - 1;


            }



            public bool Exist(char[][] board, string word)
            {
                int m = board.Length, n = board[0].Length;
                for (int i = 0; i < m; i++)
                    for (int j = 0; j < n; j++)
                        if (ExistsWord(i, j, 0, new HashSet<(int, int)>()))
                            return true;

                return false;

                bool ExistsWord(int i, int j, int wordIndex, HashSet<(int, int)> visited)
                {
                    if (i >= m || j >= n || i < 0 || j < 0 || visited.Contains((i, j)) || board[i][j] != word[wordIndex])
                        return false;
                    if (wordIndex == word.Length - 1)
                        return true;
                    visited.Add((i, j));

                    bool res = ExistsWord(i + 1, j, wordIndex + 1, visited) ||
                               ExistsWord(i - 1, j, wordIndex + 1, visited) ||
                               ExistsWord(i, j + 1, wordIndex + 1, visited) ||
                               ExistsWord(i, j - 1, wordIndex + 1, visited);

                    visited.Remove((i, j));

                    return res;
                }
            }







            public int MaxRepOpt2(string text)
            {
                var list = new List<int>[26];


                //list[0] = new List<int>();
                //list[0].Add(2);
                //list[0].Add(3);
                //list[0].Add(4);
                //list[0].Add(5);
                //list[0].Add(6);
                //list[0].Add(7);
                //list[0].Add(8);


                for (var i = 0; i < text.Length; i++)
                {
                    if (list[text[i] - 'a'] == null)
                        list[text[i] - 'a'] = new List<int>();
                    list[text[i] - 'a'].Add(i);
                }

                var max = 1;

                for (var i = 0; i <= 25; i++)
                {
                    var cons = 1;
                    var cons1 = 0;
                    var res = 0;
                    if (list[i] != null)
                    {
                        for (var j = 1; j < list[i].Count; j++)
                        {
                            if (list[i][j] == list[i][j - 1] + 1)
                                cons++;
                            else
                            {
                                cons1 = list[i][j] == list[i][j - 1] + 2 ? cons : 0;
                                cons = 1;
                            }

                            res = Math.Max(res, cons + cons1);
                        }
                    }

                    max = Math.Max(max, (list[i]?.Count ?? 0) > res ? res + 1 : res);
                }

                return max;
            }




            public int MaxRepOpt1(string text)
            {
                //char, index, count;
                var occur = new List<KeyValuePair<char, KeyValuePair<int, int>>>();

                if (text.Length == 1)
                    return 1;
                var length = 1;
                var startindex = 0;
                for (var i = 1; i < text.Length; i++)
                {
                    if (text[i] != text[i - 1])
                    {
                        occur.Add(new KeyValuePair<char, KeyValuePair<int, int>>( text[i - 1], new KeyValuePair<int, int>(startindex, length)));
                        length = 1;
                        startindex = i;
                    }
                    else
                    {
                        length++;
                    }
                }

                occur.Add(new KeyValuePair<char, KeyValuePair<int, int>>(text[text.Length-1], new KeyValuePair<int, int>(startindex, length)));

                var maxrep = occur.GroupBy(g => g.Key).Select(group => new
                {
                    letter = group.Key,
                    count = group.Count()
                }).OrderBy(o => o.letter);



                //var maxrep = occur.GroupBy(o => o.Key).Select(o => new { a = o.Key, b = o.Select(x => new { name = x.Value.Value})}
              
                //var max = maxrep.Where(m => m.Key.)

                return 1;


            }



            /*
Function exact_match(text, pattern) returns true if pattern is an exact substring of text.
"hello world", "hello" => true
"hello world", "llo wor" => true
"hello world", "hello world hello" => false


Function wildcard_match(text, pattern) adds the wildcard metacharacter . (period) to the pattern character set. This metacharacter matches any character in text.
"hello world", ".ello"  => true
"hello world", "..llo.wor" => true
"hello world", "..l.o" => true
"hello world", "...llo" => false
"hello world", "or.." => true
"hello world", "or..." => false

1. iterate through text
2. iterate from current position in text through pattern
3. if reached end of pattern return true


Function question_wildcard_match(text, pattern) adds the metacharacter ? to the pattern character set. x? in pattern matches either zero occurrences or one occurrence of x in text, where x is not ? . Assume valid input.\
"hello world", "hell?o" => True
"hello world", "helll?o" => True
"hello world", "hell?lo" => True
"hello world", ".?ell?l?l?o?o?" => True
"hello world", "llog?z? k" => False

"aaab", "a?a?aab"

Dynamic Programming - 
*/





    //fix this one:

    internal bool wildcard_match(string text, string pattern) // O(n*m)
        { // O(1) SC
            var count = 0;
            //if pattern.Length > text.Length?
            //if pattern == ""?
            var plen = pattern.Length;

            for (var i = 0; i < text.Length; i++) // O(n-m)
            {
                count = 0;
                while (count < plen &&  // O(m)
                      (text[i + count] == pattern[count] || pattern[count] == '.'))
                {
                    count++;
                }
                if (count == plen)
                    return true;

            }
            return false;

        }


        //public static bool question_wildcard_match(string text, string pattern)
        //{

        //    var count = 0;
        //    var plen = pattern.Length;

        //    for (var i = 0; i < text.Length - plen; i++)
        //    {


        //        while (text[i] == pattern[count] || pattern[count] == '?')
        //        {
        //            if (pattern[count] == '?')
        //            {

        //            }
        //        }


        //    }



        //}





        int maxlevel = 1;
        int sum = 0;
        public int DeepestLeavesSum(TreeNode root)
        {
            Traverse(root, maxlevel);
            Traverse(root.left, maxlevel + 1);
            Traverse(root.left, maxlevel + 1);
            return sum;
        }

        private void Traverse(TreeNode node, int level)
        {
            if (node == null)
                return;
            if (level > maxlevel)
            {
                maxlevel = level;
                sum = node.val;
            }
            else
            {
                sum += node.val;
            }
            Traverse(node.left, level + 1);
            Traverse(node.right, level + 1);
        }









        public string ReverseOnlyLetters(string S)
        {
            var nonletters = new List<KeyValuePair<int, char>>();
            var nonindex = 0;
            for (var i = 0; i < S.Length; i++)
            {
                if (!Char.IsLetter(S[i]))
                {
                    nonletters.Add(new KeyValuePair<int, char>(nonindex, S[i]));
                    S = S.Remove(i, 1);
                    i--;
                    
                }
                nonindex++;
            }
            var revca = S.Reverse();
            var reversed = new string(revca.ToArray());
            var sb = new StringBuilder(reversed);
            for (var i = 0; i < nonletters.Count; i++)
            {
                sb.Insert(nonletters.ElementAt(i).Key, nonletters.ElementAt(i).Value);
            }
            return sb.ToString();
        }


        public bool IsOneEditDistance2(string s, string t)
        {
            var edits = 1;
            int abs = Math.Abs(s.Length - t.Length);
            if (abs > edits)
                return false;

            int edit = 0;
            for (int i = 0; i < s.Length && i < t.Length; i++)
            {
                if (s[i] != t[i])
                    edit++;
                if (edit == edits + 1)
                    return false;
            }

            return abs + edit <= edits;
        }


public bool IsOneEditDistance(string s, string t)
        {
            if (String.IsNullOrEmpty(s) && String.IsNullOrEmpty(t))
                return false;
            if (s == t)
                return false;

            var len = s.Length;
            for (var i = 0; i < s.Length && s.Length > 0 && t.Length > 0; i++)
            {
                var c = s[i].ToString();
                if (s.Contains(c) && t.Contains(c))
                { 
                    s = s.Replace( c, "");
                    t = t.Replace(c, "");
                    i--;
                }
            }
            if (s.Length == 1 && t.Length == 1)
                return true;
            if (s.Length == 0 && t.Length == 1)
                return true;
            if (s.Length == 1 && t.Length == 0)
                return true;
            return false;
        }





        public ListNode AddTwoNumbers8(ListNode l1, ListNode l2)
        {
            var s1 = new Stack<int>();
            var s2 = new Stack<int>();

            while (l1 != null)
            {
                s1.Push(l1.val);
                l1 = l1.next;
            }

            while (l2 != null)
            {
                s2.Push(l2.val);
                l2 = l2.next;
            }

            var carry = 0;
            var l3 = new ListNode(-1);
            ListNode head = null;
            while (s1.Count > 0 || s2.Count > 0 || carry > 0)
            {
                var sum = (s1.Count > 0 ? s1.Pop() : 0) + (s2.Count > 0 ? s2.Pop() : 0) + carry;
                carry = sum / 10;
                sum %= 10;

                if (l3.val == -1)
                    l3.val = sum;
                else
                {
                    head = new ListNode(sum);
                    head.next = l3;
                    l3 = head;
                }

            }
            return l3;

        }






        char[][] _board = null;
        List<string> _result = new List<string>();

        public List<string> findWords(char[][] board, string[] words)
        {

            // Step 1). Construct the Trie
            TrieNode root = new TrieNode();
            foreach (var word in words)
            {
                TrieNode node = root;

                foreach (var letter in word)
                {
                    if (node.children.ContainsKey(letter))
                    {
                        node = node.children[letter];
                    }
                    else
                    {
                        TrieNode newNode = new TrieNode();
                        node.children.Add(letter, newNode);
                        node = newNode;
                    }
                }
                node.word = word;  // store words in Trie
            }

            this._board = board;
            // Step 2). Backtracking starting for each cell in the board
            for (int row = 0; row < board.Length; ++row)
            {
                for (int col = 0; col < board[row].Length; ++col)
                {
                    if (root.children.ContainsKey(board[row][col]))
                    {
                        backtracking(row, col, root);
                    }
                }
            }

            return this._result;
        }

        private void backtracking(int row, int col, TrieNode parent)
        {
            var letter = this._board[row][col];
            TrieNode currNode = parent.children[letter];

            // check if there is any match
            if (currNode.word != null)
            {
                this._result.Add(currNode.word);
                currNode.word = null;
            }

            // mark the current letter before the EXPLORATION
            this._board[row][col] = '#';

            // explore neighbor cells in around-clock directions: up, right, down, left
            int[] rowOffset = { -1, 0, 1, 0 };
            int[] colOffset = { 0, 1, 0, -1 };
            for (int i = 0; i < 4; ++i)
            {
                int newRow = row + rowOffset[i];
                int newCol = col + colOffset[i];
                if (newRow < 0 || newRow >= this._board.Length || newCol < 0
                    || newCol >= this._board[0].Length)
                {
                    continue;
                }
                if (currNode.children.ContainsKey(this._board[newRow][newCol]))
                {
                    backtracking(newRow, newCol, currNode);
                }
            }

            // End of EXPLORATION, restore the original letter in the board.
            this._board[row][col] = letter;

            // Optimization: incrementally remove the leaf nodes
            if (currNode.children.Count == 0)
            {
                parent.children.Remove(letter);
            }
        }
        //  }




      //  2 5 3 4 6 2 2
        public ListNode SwapPairs2(ListNode head)
        {
            if (head == null || head.next == null)
                return head;
            ListNode newhead = null;
            var tail = head.next;
            ListNode prev = null;
            while (head != null && head.next != null)
            {
                head.next = tail.next;
                tail.next = head;
                if (newhead == null)
                {
                    newhead = tail;
                    prev = head;
                }
                else
                {
                    prev.next = tail;
                    prev = prev.next.next;
                }
                head = tail.next.next;
                tail = head?.next;

            }
            return newhead;
        }







        //class Solution
        // {


        public ListNode SwapPairs(ListNode head)
        {

            if (head == null || head.next == null)
                return head;
            
            var node = head.next;
            var returnhead = head.next;
            head.next = node.next;
            node.next = head;
            var tail = head;
            head = head.next;

            while (head?.next != null)
            {
                node = head.next;
                head.next = node.next;
                node.next = head;
                tail.next = node;
                tail = head;
                head = head.next;
            }
            return returnhead;
        }


        public string ReverseWords(string s)
        {
            var words = s.Split(' ');
            var sb = new StringBuilder();
            for (var i = 0; i < words.Length; i++)
            {
                var ary = words[i].ToArray();
                Array.Reverse(ary);
                sb.Append(new string(ary));
                if (i < words.Length - 1)
                    sb.Append(" ");

            }
            return sb.ToString();
        }



        public void dfs(int[][] M, int[] visited, int i)
        {
            for (int j = 0; j < M.Length; j++)
            {
                if (M[i][j] == 1 && visited[j] == 0)
                {
                    visited[j] = 1;
                    dfs(M, visited, j);
                }
            }
        }
        public int FindCircleNum(int[][] M)
        {
            int[] visited = new int[M.Length];
            int count = 0;
            for (int i = 0; i < M.Length; i++)
            {
                if (visited[i] == 0)
                {
                    dfs(M, visited, i);
                    count++;
                }
            }
            return count;
        }

        //public int FindCircleNum(int[][] isConnected)
        //{
        //    var members = new List<int>();
        //    for (var i = 0; i < isConnected.Length; i++)
        //    {
        //        for (var j = 0; j < isConnected[i].Length; j++)
        //        {
        //            if (i != j && isConnected[i][j] == 1)
        //            {
        //                members.Add(i);
        //                members.Add(j);
        //            }
        //        }
        //    }
        //    members = members.Distinct().ToList();
        //    var solemembers = isConnected.Length - members.Count;
        //    return solemembers == isConnected.Length ? solemembers : solemembers + 1;

        //}

        //public int knightDialer(int N)
        //{
        //    int MOD = 1_000_000_007;


        //    int[][] moves = new int[][]() {{4,6},{6,8},{7,9},{4,8},{3,9,0},{},{1,7,0},{2,6},{1,3},{2,4}};

        //    int[][] dp = new int[2][10];
        //    Array.Fill(dp[0], 1);
        //    for (int hops = 0; hops < N - 1; ++hops)
        //    {
        //        Array.Fill(dp[~hops & 1], 0);
        //        for (int node = 0; node < 10; ++node)
        //            for (int nei: moves[node])
        //            {
        //                dp[~hops & 1][nei] += dp[hops & 1][node];
        //                dp[~hops & 1][nei] %= MOD;
        //            }
        //    }

        //    long ans = 0;
        //    for (int x: dp[~N & 1])
        //        ans += x;
        //    return (int)(ans % MOD);
        //}












        public ListNode DetectCycle(ListNode head)
        {
            var nodes = new List<ListNode>();
            var pos = 0;
            while (head != null)
            {
                if (!nodes.Contains(head))
                {
                    nodes.Add(head);
                    pos++;
                    head = head.next;
                }
                else
                {
                    return head;
                }

            }
            return null;
        }



        public ListNode OddEvenList(ListNode head)
        {
            if (head == null)
                return null;

            var odd = head;
            var headodd = head;
            var even = head.next;
            var headeven = head.next;
            head = head?.next?.next;
            while (head != null)
            {
                odd.next = head;
                even.next = head.next;
                head = head?.next?.next;
                if (head != null)
                {

                    even = even.next;
                }
                odd = odd.next;

            }

            odd.next = headeven;
            return headodd;


        }


        public int FindCelebrity(int n)
        {
            for (var i = 0; i < n; i++)
            {
                var celeb = true;
                for (var j = 0; j < n; j++)
                {
                    if (i != j)  // && Knows(i, j) || !Knows(j, i))
                    {
                        celeb = false;
                        // Console.WriteLine($"{i} DOES know {j}");
                        break;
                    }
                    //  Console.WriteLine($"{i} doesnt know {j}");

                }
                if (celeb)
                    return i;
            }

            return -1;
        }

        protected internal int MaxSubArray2(int[] nums)
        {
            var maxval = nums[0];
            for (var i = 1; i < nums.Length; i ++)
            {
                if (nums[i-1] > 0)
                    nums[i] = nums[i - 1] + nums[i];
                maxval = Math.Max(maxval, nums[i]);
            }
            return maxval;
        }


        List<int> sequence = new List<int>();
        public bool LeafSimilar3(TreeNode root1, TreeNode root2)
        {

            Traverse(root1);
            var s1 = new List<int>();
            s1.AddRange(sequence);

            sequence.Clear();
            Traverse(root2);
            var s2 = new List<int>();
            s2.AddRange(sequence);

            return (s1.SequenceEqual(s2));

        }

        private void Traverse(TreeNode node)
        {
            if (node == null)
                return;
            if (node.left == null && node.right == null)
            {
                sequence.Add(node.val);
            }
            if (node.left != null)
                Traverse(node.left);
            if (node.right != null)
                Traverse(node.right);

        }


        public string Multiply(string num1, string num2)
        {
            int n1 = num1.Length;
            int n2 = num2.Length;
            int[] products = new int[n1 + n2];

            for (int i = n1 - 1; i >= 0; i--)
            {
                for (int j = n2 - 1; j >= 0; j--)
                {
                    int p1 = i + j;
                    int p2 = p1 + 1;
                    int sum = (num1[i] - '0') * (num2[j] - '0') + products[p2];

                    products[p1] += sum / 10;
                    products[p2] = sum % 10;
                }
            }

            StringBuilder sb = new StringBuilder();
            foreach (int num in products)
            {
                if (!(sb.Length == 0 && num == 0))
                {
                    sb.Append(num);
                }
            }

            return sb.Length == 0 ? "0" : sb.ToString();
        }

        public int CompareVersion(string version1, string version2)
        {
            var v1 = version1.Split('.').ToList();
            var v2 = version2.Split('.').ToList();
            var diff = v1.Count - v2.Count;
            if (diff > 0)
            {
                for (var i = 0; i < diff; i++)
                {
                    v2.Add("0");
                }
            }
            else if (diff < 0)
            {
                for (var i = 0; i < Math.Abs(diff); i++)
                {
                    v1.Add("0");
                }
            }

          
            for (var i = 0; i < v1.Count; i++)
            {
                if (Convert.ToInt32(v1[i]) > Convert.ToInt32(v2[i]))
                {
                    return 1;

                }
                else if (Convert.ToInt32(v1[i]) < Convert.ToInt32(v2[i]))
                {
                    return -1;

                }
                

            }


            return 0;
        }


        /// <summary>
        /// works great, and has tricky step of adding new list, and attaching head to itself, etc.
        /// </summary>
        /// <param name="l1"></param>
        /// <param name="l2"></param>
        /// <returns></returns>
        public ListNode AddTwoNumbers7(ListNode l1, ListNode l2)
        {
            var s1 = new Stack<int>();
            var s2 = new Stack<int>();

            while (l1 != null)
            {
                s1.Push(l1.val);
                l1 = l1.next;
            }

            while (l2 != null)
            {
                s2.Push(l2.val);
                l2 = l2.next;
            }

            var carry = 0;
            ListNode head = null;
            while (s1.Count > 0 || s2.Count > 0 || carry > 0)
            {
                var sum = (s1.Count > 0 ? s1.Pop() : 0) + (s2.Count > 0 ? s2.Pop() : 0) + carry;
                carry = sum / 10;
                sum %= 10;

                var l3 = new ListNode(sum);
                l3.next = head;
                head = l3;
            }

            return head;
        }







        List<int> l = new List<int>();

        public bool LeafSimilar2(TreeNode root1, TreeNode root2)
        {
            var l1 = new List<int>();
            var l2 = new List<int>();
            Traverse(root1, l1);
          
            Traverse(root2, l2);
          

            return (l1.SequenceEqual(l2));

        }

        private void Traverse(TreeNode node, List<int> l)
        {
            if (node.left == null && node.right == null)
            {
                l.Add(node.val);
            }
            else
            {
                Traverse(node.left, l);
                Traverse(node.right, l);

            }
        }

    






    public IList<int> MajorityElement2(int[] nums)
        {
            var count = nums.Length / 3;
            var dict = new Dictionary<int, int>();
            for (var i = 0; i < nums.Length; i++)
            {
                if (!dict.ContainsKey(nums[i]))
                {
                    dict.Add(nums[i], 1);

                }
                else
                    dict[nums[i]]++;
            }
            var occured = dict.Where(d => d.Value > count).Select(d => d.Key).ToList();
            return occured;
        }


        public void NumArray(int[] nums)
        {
            var a = new List<int>();
            a.AddRange(nums);

        }




        public string LargestTimeFromDigits(int[] A)
        {
            int maxTime = -1;
            for (int i0 = 0; i0 < 4; i0++)
            {
                for (int i1 = 0; i1 < 4; i1++)
                {
                    if (i1 == i0)
                    {
                        continue;
                    }
                    for (int i2 = 0; i2 < 4; i2++)
                    {
                        if (i2 == i0 || i2 == i1)
                        {
                            continue;
                        }
                        int i3 = 6 - i0 - i1 - i2;
                        int hours = A[i0] * 10 + A[i1];
                        int mins = A[i2] * 10 + A[i3];
                        if (hours < 24 && mins < 60)
                        {
                            maxTime = Math.Max(maxTime, hours * 60 + mins);
                        }
                    }
                }
            }
            return maxTime >= 0 ? string.Format($"{maxTime / 60:00}:{maxTime % 60:00}") : string.Empty;
        }










        //works!!

        public int MaxDistToClosest(int[] seats)
        {
            var maxdistance = 0;
            var count = 0;
            var full = false;
            for (var i = 0; i < seats.Length; i++)
            {
                if (seats[i] == 1)
                {
                    if (full)
                    {
                        count++;
                        if (count / 2 > maxdistance)
                            maxdistance = count / 2;

                    }
                    else
                    {
                        if (count > maxdistance)
                            maxdistance = count;
                        full = true;
                    }

                    if (i < seats.Length - 1)
                        count = 0;

                }

                else if (seats[i] == 0)
                {
                    count++;
                    if (i == seats.Length - 1)
                    {
                        if (count > maxdistance)
                            maxdistance = count;
                    }
                }



            }
            return maxdistance;
        }









        ////copied solution
        //public ListNode ReverseList(ListNode head)
        //{

        //    ListNode prevNode = null;

        //    while (head != null) {
        //        var nextNode = head.next;
        //        head.next = prevNode;
        //        prevNode = head;
        //        head = nextNode;
        //    }

        //    return prevNode;


        //}


        public void InsertNode(ListNode node, int number)
        {
            var curr = node.val;
            node.val = number;
            while (node.next != null)
            {
                (node.next.val, curr) = (curr, node.next.val);
                node = node.next;
            }
            node.next = new ListNode(curr);
        }


        //public int Read(char[] buf, int n)
        //{

        //    var i = 0;

        //    while (i < n)
        //    {
        //        if (buf4index != -1 && numread > 0)
        //        {
        //            buf[i] = buf4[buf4index];
        //            buf4index++;
        //            i++;
        //            if (buf4index == numread)
        //                buf4index = -1;
        //        }
        //        else
        //        {
        //            buf4index = 0;
        //            numread = Read4(buf4);
        //            if (numread == 0)
        //                return i;
        //        }
        //    }
        //    return i;

        //}







        //int buf4index = -1;
        //char[] buf4 = new char[4];
        //int numread;
        //public int Readnotworking(char[] buf, int n)
        //{

        //    var count = 0;

        //    if (buf4index < 4 && buf4index > -1)
        //    {
        //        while (n > 0 && buf4index < numread)
        //        {
        //            Console.WriteLine("from past read: " + buf4[buf4index] + " count= " + count);
        //            buf[count] = buf4[buf4index];
        //            buf4index++;
        //            count++;
        //            n--;
        //        }
        //    }
        //    Console.WriteLine("buf4index TOP: " + buf4index);
        //    if (n == 0)
        //        return count;
        //    Console.WriteLine("after first if");

        //    numread = Read4(buf4);
        //    if (numread == 0)
        //    {
        //        if (count > 0)
        //            return count;
        //        else
        //            return 0;
        //    }


        //    buf4index = 0;
        //    while (n > 0 && count < numread)
        //    {
        //        Console.WriteLine("buf4[count]: " + buf4[buf4index]);
        //        buf[count] = buf4[buf4index];
        //        buf4index++;
        //        //i++;
        //        count++;
        //        n--;
        //    }

        //    Console.WriteLine("buf4index (bottom): " + buf4index);
        //    return count;

        //    //var o = new string(buf4);
        //    //Console.WriteLine("buf: " + o);
        //    //return a;
        //}


        public int LengthLongestPath(string input)
        {
            var lines = input.Split('\n');
            var max = 0;
            var pathLengthMap = new Dictionary<int, int>();
            pathLengthMap.Add(0, 0);
            for (int i = 0; i < lines.Length; i++)
            {
                var line = lines[i];
                var name = line.TrimStart('\t');
                var depth = line.Length - name.Length + 1;
                var length = pathLengthMap[depth - 1];
                length += name.Length;
                // if is file
                if (name.Contains('.'))
                {
                    max = Math.Max(max, length);
                }
                else // if is not file
                {
                    length++;
                    if (pathLengthMap.ContainsKey(depth)) pathLengthMap[depth] = length;
                    else pathLengthMap.Add(depth, length);
                }

            }
            return max;
        }






        public int MinSteps(string s, string t)
        {
            var dict = s.GroupBy(s => s).ToDictionary(s => s.Key, s => s.Count());
            var count = t.Length;
            for (var i = 0; i < t.Length; i++)
            {
                if (dict.ContainsKey(t[i]) && dict[t[i]] > 0)
                    {
                        dict[t[i]]--;
                    count--;
                    }
            }


            return count;
        }




                public int MinSteps2slow(string s, string t)
        {
           
            for (var i = 0; i < s.Length; i++)
            {
                var ti = t.IndexOf(s[i]);
                if (ti >= 0)
                    t = t.Remove(ti, 1);

            }

            return t.Length;
        }



        public int NumWaterBottles(int numBottles, int numExchange)
        {
            if (numBottles < numExchange)
                return numBottles;
            var total = numBottles;
            while (numBottles >= numExchange)
            {
                var rem = numBottles % numExchange;
                numBottles /= numExchange;
                total += numBottles;
                numBottles += rem;
            }


            return total;
        }


        //private int GetFullBottles(int numEmpty, int numExchange)
        //{
        //    if (numEmpty < numExchange)
        //        return 0;

        //    total += numEmpty / numExchange + GetFullBottles(numEmpty, numExchange);

        //    return total;
        //}





        public int NumTilePossibilities(string tiles)
        {
            int[] frequency = new int[26];
            foreach (var t in tiles)
            {
                frequency[t - 'A']++;
            }

            return dfs(frequency);
        }

        private int dfs(int[] frequency)
        {
            int sum = 0;

            for (int i = 0; i < 26; i++)
            {
                if (frequency[i] > 0)
                {
                    sum++;
                    frequency[i]--;
                    sum += dfs(frequency);
                    frequency[i]++;
                }
            }

            return sum;
        }



        //public int LengthLongestPath(string input)
        //{

        //}


        //var firstpart = true;

        //var secondindex = 0;
        //var count = 0;
        //for (var i = 0; i<S.Length; i++)
        //{
        //    if (S[i] == '-' && firstpart)
        //    {
        //        sb.Append(S.Substring(0,i+1));
        //        firstpart = false;
        //        secondindex = i + 1;
        //    }

        //    else
        //        if (S[i] != '-' && !firstpart && count<K)
        //        {
        //               sb.Append(S[i]);
        //               count++;
        //               // (count == K)
        //               //  count == 0;
        //        }
        //    else if (S[i] == '-' && !firstpart && count == K)
        //    {
        //        sb.Append(S[i]);
        //         count = 0;
        //    }


        //}
        //return sb.ToString().ToUpper();















        public TreeNode InvertTree(TreeNode root)
        {
            if (root == null)
                return null;

            (root.left, root.right) = (InvertTree(root.right), InvertTree(root.left));


            return root;

        }



        //best solution
        //public int TotalFruit(int[] tree)
        //{
        //    if (tree == null || tree.Length == 0) return 0;

        //    int start = 0;
        //    int end = 0;
        //    int k = 2;
        //    int maxFruits = 0;

        //    // Map to maintain the frequency count of each fruit
        //    Dictionary<int, int> fruitFreq = new Dictionary<int, int>();

        //    while (end < tree.Length)
        //    {
        //        if (!fruitFreq.ContainsKey(tree[end]))
        //        {
        //            fruitFreq.Add(tree[end], 0);
        //        }
        //        fruitFreq[tree[end]]++;

        //        // This is the important step as here we are reducing the count by removing the start elements.
        //        while (fruitFreq.Count > k)
        //        {
        //            fruitFreq[tree[start]]--;
        //            if (fruitFreq[tree[start]] == 0) fruitFreq.Remove(tree[start]);
        //            start++;
        //        }
        //        maxFruits = Math.Max(end - start + 1, maxFruits);
        //        end++;
        //    }
        //    return maxFruits;
        //}



        public int TotalFruit(int[] tree)
        {
            var allresults = new List<List<int>>();
          
            for (var i = 0; i < tree.Length; i++)
            {
          
                var dict = new Dictionary<int, int>();
                var result = new List<int>();
                for (var j = i; j < tree.Length; j++)
                {
                    if (!dict.ContainsKey(tree[j]))
                    {
                        if (dict.Count < 2)
                        {
                            dict.Add(tree[j], 1);
                            result.Add(tree[j]);
                        }
                        else
                            break;
                    }
                    else
                    {
                        result.Add(tree[j]);
                    }

                }

                allresults.Add(result);
            }

          


            var maxcount = allresults.Select(ar => ar.Count).Max();

            return maxcount;
        }



        public int NumUniqueEmails(string[] emails)
        {
            var len = emails.Length;
          //  var isdomain = false;
            var dict = new Dictionary<string, int>();
            for (var i = 0; i < len; i++)
            {
                var str = emails[i];
                for (var j = 0; j < str.Length; j++)
                {

                  //  if (!isdomain)
                  //  {
                        if (str[j] == '.')
                        {
                            str = str.Remove(j, 1);
                            j--;

                        }
                        else if (str[j] == '+')

                        {
                            var lentoremove = str.IndexOf('@') - j;
                            str = str.Remove(j, lentoremove);
                            j--;
                            //j -= lentoremove;
                        }
                        else if (str[j] == '@')
                        {
                            break; // isdomain = true;
                        }


                  //  }




                }
                if (!dict.ContainsKey(str))
                {
                    dict.Add(str, 1);
                }





            }

            return dict.Count;


        }




        public int BulbSwitch(int n)
        {
            checked
            {
                if (n <= 1)
                {
                    return n;
                }

                int res = 1;

                for (long i = 2; i * i <= n; i++)
                {
                    res++;
                }

                return res;
            }
        }


        //understand this one!!!!

         //   ::  redo from scratch!



        public int KEmptySlots(int[] bulbs, int k)
        {
            int res = Int32.MaxValue;
            int[] day = new int[bulbs.Length + 1];
            for (int i = 0; i < bulbs.Length; i++)
            {
                // day[i] is the day when the flower at position i blooms
                // day[0] is useless here
                day[bulbs[i]] = i + 1;
            }
           // var sync = "sdf";
           // sync.Remove()
            

            // we now are supposed to find a subarray of day[left, right] where its length is k+2 
            // and all i that left < i < right, we have day[i] > day[left] and day[i] > day[right]
            int left = 1, right = k + 2;
            for (int i = 2; right < day.Length; i++)
            {
                if (i == right)
                {
                    // found a sub array
                    res = Math.Min(res, Math.Max(day[left], day[right]));
                    left = i;
                    right = left + k + 1;
                }
                else if (day[i] < day[left] || day[i] < day[right])
                {
                    left = i;
                    right = left + k + 1;
                }
            }

            return (res == Int32.MaxValue) ? -1 : res;
        }
    


        public string NextClosestTime(string time)
        {
            var cur = 60 * Convert.ToInt32(time.Substring(0, 2));
            cur += Convert.ToInt32(time.Substring(3));

            var hash = new HashSet<int>();
            for (var i = 0; i < time.Length; i++)
            {
                if (time[i] != ':')
                    hash.Add(time[i] - '0');
            }

            while (true)
            {
                cur = (cur + 1)  % (24 * 60); 
                var hour1 = cur / 60 / 10;
                var hour2 = cur / 60 % 10;
                var min1 = cur % 60 / 10;
                var min2 = cur % 60 % 10;

                if (hash.Contains(hour1) && hash.Contains(hour2) && hash.Contains(min1) && hash.Contains(min2))
                {
                    var sb = new StringBuilder();
                    sb.Append(hour1);
                    sb.Append(hour2);
                    sb.Append(':');
                    sb.Append(min1);
                    sb.Append(min2);

                    

                    return sb.ToString();

                }

            }


            return "";
        }



        public int[] DailyTemperatures(int[] T)
        {
            var len = T.Length;
            var waitlist = new int[len];
            for (var i = 0; i < len; i++)
            {
                for (var j = i + 1; j < len; j++)
                {
                    if (T[j] > T[i])
                    {
                        waitlist[i] = j - i;
                        break;
                    }
                }
            }
            return waitlist;
        }

        public IList<int> MajorityElement(int[] nums)
        {
            var ocur = nums.Length / 3;
            var dict = new Dictionary<int, int>();

            
            var majority = new List<int>();
            for (var i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(nums[i]))
                {
                    dict[nums[i]]++;
                    if (dict[nums[i]] > ocur && !majority.Contains(nums[i]))
                    {
                        majority.Add(nums[i]);
                    }

                }
                else
                {
                    dict.Add(nums[i], 1);
                    if (dict[nums[i]] > ocur && !majority.Contains(nums[i]))
                    {
                        majority.Add(nums[i]);
                    }
                }
                    
            }
            return majority;


        }


        public TreeNode TrimBST(TreeNode root, int low, int high)
        {
            if (root == null)
                return null;
           
            if (root.val < low)
                return TrimBST(root.right, low, high);
            if (root.val > high)
                return TrimBST(root.left, low, high);

            root.left = TrimBST(root.left, low, high);
            root.right = TrimBST(root.right, low, high);
            return root;

        }



        public ListNode AddTwoNumbers6(ListNode l1, ListNode l2)
        {
            var s1 = new Stack<int>();
            var s2 = new Stack<int>();
            var carry = 0;
            var sum = 0;

            while (l1 != null)
            {
                s1.Push(l1.val);
                l1 = l1.next;
            }

            while (l2 != null)
            {
                s2.Push(l2.val);
                l2 = l2.next;
            }

            var sumstack = new Stack<int>();
            while (s1.Count > 0 || s2.Count > 0 || carry > 0)
            {
                sum = (s1.Count > 0 ? s1.Pop() : 0) + (s2.Count > 0 ? s2.Pop() : 0) + carry;
                carry = sum / 10;
                sum %= 10;

                sumstack.Push(sum);

            }


            var sumlist = new ListNode(sumstack.Pop());
            var head = sumlist;
            while (sumstack.Count > 0)
            {
                sumlist.next = new ListNode(sumstack.Pop());
                sumlist = sumlist.next;

            }

            return head;

        }



        //Efficient version:

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var s1 = ListToStack(l1);
            var s2 = ListToStack(l2);

            var carry = 0;
            ListNode head = null;
            while (s1.Count > 0 || s2.Count > 0 || carry == 1)
            {
                var val1 = s1.Count > 0 ? s1.Pop() : 0;
                var val2 = s2.Count > 0 ? s2.Pop() : 0;
                var sum = val1 + val2 + carry;
                carry = sum / 10;
                sum = sum % 10;

                var node = new ListNode(sum);
                node.next = head;
                head = node;
            }

            return head;
        }


        private Stack<int> ListToStack(ListNode l)
        {
            var stack = new Stack<int>();
            while (l != null)
            {
                stack.Push(l.val);
                l = l.next;
            }
            return stack;
        }










        public string RemoveKdigits(string num, int k)
        {
            var len = num.Length;
            var stack = new Stack<char>();

            for (var i = 0; i < len; i++)
            {
                while (stack.Count > 0 & k > 0 && stack.Peek() > num[i])
                {
                    stack.Pop();
                    k--;
                }
                stack.Push(num[i]);

            }
            while (k > 0)
            {
                stack.Pop();
                k--;
            }



            var sb = new StringBuilder();
            while (stack.Count > 0)
            {
                sb.Insert(0, stack.Pop());
            }

            for (var j = 0; j < sb.Length; j++)
            {
                if (sb[j] > '0')
                    break;
                else
                {
                    sb.Remove(j, 1);
                    j--;
                }
            }

            if (sb.Length == 0)
                return "0";

            return sb.ToString();



        }


        public bool RepeatedSubstringPattern(string s)
        {
            if (s.Length <= 1)
                return false;
            var strtocheck = new StringBuilder();
            for (var i = 0; i < s.Length; i++)
            {
                strtocheck.Append(s[i]);
                var len = strtocheck.Length;
                if (s.Length % len > 0 || (i + 1 + len) > s.Length)
                    continue;
                var isrepeated = true;
                for (var j = i + 1; j + len <= s.Length; j += len)
                {

                    if (strtocheck.ToString() != s.Substring(j, len))
                    {
                        isrepeated = false;
                        break;
                    }
                }
                if (isrepeated == true)
                    return true;
            }
            return false;
        }









        //works!!  finds first peak!.  Takes into account lengths of 1, 2, and above.
        public int FindPeakElement(int[] nums)
        {
            //var b = "ab";
            //var a = new StringBuilder();
            //a.Append("a");
            //var c = a.Length;
            //if (a.t == b[0].ToString())
            //{

            //}

            var len = nums.Length;
            if (len == 1)
                return 0;
            var peak = 0;
            for (var i = 1; i < len; i++)
            {
                if (nums[i] > nums[i - 1] && ((i > len - 2) || nums[i] > nums[i + 1]))
                    peak = i;
            }
            return peak;
        }


        //works, with no 2nd function and 2 global vars

        TreeNode successor;
       // int sval;
        public TreeNode InorderSuccessor2(TreeNode root, TreeNode p)
        {
            //if (root == null)
            //    return null;
            //var diff = root.val - p.val;
            //if (diff > 0 && (overalldiff == 0 || diff < overalldiff))
            //{
            //    overalldiff = diff;
            //    successor = root;
            //}
            //if (root.val > p.val)
            //    InorderSuccessor2(root.left, p);
            //else
            //    InorderSuccessor2(root.right, p);

            //return successor;






            if (root == null)
                return null;
            var diff = root.val - p.val;
            if (diff > 0)
            {
                // sval = diff;
                successor = root;
                //  }

                //  if (diff > 0)
                InorderSuccessor(root.left, p);
            }
            else
                InorderSuccessor(root.right, p);


            return successor;








        }









        TreeNode successornode;

        public TreeNode InorderSuccessor(TreeNode root, TreeNode p)
        {
            var diff = Math.Abs(root.val - p.val);
            if (diff <= 0)
                diff = Int32.MaxValue;
            if (root.val != p.val && root.val > p.val)
                successornode = root;

            if (root.val <= p.val)
                Traverse(root.right, p.val, diff);
            else
                Traverse(root.left, p.val, diff);


           // Traverse(root, p.val, Math.Abs(root.val - p.val));
            return successornode;
        }

        private void Traverse(TreeNode node, int key, int successor)
        {
            if (node == null)
                return;
            var diff = Math.Abs(node.val - key);
            if (diff > 0 && diff < successor && node.val > key)
            {
                successor = Math.Abs(node.val - key);
                successornode = node;
            }
            if (node.val <= key)
                Traverse(node.right, key, successor);
            else
                Traverse(node.left, key, successor);

        }


       





        public void SortColors(int[] nums)
            {
                var len = nums.Length;
                var left = 0;
                var right = len - 1;
                for (var i = 0; i <= right; i++)
                {

                    if (nums[i] == 2)
                    {
                        (nums[i], nums[right]) = (nums[right], nums[i]);
                        right--;
                    i--;
                    }
                    else if (nums[i] == 0)
                    {
                        (nums[i], nums[left]) = (nums[left], nums[i]);
                        left++;
                       
                    }
                }
            }

        





        List<int> list1 = new List<int>();
        List<int> list2 = new List<int>();

        public bool LeafSimilar(TreeNode root1, TreeNode root2)
        {
            TraverseLeaf(root1, list1);
            TraverseLeaf(root2, list2);

            if (Enumerable.SequenceEqual(list1, list2))
                return true;
            else return false;
        }

        private void TraverseLeaf(TreeNode root, List<int> list)
        {
            if (root.left == null && root.right == null)
            {
                list.Add(root.val);
                return;
            }
            if (root.left != null)
                TraverseLeaf(root.left, list);
            if (root.right != null)
                TraverseLeaf(root.right, list);
        }






        







        public string DayOfTheWeek(int day, int month, int year)
        {
            var newdate = new DateTime(year, month, day);
            var dow = newdate.DayOfWeek;
            return dow.ToString();
        }



        public string LargestTimeFromDigits2(int[] arr)
        {
            //Array.Sort(arr);
            //var digits = arr .ToString();
            var digits = String.Concat(arr.OrderBy(x => x)); // arr.Select(x => x).OrderBy(x => x));
            var hora = DateTime.Parse("23:59");
            while (hora >= DateTime.Parse("00:00 AM"))
            {
                var newdig = String.Concat($"{hora:HH:mm}".Replace(":", "").OrderBy(x => x));
                if (newdig == digits) return $"{hora:HH:mm}";
                hora = hora.AddMinutes(-1);
            }
            return "";
        }


        public string LargestTimeFromDigits3(int[] arr)
        {
            var digits = String.Concat(arr.OrderBy(x => x));
            var maxtime = DateTime.Parse("23:59");

            while (maxtime >= DateTime.Parse("00:00"))
            {
                var newtime = String.Concat($"{maxtime:HH:mm}".Replace(":", "").OrderBy(x => x));
                if (newtime == digits)
                    return $"{maxtime:HH:mm}";
                maxtime = maxtime.AddMinutes(-1);
            }
            return "";

        }



        public bool IsOneBitCharacter(int[] bits)
        {
            if (bits.Length == 1)
                return true;
            var lastzero = false;
            for (var i = 0; i < bits.Length; i++)
            {
                if (bits[i] == 0)
                    lastzero = true;
                else
                {
                    lastzero = false;
                    i++;
                }
            }
            return lastzero;
        }
        public bool WordBreak2(string s, IList<string> wordDict)
        {
            if (s == null || s.Length == 0)
                return false;
           // var start = 0;
           // var end = 1;
            var hit = false;
           // var wd2 = new List<string>();
           // wd2.AddRange(wordDict);


            while (s.Length > 0)
            {
                foreach(var word in wordDict)
                {
                    var foundindex = s.IndexOf(word);
                    if (foundindex >= 0)
                    {
                        s = s.Remove(foundindex, word.Length);
                        hit = true;
                        if (s.Length == 0)
                            break;
                    }
                    else
                        hit = false;
                }
            }


            //while (end <= s.Length)
            //{
            //    if (wd2.Contains(s.Substring(start, end - start)))
            //    {
            //       // wd2.Remove(s.Substring(start, end - start));
            //        hit = true;
            //        start = end;
            //        end++;
            //    }

            //    else
            //    {
            //        hit = false;
            //        if (end == s.Length && hit == false)
            //            break;
            //        end++;
            //    }


            //}
            return hit;

        }



            public bool WordBreak(string s, IList<string> wordDict)
        {
            var dp = new bool[s.Length + 1];
            dp[0] = true;
            for (int i = 0; i < s.Length; i++)
                if (dp[i])
                    foreach (var dict in wordDict)
                        if (string.Compare(s, i, dict, 0, dict.Length) == 0)
                            dp[i + dict.Length] = true;
            return dp[s.Length];
        }


        public bool CheckInclusion(string s1, string s2)
        {
            if (s1.Length > s2.Length)
            {
                return false;
            }

            int[] s1Frequency = new int[26];


            for (int i = 0; i < s1.Length; i++)
            {
                s1Frequency[s1[i] - 'a']++;
            }


            int[] s2Frequency = new int[26];
            for (int i = 0; i < s2.Length; i++)
            {
                s2Frequency[s2[i] - 'a']++;
                if (i >= (s1.Length - 1))
                {
                    if (check(s1Frequency, s2Frequency))
                    {
                        return true;
                    }

                    s2Frequency[s2[i - (s1.Length - 1)] - 'a']--;
                }
            }

            return false;
        }

        private bool check(int[] a, int[] b)
        {
            for (int i = 0; i < 26; i++)
            {
                if (a[i] != b[i])
                {
                    return false;
                }
            }

            return true;
        }



        public bool CheckInclusionsucks(string s1, string s2)
        {
            if (string.IsNullOrWhiteSpace(s1) || string.IsNullOrWhiteSpace(s2))
                    return false;
            if (s1 == s2)
                return true;
            var len = s1.Length-1;
            var found = true;
            var start = s2.IndexOfAny(s1.ToCharArray()) ;
            s1.Remove(s2[start]);
            start++;
            if (start < s2.Length)
            {
                var i = start;
                while (len > 0 &&  i < s2.Length)
                {
                    if (!s1.Contains(s2[i]))
                    {
                        return false;
                    }
                    else
                    {

                    }

                    i++;
                    len--;
                }
                if (len == 0)
                    found = true;
            }

            return found;


        }



        //Given a binary tree, imagine yourself standing on the right side of it, return the values of the nodes you can see ordered from top to bottom
        public IList<int> RightSideView(TreeNode root)
        {
            var right = new List<int>();

            traverse(root, right, 1);

            return right;

        }


        private void traverse(TreeNode node, IList<int> rightnodes, int level)
        {
            if (node == null)
            {
                return;
            }
            if (level > rightnodes.Count)
                rightnodes.Add(node.val);

            if (node.right != null)
                traverse(node.right, rightnodes, level + 1);
            if (node.left != null)
                traverse(node.left, rightnodes, level + 1);

        }





        //Remove Duplicates from Sorted List
        //Given a sorted linked list, delete all duplicates such that each element appear only once.
        public ListNode DeleteDuplicates(ListNode head)
        {
            if (head == null)
                return null;
            var prev = head;
            var node = prev;
           
            while (node != null)
            {
                prev = node;
                node = node.next;
                while (node != null && prev.val == node.val)
                {
                    node = node.next;
                }
                prev.next = node; 

            }
            return head;
        }





        //Clone Graph
        //Given a reference of a node in a connected undirected graph.
        //    Return a deep copy (clone) of the graph.
        //   Each node in the graph contains a val (int) and a list (List[Node]) of its neighbors.

        //public class GraphNode
        //{
        //    public int val;
        //    public IList<GraphNode> neighbors;

        //    public GraphNode()
        //    {
        //        val = 0;
        //        neighbors = new List<GraphNode>();
        //    }

        //    public GraphNode(int _val)
        //    {
        //        val = _val;
        //        neighbors = new List<GraphNode>();
        //    }

        //    public GraphNode(int _val, List<GraphNode> _neighbors)
        //    {
        //        val = _val;
        //        neighbors = _neighbors;
        //    }
        //}



        //Dictionary<int, GraphNode> clonedict = new Dictionary<int, GraphNode>();
        //public GraphNode CloneGraph(GraphNode node)
        //{
        //    if (node == null) return null;
        //    if (clonedict.ContainsKey(node.val))
        //        return clonedict[node.val];
        //    GraphNode nd = new GraphNode(node.val);
        //    clonedict.Add(nd.val, nd);
        //    foreach (GraphNode n in node.neighbors)
        //        nd.neighbors.Add(CloneGraph(n));
        //    return nd;
        //}




        //Task Scheduler
        //Given a characters array tasks, representing the tasks a CPU needs to do, where each letter represents a different task.Tasks could be done in any order.Each task is done in one unit of time. For each unit of time, the CPU could complete either one task or just be idle.
        //However, there is a non-negative integer n that represents the cooldown period between two same tasks (the same letter in the array), that is that there must be at least n units of time between any two same tasks.
        //Return the least number of units of times that the CPU will take to finish all the given tasks.

        public int LeastInterval(char[] tasks, int n)
        {

            int maxFreq = 0, interval = 0, cnt = 0;
            int[] freq = new int[26];


            foreach (char t in tasks)
            {
                freq[t - 'A']++;

                // Find the most frequent task
                if (freq[t - 'A'] > maxFreq)
                {
                    maxFreq = freq[t - 'A'];
                    cnt = 1;
                }
                // Count the number of most frequent tasks
                else if (freq[t - 'A'] == maxFreq)
                    cnt++;
            }

            // maxFreq - 1: blocks needed to allocate the first maxFreq-1 most-frequent task
            // n + 1: each block needs n+1 spaces due the the cooling interval.
            // cnt: Size of last block = number of most-frequent tasks
            interval = (maxFreq - 1) * (n + 1) + cnt;

            return interval < tasks.Length ? tasks.Length : interval;
        }

        //Merge Intervals
        //Given a collection of intervals, merge all overlapping intervals.
        public int[][] Merge(int[][] intervals)
        {
            if (intervals == null || intervals.Length == 0)
                return new int[][] { };

            List<int[]> result = new List<int[]>();

            Array.Sort(intervals, (x, y) => x[0].CompareTo(y[0]));

            int s = intervals[0][0],
                e = intervals[0][1];

            for (int i = 1; i < intervals.Length; i++)
                if (e < intervals[i][0])
                {
                    result.Add(new int[] { s, e });

                    s = intervals[i][0];
                    e = intervals[i][1];
                }
                else
                    e = Math.Max(e, intervals[i][1]);

            result.Add(new int[] { s, e });

            return result.ToArray();
        }







        //Valid Parentheses
        //Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

        public bool IsValid(string s)
        {
            if (s.Length == 0)
            return true;
        Stack<char> stacky =
            new Stack<char>();
        Dictionary<char, char> dict =
            new Dictionary<char, char>();
        string parens = "(){}[]";
        for (int i = 0; i<parens.Length - 1; i+=2)
            dict.Add(parens[i + 1], parens[i]);

        foreach (char c in s){

            if (dict.ContainsKey(c)){
                //print($"at {c}, expecting {dict[c]}\n");
                if (stacky.Count == 0)
                    return false;
                char top = stacky.Pop();
                if (top != dict[c])
                    return false;
            }
            else{
                stacky.Push(c);
            }

        }

        return (stacky.Count == 0);

    }



        //Binary Tree Paths
        //Given a binary tree, return all root-to-leaf paths.

        public IList<string> BinaryTreePaths(TreeNode root)
        {
            var paths = new List<string>();
            traverse(root, "", paths);
            return paths;
        }

        private void traverse(TreeNode node, string path, IList<string> paths)
        {
            if (node == null)
                return;
            else if (node.left == null && node.right == null)
            {
                paths.Add(path + node.val);
                return;
            }
            else
            { 
                traverse(node.left, path + node.val + "->", paths);
                traverse(node.right, path + node.val + "->", paths);
            }
        }



        //Smallest Subtree with all the Deepest Nodes
        //Given the root of a binary tree, the depth of each node is the shortest distance to the root.
        //  Return the smallest subtree such that it contains all the deepest nodes in the original tree.
        //A node is called the deepest if it has the largest depth possible among any node in the entire tree.
        //The subtree of a node is tree consisting of that node, plus the set of all descendants of that node.


        public TreeNode SubtreeWithAllDeepest(TreeNode root)
        {
            // the idea is to apply post order traversal
            // if there are two children, both have same depth - return root
            // if one is bigger, than go to the bigger
            // recursive function is design to return depth from root to leaf node maximum path        
            var result = runPostOrderTraversal(root);
            return result.Item2;
        }

        ///  root 1, left 2, right 3, and right.right = 4
        private Tuple<int, TreeNode, int> runPostOrderTraversal(TreeNode root)
        {
            if (root == null)
            {
                return new Tuple<int, TreeNode, int>(0, null, 0);
            }

            // Left, right
            var left = runPostOrderTraversal(root.left); // 2
            var right = runPostOrderTraversal(root.right);

            var path1 = left.Item1;
            var path2 = right.Item1;

            if (path1 == path2)
            {
                return new Tuple<int, TreeNode, int>(path1 + 1, root, path1 + 1);
            }
            else if (path1 < path2)
            {
                return new Tuple<int, TreeNode, int>(path2 + 1, right.Item2, right.Item3);
            }
            else
                return new Tuple<int, TreeNode, int>(path1 + 1, left.Item2, left.Item3);
        }




        //Lowest Common Ancestor of a Binary Tree
        //Given a binary tree, find the lowest common ancestor(LCA) of two given nodes in the tree.
        //According to the definition of LCA on Wikipedia: “The lowest common ancestor is defined between two nodes p and q as the lowest node in 
        //T that has both p and q as descendants (where we allow a node to be a descendant of itself).”

        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            var tuple = postOrderTraversal(root, p, q);
            return tuple.Item1;
        }

        /// <summary>
        /// return LCA and count of nodes found
        /// </summary>
        /// <param name="root"></param>
        /// <param name="p"></param>
        /// <param name="q"></param>
        /// <returns></returns>
        private static Tuple<TreeNode, int> postOrderTraversal(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root == null)
            {
                return new Tuple<TreeNode, int>(null, 0);
            }

            var left = postOrderTraversal(root.left, p, q);
            if (left.Item1 != null)
            {
                return left;
            }

            var right = postOrderTraversal(root.right, p, q);
            if (right.Item1 != null)
            {
                return right;
            }

            int count = left.Item2 + right.Item2 + ((root == p || root == q) ? 1 : 0);
            if (count == 2)
            {
                return new Tuple<TreeNode, int>(root, 2);
            }

            return new Tuple<TreeNode, int>(null, count);
        }








        public ListNode MergeTwoLists3(ListNode l1, ListNode l2)
        {
            var node = new ListNode(0);
            var head = node;

            while (l1 != null && l2 != null)
            {
                if (l1.val <= l2.val)
                {
                    node.next = l1;
                    node = node.next;
                    l1 = l1.next;
                }
                else
                {
                    node.next = l2;
                    node = node.next;
                    l2 = l2.next;
                }
            }

            if (l1 != null)
                node.next = l1;
            else
                node.next = l2;

            return head.next;
        }




        //Interval List Intersections
        //Given two lists of closed intervals, each list of intervals is pairwise disjoint and in sorted order.
        //Return the intersection of these two interval lists.
        //(Formally, a closed interval [a, b] (with a <= b) denotes the set of real numbers x with a <= x <= b.
        //The intersection of two closed intervals is a set of real numbers that is either empty, or can be represented as a closed interval.For example, the intersection of[1, 3] and[2, 4] is [2, 3].)

        public int[][] IntervalIntersection(int[][] A, int[][] B)
        {
            List<int[]> result = new List<int[]>();
            int i = 0, j = 0;

            while (i < A.Length && j < B.Length)
            {
                int aStart = A[i][0], aEnd = A[i][1];
                int bStart = B[j][0], bEnd = B[j][1];

                if (aEnd >= bStart || bEnd >= aStart)
                {
                    int maxStart = Math.Max(aStart, bStart);
                    int minEnd = Math.Min(aEnd, bEnd);

                    if (maxStart <= minEnd)
                    {
                        result.Add(new int[] { maxStart, minEnd });
                    }

                    if (aEnd < bEnd)
                    {
                        i++;
                    }
                    else
                    {
                        j++;
                    }
                }
            }

            return result.ToArray();
        }



        //Course Schedule
        //There are a total of numCourses courses you have to take, labeled from 0 to numCourses-1.
        //Some courses may have prerequisites, for example to take course 0 you have to first take course 1, which is expressed as a pair: [0,1]
        //Given the total number of courses and a list of prerequisite pairs, is it possible for you to finish all courses?

        public bool CanFinish(int numCourses, int[][] prerequisites)
        {
            if (prerequisites.GetLength(0) == 0)
                return true;

            bool[] visited = new bool[numCourses];
            List<int>[] graph = new List<int>[numCourses];

            for (int i = 0; i <= numCourses - 1; i++)
                graph[i] = new List<int>();

            for (int i = 0; i <= prerequisites.GetLength(0) - 1; i++)
                graph[prerequisites[i][0]].Add(prerequisites[i][1]);

            for (int i = 0; i <= graph.Length - 1; i++)
                if (!visited[i])
                    if (!DFS(graph, visited, new bool[numCourses], i))
                        return false;

            return true;
        }

        private bool DFS(List<int>[] graph, bool[] visited, bool[] currentPath, int course)
        {
            if (currentPath[course])
                return false;

            visited[course] = true;
            currentPath[course] = true;

            for (int i = 0; i < graph[course].Count; i++)
                if (!DFS(graph, visited, currentPath, graph[course][i]))
                    return false;

            currentPath[course] = false;

            return true;

        }


        //Continuous Subarray Sum
        //Given a list of non-negative numbers and a target integer k, write a function to check if the array has a continuous subarray of size at least 2 that sums up to a multiple of k, 
        //that is, sums up to n* k where n is also an integer.
        public bool CheckSubarraySum(int[] nums, int k)
        {
            int sum = 0;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                sum = nums[i];
                for (int j = i + 1; j < nums.Length; j++)
                {
                    sum += nums[j];
                    if (sum == 0 && k == 0)
                        return true;

                    if (k != 0)
                    {
                        if (sum % k == 0)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }




        //Partition Equal Subset Sum
        //Given a non-empty array containing only positive integers, find if the array can be partitioned into two subsets such that the sum of elements in both subsets is equal.
        //    Note: Each of the array element will not exceed 100.
        //The array size will not exceed 200.


        public bool CanPartition(int[] nums)
        {
            var n = nums.Length;
            var sum = nums.Sum();

            if (sum % 2 != 0) return false;

            var target = sum / 2;

            if (nums.Contains(target)) return true;

            var dp = new bool[n + 1, target + 1];

            for (int i = 0; i <= n; i++)
            {
                dp[i, 0] = true;
            }

            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j <= target; j++)
                {
                    dp[i, j] = dp[i - 1, j];
                    if (j >= nums[i - 1])
                    {
                        dp[i, j] |= dp[i - 1, j - nums[i - 1]];
                    }
                }
            }

            return dp[n, target];
        }








        //Shortest Bridge
        //In a given 2D binary array A, there are two islands.  (An island is a 4-directionally connected group of 1s not connected to any other 1s.)
        //Now, we may change 0s to 1s so as to connect the two islands together to form 1 island.
        //Return the smallest number of 0s that must be flipped.  (It is guaranteed that the answer is at least 1.)

        int row;
        int col;
        public int ShortestBridge(int[][] A)
        {
            row = A.Length;
            if (row == 0) return 0;
            col = A[0].Length;

            var island1 = new List<int[]>();
            var island2 = new List<int[]>();

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (A[i][j] == 1 && island1.Count == 0)
                    {
                        Dfs(A, island1, i, j);
                    }
                    else
                    {
                        Dfs(A, island2, i, j);
                    }
                }
            }
            int min = 100;
            foreach (var i1 in island1)
            {
                foreach (var i2 in island2)
                {
                    min = Math.Min(min, Math.Abs(i1[0] - i2[0]) + Math.Abs(i1[1] - i2[1]) - 1);
                }
            }
            return min;
        }

        public void Dfs(int[][] A, List<int[]> island, int i, int j)
        {
            if (i < 0 || i >= row || j < 0 || j >= col || A[i][j] == 0) return;
            A[i][j] = 0;
            island.Add(new int[] { i, j });
            Dfs(A, island, i + 1, j);
            Dfs(A, island, i, j - 1);
            Dfs(A, island, i - 1, j);
            Dfs(A, island, i, j + 1);
        }





        //Serialize and Deserialize Binary Tree
        //Design an algorithm to serialize and deserialize a binary tree.There is no restriction on how your serialization/deserialization algorithm should work. You just need to ensure that a binary tree
        //can be serialized to a string and this string can be deserialized to the original tree structure.

        public string serialize(TreeNode root)
        {
            if (root == null) return "null";
            return root.val + " " + serialize(root.left) + " " + serialize(root.right);
        }


        public TreeNode deserialize(string data)
        {
            List<TreeNode> list = new List<TreeNode>();

            if (data == "null") return null;

            string[] words = data.Split(' ');
            TreeNode root = new TreeNode(Convert.ToInt32(words[0]));
            list.Add(root);

            bool goLeft = true;
            for (int i = 1; i < words.Count(); ++i)
            {
                if (words[i] == "null")
                {
                    if (goLeft) goLeft = false;
                    else list.RemoveAt(list.Count() - 1);
                }
                else
                {
                    TreeNode node = new TreeNode(Convert.ToInt32(words[i]));
                    if (goLeft)
                    {
                        list[list.Count() - 1].left = node;
                    }
                    else
                    {
                        list[list.Count() - 1].right = node;
                        list.RemoveAt(list.Count() - 1);
                    }
                    list.Add(node);
                    goLeft = true;
                }
            }

            return root;
        }


        //Valid Palindrome II
        //Given a non-empty string s, you may delete at most one character. Judge whether you can make it a palindrome. 
        //works TOOO  SLOWW
        public bool ValidPalindrome(string s)
        {

            var r = new string( s.Reverse().ToArray());
            if (r == s)
                return true;
            for (var i = 0; i < s.Length; i++)
            {
                var palindrome = s.Remove(i, 1);
                var reversedpalindrome = new string( palindrome.Reverse().ToArray());
                if (palindrome == reversedpalindrome)
                    return true;
            }

            return false;


        }

        //WORKS GOOD:
        public bool ValidPalindrome2(string s)
        {
            if (s == null || s.Length <= 2)
            {
                return true;
            }
            char[] chars = s.ToCharArray();

            int l = 0, r = s.Length - 1;
            while (l < r)
            {
                if (chars[l] != chars[r])
                {
                    return isPalindrome(chars, l) || isPalindrome(chars, r);
                }
                l++;
                r--;
            }

            return true;

        }
        private bool isPalindrome(char[] s, int idx)
        {
            int l = 0, r = s.Length - 1;
            while (l < r)
            {
                if (l == idx)
                {
                    l++;
                }
                else if (r == idx)
                {
                    r--;
                }

                if (s[l] != s[r])
                {
                    return false;
                }
                l++;
                r--;
            }
            return true;
        }






        private int result1 = 0;
        private int[] nodes = null;

        public int CountComponents(int n, int[][] edges)
        {
            result1 = n;
            nodes = new int[n];

            for (int i = 0; i < n; i++)
                nodes[i] = i;

            foreach (var item in edges)
                Union(item[0], item[1]);

            return result1;
        }

        private void Union(int x, int y)
        {
            int px = Find(x),
                py = Find(y);

            if (px != py)
            {
                result1--;
                nodes[py] = px;
            }
        }

        private int Find(int x)
        {
            if (x != nodes[x])
                nodes[x] = Find(nodes[x]);

            return nodes[x];
        }


        public class BoolNode
        {
            public bool val;
            public Node next;
            public Node random;

            public BoolNode(bool _val)
            {
                val = _val;
                next = null;
                random = null;
            }
        }

        //n-ary Tree with each node having a boolean flag.Traverse all the nodes with only boolean flag = True.Return the total distance traveled from root to all those nodes.
        //int traverseNodes(BoolNode node)
        //{
        //    if (node.val == false)
        //        return 0;

        //    int result = 1;
        //    for (int i = 0; i < node->subnodes.size(); ++i)
        //    {
        //        result += traverseNodes(node->subnodes[i]);
        //    }
        //    return result;
        //}




        //Question 0. Similar strings ("face", "eacf") returns true if only 2 positions in the strings are swapped. Here 'f' and 'e' are swapped in the example.
        public bool areSimilar(string a, string b)
        {
            if (a.Length != b.Length)
                return false;
            int diffCount = 0;
            int[] diffIndices = new int[2];
            for (int i = 0; i < a.Length; ++i)
            {
                if (a[i] != b[i])
                {
                    if (diffCount == 2)
                        return false;
                    diffIndices[diffCount++] = i;
                }
            }
            return diffCount == 0 || (diffCount == 2 &&
                a[diffIndices[0]] == b[diffIndices[1]] &&
                a[diffIndices[1]] == b[diffIndices[0]]);
        }





        //Given an array of integers with possible duplicates, randomly output the index of a given target number. You can assume that the given target number must exist in the array.

        Random random = new Random();
        int[] nums;

        //public Solution(int[] nums)
        //{
        //    this.nums = nums;
        //}

        public int Pick(int target)
        {
            var candidate = -1;
            var n = nums.Length;

            var count = 0;
            for (int i = 0; i < n; i++)
            {
                if (nums[i] != target) continue;

                count++;

                var randomIndex = random.Next(count);
                if (randomIndex == 0)
                {
                    candidate = i;
                }
            }
            return candidate;
        }






        //Given a non-empty array of digits representing a non-negative integer, increment one to the integer.
        //The digits are stored such that the most significant digit is at the head of the list, and each element in the array contains a single digit.
        //You may assume the integer does not contain any leading zero, except the number 0 itsel

        public int[] PlusOne(int[] digits)
        {
            
            var results = new List<int>();
            
            var carry = 1;
            var sum = 0;
            for (var i = digits.Length - 1; i >= 0; i--)
            {
                sum = digits[i] + carry;
                carry = sum / 10;
                sum %= 10;
                results.Add(sum);
            }
            if (carry == 1)
                results.Add(1);

            results.Reverse();
            return results.ToArray();

        }

        //Minimum Remove to Make Valid Parentheses
        //Given a string s of '(' , ')' and lowercase English characters.
        //Your task is to remove the minimum number of parentheses ( '(' or ')', in any positions) so that the resulting parentheses string is valid and return any valid string.
        //Case study
        //In order for me to solve the algorithm, I learn that I have to put two test cases into consideration.
        //Case 1: lee(t(c) o)de)
        //The idea is to use stack to store all indexes of open paretheses, and if there is ')', then remove matched open parethese.Otherwise replace stringbuilder temporary variable copy - a copy of string - using placeholder char* at index of ')'. We can name it "replace unmatched close parenthese with wildchar *".
        //lee(t(c) o)de) -> lee(t(c) o)de* -> remove* in the string.
        //put '(' in stack, and if there is matched ')', then pop '(' otherwise replace stringBuilder index position with '*'.

        public String MinRemoveToMakeValid(String s)
        {

            var sb = new StringBuilder(s);
            var stack = new Stack<int>();

            var length = s.Length;
            for (int i = 0; i < length; i++)
            {
                var current = s[i];
                var isOpen = current == '(';
                var isClose = current == ')';

                if (isOpen)
                {
                    stack.Push(i);
                }

                if (isClose)
                {
                    if (stack.Count > 0)
                    {
                        stack.Pop();
                    }
                    else
                    {
                        sb.Replace(')', '*', i, 1);
                    }
                }
            }

            // remove extract ((, for example ))((
            while (stack.Count > 0)
            {
                sb.Remove(stack.Pop(), 1);
            }

            return sb.Replace("*", "", 0, sb.Length).ToString();



        }



        //Alien Dictionary 
        //There is a new alien language which uses the latin alphabet.However, the order among letters are unknown to you.You receive a list of non-empty
        //words from the dictionary, where words are sorted lexicographically by the rules of this new language.Derive the order of letters in this language.

        public string AlienOrdersucks(string[] words)
        {
            var len = 0;
            foreach (var word in words)
            {
                len = word.Length > len ? word.Length : len;
            }

            var order = new HashSet<char>();
            order.Add(words[0][0]);

            for (var letter = 0; letter < len; letter ++)
            {
                for (var word = 0; word < len; word++)
                {
                    if (letter < words[word].Length && letter < words[word+1].Length && words[word][letter] != words[word+1][letter]
                        && !order.Contains(words[word + 1][letter]))
                    {
                        order.Add(words[word+1][letter]);
                    }
                }
            }
            return new string ( order.Select(o => o).ToArray());
        }



            public string AlienOrder(string[] words)
        {


            var queue = new Queue<char>();
            var graph = new Dictionary<char, List<char>>();
            var indegree = new Dictionary<char, int>();
            var result = new StringBuilder();

            // Build graph and ingergee
            foreach (var word in words)
            {
                foreach (var c in word)
                {
                    if (!graph.ContainsKey(c)) { graph.Add(c, new List<char>()); }
                    if (!indegree.ContainsKey(c)) { indegree.Add(c, 0); }
                }
            }

            // Iterate by words to initialize graph and indegree
            for (var i = 1; i < words.Length; i++)
            {
                var word1 = words[i - 1];
                var word2 = words[i];

                if (word1.Length > word2.Length && word1.StartsWith(word2)) { return String.Empty; }

                for (var j = 0; j < Math.Min(word1.Length, word2.Length); j++)
                {
                    if (word1[j] != word2[j])
                    {
                        // Add relation
                        graph[word1[j]].Add(word2[j]);

                        // Increase indegree
                        indegree[word2[j]]++;
                        break;
                    }
                }
            }

            // Add chars with 0 indegree to queue
            foreach (KeyValuePair<char, int> kv in indegree)
            {
                if (kv.Value == 0)
                {
                    queue.Enqueue(kv.Key);
                }
            }

            // BFS
            while (queue.Any())
            {
                var vertex = queue.Dequeue();

                foreach (var c in graph[vertex])
                {
                    if (--indegree[c] == 0)
                    {
                        queue.Enqueue(c);
                    }
                }

                result.Append(vertex);
            }

            return result.Length == indegree.Count ? result.ToString() : String.Empty;


        }






        //Kth Smallest Element in a BST
        //Given a binary search tree, write a function kthSmallest to find the kth smallest element in it.

        public int KthSmallest(TreeNode root, int k)
        {
            return helper(root, ref k);
        }

        int helper(TreeNode root, ref int k)
        {
            if (root == null) return -1;
            int x = helper(root.left, ref k);
            if (k == 0) return x;
            if (--k == 0) return root.val;
            return helper(root.right, ref k);
        }

        //Range Sum of BST
        //Given the root node of a binary search tree, return the sum of values of all nodes with value between L and R(inclusive).
        //The binary search tree is guaranteed to have unique values.

        public int RangeSumBST(TreeNode root, int L, int R)
        {
            if (root == null)
                return 0;
            return (root.val >= L && root.val <= R ? root.val : 0) + RangeSumBST(root.left, L, R) + RangeSumBST(root.right, L, R);
        }


        ///find-index-maximum-occurring-element-equal-probability/*
        ///
        //Facebook have a practice of asking problems on Random and Reservoir Sampling.
        //This problem relates to Reservoir Sampling.
        //It should be solved with O(1) space and time O(N).
        //Hence, any solution beyond would be considered by interviewer as failed.

        public void maxRandomIndex(int[] nums)
        {
            Random random = new Random();

            int max = int.MinValue;
            int maxIndex = -1;

            int count = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > max)
                {
                    max = nums[i];
                    maxIndex = i;
                    count = 1;
                }
                else if (nums[i] == max)
                {
                    count++;

                    // probability of 1/count
                    if (random.Next(count) == 0)
                    {
                        maxIndex = i;
                    }
                }

                Console.Write(maxIndex + " ");
            }
        }









        //See code in MAIN on how to call it!!
        //Facebook interview onsite
        //You are given a mn grid.You are asked to generate k mines on this grid randomly. Each cell should have equal probability of k / mn of being chosen. Your algorithm should run in O(m) time.
        public void generateKMines(char[][] grid, int K)
        {
            int m = grid.Length, n = grid[0].Length;
            int count = 0;
            Random random = new Random();
            while (count != K)
            {
                int index = random.Next(m * n);
                int i = index % m, j = index % n;
                if (grid[i][j] != 'X')
                {
                    grid[i][j] = 'X';
                    count++;
                }

            }
        }



        public string AddBinary(string a, string b)
        {
            var aindex = a.Length - 1;
            var bindex = b.Length - 1;
            var carry = 0;
            var sum = 0;
            var total = new StringBuilder();
            while (aindex >= 0 || bindex >= 0 || carry == 1)
            {
                sum = (aindex < 0 ? 0 : a[aindex] - '0') + (bindex < 0 ? 0 : b[bindex] - '0') + carry;
                carry = sum / 2;
                sum %= 2;
                total.Insert(0, sum);
                aindex--;
                bindex--;

            }
            return total.ToString();
        }


        //Valid Palindrome
        //Given a string, determine if it is a palindrome, considering only alphanumeric characters and ignoring cases.
        //Note: For the purpose of this problem, we define empty string as valid palindrome.
        public bool IsPalindrome2(string s)
        {
            var clean = new StringBuilder();
            for (var i = 0; i < s.Length; i++)
            {
                if (char.IsLetterOrDigit(s[i]))
                    clean.Append(char.ToLower(s[i]));
            }

            var reversed = new string(clean.ToString().Reverse().ToArray());

            if (clean.ToString() == reversed)
                return true;
            else
                return false;
        }




        public string AddStrings(string num1, string num2)
        {
            if (string.IsNullOrWhiteSpace(num1) || string.IsNullOrWhiteSpace(num2))
                return string.Empty;
            var len1 = num1.Length - 1;
            var len2 = num2.Length - 1;

            var sum = 0;
            var carry = 0;
            var total = new StringBuilder();
            while (len1 >= 0 || len2 >= 0 || carry == 1)
            {
                sum = (len1 < 0 ? 0 : num1[len1] - '0') + (len2 < 0 ? 0 : num2[len2] - '0') + carry;
                carry = sum / 10;
                sum %= 10;
                total.Insert(0,sum);
                len1--;
                len2--;

            }

            return total.ToString();



        }

        //  Minimum Window Substring
        //  Given a string S and a string T, find the minimum window in S which will contain all the characters in T in complexity O(n).
        public string MinWindowNotMine(string s, string t)  //  FAST!!!  - LEARN THISS ONE!!!!!
        {
            if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(t))
            {
                return string.Empty;
            }

            var map = new int[128];
            //Array.Clear(map, 0, map.Length);
            foreach (var ch in t)
            {
                map[ch]++;
            }


            int j;
            int i; // the "tail" of current sub string. [j..i] makes a string "window".
            int start = -1; // the start position of the best sub string we found so far
            int min = int.MaxValue; // the length of the best sub string we found so far
            var total = t.Length;

            for (i = 0, j = 0; i < s.Length; i++)
            {
                if (map[s[i]]-- > 0)
                {
                    total--;
                }

                /*
                when "total" reduced to 0, we know we have found a candidate. we compare the candidate
                with the bast result we found so far. If the new candidate is better, update the "best".
                */
                while (total == 0)
                {
                    var length = i - j + 1;
                    if (length < min)
                    {
                        min = length;
                        start = j;
                    }

                    /*
                    Is the candidate we found a good one? In most cases it is not.
                    Let's say we have a template string:
                    "ABC" 
                    and a data string:
                    "XYZ..(other characters but none of them are 'A', 'B' or 'C')....ABC"
                    Based on the algorithm above, we start from j=0 and i=0. Keep moving i until we 
                    fond a candidate. In this case, the first one we found is the whole string. 
                    Is it a good one? Of cause it is not. The reason is that we have lot of "garbage" 
                    characters before we found the right pattern. In another words, we need to move 
                    variable "j" to right until we get rid of them. Then the question is: How do i 
                    know it is a "garbage" character? As we know, while variable moving from left to 
                    right, we reduce the corresponding value in map time to times. If it is a character
                    in template, it must be greater than 0. This could be a good indicator. However,
                    how about a sub string like below?
                    .....A.......XYZ............ABC......
                                 j                i
                    in this case, the first 'A' was used so the value in map is already -1. How do we
                    know the 'A' is in template? Of cause we can scan the template string but that is 
                    not a smart idea because it is slow. it is O(m * n).
                    So why don't we recover the value? Say, every time the "j" moves, we increase the 
                    corresponding value in map by 1. By doing so, the corresponding value in map will 
                    be restored to the original data: if a character is not in template string the 
                    value will be 0 otherwise it will be the number it appears in the template string.
                    What really means when a value in map change from 0 to 1? or even higher? That not
                    only means we found a character which in template string but also means we lost 
                    a required character from previous [j..i] windows. i.e, the candidate [j..i] 
                    changed to [j-1...i] and it is not valid any more because we kicked out a required
                    character. What we should do? Well, keep moving "i" to find next one.
                    */
                    if (++map[s[j++]] > 0)
                    {
                        total++;
                    }
                }
            }

            // We done. return the result if we found one
            return (min == int.MaxValue) ? string.Empty : s.Substring(start, min);
        }


        public IList<int> FindAnagrams2(string s, string p)
        {
            var results = new List<int>();
            if (s == null || s.Length == 0)
                return results;

            var charcounts = new int[26];
            var left = 0;
            var right = 0;
            var count = p.Length;

            for (var i = 0; i < p.Length; i++)
            {
                charcounts[p[i] - 'a']++;
            }

            while (right < s.Length)
            {

                if (charcounts[s[right++] - 'a']-- >= 1)
                    count--;

                if (count == 0)
                    results.Add(left);

                if (right - left == p.Length && charcounts[s[left++] - 'a']++ >= 0)
                    count++;

            }



            return results;
        }

        //too slow
        public IList<int> FindAnagrams(string s, string p)
        {
            var foundindexes = new List<int>();
            if (string.IsNullOrWhiteSpace(s) || s.Length < p.Length)
                return foundindexes;
            var len = s.Length;
            var left = 0;

            var count = p.Length;
            var right = 0;
            var foundchars = new StringBuilder(p);

            while (right < len)
            {


                var found = foundchars.ToString().IndexOf(s[right]);
                if (found > -1)
                {
                    foundchars = foundchars.Remove(found, 1);
                    if (foundchars.Length == 0)
                    {
                        foundindexes.Add(left);
                        left++;
                        right = left;
                        foundchars.Append(p);
                    }
                    else
                    {
                        right++;

                    }
                }
                else
                {
                    if (!p.Contains(s[right]))
                    {
                        left = right;
                        foundchars.Clear();
                        foundchars.Append(p);
                    }
                    else
                    {
                        left++;
                        right = left;
                    }

                }

            }
            return foundindexes;
        }


        public int RemoveDuplicates(int[] nums)
        {
            var uniques = nums.GroupBy(n => n).ToDictionary(n => n.Key, n => n.Count()).Select(n => n.Key);
            var dict = nums.GroupBy(n => n).ToDictionary(n => n.Key, n => n.Count());
            var len = uniques.Count();
            var i = 0;
            foreach (var u in uniques)
            {
                nums[i] = u;
                i++;
            }


            //for (var i = 0; i < nums.Length; i++)
            //{
            //    if (i == nums.Length-1)
            //    {
            //        uniques.Add(i);
            //    }
            //    else if (i < nums.Length -1 && nums[i] == nums[i + 1])
            //    {
            //        len--;
            //        uniques.Add(i);
            //      //  i++;
            //    }
            //    else
            //        uniques.Add(i);


            //}

            //var j = 0;
            //foreach(var unique in uniques)
            //{
            //    nums[j] = nums[unique];
            //    j++;
            //}

            return len;
        }




        public int MyAtoi2(String str)
        {
            int i = 0;
            int sign = 1;
            int result = 0;
            if (str.Length == 0) return 0;

            //Discard whitespaces in the beginning
            while (i < str.Length && str[i] == ' ')
                i++;

            // Check if optional sign if it exists
            if (i < str.Length && (str[i] == '+' || str[i] == '-'))
                sign = (str[i++] == '-') ? -1 : 1;

            // Build the result and check for overflow/underflow condition
            while (i < str.Length && str[i] >= '0' && str[i] <= '9')
            {
                if (result > int.MaxValue / 10 ||
                        (result == int.MaxValue / 10 && str[i] - '0' > int.MaxValue % 10))
                {
                    return (sign == 1) ? int.MaxValue : int.MinValue;
                }
                result = result * 10 + (str[i++] - '0');
            }
            return result * sign;
        }

        public int MyAtoi(string str)
        {
            var s = new Stack<char>();
            var numeric = false;
            var negative = false;
            var positive = false;

            try
            {

                for (var i = 0; i < str.Length; i++)
                {
                    if (str[i] >= '0' && str[i] <= '9')
                    {
                        if (!numeric && str[i] == '0' && i < str.Length - 1 && str[i + 1] < '0' && str[i + 1] > '9')
                            continue;
                        else
                        {
                            s.Push(str[i]);
                            numeric = true;
                        }
                    }
                    else if (str[i] != '-' && str[i] != '+' && str[i] != ' ')
                    {
                        if (numeric)
                            break;
                        else
                            return 0;
                    }

                    else if (str[i] == ' ')
                    {
                        if (numeric)
                            break;
                        else if (positive || negative)
                            return 0;

                    }
                    else if (str[i] == '+')
                    {

                        if (numeric)
                            break;
                        if (positive && !numeric)
                            return 0;
                        if (negative && !numeric)
                            return 0;
                        positive = true;
                    }
                    else if (str[i] == '-')
                    {
                        if (numeric)
                            break;
                        if (negative && !numeric)
                            return 0;
                        if (negative)
                            break;

                        if (positive && !numeric)
                            return 0;
                        negative = true;
                    }

                    else if (str[i] == '.')
                    {
                        break;
                    }
                }


                var outint = 0;
                var multiplier = 1;
                while (s.Count > 0)
                {
                    var test = checked(outint += ((s.Pop() - '0') * multiplier));
                    if (s.Count > 0)
                        test = checked(multiplier *= 10);
                }
                return negative ? outint * -1 : outint;

            }
            catch (OverflowException)
            {
                return negative ? int.MinValue : int.MaxValue;
            }

        }

        public int LengthOfLongestSubstring2(string s)
        {
            var set = new HashSet<char>();
            var left = 0;
            var right = 0;
            var length = 0;



            while (right < s.Length)
            {
                if (!set.Contains(s[right]))
                {
                    set.Add(s[right]);
                    length = Math.Max(length, set.Count);
                    right++;
                }
                else
                {
                    set.Remove(s[right]);
                    left++;
                }
            }

            return length;


        }

        public void ReorderList2(ListNode head)
        {
            if (head == null)
                return;
            var s = new Stack();
            var temp = head;
            var count = 0;
            while (temp != null)
            {
                s.Push(temp);
                temp = temp.next;
                count++;
            }

            temp = head.next;
            count--;
            while (count > 0)
            {
                head.next = s.Pop() as ListNode;
                head = head.next;
                count--;
                if (count == 0)
                    break;
                head.next = temp;
                head = head.next;
                temp = temp.next;
                count--;

            }
            head.next = null;
        }





        Dictionary<Node, Node> dict = new Dictionary<Node, Node>();

        public Node CopyRandomList(Node head)
        {
            if (head == null)
                return null;

            if (dict.ContainsKey(head))
            {
                return dict[head];
            }
            else
            {

                var node = new Node(head.val);
                dict.Add(head, node);

                node.next = CopyRandomList(head.next);
                node.random = CopyRandomList(head.random);
                return node;
            }
        }

        public static int[] TwoNumberSum(int[] array, int targetSum)
        {
            // Write your code here.
            var target = new List<int>();
            for (var i = 0; i < array.Length; i++)
            {
                for (var j = i + 1; j < array.Length; j++)
                {
                    if (i != j && array[i] + array[j] == targetSum)
                    {
                        var found = new int[] { array[i], array[j] };

                        return found;
                    }
                }
            }
            return new int[0];
        }

        public uint reverseBits2(uint n)
        {
            var nstr = Convert.ToString(n, 2).PadLeft(32, '0');
            var reversed = nstr.Reverse();
            var reverseduint = Convert.ToUInt32(new string(reversed.ToArray()), 2);
            return reverseduint;

        }

        public int[] CountBits2(int num)
        {

            var bits = new List<int>();
            for (var i = 0; i <= num; i++)
            {
                bits.Add(NumberOfSetBits(i));

            }
            return bits.ToArray();




        }



        int NumberOfSetBits(int i)
        {
            i = i - ((i >> 1) & 0x55555555);
            i = (i & 0x33333333) + ((i >> 2) & 0x33333333);
            return (((i + (i >> 4)) & 0x0F0F0F0F) * 0x01010101) >> 24;
        }









        public string RemoveOuterParentheses2(string S)
        {

            var count = 0;
            var start = 0;
            var newstring = new StringBuilder();
            for (var i = 0; i < S.Length; i++)
            {
                if (S[i] == '(')
                    count++;
                if (S[i] == ')')
                {
                    count--;
                    if (count == 0)
                    {
                        newstring.Append(S.Substring(start + 1, i - 1 - start));
                        start = i + 1;
                    }
                }
            }
            return newstring.ToString();
        }

        public ListNode AddTwoNumbers5(ListNode l1, ListNode l2)
        {
            var node = new ListNode(0);
            var head = node;
            var carry = 0;
            while (l1 != null || l2 != null || carry == 1)
            {
                var sum = (l1?.val ?? 0) + (l2?.val ?? 0) + carry;
                carry = sum / 10;
                sum %= 10;
                node.next = new ListNode(sum);
                node = node.next;
                //if (l1 != null)
                l1 = l1?.next;
                //if (l2 != null)
                l2 = l2?.next;


            }
            return head.next;

        }



      










        public int RomanToInt(string s)
        {
            var len = s.Length;
            var sum = 0;
            for (var i = 0; i < len; i++)
            {
                if (s[i] == 'I')
                {
                    if (i < len - 1 && s[i + 1] == 'V')
                    {
                        sum += 4;
                        i++;
                    }
                    else if (i < len - 1 && s[i + 1] == 'X')
                    {
                        sum += 9;
                        i++;
                    }
                    else
                    {
                        sum++;
                    }
                }

                else if (s[i] == 'X')
                {
                    if (i < len - 1 && s[i + 1] == 'L')
                    {
                        sum += 40;
                        i++;
                    }
                    else if (i < len - 1 && s[i + 1] == 'C')
                    {
                        sum += 90;
                        i++;
                    }
                    else
                    {
                        sum += 10;
                    }
                }


                else if (s[i] == 'C')
                {
                    if (i < len - 1 && s[i + 1] == 'D')
                    {
                        sum += 400;
                        i++;
                    }
                    else if (i < len - 1 && s[i + 1] == 'M')
                    {
                        sum += 900;
                        i++;
                    }
                    else
                    {
                        sum += 100;
                    }
                }

                else if (s[i] == 'V')
                {
                    sum += 5;
                }
                else if (s[i] == 'L')
                {
                    sum += 50;
                }
                else if (s[i] == 'D')
                {
                    sum += 500;
                }

                else if (s[i] == 'M')
                {
                    sum += 1000;
                }

            }
            return sum;
        }

        public int MissingElement(int[] nums, int k)
        {
            var count = 0;
            var missing = 0;



            for (var i = 0; count < k && i < nums.Length - 1; i++)
            {
                var diff = nums[i + 1] - nums[i];
                if (diff > 1)
                {
                    if (count + diff - 1 >= k)
                    {
                        missing = nums[i] + k - count;
                    }
                    count += diff - 1;

                }

            }

            if (count < k)
                missing = nums[nums.Length - 1] + k - count;


            return missing;
        }







        public int NetworkDelayTime(int[][] times, int N, int K)
        {



            if (times == null || times.Length == 0 || N == 0 || K > N || K < 1)
            {
                return -1;
            }

            int[] paths = new int[N + 1];
            int inf = 20000;
            Array.Fill(paths, inf);

            paths[K] = 0;

           // while (N-- > 1)
           // {
                foreach (int[] edge in times)
                {
                    int newTime = paths[edge[0]] + edge[2];
                    
                    if (newTime < paths[edge[1]])
                    {
                        paths[edge[1]] = newTime;
                    }
                }
           // }

            int result = -1;

            for (int i = 1; i < paths.Length; ++i)
            {
                if (paths[i] == inf)
                    return -1;

                result = Math.Max(result, paths[i]);
            }

            return result;
        }



        public int GetSum2(int a, int b)
        {
            if (b == 0)
                return a;
            return GetSum2(a ^ b, (a & b) << 1);
        }




        public int MaxSubArrayLen2(int[] nums, int k)
        {
            var sum = 0;
            var maxlen = 0;
            var dict = new Dictionary<int, int>() { { 0, -1 } };

            for (var i = 0; i < nums.Length; i++)
            {
                sum += nums[i];


                if (dict.ContainsKey(sum - k))
                    maxlen = Math.Max(maxlen, i - dict[sum - k]);

                if (!dict.ContainsKey(sum))
                    dict.Add(sum, i);

            }

            return maxlen;


        }


        Dictionary<int, int> largest = new Dictionary<int, int>();


        public IList<int> LargestValues(TreeNode root)
        {
            var largestlist = new List<int>();
            FindLargest(root, 1);
            return largest.Select(l => l.Value).ToList();
        }

        private void FindLargest(TreeNode root, int level)
        {

            if (root == null)
                return;

            if (!largest.ContainsKey(level))
                largest[level] = root.val;
            else if (root.val > largest[level])
                largest[level] = root.val;

            level++;
            FindLargest(root.left, level);
            FindLargest(root.right, level);

        }







        public string ReverseVowels(string s)
        {
            var sb = new StringBuilder(s);
            var reversed = s.ToList();
            var vowels = new char[] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            var left = 0;
            var right = s.Length - 1;


            while (left < right)
            {


                left = sb.ToString().IndexOfAny(vowels, left);
                if (left == -1)
                    break;
                //return new string(reversed.ToArray());
                right = sb.ToString().LastIndexOfAny(vowels, right);
                if (right == -1)
                    break; // return new string(reversed.ToArray());


                (reversed[left], reversed[right]) = (reversed[right], reversed[left]);
                sb[left] = ' ';
                sb[right] = ' ';
                left++;
                right--;

            }
            return new string(reversed.ToArray());

        }



        public int LeftMostColumnWithOne(int[][] binaryMatrix) // BinaryMatrix binaryMatrix)
        {
            //var dims = binaryMatrix.Dimensions();
            var rows = 2;// dims[0];
            var cols = 4; // dims[1];
            var pos = cols;

            for (var row = 0; row < rows; row++)
            {
                var low = 0;
                var high = cols - 1;
                while (low <= high)
                {
                    var mid = low + (high - low) / 2;
                    var midval = binaryMatrix[row][mid];
                    if (midval == 0)
                        low = mid + 1;
                    else
                        high = mid - 1;

                }
                pos = Math.Min(low, pos);

            }

            return pos == cols ? -1 : pos;


        }


        public int DaysBetweenDates(string date1, string date2)
        {
            var d1 = Convert.ToDateTime(date1);
            var d2 = Convert.ToDateTime(date2);

            //while (true)
            //{

            //}
            // ...


            return (d2 - d1).Days;
        }



        public int ClosestValue(TreeNode root, double target)
        {
            return FindClosest(root, target, root.val);
        }

        private int FindClosest(TreeNode root, double target, int closest)
        {
            if (root == null)
                return closest;



            if (Math.Abs(root.val - target) < Math.Abs(closest - target))
                closest = root.val;

            if (root.val > target)
                return FindClosest(root.left, target, closest);
            else return FindClosest(root.right, target, closest);

        }



        public string SimplifyPath(string path)
        {
            if (path.Length == 0)
                return path;
            var parts = path.Split('/', StringSplitOptions.RemoveEmptyEntries).ToList();



            var level = 0;
            for (var i = 0; i < parts.Count; i++)
            {
                if (parts[i] == "..")
                {
                    if (parts.Count > 0)
                    {
                        parts.RemoveAt(i);
                        i--;
                        if (parts.Count > 0 && i >= 0)
                        {
                            parts.RemoveAt(i);
                            i--;
                        }

                    }
                    else
                        level++;
                }
                else if (parts[i] == ".")
                {
                    parts.RemoveAt(i);
                    i--;
                }



            }


            var outpath = "/" + String.Join("/", parts);
            return outpath;

        }


        public int[] NextGreaterElement(int[] nums1, int[] nums2)
        {

            var result = new int[nums1.Length];
            for (var i = 0; i < nums1.Length; i++)
            {
                var foundindex = Array.IndexOf(nums2, nums1[i]);
                {
                    if (foundindex == nums2.Length - 1)
                        result[i] = -1;
                    else
                    {
                        var foundnextindex = Array.FindIndex(nums2, foundindex, n => n > nums1[i]);
                        result[i] = foundnextindex == -1 ? -1 : nums2[foundnextindex];
                    }

                }
            }
            return result;
        }


        public int[] NextGreaterElement2(int[] nums1, int[] nums2)
        {

            var a = Array.FindIndex(nums2, 3, a => a > 2);
            // var a = nums2.Where(n => n > 4).First();

            if (nums1 == null || nums1.Length == 0)
                return new int[] { };
            var outarray = new int[nums1.Length];
            var l2 = nums2.ToList();
            for (var i = 0; i < nums1.Length; i++)
            {
                var num = l2.IndexOf(nums1[i]);
                if (num < 0)
                    outarray[i] = -1;
                else
                {
                    var value = l2.Skip(num + 1).Where(n => n > nums1[i]).FirstOrDefault();
                    if (value > nums1[i])
                        outarray[i] = value;
                    else
                        outarray[i] = -1;
                }
            }
            return outarray;
        }







        public IList<int> ArraysIntersection(int[] arr1, int[] arr2, int[] arr3)
        {
            var maxlen = Math.Max(Math.Max(arr1.Length, arr2.Length), arr3.Length);

            var dict1 = arr1.ToDictionary(v => v, v => 1); // new Dictionary<int, int>();
            var dict2 = new Dictionary<int, int>();
            var dict3 = new Dictionary<int, int>();

            for (var i = 0; i < maxlen; i++)
            {
                if (i < arr1.Length && !dict1.ContainsKey(arr1[i]))
                {
                    dict1.Add(arr1[i], 1);
                }


                if (i < arr2.Length && !dict2.ContainsKey(arr2[i]))
                {
                    dict2.Add(arr2[i], 1);
                }

                if (i < arr3.Length && !dict3.ContainsKey(arr3[i]))
                {
                    dict3.Add(arr3[i], 1);
                }
            }


            var merged = dict1.Concat(dict2).Concat(dict3).GroupBy(d => d.Key)
                .ToDictionary(d => d.Key, d => d.Count()).Where(d => d.Value >= 3)
                .Select(d => d.Key).ToList();

            return merged;




        }



        public ListNode AddTwoNumbers4(ListNode l1, ListNode l2)
        {

            ListNode dummy = new ListNode(0), curr = dummy;
            while (l1 != null || l2 != null || dummy.val != 0)
            { // use dummy.val as carry ;)
                int sum = (l1?.val ?? 0) + (l2?.val ?? 0) + dummy.val;
                dummy.val = sum / 10;
                curr = curr.next = new ListNode(sum % 10);
                l1 = l1.next;
                l2 = l2.next;
            }

            return dummy.next;


        }




        public ListNode AddTwoNumbers3(ListNode l1, ListNode l2)
        {
            if (l1 == null)
                return l2;
            if (l2 == null)
                return l1;
            var head = new ListNode(0);
            var node = head;
            var s1 = ListToStack(l1);
            var s2 = ListToStack(l2);
            var carry = 0;
            while (s1 != null || s2 != null || carry == 1)
            {
                var sum1 = s1.Count > 0 ? s1.Pop() : 0;
                var sum2 = s2.Count > 0 ? s2.Pop() : 0;
                var sum = sum1 + sum2 + carry;
                carry = sum / 10;
                sum %= 10;

                node.next = new ListNode(sum);
                node = node.next;
            }
            return head.next;
        }




        public int MaxSubArrayLen(int[] nums, int k)
        {

            int sum = 0, maxlen = 0;
            Dictionary<int, int> dic = new Dictionary<int, int>() { { 0, -1 } };

            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];

                if (dic.ContainsKey(sum - k))
                    maxlen = Math.Max(maxlen, i - dic[sum - k]);

                if (!dic.ContainsKey(sum))
                    dic.Add(sum, i);
            }

            return maxlen;

        }



        //    {
        //    if (nums == null || nums.Length == 0) return 0;
        //    var i = 0;
        //    var j = nums.Length - 1;
        //    var count = 0;
        //  while (i<j)
        //  {
        //      var total = 0;
        //      for (var index = i; index <=j; index++)
        //      {
        //          total += nums[index];
        //      }

        //      if (total == k)
        //          return j - i + 1;
        //      else if (total > k)
        //          j--;
        //  }
        //    return 0;

        //}



        public ListNode MergeTwoLists2(ListNode l1, ListNode l2)
        {
            var head = new ListNode(0);
            ListNode node = head;

            while (l1 != null && l2 != null)
            {
                if (l1.val <= l2.val)
                {
                    node.next = l1;
                    node = node.next;
                    l1 = l1.next;
                }
                else
                {
                    node.next = l2;
                    node = node.next;
                    l2 = l2.next;
                }
                if (l1 != null) node.next = l1;
                if (l2 != null) node.next = l2;

            }
            return head.next;
        }



        public int[] SortedSquares(int[] A)
        {
            var outarray = new int[A.Length];
            for (var i = 0; i < A.Length; i++)
            {
                outarray[i] = A[i] * A[i];
            }
            Array.Sort(outarray);
            return outarray;
        }

        public string CustomSortString(string S, string T)
        {
            var tlist = T.ToList();
            var resultstr = "";
           
            for (var i = 0; i < S.Length; i++)
            {
                while (tlist.Contains(S[i]))
                {
                    resultstr += S[i];
                    tlist.Remove(S[i]);
                }
            }
            resultstr += new string(tlist.ToArray());
            return resultstr;
        }




        public int[] ProductExceptSelf(int[] nums)
        {
            var len = nums.Length;
            var outarray = new int[len];
            Array.Fill(outarray, 1);

            var product = 1;
            for (var i = 0; i < len - 1; i++)
            {
                product = product * nums[i];
                outarray[i + 1] = product * outarray[i + 1];
            }
            product = 1;
            for (var i = len - 1; i > 0; i--)
            {
                product *= nums[i];
                outarray[i - 1] = product * outarray[i - 1];
            }


            return outarray;
        }





        public int MaxProfit(int[] prices)
        {
            if (prices.Length <= 1)
                return 0;
            var buy = int.MaxValue;
            var sell = 0; // prices[prices.Length - 1];
                          //if (prices.Length == 2)
                          //{
                          //    return (sell - buy) < 0 ? 0 : (sell - buy);
                          //}

            // var i = 
            // var j = prices.Length - 2;



            for (var i = 0; i < prices.Length; i++)
            {
                if (prices[i] < buy)
                {
                    buy = prices[i];
                }
                else
                {
                    sell = Math.Max(sell, prices[i] - buy);
                }

            }



            //while (i <= j)
            //{
            //    if (prices[i] < buy)
            //    {
            //        buy = prices[i];
            //    }
            //    if (prices[j] > sell)
            //    {
            //        sell = prices[j];
            //    }
            //    i++;
            //    j--;
            //}
            return sell; // (sell - buy) < 0 ? 0 : sell - buy;
        }








        public int MinTimeToVisitAllPoints(int[][] points)
        {
            //points.Zip(points.Skip(1), (a, b) => Math.Max(Math.Abs(a[0] - b[0]), Math.Abs(a[1] - b[1]))).Sum();

            var a = points.Zip(points.Skip(1), (a, b) => a[0] + "--" + a[1]); // Math.Max(Math.Abs(a[0] - b[0]), Math.Abs(a[1] - b[1])));

            //.Sum();
            return 1;
            //return a.Sum();

        }

        public string RestoreString(string s, int[] indices)
        {
            var newstring = new StringBuilder();
            for (var i = 0; i < s.Length; i++)
            {
                newstring.Append(s[Array.IndexOf(indices, i)]);
            }
            return newstring.ToString();
        }





       



        //public void TestIcomparable()
        //{
        //    var vals1 = new List<ChrisCustom>() { new ChrisCustom(1), 2 };
        //    var test1 = vals1.OrderBy(l => l);
        //    var test2 = 1;
        //}



        public ListNode AddTwoNumbers10(ListNode l1, ListNode l2)
        {
            Stack<int> stack1 = ListToStack(l1);
            Stack<int> stack2 = ListToStack(l2);

            ListNode head = null;
            int carry = 0;
            while (stack1.Count > 0 || stack2.Count > 0 || carry > 0)
            {
                int val1 = stack1.Count > 0 ? stack1.Pop() : 0;
                int val2 = stack2.Count > 0 ? stack2.Pop() : 0;
                int val = val1 + val2 + carry;
                carry = val / 10;
                val = val % 10;
                ListNode node = new ListNode(val);
                node.next = head;
                head = node;
            }

            return head == null ? new ListNode(0) : head;
        }

        public Stack<int> ListToStack2(ListNode node)
        {
            Stack<int> stack = new Stack<int>();
            while (node != null)
            {
                stack.Push(node.val);
                node = node.next;
            }
            return stack;
        }















        public ListNode AddTwoNumbers1(ListNode l1, ListNode l2)
        {
            var s1 = new Stack<int>();
            var s2 = new Stack<int>();
            while (l1 != null || l2 != null)
            {
                if (l1 != null)
                {
                    s1.Push(l1.val);
                    l1 = l1.next;
                }
                if (l2 != null)
                {
                    s2.Push(l2.val);
                    l2 = l2.next;
                }

            }

            var carry = 0;
            var sum = 0;
            var sumlist = new List<int>();
            while (s1.Count > 0 && s2.Count > 0)
            {
                sum = s1.Pop() + s2.Pop() + carry;
                carry = sum > 9 ? 1 : 0;
                sum = sum > 9 ? sum % 10 : sum;

                sumlist.Add(sum);



            }

            while (s1.Count > 0)
            {
                sum = s1.Pop() + carry;
                carry = sum > 9 ? 1 : 0;
                sum = sum > 9 ? sum % 10 : sum;
                sumlist.Add(sum);

            }
            while (s2.Count > 0)
            {
                sum = s2.Pop() + carry;
                carry = sum > 9 ? 1 : 0;
                sum = sum > 9 ? sum % 10 : sum;
                sumlist.Add(sum);
            }

            if (carry > 0)
                sumlist.Add(carry);
            sumlist.Reverse();
            var newlist = new ListNode(sumlist[0]);
            var head = newlist;
            for (var i = 1; i < sumlist.Count; i++)
            {
                newlist.next = new ListNode(sumlist[i]);
                newlist = newlist.next;
            }
            return head;
        }



        public int LengthOfLongestSubstring(string s)
        {
            var set = new HashSet<char>();
            var count = 0;
            var left = 0;
            var right = 0;

            while (right < s.Length)
            {
                if (!set.Contains(s[right]))
                {
                    set.Add(s[right]);
                    right++;
                    count = Math.Max(count, right - left);

                }
                else
                {
                    set.Remove(s[left]);
                    left++;
                }

            }
            return count;
        }




        public void ReorderList(ListNode head)
        {

            var newlist = head;
            var nodelist = new List<ListNode>();
            var count = 0;

            while (newlist != null)
            {
                count++;
                nodelist.Add(newlist);
                newlist = newlist.next;

            }
            if (count <= 2)
                return;

            var left = 1;
            var right = nodelist.Count - 2;

            newlist = nodelist[0];
            newlist.next = nodelist[count - 1];
            newlist = newlist.next;

            while (left <= right)
            {
                newlist.next = nodelist[left];
                newlist = newlist.next;
                if (left < right)
                {
                    newlist.next = nodelist[right];
                    newlist = newlist.next;
                }
                left++;
                right--;
            }
            newlist.next = null;

        }


        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            if (head == null)
                return head;

            var count = 0;
            var firstpass = head;
            while (firstpass != null)
            {
                count++;
                firstpass = firstpass.next;
            }
            firstpass = head;
            if (count == n)
                return head.next;
            count = count - n;
            if (count == 0 && n == 0)
                return null;
            while (count > 1)
            {
                count--;
                firstpass = firstpass.next;
            }


            firstpass.next = firstpass.next.next;
            return head;



        }

        public ListNode MergeKLists(ListNode[] lists)
        {
            if (lists.Count() == 0)
                return null;
            if (lists.Count() == 1)
                return lists[0];
            var newlist = MergeTwoLists(lists[0], lists[1]); //   ListNode(-99999);
            for (var i = 2; i < lists.Length; i++)
            {

                newlist = MergeTwoLists(newlist, lists[i]);
            }
            return newlist.next;
        }



        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 == null)
                return l2;
            if (l2 == null)
                return l1;

            var newlist = new ListNode(0);
            var p = newlist;

            while (l1 != null && l2 != null)
            {
                if (l1.val >= l2.val)
                {
                    p.next = l2;
                    l2 = l2.next;
                }
                else
                {
                    p.next = l1;
                    l1 = l1.next;
                }
                p = p.next;
            }


            if (l1 != null)
            {
                p.next = l1;
            }
            if (l2 != null)
            {
                p.next = l2;
            }

            return newlist.next;

        }




        public ListNode MergeTwoListsTOOSLOW(ListNode l1, ListNode l2)
        {
            ListNode newlist; // = l1.val;
            if (l1.val <= l2.val)
            {
                newlist = new ListNode(l1.val);
                newlist.next = new ListNode(l2.val);
            }
            else
            {
                newlist = new ListNode(l2.val);
                newlist.next = new ListNode(l1.val);
            }
            newlist = newlist.next;
            l1 = l1.next;
            l2 = l2.next;

            while (l1 != null & l2 != null)
            {
                if (l1.val <= l2.val)
                {
                    newlist = new ListNode(l1.val);
                    newlist.next = new ListNode(l2.val);
                }
                else
                {
                    newlist = new ListNode(l2.val);
                    newlist.next = new ListNode(l1.val);
                }
            }
            return newlist;
        }



        public bool HasCycle2Pointer(ListNode head)
        {
            if (head == null)
                return false;
            var fast = head.next;
            var slow = head;
            while (fast != slow)
            {
                if (fast == null || fast.next == null)
                    return false;
                slow = slow.next;
                fast = fast.next.next;
            }
            return true;
        }




        public bool HasCycle(ListNode head)
        {
            var nodes = new Dictionary<ListNode, int>();
            while (head != null)
            {
                if (nodes.ContainsKey(head))
                    return true;
                nodes.Add(head, 1);

                head = head.next;

            }
            return false;
        }



        public bool IsAlienSorted(string[] words, string order)
        {


            for (var i = 0; i < words.Length-1; i++)
                for (var j = i + 1; j < words.Length; j++)
                {
                    var min = Math.Min(words[i].Length, words[j].Length);

                    for (var k = 0; k < min; k++)
                    {
                        if (order.IndexOf(words[i][k]) < order.IndexOf(words[j][k]))
                        {
                            break;
                        }
                        else if (order.IndexOf(words[i][k]) > order.IndexOf(words[j][k]))
                        {
                            return false;
                        }
                        else if (k == min - 1 && words[i].Length > words[j].Length)
                        {
                            return false;
                        }

                    }
                }
            return true;

        }



        public int LengthOfLIS(int[] nums)
        {
            int[] tail = new int[nums.Length];
            int size = 0;
            foreach (int num in nums)
            {
                int i = Array.BinarySearch(tail, 0, size, num);
                if (i < 0) i = -i - 1;
                tail[i] = num;
                if (i == size) size++;
            }
            return size;
        }

        //int minCoins = int.MaxValue;
        //public int CoinChange(int[] coins, int amount)
        //{
        //    if (amount < 0 || coins.Length == 0) return -1;
        //    int coinIndex = coins.Length - 1;
        //    int curCoins = 0;
        //    Array.Sort(coins);
        //    CoinChanges(coins, amount, coinIndex, curCoins);

        //    return minCoins == int.MaxValue ? -1 : minCoins;
        //}

        //public void CoinChanges(int[] coins, int amount, int coinIndex, int curCoins)
        //{
        //    if (coinIndex < 0 || curCoins > minCoins) return;
        //    int c = amount / coins[coinIndex];
        //    for (int i = c; i >= 0; i--)
        //    {
        //        int newCount = curCoins + i;
        //        int remaining = amount - i * coins[coinIndex];
        //        if (remaining == 0) minCoins = Math.Min(minCoins, newCount);
        //        else
        //        {
        //            if (remaining > 0 && minCoins > newCount && coinIndex > 0)
        //            {
        //                CoinChanges(coins, remaining, coinIndex - 1, newCount);
        //            }
        //            else
        //            {
        //                break;
        //            }
        //        }
        //    }
        //}



        public int CoinChange(int[] coins, int amount)
        {
            Array.Sort(coins);
            var dp = new int[amount + 1];
            Array.Fill(dp, amount + 1);
            dp[0] = 0;
            for (var i = 1; i <= amount; i++)
            {
                for (var j = 0; j < coins.Length; j++)
                {
                    if (coins[j] <= i)
                    {
                        dp[i] = Math.Min(dp[i], 1 + dp[i - coins[j]]);
                    }
                    else
                        break;
                }
            }

            return dp[amount] > amount ? -1 : dp[amount];

        }



        public int ClimbStairs1(int n)
        {
            var memo = new int[n + 1];
            return climb_Stairs(0, n, memo);
        }
        public int climb_Stairs(int i, int n, int[] memo)
        {
            if (i > n)
            {
                return 0;
            }
            if (i == n)
            {
                return 1;
            }
            if (memo[i] > 0)
            {
                return memo[i];
            }
            memo[i] = climb_Stairs(i + 1, n, memo) + climb_Stairs(i + 2, n, memo);
            return memo[i];


        }


        //Works, but way too slow
        //public int ClimbStairs(int n)
        //{
        //    if (n == 0)
        //        return 0;
        //    else if (n == 1)
        //        return 1;
        //    else if (n == 2)
        //        return 2;
        //    else
        //        return ClimbStairs(n - 1) + ClimbStairs(n - 2);
        //}

        //recursion
        public int ClimbStairs3(int n)
        {

            if (n <= 3)
                return n;
            else
            {
                var nm1 = ClimbStairs3(n - 1);
                var nm2 = ClimbStairs3(n - 2);
                return nm1 + nm2;
            }
        }

        public int ClimbStairs(int n)
        {
            return calcstairs(n, new Dictionary<int, int>());


        }




        private int calcstairs(int remaining, Dictionary<int, int> calculated)
        {
            if (remaining < 0)
                return 0;
            else if (remaining == 0)
            {
                return 1;
            }

            else if (calculated.ContainsKey(remaining))
                return calculated[remaining];
            else
            {
                calculated.Add(remaining, calcstairs(remaining - 1, calculated)
                     + calcstairs(remaining - 2, calculated));
                return calculated[remaining];
            }


        }



        public ListNode ReverseList(ListNode head)
        {
            ListNode prev = null;

          //  ListNode curr; // = null;
            while (head != null)

              (head.next,prev,head) = (prev,head,head.next); // TUPLE solution!!!

            //{
            //    curr = head.next;
            //    head.next = prev;
            //    prev = head;
            //    head = curr; // head.next;

            //}
            return prev;
        }



        public void MSInterviewsort012(int[] a)
        {

            int lo = 0;
            int hi = a.Length - 1;
            int mid = 0;
            int temp = 0;

            while (mid <= hi)
            {
                switch (a[mid])
                {
                    case 0:
                        {
                            temp = a[lo];
                            a[lo] = a[mid];
                            a[mid] = temp;
                            lo++;
                            mid++;
                            break;

                        }
                    case 1:
                        {
                            mid++;
                            break;
                        }

                    case 2:
                        {
                            temp = a[mid];
                            a[mid] = a[hi];
                            a[hi] = temp;
                            hi--;
                            break;
                        }
                }
            }
        }

        public bool IsPalindrome2(int x)
        {

            if (x < 0)
                return false;
            if (x == 0)
                return true;
            var numbers = new List<int>();

            numbers.Add(x % 10);
            var cur = x / 10;

            while (cur > 0)
            {
                numbers.Add(cur % 10);
                cur /= 10;
            }

            var l = 0;
            var r = numbers.Count() - 1;
            while (l < r)
            {
                if (numbers[l] != numbers[r])
                    return false;
                l++;
                r--;
            }
            return true;
        }

        public bool IsPalindrome(string s)
        {
            //  s = Regex.Replace(s, "^[\\p{L}]+$", ""); // "[^a-zA-Z -]", "");
            s = new string(s.Where(Char.IsLetterOrDigit).ToArray());


            if (s.Length <= 1)
                return true;


            var start = 0;
            var end = s.Length - 1;
            while (start < end)
            {
                if (Char.ToLower(s[start]) != Char.ToLower(s[end]))
                    return false;
                start++;
                end--;
            }
            return true;
        }


        public uint reverseBits(uint n)
        {
            //var r = Convert.ToString(n, 2).PadLeft(32,'0');
            //var s = r.Reverse().ToArray();
            //var t = new String(s);
            // var u = Convert.ToUInt32(t, 2);
            // return u;

            //bitwise
            //int reversed = 0;
            //for (int i = 0; i < 32; i++)
            //{

            //    uint r = 0;
            //    r <<= 1;
            //    var temp = (n & (1 << i));
            //    var temp2 = 1 << (32 - 1 - i);
            //    reversed |= (n & (1 << i)) != 0 ? 1 << (32 - 1 - i) : 0;
            //}
            //return (uint)reversed;

            uint reversed = 0;
            for (int i = 0; i < 4; i++)
            {
                reversed = reversed << 1 | (n & 1);
                n >>= 1;


            }
            return reversed;
        }

        //1 to n
        //0 to n is len * (len+1) / 2;
        public int MissingNumber(int[] nums)
        {
            var len = nums.Length;
            var sum = (len + 1) * len / 2;
            for (var i = 0; i < nums.Length; i++)
            {
                sum -= nums[i];
            }
            return sum;

        }

        public int[] CountBits(int num)
        {
            var bitcounts = new int[num + 1];
            for (var i = 0; i <= num; i++)
            {
                bitcounts[i] = Convert.ToString(i, 2).Replace("0", "").Length;
            }
            return bitcounts;
        }

        public int HammingWeight2(uint n)
        {
            var nstr = Convert.ToString(n, 2);
            var count = nstr.Where(n => n == '1').Count();
            return count;
        }


        //  uint numberbits = 0;
        public int HammingWeight(uint n)
        {
            //non recursive loop.  and to get number bits on lsb thenshift right and repeat.
            //while (n != 0)
            //{
            //    numberbits += n & 1;
            //    n >>= 1;

            //}
            //return Convert.ToInt32(numberbits);


            //recursion1
            //if (n == 0)
            //    return 0; // Convert.ToInt32(numberbits);
            //else
            //{
            //    var numberbits = n & 1;
            //    return (int)numberbits +  HammingWeight( n >> 1);
            //}

            //recursion2

            if (n == 1)
            {
                return (int)n;
            }
            if (n == 0)
            {
                return 0;
            }
            var lg = (uint)(Math.Log(n) / Math.Log(2));
            return 1 + HammingWeight((uint)(n - Math.Pow(2, lg)));

            //converttostring
            //return Convert.ToString(n, 2).Replace("0", "").Length;



        }

        public int GetSum(int a, int b)
        {
            //var list = new List<int>() { a, b };
            //var sum = list.Sum();
            //return sum;
            //if (b == 0)
            //    return a;
            //else
            //{ 
            //    var c = GetSum(a ^ b, (a & b) << 1);
            //    return c;
            //}
            while (b != 0)
            {
                var carry = a & b;
                a = a ^ b;
                b = carry << 1;
            }
            return a;

        }

        public int MaxArea(int[] height)
        {
            var left = 0;
            var right = height.Length - 1;
            var totalarea = 0;
            while (left < right)
            {
                var area = (height[left] < height[right] ? height[left] : height[right]) * (right - left);
                if (height[left] < height[right])
                    left++;
                else
                    right--;

                totalarea = Math.Max(area, totalarea);
            }
            return totalarea;
        }



        public IList<IList<int>> ThreeSum3(int[] nums)
        {
            Array.Sort(nums);
            var sums3 = new List<IList<int>>();
            var dict = nums.GroupBy(n => n).ToDictionary(n => n.Key, n => n.Count());
            var left = 0;
            var right = 0;
            var value = 0;


            for (var i = 0; i < nums.Length - 2; i++)
            {
                left = i + 1;
                right = nums.Length - 1;
                while (left < right)
                {
                    value = -nums[i];
                    if (nums[left] + nums[right] > value)
                    {
                        right--;
                    }
                    else if (nums[left] + nums[right] < value)
                    {
                        left++;
                    }

                    else
                    {
                        sums3.Add(new List<int>() { nums[i], nums[left], nums[right] });

                        while (left < right && nums[left] == nums[left + 1]) left++;
                        while (left < right && nums[right] == nums[right - 1]) right--;
                        left++;
                        right--;
                    }

                }

                while (i < nums.Length - 2 && nums[i] == nums[i + 1]) i++;
            }
            return sums3;

        }


        public IList<IList<int>> oldThreeSum(int[] nums)
        {
            Array.Sort(nums);
            IList<IList<int>> lists = new List<IList<int>>();

            for (int i = 0; i < nums.Length - 2; i++)
            {
                int left = i + 1;
                int right = nums.Length - 1;
                while (left < right)
                {
                    if (nums[i] == 0 - nums[left] - nums[right])
                    {
                        lists.Add(new List<int>() { nums[i], nums[left], nums[right]
    });

                        // skip dupes
                        while (left < right && nums[left] == nums[left + 1]) left++;
                        while (left < right && nums[right] == nums[right - 1]) right--;

                        left++;
                        right--;

                    }
                    else if (nums[i] < 0 - nums[left] - nums[right])
                    {
                        left++;
                    }
                    else
                    {
                        right--;
                    }
                }

                // skip dupes
                while (i < nums.Length - 1 && nums[i] == nums[i + 1]) i++;
            }

            return lists;
        }





        public IList<IList<int>> ThreeSum(int[] nums)
        {
            Array.Sort(nums);
            var threesums = new List<IList<int>>();
            var len = nums.Length;
            for (var i = 0; i < len - 2; i++)
            {
                var left = i + 1;
                var right = len - 1;
                while (left < right)
                {
                   // var val = -nums[i];
                    //if (nums[left] + nums[right] > val)
                   //     right--;
                  //  else if (nums[left] + nums[right] < val)
                  //      left++;

                    if (nums[i] + nums[left] + nums[right] > 0)
                        right--;
                    else if (nums[i] + nums[left] + nums[right] < 0)
                        left++;
                    else
                    {
                        threesums.Add(new List<int>() { nums[i], nums[left], nums[right] });

                        while (left < right && nums[left] == nums[left + 1]) left++;
                        while (left < right && nums[right] == nums[right - 1]) right--;
                        left++;
                        right--;
                    }
                }
                while (i < len - 1 && nums[i] == nums[i + 1])
                    i++;
            }
            return threesums;
        }

        public int Search(int[] nums, int target)
        {
            var found = Array.IndexOf(nums, target);
            return found;

        }

        public int FindMin(int[] nums)
        {
            for (var i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i + 1] < nums[i])
                {
                    return nums[i + 1];
                }
            }
            return 0;
        }


        public int MaxProduct(int[] nums)
        {
            var maxproduct = nums[0];
            var product = 1;

            for (var i = 0; i < nums.Length; i++)
            {
                product *= nums[i];
                if (product > maxproduct)
                    maxproduct = product;
                if (product == 0)
                    product = 1;
            }

            product = 1;
            for (var i = nums.Length - 1; i >= 0; i--)
            {
                product *= nums[i];
                if (product > maxproduct)
                    maxproduct = product;
                if (product == 0)
                    product = 1;
            }

            return maxproduct;
        }


        //Maximum Subarray
        //Given an integer array nums, find the contiguous subarray(containing at least one number) which has the largest sum and return its sum.
        public int MaxSubArray(int[] nums)
        {
            var sum = nums[0];
            var maxsum = nums[0];

            for (var i = 1; i < nums.Length; i++)
            {
                sum = sum + nums[i] > nums[i] ? sum + nums[i] : nums[i];
                maxsum = sum > maxsum ? sum : maxsum;
            }
            return maxsum;

        }


        public int[] ProductExceptSelf2(int[] nums)
        {
            var outarray = new int[nums.Length];
            Array.Fill(outarray, 1);
            var product = 1;
            for (var i = 0; i < nums.Length - 1; i++)
            {
                product *= nums[i];
                outarray[i + 1] = product * outarray[i + 1];
            }
            product = 1;
            for (var i = nums.Length - 1; i > 0; i--)
            {
                product *= nums[i];
                outarray[i - 1] = product * outarray[i - 1];
            }
            return outarray;
        }



        public bool ContainsDuplicate(int[] nums)
        {

            return nums.Distinct().Count() < nums.Length;

            //var dict = new Dictionary<int, int>();
            //for (var i = 0; i < nums.Length; i++)
            //{
            //    if (dict.ContainsKey(nums[i]))
            //    {
            //        return true;
            //    }
            //    else
            //    {
            //        dict.Add(nums[i], 1);
            //    }
            //}
            //return false;

        }



        public int[] TwoSum2(int[] nums, int target)
        {
            var start = 1;
            for (var i = 0; i < nums.Length; i++)
            {
                for (var j = start; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
                start++;
            }
            return null;
        }



        public IList<string> CommonChars(string[] A)
        {
            var commonchars = new List<string>();

            var commonchar = false;
            for (var j = 0; j < A[0].Length; j++)
            {

                for (var i = 1; i < A.Length; i++)
                {


                    if (A[i].Contains(A[0][j]))
                    {
                        commonchar = true;
                        var index = A[i].IndexOf(A[0][j]);
                        A[i] = A[i].Remove(index, 1);

                    }
                    else
                    {
                        commonchar = false;
                        break;
                    }
                }
                if (commonchar)
                {
                    commonchars.Add(A[0][j].ToString());
                }
            }
            return commonchars;
        }





        public int[] RelativeSortArray2(int[] arr1, int[] arr2)
        {
            var arr1list = arr1.ToList();
            var newarray = new List<int>();
            for (var i = 0; i < arr2.Length; i++)
            {
                while (arr1list.Contains(arr2[i]))
                {
                    newarray.Add(arr2[i]);
                    arr1list.Remove(arr2[i]);
                }
            }

            if (arr1list.Count > 0)
            {
                arr1list.Sort();
                newarray.AddRange(arr1list);
            }
            return newarray.ToArray();
        }



        public int SumOfLeftLeaves(TreeNode root)
        {
            if (root == null)
                return 0;

            if (root.left != null && root.left.left == null && root.left.right == null)
                return root.left.val + SumOfLeftLeaves(root.left) + SumOfLeftLeaves(root.right);
            else
                return SumOfLeftLeaves(root.left) + SumOfLeftLeaves(root.right);
        }



        public string ciperSolution(string word, string cipher)
        {
            var len = word.Length;
            if (len < 26)
                return "";

            var outstring = new StringBuilder();

            for (var i = 0; i < len; i++)
            {
                var index = char.ToUpper(word[i]) - 64;
                if (index < 0 || index > cipher.Length)
                    return "";
                var a = cipher[index - 1];
                outstring.Append(a);
            }

            return outstring.ToString();
        }






    }




    class PeekingIterator
    {


        List<int> list = new List<int>();


        // iterators refers to the first element of the array.
        public PeekingIterator(List<int> iterator) // IEnumerator<int> iterator)
        {

            list.AddRange(iterator);

        }

        // Returns the next element in the iteration without advancing the iterator.
        public int Peek()
        {
            return list[0];
        }

        // Returns the next element in the iteration and advances the iterator.
        public int Next()
        {
            if (list.Count > 0)
            {
                var val = list[0];
                list.RemoveAt(0);
                return val;
            }
            else
                return 0;
        }

        // Returns false if the iterator is refering to the end of the array of true otherwise.
        public bool HasNext()
        {
            if (list.Count > 0)
                return true;
            else
                return false;
        }
    }



    public class MyStack
    {

        Queue q1;
        Queue q2;

        public MyStack()
        {
            q1 = new Queue();
            q2 = new Queue();
        }


        public void Push(int x)
        {
            while (q1.Count > 0)
            {
                var item = q1.Dequeue();
                q2.Enqueue(item);
            }
            q1.Enqueue(x);
        }

        public int Peek()
        {
            return Convert.ToInt32(q1.Peek());
        }


        public int Pop()
        {
            var item = Convert.ToInt32(q1.Dequeue());
            while (q2.Count > 0)
            {
                var q2item = q2.Dequeue();
                q1.Enqueue(q2item);
            }

            while (q1.Count > 1)
            {
                var q1item = q1.Dequeue();
                q2.Enqueue(q1item);
            }



            return item;
        }




    }



    public class MyQueue
    {

        Stack<int> s1;
        Stack<int> s2;

        /** Initialize your data structure here. */
        public MyQueue()
        {
            s1 = new Stack<int>();
            s2 = new Stack<int>();
        }

        /** Push element x to the back of queue. */
        public void Push(int x)
        {
            while (s2.Count > 0)
            {
                var e = s2.Pop();
                s1.Push(e);
            }
            s2.Push(x);
            while (s1.Count > 0)
            {
                s2.Push(s1.Pop());
            }
        }

        /** Removes the element from in front of queue and returns that element. */
        public int Pop()
        {
            return s2.Pop();
        }

        /** Get the front element. */
        public int Peek()
        {
            return s2.Peek();
        }

        /** Returns whether the queue is empty. */
        public bool Empty()
        {
            return s2.Count == 0;
        }
    }


    class MyStack2
    {

        Queue<int> q1 = new Queue<int>();

        internal void Push(int val)
        {
            var q2 = new Queue<int>();
            while (q1.Count > 0)
            {
                q2.Enqueue(q1.Dequeue());
            }
            q1.Enqueue(val);
            while (q2.Count > 0)
            {
                q1.Enqueue(q2.Dequeue());
            }


        }

        internal int Pop()
        {
            return q1.Dequeue();
        }

        internal int Peek()
        {
            return q1.Peek();
        }

        internal bool IsEmpty()
        {
            return q1.Count == 0;
        }


    }




    class TrieNode
    {
        public Dictionary<char, TrieNode> children = new Dictionary<char, TrieNode>();
        public string word = null;
        public TrieNode() { }
    }








    public class MyCircularQueueListNode
    {
        ListNode front;
        ListNode rear;

        int capacity;
        int count = 0;

        public MyCircularQueueListNode(int k)
        {
            rear = new ListNode(-1);
            front = rear;
            capacity = k;
        }

        public bool EnQueue(int value)
        {
            if (count == capacity)
                return false;
            if (rear.val == -1)
                rear.val = value;
            else
            {
                rear.next = new ListNode(value);
                rear = rear.next;
                count++;
            }
            count++;

            return true;
        }

        public bool DeQueue()
        {
            if (count == 0)
                return false;
            if (count == 1)
            {
                front.val = -1;
            }
            else
            {
                front = front.next;
            }
            count--;
            return true;
        }

        public int Front()
        {
            if (count == 0)
                return -1;
            return front.val;
        }

        public int Rear()
        {
            if (count == 0)
                return -1;
            return rear.val;
        }

        public bool IsEmpty()
        {
            return count == 0;
        }

        public bool IsFull()
        {
            return count == capacity;
        }
    }












    public class MyCircularQueue
    {
        Queue queue;
        int capacity;

        public MyCircularQueue(int k)
        {
            queue = new Queue(k);
            capacity = k;
        }

        public bool EnQueue(int value)
        {
            if (queue.Count == capacity)
                return false;
            queue.Enqueue(value);
            return true;
        }

        public bool DeQueue()
        {
            if (queue.Count == 0)
                return false;
            queue.Dequeue();
            return true;
        }

        public int Front()
        {
            if (queue.Count == 0)
                return -1;
            return Convert.ToInt32(queue.Peek());
        }

        public int Rear()
        {
            if (queue.Count == 0)
                return -1;
            var q2 = new Queue();
            while (queue.Count > 1)
            {
                q2.Enqueue(Convert.ToInt32(queue.Dequeue()));
            }
            var item = Convert.ToInt32(queue.Peek());
            q2.Enqueue(Convert.ToInt32(queue.Dequeue()));
            while (q2.Count > 0)
            {
                queue.Enqueue(Convert.ToInt32(q2.Dequeue()));
            }
            return item;
        }

        public bool IsEmpty()
        {
            return queue.Count == 0;
        }

        public bool IsFull()
        {
            return queue.Count == capacity;
        }
    }








    //["UndergroundSystem","checkIn","checkIn","checkOut","checkIn","checkOut","checkOut","checkIn","getAverageTime","getAverageTime","checkIn","checkIn","getAverageTime"]
    //[[],[],[],[],[,[],[],],["],[],[],],[]]









    //public class UndergroundSystem
    //{

    //    Dictionary<string, List<int>> result;
    //    Dictionary<int, CheckIn> checkIns;

    //    public UndergroundSystem()
    //    {
    //        result = new Dictionary<string, List<int>>();
    //        checkIns = new Dictionary<int, CheckIn>();
    //    }

    //    public void CheckIn(int id, string stationName, int t)
    //    {
    //        checkIns[id] = new CheckIn() { stationName = stationName, time = t };
    //    }

    //    public void CheckOut(int id, string stationName, int t)
    //    {
    //        var checkInInfo = checkIns[id];
    //        string key = checkInInfo.stationName + ":" + stationName;
    //        int duration = t - checkInInfo.time;
    //        if (!result.ContainsKey(key))
    //            result[key] = new List<int>();
    //        result[key].Add(duration);
    //        checkIns.Remove(id);
    //    }

    //    public double GetAverageTime(string startStation, string endStation)
    //    {
    //        string key = startStation + ":" + endStation;
    //        return (double)(result[key].Sum()) / (double)(result[key].Count);

    //    }
    //}

    //public class CheckIn
    //{
    //    public string stationName;
    //    public int time;
    //}



    public class UndergroundSystem
    {

        private class checkin
        {


            internal string checkinstationname { get; set; }
            internal int checkintime { get; set; }

        }

        Dictionary<int, checkin> checkins = new Dictionary<int, checkin>();
        Dictionary<string, List<int>> completed = new Dictionary<string, List<int>>();

        public UndergroundSystem()
        {

        }

        public void checkIn(int id, string stationName, int t)
        {
            checkins[id] = new checkin()
            {
                checkinstationname = stationName,
                checkintime = t
            };
        }

        public void checkOut(int id, string stationName, int t)
        {

            var total = t - checkins[id].checkintime;
            var newkey = checkins[id].checkinstationname + ":" + stationName;

            if (!completed.ContainsKey(newkey))
            {
                completed.Add(newkey, new List<int>());
            }
            completed[newkey].Add(total);

        }

        public double getAverageTime(string startStation, string endStation)
        {
            var times = completed[startStation + ":" + endStation];
            var count = times.Count;

            var sum = 0;



            for (var i = 0; i < count; i++)
            {
                sum += times[i];
            }

            var average = (double)sum / (double)count;

            return average;
        }
    }

    /**
     * Your UndergroundSystem object will be instantiated and called as such:
     * UndergroundSystem obj = new UndergroundSystem();
     * obj.CheckIn(id,stationName,t);
     * obj.CheckOut(id,stationName,t);
     * double param_3 = obj.GetAverageTime(startStation,endStation);
     */









    /**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
    public class Codec
    {

        StringBuilder serialized = new StringBuilder();
        // Encodes a tree to a single string.
        public string serialize(TreeNode root)
        {
            if (root == null)
            {
                serialized.Append("M");
                serialized.Append(",");
                return null;
            }
            serialized.Append(root.val + ",");
            serialize(root.left);
            serialize(root.right);
            return serialized.ToString();
        }

        // Decodes your encoded data to tree.
        public TreeNode deserialize(string data)
        {
            if (data == null)
                return null;
            var strs = data.Split(',', StringSplitOptions.RemoveEmptyEntries).ToList();
            return dodeser(strs);
        }

        private TreeNode dodeser(List<string> strs)
        {

            if (strs[0] == "M")
                return null;
            var node = new TreeNode(Convert.ToInt32(strs[0]));
            strs.Remove(strs[0]);
            node.left = dodeser(strs);
            strs.Remove(strs[0]);
            node.right = dodeser(strs);
            return node;
        }


    }

    // Your Codec object will be instantiated and called as such:
    // Codec ser = new Codec();
    // Codec deser = new Codec();
    // TreeNode ans = deser.deserialize(ser.serialize(root));




    //static class Extensions2
    //{
    //    public static IEnumerable<T> Supersect<T>(this IEnumerable<T> a, ICollection<T> b)
    //          => a.Where(b.Remove);

    //}



    class SinglyLinkedListNodeLong
    {
        public long data;
        public SinglyLinkedListNodeLong next;

        public SinglyLinkedListNodeLong(long nodeData)
        {
            this.data = nodeData;
            this.next = null;
        }
    }

    class SinglyLinkedListLong
    {
        public SinglyLinkedListNodeLong head;
        public SinglyLinkedListNodeLong tail;

        public SinglyLinkedListLong()
        {
            this.head = null;
            this.tail = null;
        }

        public void InsertNode(long nodeData)
        {
            SinglyLinkedListNodeLong node = new SinglyLinkedListNodeLong(nodeData);

            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                this.tail.next = node;
            }

            this.tail = node;
        }
    }






    class SinglyLinkedListNode
    {
        public int data;
        public SinglyLinkedListNode next;

        public SinglyLinkedListNode(int nodeData)
        {
            this.data = nodeData;
            this.next = null;
        }
    }

    class SinglyLinkedList
    {
        public SinglyLinkedListNode head;
        public SinglyLinkedListNode tail;

        public SinglyLinkedList()
        {
            this.head = null;
            this.tail = null;
        }

        public void InsertNode(int nodeData)
        {
            SinglyLinkedListNode node = new SinglyLinkedListNode(nodeData);

            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                this.tail.next = node;
            }

            this.tail = node;
        }
    }



    class TrieWithCheck
    {


        class TrieNode
        {
            internal bool isWord { get; set; }
            internal Dictionary<char, TrieNode> children { get; set; } = new Dictionary<char, TrieNode>();
        }

        TrieNode root = new TrieNode();


        public bool Insert(string word)
        {
            var node = root;

            var len = word.Length;
            for (var i = 0; i < len; i++)
            {
                var c = word[i];
                if (node.children.ContainsKey(c))
                {
                    if (node.children[c].isWord || i == len - 1)
                    {
                        return true;
                    }
                }
                else if (!node.children.ContainsKey(c))
                {
                    node.children[c] = new TrieNode();
                }

                node = node.children[c];
            }

            node.isWord = true;

            return false;

        }
    }


    //Refresh on Interfaces and abstract classes


    interface icar
    {
        void func1();


        int a { get; set; }

        int b { get { return 1; } set { } } //you can implement properties


    }

    abstract class acar
    {

        public int a { get; set; }
        public int b { get; set; }

        public abstract void func2();


    }

    class basecar
    {
        public int c { get; set; }
    }

    class car : acar, icar
    {
        car()
        {

        }

        public void func1()
        {
            return;
        }

        public override void func2()
        {
            return;
        }

        public void test1()
        {

            a = 3;

        }


    }
















}