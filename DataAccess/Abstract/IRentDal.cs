using Core.Abstract;
using Entities.Concrete;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IRentDal : IEntityRepository<Rent>
    {
        List<CarRentDetailDto> GetRentDetails();
        List<CarRentDetailDto> GetRentDetailsByCarId(int carId);
    }
}
