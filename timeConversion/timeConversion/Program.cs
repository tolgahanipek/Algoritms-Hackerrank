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

class Result
{

    /*
     * Complete the 'timeConversion' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string timeConversion(string s)
    {
        string k = "";

        if (s.Substring(s.Length - 2, 2) == "PM")
        {
            k = s.Replace(s.Substring(s.Length - 2, 2), "");
            if (Convert.ToInt32(k.Substring(0, 2)) >= 12)
                return k;
            else
            {
                return k.Replace(k.Substring(0, 2), (12 + Convert.ToInt32(k.Substring(0, 2))).ToString());
            }
        }
        else
        {
            k = s.Replace(s.Substring(s.Length - 2, 2), "");
            if (Convert.ToInt32(k.Substring(0, 2)) >= 12)
            {
                return k.Replace(k.Substring(0, 2), "0" + (Convert.ToInt32(k.Substring(0, 2)) - 12).ToString());
            }
            else
                return k;
        }
    }
}
class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.timeConversion(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
