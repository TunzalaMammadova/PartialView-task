using System;
using OneToMany_task.Models;

namespace OneToMany_task.Services.Interfaces
{
	public interface ICategoryService
	{
        Task<List<Category>> GetAllAsync();
    }
}

