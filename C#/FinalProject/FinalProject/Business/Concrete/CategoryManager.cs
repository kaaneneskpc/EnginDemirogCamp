using Business.Abstract;
using Core.Utilities.Results;
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
        public IDataResult<List<Category>>GetAll()
        {
            return new SuccessDataResult<List<Category>>(_categoryDal.GetAll());
            //Business Codes
            
        }
        public IDataResult<List<Category>> GetByCategoryId(int id)
        {
            return new SuccessDataResult<List<Category>>(_categoryDal.GetAll(c => c.CategoryId == id));
            
        }
    }
}
