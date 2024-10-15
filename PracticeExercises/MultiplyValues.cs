using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeExercises
{
    internal class MultiplyValues
    {
        public void MainMultiplyValues() {
            Console.WriteLine("Insert 1st number");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insert 2nd number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insert 3rd number");
            int num3 = Convert.ToInt32(Console.ReadLine());

            int total1 = num1 * num2;
            int total2 = total1 * num3;
            Console.WriteLine("{0} * {1} = {2}", num1, num2, total1);
            Console.WriteLine("{0} * {1} = {2}", total1, num3, total2);

            Console.ReadLine();

        }
    }
}
