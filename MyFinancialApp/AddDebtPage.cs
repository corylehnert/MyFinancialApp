using MyFinancialApp.DTOs;
using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFinancialApp
{
    public partial class AddDebtPage : Form
    {
        public AddDebtPage()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void btnAdd_ClickAsync(object sender, EventArgs e)
        {
            Console.WriteLine("This button will add newly created Debt entry to a local database.");
            

            var request = new AddDebtRequest();
            request.Id = new Random().Next();
            request.Description = txtBxDescription.Text;
            request.Amount = float.Parse(txtBxAmount.Text);
            request.DateOfOccurrence = DateTime.Now;
            request.LastPaymentDate = DateTime.Now;
            request.Frequency = DetermineFrequency();
            request.NextPaymentDate = DetermineNextPaymentDate();
            request.Owner = "Owner";
            var response = SendAddDebtRequest(request);
        }

        private void AddDebtPage_Load(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            rBtnOneTime.Checked = true;
        }

        private async Task SendAddDebtRequest(AddDebtRequest request)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            var requestContent = JsonContent.Create(request);

            try
            {
                var response = await client.PostAsync("AddDebt", requestContent);
            }
            catch(Exception ex)
            {
                lblError.Text = ex.Message;
                lblError.Show();
            }
        }

        private string DetermineFrequency()
        {
            if (rBtnOneTime.Checked)
            {
                return "ONETIME";
            }
            else if (rBtnWeekly.Checked)
            {
                return "WEEKLY";
            }
            else if(rBtnMonthly.Checked)
            {
                return "MONTHLY";
            }
            return "N/A";
        }

        private void EnableAddButton(object sender, EventArgs e)
        {
            var isFrequencySet = rBtnMonthly.Checked || rBtnOneTime.Checked || rBtnWeekly.Checked;
            var isDescriptionNotEmpty = !String.IsNullOrEmpty(txtBxDescription.Text);
            var isAmountNotEmpty = !String.IsNullOrEmpty(txtBxAmount.Text);

            if (isFrequencySet && isDescriptionNotEmpty && isAmountNotEmpty)
            {
                btnAdd.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = false;
            }
        }

        private DateTime DetermineNextPaymentDate()
        {
            DateTime nextPaymentDate = new DateTime();
            if (rBtnOneTime.Checked)
            {
                nextPaymentDate = DateTime.MaxValue;
            }
            else if (rBtnWeekly.Checked)
            {
                nextPaymentDate = nextPaymentDate.AddDays(7);
            }
            else if (rBtnMonthly.Checked)
            {
                nextPaymentDate = nextPaymentDate.AddMonths(1);
            }

            return nextPaymentDate;
        }
    }
}
