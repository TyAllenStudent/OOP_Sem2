using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOChallengeWeek4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Swinburne Shape Area Calculator 2018.");

            //The menu options using a boolean value and while loop
            bool Menu = true;

            while (Menu)
            {
                Console.WriteLine("Please select an option: ");
                Console.WriteLine();
                Console.WriteLine("1. Create Square");
                Console.WriteLine("2. Create Rectangle");
                Console.WriteLine("3. Exit Console");

                int MenuChoice;

                //A while loop to handle incorrect menu entries
                while (!int.TryParse(Console.ReadLine(), out MenuChoice) || MenuChoice < 1 || MenuChoice > 3)
                {
                    Console.WriteLine("Please select a menu option between 1 and 3");
                }

                try
                {

                    //The menu using a switch statement
                    switch (MenuChoice)
                    {
                        case 1:

                            //Square choice
                            //Requesting input values from the user
                            Console.WriteLine("Please enter the colour of your desired square: ");
                            string inputS = Console.ReadLine();
                            Console.WriteLine("Please enter the side length of your desired square");
                            int inputS2 = int.Parse(Console.ReadLine());

                            if (inputS2 < 1)
                            {
                                throw new LessThanOneException();
                            }

                            //Instanciating the class
                            Square square = new Square(inputS, inputS2);

                            //Calling the class functions
                            Console.WriteLine($"The area of your square is: {square.GetArea()}");
                            Console.WriteLine($"The perimeter of your square is: {square.GetPerimeter()}");
                            Console.WriteLine();

                            break;

                        case 2:

                            Console.WriteLine("Please enter the colour of your desired rectangle: ");
                            string inputR = Console.ReadLine();
                            Console.WriteLine("Please enter the first side length of your desired rectangle");
                            int inputR2 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Please enter the second side length of your desired rectangle");
                            int inputR3 = int.Parse(Console.ReadLine());

                            Rectangle WreckedAnglez = new Rectangle(inputR, inputR2, inputR3);
                            Console.WriteLine($"The area of your rectangle is: {WreckedAnglez.GetArea()}");
                            Console.WriteLine($"The perimeter of your rectangle is: {WreckedAnglez.GetPerimeter()}");
                            Console.WriteLine();

                            break;

                        case 3:
                            Console.WriteLine("Goodbye");
                            Menu = false;
                            break;

                        default:
                            Console.WriteLine("Please enter a valid option");
                            Console.WriteLine();

                            break;

                    }
                    Console.WriteLine("Press any key to exit");
                }

                catch (LessThanOneException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}