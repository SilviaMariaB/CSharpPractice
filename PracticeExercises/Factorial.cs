using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeExercises
{
    internal class Factorial
    {
        public void MainFactorial()
        {
            Console.WriteLine("Please insert the value:");
            int value = Convert.ToInt32(Console.ReadLine());
            int fact = 1;

            if(value > fact)
            {
                for (int i = 1; i <= value; i++)
                {
                    fact = fact * i;
                    Console.WriteLine(fact);
                }
            }
            Console.WriteLine("{0}! = {1}", value, fact);
            Console.ReadLine();
        }
    }
}
