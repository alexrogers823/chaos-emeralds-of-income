using System;
using System.ComponentModel.DataAnnotations;

namespace ChaosEmeraldsOfIncome.Dtos
{
    public class InterestIncomeCreateDto
    {
        [Required]
        public string Name { get; set; }
        public double? TotalSavings { get; set; }
        public double InterestPercent { get; set; }
        public double InterestDollar { get; set; }
        // field used for net worth calculation 
    }
}