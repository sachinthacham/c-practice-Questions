using System;
using System.Collections.Generic;


namespace InterviewPractice
{
    public class Program
    {
        static void Main(string[] args)
        {

            int number = 23457;
            int sum = 0;

            while(number > 0)
            {
                sum += number % 10;
                number /= 10;
            }
           
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
