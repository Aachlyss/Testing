using NUnit.Framework;
using System;

namespace BankingSystem.Tests
{
    [TestFixture]
    public class BankAccountTests
    {
        [SetUp]
        public void DepositShouldIncreaseBalance()
        {
            //Arrange
            BankAccount bankAccount = new BankAccount(123);
            decimal depositAmount = 100;

            //Act
            bankAccount.Deposit(depositAmount);

            //Assert
            Assert.AreEqual(depositAmount, bankAccount.Balance);
        }

        [Test]
        public void AccountInitializeWithPositiveValue()
        {
            //Arrange



            //Act
            BankAccount bankAccount = new BankAccount(123, 2000m);

            //Assert
            Assert.AreEqual(2000m, bankAccount.Balance);
        }

        [TestCase(100)]
        [TestCase(3500)]
        [TestCase(2400)]
        public void DepositShouldIncreaseBalanceAll(decimal depositAmount)
        {
            {
                //Arrange
                BankAccount bankAccount = new BankAccount(123);  


                //Act
                bankAccount.Deposit(depositAmount);

                //Assert
                Assert.AreEqual(depositAmount, bankAccount.Balance);
            }
        }

        [Test]
        public void NegativeAmountShouldThrowInvalidOperationExceptions()
        {
            {
                //Arrange
                BankAccount bankAccount = new BankAccount(123);
                decimal depositAmount = -100;
                //Act
                //Assert
                Assert.Throws<InvalidOperationException>(() => bankAccount.Deposit(depositAmount));


            }
        }
        [Test]
        public void NegativeAmountShouldThrowInvalidOperationExceptionsWithMessage()
        {
            //Arrange
            BankAccount bankAccount = new BankAccount(123);
            decimal depositAmount = -100;
            //Act
            //Assert
            var ex = Assert.Throws<InvalidOperationException>(() => bankAccount.Deposit(depositAmount));

            Assert.AreEqual(ex.Message, "Negative Amount!");

        }
        [Test]
        public void CreditShouldDecreaseBalance()
        {
            //Arrange
            BankAccount bankAccount = new BankAccount(123);
            decimal creditAmount = 100;

            //Act
            bankAccount.Credit(creditAmount);

            //Assert
            Assert.AreEqual(-100, bankAccount.Balance);
        }

        [TestCase(5)]
        public void IncreaseBalance(decimal percent)
        {
            //Arrange
            BankAccount bankAccount = new BankAccount(100);
            //Act
            bankAccount.Increase(percent);
            //Assert
            Assert.AreEqual(105, bankAccount.Balance);

        }

        [TestCase(1001)]
        [TestCase(2004)]
        [TestCase(3500)]
        public void Bonusbalance(decimal bonusAmount)
        {
            //Arrange
            BankAccount bankAccount = new BankAccount(123);
            //Act
            bankAccount.Balance = bankAccount.Bonus();
            //Assert
            Assert.AreEqual(bankAccount.Bonus(), bankAccount.Balance);
        }

    }
}