using Microsoft.AspNetCore.Mvc;
using SuperHeroAPI.Models;

namespace SuperHeroAPI.Services.SuperHeroService
{
    public interface ISuperHeroService
    {
        Task<List<SuperHero>>? GetAllHeroes();
        Task<SuperHero>? GetSingleHero(int id);
        Task<List<SuperHero>>? AddHeroes([FromBody] SuperHero hero);
        Task<List<SuperHero>>? UpdateHeroes(int id, SuperHero request);
        Task<List<SuperHero>>? DeleteHeroes(int id);
    }
}
