using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id = 1,BrandId = 1,ColorId = 1,ModelYear =2019,DailyPrice = 180000,Description = "Temiz"},
                new Car{Id = 2,BrandId = 1,ColorId = 1,ModelYear =2020,DailyPrice = 200000,Description = "Temiz"},
                new Car{Id = 3,BrandId = 2,ColorId = 2,ModelYear =2021,DailyPrice = 210000,Description = "Temiz"},
                new Car{Id = 4,BrandId = 2,ColorId = 2,ModelYear =2018,DailyPrice = 250000,Description = "Temiz"},
                new Car{Id = 5,BrandId = 2, ColorId = 2,ModelYear =2020,DailyPrice = 190000,Description = "Temiz"},
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p => p.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAllByBrand(int brandId)
        {
            return _cars.Where(p => p.BrandId == brandId).ToList();
        }

        public List<Car> GetAllByColor(int colorId)
        {
            return _cars.Where(p => p.ColorId == colorId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;


        }
    }
}
