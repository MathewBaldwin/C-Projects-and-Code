using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            double All = 0;
            double num1 = 0;
            double num2 = 1;
            double sum = 1;

            //Fib sequence
            while (num1 <= 15000000000000)
            {
                sum = num1 + num2;
                num1 = num2;
                num2 = sum;
                //Console.WriteLine(num2);
               

                //Find the total of all the even numbers in the sequence
                if(num2 % 2 == 0)
                {
                    double total = num2;
                    All += total;

                    Console.WriteLine(All);
                }
            }
            Console.ReadLine();
        }
    }
}
