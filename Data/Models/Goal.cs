using System;
using System.ComponentModel.DataAnnotations;

namespace ChaosEmeraldsOfIncome.Controllers
{
    public class Goal
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public int EmeraldId { get; set; }
        public int Objective { get; set; }
        public DateTime? LastEdited { get; set; }
    }
}