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
            IItem item = itemType switch
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

        [DataTestMethod]
        [DataRow(1, 15)]
        [DataRow(2, 30)]
        [DataRow(3, 40)]
        [DataRow(4, 55)]
        public void Given_IHaveAddedAMultipleOfThreeLotsOfItemBToTheBasket_Then_APromotionOfThreeForFortyShouldBeAppliedToEveryMultipleOfThree(int numberOfItemB, int expectedPrice)
        {
            //Arrange
            var basket = new Basket();

            //Act
            for (int i = 0; i < numberOfItemB; i++)
            {
                basket.AddItem(new ItemB());
            }

            //Assert
            Assert.AreEqual(expectedPrice, basket.CalculatePrice());
        }
    }
}
