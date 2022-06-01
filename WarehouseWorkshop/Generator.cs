using System.Text.RegularExpressions;

namespace WarehouseWorkshop
{
    public class Generator
    {
        public Client NewClient()
        {
            string? userNameResponse;
            string userName = "";
            bool hasRecievedUserName = false;
            string? userBalanceResponse;
            decimal userBalance = 0M;
            bool hasRecievedUserBalance = false;

            bool CheckForValidName(string response)
            {
                string nameRegex = @"^(?=.{1,40}$)[a-zA-Z]+(?:[-'\s][a-zA-Z]+)*$";
                Regex regex = new Regex(nameRegex);
                Match MyMatch = Regex.Match(response, nameRegex);

                return response != null && response != "";
            }


            while (!hasRecievedUserName)
            {
                Console.WriteLine("\nWelcome new customer");
                Console.WriteLine("What is your name?");
                userNameResponse = Console.ReadLine();

                if (CheckForValidName(userNameResponse))
                {
                    userName = userNameResponse;
                    Console.WriteLine($"Lovely to meet you, {userName}.");
                    hasRecievedUserName = true;
                }
                else
                {
                    Console.WriteLine($"\nSorry, I didn't get that. Please try again.");
                }
            }

            while (!hasRecievedUserBalance)
            {
                Console.WriteLine("\nHow much money do you have in your account?");
                userBalanceResponse = Console.ReadLine();


                if (Decimal.TryParse(userBalanceResponse, out userBalance))
                {
                    hasRecievedUserBalance = true;
                }
                else
                {
                    Console.WriteLine($"Sorry, {userBalanceResponse} is not a number.\nPlease try again.");
                }
            }



            return new Client(userName, userBalance);
        }

        public Warehouse NewStockList()
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
    }
}