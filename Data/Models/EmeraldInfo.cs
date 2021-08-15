using System.ComponentModel.DataAnnotations;

namespace ChaosEmeraldsOfIncome.Models
{
    public class EmeraldInfo
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Quote { get; set; }
        public string Author { get; set; }
        public string EmeraldImageUrl { get; set; }
    }
}