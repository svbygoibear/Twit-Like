using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TwitCore.Helpers {
    public static class StringHandler {
        /// <summary>
        /// This is used to determine the start and end index of a word in a string.
        /// </summary>
        /// <param name="Text">String to find the word in.</param>
        /// <param name="Keyword">Keyword to look for in the string.</param>
        /// <returns>Returns a tuple with the start and end index of the keyword.</returns>
        public static Tuple<int, int> GetStartEnd(this string Text, string Keyword) {
            var start = Text.IndexOf(Keyword);
            if (start > -1)
                return new Tuple<int, int>(start, Keyword.Length + start);
            else
                return new Tuple<int, int>(0, 0);
        }
    }
}
