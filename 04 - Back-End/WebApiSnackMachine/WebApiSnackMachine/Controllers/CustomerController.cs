﻿using Microsoft.AspNetCore.Mvc;
using WebApiSnackMachine.Models;
using WebApiSnackMachine.Services;

namespace WebApiSnackMachine.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        public CustomerController(ICustomerService customerService)
        {
            this._customerService = customerService;
        }
        [HttpGet]

        // Get All
        public async Task<ActionResult<List<Customer>>> GetAllCustomers()
        {
            var result = await _customerService.GetAllCustomers();

            return Ok(result);
        }
        [HttpGet("{nif}")]
        public async Task<ActionResult<List<Customer>>> GetSingleCostumer(string nif)
        {
            try
            {
                var result = await _customerService.GetSingleCostumer(nif);
                if (result == null) return NotFound("Customer Not Fund ! Check Data !");

                return Ok(result);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message + " Check NIF !");
            }
        }
        // Create   
        [HttpPost]
        public async Task<ActionResult<List<Customer>>> AddCustomer([FromBody] Customer customer)
        {
            var result = await _customerService.AddCostumer(customer);
            if (result == null) return BadRequest("Something goes wrong, check data and try again !");
            return Ok(result);
        }
        
        // Update
        [HttpPut("{nif}")]
        public async Task<ActionResult<List<Customer>>> UpdateCustomer(string nif, [FromBody] Customer request)
        {
            var result = await _customerService.UpdateCustomer(nif, request);
            if (result == null) return NotFound("Customer Not Fund ! Check Data !");

            return Ok(result);
        }
        // Soft Delete
        [HttpDelete("{nif}")]
        public async Task<ActionResult<List<Customer>>> DeleteCustomer(string nif)
        {
            var result = await _customerService.DeleteCustomer(nif);
            if (result == null) return NotFound("Customer Not Fund ! Check Data !");

            return Ok(result);
        }


    }
}