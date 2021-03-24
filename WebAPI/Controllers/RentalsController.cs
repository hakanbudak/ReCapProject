using Business.Abstract;
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
    public class RentalsController : ControllerBase
    {
        IRentalService _rentalService;

        public RentalsController(IRentalService rentalService)
        {
            _rentalService = rentalService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _rentalService.GetAll();
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Add(Rental  rental)
        {
            var result = _rentalService.Add(rental);
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(Rental rental)
        {
            var result = _rentalService.Delete(rental);
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(Rental rental)
        {
            var result = _rentalService.Update(rental);
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("checkreturndate")]
        public IActionResult CheckReturnDate(int carId)
        {
            var result = _rentalService.CheckReturnDate(carId);
            if (result.Success==true)
            {
                return Ok(carId);
            }
            return BadRequest(carId);
        }
        [HttpGet("updatereturndate")]
        public IActionResult UpdateReturnDate(Rental rental)
        {
            var result = _rentalService.UpdateRetunrDate(rental);
            if (result.Success==true)
            {
                return Ok(rental);
            }
            return BadRequest(rental);
        }
        [HttpGet("rentaldetail")]
        public IActionResult RentalDetail()
        {
            var result = _rentalService.GetRentalDetails();
            if (result.Success == true)
            {
                return Ok();
            }
            return BadRequest();
        }

    }
}
