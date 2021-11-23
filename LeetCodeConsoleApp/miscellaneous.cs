using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeConsoleApp
{
    class miscellaneous
    {
   

       // Microsoft final round phone screen:

            
     
            //ISet<string> dictionary;
            //public MyController(IList<string> validEnglishWords)
            //{
            //    // TODO: something here
            //    dictionary = new HashSet<string>(validEnglishWords);

            //}

        //    List<string> results = new List<string>();
        //    public IList<string> GetAllValidAnagrams(string word)
        //    {
        //        // TODO: Implement
        //        // 

        //        var result = "";
        //        permute(word, result);
        //        var anagrams = results.Where(r => dictionary.Contains(r));

        //        return anagrams.ToList();

        //    }

        //    public void permute(string s, string answer)
        //    {

        //        if (s.Length == 0)
        //        {
        //            results.Add(answer);
        //        }

        //        for (var i = 0; i < s.Length; i++)
        //        {
        //            var c = s[i];
        //            var left = s.Substring(0, i);
        //            var right = s.Substring(i + 1);
        //            var rest = left + right;
        //            permute(rest, answer + c);
        //        }

        //    }


        //}





    //        1) AMAZON FINAL ROUND - Sep 13 / 14th
    //        implement prefix search with dictionary of priorities

    //dictionary:

    //[] {amazing, 10}
    //{amazon, 5}
    //{ amazonian, 3}


    //create class

    //create your won search structure

    //and also method with parameter
    //of prefix like "A", "AM", "AMAZONI", etc.
    //Probably, need to use a Trie?  How to implement it in C#?


    //********************************************
    //2)  AMAZON FINAL ROUND
    //write a function to find the difference between two dates whether it is exactly a month, less than a month or 
    //greater than a month apart.

    //just concerned about logic.  Don't code too fast.  so consider edge cases like year greater than next year by one 
    //then it would have to be january and December etc.

    //// Write a function that given two dates 
    //// returns -1 if they are less than a month apart, 
    //// 0 if they are exactly a month apart, and 
    //// 1 if they are greater than a month apart.

    //DateTime date1 = new DateTime(28, 2, 2021);
    //DateTime date2 = new DateTime(31, 3, 2021);

    public int monthDiff(DateTime date1, DateTime date2)
    {
        if (date1.Year == date2.Year)
        {
            if (date1.Month == date2.Month)
            {
                return -1;
            }
            else if (date1.Month - date2.Month == 1)
            {
                if (date1.Day == date2.Day)
                    return 0;
                else if (date1.Day < date2.Day)
                    return -1;
                else
                    return 1;
            }
            else if (date2.Month - date1.Month == 1)
            {
                if (date1.Day == date2.Day)
                    return 0;
                else if (date2.Day < date1.Day)
                    return -1;
                else
                    return 1;
            }
            else
                return 1;

        }
        else if (date1.Year - date2.Year == 1)
        {
            if (date1.Month == 1 && date2.Month == 12)
            {
                if (date1.Day == date2.Day)
                    return 0;
                else if (date1.Day < date2.Day)
                    return -1;
                else
                    return 1;
            }
            else
                return 1;
        }

        else if (date2.Year - date1.Year == 1)
        {
            if (date2.Month == 1 && date1.Month == 12)
            {
                if (date2.Day == date1.Day)
                    return 0;
                else if (date2.Day < date1.Day)
                    return -1;
                else
                    return 1;
            }
            else
                return 1;
        }

        return 1;



    }

    }


    //3)Design a max user limiter for amazon prime video service - enforce currently allowed number of users at any one time

    //4)  code up a user class for a social network, and
    //public class Users
    //        {

    //            public UUid userid;
    //            public string firstname;
    //            public string lastname;
    //            public string email;
    //            public string phonenumber;
    //            public string addressline1;
    //            public List<Users> friends;

    //        }

    //        public class UserRelations
    //        {

    //            public UUID user;
    //            public UUID friend;


    //        }


    //        public class Friend
    //        {
    //            public UUID user;
    //        }



    //        Dictionary<string, UUID> userhash;

    //> Using your social network, and given a Users object, write an algorithm that allows you to
    //fetch all friends at k-depth? (e.g.friend of a friend is depth 2)

    //List<Users> friends = new List<Users>();

    //        public List<Users> findFriends(Users user, k);
    //{
    //    friendsatDepth(user.friends, k)
    //    return friends;
    //}

    //    private void friendsatDepth(List<Users> users, int k)
    //    {

    //        if (users == null || k < 1)
    //            return;

    //        if (k == 1)
    //            friends.AddRange(users.friends);
    //        else
    //        {
    //            foreach (user in user.friends)
    //                friendsatDepth(user, k - 1);
    //        }


    //    }







    //Microsoft online assessment 6-Oct-2021
    //full source is in my repos here:  C:\Users\clmho\Source\Repos\abhiinifileParser\IniFileParser
    //public void Parse()  // just need to add sorting by like binary sort and implement icomparable?

    //{
    //    List<string> lines = File.ReadAllLines(Path).ToList();

    //    var section = new Section("");
    //    for (var i = 0; i < lines.Count; i++)
    //    {
    //        var line = lines[i].Trim();
    //        if (!line.StartsWith("#") && !string.IsNullOrEmpty(line))
    //        {
    //            if (line.StartsWith("["))
    //            {
    //                if (section.Name != "")
    //                {
    //                    Sections.Add(section);
    //                }
    //                var sectionstr = line.Replace('[', ' ').Replace(']', ' ').Trim();
    //                section = Sections.Where(s => s.Name == sectionstr).FirstOrDefault();
    //                if (section == null)
    //                {
    //                    section = new Section(sectionstr);
    //                }
    //            }
    //            else
    //            {
    //                while (i < lines.Count && !lines[i].StartsWith("[") && !lines[i].StartsWith("#") && !string.IsNullOrEmpty(lines[i].Trim()))
    //                {
    //                    lines[i] = lines[i].Trim();
    //                    var kindex = lines[i].IndexOf('=');

    //                    var key = lines[i].Substring(0, kindex).Trim();
    //                    var value = lines[i].Substring(kindex + 1).Trim();
    //                    if (!section.KeyValuePairs.ContainsKey(key))
    //                    {
    //                        section.KeyValuePairs.Add(key, new List<string>() { value });
    //                    }
    //                    else
    //                    {
    //                        section.KeyValuePairs[key].Add(value);
    //                    }

    //                    i++;
    //                }
    //                i--;
    //            }

    //        }
    //    }


    //}




    class Result
    {


        //        parse codelist into a proper list of lists.

        //loop through all shopping cart items

        // in loop, comparecodelist group[x][y] to current item or anything

        //  if a match, increment y, if y > current list count, set y to 0 and increment x

        //else if no match, then we must reset y to 0 as the group was only partially matched

        //  at end compare x to count.  if == return 1, else return 0;

        //2)O(c) + O(s + c) = O(c + s) where c is codelist, and s is shopping cart.


        /*
         * Complete the 'foo' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. STRING_ARRAY codeList
         *  2. STRING_ARRAY shoppingCart
         */

        public int foo(List<string> codeList, List<string> shoppingCart)
        {
            if (shoppingCart == null || shoppingCart.Count == 0) return 0;
            if (codeList == null || codeList.Count == 0) return 1;

            var scpointer = 0;
            // var clpointer = 0;
            var codegroups = new List<List<string>>();
            for (var i = 0; i < codeList.Count; i++)
            {
                var curr = codeList[i].Split(' ').ToList();
                codegroups.Add(curr);
            }
            var codegroupindex = 0;
            var codeindex = 0;

            for (; scpointer < shoppingCart.Count; scpointer++)
            {
                if (codegroupindex == codegroups.Count)
                    return 1;
                var code = codegroups[codegroupindex][codeindex];
                if (shoppingCart[scpointer] == code || code == "anything")
                {

                    codeindex++;
                    if (codeindex == codegroups[codegroupindex].Count)
                    {
                        codeindex = 0;
                        codegroupindex++;
                    }


                }
                else
                {
                    codeindex = 0;
                }

            }
            return codegroupindex == codegroups.Count ? 1 : 0;

        }




    }

    //class Solution
    //{
    //    public static void Main(string[] args)
    //    {
    //        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

    //        int codeListCount = Convert.ToInt32(Console.ReadLine().Trim());

    //        List<string> codeList = new List<string>();

    //        for (int i = 0; i < codeListCount; i++)
    //        {
    //            string codeListItem = Console.ReadLine();
    //            codeList.Add(codeListItem);
    //        }

    //        int shoppingCartCount = Convert.ToInt32(Console.ReadLine().Trim());

    //        List<string> shoppingCart = new List<string>();

    //        for (int i = 0; i < shoppingCartCount; i++)
    //        {
    //            string shoppingCartItem = Console.ReadLine();
    //            shoppingCart.Add(shoppingCartItem);
    //        }

    //        int result = Result.foo(codeList, shoppingCart);

    //        textWriter.WriteLine(result);

    //        textWriter.Flush();
    //        textWriter.Close();
    //    }
    //}



}
