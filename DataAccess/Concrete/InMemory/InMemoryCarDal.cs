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
            _cars = new List<Car>
            {
                new Car{Id = 1, BrandId = 1, ColorId = 1, DailyPrice = 1000, ModelYear = "2001", Description = "Opel Astra"},
                new Car{Id = 2, BrandId = 2, ColorId = 2, DailyPrice = 2000, ModelYear = "2002", Description = "Toyota Corolla"},
                new Car{Id = 3, BrandId = 3, ColorId = 3, DailyPrice = 3000, ModelYear = "2003", Description = "Suzuki Vitara"},
                new Car{Id = 4, BrandId = 4, ColorId = 4, DailyPrice = 4000, ModelYear = "2004", Description = "BMW 5.20"},
                new Car{Id = 5, BrandId = 5, ColorId = 5, DailyPrice = 5000, ModelYear = "2005", Description = "Ford Mustang"}

            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Add()
        {
            throw new NotImplementedException();
        }

        public void Delete(Car car)
        {
            Car CarToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(CarToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Car car)
        {
            return _cars;
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int carId)
        {
            return _cars.Where(c => c.Id == carId).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car CarToUpdate = _cars.SingleOrDefault(c => car.Id == car.Id);
            CarToUpdate.Description = car.Description;
            CarToUpdate.DailyPrice = car.DailyPrice;
            CarToUpdate.ColorId = car.ColorId;
            CarToUpdate.BrandId = car.BrandId;
            CarToUpdate.ModelYear = car.ModelYear;



        }
    }
}
