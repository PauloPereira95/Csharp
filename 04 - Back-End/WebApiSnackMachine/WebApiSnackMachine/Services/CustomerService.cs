using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiSnackMachine.Data;
using WebApiSnackMachine.Models;

namespace WebApiSnackMachine.Services
{
    public class CustomerService : ICustomerService
    {
        private static List<Customer> customers = new List<Customer>
        {
            //new Customer
            //{
            //    Name = "Joaquim",
            //    Adress = "Rua de cima n252",
            //    Tele = "915133435345",
            //    CreateAt = DateTime.Now,
            //    LastUpdateAt = DateTime.Now,
            //    DeleteAt = null,
            //    IsDeleted = false,

            //}
        };
        private readonly DataContext _context;
        public CustomerService(DataContext context)
        {
            this._context = context;
        }
        public async Task<List<Customer>>? AddCostumer([FromBody] Customer customer)
        {

            _context.Customers.Add(customer);

            await _context.SaveChangesAsync();

            return await _context.Customers.ToListAsync();
        }
        public async Task<List<Customer>>? DeleteCustomer(string nif)
        {
            var customer = await _context.Customers.Where(n => n.Nif == nif).ToListAsync();
            if (customer == null) return null;
            foreach (var item in customer)
            {
                item.IsDeleted = true;
            }
            await _context.SaveChangesAsync();
            return await _context.Customers.ToListAsync();

        }

        public async Task<List<Customer>>? GetAllCustomers()
        {
            var customers = await _context.Customers.Where(c => !c.IsDeleted).ToListAsync();
            return customers;
        }

        public async Task<Customer?> GetSingleCostumer(string nif)
        {
            var customers = await _context.Customers.SingleAsync(n => n.Nif == nif);
            if (customers == null) return null;

            return customers;

        }

        public async Task<List<Customer>>? UpdateCustomer(string nif, Customer request)
        {
            var customers = await _context.Customers.SingleAsync(n => n.Nif == nif);
            customers.Name = request.Name;
            customers.Adress = request.Adress;
            customers.Tele = request.Tele;
            customers.Nif = request.Nif;
            customers.LastUpdateAt = DateTime.Now;

            await _context.SaveChangesAsync();

            return await _context.Customers.ToListAsync();
        }
    }
}
