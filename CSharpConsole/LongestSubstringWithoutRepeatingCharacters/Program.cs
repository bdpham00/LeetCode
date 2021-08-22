using System;
using System.Collections.Generic;
using System.Linq;

namespace LongestSubstringWithoutRepeatingCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Solution().LengthOfLongestSubstring("abcabcbb")) ;
            Console.Read();
        }
    }

    public class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            string repeatCharacter = "";
            List<string> subStrings = new List<string>(); 
            if (!string.IsNullOrEmpty(s))
            {
                for (int i = 0; i < s.Length - 1; i++)
                {
                    repeatCharacter += s[i];
                    if (repeatCharacter[i] == s[i + 1])
                    {
                        subStrings.Add(repeatCharacter); 
                        repeatCharacter = "";
                    }
                }
            }

            return subStrings.OrderByDescending(x => x.Length).First().Length;
        }
    }
}
