using CableTV.Db;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CableTVWeb.Business
{
    public class PromotionService : IPromotionService
    {

    }
    public class ChannelService : IChannelService
    {

        private readonly DbContext _dbContext;

        public ChannelService(DbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Task<Channel> Add(Channel channel)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int channelId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Channel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Channel>> GetBy(Language language)
        {
            throw new NotImplementedException();
        }

        public Task<Channel> GetBy(string name)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Channel>> GetByUserId(string userId)
        {
            throw new NotImplementedException();
        }
    }
}
