using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaća2_
{
    //Refaktoriranje ZAD5
    class Palindrome
    {
        public List<string> AddPalindromes(List<string> words)
        {
            List<string> palindromes = new List<string>();

            if (IsEmpty(words))
                return palindromes;

            foreach (string word in words)
            {
                if (ReplaceSpaces(word).Equals(ReverseWord(word)))
                {
                    palindromes.Add(word);
                }
            }
            return palindromes;
        }

        public string ReplaceSpaces(string word)
        {
            return word.Replace(" ", "").ToLower();
        }

        public string ReverseWord(string word)
        {
            return new string(word.Reverse().ToArray());
        }

        public bool IsEmpty(List<string> words)
        {
            if (words == null)
                return true;
            return false;
        }
    }
}
