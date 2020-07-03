using FinanceApp.Data.Mapping;
using FinanceApp.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceApp.Data
{
    public class DbContextFinance: DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Entities.Operation> Operations { get; set; }
        public DbSet<DetOperation> DetOperations { get; set; }
        public DbSet<TypeOperation> typeOperations { get; set; }
        public DbSet<User> Users { get; set; }

        public DbContextFinance(DbContextOptions<DbContextFinance> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new OperationMap());
            modelBuilder.ApplyConfiguration(new CategoryMap());
            modelBuilder.ApplyConfiguration(new TypeOperationMap());
            modelBuilder.ApplyConfiguration(new DetailOperationMap());
            modelBuilder.ApplyConfiguration(new UserMap());
        }
    }
}
