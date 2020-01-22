using System;
using System.Collections.Generic;
using System.Text;
using Bookshelf.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Bookshelf.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Book> Book { get; set; }
        public DbSet<Author> Author { get; set; }
        public DbSet<Comment> Comment { get; set; }

        //Starting Dummy data
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            ApplicationUser user = new ApplicationUser
            {
                FirstName = "admin",
                LastName = "admin",
                UserName = "admin@admin.com",
                NormalizedUserName = "ADMIN@ADMIN.COM",
                Email = "admin@admin.com",
                NormalizedEmail = "ADMIN@ADMIN.COM",
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = "7f434309-a4d9-48e9-9ebb-8803db794577",
                Id = "00000000-ffff-ffff-ffff-ffffffffffff"
            };

            var passwordHash = new PasswordHasher<ApplicationUser>();
            user.PasswordHash = passwordHash.HashPassword(user, "Admin8*");
            modelBuilder.Entity<ApplicationUser>().HasData(user);


            //Create New Authors
            Author author1 = new Author
            {
                Id = 3,
                Name = "Jimmy John",
                ApplicationUserId = user.Id
            };
            modelBuilder.Entity<Author>().HasData(author1);

            Author author2 = new Author
            {
                Id = 4,
                Name = "Jersey Mike",
                ApplicationUserId = user.Id
            };
            modelBuilder.Entity<Author>().HasData(author2);

            Author author3 = new Author
            {
                Id = 5,
                Name = "Jared Fogel",
                ApplicationUserId = user.Id
            };
            modelBuilder.Entity<Author>().HasData(author3);

            //Create some Books
            Book johnBook = new Book
            {
                Id = 4,
                Title = "Free Smells",
                Genre = "Sandwiches",
                YearPublished = 1990,
                AuthorId = author1.Id,
                ApplicationUserId = user.Id,
                Rating = 10
            };
            modelBuilder.Entity<Book>().HasData(johnBook);

            Book jerseyBook = new Book
            {
                Id = 5,
                Title = "Jersey Subs",
                Genre = "Sandwiches",
                YearPublished = 2020,
                AuthorId = author2.Id,
                ApplicationUserId = user.Id,
                Rating = 1
            };
            modelBuilder.Entity<Book>().HasData(jerseyBook);

            Book fffffogelBook = new Book
            {
                Id = 6,
                Title = "How to make a prison sandiwich",
                Genre = "Instructional",
                YearPublished = 2015,
                AuthorId = author3.Id,
                ApplicationUserId = user.Id,
                Rating = 0
            };
            modelBuilder.Entity<Book>().HasData(fffffogelBook);

            Comment jerseyComment = new Comment
            {
                Id = 1,
                Text = "It smells like Jersey",
                BookId = jerseyBook.Id,
                ApplicationUserId = user.Id
            };
            modelBuilder.Entity<Comment>().HasData(jerseyComment);

            Comment jimmyComment = new Comment
            {
                Id = 2,
                Text = "What even is Jimmy Johns",
                BookId = johnBook.Id,
                ApplicationUserId = user.Id
            };
            modelBuilder.Entity<Comment>().HasData(jimmyComment);

            Comment jaredComment = new Comment
            {
                Id = 3,
                Text = "how did he write this book",
                BookId = fffffogelBook.Id,
                ApplicationUserId = user.Id
            };
            modelBuilder.Entity<Comment>().HasData(jaredComment);
        }
    }
}
