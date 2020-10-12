using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * @author Sampo Kupiainen
 * @version 2.0
 * @created 08.10.2020 (DD/MM/YYY)
 * @updated 13.10.2020 (DD/MM/YYY)
 */
namespace Unit_Converter
{
    public class UnitConverter
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nSimple unit converter");
            Console.WriteLine("=============================\n");
            Console.WriteLine("Made by Sampo Kupiainen, 2020\n");
            Console.WriteLine("=============================\n");

            Converter();
        }


        /// <summary>
        /// Has the user choose which conversion to do, does the conversion and prints the result
        /// </summary>
        /// <param name="pick">Represents the conversion the user chooses</param>
        /// <param name="amount">Represents the amount of chosen units to convert</param>
        static void Converter()
        {
            int pick;
            Double amount;

            Console.WriteLine("Type a number and press enter to choose a conversion");
            Console.WriteLine("1: Kilometers to miles:");
            Console.WriteLine("2: Miles to kilometers");

            pick = Convert.ToInt16(Console.ReadLine());

            if(pick == 1)
            {
                Console.WriteLine("Enter the amount of kilometers:");
                amount = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(amount + " kilometers equals to " + amount * 0.621371192 + " miles");
            }

            if(pick == 2)
            {
                Console.WriteLine("Enter the amount of miles:");
                amount = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(amount + " miles equals to " + amount * 1.609344 + " kilometers");
            }
            Console.WriteLine("\nPress any button to close the program");
            Console.ReadKey();
        }
    }  
}