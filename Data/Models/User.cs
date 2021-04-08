using System;

namespace ChaosEmeraldsOfIncome.Controllers
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public double? Contribution { get; set; }
        public int? RetirementAge { get; set; }
        public DateTime? LastLoggedIn { get; set; }
    }
}