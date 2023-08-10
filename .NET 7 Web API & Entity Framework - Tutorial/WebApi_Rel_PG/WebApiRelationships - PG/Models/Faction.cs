using System.Text.Json.Serialization;

namespace WebApiRelationships___PG.Models
{
    public class Faction
    {
        public int  Id { get; set; }
        public string  Name { get; set; }
        [JsonIgnore]
        public List<Character> Character { get; set; }
    }
}
