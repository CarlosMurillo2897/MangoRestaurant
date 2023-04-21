using AutoMapper;
using Mango.Services.ProductAPI.Models;

namespace Mango.Services.ProductAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps() => 
            new MapperConfiguration(config =>
            {
                // Map properties if use the same name.
                config.CreateMap<ProductDTO, Product>();
                config.CreateMap<Product, ProductDTO>();
            });
    }
}
