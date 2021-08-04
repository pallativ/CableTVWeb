using AutoMapper;
using CableTV.Db;
using CableTVWeb.Controllers;

namespace CableTVWeb.Mappers.Profiles
{
    public class ChannelMapProfile : Profile
    {
        public ChannelMapProfile()
        {
            CreateMap<Channel, ChannelModel>()
                .ForMember(t => t.Id, options => options.MapFrom(src => src.Id));

            CreateMap<ChannelModel, Channel>()
              .ForMember(t => t.Id, options => options.MapFrom(src => src.Id))
              .ForMember(t => t.Name, options => options.MapFrom(src => src.Name));
        }
    }
}
