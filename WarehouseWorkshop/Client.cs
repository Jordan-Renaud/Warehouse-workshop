namespace WarehouseWorkshop
{
    public class Client
    {
        public string Name { get; set; }
        public decimal AccountBalance { get; set; }

        public Client(string name, decimal accountBalance)
        {
            Name = name;
            AccountBalance = accountBalance;
        }

        public void LogOutClientData()
        {
            Console.WriteLine($"Client name: {Name}, Balance: £{AccountBalance}");
        }
    }
}