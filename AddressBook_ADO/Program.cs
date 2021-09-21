using System;

namespace AddressBook_ADO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to ADO.NET Address Book System ");
            DatabaseManager manager = new DatabaseManager();
            manager.CreateDatabase();
        }
    }
}
