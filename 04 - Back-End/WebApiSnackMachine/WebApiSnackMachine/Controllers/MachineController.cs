using Microsoft.AspNetCore.Mvc;
using System.Reflection.PortableExecutable;
using WebApiSnackMachine.Models;
using WebApiSnackMachine.Services;
using Machine = WebApiSnackMachine.Models.Machine;

namespace WebApiSnackMachine.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class MachineController : Controller
    {
        private readonly IMachineService _machineService;
        public MachineController(IMachineService machineService)
        {
            this._machineService = machineService;
        }
        // Get All
        [HttpGet]
        public async Task<ActionResult<IList<Machine>>> GetAllMachines()
        {
            var result = await _machineService.GetAllMachine();
            return Ok(result);
        }
        [HttpGet("{name}")]
        public async Task<ActionResult<IList<Machine>>> GetSingleMachine(string name)
        {
            var result = await _machineService.GetSingleMachine(name);
            if (result == null) return BadRequest("Something goes wrong, check data and try again !");
            return Ok(result);
        }
        // Create
        [HttpPost]
        public async Task<ActionResult<IList<Machine>>> AddMachine([FromBody] Machine machine)
        {
            var result = await _machineService.AddMachine(machine);
            if (result == null) return BadRequest("Something goes wrong, check data and try again !");
            return Ok(result);
        }
        [HttpDelete("{name}")]
        public async Task<ActionResult<IList<Machine>>> DeleteMachine(string name)
        {
            var result = await _machineService.DeleteMachine(name);
            if (result == null) return null;
            return Ok(result);
        }
        [HttpPut("{name}")]
        public async Task<ActionResult<IList<Machine>>> UpdateMachine(string name, [FromBody] Machine request)
        {
            var result = await _machineService.UpdateMachine(name,request);
            if (result == null) return NotFound("Machine Not Fund ! Check Data !");
            return Ok(result);
        }

       
    }
}
