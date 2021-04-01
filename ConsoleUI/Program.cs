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

            UserManager userManager = new UserManager(new EfUserDal());
            userManager.Add(new User { FirstName = "kerim", LastName = "dev", Email = "denemekerim@gmail.com", Password = "123" });


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
