using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your age: ");
            string ageText = Console.ReadLine();

            //ageText += 10;
            //Console.WriteLine($"You are going to be {ageText} years old in 10 years");

            //int age = int.Parse(ageText);
            //age += 10;
            
            bool isAgeValid = int.TryParse(ageText, out int age);
            if (isAgeValid)
            {
                age += 10;
                Console.WriteLine($"You are going to be {age} years old in 10 years"); 
            }
            else
            {
                Console.WriteLine("That is not a valid age.");
            }

            Console.ReadLine();
        }
    }
}
