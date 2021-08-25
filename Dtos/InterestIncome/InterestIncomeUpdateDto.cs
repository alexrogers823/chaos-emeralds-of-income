using System;

namespace ChaosEmeraldsOfIncome.Dtos
{
    public class InterestIncomeUpdateDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public double? TotalSavings { get; set; }
        public double InterestPercent { get; set; }
        public double InterestDollar { get; set; }
        // field used for net worth calculation 
        public bool IsActive { get; set; }
        public DateTime? DateAdded { get; set; }
        public DateTime? LastUpdated { get; set; }
    }
}