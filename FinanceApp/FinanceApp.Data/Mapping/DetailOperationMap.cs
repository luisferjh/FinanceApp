using FinanceApp.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceApp.Data.Mapping
{
    public class DetailOperationMap : IEntityTypeConfiguration<DetOperation>
    {
        public void Configure(EntityTypeBuilder<DetOperation> builder)
        {
            // validations and configurations types
            builder.Property(p => p.IdOperation)
                .HasColumnName("Id_Operation");

            builder.Property(p => p.IdUser)
                .HasColumnName("Id_User")                              
                .IsRequired();

            builder.ToTable("DetailOperation")
                .HasKey(e => new { e.IdUser, e.IdOperation });

            // relationships
            builder.HasOne(w => w.Operation)
                  .WithMany(w => w.DetOperations)
                  .HasForeignKey(w => w.IdOperation)
                  .OnDelete(DeleteBehavior.ClientSetNull);

            builder.HasOne(w => w.User)
                .WithMany(w => w.DetOperations)
                .HasForeignKey(w => w.IdUser)
                .OnDelete(DeleteBehavior.ClientSetNull);

            //builder.HasMany(w => w.Budgets)
            //    .WithOne(w => w.Status)
            //    .HasForeignKey(w => w.IdStatus)
            //    .OnDelete(DeleteBehavior.ClientSetNull); 

          
        }
    }
}
