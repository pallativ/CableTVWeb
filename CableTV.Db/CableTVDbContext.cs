using Microsoft.EntityFrameworkCore;

namespace CableTV.Db
{
    public class CableTVDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Channel> Channels { get; set; }
        public DbSet<ChannelPackage> ChannelPackages { get; set; }
        public DbSet<ChannelPackageItem> ChannelPackageItems { get; set; }
        public DbSet<Promotion> Promotions { get; set; }
    }
}
