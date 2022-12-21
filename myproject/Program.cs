using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myproject
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.Write("Enter first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int result = num1 + num2;

        Console.WriteLine("The sum of " + num1 + " and " + num2 + " is " +result);

        Console.ReadKey();
        }
    }
}

