using System;

namespace ChaosEmeraldsOfIncome.Dtos
{
    public class EarnedIncomeReadDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string IncomeTitle { get; set; }
        public int IncomeAmount { get; set; }
        public string Frequency { get; set; }
        public bool IsCurrent { get; set; }
        public DateTime? LastEdited { get; set; }
    }
}