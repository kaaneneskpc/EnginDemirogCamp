using Business.Abstract;
using Entities.Concrete;
using Business.Abstract;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : IBusinessService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }
        public List<Car> GetCarsByBrandId(int id)
        {
            return _carDal.GetAll(c => c.BrandId == id);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _carDal.GetAll(c => c.ColorId == id);
        }

        public void Add(Car car)
        {
            if (car.Description.Length >= 2)
            {
                if (car.DailyPrice > 0)
                {
                    _carDal.Add(car);
                }
                else
                {
                    Console.WriteLine("Daily Price upper than 0");
                }
                
            }
            else
            {
                Console.WriteLine("Car name must have min 2 characters.");
            }

        }
        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }

    }
}
