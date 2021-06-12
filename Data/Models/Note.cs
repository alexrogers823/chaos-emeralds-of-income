using System;

namespace ChaosEmeraldsOfIncome.Controllers
{
    public class Note
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int IncomeId { get; set; }
        public string Message { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}