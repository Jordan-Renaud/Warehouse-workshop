namespace WarehouseWorkshop
{
    public class Warehouse
    {
        public Dictionary<Item, int> StockList { get; }

        public Warehouse(Dictionary<Item, int> stockList)
        {
            StockList = stockList;
        }

        public void LogCurrentStock()
        {
            Console.WriteLine("\nCurrent stock in Warehouse:");
            foreach (var item in StockList)
            {
                Console.WriteLine($"\tItem: {item.Key.Name}, Amount: {item.Value}");
            }

        }

        public void LogItemDetails()
        {
            Console.WriteLine("\nFood names with their prices in stock in Warehouse:");
            foreach (var item in StockList)
            {
                item.Key.LogItemDetails();
            }

        }

        public void Add(Item item, int amount)
        {
            StockList.Add(item, amount);
        }
    }
}