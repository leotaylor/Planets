using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> PlanetList = new List<string>() { "Mercury", "Mars" };
            PlanetList.Add("Jupiter");
            PlanetList.Add("Saturn");

            List<string> LastTwoPlanets = new List<string> { "Neptune", "Uranus" };

            PlanetList.AddRange(LastTwoPlanets);

            PlanetList.Insert(1, "Venus");
            PlanetList.Insert(2, "Earth");

            PlanetList.Add("Pluto");

            List<string> rockyPlanets = PlanetList.GetRange(0, 4);

            PlanetList.Remove("Pluto");


            var spacecraftDictionary = new Dictionary<string, List<string>>()
            {
                { "Mariner", new List<string> { "Mercury", "Venus", "Mars" } },
                { "Messenger", new List<string> { "Mercury", "Venus"} },
                { "Pioneer" , new List<string> { "Venus", "Jupiter", "Saturn" } },
                { "Galileo" , new List<string> { "Venus", "Jupiter" } },
                { "Magellan" , new List<string> { "Venus" } },
                { "Cassini", new List<string> { "Venus", "Jupiter", "Saturn" } },
                { "Viking", new List<string> { "Mars" } },
                { "Voyager", new List<string> { "Jupiter", "Saturn", "Uranus", "Neptune" } },
                { "Ulysses", new List<string> { "Jupiter" } },
                { "New Horizons", new List<string> { "Jupiter", "Pluto" } }
            };

            // Dictionary<string, List<string>> spacecraftDictionary = new Dictionary<string, List<string>>();
            // spacecraftDictionary.Add("Mariner", new List<string> { "Mercury", "Venus", "Mars" });
            // spacecraftDictionary.Add("Messenger", new List<string> { "Mercury", "Venus" });
            // spacecraftDictionary.Add("Pioneer", new List<string> { "Venus", "Jupiter", "Saturn" });
            // spacecraftDictionary.Add("Galileo", new List<string> { "Venus", "Jupiter" });
            // spacecraftDictionary.Add("Magellan", new List<string> { "Venus" });
            // spacecraftDictionary.Add("Cassini", new List<string> { "Venus", "Jupiter", "Saturn" });
            // spacecraftDictionary.Add("Viking", new List<string> { "Mars" });
            // spacecraftDictionary.Add("Voyager", new List<string> { "Jupiter", "Saturn", "Uranus", "Neptune" });
            // spacecraftDictionary.Add("Ulysses", new List<string> { "Jupiter" });
            // spacecraftDictionary.Add("New Horizons", new List<string> { "Jupiter", "Pluto" });

            foreach(var planet in PlanetList)
            {
                var answer = planet + ": ";

                var craftVists = new List<string>();

                foreach(var spacecraft in spacecraftDictionary)
                {
                    var craft = spacecraft.Key;
                    var visitedPlanets = spacecraft.Value;

                    if (visitedPlanets.Contains(planet))
                    {
                        craftVists.Add(craft);
                    }
                }

                answer = answer + string.Join(", ", craftVists);

                Console.WriteLine(answer);
                Console.ReadLine();
            }
        }
    }
}
