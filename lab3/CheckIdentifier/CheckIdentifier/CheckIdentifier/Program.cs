using System;

namespace CheckIdentifier
{
    public class Program
    {
        public static bool IsEnglishLetter(char ch)
        {
            return (ch >= 'A' && ch <= 'Z') || (ch >= 'a' && ch <= 'z');
        }
        public static bool IsDigit(char ch)
        {
            return (ch >= '0' && ch <= '9');
        }
        public static bool CheckIdentifier(string identifier)
        {
            if (identifier.Length > 0)
            {
                if (IsDigit(identifier[0]))
                {
                    Console.WriteLine("no");
                    Console.WriteLine("identifier cannot start with a digit");
                    return false;
                }
                for (int i = 1; i < identifier.Length; i++)
                {
                    if (!IsEnglishLetter(identifier[i]) && !IsDigit(identifier[i]))
                    {
                        Console.WriteLine("no");
                        Console.WriteLine("identifier must contain only letters or numbers");
                        return false;
                    }
                }
            }
            else
            {
                Console.WriteLine("no");
                Console.WriteLine("Empty string is not identifier");
                return false;
            }
            Console.WriteLine("yes");
            return true;
        }
        static int Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Wrong parameters count");
                return 1;
            }

            string inputString = args[0];

            if (!CheckIdentifier(inputString))
            {
                return 1;
            }
            return 0;
        }
    }
}
