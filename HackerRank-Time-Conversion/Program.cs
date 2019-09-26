using System;
using System.IO;

namespace HackerRank_Time_Conversion
{
    class Program
    {
        static string TimeConversion(string s)
        {
            //Boolean variable to see if our converison was sucessful from 12 hour to 24 hour while calling the DateTime class in C# using the TryParse method which it
            // will take the input string and the out variable of the DateTime class.
            bool conversionSuccess = DateTime.TryParse(s, out DateTime time);
      
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
