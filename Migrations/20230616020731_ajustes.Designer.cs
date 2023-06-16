﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebIssueManagementApp.Data;

#nullable disable

namespace WebIssueManagementApp.Migrations
{
    [DbContext(typeof(ManagementIssueContext))]
    [Migration("20230616020731_ajustes")]
    partial class ajustes
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WebIssueManagementApp.Models.Attachment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<byte[]>("Content")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("ContentType")
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)");

                    b.Property<string>("FileName")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<int>("IdIssue")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdIssue");

                    b.ToTable("Attachments");
                });

            modelBuilder.Entity("WebIssueManagementApp.Models.Issue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Abstract")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("DataBase")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<DateTime>("DateBegin")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateEnd")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdUser")
                        .HasColumnType("int");

                    b.Property<string>("Server")
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Text")
                        .HasColumnType("varchar(max)");

                    b.Property<string>("UrlIssue")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.HasKey("Id");

                    b.HasIndex("IdUser");

                    b.ToTable("Issues");
                });

            modelBuilder.Entity("WebIssueManagementApp.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "pauloandredarocha@gmail.com",
                            Name = "Paulo Rocha",
                            Password = "123456"
                        });
                });

            modelBuilder.Entity("WebIssueManagementApp.Models.Attachment", b =>
                {
                    b.HasOne("WebIssueManagementApp.Models.Issue", null)
                        .WithMany("ListAttachment")
                        .HasForeignKey("IdIssue")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebIssueManagementApp.Models.Issue", b =>
                {
                    b.HasOne("WebIssueManagementApp.Models.User", null)
                        .WithMany()
                        .HasForeignKey("IdUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebIssueManagementApp.Models.Issue", b =>
                {
                    b.Navigation("ListAttachment");
                });
#pragma warning restore 612, 618
        }
    }
}
