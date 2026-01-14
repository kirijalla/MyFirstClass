using System;
using System.Collections.Generic;
using System.Text;

namespace calculator
{
    internal class Class1
    {
        public double balance = 0;
        public static void atm(int choice)
        {
            do
            {
                Console.WriteLine("1. Balance");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("4. EXIT");

                switch (choice)
                {
                    case 1: 
                        Cbalance(10);
                        break;
                    case 2:
                        deposit(10, 20);
                        break;
                    case 3:
                        Withdraw(30, 12);
                        break;
                }

            }while (choice != 4);



        }

        public static void Cbalance(double balance) 
        {
            Console.WriteLine($"Current balance: {balance}");
        }
        public static void deposit(double balance,double amount) 
        { balance = balance + amount;

            Console.WriteLine("Deposit is succes");
            Console.WriteLine($"Current balance is {balance}");
        
        }
        public static void Withdraw(double balance, double amount) 
        {
            if (amount < 0) 
            { Console.WriteLine("Amount is not valid");
                return;
            }

            if (amount < balance)
            {
                balance -= amount;
                Console.WriteLine("Withdraw is succes");
                Console.WriteLine($"Current balance is {balance}");
            }
            else 
            {
                Console.WriteLine("you are poor you dont have that much money");
            }
        }
       
    }
}
