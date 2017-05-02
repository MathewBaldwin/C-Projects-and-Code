using System.Collections.Generic;


namespace ConsoleApp6
{
    public class ItemsClass
    {
        public string ItemName { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }

        //public decimal Total { get; set; }

        public override string ToString()
        {
            return "Quantity: " + Quantity + "   Name: " + ItemName + "   Price: ${0:C}" + Price;
        }

        public string Display
        {
            get
            {
                return string.Format("{0} - {1} - ${2},", ItemName, Quantity, Price);
            }
        }
    }
}
