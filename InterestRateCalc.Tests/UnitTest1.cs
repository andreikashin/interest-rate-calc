using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InterestRateCalc.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            var fakeService = new Api.Services.InterestRateDecisionService();
            var amount = 2001;

            // Act
            var expected = fakeService.IsApproved(amount);

            // Assert
            Assert.IsTrue(expected);
        }
    }
}
