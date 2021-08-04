using AutoMapper;
using CableTV.Db;
using CableTVWeb.Controllers;

namespace CableTVWeb.Services
{
    public class ChannelMapProfile : Profile
    {
        public ChannelMapProfile()
        {
            CreateMap<Channel, ChannelModel>()
                .ForMember(t => t.ChannelNumber, options => options.MapFrom(src => src.Id));

            CreateMap<ChannelModel, Channel>()
              .ForMember(t => t.Id, options => options.MapFrom(src => src.ChannelNumber))
              .ForMember(t => t.ChannelName, options => options.MapFrom(src => src.Name));
        }
    }
}
