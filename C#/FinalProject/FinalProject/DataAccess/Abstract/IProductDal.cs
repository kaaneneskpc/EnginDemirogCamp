using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IProductDal : IEntitiyRepository<Product> //not default public
    {
        //all of them default public
       
    }
}
