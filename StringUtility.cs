using System;
using System.Collections.Generic;

namespace road_to_C_
{
    public class StringUtility
    {

        public static string SummerizeText(string text)
        {

            const int maxlength = 20;
            if (text.Length < 20)

                return text;
            var words = text.Split(' ');
            var totalCharacters = 0;
            var summaryWords = new List<string>();
            foreach (var word in words)
            {
                summaryWords.Add(word);

                totalCharacters += word.Length + 1;
                if (totalCharacters > maxlength)
                    break;
            }
            return String.Join(" ", summaryWords) + "....";


        }

    }
}
