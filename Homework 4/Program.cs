using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask for input
            Console.WriteLine("How may factorials do you want?");
            //Store input as string
            string userInput = Console.ReadLine();
            //Convert string to integer
            int n = int.Parse(userInput);

            //Establish solution variable
            int result = 1;
            //Calculation
            for (int i = 1; i <= n; i++)
            {
                result *= i;
                Console.WriteLine("{0}! = {1}", i, result);
            }

            
            Console.ReadLine();
        }
    }
}
