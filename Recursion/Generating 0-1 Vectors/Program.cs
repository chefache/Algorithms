using System;

namespace Generating_0_1_Vectors
{
    class Program
    {
        static void Main()
        {
            var arr = new int[8];
            Generate(0, arr);
        }

        static void Generate(int index, int[] arr)
        {
            if (index == arr.Length)
            {
                Console.WriteLine(string.Join(" ", arr));
            }
            else
            {
                for (int i = 0; i <= 1; i++)
                {
                    arr[index] = i;
                    Generate(index + 1, arr);
                }
            }
        }
    }
}
