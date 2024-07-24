using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MyFinancialApp.DTOs
{
    public class AddDebtRequest
    {
        public int Id { get; set; }

        public float Amount { get; set; }

        public string Description { get; set; }

        public string Frequency { get; set; }

        public DateTime DateOfOccurrence { get; set; }

        public DateTime NextPaymentDate { get; set; }

        public DateTime LastPaymentDate { get; set; }

        /// <summary>
        /// Person who the has the pay the debt aka debtee
        /// </summary>
        public string Owner { get; set; }
    }
}
