using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FS.Entity.Products;

namespace FS.DataAccessLayer.EntityFrameworkCore.Configurations.Products
{
    public class ProductOrderConfig : IEntityTypeConfiguration<ProductOrder>
    {
        public void Configure(EntityTypeBuilder<ProductOrder> builder)
        {
            builder.Ignore(x => x.Id);
            builder.HasKey(x => new { x.ProductId, x.OrderId });

        }
    }
}
