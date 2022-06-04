using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetSolutions.DataStructures
{
    public static class StringProblems
    {
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

        /// <summary>
        /// 383. Ransom Note
        /// Given two strings ransomNote and magazine, return true if ransomNote can be constructed 
        /// from magazine and false otherwise.
        /// Each letter in magazine can only be used once in ransomNote.
        /// </summary>
        /// <param name="ransomNote"></param>
        /// <param name="magazine"></param>
        /// <returns></returns>
        public static bool CanConstruct(string ransomNote, string magazine)
        {
            var dict = new Dictionary<char, int>();
            foreach(var c in magazine)
            {
                if (dict.ContainsKey(c))
                {
                    dict[c]++;
                }
                else
                {
                    dict.Add(c, 1);
                }
            }

            foreach(var c in ransomNote)
            {
                if (dict.TryGetValue(c, out var value))
                {
                    if (value == 0)
                    {
                        return false;
                    }
                    dict[c]--;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }
    }
}
