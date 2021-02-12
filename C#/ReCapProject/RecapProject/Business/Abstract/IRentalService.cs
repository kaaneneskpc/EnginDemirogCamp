using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IDataResult<List<Rental>> GetAll();

        IDataResult<List<Rental>> GetRentalByCarId(int carId);
        IDataResult<List<Rental>> GetRentalByCustomerId(int customerId);

        IDataResult<List<RentalDetailDto>> GetRentalDetails();

        IResult Add(Rental rental);

        IResult Delete(Rental rental);

        IResult Update(Rental rental);
    }
}
