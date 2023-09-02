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


    public static int equalizeArray(List<int> arr)
    {
        int adet = 0, temp = 0, temp1 = 0;
        arr.Sort();
        for (int i = 0; i < arr.Count; i++)
        {
            adet = 0;
            if (arr[i] != temp)
            {
                for (int j = i; j < arr.Count; j++)
                {
                    if (arr[j] == arr[i])
                        adet++;
                    else
                        continue;
                }
                temp = arr[i];
                if (temp1 < adet)
                    temp1 = adet;
                else
                    continue;
            }

        }

        return arr.Count - temp1;

    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int result = Result.equalizeArray(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
