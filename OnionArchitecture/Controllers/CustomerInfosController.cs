﻿using DomainLayer.Models;
using DomainLayer.Models.Request;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServicesLayer;
using ServicesLayer.CustomerService;
using ServicesLayer.CustomerService.ServiceInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnionArchitecture.Controllers
{
   [Route("api/[controller]")]
   [ApiController]
   public class CustomerInfosController : ControllerBase
    {
        private readonly ICustomerInfoService _customerService;
       
        public CustomerInfosController(ICustomerInfoService countryService)
        {
         _customerService = countryService;
        }
     

        [HttpGet(nameof(GetCustomer))]
        public IActionResult GetCustomer(int id)
        {
            var result = _customerService.GetCustomer(id);
            if(result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
            
        }
        [HttpGet(nameof(GetAllCustomer))]
        public IActionResult GetAllCustomer()
        {
            var result = _customerService.GetAllCustomer();
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");

        }
        [HttpPost(nameof(InsertCustomer))]
        public IActionResult InsertCustomer(CustomerInfo customer)
        {
           _customerService.InsertCustomer(customer);
            return Ok("Data inserted");
        }
        [AllowAnonymous]
        [HttpPut(nameof(UpdateCustomer))]
        public IActionResult UpdateCustomer(int id,UpdateCustomerInfo updateInfo)
        {
            _customerService.UpdateCustomer(id, updateInfo);
            return Ok("Updation done");

        }
        [HttpDelete(nameof(DeleteCustomer))]
        public IActionResult DeleteCustomer(int Id)
        {
            _customerService.DeleteCustomer(Id);
            return Ok("Data Deleted");

        }
    }
}
