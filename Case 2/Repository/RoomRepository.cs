using System.Collections.Generic;
using Case_2.Models;

namespace Case_2.Repositories
{
    public class RoomRepository
    {
        private List<Room> rooms = new List<Room>();

        // Constructor - laver mockdata
        public RoomRepository()
        {
            rooms.Add(new Room(1, "A101", 30));
            rooms.Add(new Room(2, "B202", 10));
        }

        // Henter alle rooms
        public List<Room> GetAll()
        {
            return rooms;
        }
    }
}



