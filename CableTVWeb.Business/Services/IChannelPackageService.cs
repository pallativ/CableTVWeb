using CableTV.Db;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CableTVWeb.Business
{
    public interface IChannelPackageService
    {
        Task<IEnumerable<ChannelPackage>> GetAll();
        Task<IEnumerable<ChannelPackage>> Get(string channelName);
        Task<IEnumerable<ChannelPackage>> Get(int channelId);
        Task<IEnumerable<ChannelPackage>> GetByUserId(string userId);
    }
}
