using CableTV.Db;
using CableTVWeb.Business;
using CableTVWeb.Mappers;
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
        private readonly IChannelMapperService _mapperServce;

        public ChannelsController(IChannelService channelService, IChannelMapperService mapperService)
        {
            _channelService = channelService;
            _mapperServce = mapperService;
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
            var channel = _mapperServce.ToEntity(model);
            channel = await _channelService.Add(channel);
            return Created("", channel);
        }

        [HttpPut]
        public async Task<IActionResult> Update(ChannelModel model)
        {
            var channel = await _channelService.GetById(model.ChannelNumber);
            if (channel == null)
                return NotFound();
            channel = _mapperServce.ToEntity(model);
            channel = await _channelService.Update(channel);
            return Ok(channel);
        }

        [HttpGet("/{laungageId}")]
        public async Task<IActionResult> Get(int laungageId)
        {
            var channels = await _channelService.GetBy((Language)laungageId);
            var models = channels.Select(t => _mapperServce.ToModel(t));
            return Ok(models);
        }
    }
}
