using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mid_Assignment
{
    class Account
    {
        private int accountNumber;
        private string accountName;
        private double balance;
        private Address address;

        public Account(int accountNumber, string accountName, double balance, Address address)
        {
            this.accountNumber = accountNumber;
            this.accountName = accountName;
            this.balance = balance;
            this.address = address;
    
        }
        public int AccountNumber
        {
            set { this.accountNumber= value ; }
            get { return this.accountNumber; }
        }
        public string AccountName
        {
            set { this.accountName = value; }
            get { return this.accountName; }
        }
        public double Balance
        {
            set { this.Balance = value; }
            get { return this.Balance; }
        }
        public   Address Address
        {
            set { this.address = value; }
            get { return this.address; }
        }
        public void Withdraw(double amount)
        {
           if(amount > 0 && amount <=balance)
            {
                
            }
        }
    }
}
