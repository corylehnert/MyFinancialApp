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
    public partial class CreateFinancialReport : Form
    {
        public CreateFinancialReport()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            listDebts.Show();
            //var listItem = new ListViewItem();
            //listItem.Text = "80.00";
            //listItem.SubItems.Add("Models");
            //listItem.SubItems.Add("07/23/24");
            //listItem.SubItems.Add("12/31/99");
            //listDebts.Items.Add(listItem);
        }
    }
}
