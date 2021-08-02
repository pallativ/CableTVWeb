using CableTV.Db;
using CableTVWeb.Business;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CableTVWeb.Controllers
{
    [Route("api/channel")]
    [ApiController]
    public class ChannelsController : ControllerBase
    {
        private readonly IChannelService _channelService;
        private readonly IModelConverter<CreateChannelModel, Channel> converter;

        public ChannelsController(IChannelService channelService, IModelConverter<CreateChannelModel, Channel> converter)
        {
            _channelService = channelService;
            this.converter = converter;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var items = await _channelService.GetAll();
            return Ok(items);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateChannelModel model)
        {
            var channel =  converter.ToModel(model);
            channel = await _channelService.Add(channel);
            return Created("", channel);
        }
    }

    public interface IModelConverter<TModel,TEntity>
    {
        TEntity ToModel(TModel model);
    }
}
