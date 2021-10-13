using Core.Abstract.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentDal : EfEntityRepositoryBase<Rent, NorthwindContext>, IRentDal
    {
        public List<CarRentDetailDto> GetRentDetails()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var result = from c in context.Cars
                             join r in context.Rentals
                             on c.Id equals r.Id into temp
                             from t in temp.DefaultIfEmpty()
                             select new CarRentDetailDto
                             {

                             };
                return result.ToList();
            }
        }

        public List<CarRentDetailDto> GetRentDetailsByCarId(int carId)
        {
            var resultList = GetRentDetails();
            return resultList.Where(c => c.CarId == carId).ToList();
        }
    }
}
