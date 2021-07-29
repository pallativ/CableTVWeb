using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CableTV.Db
{
    public class ChannelPackageItem
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public int ChannelPackageId { get; set; }
        [Required]
        public int ChannelId { get; set; }
        public ChannelPackage Package { get; set; }
        public Channel Channel { get; set; }
    }
}
