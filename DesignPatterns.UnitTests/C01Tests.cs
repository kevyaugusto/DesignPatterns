using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.C01;
using DesignPatterns.C01.Sample01;

namespace DesignPatterns.UnitTests
{
    [TestClass]
    public class C01Tests
    {
        [TestMethod]
        public void C01TestPersonalIncomeTax()
        {
            var personalIncomeTax = new PersonalIncomeTax();
            var budget = new Budget(100);
            var taxCalculator = new TaxCalculator();

            var calculatedTax = taxCalculator.Calculate(budget, personalIncomeTax);

            Assert.AreEqual(6D, calculatedTax);
        }

        [TestMethod]
        public void C01TestCompanyTax()
        {
            var companyTax = new CompanyTax();
            var budget = new Budget(500);
            var taxCalculator = new TaxCalculator();

            var calculatedTax = taxCalculator.Calculate(budget, companyTax);

            Assert.AreEqual(50D, calculatedTax);
        }

        [TestMethod]
        public void C01TestSample0175PercentProfitOfInvestment25PercentTax_ConservativeInvestment()
        {
            var bankAccount = new BankAccount();
            var initialBalance = 100;

            bankAccount.Deposit(initialBalance);

            var conservativeInvestment = new ConservativeInvestment();

            var investmentCalculator = new InvestmentCalculator();
            var profitOfInvestment = investmentCalculator.Calculate(bankAccount, conservativeInvestment);

            bankAccount.Deposit(profitOfInvestment * 0.75);

            var expectedBalance = initialBalance + (initialBalance * conservativeInvestment.Factor);

            Assert.AreEqual(expectedBalance, bankAccount.Balance);
        }

        [TestMethod]
        public void C01TestSample0175PercentProfitOfInvestment25PercentTax_ModerateInvestment()
        {
            var bankAccount = new BankAccount();
            var initialBalance = 100;

            bankAccount.Deposit(initialBalance);

            var moderateInvestment = new ModerateInvestment();

            var investmentCalculator = new InvestmentCalculator();
            var profitOfInvestment = investmentCalculator.Calculate(bankAccount, moderateInvestment);

            bankAccount.Deposit(profitOfInvestment * 0.75);

            var expectedBalance = initialBalance + (initialBalance * moderateInvestment.Factor * 0.75);

            Assert.AreEqual(expectedBalance, bankAccount.Balance);
        }

        [TestMethod]
        public void C01TestSample0175PercentProfitOfInvestment25PercentTax_FearlessInvestment()
        {
            var bankAccount = new BankAccount();
            var initialBalance = 100;

            bankAccount.Deposit(initialBalance);

            var fearlessInvestment = new FearlessInvestment();

            var investmentCalculator = new InvestmentCalculator();
            var profitOfInvestment = investmentCalculator.Calculate(bankAccount, fearlessInvestment);

            bankAccount.Deposit(profitOfInvestment * 0.75);

            var expectedBalance = initialBalance + (initialBalance * fearlessInvestment.Factor * 0.75);

            Assert.AreEqual(expectedBalance, bankAccount.Balance);
        }
    }
}
