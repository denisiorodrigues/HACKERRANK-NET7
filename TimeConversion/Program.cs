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

    public static string timeConversion(string dateString)
    {
        if(string.IsNullOrEmpty(dateString))
        {
            return dateString;
        }
        
        var dateTime = DateTime.Parse(dateString, CultureInfo.CurrentCulture);
        return dateTime.ToString("HH:mm:ss", CultureInfo.CurrentCulture);
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        /*
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.timeConversion(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
        */
        string s = "12:05:33AM";

        string result = Result.timeConversion(s);
        Console.WriteLine(result);
    }
}