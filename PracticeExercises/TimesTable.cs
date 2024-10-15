using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PracticeExercises
{
    internal class TimesTable
    {
        public void MainTimesTable()
        {
            Console.WriteLine("Please insert a number for the times table");
            int tableNumber = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < 10; i++) {
                Console.WriteLine("{0} x {1} = {2}",(i+1), tableNumber, (i+1)*tableNumber);
            }

            Console.ReadLine();
        }
    }
}
