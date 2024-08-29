using Moq;
using Moq.Protected;
using MyFinancialApp.DTOs;
using MyFinancialApp.Presenters;

namespace UnitTests.AddPageTests
{
    [TestClass]
    public class AddPagePresenterTests
    {
        [TestMethod]
        public async Task AddPagePresenter_WhenValidRequestPresented_ReturnsOkResponse()
        {
            // Arrange
            var mockHttpHandler = new Mock<HttpMessageHandler>();

            mockHttpHandler.Protected().Setup<Task<HttpResponseMessage>>("SendAsync", ItExpr.IsAny<HttpRequestMessage>(), ItExpr.IsNull<CancellationToken>()).ReturnsAsync(new HttpResponseMessage { StatusCode = System.Net.HttpStatusCode.OK});

            var testPresenter = new AddDebtPresenter(new HttpClient(mockHttpHandler.Object));

            // Act
            var response = await testPresenter.AddDebt(CreateFakeAddDebtRequest(1, "TestEntry", float.Parse("100.00"), "ONETIME", new DateTime(2000, 3, 1), new DateTime(2000, 1, 1), DateTime.MaxValue, "Test"));

            // Assert

            Assert.IsTrue(response.StatusCode == System.Net.HttpStatusCode.OK);

        }

        private AddDebtRequest CreateFakeAddDebtRequest(int id, string description, float amount, string frequency, DateTime dateOfOccurrence, DateTime lastPaymentDate, DateTime nextPaymentDate, string owner)
        {
            return new AddDebtRequest
            {
                Id = id,
                Description = description,
                Amount = amount,
                DateOfOccurrence = dateOfOccurrence,
                Frequency = frequency,
                LastPaymentDate = lastPaymentDate,
                NextPaymentDate = nextPaymentDate,
                Owner = owner
            };
        }
    }
}
