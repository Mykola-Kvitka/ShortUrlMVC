using AutoMapper;
using ShortUrlMVC.PL;

namespace ShortUrlMVC.Tests.Mapping
{
    public static class MapperFactory
    {
        private static readonly Mapper _mapper;

        static MapperFactory()
        {
            var configuration = new MapperConfiguration(options =>
                options.AddMaps(typeof(Startup).Assembly));
        }

        public static IMapper InitMapper()
        {
            return _mapper;
        }
    }
}
