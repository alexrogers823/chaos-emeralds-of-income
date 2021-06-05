using System;

namespace ChaosEmeraldsOfIncome.Controllers
{
    public class CapitalGains
    {
        public int Id { get; set; }
        public string Investment { get; set; }
        public double Value { get; set; }
        public DateTime LastLoggedIn { get; set; }
    }
}