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


            Console.WriteLine(PlanetList);
            Console.ReadLine();
        }
    }
}
