using System.ComponentModel.DataAnnotations;

namespace ChaosEmeraldsOfIncome.Dtos
{
    public class EarnedIncomeCreateDto
    {
        public int UserId { get; set; }
        [Required]
        public string IncomeTitle { get; set; }
        public int IncomeAmount { get; set; }
        [Required]
        public string Frequency { get; set; }
    }
}