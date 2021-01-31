using Businness.Abstract;
using DataAccess.Abstractt;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Businness.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            Console.WriteLine("Başarıyla Eklendi");
        }

        public void Delete(Car car)
        {
            Console.WriteLine("Başarıyla Silindi");
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }
        public void Update(Car car)
        {
            Console.WriteLine("Başarıyla Güncellendi");
        }
    }
}
