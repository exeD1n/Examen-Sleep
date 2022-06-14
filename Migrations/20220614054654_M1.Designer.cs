﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WpfApp15.DB;

namespace WpfApp15.Migrations
{
    [DbContext(typeof(ContextDB))]
    [Migration("20220614054654_M1")]
    partial class M1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WpfApp15.DB.Product", b =>
                {
                    b.Property<int>("IDproduct")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cost")
                        .HasColumnType("int");

                    b.Property<string>("NameProd")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IDproduct");

                    b.ToTable("products");
                });

            modelBuilder.Entity("WpfApp15.DB.Users", b =>
                {
                    b.Property<int>("IDuser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IDuser");

                    b.ToTable("users");
                });
#pragma warning restore 612, 618
        }
    }
}
