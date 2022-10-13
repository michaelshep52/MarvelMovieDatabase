﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Common.cs
{
    public class StringHandler
    {
        public string InsertSpaces(string source)
        {
            string result = string.Empty;

            if (!String.IsNullOrWhiteSpace(source))
            {
                foreach (char letter in source)
                {
                    if (char.IsUpper(letter)) //looks through out code for Uppercase letter then adds a space.
                    {
                        result += "";
                    }
                    result += letter;
                }
            }
            return result;
        }
    }
}

