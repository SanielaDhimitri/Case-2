using System.Collections.Generic;
using Case_2.Models;

namespace Case_2
{
    public static class MockData
    {
        public static List<Room> GetRooms()
        {
            return new List<Room>
            {
                new Room(1, "A101", 30),
                new Room(2, "B202", 10),
                new Room(3, "C303", 50)
            };
        }
    }
}