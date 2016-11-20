using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1c_NastStorsta
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfInts;
            int largestNumber = 0;
            int secondLargestNumber = 0;
            int input;

            Console.Write("Ange hur många tal som ska läsas in: ");
            numberOfInts = int.Parse(Console.ReadLine());
            Console.WriteLine("\nMata in {0} tal", numberOfInts);
            Console.WriteLine("---------------------------"); 

            while (numberOfInts > 0)
            {
                input = int.Parse(Console.ReadLine());

                // If the latest input is larger than the biggest number... 
                if (input >= largestNumber) 
                {
                    // .. the second largest number is assigned the largest numbers value while the largest number takes the new inputs value. 
                    secondLargestNumber = largestNumber; 
                    largestNumber = input;
                }
                // If the latest input is smaller than the largest number, but larger than the second largest number... 
                else if (input >= secondLargestNumber)
                {
                    // ...second largest number is assigned value from the new input. 
                    secondLargestNumber = input; 
                }

                --numberOfInts;
            }

            Console.WriteLine("---------------------------"); 
            Console.WriteLine("Det näst största talet är: {0}.\n", secondLargestNumber); 
        }
    }
}
