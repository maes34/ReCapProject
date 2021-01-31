﻿using DataAccess.Abstractt;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
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
                new Car {Id = 1, BrandId = 1, ColorId = 1, DailyPrice = 100, ModelYear = "2013", Description = "Uygun Fiyatlı Kiralık"},
                new Car {Id = 2, BrandId = 2, ColorId = 2, DailyPrice = 250, ModelYear = "2015", Description = "Orta Fiyatlı Kiralık"},
                new Car {Id = 3, BrandId = 2, ColorId = 2, DailyPrice = 300, ModelYear = "2017", Description = "Orta Fiyatlı Kiralık"},
                new Car {Id = 4, BrandId = 3, ColorId = 3, DailyPrice = 500, ModelYear = "2019", Description = "Yüksek Fiyatlı Kiralık"},
                new Car {Id = 5, BrandId = 3, ColorId = 4, DailyPrice = 700, ModelYear = "2021", Description = "Lüks Fiyatlı Kiralık"}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(x => x.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public Car GetById(int id)
        {
            return _cars.SingleOrDefault(x=> x.Id == id);
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(x => x.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
