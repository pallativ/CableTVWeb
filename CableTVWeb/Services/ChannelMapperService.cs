using AutoMapper;
using CableTV.Db;
using CableTVWeb.Controllers;
using System;

namespace CableTVWeb.Services
{
    public class ChannelMapperService : IChannelMapperService
    {
        private readonly IMapper _mapper;

        public ChannelMapperService(IMapper mapper)
        {
            _mapper = mapper;
        }
        public Channel ToEntity(ChannelModel model)
        {
            return _mapper.Map<Channel>(model);
        }

        public ChannelModel ToModel(Channel entity)
        {
            return _mapper.Map<ChannelModel>(entity);
        }
    }
}
