using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfColorDal : EfEntityRepositoryBase<Color, RecapContext>, IColorDal
    {
       /* public List<ColorDetailDto> GetColorDetails()
        {
            throw new NotImplementedException();
        }*/
    }
}
