using FinanceApp.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceApp.Data.Mapping
{
    public class ExpenseMap : IEntityTypeConfiguration<Expense>
    {
        public void Configure(EntityTypeBuilder<Expense> builder)
        {
            // validations and configuration types

            builder.Property(p => p.IdExpense)
                .HasColumnName("Id_Expense");
           // builder.Property(p => p.IdCategoryExpense).IsRequired();
            builder.Property(p => p.DescriptionExpense).HasColumnType("varchar(70)").IsRequired();

            builder.Property(p => p.AmountSpent).HasColumnType("decimal(11,2)").IsRequired();
            builder.Property(p => p.DateExpense).HasColumnType("datetime").IsRequired();           
            builder.Property(p => p.IdStatus).HasColumnType("int").HasColumnName("Id_Status").IsRequired();

            //relations
            builder.ToTable("Expense")
                   .HasKey(p => p.IdExpense);

            builder.HasOne(w => w.CategoryExpense)
                .WithMany(w => w.Expenses)
                .HasForeignKey(w => w.IdCategoryExpense)
                .OnDelete(DeleteBehavior.ClientSetNull);
        }
            
    }
}
