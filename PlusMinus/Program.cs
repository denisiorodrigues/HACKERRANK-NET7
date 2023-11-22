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
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        var count = (decimal) arr.Count();
        var positiveCount = (decimal) arr.Where(x => x > 0).Count();
        var negativeCount = (decimal) arr.Where(x => x < 0).Count();
        var equalZero = (decimal) arr.Where(x => x == 0).Count();

        Console.WriteLine(FormatResult(positiveCount/count));
        Console.WriteLine(FormatResult(negativeCount/count));
        Console.WriteLine(FormatResult(equalZero/count));
    }

    public static string FormatResult(decimal result) 
    {
        return Math.Round(result, 5).ToString("F5");
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        //int n = Convert.ToInt32(Console.ReadLine().Trim());
        //List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
        //List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
        List<int> arr = new List<int>{-4, 3, -9, 0, 4, 1};
        
        //List<int> arr = new List<int>{55,48,48,45,91,97,45,1,39,54,36,6,19,35,66,36,72,93,38,21,65,70,36,63,39,76,82,26,67,29,24,82,62,53,1,50,47,65,67,19,66,90,77};

        Result.plusMinus(arr);
    }
}
