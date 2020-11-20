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
            var item = new Item();

            //Act
            basket.Add(new Item);

            //Assert
            Assert.AreEqual(1, basket.Items.Count);
        }
    }
}
