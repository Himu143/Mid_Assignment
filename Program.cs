using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mid_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank("DBBL", 5);
            bank.AddAccount(new Account(1001, "Himu", 60000, new Address("20", "123", "Dhaka", "Country")));
            bank.AddAccount(new Account(1002, "Hasan", 50000, new Address("23", "143", "Dhaka", "Country")));
            bank.PrintAccountDetails();
            bank.DeleteAccount(1001);
        }
    }
}
