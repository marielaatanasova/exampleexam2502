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
            List<string> commands = new List<string>();
            string input = Console.ReadLine();

            while (input != "ReadMe")
            {
                commands.Add(input);
                input = Console.ReadLine();

            }
            string[] results = new string[commands.Count];
            int index = -1; //index of rows
            foreach (string command in commands)
            {
                index++;
                char[] ch = command.ToCharArray();
                Array.Reverse(ch);
                string reversestr = string.Join("", ch);
                if (reversestr.Equals(command))
                {
                    results[index] = "YES";
                    continue;
                }
                List<string> codes = command.Split('.').ToList();
                for (int i = 0; i < codes.Count; i++)
                {

                    foreach (string code in codes)
                    {
                        if (codes[i].Length != 3 || codes[i].Contains(' ') || codes[i].Contains('_'))
                        {
                            results[index] = "NO";
                            continue;
                        }

                    }
                    Console.WriteLine(string.Join("\n", results));
                }
            }


        }
//            for (int i = 0; i < commands.Count; i++)
//            {
//                int pos = commands[i].IndexOf('.');
//                if (pos == -1 || pos!=3)
//                {
//                    results[i] = "NO";
//                    continue;
//                } //sega sum sig che imam tochka .
//                string part1 = commands[i].Substring(0,pos-1);
//                string part2 = commands[i].Substring(pos + 1);

//                if (part2.Length != 3 || part1.Contains(' ') || part1.Contains('_') || part2.Contains(' ') || part2.Contains('_'))
//                {
//                    results[i] = "NO";
//                    continue;
//                }
//                char[] ch = commands[i].ToCharArray();
//                Array.Reverse(ch);
//                string reversestr = string.Join("", ch);
//                if (reversestr.Equals(commands[i]))
//                {
//                    results[i] = "YES";
//                    continue;
//                }
//            }
//            Console.WriteLine(string.Join("\n",results));
//        }
//    }
//}
