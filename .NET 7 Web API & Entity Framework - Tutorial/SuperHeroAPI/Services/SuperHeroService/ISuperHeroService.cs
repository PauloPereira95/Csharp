using SuperHeroAPI.Models;

namespace SuperHeroAPI.Services.SuperHeroService
{
    public interface ISuperHeroService
    {
        List<SuperHero> GetAllHeroes();
    }
}
