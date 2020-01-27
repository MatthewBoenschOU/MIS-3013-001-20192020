//Matthew Boensch
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputAndFormatting
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter your first name >>)");
            string FirstName = Console.ReadLine();

            Console.WriteLine("Please enter your favorite number >>");
            String FavNumberAsString = Console.ReadLine();

            int FavNumber = Convert.ToInt32(FavNumberAsString);
            //Combine 2 steps into 1

            int FavNumberTimes10 = 10 * FavNumber;

            string message = FirstName + " You have a favorite number of " + FavNumber.ToString("N3") + " and if you multiply that by 10 you get " + FavNumberTimes10.ToString("C3");

            if (FavNumber == 7 || FavNumber == 3)
            {
                Console.WriteLine("How original are you?");
            }

            else if (FavNumber == 13)
            {
                Console.WriteLine("WHAT? That is an unlucky #");
            }
            else
            {
                Console.WriteLine(message);
            }

            switch (FavNumber)

            {
                case 7:
                    Console.WriteLine("How original are you?");
                    break;
                case 13:
                    Console.WriteLine("WHAT? That is an unlucky #");
                    break;
                default:
                    Console.WriteLine(message);

                    break;

                    Console.WriteLine(message);

            }

            if (FavNumber % 2 == 0)
            {
                Console.WriteLine("Your favorite number is even");
            }
            else
            {
                Console.WriteLine("You favorite number is odd");
            }
            Console.ReadKey();
        }
    }
}
        