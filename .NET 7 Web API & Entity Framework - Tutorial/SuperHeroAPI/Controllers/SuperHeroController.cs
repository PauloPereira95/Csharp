﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperHeroAPI.Models;

namespace SuperHeroAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {

        private static List<SuperHero> superHeroes = new List<SuperHero>
            {
                new SuperHero
                {
                    Id = 1,
                    Name ="Spider-Man",
                    FirstName ="Peter",
                    LastName ="Parker",
                    Place="New York City"
                },
                new SuperHero
                {
                    Id = 2,
                    Name ="Iron-Man",
                    FirstName ="Tony",
                    LastName ="Stark",
                    Place="Malibu"
                }
            };
        // obtem todos
        [HttpGet]
        public async Task<ActionResult<List<SuperHero>>> GetAllHeroes()
        {
            return Ok(superHeroes);

        }
        // obtem com id especifico
        [HttpGet("{id}")]
        public async Task<ActionResult<SuperHero>> GetAllHeroes(int id)
        {
            var hero = superHeroes.Find(x => x.Id == id);
            if (hero == null) return NotFound("Sorry, but hero dont exist");
            return Ok(hero);

        }
        // create
        [HttpPost]
        // from body especifica para procurar no body do request
        public async Task<ActionResult<List<SuperHero>>> AddHeroes([FromBody]SuperHero hero)
        {
            superHeroes.Add(hero);
            return Ok(superHeroes);

        }
        [HttpPut("{id}")]
        public async Task<ActionResult<SuperHero>> UpdateAllHeroes(int id)
        {
            var hero = superHeroes.Find(x => x.Id == id);
            if (hero == null) return NotFound("Sorry, but hero dont exist");
            return Ok(hero);

        }
    }
}
