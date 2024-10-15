using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeExercises
{
    internal class OddAndEvenNumbers
    {
        public void MainOddAndEvenNumbers()
        {
            Console.WriteLine("Even numbers: ");
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine("\nOdd numbers: ");
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 == 1)
                {
                    Console.Write(i + " ");
                }
            }
            Console.ReadLine();
        }
    }
}
