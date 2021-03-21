using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBrandDal : EfEntityRepositoryBase<Brand, RecapContext>, IBrandDal
    {
       /* public List<BrandDetailDto> GetBrandDetails()
        {
            throw new NotImplementedException();
        }*/
    }
}
