using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3__re_upload_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask for input
            Console.WriteLine("Please give a value n");
            //Store input as string
            string userInput = Console.ReadLine();
            //Convert string to integer
            int n = int.Parse(userInput);

            //Establish solution variable
            int result = 1;
            //Calculation
            for (int i = n; i >= 1; i--)
                result *= i;

            Console.WriteLine(result);
            Console.ReadLine();
       



        }
    }
}
