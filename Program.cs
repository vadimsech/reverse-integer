using System;

namespace tmp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 90120;
            int result = 0;
            int temp;
            while (i > 9 || i < -9)
            {
                temp = i % 10;
                i /= 10;
                result = result * 10 + temp;
            }          
            result = result * 10 + i;
            Console.WriteLine(result);            
        }
    }
}