using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IResult Add(Car car);
        void Delete(Car car);
        void Update(Car car);
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetById(int Id);
        IDataResult<List<CarDetailDto>> GetAllCarDetails();

    }
}
