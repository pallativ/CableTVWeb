using System;

namespace CableTV.Db
{
    public class UserChannelPackageSubscription
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int ChannelPackageId { get; set; }
        public ChannelPackage ChannelPackage { get; set; }
        public DateTime SubscribedDate { get; set; }
    }
}
