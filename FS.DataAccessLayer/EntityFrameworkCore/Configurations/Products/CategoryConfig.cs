using FS.DataAccessLayer.EntityFrameworkCore.Configurations.Commons;
using FS.Entity.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.DataAccessLayer.EntityFrameworkCore.Configurations.Products
{
    public class CategoryConfig : EditedBaseEntityConfig<Category>
    {
        public override void Configure(EntityTypeBuilder<Category> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Value)
                .HasMaxLength(24);

            builder.HasData([
                new Category { Id = 1, Value = "Kitchen", CreatedId = 1, CreatedDate = DateTime.UtcNow, UpdatedId = 1, UpdatedDate = DateTime.UtcNow },
                new Category { Id = 2, Value = "Bedroom", CreatedId = 1, CreatedDate = DateTime.UtcNow, UpdatedId = 1, UpdatedDate = DateTime.UtcNow },
                new Category { Id = 3, Value = "Guest room", CreatedId = 1, CreatedDate = DateTime.UtcNow, UpdatedId = 1, UpdatedDate = DateTime.UtcNow },
                new Category { Id = 4, Value = "Bathroom", CreatedId = 1, CreatedDate = DateTime.UtcNow, UpdatedId = 1, UpdatedDate = DateTime.UtcNow },
            ]);

        }
    }
}
