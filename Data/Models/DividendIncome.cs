using System;
using System.ComponentModel.DataAnnotations;

namespace ChaosEmeraldsOfIncome.Models
{
    public class DividendIncome
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public int InvestmentId { get; set; }
        public double DividendPayout { get; set; }
        public DateTime? DateAdded { get; set; }
    }
}