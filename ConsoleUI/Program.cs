using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            carManager.Add(new Car
            {
                Id = 5,
                BrandId = 4,
                ColorId = 6,
                DailyPrice = 4000,
                Description = "garaj otosu",
                ModelYear = 1999
            });
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.ModelYear);
            }
        }
    }
}
