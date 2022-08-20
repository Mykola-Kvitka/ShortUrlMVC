using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShortUrlMVC.BLL.Models;

namespace ShortUrlMVC.BLL.Interfaces
{
    public interface IShortURLService
    {
        Task<bool> CreateAsync(ShortURL request);
        Task<IEnumerable<ShortURL>> GetAllAsync();
        void DeleteAsync(string id);
        Task<ShortURL> GetAsync(string id);
    }
}
