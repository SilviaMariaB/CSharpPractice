using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeExercises
{
    internal class BiggestNumber
    {
        public void MainBiggestNumber()
        {
            Console.WriteLine("Insert 1st number");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insert 2nd number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insert 3rd number");
            int num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 >= num2)
            {
                if (num1 >= num3)
                {
                    Console.WriteLine("The biggest number is " + num1);
                }
                else { Console.WriteLine("The biggest number is " + num3); }
            }
            else if (num2 >= num3)
            {
                Console.WriteLine("The biggest number is " + num2);
            }
            else { Console.WriteLine("The biggest number is " + num3); }

            Console.ReadLine();
        }
    }
}
