using MyFinancialApp.DTOs;
using System;
using System.Net.Http.Json;
using System.Net.Http;
using System.Threading.Tasks;
using System.Configuration;

namespace MyFinancialApp.Presenters
{
    public class AddDebtPresenter
    {
        private static HttpClient _httpClient;
        private Uri Uri = new Uri(ConfigurationManager.AppSettings["myFinanicalApi"]);
        public AddDebtPresenter(HttpClient client)
        {
            _httpClient = client;
        }
        public async Task<HttpResponseMessage> AddDebt(AddDebtRequest request)
        {
            return await SendAddDebtRequest(request);
        }

        /// <summary>
        /// Sends a request to API to add new Debt
        /// </summary>
        /// <param name="request">Request data for AddDebt path</param>
        /// <returns>Task</returns>
        private async Task<HttpResponseMessage> SendAddDebtRequest(AddDebtRequest request)
        {
            _httpClient.BaseAddress = Uri;
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            var requestContent = JsonContent.Create(request);

            try
            {
                var response = await _httpClient.PostAsync("AddDebt", requestContent);
                response.EnsureSuccessStatusCode();
                return response;
            }
            finally
            {
            }
        }
    }
}
