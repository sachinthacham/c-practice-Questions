using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPractice
{
    internal class QuestionThree
    {
        //reverse the order of words in a given string
        static void Main()
        {
            string input = "Hello World from C#";
            string[] words = input.Split(' '); // Split the string into words
            Array.Reverse(words);              // Reverse the array of words
            string reversed = string.Join(" ", words); // Join the words back into a string

            Console.WriteLine(reversed); // Output: "C# from World Hello"
        }
    }
}
