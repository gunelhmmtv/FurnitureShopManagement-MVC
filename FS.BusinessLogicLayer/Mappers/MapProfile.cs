using AutoMapper;
using FS.BusinessLogicLayer.Dtos;
using FS.Entity.Accounts;
using FS.Entity.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.BusinessLogicLayer.Mappers
{
    public class MapProfile : Profile
    {
        public MapProfile() 
        {
            CreateMap<ProductViewDto, Product>();
            CreateMap<Product,ProductViewDto>();
            CreateMap<AddProductDto, Product>();
            CreateMap<Product,AddProductDto>();
            CreateMap<UpdateProductDto, Product>();
            CreateMap<Product,UpdateProductDto>();

            CreateMap<CreateUserDto, User>();
            CreateMap<CreateUserDto, UserDetail>();
        }
    }
}
