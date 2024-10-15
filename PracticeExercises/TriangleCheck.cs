using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeExercises
{
    internal class TriangleCheck
    {
        public void MainTriangleCheck() {
            Console.WriteLine("Please insert first angle: ");
            int angle1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please insert second angle: ");
            int angle2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please insert third angle: ");
            int angle3 = Convert.ToInt32(Console.ReadLine());

            int angleSum = angle1 + angle2 + angle3;

            Console.WriteLine(angleSum == 180 ? "Valid" : "Invalid!");

            Console.ReadLine();
        }
    }
}
