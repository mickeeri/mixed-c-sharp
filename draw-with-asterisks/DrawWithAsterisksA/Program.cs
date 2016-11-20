using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawWithAsterisksA
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int rows = 1; rows <= 25; rows++)
            {
                switch (rows)
                { 
                    case 1:
                    case 4:
                    case 7:
                    case 10:
                    case 13:
                    case 16:
                    case 19:
                    case 22:
                    case 25: 
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break; 

                    case 2:
                    case 5:
                    case 8:
                    case 11:
                    case 14:
                    case 17:
                    case 20:
                    case 23: 
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        break; 

                    case 3:
                    case 6:
                    case 9:
                    case 12:
                    case 15:
                    case 18:
                    case 21:
                    case 24: 
                        Console.ForegroundColor = ConsoleColor.Green;
                        break; 
                }
                if (rows % 2 == 0)   // If the row number is even add space. 
                {
                    Console.Write(" "); 
                }
                for (int columns = 1; columns <= 39; columns++)    // For every row it writes * 39 times. 
                {
                    Console.Write("* ");
                }
                Console.WriteLine(); // When the for-loop is complete: row break.  
            }
            Console.ResetColor(); 
        }
    }
}
