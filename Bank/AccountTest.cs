using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    [TestFixture]
    class AccountTest
    {
        Account source;
        Account destination;

        [SetUp]
        public void InitAccount()
        {
            //Arrange
            source = new Account();
            source.Deposit(200.00f);
            destination = new Account();
            destination.Deposit(150.00f);
        }

        [Test]
        [Category("pass")]
        public void TransferFunds()
        {
            //act
            source.TransferFunds(destination, 100.00f);

            //Assert
            Assert.AreEqual(250.00f, destination.Balance);
            Assert.AreEqual(100.00f, source.Balance);
        }

        [Test, Category("pass")]
        [TestCase(200, 0, 78)]
        [TestCase(200, 0, 180)]
        [TestCase(200, 0, 1)]
        public void TransferMinFunds(int a, int b, int c)
        {
            Account source = new Account();
            source.Deposit(a);
            Account destination = new Account();
            destination.Deposit(b);

            source.TransferMinFunds(destination, c);
            Assert.AreEqual(c, destination.Balance);
        }


    }
}
