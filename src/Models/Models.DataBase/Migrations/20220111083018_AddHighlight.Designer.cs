﻿// <auto-generated />
using System;
using CleanReader.Models.DataBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Models.DataBase.Migrations
{
    [DbContext(typeof(LibraryDbContext))]
    [Migration("20220111083018_AddHighlight")]
    partial class AddHighlight
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.1");

            modelBuilder.Entity("CleanReader.Models.DataBase.Book", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("AddTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("Author")
                        .HasColumnType("TEXT");

                    b.Property<string>("Cover")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastChapterId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("LastOpenTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("Path")
                        .HasColumnType("TEXT");

                    b.Property<string>("SourceId")
                        .HasColumnType("TEXT");

                    b.Property<int>("Status")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Type")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("Title", "Author");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("CleanReader.Models.DataBase.History", b =>
                {
                    b.Property<string>("BookId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Locations")
                        .HasColumnType("TEXT");

                    b.Property<string>("Position")
                        .HasColumnType("TEXT");

                    b.Property<double>("Progress")
                        .HasColumnType("REAL");

                    b.Property<double>("ReadDuration")
                        .HasColumnType("REAL");

                    b.HasKey("BookId");

                    b.ToTable("Histories");
                });

            modelBuilder.Entity("CleanReader.Models.DataBase.ReadSection", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("HistoryBookId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("HistoryBookId");

                    b.ToTable("ReadSection");
                });

            modelBuilder.Entity("CleanReader.Models.DataBase.Shelf", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Order")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("Name");

                    b.ToTable("Shelves");
                });

            modelBuilder.Entity("CleanReader.Models.DataBase.ShelfBook", b =>
                {
                    b.Property<string>("BookId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ModifiedTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("ShelfId")
                        .HasColumnType("TEXT");

                    b.HasKey("BookId");

                    b.HasIndex("ShelfId");

                    b.ToTable("ShelfBook");
                });

            modelBuilder.Entity("CleanReader.Models.DataBase.Tag", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("BookId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("Name");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("Models.DataBase.Highlight", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("BookId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CfiRange")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Color")
                        .HasColumnType("TEXT");

                    b.Property<string>("Comments")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("CreateTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("Text")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.ToTable("Highlights");
                });

            modelBuilder.Entity("CleanReader.Models.DataBase.ReadSection", b =>
                {
                    b.HasOne("CleanReader.Models.DataBase.History", null)
                        .WithMany("ReadSections")
                        .HasForeignKey("HistoryBookId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CleanReader.Models.DataBase.ShelfBook", b =>
                {
                    b.HasOne("CleanReader.Models.DataBase.Shelf", null)
                        .WithMany("Books")
                        .HasForeignKey("ShelfId");
                });

            modelBuilder.Entity("CleanReader.Models.DataBase.Tag", b =>
                {
                    b.HasOne("CleanReader.Models.DataBase.Book", null)
                        .WithMany("Tags")
                        .HasForeignKey("BookId");
                });

            modelBuilder.Entity("CleanReader.Models.DataBase.Book", b =>
                {
                    b.Navigation("Tags");
                });

            modelBuilder.Entity("CleanReader.Models.DataBase.History", b =>
                {
                    b.Navigation("ReadSections");
                });

            modelBuilder.Entity("CleanReader.Models.DataBase.Shelf", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
