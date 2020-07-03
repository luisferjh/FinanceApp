﻿// <auto-generated />
using System;
using FinanceApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FinanceApp.Data.Migrations
{
    [DbContext(typeof(DbContextFinance))]
    partial class DbContextFinanceModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FinanceApp.Entities.Category", b =>
                {
                    b.Property<int>("IdCategory")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id_Category")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(3);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Icono")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<bool>("Status")
                        .HasColumnName("Status")
                        .HasColumnType("bit");

                    b.HasKey("IdCategory");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("FinanceApp.Entities.DetOperation", b =>
                {
                    b.Property<int>("IdUser")
                        .HasColumnName("Id_User")
                        .HasColumnType("int");

                    b.Property<int>("IdOperation")
                        .HasColumnName("Id_Operation")
                        .HasColumnType("int");

                    b.HasKey("IdUser", "IdOperation");

                    b.HasIndex("IdOperation");

                    b.ToTable("DetailOperation");
                });

            modelBuilder.Entity("FinanceApp.Entities.Operation", b =>
                {
                    b.Property<int>("IdOperation")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id_Operation")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("CodeTypeOperation")
                        .IsRequired()
                        .HasColumnName("Code_TypeOperation")
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("IdTypeOperation")
                        .HasColumnName("Id_TypeOperation")
                        .HasColumnType("int");

                    b.Property<DateTime>("OperationDate")
                        .HasColumnType("datetime");

                    b.Property<bool>("Status")
                        .HasColumnName("Status")
                        .HasColumnType("bit");

                    b.HasKey("IdOperation");

                    b.HasIndex("IdTypeOperation");

                    b.ToTable("Operation");
                });

            modelBuilder.Entity("FinanceApp.Entities.TypeOperation", b =>
                {
                    b.Property<int>("IdTypeOperation")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id_TypeOperation")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Icono")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("IdCategory")
                        .HasColumnName("Id_Category")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<bool>("Status")
                        .HasColumnName("Status")
                        .HasColumnType("bit");

                    b.HasKey("IdTypeOperation");

                    b.HasIndex("IdCategory");

                    b.ToTable("TypeOperation");
                });

            modelBuilder.Entity("FinanceApp.Entities.User", b =>
                {
                    b.Property<int>("IdUser")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id_User")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(60)")
                        .HasMaxLength(60);

                    b.Property<int>("IdStatus")
                        .HasColumnName("Id_Status")
                        .HasColumnType("int");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(250)")
                        .HasMaxLength(250);

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(250)")
                        .HasMaxLength(250);

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("IdUser");

                    b.ToTable("User");
                });

            modelBuilder.Entity("FinanceApp.Entities.DetOperation", b =>
                {
                    b.HasOne("FinanceApp.Entities.Operation", "Operation")
                        .WithMany("DetOperations")
                        .HasForeignKey("IdOperation")
                        .IsRequired();

                    b.HasOne("FinanceApp.Entities.User", "User")
                        .WithMany("DetOperations")
                        .HasForeignKey("IdUser")
                        .IsRequired();
                });

            modelBuilder.Entity("FinanceApp.Entities.Operation", b =>
                {
                    b.HasOne("FinanceApp.Entities.TypeOperation", "TypeOperation")
                        .WithMany("Operations")
                        .HasForeignKey("IdTypeOperation")
                        .IsRequired();
                });

            modelBuilder.Entity("FinanceApp.Entities.TypeOperation", b =>
                {
                    b.HasOne("FinanceApp.Entities.Category", "Category")
                        .WithMany("TypeOperations")
                        .HasForeignKey("IdCategory")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
