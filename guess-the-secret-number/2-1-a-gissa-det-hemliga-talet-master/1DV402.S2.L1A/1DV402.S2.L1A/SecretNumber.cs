using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S2.L1A
{
    public class SecretNumber
    {
        // Fält 
        private int _count; // Antalet gissningar sedan det hemliga talet slumpats fram. 
        private int _number; // Det hemliga talet. 
        
        // Konstant
        public const int MaxNumberOfGuesses = 7;

        // Konstruktor
        public SecretNumber()
        {
            Initialize(); 
        }

        // Metoder
        public void Initialize()
        {
            _count = 0;

            Random myRandom = new Random();
            _number = myRandom.Next(1, 101);
        }

        public bool MakeGuess(int number) // Parametern number innehållet det gissade talets värde. 
        {
            // Om gissningen är mindre än 1 eller större än 100. 
            if (number < 1 || number > 100)
            {
                throw new ArgumentOutOfRangeException();
            }
            // Om fler gissningar än sju. 
            if (_count >= MaxNumberOfGuesses) 
            {
                throw new ApplicationException();
            }

            else
            {
                _count++;

                if (number > _number)
                {
                    Console.WriteLine("{0} är för högt.", number);
                    
                    if (_count == MaxNumberOfGuesses)
                    {
                        // Skrivs ut när gissningarna är slut. 
                        Console.WriteLine("Du har {0} gissningar kvar. Det hemliga talet är {1}.", _count-MaxNumberOfGuesses, _number);
                    }
                    return false;  
                }
                
                else if (number < _number)
                {
                    Console.WriteLine("{0} är för lågt.", number);
                    if (_count == MaxNumberOfGuesses)
                    {
                        // Skrivs ut när gissningarna är slut. 
                        Console.WriteLine("Du har {0} gissningar kvar. Det hemliga talet är {1}.", _count-MaxNumberOfGuesses, _number);
                    }
                    return false; 
                }
                
                // Om gissningen varken är för låg eller för hög är den rätt. 
                else 
                {
                    Console.WriteLine("RÄTT GISSAT! Du klarade det på {0} gissningar", _count);
                    return true; 
                }
            }
        }
    }
}
