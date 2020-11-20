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
    }
}
