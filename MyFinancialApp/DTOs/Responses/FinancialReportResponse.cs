using System.Collections.Generic;
using MyFinancialApp.DTOs.Data;

namespace MyFinancialApp.DTOs.Responses
{
    public class FinancialReportResponse
    {
        public List<DebtEntry> Debts { get; set; } = new List<DebtEntry>();

        public List<string> Notices { get; set; } = new List<string>();
    }
}
