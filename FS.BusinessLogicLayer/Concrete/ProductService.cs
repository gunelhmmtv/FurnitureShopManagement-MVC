﻿using AutoMapper;
using Azure.Core;
using FluentValidation;
using FS.BusinessLogicLayer.Abstract;
using FS.BusinessLogicLayer.Dtos;
using FS.BusinessLogicLayer.ValidationRules;
using FS.CoreLayer.Enums;
using FS.CoreLayer.Extentions;
using FS.CoreLayer.Wrappers.Implementations;
using FS.CoreLayer.Wrappers.Interfaces;
using FS.DataAccessLayer.Abstract;
using FS.Entity.Commons;
using FS.Entity.Products;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FS.BusinessLogicLayer.Concrete
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;
        private readonly IValidator<AddProductDto> _addProductDtoValidator;

        public ProductService(IProductRepository productRepository, IMapper mapper, IValidator<AddProductDto> addProductDtoValidator)
        {
            _productRepository = productRepository;
            _mapper = mapper;
            _addProductDtoValidator = addProductDtoValidator;
        }

        public async Task<IResponseResult> AddAsync(AddProductDto productDto)
        {
            var result = await _addProductDtoValidator.ValidateAsync(productDto);
            if (result.IsValid is false)
            {
                return new ResponseDataResult<bool>(result.ToResponseValidationResults());
            }

            var productEntity = _mapper.Map<Product>(productDto);
            var uploadedFilesEntity = _mapper.Map<ICollection<UploadedFile>>(productDto.UploadedFileDtos);

            productEntity.UploadedFiles = uploadedFilesEntity;

            await _productRepository.AddAsync(productEntity);
            try
            {
                await _productRepository.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                var e = ex;
            }
            await _productRepository.SaveChangesAsync();
            return new ResponseResult(FS.CoreLayer.Enums.ResponseType.SuccessResult, "Product was added succesfully");
        }

        public async Task<IResponseDataResult<IEnumerable<ProductViewDto>>> GetProductsAsync()
        {
            var product = await _productRepository.GetProductWithDetailAsync();
            var productView = _mapper.Map<IEnumerable<ProductViewDto>>(product);
            return new ResponseDataResult<IEnumerable<ProductViewDto>>(productView);
        }

        public async Task<IResponseDataResult<bool>> RemoveAsync(int id)
        {
            var product = await _productRepository.GetByIdAsync(id);
            if (product is null)
            {
                return new ResponseDataResult<bool>(ResponseType.NotFound, "Product not found to delete");
            }

            _productRepository.Remove(product);
            await _productRepository.SaveChangesAsync();
            return new ResponseDataResult<bool>(ResponseType.SuccessResult,"Succesfully deleted!");
        }

        

    }
}
