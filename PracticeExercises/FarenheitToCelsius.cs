using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeExercises
{
    internal class FarenheitToCelsius
    {
        public void MainFarenheitToCelsius()
        {
            Console.WriteLine("Please select an option:");
            Console.WriteLine("1. Convert from F to C.");
            Console.WriteLine("2. Convert from C to F.");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {

                Console.WriteLine("Please insert the value in F:");
                double temperatureF = Convert.ToDouble(Console.ReadLine());

                double temperatureConvertedinC = (temperatureF - 32) / 1.8;

                Console.WriteLine("The temperature in Celsius is: {0:0.00}C", temperatureConvertedinC);
            }
            else if (choice == 2)
            {
                Console.WriteLine("Please insert the value in C:");
                double temperatureC = Convert.ToDouble(Console.ReadLine());
                double temperatureConvertedinF = (temperatureC * 1.8) + 32;

                Console.WriteLine("The temperature in Farenheit is: {0:0.00}F", temperatureConvertedinF);
            }
            Console.ReadLine();
        }
    }
}
