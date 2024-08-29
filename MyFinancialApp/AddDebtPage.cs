using MyFinancialApp.DTOs;
using MyFinancialApp.Presenters;
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

        private async void btnAdd_ClickAsync(object sender, EventArgs e)
        {
            Console.WriteLine("This button will add newly created Debt entry to a local database.");

            AddDebtPresenter presenter = new AddDebtPresenter(new HttpClient());
            var request = new AddDebtRequest();
            request.Id = new Random().Next();
            request.Description = txtBxDescription.Text;
            request.Amount = float.Parse(txtBxAmount.Text);
            request.DateOfOccurrence = DateTime.Now;
            request.LastPaymentDate = DateTime.Now;
            request.Frequency = DetermineFrequency();
            request.NextPaymentDate = DetermineNextPaymentDate();
            request.Owner = "Owner";
            try
            {
                var response = await presenter.AddDebt(request);
                if (response.IsSuccessStatusCode)
                {
                    lblMessage.Text = "Debt has been added to database.";
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message;
            }
            
        }

        private void AddDebtPage_Load(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            rBtnOneTime.Checked = true;
        }

        /// <summary>
        /// Converts checkbox values to usable data
        /// </summary>
        /// <returns>Frequency type if true; N/A if not found</returns>
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

        /// <summary>
        /// Determines when the Add button is enabled
        /// </summary>
        /// <param name="sender">Data on object that causes the event</param>
        /// <param name="e">Event args</param>
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

        /// <summary>
        /// Determine next payment data based on frequency check box values
        /// </summary>
        /// <returns>date of next payment</returns>
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
