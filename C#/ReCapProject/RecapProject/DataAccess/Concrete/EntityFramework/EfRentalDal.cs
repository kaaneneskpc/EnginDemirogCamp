using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
     public class EfRentalDal : EfEntityRepositoryBase<Rental,RecapContext>,IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {

            using (RecapContext context = new RecapContext())
            {
                var result = from r in context.Rental
                              join c in context.Customer
                              on r.CustomerId equals c.CustomerId
                              select new RentalDetailDto {CustomerId = c.CustomerId, RentDate = r.RentDate , 
                                  ReturnDate = r.ReturnDate };
                return result.ToList();
            }
        }
    }
}
