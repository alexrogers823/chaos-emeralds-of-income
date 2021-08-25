using System.ComponentModel.DataAnnotations;

namespace ChaosEmeraldsOfIncome.Dtos
{
    public class EarnedIncomeCreateDto
    {
        [Required]
        public string IncomeTitle { get; set; }
        public int IncomeAmount { get; set; }
        [Required]
        public string Frequency { get; set; }
    }
}