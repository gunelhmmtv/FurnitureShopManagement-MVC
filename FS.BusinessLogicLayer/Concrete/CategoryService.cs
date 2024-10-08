using FS.BusinessLogicLayer.Abstract;
using FS.DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.BusinessLogicLayer.Concrete
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoryService(ICategoryRepository categoryRepository )
        {
            _categoryRepository = categoryRepository;
        }
        public async Task<IDictionary<int, string>> GetCategoryDictionaryAsync()
        {
            return await _categoryRepository.GetDictionaryAsync(x => x.Id, x => x.Value);
        }
    }
}
