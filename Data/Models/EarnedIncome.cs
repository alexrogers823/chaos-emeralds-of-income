using System;
using System.ComponentModel.DataAnnotations;

namespace ChaosEmeraldsOfIncome.Controllers
{
    public class EarnedIncome
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        [Required]
        public string IncomeTitle { get; set; }
        public int IncomeAmount { get; set; }
        [Required]
        public string Frequency { get; set; }
        public bool IsCurrent { get; set; }
        public DateTime? LastUpdated { get; set; }
    }
}