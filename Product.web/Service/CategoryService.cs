using Product.web.Data;
using Product.web.Models;
using System.Collections.Generic;
using System.Linq;

namespace Product.web.Service
{
    public class CategoryService : ICategoryService
    {
        private readonly ApplicationDbContext _db;

        public CategoryService(ApplicationDbContext db)
        {
            _db = db;
        }

        public List<Category> GetAll()
        {
            return _db.Categories.ToList();
        }
    }
}
