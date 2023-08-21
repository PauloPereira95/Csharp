using Microsoft.AspNetCore.Mvc;
using WebApiSnackMachine.Models;

namespace WebApiSnackMachine.Services
{
    public interface ICustomerService
    {
        Task<List<Customer>>? GetAllCustomer();
        Task<Customer?> GetSingleCostumer(string nif);
        Task<List<Customer>>? AddCostumer([FromBody] Customer customer);
        Task<List<Customer>>? UpdateCustomer(string nif, Customer customer);
        Task<List<Customer>>? DeleteCustomer(string nif);
    }
}
