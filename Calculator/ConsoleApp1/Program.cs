using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicCalculater
{
    class Program
    {
        static void Main(string[] args)
        {
            Start:
            string userAnswer;
            int firstNumber;
            int secondNumber;
            int mathResult;


            Console.WriteLine("Do you want to use the Basic or Advanced calculater?");
            Console.Beep();
            userAnswer = Console.ReadLine();

            if (userAnswer == "Basic")
            {
                //Inform the user they have chosen the basic calculator and ask the user if they want to add of subtract
                Console.WriteLine("You have chosen to use the Basic Calculater!");
                Console.Beep();
                Console.Write("Enter your first number: ");
                Console.Beep();
                firstNumber = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter your second number: ");
                Console.Beep();
                secondNumber = Convert.ToInt32(Console.ReadLine());

                Console.Write("Do you want to Add or Subtract? ");
                Console.Beep();
                string addSubtract;
                addSubtract = Console.ReadLine();

                if (addSubtract == "Add")
                {
                   mathResult = firstNumber + secondNumber;
                   Console.WriteLine(firstNumber + " + "  + secondNumber +" = " + mathResult);
                }
                else if (addSubtract == "Subtract")
                {
                    mathResult = firstNumber - secondNumber;
                    Console.WriteLine(firstNumber + " - " + secondNumber + " = " + mathResult);
                }

                Console.WriteLine("Do you want to restart? (yes or no) ");
                userAnswer = Console.ReadLine();

                if (userAnswer == "yes")
                {
                    goto Start;
                }

            }
            else if (userAnswer == "Advanced")
            {
                //Inform the user that they have chosen the advanced calculator which uses multiplication and division with floating point numbers
                Console.WriteLine("Advanced Calculator allows you to multiply and divide!");
                Console.Beep();

                Console.Write("Enter your first number: ");
                Console.Beep();
                firstNumber = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter your second number: ");
                Console.Beep();
                secondNumber = Convert.ToInt32(Console.ReadLine());

                Console.Write("Do you want to Multiply or Divide? ");
                Console.Beep();
                string multiplyDivide;
                multiplyDivide = Console.ReadLine();

                if (multiplyDivide == "Multiply")
                {
                    mathResult = firstNumber * secondNumber;
                    Console.WriteLine(firstNumber + " * " + secondNumber + " = " + mathResult);
                    Console.Beep();
                }
                else if (multiplyDivide == "Divide")
                {
                    mathResult = firstNumber / secondNumber;
                    Console.WriteLine(firstNumber + " / " + secondNumber + " = " + mathResult);
                    Console.Beep();
                }


            }
            else if (userAnswer != "Basic")
            {
                Console.WriteLine("That is not a valid option! Please try again.");
                Console.Beep();
                goto Start;
            }
            
        }
    }
}

