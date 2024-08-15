using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyFinancialApp.DTOs.Responses;

namespace MyFinancialApp
{
    public partial class CreateFinancialReport : Form
    {
        HttpClient client;
        public CreateFinancialReport()
        {
            InitializeComponent();
            client = new HttpClient();
            client.BaseAddress = new Uri("");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }

        private void btnGenerate_ClickAsync(object sender, EventArgs args)
        {
            listDebts.Items.Clear();
            try
            {
                lblMessage.Text = "Creating Report...";
                var reportPath = DetermineReportType();
                var response = RetrieveData(reportPath);
                lblMessage.Text = "Report Generated.";

            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message;
                lblMessage.Show();
            }
            listDebts.Show();
        }

        /// <summary>
        /// Retreive data from database to be displayed
        /// </summary>
        /// <param name="reportPath">The path for API call</param>
        /// <returns>Task</returns>
        private async Task<FinancialReportResponse> RetrieveData(string reportPath)
        {
            var responseData = new FinancialReportResponse();
            try
            {
                responseData = await client.GetFromJsonAsync<FinancialReportResponse>(reportPath, new System.Text.Json.JsonSerializerOptions { PropertyNameCaseInsensitive = true, IncludeFields = true });
                foreach (var debtEntry in responseData.Debts)
                {
                    var item = new ListViewItem(debtEntry.Description);
                    item.SubItems.Add(debtEntry.Amount.ToString());
                    item.SubItems.Add(debtEntry.NextPaymentDate.ToShortDateString());
                    item.SubItems.Add(debtEntry.LastPaymentDate.ToShortDateString());
                    listDebts.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message;
                lblMessage.Show();
            }
            return responseData;
        }

        /// <summary>
        /// Turn combo box values into usable data
        /// </summary>
        /// <returns>Value of combo box data</returns>
        private string DetermineReportType()
        {
            var reportPath = "";
            switch (this.comBoxFrequency.SelectedIndex)
            {
                case 0: return comBoxFrequency.Items[0].ToString();
                case 1: return comBoxFrequency.Items[1].ToString();
                case 2: return comBoxFrequency.Items[2].ToString();
                default: return comBoxFrequency.Items[0].ToString();
            }
        }
    }
}
