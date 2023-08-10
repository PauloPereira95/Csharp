using WebApiRelationships___PG.Models;

namespace WebApiRelationships___PG.DTOs
{
    public record struct CharacterCreateDto(string Name, BackpackCreateDto Backpack,
        List<FactionDto> factions,
        List<WeaponDto> Weapons);

}
