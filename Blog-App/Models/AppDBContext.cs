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
                    Id="1",
                    Name = "Sam",
              
                });
            modelBuilder.Entity<Author>().HasData(
               new Author
               {
                   Id = "2",
                   Name = "John",
             
               });
            modelBuilder.Entity<Author>().HasData(
               new Author
               {
                   Id = "3",
                   Name = "Mary",
              
               });

            //Seed Blog Data

            modelBuilder.Entity<Blog>().HasData(
                new Blog
                {
                    Id = "1",
                    Name = "First Blog",
                    AuthorId = "1",
                    Content = "First Content",
                    DatePublished = "15/10/2020",
                    Category = "Hardware"
                });
            modelBuilder.Entity<Blog>().HasData(
                new Blog
                {
                    Id = "2",
                    Name = "Second Blog",
                    AuthorId = "2",
                    Content = "Second Content",
                    DatePublished = "15/10/2020",
                    Category = "Software"
                });

            modelBuilder.Entity<Blog>().HasData(
                new Blog
                {
                    Id = "3",
                    Name = "Third Blog",
                    AuthorId = "3",
                    Content = "Third Content",
                    DatePublished = "15/10/2020",
                    Category="Technology"
                });
            modelBuilder.Entity<Blog>().HasData(
                new Blog
                {
                    Id = "4",
                    Name = "Fourth Blog",
                    AuthorId = "3",
                    Content = "Fourth Content",
                    DatePublished = "15/10/2020",
                    Category = "Technology"
                });
        }



    }
}
