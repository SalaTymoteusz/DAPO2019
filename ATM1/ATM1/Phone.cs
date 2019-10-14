using System;
using System.Collections.Generic;
using System.Text;

namespace ATM1
{
    class Phone
    {
        public string number;
        public float balance;
        public Phone(string n, float b)
        {
            number = n;
            balance = b;
        }

        public void addBalance(float amount)
        {
            balance += amount;
        }

        public float getBalance()
        {
            return balance;
        }
    }
}
