using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SuperMarket.Domains.Services;
using SuperMarket.Domains.Models;
using System.Collections.Generic;

namespace SuperMarket.Controllers
{
    [Route("/api/[controller]")]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<IEnumerable<Category>> GetAllAsync()
        {
            var categories = await _categoryService.ListAsync();
            return categories;
        }
    }
}
