using System;
using System.Collections.Generic;

namespace HackerRankExam
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 13-EqualPrice (20dk)
            //List<long> result = countMinimumOperations(new List<int>() { 2, 5, 1 }, new List<int>() { 8, 4, 3 });
            //List<long> result2 = countMinimumOperations(new List<int>() { 2 }, new List<int>() { 8,4,3,10,6 });
            //foreach(var item in result2)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 12-StringReplacement 11:29
            Console.WriteLine(getSmallestString("db??c???erdec", "deciph"));
            #endregion

            #region 11-ComplianceCrawlerDirectoryReset (15dk)
            //int result = minimumSteps(new List<string>() { "x/", "../", "y/", "z/"});
            //Console.WriteLine(result);
            #endregion

            Console.ReadLine();
        }
        public static List<long> countMinimumOperations(List<int> price, List<int> query)
        {
            List<long> result = new List<long>();
            for (int i = 0; i < query.Count; i++)
            {
                int toplam = 0;
                for (int j = 0; j < price.Count; j++)
                {
                    toplam += Math.Abs(query[i] - price[j]);
                }
                result.Add(Convert.ToInt64(toplam));
            }
            return result;
        }

        public static string getSmallestString(string word, string substr)
        {
            int subind = 0;
            char[] word2 = word.ToCharArray();
            for (int i = 0; i < word.Length; i++)
            {
                if (subind < substr.Length)
                {
                    if (word[i] == substr[subind] || word[i] == '?')
                    {
                        word2[i] = substr[subind];
                        subind++;
                    }
                    else
                    {
                        if (word[i] == '?') { word2[i] = 'a'; }
                        subind = 0;
                    }
                }              
            }
            string result = string.Concat(word2);
            return result.Contains(substr)?result:"-1";
        }

        public static int minimumSteps(List<string> loggedMoves)
        {
            int result = 0;
            for (int i = 0; i < loggedMoves.Count; i++)
            {
                switch (loggedMoves[i])
                {
                    case "../":
                        result--;
                        break;
                    case "./":
                        break;
                    default:
                        result++;
                        break;
                }
            }
            return result;
        }
    }
}
