using CableTV.Db;
using System.ComponentModel.DataAnnotations;

namespace CableTVWeb.Controllers
{
    public class CreateChannelModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public int ChannelNumber { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public Language Language { get; set; }
    }
}
