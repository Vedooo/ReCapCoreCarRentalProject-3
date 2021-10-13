﻿using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using Core.Utilities.Results.DataResultOptions.DataResultChoice;
using Core.Utilities.Results.ResultOptions.ResultChoice;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }


        public IResult Add(Customer customer)
        {
            _customerDal.Add(customer);
            return new SuccessResult(Messages.CustomerAdded);
        }

        public IResult Delete(Customer customer)
        {
            _customerDal.Delete(customer);
            return new SuccessResult(Messages.CustomerDeleted);
        }

        public IDataResult<List<Customer>> GetAll()
        {
            if (DateTime.Now.Hour == 21)
            {
                return new ErrorDataResult<List<Customer>>(Messages.MaintainanceTimeCustomer);
            }

            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(), Messages.CarsListedForCustomers);
        }

        public IDataResult<Customer> GetById(int customerId)
        {
            return new SuccessDataResult<Customer> (_customerDal.Get(cu => cu.Id == customerId));
        }

        public IResult Update(Customer customer)
        {
            _customerDal.Update(customer);
            return new SuccessResult(Messages.CustomerUpdated);
        }
    }
}
