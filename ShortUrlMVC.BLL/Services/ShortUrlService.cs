using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShortUrlMVC.BLL.Interfaces;
using ShortUrlMVC.BLL.Models;
using ShortUrlMVC.DAL.Interfaces;
using ShortUrlMVC.DAL.Models;
using ShortUrlMVC.BLL.Helpers;

namespace ShortUrlMVC.BLL.Services
{
    public class ShortUrlService : IShortURLService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ShortUrlService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<bool> CreateAsync(ShortURL request)
        {
            var requestEntity = _mapper.Map<ShortURL, ShortURLEntity>(request);

            if (GetAsync(requestEntity.OrginalURLId) == null) { 

            requestEntity.CreateDate = DateTime.Now;
            requestEntity.Short = ShortLinkHelper.GetUrlChunk(requestEntity.OrginalURLId);

            await _unitOfWork.ShortURLs.CreateAsync(requestEntity);
            return true;
            }

            return false;

        }

        public void DeleteAsync(string id)
        {
            _unitOfWork.ShortURLs.DeleteAsync(id);
        }

        public async Task<IEnumerable<ShortURL>> GetAllAsync()
        {
            var post = await _unitOfWork.ShortURLs.GetAllAsync();

            return _mapper.Map<IEnumerable<ShortURLEntity>, IEnumerable<ShortURL>>(post);
        }

        public async Task<ShortURL> GetAsync(string id)
        {
            var result = await _unitOfWork.ShortURLs.GetAsync(id);

            return _mapper.Map<ShortURLEntity, ShortURL>(result);
        }

    }
}
