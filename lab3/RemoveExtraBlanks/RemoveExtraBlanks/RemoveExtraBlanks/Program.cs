using System;
using System.IO;
using System.Text.RegularExpressions;

namespace RemoveExtraBlanks
{
    public class Program
    {
        public static string RemoveExtraBlanks(string str)
        {
            string withoutExtraBlanks = "";
            bool blankFlag = false;
            str = str.Trim();
            for (int i = 0; i < str.Length; ++i)
            {
                if (str[i] != ' ' && str[i] != '\t')
                {
                    withoutExtraBlanks += str[i];
                    blankFlag = false;
                }
                else
                {
                    if (!blankFlag)
                    {
                        withoutExtraBlanks += str[i];
                        blankFlag = true;
                    }
                }
            }
            return withoutExtraBlanks;
        }
        public static int Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("Incorrect number of arguments\n");
                return 1;
            }
            if (!File.Exists(args[0]) || !File.Exists(args[1]))
            {
                Console.WriteLine("File not found\n");
                return 1;
            }
            string[] input = System.IO.File.ReadAllLines(args[0]);
            StreamWriter output = new StreamWriter(args[1]);
            foreach (string line in input)
            {
                output.WriteLine(RemoveExtraBlanks(line));
            }
            output.Close();
            return 0;
        }
    }
}
