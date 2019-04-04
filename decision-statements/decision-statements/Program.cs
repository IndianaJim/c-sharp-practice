using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decision_statements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter temp: ");
            var temperature = Console.ReadLine();
            
            if(int.TryParse(temperature,out int temperatureNumber))
            {
                if(temperatureNumber < 40)
                {
                    Console.WriteLine("Take a coat!");
                }else if (temperatureNumber == 40)
                {
                    Console.WriteLine("It's 40 degress out!");
                }else
                {
                    Console.WriteLine("Warm out!");
                }
            }else Console.WriteLine("That's not a number!");

            Console.Read();
        }
    }
}
