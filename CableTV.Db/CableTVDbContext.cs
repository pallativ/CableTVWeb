using Microsoft.EntityFrameworkCore;

namespace CableTV.Db
{
    public class CableTVDbContext : DbContext
    {
        public CableTVDbContext(DbContextOptions<CableTVDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Channel> Channels { get; set; }
        public DbSet<ChannelPackage> ChannelPackages { get; set; }
        public DbSet<ChannelPackageItem> ChannelPackageItems { get; set; }
        public DbSet<Promotion> Promotions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Channel>().ToTable("Channel");
        }
    }
}
