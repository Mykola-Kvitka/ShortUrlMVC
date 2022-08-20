using NSubstitute;
using ShortUrlMVC.BLL.Interfaces;
using ShortUrlMVC.BLL.Services;
using ShortUrlMVC.DAL.Interfaces;
using ShortUrlMVC.DAL.Models;
using ShortUrlMVC.Tests.Mapping;
using System;
using Xunit;

namespace ShortUrlMVC.Tests
{
    public class ShortURLServiceTests
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ShortUrlService _sut;

        public ShortURLServiceTests()
        {
            var mapper = MapperFactory.InitMapper();
            _unitOfWork = Substitute.For<IUnitOfWork>();
            _sut = new ShortUrlService(_unitOfWork, mapper);
        }

        [Fact]
        public void Test1()
        {
            _unitOfWork.ShortURLs.CreateAsync(Arg.Any<ShortURLEntity>());
        }
    }
}
