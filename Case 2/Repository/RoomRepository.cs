using System.Collections.Generic;
using Case_2.Models;

namespace Case_2.Repositories
{
    public class RoomRepository
    {
        private List<Room> rooms = new List<Room>();

        public RoomRepository()
        {
            // mockdata
            rooms.Add(new Room(1, "A101", 30));
            rooms.Add(new Room(2, "B202", 10));
        }

        // Hent alle rooms
        public List<Room> GetAll()
        {
            return rooms;
        }

        // Find room med id
        public Room GetById(int id)
        {
            foreach (var room in rooms)
            {
                if (room.Id == id)
                {
                    return room;
                }
            }
            return null;
        }

        // Tilføj et room
        public void Add(Room room)
        {
            rooms.Add(room);
        }
    }
}




