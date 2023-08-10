﻿using System.Text.Json.Serialization;

namespace WebApiRelationships___PG.Models
{
    public class Backpack
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int CharacterId { get; set; }
        [JsonIgnore]
        public Character Character { get; set; }
    }
}
