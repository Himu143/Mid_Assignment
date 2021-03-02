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
       
    }
}
