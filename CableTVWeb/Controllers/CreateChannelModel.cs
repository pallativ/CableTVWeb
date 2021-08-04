using CableTV.Db;
using System.ComponentModel.DataAnnotations;

namespace CableTVWeb.Controllers
{
    public class ChannelModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public int Id { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public Language Language { get; set; }
    }
}
