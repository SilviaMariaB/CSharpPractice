using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace PracticeExercises
{
    internal class FizzBuzz
    {
        public void MainFizzBuzz()
        {
            Console.WriteLine("Please insert a number.");
            int maximum = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= maximum; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            } 
            Console.ReadLine();
        }

    }
}
