using System.Linq;
using System;

namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> videogames = new List<string>();
            List<string> newgames = new List<string>();

            videogames.Add("Assassin's Creed");
            videogames.Add("Doom");
            videogames.Add("FortNight");
            videogames.Add("Tomb Raider");
            videogames.Add("Stryker");
            

            newgames = videogames.OrderBy(x => x.Length).ToList();

            foreach(string game in videogames) 
            {
                Console.WriteLine(game);           
            }

            Console.WriteLine("-------------------------------------");
            foreach (string game in newgames)
            {
                Console.WriteLine(game);
            }
            
        }
    }
}
