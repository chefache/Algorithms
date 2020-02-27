using System;

namespace Recursive_Array_Sum
{
    class Program
    {
        static void Main()
        {
            var numbers = new[] { 1, 2, 3, 4, 5 };
            var result = Sum(numbers, 0);
            Console.WriteLine(result);
        }

        static int Sum(int[] arr, int index)
        {
            if (index == arr.Length)
            {
                return 0;
            }

            Console.WriteLine("Before recursion " + index);

            var currentSum = arr[index] + Sum(arr, index + 1);

            Console.WriteLine("After recursion " + index);


            return currentSum;
        }
    }
}
