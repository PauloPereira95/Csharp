using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webApiSnack.Services;

namespace webApiSnack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class MoneyController : ControllerBase
    {
        private readonly IMoneyService _moneyService;
        public MoneyController(IMoneyService moneyService)
        {
            this._moneyService = moneyService;
        }

        // Get All
        [HttpGet]
        public async Task<ActionResult<List<Money>>> GetAllMoney()
        {
            var result = await _moneyService.GetAllMoney();
            return Ok(result);
        }
        // Create Money
        [HttpPost]
        public async Task<ActionResult<List<Money>>> AddMoney(Money money)
        {
            var result = await _moneyService.AddMoney(money);
            if (result == null) return BadRequest("\"Something goes wrong, check data and try again !\"");
            return Ok(result);
        }
        [HttpGet("{nif}")]
        public async Task<ActionResult<List<Money>>> GetMoneyCustomer(string nif)
        {
            var result = await _moneyService.GetMoneyCostumer(nif);
            if (result == null) return BadRequest("\"Something goes wrong, check data and try again !\"");
            return Ok(result);
        }
    }
}
