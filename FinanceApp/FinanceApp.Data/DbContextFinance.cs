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
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<CategoryExpense> CategoryExpenses { get; set; }

        public DbContextFinance(DbContextOptions<DbContextFinance> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new ExpenseMap());
            modelBuilder.ApplyConfiguration(new CategoryExpenseMap());
        }
    }
}
