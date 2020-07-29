using FluentAssertions;
using System;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace IntegracaoAPI.IntegrationTests
{
	public class IntegracaoTest
	{
        private readonly TestContext _testContext;
        public IntegracaoTest()
        {
            _testContext = new TestContext();
        }

        [Fact]
        public async Task Values_Get_ReturnsOkResponse()
        {
            var response = await _testContext.Client.GetAsync("/IntegracaoXXX");
            response.EnsureSuccessStatusCode();
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }

        [Fact]
        public async Task Values_GetById_ValuesReturnsOkResponse()
        {
            var response = await _testContext.Client.GetAsync("/Integracao/5");
            response.EnsureSuccessStatusCode();
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }

        [Fact]
        public async Task Values_GetById_ReturnsBadRequestResponse()
        {
            var response = await _testContext.Client.GetAsync("/Integracao/XXX");
            response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
        }

        [Fact]
        public async Task Values_GetById_CorrectContentType()
        {
            var response = await _testContext.Client.GetAsync("/Integracao/5");
            response.EnsureSuccessStatusCode();
            response.Content.Headers.ContentType.ToString().Should().Be("text/plain; charset=utf-8");
        }
    }
}
