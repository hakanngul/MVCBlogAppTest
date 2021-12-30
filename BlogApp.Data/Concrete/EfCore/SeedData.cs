using System;
using System.Linq;
using BlogApp.Entity.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BlogApp.Data.Concrete.EfCore
{
    public static class SeedData
    {
        public static void Seed(IApplicationBuilder app)
        {
            BlogContext context = app.ApplicationServices.GetRequiredService<BlogContext>();
            context.Database.Migrate();

            if (!context.Categories.Any())
            {
                context.Categories.AddRange(
                    new Category() {Name = "C#"},
                    new Category() {Name = "Java"},
                    new Category() {Name = "Python"},
                    new Category() {Name = "Ruby"},
                    new Category() {Name = "C++"},
                    new Category() {Name = "JavaScript"}
                );
                context.SaveChanges();
            }


            if (!context.Blogs.Any())
            {
                context.Blogs.AddRange(
                    new Blog()
                    {
                        Title = "First Blog For C#", Description = "First Blog Description", Image = "1.jpg",
                        IsApproved = true, CategoryId = 1, Body = "First Blog Body", AddedDateTime = DateTime.Now.AddDays(1)
                    },
                    new Blog()
                    {
                        Title = "Second Blog For Java", Description = "Second Blog Description", Image = "2.jpg",
                        IsApproved = true, CategoryId = 2, Body = "Second Blog Body", AddedDateTime = DateTime.Now.AddDays(2)
                    },
                    new Blog()
                    {
                        Title = "Third Blog For Python", Description = "Third Blog Description", Image = "3.jpg",
                        IsApproved = true, CategoryId = 3, Body = "Third Blog Body", AddedDateTime = DateTime.Now.AddDays(3)
                    },
                    new Blog()
                    {
                        Title = "Forth Blog For Ruby on Rails", Description = "Forth Blog Description", Image = "4.jpg",
                        IsApproved = false, CategoryId = 4, Body = "Forth Blog Body", AddedDateTime = DateTime.Now.AddDays(4)
                    },
                    new Blog()
                    {
                        Title = "Five Blog For C++", Description = "Five Blog Description", Image = "5.jpg",
                        IsApproved = true, CategoryId = 5, Body = "Five Blog Body", AddedDateTime = DateTime.Now.AddDays(5)
                    },
                    new Blog()
                    {
                        Title = "Six Blog For JavaScript", Description = "Six Blog Description", Image = "6.jpg",
                        IsApproved = false, CategoryId = 6, Body = "Six Blog Body", AddedDateTime = DateTime.Now.AddDays(6)
                    }
                );
                context.SaveChanges();
            }
        }
    }
}