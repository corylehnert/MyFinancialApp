using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MyFinancialApp.DTOs.Data
{
    public class DebtEntry
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

        [JsonConstructor]
        public DebtEntry(int id, float amount, string description, DateTime dateOfOccurrence, string frequency, DateTime nextPaymentDate, DateTime lastPaymentDate, string owner)
        {
            Id = id;
            Amount = amount;
            Description = description;
            DateOfOccurrence = dateOfOccurrence;
            Frequency = frequency;
            NextPaymentDate = nextPaymentDate;
            LastPaymentDate = lastPaymentDate;
            Owner = owner;
        }
    }
}
