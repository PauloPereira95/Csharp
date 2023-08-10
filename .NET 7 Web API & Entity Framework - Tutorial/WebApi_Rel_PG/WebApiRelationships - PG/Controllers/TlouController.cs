using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiRelationships___PG.Data;
using WebApiRelationships___PG.DTOs;
using WebApiRelationships___PG.Models;
using Microsoft.EntityFrameworkCore;


namespace WebApiRelationships___PG.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TlouController : ControllerBase
    {
        private readonly DataContext _context;

        public TlouController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<Character>> GertCharacterById(int id)
        {
            var charcter = await _context.Character.Include(c => c.Backpack).Include(f => f.Factions)
                .Include(w => w.Weapons).FirstOrDefaultAsync(c => c.Id == id);
            return Ok(charcter);
        }

        [HttpPost]
        public async Task<ActionResult<List<Character>>> CreateCharacter(CharacterCreateDto request)
        {
            var newCharacter = new Character
            {
                Name = request.Name,

            };
            var backpack = new Backpack
            {
                Description = request.Backpack.Description,
                Character = newCharacter
            };
            var weapons = request.Weapons.Select(w => new Weapon { Name = w.Name, Character = newCharacter }).ToList();
            var factions = request.factions.Select(f => new Faction { Name = f.Name, Character = new List<Character> { newCharacter } }).ToList();


            newCharacter.Backpack = backpack;
            newCharacter.Weapons = weapons;
            newCharacter.Factions = factions;

            _context.Character.Add(newCharacter);
            await _context.SaveChangesAsync();
            return Ok(await _context.Character.Include(c => c.Backpack).Include(w => w.Weapons).ToListAsync());
        }

    }
}
