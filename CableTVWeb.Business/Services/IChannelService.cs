using CableTV.Db;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CableTVWeb.Business
{
    public interface IChannelService
    {
        Task<IEnumerable<Channel>> GetAll();
        Task<IEnumerable<Channel>> GetBy(Language language);
        Task<Channel> GetBy(string name);
        Task<Channel> Add(Channel channel);
        Task Delete(int channelId);
        Task<IEnumerable<Channel>> GetByUserId(string userId);
    }
}
