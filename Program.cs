using System;

namespace tmp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseNumber(-6780));
            Console.WriteLine(ReverseNumber(9563));
        }

        static int ReverseNumber(int numberToReverse)
        {
            int result = 0;
            int temp;

            while (numberToReverse > 9 || numberToReverse < -9)
            {
                temp = numberToReverse % 10;
                numberToReverse /= 10;
                result = result * 10 + temp;
            }
            result = result * 10 + numberToReverse;

            return result;
        }
    }
}