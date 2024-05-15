using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaća2_
{
    //Refaktoriranje ZAD4
    class UniqueChars
    {
        public static List<char> Add(string text)
        {
            List<char> chars = new List<char>();

            for (int i = 0; i < text.Length; i++)
            {
                if (IsUnique(text[i], text))
                {
                    chars.Add(text[i]);
                }
            }
            return chars;
        }

        public static bool IsUnique(char letter, string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (IsEqual(letter, text[i]))
                    return false;
            }
            return true;
        }

        public static bool IsEqual(char a, char b)
        {
            if (a == b)
                return true;

            return false;
        }
    }
}
