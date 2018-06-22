using System;
using System.Collections.Generic;


namespace list_quickstart
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayingWithStrings();
        }
        public static void PlayingWithStrings(){
            var names = new List<string> { "Chris", "Ana", "Felipe" };
            Console.WriteLine("\n ******* Original List: *******".ToUpper());
            foreach (var name in names)
            {
                Console.WriteLine($"{name}");
            }

            //add and remove from the list using dot notation with Add and remove
            names.Add("Chriswf");
            names.Add("Atlas");
            names.Add("Billy");
            Console.WriteLine($" \n Removing: {names[1]} and {names[2]}");
            names.Remove("Ana");
            names.Remove("Felipe");
            Console.WriteLine($"    Adding: {names[1]} and {names[2]}");
            Console.WriteLine($"        There are now {names.Count} names in this list");
            Console.WriteLine(" \n ******* Modified List: *******".ToUpper());
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name}!");
            }

            // Console.Write($"\nChriswf is at the index of {names.IndexOf("Chriswf")} \n");

            Console.Write("\nSearching for user Chriswf...\n");
            foreach (var name in names)
            {
                if (name != "Chriswf")
                {
                    Console.Write($"This isn't Chriswf, this is {name} with the index of {names.IndexOf(name)}!\n");
                }
                else Console.Write($"You found Chriswf at index 1!\n");
            }

            Console.Write("\nNow let's sort that list!\n");
            names.Sort();
            foreach (var name in names)
            {
                Console.Write($"{name} \n");
            }
        }
    }
}
