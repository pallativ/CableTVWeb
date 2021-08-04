using System.ComponentModel.DataAnnotations.Schema;

namespace CableTV.Db
{
    public class Channel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public Language Language { get; set; }
        public int ChannelNumber { get; set; }
        public decimal Price { get; set; }
    }
}
