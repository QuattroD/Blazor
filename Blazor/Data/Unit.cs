using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Blazor.Data
{
    public class Unit
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        ObjectId _id;
        public string name { get; set; }
        public string Class { get; set; }
        public int LVL { get; set; }
        public int Currentexp { get; set; }
        public int TotalExp { get; set; }
        public double health { get; set; }
        public double MaxHealth { get; set; }
        public double physicaldefence { get; set; }
        public double damage { get; set; }
        public double magicdamage { get; set; }
        public double manapool { get; set; }
        public double MaxMana { get; set; }
        public double Strength { get; set; }
        public double Dexterity { get; set; }
        public double Constitution { get; set; }
        public double Intellisence { get; set; }
        [BsonIgnoreIfNull]
        public string? helmet { get; set; }
        [BsonIgnoreIfNull]
        public string? armor { get; set; }
        [BsonIgnoreIfNull]
        public string? weapon { get; set; }
    }
}
