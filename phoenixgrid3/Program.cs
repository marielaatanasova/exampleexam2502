using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phoenixgrid3
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> commands = new List<string>();
            while (input != "ReadMe")
            {
                commands.Add(input);
                input = Console.ReadLine();

            }
            List<string> results = new List<string>(commands.Count);
            for (int i = 0; i < commands.Count; i++)
            {
                int pos = commands[i].IndexOf('.');
                if (pos == -1 || pos!=3)
                {
                    results[i] = "NO";
                    continue;
                } //sega sum sig che imam tochka .
                string part1 = commands[i].Substring(0,pos-1);
                string part2 = commands[i].Substring(pos + 1);
                
                if (part2.Length != 3 || part1.Contains(' ') || part1.Contains('_') || part2.Contains(' ') || part2.Contains('_'))
                {
                    results[i] = "NO";
                    continue;
                }
                char[] ch = commands[i].ToCharArray();
                Array.Reverse(ch);
                string reversestr = string.Join("", ch);
                if (reversestr.Equals(commands[i]))
                {
                    results[i] = "YES";
                    continue;
                }
            }
            Console.WriteLine(string.Join("\n",results));
        }
    }
}
