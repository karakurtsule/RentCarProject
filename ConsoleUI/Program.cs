using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description + " --> " + car.DailyPrice);
            }
            */

            /*
             
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description + " --> " + car.DailyPrice);
            }

            Console.WriteLine("*********************************************");

            foreach (var car in carManager.GetCarDetail())
            {
                Console.WriteLine(car.Description + " --> " + car.DailyPrice + " --> " + car.ColorName);
            }

            Console.WriteLine("*********************************************");

            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll())
            {
                //Console.WriteLine(brand.BrandName);
            }

            */

            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetAll().Data)
            {
                Console.WriteLine(car.Description);
            }
        }
    }
}
