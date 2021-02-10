using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public List<Category> GetAll()
        {
            //Business Codes
            return _categoryDal.GetAll();

        }
        public List<Category> GetByCategoryId(int id)
        {
            return _categoryDal.GetAll(c => c.CategoryId == id);
        }
    }
}
