using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometriskaFigurerA
{
    class Program
    {
        // Metod som läser in en figurs längd och bredd. Parameterns värde bestämmer vilken figur som ska skapas. 
        private static Shape CreateShape(ShapeType shapeType)
        {
            if (shapeType == ShapeType.Ellispe)
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.ForegroundColor = ConsoleColor.White; 
                Console.WriteLine("\n==============================================");
                Console.WriteLine("=                 Ellips                     =");
                Console.WriteLine("==============================================\n");
                Console.BackgroundColor = ConsoleColor.Black;

                Ellipse myEllipse = new Ellipse(ReadDoubleGreaterThanZero("Ange längden: "), ReadDoubleGreaterThanZero("Ange bredden: "));

                return myEllipse;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.ForegroundColor = ConsoleColor.White; 
                Console.WriteLine("\n==============================================");
                Console.WriteLine("=               Rektangel                    =");
                Console.WriteLine("==============================================\n");
                Console.BackgroundColor = ConsoleColor.Black;

                Rectangle myRectangle = new Rectangle(ReadDoubleGreaterThanZero("Ange längden: "), ReadDoubleGreaterThanZero("Ange bredden: "));

                return myRectangle;                
            }

        }

        static void Main(string[] args) 
        {

            bool exit = false; 
            int menuChoice;
            Shape shape = null; 

            do
            {                
                ViewMenu();
            
                Console.Write("\nAnge menyval [0-2]: ");

                if (int.TryParse(Console.ReadLine(), out menuChoice) && menuChoice >= 0 && menuChoice <= 2)
                {
                    switch (menuChoice)
                    {
                        case 0:
                            exit = true;
                            continue;

                        case 1:
                            shape = CreateShape(ShapeType.Ellispe);
                            break;

                        case 2:
                            shape = CreateShape(ShapeType.Rectangle);
                            break;
                    }
                   
                    ViewShapeDetail(shape);
                }
                else
                {                     
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nFEL! Ange ett tal mellan 0 och 2.");
                    Console.ResetColor(); 
                }

                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("\n      Tryck tangent för att fortsätta  ");
                Console.ResetColor(); 
                Console.CursorVisible = false;
                Console.ReadKey(true);
                Console.Clear();
                Console.CursorVisible = true;

            } while (!exit);

            Console.WriteLine(); 
        }

        // Metod som returnerar ett flyttal som används för figurens längd och bredd. 
        private static double ReadDoubleGreaterThanZero(string prompt)
        {
            double value;

            do
            {
                Console.Write(prompt);

                if (double.TryParse(Console.ReadLine(), out value) && value > 0)
                {
                    return value;
                }
                
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n FEL! Ange ett flyttal större än 0.\n");
                Console.ResetColor();  

            } while (true);
            
        }

        private static void ViewMenu()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White; 
            Console.WriteLine("========================================================");
            Console.WriteLine("=                                                      =");
            Console.WriteLine("=                Geometriska figurer                   =");
            Console.WriteLine("=                                                      =");
            Console.WriteLine("========================================================");
            Console.BackgroundColor = ConsoleColor.Black; 
            Console.WriteLine("\n0. Avsluta.\n");
            Console.WriteLine("1. Ellips.\n");
            Console.WriteLine("2. Rektangel.\n");
            Console.WriteLine("========================================================");
        }

        private static void ViewShapeDetail(Shape shape)
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n==============================================");
            Console.WriteLine("=                  Detaljer                  =");
            Console.WriteLine("==============================================\n");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine(shape);
            Console.WriteLine("\n========================================================");
        }
    }
}
