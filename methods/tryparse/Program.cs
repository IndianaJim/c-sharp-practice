using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tryparse
{
    class Program
    {
        static void Main(string[] args)
        {
            string numberAsString = "128";
            int parsedValue;
            bool success = int.TryParse(numberAsString, out parsedValue);

            if (success)
                Console.WriteLine("successful parse, the number is " + parsedValue);
            else
                Console.WriteLine("Parsing failed");

            Console.Read();
        }
    }
}
