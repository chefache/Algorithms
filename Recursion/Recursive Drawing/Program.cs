using System;

namespace Recursive_Drawing
{
    class Program
    {
        static void Main(string[] args)
        {
            int figureSize = int.Parse(Console.ReadLine());
            Print(figureSize);
            
        }

        static void Print( int index)
        {
            if (index == 0)
            {
                return;
            }
            Console.WriteLine(new string('*', index));

            Print(index - 1);

            Console.WriteLine(new string('#', index));
        }
    }
}
