using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.C01;

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
    }
}
