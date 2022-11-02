using System.Diagnostics;

namespace Classes_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer { Id = 1, Address = "10 Madeup Street", Name = "Bob the Builder"};
            var trade = new Trade { Amount = 10, Asset = "ABCD", Direction = "Buy", Price = 1000};

            customer.MakeTrade(trade);
            Console.WriteLine(customer.CustomerSummary);

            Console.WriteLine("Hello, welcome to the trading platform. \n What is your name? ");
            string name = Console.ReadLine();
            Console.WriteLine(" What is your address? ");
            string address = Console.ReadLine();
            Console.WriteLine(" What is your ID? ");
            string id = Console.ReadLine();
            var customer1 = new Customer { Id = Int16.Parse(id), Address = address, Name = name };

            Console.WriteLine("What asset would you like to trade?");
            string asset = Console.ReadLine();
            Console.WriteLine("How many? ");
            string amount = Console.ReadLine();
            Console.WriteLine(" Sell or buy? ");
            string direction = Console.ReadLine();
            var trade2 = new Trade { Amount = Int16.Parse(amount), Asset = asset , Direction = direction, Price = 1000 };
            customer1.MakeTrade(trade2);

            Console.WriteLine(customer1.CustomerSummary);
        }
    }
}
