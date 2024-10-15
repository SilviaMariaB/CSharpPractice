using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeExercises
{
    internal class SumTenValues
    {
        private string GetDisplayQuestion(int index)
        {
            if (index == 1)
            {
                return "Insert 1st number:";
            }

            if (index == 2) {
                return "Insert 2nd number:";

            }

            if (index == 3) {
                return "Insert 3rd number:";
            }

            return $"Insert {index}th number:";
        }

        public void MainSumTenValues2()
        {
            int totalSum = 0;

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(GetDisplayQuestion(i));
                int insertedNumber = Convert.ToInt32(Console.ReadLine());
                totalSum = totalSum + insertedNumber;
            }

            Console.WriteLine("The sum is {0}", totalSum);
            Console.ReadLine();
        }

        public void MainSumTenValues() {
            int totalSum = 0;

            for (int i = 1; i <= 10; i++) {
                if (i == 1)
                {
                    Console.WriteLine("Insert 1st number:");
                    int insertedNumber = Convert.ToInt32(Console.ReadLine());
                    totalSum = totalSum + insertedNumber;
                }
                else if (i == 2)
                {
                    Console.WriteLine("Insert 2nd number:");
                    int insertedNumber = Convert.ToInt32(Console.ReadLine());
                    totalSum = totalSum + insertedNumber;
                }
                else if (i == 3)
                {
                    Console.WriteLine("Insert 3rd number:");
                    int insertedNumber = Convert.ToInt32(Console.ReadLine());
                    totalSum = totalSum + insertedNumber;
                } else
                {
                    Console.WriteLine("Insert {0}th number:", i);
                    int insertedNumber = Convert.ToInt32(Console.ReadLine());
                    totalSum = totalSum + insertedNumber;
                }
            }
            Console.WriteLine("The sum is {0}", totalSum);
            Console.ReadLine();
        }
    }
}
