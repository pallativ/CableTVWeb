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

        public ChannelsController(IChannelService channelService)
        {
            _channelService = channelService;
            var channel = _channelService.Add(new Channel()
            {
                ChannelName = "TV",
                ChannelNumber = 1,
                Language = Language.Telugu,
                Price = 10
            }).Result;

        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var items = await _channelService.GetAll();
            return Ok(items);
        }

        //[HttpPost]
        //public async Task<IActionResult> Create(CreateChannelModel model)
        //{

        //    return Created("", channel);
        //}
    }
}
