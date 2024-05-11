﻿using System;
using Microsoft.EntityFrameworkCore;
using OneToMany_task.Models;

namespace OneToMany_task.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Slider> Sliders { get; set; }
        public DbSet<SliderInfo> SliderInfos { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Expert> Experts { get; set; }
        public DbSet<ExpertImage> ExpertImages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blog>()
                        .HasData(
            new Blog
            {
                Id = 1,
                Title = "Title1",
                Description = "Desc1",
                Date = DateTime.Now,
                Image = "blog-feature-img-1.jpg"
            },

            new Blog
            {
                Id = 2,
                Title = "Title2",
                Description = "Desc2",
                Date = DateTime.Now,
                Image = "blog-feature-img-3.jpg"
            },

            new Blog
            {
                Id = 3,
                Title = "Title3",
                Description = "Desc3",
                Date = DateTime.Now,
                Image = "blog-feature-img-4.jpg"
            }
        );

        }
    }
}


