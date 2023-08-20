using Microsoft.AspNetCore.Mvc;
using WebApiSnackMachine.Models;

namespace WebApiSnackMachine.Services
{
    public interface IMoneyService
    {
        Task<List<Money>>? GetAllMoney();
        Task<List<Money>>? GetMoneyCostumer(string nif);
        Task<List<Money>>? AddMoney([FromBody] Money money,string nif);
        Task<List<Money>>? UpdateMoney(string nif, Money money);
        Task<List<Money>>? DeleteMoney(string nif);
    }
}
