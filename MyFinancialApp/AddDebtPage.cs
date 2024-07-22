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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Console.WriteLine("This button will add newly created Debt entry to a local database.");
        }

        private void AddDebtPage_Load(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
        }
    }
}
