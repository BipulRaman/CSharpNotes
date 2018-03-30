using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var sqVal = Calculate(2, 3, out int add, out int multiply);
        }

        public static int Calculate (int x, int y, out int sum, out int product)
        {
            sum = x + y;
            product = x * y;
            return x * x;
        }
    }
}
