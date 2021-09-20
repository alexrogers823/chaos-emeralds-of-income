using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChaosEmeraldsOfIncome.Models
{
    public class InterestIncome
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        // [ForeignKey("UserId")]
        // public User User { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "{0} cannot exceed {1} characters")]
        public string Name { get; set; }
        public double? TotalSavings { get; set; }
        [Range(0.01, 25, ErrorMessage = "Percentage must be between {0} and {1}")]
        public double InterestPercent { get; set; }
        public double InterestDollar { get; set; }
        // field used for net worth calculation 
        public bool IsActive { get; set; }
        public DateTime? DateAdded { get; set; }
        public DateTime? LastUpdated { get; set; }
    }
}