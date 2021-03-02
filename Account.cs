using System;
using System.Collections.Generic;
using System.Text;

namespace MidAssignment1
{
    public class Account
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
            set { this.accountNumber = value; }
            get { return this.accountNumber; }
        }
        public string AccountName
        {
            set { this.accountName = value; }
            get { return this.accountName; }
        }
        public double Balance
        {
            set { this.balance = value; }
            get { return this.balance; }
        }
        public Address Address
        {
            set { this.address = value; }
            get { return this.address; }
        }
        public void Widraw(double ammount)
        {
            if (balance < ammount)
            {
                Console.WriteLine("NOT ENOUGH BALANCE");
            }
            else
            {
                balance -= ammount;
            }
        }
        public void Diposit(double ammount)
        {
            balance += ammount;
        }
        public void Transfer(Account receiver, double ammount)
        {
            if (balance < ammount)
            {
                Console.WriteLine("NOT ENOUGH BALANCE");
            }
            else
            {
                this.balance -= ammount;
                receiver.Balance += ammount;
            }
        }
        public void ShowAccountInfo()
        {
            Console.WriteLine("ACCOUNT INFORMATION\n" + "Account Number: " + this.accountNumber +
                "\nName: " + this.accountName + "\nBalance: " + this.balance + "\nAddress: " + address.getAddress());
        }


    }
}
