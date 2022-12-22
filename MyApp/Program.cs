using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    namespace MyApp
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.Write("Enter your city: ");
                string? cityName = Console.ReadLine();
                Console.Write("Please enter the zipcode: ");
                string? myZipCode = Console.ReadLine();
                Console.WriteLine("Your city is " + cityName + " and your zip code is " + myZipCode + ".");

                Console.ReadLine();
            }
        }
    }



