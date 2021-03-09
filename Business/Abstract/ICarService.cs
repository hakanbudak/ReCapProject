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
        List<Car> GetAll();
        List<CarDetailDto> GetCarDetails();
        
    }
}
