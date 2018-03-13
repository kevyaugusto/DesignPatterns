using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.C02;

namespace DesignPatterns.UnitTests
{
    [TestClass]
    public class C02Tests
    {
        [TestMethod]
        public void C02TestNoDiscount()
        {
            var initialBudgetValue = 30;

            var budget = new Budget(initialBudgetValue);

            budget.AddBudgetItem(new BudgetItem("Pen", 10));
            budget.AddBudgetItem(new BudgetItem("Pencil", 10));
            budget.AddBudgetItem(new BudgetItem("Sharpener", 10));

            var discountCalculator = new DiscountCalculator();

            var discountApplied = discountCalculator.CalculateDiscount(budget);

            Assert.AreEqual(initialBudgetValue, initialBudgetValue - discountApplied);
        }

        [TestMethod]
        public void C02TestFiveHundredDollarsDiscount()
        {
            var initialBudgetValue = 600;

            var budget = new Budget(initialBudgetValue);

            budget.AddBudgetItem(new BudgetItem("Pen", 200));
            budget.AddBudgetItem(new BudgetItem("Pencil", 200));
            budget.AddBudgetItem(new BudgetItem("Sharpener", 200));

            var discountCalculator = new DiscountCalculator();

            var discountApplied = discountCalculator.CalculateDiscount(budget);

            var expectedValue = initialBudgetValue - (initialBudgetValue * budget.DiscountFactor);

            Assert.AreEqual(expectedValue, initialBudgetValue - discountApplied);
        }

        [TestMethod]
        public void C02TestFiveItemsDiscount()
        {
            var initialBudgetValue = 1200;

            var budget = new Budget(initialBudgetValue);

            budget.AddBudgetItem(new BudgetItem("Pen", 200));
            budget.AddBudgetItem(new BudgetItem("Pencil", 200));
            budget.AddBudgetItem(new BudgetItem("Sharpener", 200));
            budget.AddBudgetItem(new BudgetItem("Mouse", 200));
            budget.AddBudgetItem(new BudgetItem("XBOX", 200));
            budget.AddBudgetItem(new BudgetItem("iPhone", 200));

            var discountCalculator = new DiscountCalculator();

            var discountApplied = discountCalculator.CalculateDiscount(budget);

            var expectedValue = initialBudgetValue - (initialBudgetValue * budget.DiscountFactor);

            Assert.AreEqual(expectedValue, initialBudgetValue - discountApplied);
        }
        
    }
}
