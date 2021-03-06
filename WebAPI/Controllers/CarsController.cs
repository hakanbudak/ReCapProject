using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFrameWork;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        //Loosely coupled
        //nameing convetion
        ICarService _carService;

        public CarsController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            //Swagger 
            var result=_carService.GetAll();
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Add(Car car)
        {
            var result = _carService.Add(car);
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(Car car)
        {
            var result = _carService.Delete(car);
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(Car car)
        {
            var result = _carService.Update(car);
            if (result.Success==true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbycolorıd")]
        public IActionResult GetColorId(int id)
        {
            var result = _carService.GetCarsByColorId(id);
            if (result.Success==true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbybrandıd")]
        public IActionResult GetBrandId(int id)
        {
            var result = _carService.GetCarsByBrandId(id);
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getcardetail")]
        public IActionResult GetCarDetail()
        {
            var result = _carService.GetCarDetails();
            if (result.Success==true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


    }
}
