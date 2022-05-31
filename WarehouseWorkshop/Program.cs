namespace WarehouseWorkshop
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Item> items = new List<Item> { new Item("Banana", 1.5M), new Item("Apple", 1.0M), new Item("Carrot", 1.75M) };

            foreach (var item in items)
            {
                item.LogItemDetails();
            }
        }
    }
}