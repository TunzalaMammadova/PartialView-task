using System;
using Microsoft.EntityFrameworkCore;
using OneToMany_task.Data;
using OneToMany_task.Models;
using OneToMany_task.Services.Interfaces;

namespace OneToMany_task.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly AppDbContext _context;

        public CategoryService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Category>> GetAllAsync()
        {
            return await _context.Categories.Where(m=>!m.SoftDeleted).ToListAsync();
        }
    }
}

