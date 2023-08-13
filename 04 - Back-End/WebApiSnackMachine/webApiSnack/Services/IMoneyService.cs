using Microsoft.AspNetCore.Mvc;

namespace webApiSnack.Services
{
    public interface IMoneyService
    {
        Task<List<Money>>? GetAllMoney();
        Task<List<Money>>? GetMoneyCostumer(string nif);
        Task<List<Money>>? AddMoney([FromBody] Money money);
        Task<List<Money>>? UpdateMoney(string nif,  Money money);
        Task<List<Money>>? DeletMoney(string nif);
    }
}
