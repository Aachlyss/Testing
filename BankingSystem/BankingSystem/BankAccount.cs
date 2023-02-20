using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    public class BankAccount
    {
        public BankAccount(int id, decimal balance = 0)
        {
            Id = id;
            Balance = balance;
        }

        public int Id { get; set; }
        public decimal Balance { get; set; }

        public void Deposit(decimal amount)
        {
            if (amount <=0)
            {
                throw new InvalidOperationException("Negative Amount!");
            }
            this.Balance += amount;
        }

        public void Credit(decimal cash)
        {
            if (cash <= 0)
            {
                throw new InvalidOperationException("Cannot credit negative amount!");
            }

            this.Balance -= cash;
        }
        public void Increase(double percent)
        {

        }
    }
}
