using FS.DataAccessLayer.Abstract;
using FS.DataAccessLayer.EntityFrameworkCore.Contexts;
using FS.Entity.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.DataAccessLayer.EntityFrameworkCore.Concrete
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(FsContext dbContext) : base(dbContext)
        {
        }
    }
}
