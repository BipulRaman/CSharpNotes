using System;

namespace ConsoleApp
{
    class Program
    {
        // int.TryParse
        // Return bool type, out value will be 0 in case of incorrect input / string input / null input

        // int.Parse 
        // Input cannot be null or string

        // Convert.ToInt32
        // Input can be null but not string. Output for null is 0

        static void Main(string[] args)
        {
            string str = "10b";
            bool b = int.TryParse(str, out int convertedValue);
            Console.WriteLine(b);            
            Console.WriteLine(convertedValue);
            // Console.WriteLine(int.Parse(str));
            Console.WriteLine(Convert.ToInt32(str));
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
