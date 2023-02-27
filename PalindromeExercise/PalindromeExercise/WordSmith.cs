using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string word1)
        {
            string word2 = "";
            for (int i = word1.Length - 1; i >= 0; i--)
            {
                word2 += word1[i];
            }
            if (word1 == word2)
            {
                return true;
            }
            return false;
        }
    }
}
