using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiSnackMachine.Data;
using WebApiSnackMachine.Models;

namespace WebApiSnackMachine.Services
{
    public class CustomerService : ICustomerService
    {
        
        private readonly DataContext _context;
        public CustomerService(DataContext context)
        {
            this._context = context;
        }
        public async Task<IList<Customer>>? AddCostumer([FromBody] Customer customer)
        {

            _context.Customer.Add(customer);

            await _context.SaveChangesAsync();

            return await _context.Customer.ToListAsync();
        }
        public async Task<IList<Customer>>? DeleteCustomer(string nif)
        {
            var customer = await _context.Customer.Where(n => n.Nif == nif).ToListAsync();
            if (customer == null) return null;
            foreach (var item in customer)
            {
                item.IsDeleted = true;
                item.DeleteAt = DateTime.Now;
            }
            await _context.SaveChangesAsync();
            return await _context.Customer.ToListAsync();

        }

        public async Task<IList<Customer>>? GetAllCustomer()
        {
            var Customer = await _context.Customer.Where(c => !c.IsDeleted).Include("Money").ToListAsync();
            return Customer;
        }

        public async Task<Customer?> GetSingleCostumer(string nif)
        {
            var Customer = await _context.Customer.Include("Money").SingleAsync(n => n.Nif == nif);
            if (Customer == null) return null;

            return Customer;

        }

        public async Task<IList<Customer>>? UpdateCustomer(string nif, Customer request)
        {
            var Customer = await _context.Customer.SingleAsync(n => n.Nif == nif);
            Customer.Name = request.Name;
            Customer.Adress = request.Adress;
            Customer.Tele = request.Tele;
            Customer.Nif = request.Nif;
            Customer.LastUpdateAt = DateTime.Now;

            await _context.SaveChangesAsync();

            return await _context.Customer.ToListAsync();
        }
    }
}
