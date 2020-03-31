using System;
using System.Collections.Generic;

namespace PasswordStrength
{
    public class Program
    {
        public static int CalcPasswordStrength(string password)
        {
            int strength = 0, digitCounter = 0, upperCounter = 0, duplicatesCounter = 0, lowerCounter = 0;
            HashSet<char> unique = new HashSet<char>();
            HashSet<char> duplicates = new HashSet<char>();
            strength = password.Length * 4;

            for (int i = 0; i < password.Length; i++)
            {
                if (!((password[i] >= 'A' && password[i] <= 'Z') || (password[i] >= 'a' && password[i] <= 'z')) && !(Char.IsDigit(password[i])))
                {
                    Console.WriteLine("Password can only contain english symbols or numbers");
                    return 1;
                }
                if (Char.IsDigit(password[i]))
                {
                    digitCounter++;
                }
                else
                {
                    if (password[i] >= 'A' && password[i] <= 'Z')
                    {
                        upperCounter++;
                    }
                    else
                    {
                        lowerCounter++;
                    }
                }
                if (!unique.Contains(password[i]))
                {
                    unique.Add(password[i]);
                }
                else
                {
                    if (!duplicates.Contains(password[i]))
                    {
                        duplicates.Add(password[i]);
                        duplicatesCounter++;
                    }
                    duplicatesCounter++;
                }
            }

            strength += 4 * digitCounter;

            if (upperCounter != 0)
            {
                strength += (password.Length - upperCounter) * 2;
            }

            if (lowerCounter != 0)
            {
                strength += (password.Length - lowerCounter) * 2;
            }

            if (digitCounter == 0 || (lowerCounter + upperCounter) == 0)
            {
                strength -= password.Length;
            }

            strength -= duplicatesCounter;
            return strength;
        }
        static int Main(string[] args)
        {
            if (args.Length != 1)
            {
                System.Console.WriteLine("Error: Wrong parameters count \n Usage: PasswordStrength.exe <password>");
                return 1;
            }
            string Password = args[0];
            System.Console.WriteLine(CalcPasswordStrength(Password));
            return 0;
        }
    }
}
