using MyFinancialApp.DTOs.Responses;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFinancialApp.Presenters
{
    public class FinancialReportPresenter
    {
        HttpClient _httpClient;

        public FinancialReportPresenter(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<FinancialReportResponse> RetrieveDebtRecords(string reportPath)
        {
            _httpClient.BaseAddress = new Uri(ConfigurationManager.AppSettings["api"]);
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            return await _httpClient.GetFromJsonAsync<FinancialReportResponse>(reportPath, new System.Text.Json.JsonSerializerOptions { PropertyNameCaseInsensitive = true, IncludeFields = true });
        }
    }
}
