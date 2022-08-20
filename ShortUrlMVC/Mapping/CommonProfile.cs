using AutoMapper;
using ShortUrlMVC.BLL.Models;
using ShortUrlMVC.PL.ViewModels;
using ShortUrlMVC.DAL.Models;
using System.Linq.Expressions;
using System;

namespace ShortUrlMVC.PL.Mapping
{
    public class CommonProfile : Profile
    {
        public CommonProfile()
        {
            AddBusinessMapping();
            AddWebMapping();
        }

        public void AddWebMapping()
        {
            CreateMap<ShortURLEntity, ShortURL>().ReverseMap();
        }

        public void AddBusinessMapping()
        {
            CreateMap<ShortURL, ShortURLViewModel>().ReverseMap();
        }
    }
}
