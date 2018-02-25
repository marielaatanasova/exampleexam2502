using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePhoenix4
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            Dictionary<string, List<string>> squad = new Dictionary<string, List<string>>();
       
            while (command != "Blaze it!")
            {
                List<string> creatures = command.Split(' ').ToList();
                string captain = creatures[0];
                string mate = creatures[2];
                if (squad.ContainsKey(captain))
                {
                   
                    {
                        squad[captain].Add(mate);
                    }
                }
                else
                {
                    if (mate != captain)
                    {
                        List<string> otbor = new List<string>();
                        otbor.Add(mate);
                        squad.Add(captain, otbor);
                    }
                }
                command = Console.ReadLine();
               
            }
            Dictionary<string, int> counts = new Dictionary<string, int>();
            foreach (var element in squad.Keys)
            {
                Console.WriteLine($"{element} -> {string.Join(", ", squad[element])}");
                counts.Add(element, squad[element].Count);
                // counts = counts.OrderByDescending(x => x.Value).ToDictionary(x => x.Key
                Console.WriteLine(string.Join("..", counts.Keys));
                Console.WriteLine(string.Join("..", counts.Values));
                List<string> captains = counts.Keys.Select((x =>x )).ToList();
                Console.WriteLine(string.Join("..", captains));
            }
        }
    }
}
