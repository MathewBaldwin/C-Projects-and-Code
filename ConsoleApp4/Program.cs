using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp4
{
    public class Example
    {
        public static void Main()
        {
            //string filePath = @"C:\Users\honda\Desktop\ShoppingList.txt"


            Console.WriteLine("Do you wish to create a new shopping list?");
            string userInput = Console.ReadLine();
            Console.Clear();

            if (userInput == "yes" || userInput == "y" || userInput == "YES" || userInput == "Y")
            {

                // Create a list of items.
                List<ShoppingList> items = new List<ShoppingList>();
                

                while (true)
                {
                    Console.WriteLine("Enter a item name: ");
                    string nameinput = Console.ReadLine();
                    Console.Clear();
                    

                    Console.WriteLine("Enter a Quantity: ");
                    int quantityInput = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();

                    Console.WriteLine("Enter the price :");
                    var priceInput = Convert.ToDecimal(Console.ReadLine());
                    Console.Clear();

                    items.Add(new ShoppingList { ItemName = nameinput, Quantity = quantityInput, Price = priceInput, Total = quantityInput*priceInput});
                   
                    foreach (ShoppingList things in items)
                    {
                        Console.WriteLine(things);
                    }

                    decimal total = 0;

                    Console.WriteLine("Do you want to add another item?");
                    string userAnswer = Console.ReadLine();
                    Console.Clear();
                    
                    if (userAnswer == "no" || userAnswer == "n" || userAnswer == "NO" || userAnswer == "N" || userAnswer == null)
                    {
                        
                        foreach (ShoppingList things in items)
                        {
                            Console.WriteLine(things);
                            decimal totals = priceInput * quantityInput;
                            
                        }
                        Console.WriteLine("Your current total is: " + total);
                        //for (decimal i = 0; i < items.Count; i++)
                        //{
                        //    i += priceInput * quantityInput;
                        //    total = i;

                        //    //Console.WriteLine("Your Current Total Is: " + priceInput * quantityInput);
                        //    Console.WriteLine(total);
                        //}
                        break;
                    }
                }
            }
            else
            {
                //if (!File.Exists(@"C:\Users\honda\Desktop\ShoppingList.txt"))
                //{

                //    string newTextFile = "Hello, Missing Something?";
                //    File.WriteAllText(@"C:\Users\honda\Desktop\ShoppingList.txt", newTextFile);
                //}
                //else
                //{
                //    string readText = File.ReadAllText(@"C:\Users\honda\Desktop\ShoppingList.txt");
                //    Console.WriteLine(readText);
                //}
            }
        }
    }
}
