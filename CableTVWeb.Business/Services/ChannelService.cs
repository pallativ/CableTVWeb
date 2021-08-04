using CableTV.Db;
using CableTVWeb.Business.Exceptions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CableTVWeb.Business
{
    public class ChannelService : IChannelService
    {

        private readonly CableTVDbContext _dbContext;

        public ChannelService(CableTVDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Channel> Add(Channel channel)
        {
            var isAlredyExists = await IsExists((t) => t.ChannelName == channel.ChannelName);
            if (isAlredyExists)
                throw new ResourceConflictException();
            _dbContext.Channels.Add(channel);
            await _dbContext.SaveChangesAsync();
            return channel;
        }

        public Task<Channel> GetById(int channelId)
        {
            return _dbContext.Channels.FirstOrDefaultAsync(t => t.Id == channelId);
        }

        public Task<bool> IsExists(Expression<Func<Channel, bool>> predicate)
        {
            return _dbContext.Channels.AnyAsync(predicate);
        }

        public async Task Delete(int channelId)
        {
            var channel = await GetById(channelId);
            _dbContext.Channels.Remove(channel);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Channel>> GetAll()
        {
            return await _dbContext.Channels.ToListAsync();
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

        public Task<Channel> Update(Channel channel)
        {
            throw new NotImplementedException();
        }
    }
}
