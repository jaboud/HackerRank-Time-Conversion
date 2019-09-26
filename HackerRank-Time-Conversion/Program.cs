using System;
using System.IO;

namespace HackerRank_Time_Conversion
{
    class Program
    {
        static string TimeConversion(string s)
        {

      
        }
        static void Main(string[] args)
        {
            TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string s = Console.ReadLine();

            string result = TimeConversion(s);

            tw.WriteLine(result);

            tw.Flush();
            tw.Close();
        }
    }
}
