using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TwitCore.Helpers {
    public static class Base64Handler { //for encoding base64 to string, and vice versa. This is not really needed for this project, but can be usefull when trying out micro services

        /// <summary>
        /// Encodes text to base4 string, based on the encoding type passed through
        /// </summary>
        /// <param name="encoding">Encoding, like UTF-8</param>
        /// <param name="text">Text to be encoded</param>
        /// <returns></returns>
        public static string EncodeBase64(this System.Text.Encoding encoding, string text) {
            if (text == null)
                return null;

            byte[] textAsBytes = encoding.GetBytes(text);
            return System.Convert.ToBase64String(textAsBytes);
        }

        /// <summary>
        /// Decodes a base 64 string, as per the encoding type indicated. If it can't be decoded (due to incorrect format) it will return a null value and a false
        /// </summary>
        /// <param name="encoding">Encoding, like UTF-8</param>
        /// <param name="encodedText">Text to be decoded</param>
        /// <param name="decodedText">The decoded text</param>
        /// <returns></returns>
        public static bool TryDecodeBase64(this System.Text.Encoding encoding, string encodedText, out string decodedText) {
            if (encodedText == null) {
                decodedText = null;
                return false;
            }

            try {
                byte[] textAsBytes = Convert.FromBase64String(encodedText);
                decodedText = encoding.GetString(textAsBytes);
                return true;
            }
            catch (Exception) {
                decodedText = null;
                return false;
            }
        }
    }
}
