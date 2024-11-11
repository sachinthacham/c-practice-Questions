using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPractice
{
    internal class QuestionSix
    {
        //remove duplicate characters from a string?
        static void Main()
        {
            string input = "hello world";
            string result = RemoveDuplicates(input);
            Console.WriteLine(result);
        }

        static string RemoveDuplicates(string input)
        {
            HashSet<char> seen = new HashSet<char>();  // To keep track of characters that have already been added
            string result = "";  // The result string without duplicates

            foreach (char c in input)
            {
                if (!seen.Contains(c))  // Check if the character is already in the HashSet
                {
                    seen.Add(c);  // If not, add it to the HashSet
                    result += c;  // Add the character to the result string
                }
            }

            return result;
        }
    }
}
