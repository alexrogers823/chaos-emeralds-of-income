using System;

namespace ChaosEmeraldsOfIncome.Controllers
{
    public class InterestIncome
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public double InterestPercent { get; set; }
        public double InterestDollar { get; set; }
        public DateTime? DateAdded { get; set; }
    }
}