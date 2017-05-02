using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter N");
            int N = int.Parse(Console.ReadLine());
            for (int row=1; row <=N; row++)
            {
                for (int col = row; col <=row + N - 1;)
                {
                    Console.Write(col + " ");
                    col++;
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}

    

