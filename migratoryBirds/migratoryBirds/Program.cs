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
     * Complete the 'migratoryBirds' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static int migratoryBirds(List<int> arr)
    {
        Dictionary<string, int> g = new Dictionary<string, int>();
        arr.Sort();
        int c = 0, f = 0;
        int temp = 0;
        int counter = 0;
        for (int i = 0; i < arr.Count; i++)
        {
            if (temp != arr[i])
            {
                for (int j = i; j < arr.Count; j++)
                {
                    if (arr[i] == arr[j])
                        counter++;
                    else
                        break;
                }
                g.Add(arr[i].ToString(), counter);
                temp = arr[i];
                counter = 0;
            }
            else
                continue;
        }

        foreach (KeyValuePair<string, int> d in g)
        {
            if (c < d.Value)
            {
                c = d.Value;
                f = Convert.ToInt32(d.Key);
            }
        }
        return f;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int result = Result.migratoryBirds(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
