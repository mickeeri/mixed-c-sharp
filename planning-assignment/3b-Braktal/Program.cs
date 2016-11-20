using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.White; 
                string line = ("------------");

                Fraction fraction1 = new Fraction(2, 4);
                Fraction fraction2 = new Fraction(6, 8);
                // ToString
                Console.WriteLine("\nToString");
                Console.WriteLine(line);
                Console.WriteLine(fraction1);
                Console.WriteLine(fraction2);                

                // Add
                Console.WriteLine("\nAdd");
                Console.WriteLine(line);
                Console.WriteLine("{0} + {1} = {2}", fraction1, fraction2, fraction1.Add(fraction2)); 
                Console.WriteLine(); 

                // Multiply
                Console.WriteLine("Multiply");
                Console.WriteLine(line);
                Console.WriteLine("{0} * {1} = {2}", fraction1, fraction2, fraction1.Multiply(fraction2)); 
                Console.WriteLine(); 
                
                // IsEqualTo
                Console.WriteLine("IsEqualTo");
                Console.WriteLine(line);
                if (fraction1.IsEqualTo(fraction2) == true)
                {
                    Console.WriteLine("Instanserna representerar samma bråktal.\n");
                }
                else
                {
                    Console.WriteLine("Instanserna representerar INTE samma bråktal.\n"); 
                }
                                
                // IsNegative
                Console.WriteLine("IsNegative");
                Console.WriteLine(line);
                if (fraction1.IsNegative() == true)
                {
                    Console.WriteLine("Bråktalet {0} är negativt.\n", fraction1);
                }
                else
                {
                    Console.WriteLine("Bråktalet {0} är INTE negativt.\n", fraction1);
                }
            }
            catch (ArgumentException ex)
            {
                Console.BackgroundColor = ConsoleColor.Red; 
                Console.WriteLine(ex.Message);
                Console.BackgroundColor = ConsoleColor.Black; 
            }
            Console.WriteLine(); 
            
            
        }
    }
}
