using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiSnackMachine.Data;
using WebApiSnackMachine.Models;

namespace WebApiSnackMachine.Services
{
    public class MachineSerice : IMachineService
    {
        private readonly DataContext _context;
        public MachineSerice(DataContext context)
        {
            this._context = context;
        }
        public async Task<IList<Machine>>? AddMachine([FromBody] Machine machine)
        {
            _context.Machine.Add(machine);
            await _context.SaveChangesAsync();
            return await _context.Machine.ToListAsync();
        }
        public async Task<IList<Machine>>? GetAllMachine()
        {
            var machines = await _context.Machine.Where(c => !c.IsDeleted).ToListAsync();
            return machines;
        }

        public async Task<IList<Machine>>? DeleteMachine(string name)
        {
            var machine = await _context.Machine.Where(n => n.MachineName == name).ToListAsync();
            if (machine == null) return null;
            foreach (var item in machine)
            {
                item.IsDeleted = true;
                item.DeleteAt = DateTime.Now;
            }
            await _context.SaveChangesAsync();
            return await _context.Machine.ToListAsync();
        }


        public async Task<Machine>? GetSingleMachine(string name)
        {
            var machine = await _context.Machine.SingleAsync(n => n.MachineName == name);
            if (machine == null) return null;
            return machine;
        }

        public async Task<IList<Machine>>? UpdateMachine(string name, Machine request)
        {
            var machine = await _context.Machine.SingleAsync(n => n.MachineName == name);
            machine.MachineName = request.MachineName;
            machine.Location = request.Location;
            machine.LastUpdateAt = DateTime.Now;
            //
            machine.Support = request.Support;
            machine.Intervection = request.Intervection;
            machine.Size = request.Size;
            await _context.SaveChangesAsync();
            return await _context.Machine.ToListAsync();
        }
    }
}

