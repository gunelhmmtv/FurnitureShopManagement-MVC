﻿using FS.DataAccessLayer.EntityFrameworkCore.Configurations.Commons;
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
    public class UserDetailConfig : BaseEntityConfig<UserDetail>
    {
        public override void Configure(EntityTypeBuilder<UserDetail> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.FirstName)
                .HasMaxLength(25)
                .IsRequired(true)
                .HasColumnName("FirstName");

            builder.Property(x => x.FirstName)
                .HasMaxLength(25)
                .IsRequired(true)
                .HasColumnName("FirstName");

            builder.Property(x => x.ConfirmCode)
                .IsRequired(false)
                .HasColumnName("ConfirmCode");

            builder.Property(x => x.LastName)
                .HasMaxLength(25)
                .IsRequired(true)
                .HasColumnName("LastName");

            builder.Property(x => x.DateOfBirth)
                .IsRequired(false)
                .HasColumnType("datetime")
                .HasColumnName("DateOfBirth");

            builder.Ignore(x => x.FullName);

            builder.HasIndex(x => x.UserId).IsUnique();



        }
    }
}
