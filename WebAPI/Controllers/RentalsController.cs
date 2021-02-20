﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentalsController : ControllerBase
    {
        private IRentalService _rentalService;
        public RentalsController(IRentalService rentalService)
        {
            _rentalService = rentalService;
        }


        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _rentalService.GetAll();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }
        [HttpPost("add")]
        public IActionResult Add(Rental rental)
        {
            var result = _rentalService.Add(rental);
            return Ok(result.Message);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Rental rental)
        {
            var result = _rentalService.Delete(rental);
            return Ok(result.Message);
        }
        [HttpPost("update")]
        public IActionResult Update(Rental rental)
        {
            var result = _rentalService.Update(rental);
            return Ok(result.Message);
        }


    }
}
