using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mid_Assignment
{
    class Bank
    {
        private string bankName;
        public Account[] myBank;

    public Bank(string bankName,int size)
        {
            this.bankName = bankName;
            this.myBank = new Account[size];
        }
        public void AddAccount(Account account)
        {
            for(int i=0; i<myBank.Length; i++)
            {
                if(myBank[i]==null)
                {
                    myBank[i] = account;
                    break;
                }
            }
        }
        public void DeleteAccount(int accountNumber)
        {
            for (int i=0; i< myBank.Length; i++)
            {
                if(myBank[i]==null )
                {
                    continue;
                }
                else if (myBank[i].AccountNumber==accountNumber)
                {
                    myBank[i] = null;
                    for(int j=1; j<(myBank.Length-1); j++)
                    {
                        myBank[j] = myBank[j + 1];
                    }
                    Console.WriteLine("Account Deleted");
                }
            }
        }
        public void PrintAccountDetails()
        {
            for(int i=0; i<myBank.Length; i++)
            {
                if(myBank[i].AccountNumber==null)
                {
                    continue;
                }
                myBank[i].PrintAccountDetails();
            }
        }
       
    }
}
