using Microsoft.AspNetCore.Mvc;
namespace webApiSnack.Services
{
    public interface ICustomerService
    {
        Task<List<Customer>>? GetAllCustomers();
        Task<Customer?> GetSingleCostumer(string nif);
        Task<List<Customer>>? AddCostumer([FromBody] Customer customer);
        Task<List<Customer>>? UpdateCustomer(string nif, Customer customer);
        Task<List<Customer>>? DeleteCustomer(string nif);
    }
}
