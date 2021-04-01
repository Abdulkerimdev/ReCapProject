using Business.Abstract;
using Core.Utilities;
using Core.Utilities.Results;
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
            return new SuccessResult("Kullanıcı değişti");
        }

        public IResult Delete(Customer customer)
        {
            return new SuccessResult("Kullanıcı değişti");
        }

        public IDataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll());
        }

        public IDataResult<List<Customer>> GetById(int Id)
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetByID(u => u.UserId == Id));
        }

        public IResult Update(Customer customer)
        {
            return new SuccessResult("Kullanıcı değişti");
        }
    }
}
