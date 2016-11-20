using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GodtyckligLonerevision
{
    class Program
    {
        static void Main(string[] args)  // Anropa metoden ReadInt(), om antalet är minst två, anropa ProcessSalaries och skicka antal löner att berbetas som ett argument. 
        {
            int numberOfSalaries = 0;

            do
            {
                try 
                {
                    numberOfSalaries = ReadInt("Ange antal löner att mata in: "); // Om antalet löner är mindre än två. 
                    if (numberOfSalaries < 2)
                    {
                        throw new Exception();
                    }
                    else
                    {
                        ProcessSalaries(numberOfSalaries); 
                    }
                }
                catch
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nDu måste mata in minst två löner för att kunna göra en beräkning!\n");
                    Console.ResetColor();
                }
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("\nTryck tangent för ny beräkning - Esc avslutar.\n");
                Console.ResetColor(); 
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape); 
        }

        static void ProcessSalaries(int count) 
        {
            // Läser in lönerna. 
            int[] salaries = new int[count];

            for (int i = 0; i < salaries.Length; i++)
            {
                salaries[i] = ReadInt("Ange lön nummer nummer " + (int)(i + 1) + ": "); 

                if (salaries[i] <= 0)
                {
                    throw new FormatException(); 
                }
            }

            //Räknar ut medianen. 
            int medianSalary;

            List<int> copyOfSalaries = new List<int>(salaries); // Skapar en kopia för att den ursprunliga inmatningen inte ska sorteras. 

            copyOfSalaries.Sort();
                                                       
            if (copyOfSalaries.Count % 2 == 0)               //  Om antalet löner är jämt. 
            {
                medianSalary = (copyOfSalaries[copyOfSalaries.Count / 2] + copyOfSalaries[copyOfSalaries.Count / 2 - 1]) / 2;
            }
            else // Om antalet löner är udda. 
            {
                medianSalary = copyOfSalaries[copyOfSalaries.Count / 2];
            }

            // Presenterar resultatet. 
            Console.WriteLine("\n------------------------------------------"); 
            Console.WriteLine("Medianlön:     {0, 10:c0}", medianSalary); 
            Console.WriteLine("Medellön:      {0, 10:c0}", salaries.Average());
            Console.WriteLine("Lönespridning: {0, 10:c0}", salaries.Max() - salaries.Min());
            Console.WriteLine("------------------------------------------");
            
            // Skriver ut lönerna i den ursprunliga ordningen, tre löner per rad. 
            for (int i = 0; i < salaries.Length; i++) 
            {
                Console.Write("{0, 10} ", salaries[i]); 
                if ((i + 1) % 3 == 0)                   // Om i+1 är delbart med 3, infoga ny rad. 
                {
                    Console.WriteLine(); 
                }
            }
            Console.WriteLine(); 
        }
        static int ReadInt(string prompt)  
        {
            string input = null;

            while (true)                
            {
                try
                {                                   
                    Console.Write(prompt);
                    input = Console.ReadLine();
                    return int.Parse(input);  
                }
                catch (FormatException)
                {
                    Console.BackgroundColor = ConsoleColor.Red;                                 // Om anv matar in t.ex. en sträng. 
                    Console.WriteLine("\nFel '{0}' kan inte tolkas som ett heltal.\n", input);
                    Console.ResetColor(); 
                } 
            }
        }
    }
}
