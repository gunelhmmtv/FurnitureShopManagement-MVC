using FS.BusinessLogicLayer.Dtos;
using FS.CoreLayer.Wrappers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.BusinessLogicLayer.Abstract
{
    public interface IProductService
    {
        Task<IResponseDataResult<IEnumerable<ProductViewDto>>> GetProductsAsync();
        Task<IResponseResult> AddAsync(AddProductDto productDto);

        Task<IResponseDataResult<bool>> RemoveAsync(int id);


    }
}
