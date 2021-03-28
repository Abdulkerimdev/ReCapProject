using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> cars;
        public InMemoryCarDal()
        {
            cars = new List<Car> { new Car { CarName= "tesla", Id=1, BrandId=1, ColorId=1, DailyPrice= 100,
                Description="Hoş araba", ModelYear= 2010},
                new Car { CarName= "jeep", Id=2 ,BrandId=2, ColorId=2, DailyPrice = 250,
                    Description= "Müko araba", ModelYear = 2015} };
        }
        public void Add(Car car)
        {
           
                cars.Add(car);
            
            
        }


        public void Delete(Car car)
        {
            Car carToDelete = cars.SingleOrDefault(c => c.Id == car.Id);
            cars.Remove(carToDelete);
        }


        public void Update(Car car)
        {
            Car carToUpdate = cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.ModelYear = car.ModelYear;

        }

        List<Car> ICarDal.GetAll()
        {
            return cars;
        }

        List<Car> ICarDal.GetById(int Id)
        {
            return cars.Where(c => c.Id == Id).ToList();
        }
    }
}