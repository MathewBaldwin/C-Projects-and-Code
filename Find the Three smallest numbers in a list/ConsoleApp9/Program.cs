using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program and ask the user to supply a list of comma separated numbers(e.g 5, 1, 9, 2, 10).
            //If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; 
            //otherwise, display the 3 smallest numbers in the list.

            Console.WriteLine("Enter numbers seperated by a comma");
            string userInput = Console.ReadLine();
            var revisedInput = userInput.Split(',');

            var numbersList = new List<int>();

            var threeSmallestList = new List<int>();


            foreach (string i in revisedInput)
            {
                numbersList.Add(Convert.ToInt32(i));
            }

            if (numbersList.Count < 5)
            {
                Console.WriteLine("Invalid List, Try again?");
            }


            while (threeSmallestList.Count < 3)
            {
                int startingNumber = numbersList[0];
                foreach (var number in numbersList)
                {
                    if(startingNumber > number)
                    {
                        startingNumber = number;
                    }

                }

                numbersList.Remove(startingNumber);
                threeSmallestList.Add(startingNumber);
            }
            

            foreach(int n in threeSmallestList)
            {
                Console.WriteLine(n);
            }






        }
    }
}


