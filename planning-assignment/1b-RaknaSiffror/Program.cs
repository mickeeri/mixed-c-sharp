using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1b_RaknaSiffror
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ange ett positivt heltal: ");

            try
            {
                int number = int.Parse(Console.ReadLine());
                int zeros = 0;
                int oddNumbers = 0;
                int evenNumbers = 0;

                // Converting to string to be able to use .Length.  
                string stringNumber = number.ToString();

                for (int i = 0; i < stringNumber.Length; i++)
                {
                    if (stringNumber[i] == '0')
                    {
                        zeros++;
                    }
                    // If the number is even. 
                    else if ((int)stringNumber[i] % 2 == 0)
                    {
                        evenNumbers++;
                    }
                    else
                    {
                        oddNumbers++;
                    }
                }

                Console.WriteLine("\n-------------------------");
                Console.WriteLine("\nAntal nollor: {0}\nAntal udda: {1}\nAntal jämna: {2}\n", zeros, oddNumbers, evenNumbers);
            }
            catch (FormatException)
            {
                Console.WriteLine("\nFel! Ange ett heltal.\n");
            }
            catch (OverflowException)
            {
                Console.WriteLine("\nOBS! Talet är för stort.\n"); 
            }


        }
    }
}
