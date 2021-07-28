using CableTV.Db;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CableTVWeb.Business
{
    public class ChannelPackageService : IChannelPackageService
    {
        public Task<IEnumerable<ChannelPackage>> Get(string channelName)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ChannelPackage>> Get(int channelId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ChannelPackage>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ChannelPackage>> GetByUserId(string userId)
        {
            throw new NotImplementedException();
        }
    }
}
