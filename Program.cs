using System;
using System.Collections.Generic;


namespace list_quickstart
{
    class Program
    {
        static void Main(string[] args)
        {
             var names = new List<string> { "Chris", "Ana", "Felipe" };
             names.Add("Chriswf");
             names.Add("Atlas");
             names.Remove("Ana");
             names.Remove("Felipe"); //add and remove from the list using dot notation with Add and remove

            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
        }
    }
}
