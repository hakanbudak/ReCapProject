﻿using Core.Utilities.Results;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    { 
        //IDto ya ve diğerlerine getAll,getbyId,add,update,delete ekleme de kaldın unutma sonrasında join işlemi ve son
        IDataResult<List<Car>> GetAll();
        IDataResult<List<CarDetailDto>> GetCarDetails();
        IDataResult<List<Car>> GetCarsByBrandId(int id); //list olarak dondurmussun bir hata alırsan bu kısıma bir göz at!!!!!!!
        IDataResult<List<Car>> GetCarsByColorId(int id); //list olarak dondurmussun bir hata alırsan bu kısıma bir göz at!!!!!!!
        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(Car car);
        
    }
}
