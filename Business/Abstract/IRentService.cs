using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRentService
    {
        IDataResult<List<Rent>> GetAll();
        IDataResult<Rent> GetByRentId(int rentId);
        IDataResult<List<CarRentDetailDto>> GetCarRentDetail();
        IDataResult<List<CarRentDetailDto>> GetCarRentDetailId(int carId);

        IResult IsCarEverRented(int carId);
        IResult IsCarReturned(int carId);
        IResult IsCarAvaible(int carId);


        IResult Add(Rent rent);
        IResult Update(Rent rent);
        IResult Delete(Rent rent);
    
    }
}
