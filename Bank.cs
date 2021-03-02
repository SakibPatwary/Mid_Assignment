using System;
using System.Collections.Generic;
using System.Text;

namespace MidAssignment1
{
    public class Bank
    {
        private string bankName;
        private Account[] myBank;

        public Bank(string bankName, int size)
        {
            this.bankName = bankName;
            this.myBank = new Account[size];
        }

        public string BankName
        {
            set { this.bankName = value; }
            get { return this.bankName; }
        }

        public Account[] MyBank
        {
            get { return this.myBank; }
        }
        public void AddAccount(Account account)
        {
            bool flag = false;
            int num = -1;
            for (int i = 0; i < myBank.Length; i++)
            {
                if (myBank[i] == null)
                {
                    myBank[i] = account;
                    flag = true;
                    num = i;
                    break;
                }
            }
            if (flag) Console.WriteLine("Account Added....\nYour Account Number = {0} ", myBank[num].AccountNumber);
            else Console.WriteLine("Can not add.....");
        }
        public void DeleteAccount(int accountNumber)
        {
            bool flag = false;
            for (int i = 0; i < myBank.Length; i++)
            {
                if (myBank[i] == null) continue;
                else if (accountNumber == myBank[i].AccountNumber)
                {
                    myBank[i] = null;
                    for (int j = i; j < myBank.Length - 1; j++)
                    {
                        Account x = myBank[j];
                        myBank[j] = myBank[j + 1];
                        myBank[j + 1] = x;
                    }
                    flag = true;
                }
            }
            if (flag) Console.WriteLine("Account Deleted....");
            else Console.WriteLine("Can not delete.....");
        }
        public void Transaction(int transactionType, params dynamic[] x)
        {
            if (transactionType == 1)
            {
                myBank[x[0]].Widraw(x[1]);
            }
            else if (transactionType == 2)
            {
                myBank[x[0]].Diposit(x[1]);
            }
            else if (transactionType == 3)
            {
                myBank[x[0]].Transfer(myBank[x[1]], x[2]);
            }
            else
            {
                Console.WriteLine("You gave a wrong input....");
            }
        }
        public int SearchAccount(int accountNumber)
        {
            bool flag = false;
            int i = 0;
            for (i = 0; i < myBank.Length; i++)
            {
                if (myBank[i] == null) continue;
                else if (myBank[i].AccountNumber == accountNumber)
                {
                    flag = true;
                    break;
                }
            }
            if (flag) return i;
            else return -1;
        }
        public void PrintAccountDetails(int index)
        {
            Console.WriteLine("Bank Name : " + this.bankName);
           
            for(int i = 0; i < myBank.Length; i++)
            {
                myBank[i].ShowAccountInfo();
            }

        }
    }
}
