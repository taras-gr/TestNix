using System.Threading.Tasks;
using UrlShort.Domain.Models;
using UrlShort.Domain.UrlShortLogic;
using UrlShort.Repositories;

namespace UrlShort.Services
{
    public class ShortUrlService : IShortUrlService
    {
        private IRepository _repository;
        private UrlShorterProcessor _urlShorterProcessor;

        public ShortUrlService(IRepository repository)
        {
            _repository = repository;
            _urlShorterProcessor = new UrlShorterProcessor();
        }

        public async Task AddNewUrlAsync(string fullUrl)
        {
            var shortUrl = _urlShorterProcessor.ShortUrl();

            var urlEntity = new UrlEntity()
            {
                FullUrl = fullUrl,
                ShortedUrl = shortUrl
            };

            await _repository.Insert(urlEntity);
        }

        public async Task<string> GetFullUrlAsync(string shortUrl)
        {
            var fullUrl = await _repository.GetUrlEntityByShortValue(shortUrl);

            return fullUrl.FullUrl;
        }
    }
}