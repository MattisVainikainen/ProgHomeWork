using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Account
    {
        private float balance;
        private float minBalance = 10;

        public Account()
        {

        }

        public Account (int value)
        {
            balance = value;
        }

        public void Deposit(float amount)
        {
            balance += amount;
        }

        public void WithDraw(float amount)
        {
            balance -= amount;
        }

        public void TransferFunds(Account destination, float amount)
        {
            destination.Deposit(amount);
            WithDraw(amount);
        }

        public Account TransferMinFunds(Account destination, float amount)
        {
            if(balance - amount > minBalance)
            {
                destination.Deposit(amount);
                WithDraw(amount);
            }
            else
            {
                //throw new NotEnoughFundsExeption();
            }
            return destination;
        }

        public float Balance
        {
            get { return balance; }
        }

        public float MinBalance
        {
            get { return minBalance; }
        }
    }
}
