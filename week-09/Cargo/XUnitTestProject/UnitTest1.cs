using Cargos;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace XUnitTestProject
{
    public class HomeRocketShould
    {
        private readonly TestServer server;
        private readonly HttpClient client;

        public HomeRocketShould()
        {
            server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            client = server.CreateClient();
        }

        [Fact]
        public async Task ReturnJson()
        {
            var response = await client.GetAsync("api/rocket");
            string json = await response.Content.ReadAsStringAsync();
            Assert.Equal("{\"caliber25\":0,\"caliber30\":0,\"caliber50\":0,\"shipstatus\":\"empty\",\"ready\":false}", json);
        }

    }
}

