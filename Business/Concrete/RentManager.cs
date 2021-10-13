using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using Core.Utilities.Results.DataResultOptions.DataResultChoice;
using Core.Utilities.Results.ResultOptions.ResultChoice;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class RentManager : IRentService
    {
        IRentDal _rentDal;

        public RentManager(IRentDal rentDal)
        {
            _rentDal = rentDal;
        }

        public IResult Add(Rent rent)
        {
            var result = IsCarAvaible(rent.CarId);
            if (result.Success)
            {
                _rentDal.Add(rent);
                return new SuccessResult(Messages.RentInfoAdded);
            }
            else
            {
                return new ErrorResult(result.Message);
            }
        }

        public IResult Delete(Rent rent)
        {
            _rentDal.Delete(rent);
            return new SuccessResult(Messages.RentInfoDeleted);
        }

        public IDataResult<List<Rent>> GetAll()
        {
            if (DateTime.Now.Hour == 21)
            {
                return new ErrorDataResult<List<Rent>>(Messages.MaintainanceTimerRent);
            }

            return new SuccessDataResult<List<Rent>>(_rentDal.GetAll(), Messages.RentCarListed);
        }

        public IDataResult<Rent> GetByRentId(int rentId)
        {
            return new SuccessDataResult<Rent>(_rentDal.Get(r => r.Id == rentId));
        }

        public IDataResult<List<CarRentDetailDto>> GetCarRentDetail()
        {
            return new SuccessDataResult<List<CarRentDetailDto>>(_rentDal.GetRentDetails());
        }

        public IDataResult<List<CarRentDetailDto>> GetCarRentDetailId(int carId)
        {
            return new SuccessDataResult<List<CarRentDetailDto>>(_rentDal.GetRentDetailsByCarId(carId));
        }

        public IResult IsCarAvaible(int carId)
        {
            if (IsCarAvaible(carId).Success)
            {
                if (IsCarReturned(carId).Success)
                {
                    return new SuccessResult(Messages.RentInfoAdded);
                }
                return new ErrorResult(Messages.RentUnavaible);
            }
            return new SuccessResult(Messages.RentInfoAdded);
        }

        public IResult IsCarEverRented(int carId)
        {
            if (_rentDal.GetAll(r => r.CarId == carId).Any())
            {
                return new SuccessResult();
            }
            return new ErrorResult();
        }

        public IResult IsCarReturned(int carId)
        {
            if (_rentDal.GetAll(r => (r.CarId == carId) && (r.ReturnDate == null)).Any())
            {
                return new ErrorResult();
            }
            return new SuccessResult();
        }

        public IResult Update(Rent rent)
        {
            _rentDal.Update(rent);
            return new SuccessResult(Messages.RentInfoUpdated);

        }
    }
}
