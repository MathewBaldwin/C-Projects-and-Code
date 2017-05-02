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
            Console.WriteLine("Do you wish to create a new shopping list or add to your current one?");
            string userInput = Console.ReadLine();
            Console.Clear();

            ShoppingCart cart = new ShoppingCart();
            List<ItemsClass> ShoppingCartData = new List<ItemsClass>();
            List<decimal> totalList = new List<decimal>();

            if (userInput == "yes" || userInput == "y" || userInput == "YES" || userInput == "Y")
            {
                while (true)
                {
                    Console.WriteLine("Enter a item name: ");
                    string nameInput = Console.ReadLine();
                    Console.Clear();

                    Console.WriteLine("Enter a Quantity: ");
                    int quantityInput = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();

                    Console.WriteLine("Enter the price: ");
                    var priceInput = Convert.ToDecimal(Console.ReadLine());
                    Console.Clear();

                    cart.Items.Add((new ItemsClass { ItemName = nameInput, Quantity = quantityInput, Price = priceInput}));

                    foreach (ItemsClass item in cart.Items)
                    {

                        Console.WriteLine(item);
                    }

                    Console.WriteLine("Do you want to add another item?");
                    string userAnswer = Console.ReadLine();
                    Console.Clear();

                    if (userAnswer == "no" || userAnswer == "n" || userAnswer == "NO" || userAnswer == "N" || userAnswer == null)
                    {
                        foreach (ItemsClass item in cart.Items)
                        {

                            Console.WriteLine(item);
                        }

                        foreach (ItemsClass item in cart.Items)
                        {

                            decimal finalTotal = item.Quantity * item.Price;
                            totalList.Add(finalTotal);
                        }
                        decimal trueFinalTotal = totalList.Sum();
                        Console.WriteLine("Your total is: $",  trueFinalTotal);
                        
                        break;
                    }
                }
            }
        }
    }
}


