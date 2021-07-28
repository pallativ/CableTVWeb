namespace CableTV.Db
{
    public class ChannelPackageItem
    {
        public int Id { get; set; }
        public int ChannelPackageId { get; set; }
        public int ChannelId { get; set; }
        public ChannelPackage Package { get; set; }
        public Channel Channel { get; set; }
    }
}
