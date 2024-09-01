using Moq.Protected;
using Moq;
using MyFinancialApp.Presenters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFinancialApp.DTOs.Responses;
using MyFinancialApp.DTOs.Data;
using System.Net.Http.Json;
using System.Text.Json;

namespace UnitTests.FinancialReportTests
{
    [TestClass]
    public class CreateFinancialReportTests
    {
        [TestMethod]
        public async Task FinancialReportPagePresenter_WhenValidRequestPresented_ReturnsOkResponse()
        {
            // Arrange
            var mockHttpMessageHandler = new Mock<HttpMessageHandler>();
            mockHttpMessageHandler.Protected().Setup<Task<HttpResponseMessage>>("SendAsync", ItExpr.IsAny<HttpRequestMessage>(), ItExpr.IsAny<CancellationToken>()).ReturnsAsync(new HttpResponseMessage { Content = JsonContent.Create(SetFakeSuccessfulFinancialReportResponse()) });

            var testPresenter = new FinancialReportPresenter(new HttpClient(mockHttpMessageHandler.Object));

            // Act
            var response = await testPresenter.RetrieveDebtRecords("test");
            // Assert

            Assert.IsTrue(response.Debts.Count() == 5);
            Assert.IsTrue(response.Notices.Count() == 0);
        }

        private FinancialReportResponse SetFakeSuccessfulFinancialReportResponse()
        {
            return new FinancialReportResponse
            {
                Debts = new List<DebtEntry>
                {
                    new DebtEntry(1, 123.23f, "Test Item", DateTime.Now, "ONETIME", DateTime.Now.AddDays(-1), DateTime.Now.AddMonths(1), "Test Owner"),
                    new DebtEntry(2, 123.23f, "Test Item", DateTime.Now, "ONETIME", DateTime.Now.AddDays(-1), DateTime.Now.AddMonths(1), "Test Owner"),
                    new DebtEntry(3, 123.23f, "Test Item", DateTime.Now, "ONETIME", DateTime.Now.AddDays(-1), DateTime.Now.AddMonths(1), "Test Owner"),
                    new DebtEntry(4, 123.23f, "Test Item", DateTime.Now, "ONETIME", DateTime.Now.AddDays(-1), DateTime.Now.AddMonths(1), "Test Owner"),
                    new DebtEntry(5, 123.23f, "Test Item", DateTime.Now, "ONETIME", DateTime.Now.AddDays(-1), DateTime.Now.AddMonths(1), "Test Owner"),
                },
                Notices = new List<string>()
            };
        }
    }
}
