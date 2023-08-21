using Microsoft.AspNetCore.Mvc;
using WebApiSnackMachine.Models;

namespace WebApiSnackMachine.Services
{
    public interface IMoneyService
    {
        Task<IList<Money>>? GetAllMoney();
        Task<IList<Money>>? GetMoneyCostumer(string nif);
        Task<IList<Money>>? AddMoney([FromBody] Money money,string nif);
        Task<IList<Money>>? UpdateMoney(string nif, Money money);
        Task<IList<Money>>? DeleteMoney(string nif);
    }
}
