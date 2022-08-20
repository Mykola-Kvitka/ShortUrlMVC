using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShortUrlMVC.DAL.Models;

namespace ShortUrlMVC.DAL.Interfaces
{
    public interface IUnitOfWork
    {
        IGenericRepository<ShortURLEntity> ShortURLs { get; }
    }
}
