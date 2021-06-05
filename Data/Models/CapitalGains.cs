using System;

namespace ChaosEmeraldsOfIncome.Controllers
{
    public class CapitalGains
    {
        public int Id { get; set; }
        public string Investment { get; set; }
        public double InitialSellValue { get; set; }
        public double CurrentValue { get; set; }
        // field used for net worth calculation
        public bool IsActive { get; set; }
        public DateTime? LastUpdated { get; set; }
    }
}