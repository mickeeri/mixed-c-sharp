using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3a_Palindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.ForegroundColor = ConsoleColor.White; 
                
                Console.Write("Ange en textrad (endast små bokstäver): ");
                string line = Console.ReadLine();
                string lineBackwards = null;

                // Goes through the line backwards and creates a new string. 
                for (int i = line.Length - 1; i >= 0; --i)
                {
                    lineBackwards += line[i];
                }
                
                // Compares the two string after removing the spaces. 
                if (lineBackwards.Replace(" ", "") == line.Replace(" ", "")) 
                {
                    Console.WriteLine("\nTextraden \"{0}\" är ett palindrom.\n", line);
                }
                else
                {
                    Console.WriteLine("\nTyvärr, textraden \"{0}\" är inte ett palindrom.\n", line);
                }

                Console.ForegroundColor = ConsoleColor.White; 
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Tryck tangent för ny beräkning - Esc avslutar\n");
                Console.ResetColor(); 

            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);

            Console.WriteLine(); 
        }
    }
}
