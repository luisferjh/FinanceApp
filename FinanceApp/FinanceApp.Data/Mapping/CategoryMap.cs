using FinanceApp.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceApp.Data.Mapping
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            // validations and configuration types

            builder.Property(p => p.IdCategory)
                .HasColumnName("Id_Category");

            builder.Property(p => p.Code)
                .HasColumnType("varchar(10)")
                .HasMaxLength(3)
                .IsRequired();

            builder.Property(p => p.Description)
                .HasColumnType("varchar(100)")
                .HasMaxLength(100)                
                .IsRequired();

            builder.Property(p => p.Icono)
                .HasColumnType("varchar(50)")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(p => p.Status)
                .HasColumnName("Status")
                .HasColumnType("bit")
                .IsRequired();


            builder.ToTable("Category")
                .HasKey(p => p.IdCategory);           
       
            //relations
        }
    }
}
