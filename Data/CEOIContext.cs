using Microsoft.EntityFrameworkCore;

namespace ChaosEmeraldsOfIncome.Controllers
{
    public class CEOIContext : DbContext
    {
        public CEOIContext(DbContextOptions<CEOIContext> options) : base(options)
        {
            
        }

        public DbSet<EarnedIncome> EarnedIncome { get; set; }
        public DbSet<InterestIncome> InterestIncome { get; set; }
        public DbSet<RentalIncome> RentalIncome { get; set; }
        public DbSet<CapitalGains> CapitalGains { get; set; }
        public DbSet<DividendIncome> DividendIncome { get; set; }
        public DbSet<RoyaltyIncome> RoyaltyIncome { get; set; }
        public DbSet<BusinessIncome> BusinessIncome { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Goal> Goals { get; set; }
        public DbSet<EmeraldInfo> Emeralds { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<Resource> Resources { get; set; }

    }
}