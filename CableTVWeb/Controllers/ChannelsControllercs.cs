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
        private readonly IModelConverter<ChannelModel, Channel> converter;

        public ChannelsController(IChannelService channelService, IModelConverter<ChannelModel, Channel> converter)
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
        public async Task<IActionResult> Create(ChannelModel model)
        {
            var channel = converter.ToEntity(model);
            channel = await _channelService.Add(channel);
            return Created("", channel);
        }

        [HttpPut]
        public async Task<IActionResult> Update(ChannelModel model)
        {
            var channel = await _channelService.GetById(model.ChannelNumber);
            if (channel == null)
                return NotFound();
            channel = converter.ToEntity(model);
            channel = await _channelService.Update(channel);
            return Ok(channel);
        }

        [HttpGet("/{laungageId}")]
        public async Task<IActionResult> Get(int laungageId)
        {
            var channels = await _channelService.GetBy((Language)laungageId);
            var models = channels.Select(t => converter.ToModel(t));
            return Ok(models);
        }
    }
}
