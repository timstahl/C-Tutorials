using System;

namespace HomeWorkTypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();

            Console.WriteLine("This program tells you how old you were in the year 2000.");
            Console.Write("What is your current age: ");

            string ageText = Console.ReadLine();

            bool isAgeValid = int.TryParse(ageText, out int age);

            if (isAgeValid == true)
            {

                if (age < 19)
                {
                    Console.WriteLine("You weren't even born yet lol!!");
                }
                else
                {
                    age -= 19;
                    Console.WriteLine($"In the year 2000 you were {age} years old!");
                }

            }

            else
            {
                Console.WriteLine("Please enter the correct input!");
            }
                

        }
    }
}
