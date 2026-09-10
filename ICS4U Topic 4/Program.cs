using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICS4U_Topic_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RandomIntegers();
        }

        public static void RandomIntegers()
        {
            Random generator = new Random();
            int maxValue = 0;
            int minValue = 0;

            bool maxValueValid = false;
            bool minValueValid = false;

            // Title

            Console.WriteLine($"Random Integer");
            Console.WriteLine();

            // Enter Values

            while (!maxValueValid)
            {
                Console.WriteLine("Enter the maximum value: ");
               

                if (!Int32.TryParse(Console.ReadLine(), out maxValue))
                {
                    Console.WriteLine("Invalid input.");
                    continue;
                }
                else
                {

                
                
                }

            }

        }

    }
}
