using AutoMapper;
using AutoMapper.Configuration;

namespace Hospital.Utilities
{
    public interface IHaveCustomMappings
    {
        void CreateMappings(IConfiguration configuration);
    }
}
