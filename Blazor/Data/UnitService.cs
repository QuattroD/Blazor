using MongoDB.Driver;

namespace Blazor.Data
{
    public class UnitService
    {
        public List<Unit> units = new List<Unit>();
        public List<Unit> getUnits()
        {
            return units;
        }

        public List<Unit> setUnits()
        {
            units = MongoDB.GetUnits();
            return units;
        }
    }
}
