using System.Collections.Generic;
using Entities.Concrete;

namespace MVCWebUI.Models
{
    public class CategoryListViewModel
    {
        public List<Category> Categories { get; set; }
        public int ActiveCategoryId { get; set; }
    }
}