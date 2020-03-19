using System;
using System.Collections.Generic;

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
            HashSet<char> uniqueSet = new HashSet<char>();
            int i = 0;

            while (i <= inputString.Length - 1)
            {
                char ch = inputString[i];
                if (uniqueSet.Contains(ch))
                {
                    inputString = inputString.Remove(i, 1);
                }
                else
                {
                    uniqueSet.Add(ch);
                    i++;
                }
            }

            Console.WriteLine(inputString);

            return 0;
        }
    }
}
