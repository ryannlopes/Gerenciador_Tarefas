﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using taskManagerKidsAPI.Context;

#nullable disable

namespace taskManagerKidsAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230606005253_initMigration")]
    partial class initMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("KidParent", b =>
                {
                    b.Property<int>("KidsId")
                        .HasColumnType("int");

                    b.Property<int>("ParentsId")
                        .HasColumnType("int");

                    b.HasKey("KidsId", "ParentsId");

                    b.HasIndex("ParentsId");

                    b.ToTable("KidParent");
                });

            modelBuilder.Entity("taskManagerKidsAPI.Models.Kid", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .HasColumnType("longtext");

                    b.Property<int>("Score")
                        .HasColumnType("int");

                    b.Property<string>("User")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Kids");
                });

            modelBuilder.Entity("taskManagerKidsAPI.Models.Parent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .HasColumnType("longtext");

                    b.Property<string>("User")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Parents");
                });

            modelBuilder.Entity("taskManagerKidsAPI.Models.Task", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Category")
                        .HasColumnType("longtext");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<int>("GainScore")
                        .HasColumnType("int");

                    b.Property<string>("Importance")
                        .HasColumnType("longtext");

                    b.Property<int>("KidId")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .HasColumnType("longtext");

                    b.Property<string>("Title")
                        .HasColumnType("longtext");

                    b.Property<string>("Topic")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("KidId");

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("KidParent", b =>
                {
                    b.HasOne("taskManagerKidsAPI.Models.Kid", null)
                        .WithMany()
                        .HasForeignKey("KidsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("taskManagerKidsAPI.Models.Parent", null)
                        .WithMany()
                        .HasForeignKey("ParentsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("taskManagerKidsAPI.Models.Task", b =>
                {
                    b.HasOne("taskManagerKidsAPI.Models.Kid", "Kid")
                        .WithMany("Tasks")
                        .HasForeignKey("KidId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kid");
                });

            modelBuilder.Entity("taskManagerKidsAPI.Models.Kid", b =>
                {
                    b.Navigation("Tasks");
                });
#pragma warning restore 612, 618
        }
    }
}
