using System;

namespace Recursive_Factorial
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            long result = Factorial(number);

            Console.WriteLine(result);
        }

        static long Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            return n + Factorial(n - 1);
        }
    }
}
