﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using finalProjectApi.Models;

namespace finalProjectApi.Migrations
{
    [DbContext(typeof(FinalProjectDbContext))]
    [Migration("20190814015418_AddingDetails")]
    partial class AddingDetails
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("finalProjectApi.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("product_id");

                    b.Property<decimal>("Cost")
                        .HasColumnName("cost")
                        .HasColumnType("decimal(13, 4)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnName("description")
                        .HasMaxLength(300);

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasColumnName("details")
                        .HasMaxLength(300);

                    b.Property<decimal>("Price")
                        .HasColumnName("price")
                        .HasColumnType("decimal(13, 4)");

                    b.Property<bool>("Status")
                        .HasColumnName("status");

                    b.HasKey("Id");

                    b.ToTable("product");
                });

            modelBuilder.Entity("finalProjectApi.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("user_id");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnName("full_name");

                    b.Property<bool>("IsAdmin")
                        .HasColumnName("is_admin");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnName("password");

                    b.Property<bool>("Status")
                        .HasColumnName("status");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnName("user_name");

                    b.HasKey("Id");

                    b.ToTable("user");
                });
#pragma warning restore 612, 618
        }
    }
}