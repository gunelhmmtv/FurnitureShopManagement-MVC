using FS.DataAccessLayer.EntityFrameworkCore.Configurations.Commons;
using FS.Entity.Accounts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.DataAccessLayer.EntityFrameworkCore.Configurations.Accounts
{
    public class RegisterStatusConfig : BaseEntityConfig<RegisterStatus>
    {
        public override void Configure(EntityTypeBuilder<RegisterStatus> builder)
        {
            builder.Property(x => x.Value)
                .HasMaxLength(25)
                .HasColumnName("Value")
                .HasComment("For Registered Statuses");
        }
    }
}
