using Case_2.Models;
namespace Case_2.Mock
{
    public class RoomTypeMock
    {
        public static List<RoomType> GetRoomTypes()
        {
            return new List<RoomType>
            {
                new RoomType { RoomTypeId = 1, TypeName = "Klasselokale" },
                new RoomType { RoomTypeId = 2, TypeName = "Mødelokale" },
                new RoomType { RoomTypeId = 3, TypeName = "Auditorium" }
            };
        }
    }
}