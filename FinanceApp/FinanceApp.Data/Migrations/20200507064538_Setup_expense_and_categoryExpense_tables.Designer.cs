﻿// <auto-generated />
using System;
using FinanceApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FinanceApp.Data.Migrations
{
    [DbContext(typeof(DbContextFinance))]
    [Migration("20200507064538_Setup_expense_and_categoryExpense_tables")]
    partial class Setup_expense_and_categoryExpense_tables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FinanceApp.Entities.CategoryExpense", b =>
                {
                    b.Property<int>("IdCategoryExpense")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id_CategoryExpense")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CodCategoryExpense")
                        .IsRequired()
                        .HasColumnType("varchar(3)")
                        .HasMaxLength(3);

                    b.Property<string>("DescriptionCategoryExpense")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("IdStatus")
                        .HasColumnName("Id_Status")
                        .HasColumnType("int");

                    b.HasKey("IdCategoryExpense");

                    b.ToTable("CategoryExpense");
                });

            modelBuilder.Entity("FinanceApp.Entities.Expense", b =>
                {
                    b.Property<int>("IdExpense")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id_Expense")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("AmountSpent")
                        .HasColumnType("decimal(11,2)");

                    b.Property<DateTime>("DateExpense")
                        .HasColumnType("datetime");

                    b.Property<string>("DescriptionExpense")
                        .IsRequired()
                        .HasColumnType("varchar(70)");

                    b.Property<int>("IdCategoryExpense")
                        .HasColumnType("int");

                    b.Property<int>("IdStatus")
                        .HasColumnName("Id_Status")
                        .HasColumnType("int");

                    b.HasKey("IdExpense");

                    b.HasIndex("IdCategoryExpense");

                    b.ToTable("Expense");
                });

            modelBuilder.Entity("FinanceApp.Entities.Expense", b =>
                {
                    b.HasOne("FinanceApp.Entities.CategoryExpense", "CategoryExpense")
                        .WithMany("Expenses")
                        .HasForeignKey("IdCategoryExpense")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
