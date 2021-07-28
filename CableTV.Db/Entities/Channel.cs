namespace CableTV.Db
{
    public class Channel
    {
        public int Id { get; set; }
        public string ChannelName { get; set; }
        public Language Language { get; set; }
        public int ChannelNumber { get; set; }
        public decimal Price { get; set; }
    }
}
