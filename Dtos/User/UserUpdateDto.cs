namespace ChaosEmeraldsOfIncome.Dtos
{
    public class UserUpdateDto
    {
        public string Name { get; set; }
        public int NetWorthGoal { get; set; }
        public double? Contribution { get; set; }
        public int? RetirementAge { get; set; }
    }
}