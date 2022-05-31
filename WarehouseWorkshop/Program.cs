namespace WarehouseWorkshop
{
    public class Program
    {
        static void Main(string[] args)
        {
            Warehouse GenerateStockList()
            {
                List<string> foodStuffs = new List<string> { "Apple", "Banana", "Carrot", "Doughnut", "Egg", "Fig", "Garlic", "Ham", "Ice Cream", "Jam", "Ketchup", "Lemon", "Mango", "Nectarine", "Orange", "Pineapple", "Quinoa", "Radish", "Soup", "Tomato", "Udon", "Vegetable Oil", "Watermelon", "Xmas Cookies", "Yoghurt", "Zuchini" };
                List<Item> items = new List<Item> { };
                Warehouse stockList = new Warehouse(new Dictionary<Item, int>());

                //number generator
                Random random = new Random();
                decimal NextDecimal(Random random, double minValue, double maxValue, int decimalPlaces)
                {
                    double randNumber = random.NextDouble() * (maxValue - minValue) + minValue;
                    return Convert.ToDecimal(randNumber.ToString("f" + decimalPlaces));
                }

                //populate items with Name and cost
                foreach (var food in foodStuffs)
                {
                    decimal randomDecimal = NextDecimal(random, 0.01, 9.99, 2);
                    items.Add(new Item(food, randomDecimal));
                }

                //populate stockList with items + amount
                foreach (var item in items)
                {
                    int num = random.Next(10);
                    stockList.Add(item, num);
                }
                return stockList;
            }

            Warehouse stockList = GenerateStockList();

            stockList.LogCurrentStock();
            stockList.LogItemDetails();
        }
    }
}