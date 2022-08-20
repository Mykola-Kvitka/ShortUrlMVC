using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShortUrlMVC.DAL.DataAccses;
using ShortUrlMVC.DAL.Interfaces;
using ShortUrlMVC.DAL.Models;
using ShortUrlMVC.DAL.Repositories;

namespace ShortUrlMVC.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataAccsess _appData;

        private GenericRepository<ShortURLEntity> _shortURL;

        public UnitOfWork(DataAccsess appData)
        {
            _appData = appData;
        }

        public IGenericRepository<ShortURLEntity> ShortURLs => _shortURL ??= new GenericRepository<ShortURLEntity>(_appData);

    }
}
