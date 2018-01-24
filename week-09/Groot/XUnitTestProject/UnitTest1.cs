using Groot;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace XUnitTestProject
{
    public class GuardianTests
    {
        private HttpClient client;
        private TestServer server;

        public GuardianTests()
        {
            server = new TestServer(new WebHostBuilder().
                UseStartup<Startup>());
            client = server.CreateClient();
        }

        [Fact]
        public async Task IndexShouldReturnOkStatus()
        {
            var response = await client.GetAsync("/api/groot?message=hello");
            string json = await response.Content.ReadAsStringAsync();
            Assert.Equal("{\"received\":\"hello\",\"translated\":\"I am Groot!\"}", json);

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task IndexShouldReturnNotOkStatus()
        {
            var response = await client.GetAsync("/api/groot");
            string json = await response.Content.ReadAsStringAsync();
            Assert.Equal("{\"error\":\"I am Groot!\"}", json);

            Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
        }
    }
}
