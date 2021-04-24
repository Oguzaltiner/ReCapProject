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
    public class CarsController : ControllerBase
    {
        ICarService _carService;
        public CarsController(ICarService carService)
        {
            _carService = carService;
        }
        [HttpPost("add")]
        public IActionResult Add(Car car)
        {
            var result = _carService.Add(car);
            return Ok(result.Message);
        }
        [HttpPost("delete")]
        public IActionResult Delete(Car car)
        {
            var result = _carService.Delete(car);
            return Ok(result.Message);
        }
        [HttpPost("update")]
        public IActionResult Update(Car car)
        {
            var result = _carService.Update(car);
            return Ok(result.Message);
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {

            var result = _carService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);

        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {

            var result = _carService.Get(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
        [HttpGet("getbybrandid")]
        public IActionResult GetByBrandId(int brandId)
        {

            var result = _carService.GetCarByBrandId(brandId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);

        }
        [HttpGet("getbycolorid")]
        public IActionResult GetByColorId(int colorId)
        {

            var result = _carService.GetCarByBrandId(colorId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);

        }
        [HttpGet("getcardetails")]
        public IActionResult GetCarDetails()
        {
            var result = _carService.GetCarDetails();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpGet("getcardetailbycarid")]
        public IActionResult GetCarDetailByCarId(int carId)
        {
            var result = _carService.GetAllCarDetailByCarId(carId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpGet("getdtobrandandcolorid")]
        public IActionResult GetDtoBrandAndColorId(int brandId, int colorId)
        {
            var result = _carService.GetDtoBrandAndColorId(brandId, colorId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
