using System.Threading.Tasks;
using UrlShort.Domain.Models;

namespace UrlShort.Repositories
{
    public interface IRepository
    {
        Task Insert(UrlEntity urlEntity);
        Task<UrlEntity> GetUrlEntityByShortValue(string shortUrl);
    }
}