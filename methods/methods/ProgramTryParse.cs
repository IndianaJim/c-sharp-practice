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
            string friend1 = "Brad";
            string friend2 = "Doug";
            string friend3 = "Phil";

            GreetFriend(friend1);
            GreetFriend(friend2);
            GreetFriend(friend3);
            Console.Read();

            //Console.WriteLine("Addition of 15 and 31 = " + Add(15, 31));
            //Console.WriteLine("Multiplication of 15 and 31 = " + Mult(15, 31));
            //Console.Read();

        }

        public static void GreetFriend(string name)
        {
            Console.WriteLine("Hi " + name + ", my friend");
            
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
