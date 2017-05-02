namespace ConsoleApp4
{
    public class ShoppingList
    {
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Total { get; set; }

        public override string ToString()
        {
            return "Quantity: " + Quantity + "   Name: " + ItemName + "   Price: " + Price;
        }
    }
}
