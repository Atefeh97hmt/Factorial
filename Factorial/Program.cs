using System;


namespace Factorial
{
    class Factorial
    {
        public static void Main(string[] args)
        {
            int i, factorial = 1, number;
            Console.Write("Please enter a number: ");
            number = int.Parse(Console.ReadLine());
            for (i = 1; i <= number; i++)
            {
                factorial = factorial * i;
            }
            Console.Write("Factorial of " + number + " is " + factorial);
            Console.ReadKey();
        }
    }
}
