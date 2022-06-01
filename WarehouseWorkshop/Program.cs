namespace WarehouseWorkshop
{
    public class Program
    {
        static void Main(string[] args)
        {
            Generator setUpDataGenerator = new Generator();

            Warehouse stockList = setUpDataGenerator.NewStockList();

            stockList.LogCurrentStock();
            stockList.LogItemDetails();

            bool isShopping = true;

            while (isShopping)
            {
                Console.WriteLine("Welcome to Jordan's Supermarket!/n");
                Console.WriteLine("Are you a customer? (Y/N) ");
                string userResponse = Console.ReadLine();
                bool isCustomer = userResponse == "Y" || userResponse == "y";

                if (isCustomer)
                {
                    Client client = setUpDataGenerator.NewClient();
                    client.LogOutClientData();
                }
            }

        }
    }
}