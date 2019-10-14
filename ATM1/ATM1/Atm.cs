using System;
using System.Collections.Generic;
using System.Text;

namespace ATM1
{
    class Atm
    {
        Account account = new Account(5000, "1234", "121212");
        Phone phone = new Phone("123123123", 33.33f);
        int choice;
        float withdraw;
        float amount;
        string phoneNumber;
        public void start()
        {
            while (true)
            {
                Console.WriteLine("Insert card");
                string card = Console.ReadLine();
                if (card == account.number)
                {
                    Console.WriteLine("ENTER YOUR PIN NUMBER");
                    string pin = Console.ReadLine();
                    if (account.pin == pin)
                    {
                        Console.WriteLine("1. Current Balance\n");
                        Console.WriteLine("2. Withdraw \n");
                        Console.WriteLine("3. TOP-UP YOUR PHONE \n");
                        Console.WriteLine("4. Cancel \n");
                        Console.WriteLine("ENTER YOUR CHOICE : ");
                        choice = int.Parse(Console.ReadLine());

                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine(account.getBalance());
                                break;
                            case 2:
                                Console.WriteLine("\n ENTER THE WITHDRAW AMOUNT : ");
                                withdraw = float.Parse(Console.ReadLine());
                                if (withdraw > account.balance)
                                {
                                    Console.WriteLine("\n SORRY! INSUFFICENT BALANCE");
                                }
                                else
                                {
                                    Console.WriteLine("\n MONEY: "+account.withdrawMoney(withdraw));
                                    Console.WriteLine("\n ACCOUNT BALANCE: " + account.getBalance());
                                }
                                break;
                            case 3:
                                Console.WriteLine("\n ENTER PHONE NUMBER");
                                phoneNumber = Console.ReadLine();
                                if (phoneNumber == phone.number)
                                {
                                    Console.WriteLine("\n YOUR PHONE BALANCE: " + phone.getBalance());
                                    Console.WriteLine("\n ENTER AMOUNT");
                                    amount = float.Parse(Console.ReadLine());
                                    if(amount > account.balance)
                                    {
                                        Console.WriteLine("\n SORRY! INSUFFICENT BALANCE");
                                    }
                                    else
                                    {
                                        phone.addBalance(amount);
                                        Console.WriteLine("\n YOUR PHONE BALANCE: " + phone.getBalance());
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("\n NUMBER NOT FOUND");
                                }
                                break;
                            case 4:
                                break;

                        }
                    }
                    else
                    {
                        Console.WriteLine("\n WRONG PIN NUMBER");
                    }
                }
                else
                {
                    Console.WriteLine("\n WRONG CARD");
                }
            }
        }
    }
}
