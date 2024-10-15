using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeExercises
{
    internal class AgeCheckOutput
    {
        public void MainAgeCheckOutput()
        {

            bool success = true;

            while (success)
            {
                Console.WriteLine("Please insert your age:");
                if (int.TryParse(Console.ReadLine(), out int parsedAge))
                {

                    if (parsedAge < 0 || parsedAge > 126)
                    {
                        Console.WriteLine("Invalid range.");
                    }
                    else
                    {
                        success = false;
                        if (parsedAge > 0 && parsedAge <= 12)
                        {
                            Console.WriteLine("You are a child.");
                        }
                        else if (parsedAge > 12 && parsedAge <= 18)
                        {
                            Console.WriteLine("You are a teenager.");
                        }
                        else if (parsedAge > 18 && parsedAge <= 59)
                        {
                            Console.WriteLine("You are an adult.");
                        }
                        else if (parsedAge > 59)
                        {
                            Console.WriteLine("You are a senior adult.");
                        }
                    }
                } else { Console.WriteLine("Invalid age input."); }
            }
            Console.ReadLine();

        }
    }
}
