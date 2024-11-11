using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPractice
{
    internal class QuestionFive
    {
        //count the occurrence of each character in a string
        static void Main()
        {
            string input = "hello world";
            Dictionary<char, int> charCount = new Dictionary<char, int>();

            foreach (char c in input)
            {
                if (charCount.ContainsKey(c))
                {
                    charCount[c]++;
                }
                else
                {
                    charCount[c] = 1;
                }
            }

            foreach (var kvp in charCount)
            {
                Console.WriteLine($"Character: '{kvp.Key}' - Count: {kvp.Value}");
            }
        }
    }
}
