using System;

namespace tmp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseNumber(-6780));
            Console.WriteLine(ReverseNumber(1534236469));
        }

        static int ReverseNumber(int numberToReverse)
        {
            long result = 0;
            int temp;

            while (numberToReverse > 9 || numberToReverse < -9)
            {
                temp = numberToReverse % 10;
                numberToReverse /= 10;
                result = result * 10 + temp;
            }
            result = result * 10 + numberToReverse;

            if (result >= int.MaxValue || result <= int.MinValue)
            {
                return 0;
            }

            return (int)result;
        }
    }
}