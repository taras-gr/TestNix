using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using UrlShort.Domain.Models;

namespace UrlShort.Repositories
{
    public class Repository : IRepository
    {
        private DataContext _dataContext;

        public Repository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<UrlEntity> GetUrlEntityByShortValue(string shortUrl)
        {
            var urlEntity = await _dataContext.UrlEntities
                .FirstOrDefaultAsync(s => s.ShortedUrl == shortUrl);

            return urlEntity;
        }

        public async Task Insert(UrlEntity urlEntity)
        {
            await _dataContext.UrlEntities.AddAsync(urlEntity);

            await _dataContext.SaveChangesAsync();
        }
    }
}