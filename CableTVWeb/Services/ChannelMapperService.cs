using CableTV.Db;
using CableTVWeb.Controllers;
using System;

namespace CableTVWeb.Services
{
    public class ChannelMapperService : IChannelMapperService
    {
        public Channel ToEntity(ChannelModel model)
        {
            var channel = new Channel()
            {
                Id = model.ChannelNumber,
                ChannelName = model.Name,
                Language = model.Language,
                Price = model.Price
            };
            return channel;
        }

        public ChannelModel ToModel(Channel entity)
        {
            throw new NotImplementedException();
        }
    }
}
