using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeExercises
{
    internal class NumberOfDays
    {
        public void MainNumberOfDays()
        {
            Console.WriteLine("Please insert your birth year:");

            int birthYear = Convert.ToInt32(Console.ReadLine());
            int yearsCount = 2024 - birthYear;
            int noOfDays = yearsCount * 365;

            Console.WriteLine("You are born in the year {0} and you have lived {1} days.", birthYear, noOfDays);

            Console.ReadLine();
        }
    }
}
