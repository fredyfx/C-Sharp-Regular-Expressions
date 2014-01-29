using System;
using System.Text;
// In order to use Regex:
using System.Text.RegularExpressions;

namespace RegularExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex pattern0 = new Regex(" ");
            string text0 = "El fredy";
            string[] words0 = pattern0.Split(text0);
            foreach (string word0 in words0)
            {
                Console.WriteLine(word0);
            }
            Console.WriteLine("Without digits:");
            //For \d -> it means IsDigit?
            Regex pattern1 = new Regex(@"\d");
            string text1 = "El1fredy23fx";
            string[] words1 = pattern1.Split(text1);
            foreach (string word1 in words1)
            {
                Console.WriteLine(word1);
            }
            string sampleLine = "Hello world!";
            Regex pattern2 = new Regex("[aeiou]");
            string noVowels = pattern2.Replace(sampleLine, "?");
            Console.WriteLine(noVowels);
        }
    }
}
