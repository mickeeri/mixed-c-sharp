using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GodtyckligLonerevisionB
{
    class Program
    {
        static void Main(string[] args) 
        {
            do
            {
                try
                {
                    int numberOfSaleries = ReadInt("Ange antal löner att mata in: ");
                    if (numberOfSaleries < 2)
                    {
                        throw new ArgumentException();
                    }
                    Console.WriteLine();

                    int[] salaries = ReadSalaries(numberOfSaleries);

                    ViewResults(salaries);
                }
                
                catch (ArgumentException)
                {
                    ViewMessage("\nDu måste mata in minst två löner för att kunna göra en beräkning!", true); 
                }

                ViewMessage("\nTryck tangent för ny beräkning - Esc avslutar.\n", false);

            } while (IsContinuing() == true);
        }
        
        static int GetDispertion(int[] source) 
        {
            return source.Max() - source.Min(); 
        }
        
        static int GetMedian(int[] source)
        {
            int medianSalary;

            List<int> copyOfSalaries = new List<int>(source); // Kopia av arrayen eftersom inte den ursprungliga inmatningen ska sorteras. 
            copyOfSalaries.Sort(); 
            
            if (copyOfSalaries.Count % 2 == 0) // Om antalet löner är jämt. 
            {
                medianSalary = (copyOfSalaries[copyOfSalaries.Count / 2] + copyOfSalaries[copyOfSalaries.Count / 2 - 1]) / 2;
            }
            else // Om antalet löner är udda. 
            {
                medianSalary = copyOfSalaries[copyOfSalaries.Count / 2];
            }
            
            return medianSalary; 
        }
        
        static bool IsContinuing()  
        {
            if (Console.ReadKey(true).Key != ConsoleKey.Escape)
            {
                return true;
            }
            else
            {
                return false; 
            }
        }
        
        static int ReadInt(string prompt) // Metod som läser in antalet och själva lönerna.
        {
            string input = null;
            int result; 

            while (true)
            {
                try
                {
                    Console.Write(prompt);
                    input = Console.ReadLine();
                    result = int.Parse(input); 
                    return result;
                }

                catch
                {
                    ViewMessage("\nFEL! '" + input + "' kan inte tolkas som ett heltal!\n", true); 
                } 
            }
        }
        
        static int[] ReadSalaries(int count)
        {
            int[] salaries = new int[count];

            for (int i = 0; i < salaries.Length; i++)
            {
                salaries[i] = ReadInt("Ange lön nummer " + (int)(i + 1) + ": ");
            }

            return salaries; 
        }
        
        static void ViewMessage(string message, bool isError) 
        {
            if (isError == false)
            {
                Console.ForegroundColor = ConsoleColor.White; // Vanligt meddelande.
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(message);
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White; // Felmeddelande. 
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine(message);
                Console.ResetColor(); 
            }
        }
        
        static void ViewResults(int[] salaries)
        {
            Console.WriteLine("\n------------------------------------------");
            Console.WriteLine("Medianlön:     {0, 9:c0}", GetMedian(salaries));
            Console.WriteLine("Medellön:      {0, 9:c0}", salaries.Average());
            Console.WriteLine("Lönespridning: {0, 9:c0}", GetDispertion(salaries));
            Console.WriteLine("------------------------------------------");

            for (int i = 0; i < salaries.Length; i++)
            {
                Console.Write("{0, 7} ", salaries[i]);
                if ((i + 1) % 3 == 0)
                {
                    Console.WriteLine(); 
                }
            }
            Console.WriteLine(); 
        }
    }
}
