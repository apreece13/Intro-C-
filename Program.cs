using System;
using System.Collections.Generic;

namespace intro
{
    class Program
    {
        static void Main(string[] args)
        {

            // Intro 

            // Console.WriteLine("What's your name?");

            // string firstName = Console.ReadLine();

            // int milesPerHour = 30;

            // Console.WriteLine($"Hello, {firstName}! I can't believe you can run {milesPerHour} mph!");

            // if(milesPerHour > 20){
            //     Console.WriteLine("You are extremely fast.");
            // } else {
            //     Console.WriteLine("You're pretty fast, but not as fast as Pat!");
            // }

            // List<string> students = new List<string>() {
            //     "Megan", "Damon", "Chase", "Tekisha",
            //     "Castle", "Mark", "Keith", "Adam",
            //     "Patrick", "Hannah", "Mike"
            // };

            // // Can't do this easily with a base array
            // students.Add("Melanie");
            // students.Insert(3, "Simon");

            // if (students.Contains("Chase")) {
            //     Console.WriteLine("Must be cohort 13");
            // }

            // // This looks a lot like JavaScript!
            // students.ForEach(stu => Console.WriteLine(stu));

            // Data Structure List

            // List<string> planetList = new List<string>(){"Mercury", "Mars"};

            // planetList.Add("Jupiter");
            // planetList.Add("Saturn");

            // List<string> otherPlanets = new List<string>(){"Uranus", "Neptune"};

            // Console.WriteLine();
            // foreach(string planet in planetList){
            //     Console.WriteLine(planet);
            // }

            // Console.WriteLine("\nAddRange(planetList)");
            // planetList.AddRange(otherPlanets);

            // planetList.Insert(1, "Venus");
            // planetList.Insert(2, "Earth");
            // planetList.Add("Pluto");

            // Console.WriteLine();
            // foreach(string planet in planetList){
            //     Console.WriteLine(planet);
            // }

            // List<string> rockyPlanets = new List<string>();
            // string[] output = planetList.GetRange(0,4).ToArray();

            // Console.WriteLine("Rocky Planets");
            // foreach(string planets in output){
            //     Console.WriteLine(planets);
            // }

            // planetList.Remove("Pluto");

            // foreach(string planet in planetList){
            //     Console.WriteLine(planet);
            // }

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

                // Console.WriteLine(numbers.Count);
                // Console.WriteLine(random.Next(6));
                Console.WriteLine(i);
                
                    // if(numbers = i){
                    //     Console.WriteLine("number list contains", numbers.i);
                    // }
                    // else
                    // {
                    //     Console.WriteLine("numbers list does not contain", numbers.i);
                    // }

                    
                    
                

            }


        }

        private static void AddRange(List<string> planetList, List<string> otherPlanets)
        {
            throw new NotImplementedException();
        }
    }
}
