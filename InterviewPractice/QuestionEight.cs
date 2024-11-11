using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPractice
{
    internal class QuestionEight
    {
        //find the sum of digits of a positive integer
        static void Main()
        {
            int number = 12345;  // Example input number
            int sum = 0;

            // While the number is greater than 0
            while (number > 0)
            {
                // Add the last digit to the sum
                sum += number % 10;

                // Remove the last digit from the number
                number /= 10;
            }

            // Output the result
            Console.WriteLine("Sum of digits: " + sum);
        }
    }
}
