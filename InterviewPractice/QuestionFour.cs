using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPractice
{
    internal class QuestionFour
    {
        //reverse each word in a given string
        static void Main()
        {
            string input = "Hello World from C#";
            string[] words = input.Split(' '); // Split the string into words

            for (int i = 0; i < words.Length; i++)
            {
                char[] chars = words[i].ToCharArray();
                Array.Reverse(chars);
                words[i] = new string(chars); // Reverse each word
            }

            string result = string.Join(" ", words); // Join the reversed words
            Console.WriteLine(result); // Output: "olleH dlroW morf #C"
        }
    }
}
