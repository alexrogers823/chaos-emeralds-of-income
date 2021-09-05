using System;

namespace ChaosEmeraldsOfIncome.Dtos
{
    public class UserReadDto
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int NetWorthGoal { get; set; }
        public double? Contribution { get; set; }
        public int? RetirementAge { get; set; }
        public DateTime? LastLoggedIn { get; set; }
    }
}