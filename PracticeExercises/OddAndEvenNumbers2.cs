using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeExercises
{
    internal class OddAndEvenNumbers2
    {
        public void MainOddAndEvenNumbers2() {

            Console.WriteLine("Insert a number:");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(number%2==0 ? "The number is even." : "The number is odd.");
        
            Console.ReadLine();
        }
    }
}
