using FinanceApp.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceApp.Data.Mapping
{
    public class OperationMap : IEntityTypeConfiguration<Operation>
    {
        public void Configure(EntityTypeBuilder<Operation> builder)
        {
            // validations and configuration types

            builder.Property(p => p.IdOperation)
                .HasColumnName("Id_Operation");

            builder.Property(p => p.IdTypeOperation)
                .HasColumnName("Id_TypeOperation")
                .IsRequired();

            builder.Property(p => p.CodeTypeOperation)
                .HasColumnName("Code_TypeOperation")
                .HasColumnType("varchar(10)")
                .HasMaxLength(10)
                .IsRequired();

            builder.Property(p => p.Description)
                .HasColumnType("varchar(100)")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(p => p.Amount)
                .HasColumnType("decimal(18,2)")
                .IsRequired();
            
            builder.Property(p => p.OperationDate)
                .HasColumnType("datetime")
                .IsRequired();

            builder.Property(p => p.Status)
                .HasColumnType("bit")
                .HasColumnName("Status").IsRequired();

            //relations
            builder.ToTable("Operation")
                   .HasKey(p => p.IdOperation);

            builder.HasOne(w => w.TypeOperation)
                .WithMany(w => w.Operations)
                .HasForeignKey(w => w.IdTypeOperation)
                .OnDelete(DeleteBehavior.ClientSetNull);
        }
            
    }
}
