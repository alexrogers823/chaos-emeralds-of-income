using System;

namespace ChaosEmeraldsOfIncome.Controllers
{
    public class DividendIncome
    {
        public int Id { get; set; }
        public int InvestmentId { get; set; }
        public double DividendPayout { get; set; }
        public DateTime? DateAdded { get; set; }
    }
}