using System;
using System.ComponentModel.DataAnnotations;

namespace ChaosEmeraldsOfIncome.Dtos
{
    public class EarnedIncomeUpdateDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        [Required]
        public string IncomeTitle { get; set; }
        [Required]
        public int IncomeAmount { get; set; }
        [Required]
        public string Frequency { get; set; }
        public bool IsCurrent { get; set; }
        public DateTime? LastEdited { get; set; }
    }
}