using System;
using CheckoutKata.Lib;
using CheckoutKata.Lib.Items;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CheckoutKata.UnitTests
{
    [TestClass]
    public class BasketTests
    {
        [TestMethod]
        public void Given_IHaveSelectedToAddAnItemToTheBasket_Then_TheItemShouldBeAddedToTheBasket()
        {
            //Arrange
            var item = new ItemA();
            var basket = new Basket();

            //Act
            basket.AddItem(item);

            //Assert
            Assert.AreEqual(1, basket.GetItems().Count);
        }

        [DataTestMethod]
        [DataRow("A", 10)]
        [DataRow("B", 15)]
        [DataRow("C", 40)]
        [DataRow("D", 55)]
        public void Given_ItemsHaveBeenAddedToTheBasket_Then_TheTotalCostOfTheBasketShouldBeCalculated(string itemType, int expectedPrice)
        {
            //Arrange
            Item item = itemType switch
            {
                "A" => new ItemA(),
                "B" => new ItemB(),
                "C" => new ItemC(),
                "D" => new ItemD(),
                _ => throw new ArgumentOutOfRangeException($"wrong {nameof(itemType)}: {itemType}")
            };
            var basket = new Basket();

            //Act
            basket.AddItem(item);

            //Assert
            Assert.AreEqual(expectedPrice, basket.CalculatePrice());

        }
    }
}
