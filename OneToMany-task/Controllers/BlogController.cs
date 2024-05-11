using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OneToMany_task.Data;

namespace OneToMany_task.Controllers
{
	public class BlogController:Controller
	{
        private readonly AppDbContext _context;

        public BlogController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()=> View(await _context.Blogs.Where(m => !m.SoftDeleted).ToListAsync());
        
    }
}

