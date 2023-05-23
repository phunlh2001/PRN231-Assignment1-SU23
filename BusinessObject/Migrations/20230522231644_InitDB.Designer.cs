﻿// <auto-generated />
using BusinessObject;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BusinessObject.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230522231644_InitDB")]
    partial class InitDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BusinessObject.Object.Customer", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("id");

                    b.Property<string>("Birthday")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("birthday");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("email");

                    b.Property<string>("Fullname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("fullname");

                    b.Property<bool>("Male")
                        .HasColumnType("bit")
                        .HasColumnName("male");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("phone_number");

                    b.Property<int>("Points")
                        .HasColumnType("int")
                        .HasColumnName("points");

                    b.HasKey("Id");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            Birthday = "02/04/2001",
                            Email = "kaizph@gmail.com",
                            Fullname = "Kaiz Nguyen",
                            Male = true,
                            PhoneNumber = "0396384095",
                            Points = 8
                        },
                        new
                        {
                            Id = "2",
                            Birthday = "02/08/1997",
                            Email = "chaunt@gmail.com",
                            Fullname = "Chau NT",
                            Male = false,
                            PhoneNumber = "0793786216",
                            Points = 9
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
