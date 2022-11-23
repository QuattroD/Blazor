using Blazor.Pages;
using MongoDB.Driver;

namespace Blazor.Data
{
    public class MongoDB
    {
        public static List<Unit> GetUnits()
        {
            List<Unit> units = new List<Unit>();
            var client = new MongoClient();
            var database = client.GetDatabase("Army");
            var collection = database.GetCollection<Unit>("Test");
            var list = collection.Find(x => true).ToList();
            foreach (var item in list)
            {
                units.Add(item);
            }
            return units;
        }
    }
}
