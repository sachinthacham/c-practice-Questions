using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPractice
{
    internal class QuestionSeven
    {
        //find all possible substring of a given string
        static void Main()
        {
            string input = "abc";
            FindSubstrings(input);
        }

        static void FindSubstrings(string input)
        {
            int length = input.Length;

            // Outer loop for the starting index
            for (int i = 0; i < length; i++)
            {
                // Inner loop for the ending index
                for (int j = i + 1; j <= length; j++)
                {
                    // Extract the substring
                    string substring = input.Substring(i, j - i);
                    Console.WriteLine(substring);
                }
            }
        }
    }
}
