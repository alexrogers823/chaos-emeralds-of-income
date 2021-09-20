using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChaosEmeraldsOfIncome.Models
{
    public class EarnedIncome
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        // [ForeignKey("UserId")]
        // public User User { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "{0} cannot exceed {1} characters")]
        public string IncomeTitle { get; set; }
        [Range(5, 999999, ErrorMessage = "Income should be between {0} and {1}")]
        public int IncomeAmount { get; set; }
        [Required]
        public string Frequency { get; set; }
        public bool IsActive { get; set; }
        public DateTime? LastUpdated { get; set; }
    }
}