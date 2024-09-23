using FS.Entity.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.DataAccessLayer.Abstract
{
    public interface IProductOrderRepository : IGenericRepository<ProductOrder>
    {
    }
}
