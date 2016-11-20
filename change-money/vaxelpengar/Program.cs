using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vaxelpengar
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                double subtotalAmount;         // Det exakta priset
                uint totalAmount;                   // Priset efter avrundning. 
                uint cash;                      // Erhållna beloppet. 
                uint change;
                double roundingOffAmount;

                subtotalAmount = ReadPositiveDouble("Ange totalsumma     : ");
                totalAmount = (uint)Math.Round(subtotalAmount);                      
                cash = ReadUint("Ange erhållet belopp: ", totalAmount);
                roundingOffAmount = totalAmount - subtotalAmount;
                change = cash - totalAmount;

                Console.WriteLine("\nKVITTO");
                Console.WriteLine("-----------------------------------------------------");
                Console.WriteLine("Toalt            : {0, 20:c}", subtotalAmount);
                Console.WriteLine("Öresavrundning   : {0, 20:c}", roundingOffAmount);
                Console.WriteLine("Att betala       : {0, 20:c0}", totalAmount);
                Console.WriteLine("Kontant          : {0, 20:c0}", cash);
                Console.WriteLine("Tillbaka         : {0, 20:c0}", change);
                Console.Write("-------------------------------------------------------\n");
                
                SplitIntoDenominations(change);
                Console.WriteLine(); 

                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Tryck tangent för ny beräkning - Esc avslutar\n");
                Console.ResetColor(); 

            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }


        static double ReadPositiveDouble(string prompt) // Metod som läser in totalsumma. Säkerställer att priset efter avrundning är större eller lika med 1. Annars ska anv få en ny chans. 
        {
            string input = null;
            double subtotal = 0d;

            while (true)
            {
                try
                {
                    Console.Write(prompt);
                    input = Console.ReadLine();
                    subtotal = double.Parse(input);

                    if (subtotal < 1)
                    {
                        throw new FormatException(); // Om värdet är negativt. 
                    }

                    return subtotal;
                }
                catch (FormatException)
                {
                    Console.BackgroundColor = ConsoleColor.Red; 
                    Console.WriteLine("\nFEL! '{0}' kan inte tolkas som en giltig summa pengar.\n", input);
                    Console.ResetColor(); 
                }
            }
        }

        static uint ReadUint(string prompt, uint minValue) // Metod som läser in det erhållna beloppet. Säkerställ att anv anger ett värde som inte är mindre än totalsumman, eller något som inte är ett heltal. 
        {
            string input = null;  // Har en variabel av datatypen string för att jag det inte ska stå "0 kan inte tolkas..." i eventuellt felmeddelande. 
            uint cash = 0;
            
            while (true)
	        {
	            try
                {
                    Console.Write(prompt);
                    input = Console.ReadLine(); 
                    cash = uint.Parse(input);

                    if (cash < minValue)  
                    {
                        throw new OverflowException();
                    }
                
                    return cash;
                } 

                catch (FormatException)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nFEL! '{0}' kan inte tolkas som en giltig summa pengar.\n", input); 
                    Console.ResetColor(); 
                }

                catch (OverflowException)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nFEL! {0:c0} är ett för litet belopp.\n", minValue);
                    Console.ResetColor(); 
                }
           }
     }

        static void SplitIntoDenominations(uint change) // Metod som delar upp växeln och presenterar vilka valörer som ska lämnas tillbaka. 
        {
            
            uint numberOfBillsAndCoins; 
            
            uint[] denominations = new uint[] { 500, 100, 50, 20, 10, 5, 1 };

            foreach (uint denomination in denominations)
            {
                if (denomination < change && change > 0)
                {
                    numberOfBillsAndCoins = change / denomination;
                    change %= denomination;

                    if (denomination >= 20)
                    {
                        Console.WriteLine("{0,3}-lappar: {1,2}", denomination, numberOfBillsAndCoins);  
                    }
                    else
                    {
                        Console.WriteLine("{0,3}-kronor: {1,2}", denomination, numberOfBillsAndCoins);
                    }
                }
            }

        }
        
    }
}
