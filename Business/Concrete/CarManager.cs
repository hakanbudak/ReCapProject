using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
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
        public void Add(Car car)
        {
            if (car.DailyPrice > 0 && car.Description.Length > 2)
            {
                _carDal.Add(car);
            }
            else
            {
                Console.WriteLine("The car could not be added. Registration conditions; \n " +
                    "-The model year of the car must be above 2000 \n" +
                    "-The daily price of the car must be greater than zero");
            }
        }

        public void Update(Car car)
        {
            if (car.Description.Length > 2)
            {
                _carDal.Update(car);
            }
            else
            {
                Console.WriteLine("The car could not be added. Registration conditions;\n" +
                    "-The car description must contain at least two characters.");
            }
        }
        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }
        public List<Car> GetCarsByBrandId(int id)
        {
            return _carDal.GetAll(p => p.BrandId == id);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _carDal.GetAll(p => p.ColorId == id);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }
    }
}
