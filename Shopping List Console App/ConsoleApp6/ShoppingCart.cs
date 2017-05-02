using System.Collections.Generic;

namespace ConsoleApp6
{
    public class ShoppingCart
    {
        public string Name { get; set; }

        public List<ItemsClass> Items { get; set; }

        //Instantiate both lists in the constructor before they are going to be used so that it does not have to be instantiated every time someone calls a new store instance
        public ShoppingCart()
        {
            Items = new List<ItemsClass>();
        }
    }
}
