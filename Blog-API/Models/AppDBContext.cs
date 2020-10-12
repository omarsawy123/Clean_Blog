using Blog_Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog_API.Models
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
        }

        public DbSet<Author> Authors {get; set;}
        public DbSet<Blog> Blogs { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // seed Author Data

            modelBuilder.Entity<Author>().HasData(
                new Author
                {
                    Name = "Sam",
                    Specialty = Specialty.Hardware,
                    Blogs=2
                });
            modelBuilder.Entity<Author>().HasData(
               new Author
               {
                   Name = "John",
                   Specialty = Specialty.Software,
                   Blogs = 2
               });
            modelBuilder.Entity<Author>().HasData(
               new Author
               {
                   Name = "Mary",
                   Specialty = Specialty.Technology,
                   Blogs = 2
               });

            //Seed Blog Data

            modelBuilder.Entity<Blog>().HasData(
                new Blog
                {
                    Title = "First Blog",
                    AuthorId = 1,
                    Content = "First Content",
                    DatePublished = new DateTime(2020, 10, 12)
                });
            modelBuilder.Entity<Blog>().HasData(
                new Blog
                {
                    Title = "Second Blog",
                    AuthorId = 2,
                    Content = "Second Content",
                    DatePublished = new DateTime(2020, 10, 13)
                });

            modelBuilder.Entity<Blog>().HasData(
                new Blog
                {
                    Title = "Third Blog",
                    AuthorId = 3,
                    Content = "Third Content",
                    DatePublished = new DateTime(2020, 10, 14)
                });
        }



    }
}
