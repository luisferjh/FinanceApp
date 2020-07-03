using FinanceApp.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceApp.Data.Mapping
{
    public class TypeOperationMap : IEntityTypeConfiguration<TypeOperation>
    {
        public void Configure(EntityTypeBuilder<TypeOperation> builder)
        {
            builder.Property(p => p.IdTypeOperation)
                .HasColumnName("Id_TypeOperation");

            builder.Property(p => p.IdCategory)
                .HasColumnName("Id_Category")
                .IsRequired();

            builder.Property(p => p.Code)
                .HasColumnType("varchar(10)")   
                .HasMaxLength(10)
                .IsRequired();

            builder.Property(p => p.Name)
               .HasColumnType("varchar(50)")
               .HasMaxLength(50)
               .IsRequired();

            builder.Property(p => p.Icono)
               .HasColumnType("varchar(50)")
               .HasMaxLength(50)
               .IsRequired();

            builder.Property(p => p.Description)
                .HasColumnType("varchar(100)")
                .HasMaxLength(100)
                .IsRequired();

            //builder.Property(p => p.InitialDate)
            //.HasColumnType("Date")
            //.IsRequired();
          
            builder.Property(p => p.Status)
                .HasColumnType("bit")
                .HasColumnName("Status")
                .IsRequired();


            builder.ToTable("TypeOperation")
                .HasKey(w => w.IdTypeOperation);

            // Relationships
            builder.HasOne(w => w.Category)
                .WithMany(w => w.TypeOperations)
                .HasForeignKey(w => w.IdCategory)
                .OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}
