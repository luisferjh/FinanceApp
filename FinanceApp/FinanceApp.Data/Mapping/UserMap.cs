using FinanceApp.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceApp.Data.Mapping
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            // validations and configurations types
            builder.Property(p => p.IdUser)
                .HasColumnName("Id_User");

            builder.Property(p => p.UserName)
                .HasColumnType("varchar(100)")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(p => p.Email)
                .HasColumnType("varchar(60)")
                .HasMaxLength(60)                
                .IsRequired();

            builder.Property(p => p.PasswordHash)
                .HasMaxLength(250)
                .IsRequired();

            builder.Property(p => p.PasswordSalt)
                .HasMaxLength(250)
                .IsRequired();

            builder.Property(p => p.IdStatus)
                .HasColumnName("Id_Status")
                .HasColumnType("int")
                .IsRequired();


            builder.ToTable("User")
                .HasKey(w => w.IdUser);
        }
    }
}
