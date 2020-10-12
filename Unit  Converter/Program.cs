using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * @author Sampo Kupiainen
 * @version 9.10.2020
 */
namespace Unit_Converter
{
    public class UnitConverter
    {
        static void Main(string[] args)
        {
            //Prints the name of the app and its maker
            Console.WriteLine("\nSimple unit converter");
            Console.WriteLine("=============================\n");
            Console.WriteLine("Made by Sampo Kupiainen, 2020\n");
            Console.WriteLine("=============================\n");

            //Calls the actual converter
            Converter();
        }


        //Asks for input from the user and then converts with the given parameters
        static void Converter()
        {
            //Declaring variables
            String unit1;
            Double amount;
            String unit2;

            //Ask the user to enter the amount and name of the unit to be converted
            Console.WriteLine("Enter a number and unit separated with a space:");
            var paramList = Console.ReadLine().Split(' '); // https://stackoverflow.com/questions/36266643/ask-user-to-enter-parameters-in-console-application
            amount = Convert.ToDouble(paramList[0]);
            unit1 = paramList[1];


            //Ask the user for the unit to convert to
            Console.WriteLine("Enter the unit to convert to:");
            unit2 = Console.ReadLine();

            //if-else-statement checking the inputs
            if (unit1 == "km" && unit2 == "mi")
            {
                Console.WriteLine(amount + " kilometers equals to " + amount * 0.621371192 + " miles");
            }

            else if (unit1 == "mi" && unit2 == "km")
            {
                Console.WriteLine(amount + " miles equals to " + amount * 1.609344 + " kilometers");
            }

            else
            {
                Console.WriteLine("ERROR");
            }
        }
    }
}