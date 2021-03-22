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
        IResult Add(Rental rental);
        IResult Delete(Rental rental);
        IResult Update(Rental rental);
        IResult CheckReturnDate(int carId);
        IResult UpdateRetunrDate(Rental rental);
        IDataResult<List<Rental>> GetAll();
        IDataResult<List<CarRentalDetailDto>> GetRentalDetails();
    }
}
