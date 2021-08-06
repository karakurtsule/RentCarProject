using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car> { 
                new Car{Id = 1, BrandId = 1, ColorId = 1, DailyPrice = 50000, Description = "Limuzin", ModelYear = 1995},
                new Car{Id = 2, BrandId = 2, ColorId = 2, DailyPrice = 1250, Description = "Range Rover", ModelYear = 1995},
                new Car{Id = 3, BrandId = 3, ColorId = 3, DailyPrice = 500, Description = "Bmw", ModelYear = 1995},
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            var deleteItem = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(car);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car GetById(int id)
        {
            return _cars.SingleOrDefault(c => c.Id == id);
        }

        public Car GetById(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            var updateItem = _cars.SingleOrDefault(c => c.Id == car.Id);
            updateItem.Id = car.Id;
            updateItem.BrandId = car.BrandId;
            updateItem.ColorId = car.ColorId;
            updateItem.DailyPrice = car.DailyPrice;
            updateItem.Description = car.Description;
            updateItem.ModelYear = car.ModelYear;
        }

        List<CarDetailDto> ICarDal.GetCarDetails()
        {
            throw new NotImplementedException();
        }
    }
}
