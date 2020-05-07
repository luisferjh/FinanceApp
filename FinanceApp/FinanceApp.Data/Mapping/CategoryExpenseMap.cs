using FinanceApp.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceApp.Data.Mapping
{
    public class CategoryExpenseMap : IEntityTypeConfiguration<CategoryExpense>
    {
        public void Configure(EntityTypeBuilder<CategoryExpense> builder)
        {
            // validations and configuration types

            builder.Property(p => p.IdCategoryExpense)
                .HasColumnName("Id_CategoryExpense");

            builder.Property(p => p.CodCategoryExpense)
                .HasColumnType("varchar(3)")
                .HasMaxLength(3)
                .IsRequired();

            builder.Property(p => p.DescriptionCategoryExpense)
                .HasColumnType("varchar(100)")
                .HasMaxLength(100)                
                .IsRequired();

            builder.Property(p => p.IdStatus)
                .HasColumnName("Id_Status")
                .HasColumnType("int")
                .IsRequired();

            //relations
            builder.ToTable("CategoryExpense")
                .HasKey(p => p.IdCategoryExpense);           
       
        }
    }
}
