namespace WarehouseWorkshop
{
    public class Item
    {
        public string Name { get; }
        public decimal Price { get; }

        public Item(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public void LogItemDetails()
        {
            Console.WriteLine($"\tItem name: {Name}, Price: £{Price}");
        }
    }
}