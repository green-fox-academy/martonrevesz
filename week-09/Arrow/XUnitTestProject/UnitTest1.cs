using Arrow;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace XUnitTestProject
{
    public class HomeYonduShould
    {
        private readonly TestServer server;
        private readonly HttpClient client;

        public HomeYonduShould()
        {
            server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            client = server.CreateClient();
        }

        [Fact]
        public async Task ReturnStatusOk()
        {
            var response = await client.GetAsync("api/yondu?distance=100.00&time=10.00");
            string json = await response.Content.ReadAsStringAsync();
            Assert.Equal("{\"distance\":100.0,\"time\":10.0,\"speed\":10.0}", json);
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task ReturnStatusBadRequest()
        {
            var response = await client.GetAsync("api/yondu?distance=100.00");
            string json = await response.Content.ReadAsStringAsync();
            Assert.Equal("{\"error\":\"Error occured!\"}", json);
            Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
        }
    }
}
