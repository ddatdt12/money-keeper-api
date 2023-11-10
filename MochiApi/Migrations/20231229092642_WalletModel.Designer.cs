﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MochiApi.Models;

#nullable disable

namespace MochiApi.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20221229092642_WalletModel")]
    partial class WalletModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("MochiApi.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("WalletId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("WalletId");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "test@gmail.com",
                            Password = "123123123"
                        },
                        new
                        {
                            Id = 2,
                            Email = "test2@gmail.com",
                            Password = "123123123"
                        },
                        new
                        {
                            Id = 3,
                            Email = "test3@gmail.com",
                            Password = "123123123"
                        },
                        new
                        {
                            Id = 4,
                            Email = "test4@gmail.com",
                            Password = "123123123"
                        });
                });

            modelBuilder.Entity("MochiApi.Models.Wallet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Balance")
                        .HasColumnType("int");

                    b.Property<bool>("IsDefault")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("OwnerId")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("Wallet");
                });

            modelBuilder.Entity("MochiApi.Models.User", b =>
                {
                    b.HasOne("MochiApi.Models.Wallet", null)
                        .WithMany("Members")
                        .HasForeignKey("WalletId");
                });

            modelBuilder.Entity("MochiApi.Models.Wallet", b =>
                {
                    b.HasOne("MochiApi.Models.User", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("MochiApi.Models.Wallet", b =>
                {
                    b.Navigation("Members");
                });
#pragma warning restore 612, 618
        }
    }
}
