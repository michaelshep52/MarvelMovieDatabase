using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Common.cs
{
    public static class StringHandler
    {
        /// <summary>
        ///Insert Spaces before each capital letter in a string
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string InsertSpaces(this string source) //(this) makes it an extension.
        {
            string result = string.Empty;

            if (!String.IsNullOrWhiteSpace(source))
            {
                foreach (char letter in source)
                {
                    if (char.IsUpper(letter)) //looks through out code for Uppercase letter then adds a space.
                    {
                        result = result.Trim(); //Trim any spaces already there before adding a space.
                        result += "";
                    }
                    result += letter;
                }
            }
            result = result.Trim();
            return result;
        }
    }
}