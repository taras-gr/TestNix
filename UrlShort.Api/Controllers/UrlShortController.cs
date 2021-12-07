using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using UrlShort.Services;

namespace UrlShort.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UrlShortController : ControllerBase
    {
        private IShortUrlService _shortUrlService;
        private readonly ILogger _logger;

        public UrlShortController(IShortUrlService shortUrlService,
            ILogger<UrlShortController> logger)
        {
            _logger = logger;
            _shortUrlService = shortUrlService;
        }

        [HttpGet]
        public async Task<ActionResult<string>> GetFullUrlByShort(string shortUrl)
        {
            try
            {
                var fullUrl = await _shortUrlService.GetFullUrlAsync(shortUrl);
                _logger.LogInformation($"FullUrl: {fullUrl}");

                return Redirect(fullUrl);
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }
        }

        [HttpPost]
        public async Task<ActionResult> ShortUrl([FromBody]string fullUrl)
        {
            try
            {
                await _shortUrlService.AddNewUrlAsync(fullUrl);

                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }
        }
    }
}