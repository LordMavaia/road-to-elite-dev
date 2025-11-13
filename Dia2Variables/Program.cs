// See https://aka.ms/new-console-template for more information
using System;

namespace Day2Variables
{
    class Programdot
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome! Let's practice variables.");
            Console.WriteLine("Hello, World!");
            
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();  // lee texto del usuario

            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine()); // lee y convierte a número

            Console.Write("Are you learning C#? (true/false): ");
            bool learning = Convert.ToBoolean(Console.ReadLine()); // lee y convierte a booleano
            int futuraEdad = age + 5;

            Console.WriteLine($"Nice to meet you, {name}! You are {age} years old and learning: {learning}");
            Console.WriteLine($"La edad en 5 años sera de {futuraEdad}");

               if (age > 30)
            {
                Console.WriteLine("Mayor a 30");
            }
            else if (age <= 30 && age > 18)
            {
                Console.WriteLine("Jovencito");
            }
            else
            {
                Console.WriteLine("Otra edad");
            }

        }
    }
}