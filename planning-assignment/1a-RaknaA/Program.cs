using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1a_RaknaA
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            int lowerCaseA = 0;
            int upperCaseA = 0;

            Console.Write("Mata in en textrad: ");
            line = Console.ReadLine();

            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] == 'a')
                {
                    lowerCaseA++;
                }
                if (line[i] == 'A')
                {
                    upperCaseA++;
                }
            }

            Console.WriteLine("\nAntal A: {0}\nAntal a: {1}\n", upperCaseA, lowerCaseA); 
        }
    }
}
