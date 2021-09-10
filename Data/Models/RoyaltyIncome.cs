using System;
using System.ComponentModel.DataAnnotations;

namespace ChaosEmeraldsOfIncome.Models
{
    public class RoyaltyIncome
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; }
        public string Frequency { get; set; }
        public double Amount { get; set; }
        public bool IsActive { get; set; }
        public DateTime? LastUpdated { get; set; }
    }
}