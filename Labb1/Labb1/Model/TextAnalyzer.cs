using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Labb1.Model
{
    public static class TextAnalyzer
    {

        public static int GetNumberOfCapitals(string content)
        {
            int counter = 0;
            for (var i = 0; i < content.Length; i++)
            {
                var letterChecker = content[i];
                if (char.IsUpper(letterChecker) && !(char.IsWhiteSpace(letterChecker))) // om letterChecker har stor bokstav och inte är ett mellanrum...
                {
                    counter++;
                }
            }
            return counter;
        }

    }
}