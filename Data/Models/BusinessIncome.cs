using System;
using System.ComponentModel.DataAnnotations;

namespace ChaosEmeraldsOfIncome.Models
{
    public class BusinessIncome
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public string BusinessName { get; set; }
        public double Revenue { get; set; }
        public double Expenses { get; set; }
        public double Profit { get; set; }
        public bool IsCurrent { get; set; }
        public DateTime? LastUpdated { get; set; }
    }
}