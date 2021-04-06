using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Business;
using Core.Utilities.Helper;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class CarImagesManager : ICarImagesService
    {
        ICarImageDal _carImagesManager;

        public CarImagesManager(ICarImageDal carImagesManager)
        {
            _carImagesManager = carImagesManager;
        }


        [ValidationAspect(typeof(CarImagesValidator))]
        public IResult Add(CarImages carImages, IFormFile file)
        {

            IResult result = BusinessRules.Run(CheckImageLimited(carImages.CarId));
            if (result != null)
            {
                return result;
            }

            carImages.ImagePath = FileHelper.Add(file);
            carImages.Date = DateTime.Now;
            _carImagesManager.Add(carImages);
            return new SuccessResult(Messages.CarImagesAdded);
        }

        
        public IResult Delete(CarImages carImages)
        {

            var oldpath = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\wwwroot")) + _carImagesManager.Get(p => p.Id == carImages.Id).ImagePath;
            IResult result = BusinessRules.Run(FileHelper.Delete(oldpath));

            if (result != null)
            {
                return result;
            }

            _carImagesManager.Delete(carImages);
            return new SuccessResult(Messages.CarImagesDeleted);
        }

        public IDataResult<CarImages> Get(int id)
        {
            return new SuccessDataResult<CarImages>(_carImagesManager.Get(p => p.Id == id));
        }

        public IDataResult<List<CarImages>> GetAll()
        {
            return new SuccessDataResult<List<CarImages>>(_carImagesManager.GetAll(), Messages.CarImagesListed);
        }

        public IDataResult<List<CarImages>> GetImagesByCarId(int CarId)
        {
            var result = _carImagesManager.GetAll(c => c.CarId == CarId).Any();
            if (!result)
            {
                List<CarImages> carimage = new List<CarImages>();
                carimage.Add(new CarImages { CarId = CarId, ImagePath = @"\Images\default.png" });
                return new SuccessDataResult<List<CarImages>>(carimage);
            }
            return new SuccessDataResult<List<CarImages>>(_carImagesManager.GetAll(p => p.CarId == CarId));
        }
        [ValidationAspect(typeof(CarImagesValidator))]
        public IResult Update(CarImages carImages, IFormFile file)
        {
            var oldPath = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\wwwroot")) + _carImagesManager.Get(p => p.Id == carImages.CarId).ImagePath;

            carImages.ImagePath = FileHelper.Update(oldPath, file);
            carImages.Date = DateTime.Now;

            _carImagesManager.Update(carImages);
            return new SuccessResult(Messages.CarImagesUpdate);
        }


        private IResult CheckImageLimited(int carId)
        {
            var carImageCount = _carImagesManager.GetAll(p => p.CarId == carId).Count;
            if (carImageCount >= 5)
            {
                return new ErrorResult(Messages.CarCheckImageLimited);
            }
            return new SuccessResult();
        }
    }
}
