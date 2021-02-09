using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
            // Debug and Conditions
            return _categoryDal.GetAll();
        }

        public Category GetById(int categoryId)
        {
            // Debug and Conditions
            return _categoryDal.Get(c => c.CategoryId == categoryId);
        }
    }
}