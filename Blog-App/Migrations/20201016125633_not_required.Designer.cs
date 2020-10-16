﻿// <auto-generated />
using Blog_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Blog_App.Migrations
{
    [DbContext(typeof(AppDBContext))]
    [Migration("20201016125633_not_required")]
    partial class not_required
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Blog_Models.Author", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            Name = "Sam"
                        },
                        new
                        {
                            Id = "2",
                            Name = "John"
                        },
                        new
                        {
                            Id = "3",
                            Name = "Mary"
                        });
                });

            modelBuilder.Entity("Blog_Models.Blog", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AuthorId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DatePublished")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Blogs");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            AuthorId = "1",
                            Category = "Hardware",
                            Content = "First Content",
                            DatePublished = "15/10/2020",
                            Name = "First Blog"
                        },
                        new
                        {
                            Id = "2",
                            AuthorId = "2",
                            Category = "Software",
                            Content = "Second Content",
                            DatePublished = "15/10/2020",
                            Name = "Second Blog"
                        },
                        new
                        {
                            Id = "3",
                            AuthorId = "3",
                            Category = "Technology",
                            Content = "Third Content",
                            DatePublished = "15/10/2020",
                            Name = "Third Blog"
                        },
                        new
                        {
                            Id = "4",
                            AuthorId = "3",
                            Category = "Technology",
                            Content = "Fourth Content",
                            DatePublished = "15/10/2020",
                            Name = "Fourth Blog"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
