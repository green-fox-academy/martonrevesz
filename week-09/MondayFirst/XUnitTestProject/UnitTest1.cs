using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using MondayFirst;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace XUnitTestProject
{
    public class HomeDoubleShould
    {
        private readonly TestServer server;
        private readonly HttpClient client;

        public HomeDoubleShould()
        {
            server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            client = server.CreateClient();
        }


        [Fact]
        public async Task ReturnOkStatus()
        {
            var response = await client.GetAsync("/api/doubling?input=4");


            string json = await response.Content.ReadAsStringAsync();
            Assert.Equal( "{\"received\":4,\"result\":8}", json);

        }
    }
}
