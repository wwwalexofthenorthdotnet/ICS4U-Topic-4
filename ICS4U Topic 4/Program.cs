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
            // Uncomment what you want to check

            //RandomIntegers();
            //DiceRoller();
            RandomDecimal();


        }

        public static void RandomIntegers()


        {
            Random generator = new Random();
            int maxValue = 0;
            int minValue = 0;

            bool maxValueValid = false;
            bool minValueValid = false;

            int randomNumber = 0;

            // Title

            Console.WriteLine($"Random Integer");
            Console.WriteLine();

            // Enter Values

            while (!maxValueValid)
            {
                Console.Write("Enter the maximum value (Decimal Invalid): ");


                if (!Int32.TryParse(Console.ReadLine(), out maxValue))
                {
                    Console.WriteLine("Invalid input.");
                    continue;
                }
                else
                {
                    maxValueValid = true;
                }

            }

            Console.Clear();

            while (!minValueValid)
            {
                Console.Write("Enter the minimum value (Decimal Invalid): ");
                if (!Int32.TryParse(Console.ReadLine(), out minValue))
                {
                    Console.WriteLine("Invalid input.");
                    continue;
                }
                else if (minValue > maxValue)
                {
                    Console.WriteLine("Minimum value cannot be greater than maximum value.");
                    continue;
                }
                else
                {
                    minValueValid = true;
                }
            }

            Console.Clear();

            randomNumber = generator.Next(minValue, maxValue + 1);

            for (int i = 0; i < 5; i++)
            {

                Console.WriteLine($"Your random number is : {randomNumber}");
            }
        }

        public static void DiceRoller()
        {
            Random generator = new Random();

            int dice1 = 0;
            int dice2 = 0;

            bool finish = false;
            bool start = false;

            string input = "";


            // Title

            Console.WriteLine("Dice Roller");
            Console.WriteLine();

            while (!finish)
            {
                Console.Write("Press any key to roll the dice: ");
                Console.ReadKey();
                start = true;

                while (start)
                {

                    dice1 = generator.Next(1, 7);
                    dice2 = generator.Next(1, 7);

                    Console.Clear();

                    Console.WriteLine($"You rolled a {dice1} and a {dice2}.");

                    Console.WriteLine();

                    Console.ReadLine();

                }
            }
        }

        public static void RandomDecimal()
        {
            Random generator = new Random();
            int maxValue = 0;
            int minValue = 0;

            int roundValue = 0;

            bool maxValueValid = false;
            bool minValueValid = false;
            bool roundValueValid = false;

            double randomNumber = 0;

            // Title

            Console.WriteLine($"Random Decimal");
            Console.WriteLine();

            // Enter Values

            while (!maxValueValid)
            {
                Console.Write("Enter the maximum value : ");


                if (!Int32.TryParse(Console.ReadLine(), out maxValue))
                {
                    Console.WriteLine("Invalid input.");
                    continue;
                }
                else
                {
                    maxValueValid = true;
                }

            }

            Console.Clear();

            while (!minValueValid)
            {
                Console.Write("Enter the minimum value : ");
                if (!Int32.TryParse(Console.ReadLine(), out minValue))
                {
                    Console.WriteLine("Invalid input.");
                    continue;
                }
                else if (minValue > maxValue)
                {
                    Console.WriteLine("Minimum value cannot be greater than maximum value.");
                    continue;
                }
                else
                {
                    minValueValid = true;
                }
            }

            Console.Clear();

            while (!roundValueValid)
            {
                Console.Write("How many decimal points? : ");
                if (!Int32.TryParse(Console.ReadLine(), out roundValue))
                {
                    Console.WriteLine("Invalid input.");
                    continue;
                }
                else if (roundValue <= 0)
                {
                    Console.WriteLine("You Can't Round to under 0 decimal points.");
                    continue;
                }
                else
                {
                    roundValueValid = true;
                }
            }

            randomNumber = generator.Next(minValue, maxValue) + generator.NextDouble();

            Console.WriteLine($"Your random number is : {Math.Round(randomNumber, roundValue)}");
        }
    }
}
