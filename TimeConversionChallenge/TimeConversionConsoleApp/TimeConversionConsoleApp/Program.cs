﻿using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("TimeConversionTests")]
internal class Result
{

    /*
     * Complete the 'timeConversion' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string timeConversion(string dateInput)
    {
        //07:05:45PM
        var dateFormat = "hh:mm:sstt";
        var parsedDate = DateTime.ParseExact(dateInput, dateFormat, null);

        return parsedDate.ToString("HH:mm:ss");
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