using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetSolutions.DataStructures
{
    public static class StringProblems
    {
        struct CharStat
        {
            int firstPos;
            int count;
        };

        /// <summary>
        /// 387. First Unique Character in a String
        /// Given a string s, find the first non-repeating character in it and return its index. 
        /// If it does not exist, return -1.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int FirstUniqChar(string s)
        {
            var dict = new Dictionary<char, int[]>();
            for(var i = 0; i < s.Length; i++)
            {
                if (dict.TryGetValue(s[i], out var stat))
                {
                    stat[1]++;
                }
                else
                {
                    dict.Add(s[i], new int[2] { i, 1 });
                }
            }
            foreach(var item in dict)
            {
                if (item.Value[1] == 1)
                {
                    return item.Value[0];
                }
            }
            return -1;
        }
    }
}
