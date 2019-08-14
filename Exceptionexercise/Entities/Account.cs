using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exceptionexercise.Entities.Exceptions;

namespace Exceptionexercise.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithDrawLimit { get; set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance, double withDrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithDrawLimit = withDrawLimit;
        }

        public void deposit(double amount)
        {
            Balance += amount;
        }

        public void withDraw(double amount)
        {
            if(Balance - amount < 0)
            {
                throw new DomainExceptions("Insufficient Balance");
            }
            if(amount > WithDrawLimit)
            {
                throw new DomainExceptions("The amount exceeds withdraw limit");
            }
            Balance -= amount;
        }
    }
}
