using System;

namespace MidAssignment1
{
    class Program
    {
        private static int x = 0;
        public static int AutoIdGenerator()
        {
            x++;
            return x;

        }
        static void Main(string[] args)
        {
            Console.Write("Enter Your Bank Name : ");
            string bankName = Console.ReadLine();
            Console.Write("How many account you Want to insert ? :");
            int size = Convert.ToInt32(Console.ReadLine());

            Bank b1 = new Bank(bankName, size);

            while (true)
            {
                Console.WriteLine("Select the following option : ");
                Console.Write("1. Add Account\n2. Delete Account\n3. Transaction\n4. Show Account Details\n5. Exit\n\nEnter : ");
                int x = Convert.ToInt32(Console.ReadLine());

                if (x == 1)
                {
                    Console.Write("Enter Account : \nName : ");
                    string accountName = Console.ReadLine();
                    Console.Write("Balance : ");
                    double balance = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Address :\nRoad No. : ");
                    string roadNo = Console.ReadLine();
                    Console.Write("House No. : ");
                    string houseNo = Console.ReadLine();
                    Console.Write("City : ");
                    string city = Console.ReadLine();
                    Console.Write("Country : ");
                    string country = Console.ReadLine();

                    int id = AutoIdGenerator();

                    b1.AddAccount(new Account(id, accountName, balance, new Address(roadNo, houseNo, city, country)));


                }
                else if (x == 2)
                {
                    Console.Write("Enter You Account Number : ");
                    int accountNumber = Convert.ToInt32(Console.ReadLine());
                    b1.DeleteAccount(accountNumber);
                }
                else if (x == 3)
                {
                    Console.Write("Enter You Account Number : ");
                    int accountNumber = Convert.ToInt32(Console.ReadLine());
                    int found = b1.SearchAccount(accountNumber);
                    if (found >= 0)
                    {
                        Console.Write("What do you want to do??\n1. Withdraw\n2. Deposit \n3. Transfer\n\nEnter : ");
                        int choise = Convert.ToInt32(Console.ReadLine());
                        if (choise == 1)
                        {
                            Console.Write("Enter the amount you want to withdraw : ");
                            double amount = Convert.ToDouble(Console.ReadLine());
                            b1.Transaction(choise, found, amount);
                        }
                        else if (choise == 2)
                        {
                            Console.Write("Enter the amount you want to Deposit : ");
                            double amount = Convert.ToDouble(Console.ReadLine());
                            b1.Transaction(choise, found, amount);
                        }
                        else if (choise == 3)
                        {
                            Console.Write("Enter Receiver Account Number : ");
                            int recAccountNumber = Convert.ToInt32(Console.ReadLine());
                            int search = b1.SearchAccount(recAccountNumber);
                            if (search == found)
                            {
                                Console.WriteLine("The receiver Account Number is your.....");
                            }
                            else if (search >= 0)
                            {
                                Console.Write("Enter the amount you want to Transfer : ");
                                double amount = Convert.ToDouble(Console.ReadLine());
                                b1.Transaction(choise, found, search, amount);
                            }
                            else
                            {
                                Console.WriteLine("You enter a wrong input....\n1. Go Back\n2. Exit");
                                int wrong = Convert.ToInt32(Console.ReadLine());
                                if (wrong == 1) continue;
                                else if (wrong == 2) break;
                                else
                                {
                                    Console.WriteLine("Again the input was Wrong...Try Some time later");
                                    break;
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("You enter a wrong input....\n1. Go Back\n2. Exit");
                            int wrong = Convert.ToInt32(Console.ReadLine());
                            if (wrong == 1) continue;
                            else if (wrong == 2) break;
                            else
                            {
                                Console.WriteLine("Again the input is Wrong...");
                                break;
                            }

                        }

                    }
                    else
                    {
                        Console.WriteLine("No Such Account....");
                    }
                }
                else if (x == 4)
                {
                    Console.WriteLine("The information of the accounts are: ");
                    b1.PrintAccountDetails();

                }
                else if (x == 5)
                {
                    break;
                }
                else
                {
                    Console.Write("You enter a wrong input....\n1. Go Back\n2. Exit \n\nEnter : ");
                    int wrong = Convert.ToInt32(Console.ReadLine());
                    if (wrong == 1) continue;
                    else if (wrong == 2) break;
                    else
                    {
                        Console.WriteLine("Again the input is Wrong...");
                        break;
                    }

                }
            }

        }
    }
}
