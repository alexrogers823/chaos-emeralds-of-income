using System;

namespace ChaosEmeraldsOfIncome.Controllers
{
    public class RoyaltyIncome
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Frequency { get; set; }
        public double Amount { get; set; }
        public DateTime? LastUpdated { get; set; }
    }
}