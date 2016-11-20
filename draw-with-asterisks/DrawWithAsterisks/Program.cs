using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawWithAsterisks
{
    class Program
    {
        static void Main(string[] args) 
        {

            byte asterisksInBase;

            asterisksInBase = ReadOddByte();

            RenderTriangle(asterisksInBase);

        }

        static byte ReadOddByte() // Metod som ska returnera udda heltal av typen byte (0-255). Inga udda tal ska kunna matas in. Ska ligga inom intervallet 1-79. Returnera antalet asterisker i triangelns bas. 
        {
            byte asterisksInBase;

            while (true)
            {
                try
                {
                    Console.Write("Ange det udda talet aserisker <max 79> i triangelns bas: ");
                    asterisksInBase = byte.Parse(Console.ReadLine());

                    if (asterisksInBase > 79)
                    {
                        throw new OverflowException();
                    }

                    if (asterisksInBase % 2 == 0)    // Om talet är jämt ska det bli ett undantag. Om talet INTE efter restdivision med 2 blir något annat än 0 är det udda. 
                    {
                        throw new FormatException();
                    }

                    return asterisksInBase;
                }

                catch
                {
                    Console.WriteLine();
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Det inmatade värdet är inte ett udda heltal mellan 1 och 79."); // Samma meddelande för alla undantag. 
                    Console.ResetColor();
                    Console.WriteLine();
                }
            }
        }

        static void RenderTriangle(byte cols) // Metod som ska rendera ut en triangel. 
        {
            for (int i = 2; i < cols; i++)   
            {
                Console.Write(" ");

            }

                Console.Write("*");
                Console.WriteLine();

        }
    }
}
