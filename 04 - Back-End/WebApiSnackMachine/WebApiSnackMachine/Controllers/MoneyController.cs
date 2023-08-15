using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using WebApiSnackMachine.Models;
using WebApiSnackMachine.Services;

namespace WebApiSnackMachine.Controllers
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
        #region Add Money (OCULTADO)
        //// Create Money
        //[HttpPost]
        //public async Task<ActionResult<List<Money>>> AddMoney(Money money)
        //{
        //    var result = await _moneyService.AddMoney(money);
        //    if (result == null) return BadRequest("\"Something goes wrong, check data and try again !\"");
        //    return Ok(result);
        //}
        #endregion
        [HttpGet("{nif}")]
        public async Task<ActionResult<List<Money>>> GetMoneyCustomer(string nif)
        {
            var result = await _moneyService.GetMoneyCostumer(nif);
            if (result == null) return BadRequest("\"Something goes wrong, check data and try again !\"");
            return Ok(result);
        }
        [HttpPut("{nif}")]
        public async Task<ActionResult<List<Money>>> UpdateMoney(string nif, [FromBody] Money request)
        {
            var result = await _moneyService.UpdateMoney(nif,request);
            if (result == null) return Problem("Money of Customer Not Fund ! Check Data !");
            return Ok(result);

        }
    }
}
