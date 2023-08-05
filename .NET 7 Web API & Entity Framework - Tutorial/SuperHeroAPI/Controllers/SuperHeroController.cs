using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperHeroAPI.Services.SuperHeroService;

namespace SuperHeroAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    // apenas chama os metodos
    public class SuperHeroController : ControllerBase
    {
        private readonly ISuperHeroService _superHeroService;
        public SuperHeroController(ISuperHeroService superHeroService)
        {
            this._superHeroService = superHeroService;
        }

        // obtem todos
        [HttpGet]
        public async Task<ActionResult<List<SuperHero>>> GetAlleHeroes()
        {
            return await _superHeroService.GetAllHeroes();

        }
        // obtem com id especifico
        [HttpGet("{id}")]
        public async Task<ActionResult<SuperHero>> GetSingleHeroes(int id)
        {
            var result = await _superHeroService.GetSingleHero(id);
            if (result == null) return NotFound("Hero not Fund !");
            return Ok(result);
        }
        // create
        [HttpPost]
        // from body especifica para procurar no body do request
        public async Task<ActionResult<List<SuperHero>>> AddHeroes([FromBody] SuperHero hero)
        {
            var result = await _superHeroService.AddHeroes(hero);
            return Ok(result);

        }
        // update
        [HttpPut("{id}")]
        public async Task<ActionResult<SuperHero>> UpdateHeroes(int id, SuperHero request)
        {
            var result = await _superHeroService.UpdateHeroes(id, request);
            if (result == null) return NotFound("Hero not Fund !");
            return Ok(result);

        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<List<SuperHero>>> DeleteHeroes(int id)
        {
            var result = await _superHeroService.DeleteHeroes(id);
            if (result == null) return NotFound("Hero not Fund !");
            return Ok(result);
        }
    }
}
