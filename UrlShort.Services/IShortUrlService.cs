using System.Threading.Tasks;

namespace UrlShort.Services
{
    public interface IShortUrlService
    {
        Task AddNewUrlAsync(string fullUrl);
        Task<string> GetFullUrlAsync(string shortUrl);
    }
}