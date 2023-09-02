using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace Solve_me_first
{
    class Result
    {
        public static string timeInWords(int h, int m)
        {
            string[] a ={"one","two","three",
        "four","five","six",
        "seven","eight","nine","ten",
        "eleven","twelve","thirteen","fourteen","fifteen","sixteen",
        "seventeen","eighteen","nineteen","twenty","twenty one",
        "twenty two","twenty three","twenty four","twenty five",
        "twenty six","twenty seven","twenty eight","twenty nine"};
            if (m == 0)
                return a[h - 1] + " o' clock";
            else if (m == 1)
                return a[m - 1] + " minute past " + a[h - 1];
            else if (m == 15)
                return "quarter past " + a[h - 1];
            else if (m > 0 && m < 30)
                return a[m - 1] + " minutes past " + a[h - 1];
            else if (m == 30)
                return "half past " + a[h - 1];
            else if (m == 45)
            {
                if (h == 12)
                    return "quarter to " + a[h - 12];
                else
                    return "quarter to " + a[h];
            }
            else
            {
                if (h == 12)
                    return a[60 - m - 1] + " minutes to " + a[h - 12];
                else
                    return a[60 - m - 1] + " minutes to " + a[h];
            }
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int h = Convert.ToInt32(Console.ReadLine().Trim());

            int m = Convert.ToInt32(Console.ReadLine().Trim());

            string result = Result.timeInWords(h, m);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }

    }
}


