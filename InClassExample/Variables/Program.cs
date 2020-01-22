//Matthew Boensch
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a string named firstname
            string FirstName;

            //Assign a value to firstname (Use your name)
            FirstName = "Matthew";

            //Create an int named favoritenumber and assign your favorite number to it
            int FavoriteNumber = 3;

            double CrazyNumber = 7.6767 * FavoriteNumber;

            string LastName = "Boensch";
            string FullName = FirstName + " " + LastName;

            //cw = Console.WriteLine()
            Console.WriteLine(FullName + " Has the favorite number of " + FavoriteNumber 
                + " \nwhich equates to a crazy number of " + CrazyNumber);

            //MAKE IT DYNAMIC


            Console.ReadKey();      
        }
    }
}
