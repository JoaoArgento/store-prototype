using AutoMapper;
using Catalog.Shared.Entities;
using Catalog.Shared.Models;

namespace Catalog.Shared.Mappings
{
    public class CatalogMappingProfile : Profile
    {
        public CatalogMappingProfile()
        {
            CreateMap<ProductModel, Product>();
        }


    }
}
