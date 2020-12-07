using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_Converter
{
    public class UnitConverter
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nSimple unit converter");
            Console.WriteLine("=============================\n");

            Converter();
        }


        /// <summary>
        /// Has the user choose which conversion to do, does the conversion and prints the result
        /// </summary>
        /// <param name="pick">The number representing the conversion the user chooses</param>
        /// <param name="amount">The amount of chosen units to convert</param>
        static void Converter()
        {
            int pick;
            Double amount;

            Console.WriteLine("Type a number and press enter to choose a conversion");
            Console.WriteLine("1: Kilometers to miles:");
            Console.WriteLine("2: Miles to kilometers");

            pick = Convert.ToInt16(Console.ReadLine());

            if (pick == 1)
            {
                Console.WriteLine("Enter the amount of kilometers:");
                amount = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(amount + " kilometers equals to " + amount * 0.621371192 + " miles");
            }

            if (pick == 2)
            {
                Console.WriteLine("Enter the amount of miles:");
                amount = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(amount + " miles equals to " + amount * 1.609344 + " kilometers");
            }

            if (pick > 2)
            {
                Console.WriteLine("\n!!The program does not support this input!!");
            }

            Console.WriteLine("\nPress any button to close the program");
            Console.ReadKey();
        }
    }  
}