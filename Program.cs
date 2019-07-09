using System;
using System.Collections.Generic;

namespace chapter4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() { "Mercury", "Mars" };

            planetList.Add("Jupiter");
            planetList.Add("Saturn");
            List<string> lastTwo = new List<string>() { "Uranus", "Neptune" };
            planetList.AddRange(lastTwo);
            planetList.Insert(2, "Earth");
            planetList.Insert(1, "Venus");
            planetList.Add("Pluto");
            planetList.Remove("Pluto");

            List<string> rockyPlanets = planetList.GetRange(0, 4);

            rockyPlanets.ForEach(planet => Console.WriteLine($"{planet} is a rocky planet"));

            planetList.ForEach(planet => Console.WriteLine(planet));
            // Console.WriteLine(planetList);

            Random random = new Random();
            List<int> numbers = new List<int> {
            random.Next(6),
            random.Next(6),
            random.Next(6),
            random.Next(6),
            random.Next(6),
            random.Next(6),
            };
            for (int i = 0; i < numbers.Count; i++)
            {
                // Determine if the current loop index is contained inside of the `numbers` list. Print a message to the console indicating whether the index is in the list.

                if (numbers.Contains(i))
                {
                    Console.WriteLine($"numbers list contains {i}");
                }
                else
                {
                    Console.WriteLine($"numbers list does not contain {i}");
                }

            }
        }
    }
}
