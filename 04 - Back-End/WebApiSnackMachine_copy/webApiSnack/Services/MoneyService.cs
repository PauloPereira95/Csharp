using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace webApiSnack.Services
{
    public class MoneyService : IMoneyService
    {
        private readonly DataContext _context;
        public MoneyService(DataContext context)
        {
            this._context = context;
        }
        // Create Money
        public async Task<List<Money>>? AddMoney([FromBody] Money money)
        {
            _context.Money.Add(money);
            await _context.SaveChangesAsync();
            return await _context.Money.ToListAsync();
        }
        // Get Money
        public async Task<List<Money>>? GetAllMoney()
        {
            var moneys = await _context.Money.Where(m => !m.IsDeleted).ToListAsync();
            return moneys;
        }

        Task<List<Money>>? IMoneyService.DeletMoney(string nif)
        {
            throw new NotImplementedException();
        }

        async Task<List<Money>>? IMoneyService.GetMoneyCostumer(string nif)
        {
            //var cust = await _context.Customers.Where(c => c.Nif == nif).Select( c => c.Money).Include("Money").ToListAsync();
            var moneyCust = await _context.Customers.Where(n => n.Nif == nif)
                .Select(m => m.Money).ToListAsync();
            return moneyCust;
           
        }

        Task<List<Money>>? IMoneyService.UpdateMoney(string nif, Money money)
        {
            throw new NotImplementedException();
        }
    }
}
