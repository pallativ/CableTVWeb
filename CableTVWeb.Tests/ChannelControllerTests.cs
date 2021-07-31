using CableTV.Db;
using CableTVWeb.Controllers;
using Microsoft.AspNetCore.Mvc.Testing;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace CableTVWeb.Tests
{
    public class ChannelControllerTests
      : IClassFixture<WebApplicationFactory<Startup>>
    {
        private readonly WebApplicationFactory<Startup> _factory;

        public ChannelControllerTests(WebApplicationFactory<Startup> factory)
        {
            _factory = factory;
        }

        [Fact]
        public async Task GetAll_Of_Channel_Controller()
        {
            // Arrange
            var client = _factory.CreateClient();

            // Act
            var response = await client.GetAsync("/api/channel");
            var content = await response.Content.ReadAsStringAsync();

            // Assert
            response.EnsureSuccessStatusCode(); // Status Code 200-299
            Assert.NotEmpty(content);
        }

        //[Fact]
        //public async Task VerifyCreateChannel()
        //{
        //    // Arrange
        //    var client = _factory.CreateClient();
        //    var model = new CreateChannelModel() { ChannelNumber = 1, Name = "TV1", Price = 10, Language = CableTV.Db.Language.Telugu };
        //    var dbContext = _factory.Services.GetService(typeof(CableTVDbContext));

        //    // Act
        //    //var response = await client.PostAsync("/api/channel", new HttpContent() { JsonConvert.SerializeObject(model) });
        //    //var content = await response.Content.ReadAsStringAsync();

        //    // Assert
        //    //response.EnsureSuccessStatusCode(); // Status Code 200-299
        //    //Assert.Equal("Success from controllers", content);
        //}
    }
}
