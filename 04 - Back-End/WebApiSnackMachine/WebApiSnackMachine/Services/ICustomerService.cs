using Microsoft.AspNetCore.Mvc;
using WebApiSnackMachine.Models;

namespace WebApiSnackMachine.Services
{
    public interface ICustomerService
    {
        Task<IList<Customer>>? GetAllCustomer();
        Task<Customer?> GetSingleCostumer(string nif);
        Task<IList<Customer>>? AddCostumer([FromBody] Customer customer);
        Task<IList<Customer>>? UpdateCustomer(string nif, Customer customer);
        Task<IList<Customer>>? DeleteCustomer(string nif);
    }
}
