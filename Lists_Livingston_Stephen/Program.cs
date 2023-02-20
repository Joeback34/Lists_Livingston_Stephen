using System;
using System.Collections.Generic;

namespace Lists_Livingston_Stephen
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> games = new List<string> /// creates new list of called games.
            {
                "CS:GO",
                "Halo 3",
                "Borderlands 3",
                "Fifa 22",
                "Minecraft"
            };

            string[] otherGames = new string[] // new string array called otherGames.
            {
                "Tiny Tina's Wonderlands",
                "Farcry 3"
            };

            foreach (string game in games) // prints games to the console.
            {
                Console.WriteLine(game);
            }

            Console.WriteLine($"\nGames in list: {games.Count}"); // Prints games from the list and counts how many games are in the list.

            games.AddRange(otherGames); /// Adds a range of the array to the games list.

            Console.WriteLine($"\nGames in list: {games.Count}");

            if (games.Contains("Halo")) /// Prints to the console if games list contains Halo esle it adds Halo to the list.
            {
                Console.WriteLine("\nMASTER CHIEF IS IN THE HOUSE!");

            }
            else
            {
                games.Add("Halo");
            }

            int myInt = 6; /// if the integer is less than the games count it removes the game at index 6(farcry 3).

            if (myInt < games.Count)
            {
                games.RemoveAt(myInt);
            }
            else
            {
                Console.WriteLine("\nGames not found!");
            }

            Console.WriteLine("\nAll games in the list:");
            foreach (string game in games)
            {
                Console.WriteLine(game);
            }
            
            games.Sort(); /// sorts the list of games and prints the list in aplhabeticale order to the console.

            Console.WriteLine("Sorted games list:");
            foreach (string game in games)
            {
                Console.WriteLine(game);
            }

            string[] newList = new string[games.Count]; /// Copies list to newList and prints it again to the console.

            games.CopyTo(newList); // Copies games list to newList.

            games.Clear();

            Console.WriteLine("\nNew List:");
            foreach(string game in newList)
            {
                Console.WriteLine(game);
            }
        }
    }
}
