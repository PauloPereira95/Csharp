using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiSnackMachine.Data;
using WebApiSnackMachine.Models;

namespace WebApiSnackMachine.Services
{
    public class MoneyService : IMoneyService
    {
        private readonly DataContext _context;
        public MoneyService(DataContext context)
        {
            this._context = context;
        }
        // Create Money
        public async Task<List<Money>>? AddMoney([FromBody] Money money,string nif)
        {
            //_context.Money.Add(money,nif);
            //await _context.SaveChangesAsync();
            //return await _context.Money.ToListAsync();

            var cust = await _context.Customer.Where(n => n.Nif == nif).Include("Money").SingleOrDefaultAsync();
            //var moneyCust = await _context.Money.SingleAsync(i => i.Customer.IDCostumer == cust);
            if (cust != null)
            {
                
                _context.Money.Add(money);

                cust.Money.Add(money);
                await _context.SaveChangesAsync();

                return await _context.Money.ToListAsync();
            }
            return null;
        }
        // Get Money
        public async Task<List<Money>>? GetAllMoney()
        {
            var moneys = await _context.Money.Where(m => !m.IsDeleted).ToListAsync();
            return moneys;
        }

        
        public async Task<List<Money>>? GetMoneyCostumer(string nif)
        {
            var cust = await _context.Customer.Include("Money").Where(n => n.Nif == nif).
                Select(m => m.Money).FirstOrDefaultAsync();
                             
            //var moneyCust = await _context.Customer.Include(m => m.Money).Where(n => n.Nif == nif).
            //   ToListAsync();

            return (List<Money>)cust;
            //throw new NotImplementedException();
        }

        public async Task<List<Money>>? UpdateMoney(string nif, Money request)
        {
            var cust = await _context.Customer.Where(n => n.Nif == nif).Select(n => n.IDCostumer).SingleOrDefaultAsync();
            
            // colect costumer id
            var moneyCustumer = await _context.Money.SingleAsync(i => i.Customer.IDCostumer == cust);
            moneyCustumer.FiveEuro = request.FiveEuro;
            moneyCustumer.OneCent = request.OneCent;
            moneyCustumer.OneEuro = request.OneEuro;
            moneyCustumer.QuarterCent = request.QuarterCent;
            moneyCustumer.TenCent = request.TenCent;
            moneyCustumer.TwentyCent = request.TwentyCent;
            moneyCustumer.LastUpdateAt = DateTime.Now;


            // UMA SEGUNDA FORMA DE Update
            #region Metodo 2 UPDATE
            //await _context.Customer.Where(n => n.Nif == nif).Include("Money")
            //    .ExecuteUpdateAsync(update =>
            //    update.SetProperty(money => money.Money.OneEuro, request.OneEuro)
            //    .SetProperty(money => money.Money.FiveEuro, request.FiveEuro)
            //    .SetProperty(money => money.Money.OneCent, request.OneCent)
            //    .SetProperty(money => money.Money.OneEuro, request.OneEuro)
            //    .SetProperty(money => money.Money.QuarterCent, request.QuarterCent)
            //    .SetProperty(money => money.Money.TenCent, request.TenCent)
            //    .SetProperty(money => money.Money.TwentyCent, request.TwentyCent)
            //    .SetProperty(money => money.Money.LastUpdateAt, (DateTime?)DateTime.Now));

            #endregion
            await _context.SaveChangesAsync();
            return await _context.Money.ToListAsync();
        }

        public async Task<List<Money>>? DeleteMoney(string nif)
        {
            var cust = await _context.Customer.Where(n => n.Nif == nif).Select(n => n.IDCostumer).SingleOrDefaultAsync();
            // colect costumer id
            var moneyCustumer = await _context.Money.SingleAsync(i => i.Customer.IDCostumer == cust);

            
            if (moneyCustumer == null) return null;

            moneyCustumer.IsDeleted = true ;
            moneyCustumer.DeleteAt = DateTime.Now;

            await _context.SaveChangesAsync();
            return await _context.Money.ToListAsync();
        }
    }
}
