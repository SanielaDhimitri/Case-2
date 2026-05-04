using Case_2.Models;

namespace Case_2.MockData
{
    public class BuildingMock
    {
        public static List<Building> GetBuildings()
        {
            return new List<Building>
            {
                new Building { BuildingId = 1, BuildingName = "Bygning A", Address = "Roskilde" },
                new Building { BuildingId = 2, BuildingName = "Bygning B", Address = "Køge" }
            };
        }
    }
}