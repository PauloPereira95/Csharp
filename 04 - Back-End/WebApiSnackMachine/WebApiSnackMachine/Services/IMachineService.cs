using Microsoft.AspNetCore.Mvc;
using WebApiSnackMachine.Models;

namespace WebApiSnackMachine.Services
{
    public interface IMachineService
    {
        Task<IList<Machine>>? GetAllMachine(); //
        Task<Machine>? GetSingleMachine(string name);
        Task<IList<Machine>>? AddMachine([FromBody] Machine machine);
        Task<IList<Machine>>? UpdateMachine(string name, Machine machine);
        Task<IList<Machine>>? DeleteMachine(string name); //
    }
}
