using System;

namespace ChaosEmeraldsOfIncome.Controllers
{
    public class Goal
    {
        public int UserId { get; set; }
        public int EmeraldId { get; set; }
        public int Objective { get; set; }
        public DateTime? LastEdited { get; set; }
    }
}