using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> names = new List<string>();

            Console.Write("What is your first name: ");
            string firstNames = Console.ReadLine();
            names.Add(firstNames);

            Console.WriteLine("Do you want to enter another name(yes/no): ");
            string answer = Console.ReadLine();
            
              while(answer == "yes")
                { 
                    Console.Write("What is your first name: ");
                    firstNames = Console.ReadLine();
                    names.Add(firstNames);
                    Console.WriteLine("Do you want to enter another name(yes/no): ");
                    answer = Console.ReadLine();
                }

              if (answer == "no")
                { 
                    foreach (var name in names)
                    {
                     Console.WriteLine($"Hello {name} ");
                    }
                }

              else
                {
                  Console.WriteLine("That is not a valid answer.");
                }
                
            Console.ReadLine();
        }
    }
}
