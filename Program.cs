using System;
using System.Collections.Generic;


namespace list_quickstart
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string> { "Chris", "Ana", "Felipe" };
            Console.WriteLine("\n ******* Original List: *******".ToUpper());
            foreach (var name in names)
            {
                Console.WriteLine($"{name}");
            }

            //add and remove from the list using dot notation with Add and remove
            names.Add("Chriswf");
            names.Add("Atlas");
            Console.WriteLine($" \n Removing: {names[1]} and {names[2]}");
            names.Remove("Ana");
            names.Remove("Felipe");
            Console.WriteLine($" Adding: {names[1]} and {names[2]}");
            Console.WriteLine(" \n ******* Modified List: *******".ToUpper());
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name}!");
            }
        }
    }
}
