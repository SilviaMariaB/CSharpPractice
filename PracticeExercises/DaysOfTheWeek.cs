using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeExercises
{
    internal class DaysOfTheWeek
    {
        public void MainDaysOfTheWeek()
        {
            Console.WriteLine("Insert a day of the week in number form (1-7):");
            int dayOfWeek = Convert.ToInt32(Console.ReadLine());

            switch (dayOfWeek)
            {
                case 1: Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Insert not valid :(");
                    break;
            }

            Console.ReadLine();
        }
    }
}
