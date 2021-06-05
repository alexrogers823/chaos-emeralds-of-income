using System;

namespace ChaosEmeraldsOfIncome.Controllers
{
    public class EarnedIncome
    {
        public int UserId { get; set; }
        public string IncomeTitle { get; set; }
        public int IncomeAmount { get; set; }
        public string Frequency { get; set; }
        public bool IsCurrent { get; set; }
        public DateTime? LastUpdated { get; set; }
    }
}