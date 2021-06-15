using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GokulAssignment2
{
    class Program
    {
        //Menu
        static public int Menu()
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine("             Menu              ");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("1 - Get Rectangle Length");
            Console.WriteLine("2 - Change Rectangle Width");
            Console.WriteLine("3 - Get Rectangle Width");
            Console.WriteLine("4 - Change Rectangle Length");
            Console.WriteLine("5 - Get Rectangle Perimeter");
            Console.WriteLine("6 - Get Rectangle Area");
            Console.WriteLine("7 - Exit");
            Console.WriteLine("--------------------------------");

            Console.WriteLine("\n");

            Console.WriteLine("Enter the option : ");
            int option = Convert.ToInt32(Console.ReadLine());
            return option;
        }

        //Validation
        static public Rectangle Validation()
        {
            int length = 0, width = 0;
            Rectangle rectangle;
            do
            {
                try
                {
                    Console.WriteLine("Please enter the length");
                    length = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please enter the width");
                    width = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                rectangle = new Rectangle(length, width);

                if (length == 0 || width == 0)
                {
                    Console.WriteLine("Sides must contain values greater than 0. Please enter a valid value.");
                }
            } while (length <= 0 || width <= 0);

            return rectangle;
        }

        static void Main(string[] args)
        {
            Rectangle rectangle = Validation();
            int op;
            do
            {
                op = Menu();
                switch (op)
                {
                    case 1:
                        Console.WriteLine("Length: {0}", rectangle.GetLength());
                        break;

                    case 2:
                        Console.WriteLine("Enter the new Length");
                        rectangle.SetLength(Convert.ToInt32(Console.ReadLine()));
                        Console.WriteLine("Value changed -> New Value {0}", rectangle.GetLength());
                        break;

                    case 3:
                        Console.WriteLine("Width: {0}", rectangle.GetWidth());
                        break;

                    case 4:
                        Console.WriteLine("Enter the new Width");
                        rectangle.SetWidth(Convert.ToInt32(Console.ReadLine()));
                        Console.WriteLine("Value changed -> New Value {0}", rectangle.GetWidth());
                        break;
                    case 5:
                        Console.WriteLine("Perimeter: {0}", rectangle.GetPerimeter());
                        break;

                    case 6:
                        Console.WriteLine("Area: {0}", rectangle.GetArea());
                        break;

                    default:
                        Console.WriteLine("Please enter a valid option");
                        break;
                }
            } while (op != 7);
            Console.WriteLine("Program ended!");
            Console.ReadKey();
        }
    }
}
