using System;
using System.ComponentModel.DataAnnotations;

namespace ChaosEmeraldsOfIncome.Models
{
    public class Note
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public int IncomeId { get; set; }
        public string Message { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}