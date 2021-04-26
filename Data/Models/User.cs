using System;
using System.ComponentModel.DataAnnotations;

namespace ChaosEmeraldsOfIncome.Controllers
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int NetWorthGoal { get; set; }
        public double? Contribution { get; set; }
        public int? RetirementAge { get; set; }
        public DateTime? LastLoggedIn { get; set; }
    }
}