using AutoMapper;
using FS.BusinessLogicLayer.Dtos;
using FS.BusinessLogicLayer.ValidationRules;
using FS.Entity.Accounts;
using FS.Entity.Commons;
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
            CreateMap<AddProductDto, Product>();
            CreateMap<UpdateProductDto, Product>();
            CreateMap<CreateUserDto, User>();
            CreateMap<CreateUserDto, UserDetail>();
            CreateMap<UploadedFileDto, UploadedFile>();
            CreateMap<Product,ProductViewDto>()
                .ForMember(dest=>dest.Category,opt=>opt.MapFrom(src=>src.Category.Value))
                .ForMember(dest=>dest.Url,opt=>opt.MapFrom(src=>src.UploadedFiles.FirstOrDefault().FileName));
        }
    }
}
