using System;
using System.Net;

namespace Lab4_Exponents
{
    class Program
    {
        static void Main(string[] args)
        {
            bool mathAgain = true;
            double userNum;


            while (mathAgain == true)
            {
                Console.WriteLine("Hello! Please enter a number to be squared and cubed.");

                while (!double.TryParse(Console.ReadLine(), out userNum))
                {
                    Console.WriteLine("Please enter a number to be squared and cubed.");
                }

                Calculate(userNum);

                mathAgain = RunAgain();
            }

        }

        public static void Calculate(double num)
        {
            Console.WriteLine("Number \t Squared \t Cubed \t");
            Console.WriteLine("=======  ======= \t ======= \n");

            for (int i = 1; i <= num; i++)
            {
                double power = Math.Pow(i, 2);
                double cube = Math.Pow(i, 3);

                Console.WriteLine($"{i} \t {power} \t\t {cube}");

            }
        }

        public static bool RunAgain()
        {
            bool mathAgain = true;

            Console.WriteLine("Would you like to try again?");
            char choice = char.Parse(Console.ReadLine().ToLower());


            if (char.ToLower(choice) == 'y')
            {
                mathAgain = true;
            }
            else if (char.ToLower(choice) == 'n')
            {
                mathAgain = false;
            }
            else
            {
                Console.WriteLine("Would you like to try again? (y/n)");
                choice = char.Parse(Console.ReadLine().ToLower());
            }

            return mathAgain;
        }
    }
}
