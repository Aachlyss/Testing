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
        public void Increase(decimal percent)
        {
            this.Balance =this.Balance+ (this.Balance * percent) /100;
        }
        public void PaymentForCredit(decimal payment)
        {
            if (payment <=0)
            {
                throw new ArgumentException("Payment cannot be zero or negative!");
            }
            if (this.Balance<payment)
            {
                throw new ArgumentException("Not enough money!");
            }
            this.Balance -= payment;
        }
        public decimal Bonus()
        {
            if (this.Balance>=1000&&this.Balance<=2000)
            {
                this.Balance += 100;
            }
            else if (this.Balance > 2000 && this.Balance < 3000)
            {
                this.Balance += 200;
            }
            else if (this.Balance > 3000 )
            {
                this.Balance += 300;
            }
            return this.Balance;
        }
    }
}
