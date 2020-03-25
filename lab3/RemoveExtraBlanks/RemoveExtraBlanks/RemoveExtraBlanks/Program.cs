using System;
using System.IO;

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
                string stringNoSpaces = String.Join(" ", line.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries));
                string stringNoTab = String.Join("\t", stringNoSpaces.Split(new string[] { "\t" }, StringSplitOptions.RemoveEmptyEntries));
                output.WriteLine(stringNoTab.Trim());
            }
            output.Close();
            return 0;
        }
    }
}
