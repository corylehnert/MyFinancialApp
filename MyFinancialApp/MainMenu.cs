using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFinancialApp
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void btnAddDebt_Click(object sender, EventArgs e)
        {
            this.Hide();
            var addDebtForm = new AddDebtPage();
            addDebtForm.ShowDialog();
            this.Show();
        }

        private void btnCreateReport_Click(object sender, EventArgs e)
        {
            this.Hide();
            var createFinancialReport = new CreateFinancialReport();
            createFinancialReport.ShowDialog();
            this.Show();
        }
    }
}
