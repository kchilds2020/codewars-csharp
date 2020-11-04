using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCSharp
{
    class AlphabetPosition
    {
        public static string convertString(string text)
        {
            string alphabet = " abcdefghijklmnopqrstuvwxyz";
            string result = "";
            for (int i = 0; i < text.Length; i++)
                if (text[i] != ' ')
                    for (int j = 1; j < alphabet.Length; j++)
                        if (alphabet[j] == text[i] || Char.ToUpper(alphabet[j]) == text[i])
                            result += j + " ";

            return result.Remove(result.Length - 1, 1);
        }

    }
}
