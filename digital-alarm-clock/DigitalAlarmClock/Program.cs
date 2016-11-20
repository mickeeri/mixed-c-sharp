using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalAlarmClock
{
    class Program
    {
        // Metod som instansierar objekt av klassen AlarmClock och testar konstruktorerna, egenskaperna och metoderna. 
        static void Main(string[] args)
        {
            Console.WriteLine("Test 1.\nTest av standardkonstruktorn.\n");
            AlarmClock test1 = new AlarmClock();
            Console.WriteLine(test1);

            Console.WriteLine(HorizontalLine); 
            Console.WriteLine("Test 2.\nTest av konstruktorn med två parametrar.\n");
            AlarmClock test2 = new AlarmClock(9, 42);
            Console.WriteLine(test2);

            Console.WriteLine(HorizontalLine);
            Console.WriteLine("Test 3.\nTest av konstruktorn med fyra parametrar.\n");
            AlarmClock test3 = new AlarmClock(13, 24, 7, 35);
            Console.WriteLine(test3);

            ViewTestHeader("Test 4.\nStäller befintlig AlarmClock-objekt till 23:58 och låter den gå 13 minuter.\n");
            Run(new AlarmClock(23, 58, 7, 35), 13);

            ViewTestHeader("Test 5.\nStäller befintligt AlarmClock-objekt till tiden 6:12 och alarmtiden 6:15\noch låter den gå 6 minuter.\n");
            Run(new AlarmClock(6, 12, 6, 15), 6);

            Console.WriteLine(HorizontalLine);
            Console.WriteLine("Test 6.\nTestar egenskaperna så att undantag kastas då tid och alarmtid tilldelas\nfelaktiga värden.");
            Console.WriteLine();
            
            AlarmClock test6 = new AlarmClock();

            for (int i = 1; i <= 4; i++)
            {
                try
                {
                    switch (i)
                    {
                        case 1: test6.Hour = 24;
                            break;

                        case 2: test6.Minute = 60;
                            break;

                        case 3: test6.AlarmHour = 24;
                            break;

                        case 4: test6.AlarmMinute = 60;
                            break;
                    }
                }
                catch (Exception ex)
                {
                    ViewErrorMessage(ex.Message);
                }
            }
            Console.WriteLine();

            Console.WriteLine(HorizontalLine); 
            Console.WriteLine("Test 7.\nTestar konstruktorer så att undantag kan kastas då tid och alarmtid tilldelas\nfelaktiga värden.");
            Console.WriteLine();
            for (int i = 1; i <= 4; i++)
            {
                try
                {
                    switch (i)
                    {
                        case 1: // Hour har felaktigt värde. 
                            new AlarmClock(24, 59);
                            break;

                        case 2: // Minute har felaktigt värde. 
                            new AlarmClock(23, 60);
                            break;

                        case 3: // Alarmhour har felaktigt värde. 
                            new AlarmClock(23, 59, 24, 59);
                            break;

                        case 4: // AlarmMinute har felaktigt värde. 
                            new AlarmClock(23, 59, 23, 60);
                            break;
                    }
                }
                catch (Exception ex)
                {
                    ViewErrorMessage(ex.Message);
                }
            }
            Console.WriteLine();
        }

        private static string HorizontalLine = "═══════════════════════════════════════════════════════════════════════════════";

        private static void Run(AlarmClock ac, int minutes)
        {
            for (int i = 0; i < minutes; i++)
            {
                bool result = ac.TickTock();

                if (result == true)
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.White; 
                    Console.WriteLine("{0}\tBEEP!\tBEEP!\tBEEP!\tBEEP!", ac);
                    Console.ResetColor(); 
                }
                
                Console.WriteLine(ac);
            }
        }

        private static void ViewErrorMessage(string message)
        {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;                     
                    Console.WriteLine(message);
                    Console.ResetColor(); 
        }

        private static void ViewTestHeader(string header)
        {
            Console.WriteLine(HorizontalLine);
            Console.WriteLine(header);
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" ╔═════════════════════════════════════════╗ ");
            Console.WriteLine(" ║       Väckarklockan URLED <TM>          ║ ");
            Console.WriteLine(" ║        Modellnr: 1DV402S2L2A            ║ ");
            Console.WriteLine(" ╚═════════════════════════════════════════╝ ");
            Console.ResetColor();
        }
    }
}
