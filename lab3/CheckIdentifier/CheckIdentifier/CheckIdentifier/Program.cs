using System;

namespace CheckIdentifier
{
    public class Program
    {
        static bool IsEnglishLetter(char ch)
        {
            return (ch >= 'A' && ch <= 'Z') || (ch >= 'a' && ch <= 'z');
        }
        static bool IsDigit(char ch)
        {
            return (ch >= '0' && ch <= '9');
        }

        public static int Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Wrong parameters count");
                return 1;
            }
            else
            {
                string inputString = args[0];
                if (inputString.Length > 0)
                {
                    if (IsDigit(inputString[0]))
                    {
                        Console.WriteLine("no");
                        Console.WriteLine("identifier cannot start with a digit");
                        return 1;
                    }
                    for (int i = 1; i < inputString.Length; i++)
                    {
                        if (!IsEnglishLetter(inputString[i]) && !IsDigit(inputString[i]))
                        {
                            Console.WriteLine("no");
                            Console.WriteLine("identifier must contain only letters or numbers");
                            return 1;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("no");
                    Console.WriteLine("Empty string is not identifier");
                    return 1;
                }
            }
            Console.WriteLine("yes");
            return 0;
        }
    }
}
