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


        /// <summary>
        /// 242. Valid Anagram
        /// Given two strings s and t, return true if t is an anagram of s, and false otherwise.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public static bool IsAnagram(string s, string t)
        {
            var dict = new byte[26];
            
            foreach(var c in s)
            {
                dict[c-'a']++;
            }

            foreach(var c in t)
            {
                dict[c-'a']--;
            }

            foreach(var n in dict)
            {
                if (n != 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
