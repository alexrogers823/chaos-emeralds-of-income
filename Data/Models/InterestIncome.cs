using System;

namespace ChaosEmeraldsOfIncome.Controllers
{
    public class InterestIncome
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public int InterestPercent { get; set; }
        public int InterestDollar { get; set; }
        public DateTime DateAdded { get; set; }
    }
}