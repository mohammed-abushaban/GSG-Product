using Product.web.Models;
using System.Collections.Generic;

namespace Product.web.Service
{
    public interface ICategoryService
    {
        List<Category> GetAll();
    }
}