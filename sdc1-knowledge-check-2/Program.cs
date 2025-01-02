using System;
using System.Collections.Generic;

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many records do you want to add? ");
            int numberOfRecords;

            // Error handling for numeric input
            while (!int.TryParse(Console.ReadLine(), out numberOfRecords) || numberOfRecords <= 0)
            {
                Console.WriteLine("Please enter a valid positive number for the number of records.");
            }

            var recordList = new List<CatFood>();
            for (int i = 0; i < numberOfRecords; i++)
            {
                var catFood = new CatFood();

                // Error handling for each property
                Console.Write("Enter the value for Name: ");
                catFood.Name = Console.ReadLine();
                while (string.IsNullOrEmpty(catFood.Name))
                {
                    Console.WriteLine("Name is required. Please enter a valid value.");
                    catFood.Name = Console.ReadLine();
                }

                Console.Write("Enter the value for Description: ");
                catFood.Description = Console.ReadLine();
                while (!string.IsNullOrEmpty(catFood.Description) && catFood.Description.Length < 10)
                {
                    Console.WriteLine("Description must be at least 10 characters long. Please enter a valid value.");
                    catFood.Description = Console.ReadLine();
                }

                Console.Write("Is it Kitten Food (true/false)? ");
                bool kittenFood;
                while (!bool.TryParse(Console.ReadLine(), out kittenFood))
                {
                    Console.WriteLine("Please enter a valid boolean value (true/false).");
                }
                catFood.KittenFood = kittenFood;

                recordList.Add(catFood);
            }

            // Print out the list of records using Console.WriteLine()
            foreach (var record in recordList)
            {
                Console.WriteLine(record);
            }
        }
    }

    public class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }

    public class CatFood : Product
    {
        public bool KittenFood { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Description: {Description}, KittenFood: {KittenFood}";
        }
    }
}
