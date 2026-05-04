using Case_2.Models;
namespace Case_2.Mock
{
    public class BuildingMock
    {
        public static List<Building> GetBuildings()
        {
            return new List<Building>
            {
                new Building { Id = 1, Name = "Bygning A", Address = "Roskilde" },
                new Building { Id = 2, Name = "Bygning B", Address = "Køge" }
            };
        }
    }
}