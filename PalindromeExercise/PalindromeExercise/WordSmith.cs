using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string word)
        {
            //reverse the word
            var reversed = "";

            for (int i = word.Length - 1; i >= 0; i--)
            {
                reversed += word[i];
            }
            //compare the original with the reversed
            if (reversed.ToLower() == word.ToLower())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
