using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            
            carManager.Add(new Car
            {
                CarName = "toros",
                Id = 5,
                BrandId = 4,
                ColorId = 6,
                DailyPrice = 10,
                Description = "garaj otosu",
                ModelYear = 1999
            });

            /*
            var result = carManager.GetAllCarDetails();
            foreach (var car in result)
            {
                Console.WriteLine(car.BrandName);
            }
            */

        }
    }
}
