using AutoMapper;
using FluentValidation;
using FS.BusinessLogicLayer.Abstract;
using FS.BusinessLogicLayer.Dtos;
using FS.CoreLayer.Enums;
using FS.CoreLayer.Wrappers.Implementations;
using FS.CoreLayer.Wrappers.Interfaces;
using FS.DataAccessLayer.Abstract;
using FS.Entity.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace FS.BusinessLogicLayer.Concrete
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductService(IProductRepository productRepository,IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper= mapper;
        }

        public async Task<IResponseResult> AddAsync(AddProductDto productDto)
        {
            var product = _mapper.Map<Product>(productDto);
            await _productRepository.AddAsync(product);
            return new ResponseResult(ResponseType.SuccessResult, "Product was added succesfully");
        }

        public async Task<IResponseDataResult<IEnumerable<ProductViewDto>>> GetProductsAsync()
        {
            var product = await _productRepository.GetAllAsync();
            var productView = _mapper.Map<IEnumerable<ProductViewDto>>(product);
            return new ResponseDataResult<IEnumerable<ProductViewDto>>(productView);

        }
      

       
    }
}
