using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Addition of 15 and 31 = " + Add(15, 31));
            Console.WriteLine("Multiplication of 15 and 31 = " + Mult(15, 31));
            Console.Read();

        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Mult(int num1, int num2)
        {
            return num1 * num2;
        }
    }
}
