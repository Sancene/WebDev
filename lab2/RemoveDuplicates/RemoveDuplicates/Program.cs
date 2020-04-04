using System;
using System.Linq;

namespace RemoveDuplicates
{
    class Program
    {
        static int Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Incorrect number of argumens!");
                Console.WriteLine("Usage: remove_duplicates.exe <input string>");
                return 1;
            }

            string inputString = args[0];
            inputString = new string(inputString.Distinct().ToArray());
            Console.WriteLine(inputString);

            return 0;
        }
    }
}
