using System;
using System.IO;
using System.Text.RegularExpressions;

namespace RemoveExtraBlanks
{
    public class Program
    {
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
                Regex regex = new Regex(@"[ , \t]+");
                string line2 = regex.Replace(line, " ");
                output.WriteLine(line2.Trim());
            }
            output.Close();
            return 0;
        }
    }
}
