using System;
using System.Collections.Generic;
using System.Text;

namespace ATM1
{
    class Account
    {
        public float balance;
        public string pin, number;
        public Account(float a, string p, string n)
        {
            balance = a;
            pin = p;
            number = n;
        }
        public float getBalance()
        {
            return balance;
        }

        public float withdrawMoney(float money)
        {
            balance -= money;
            return money;
        }


    }
}
