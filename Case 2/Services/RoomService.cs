using Case_2.Models;
using Case_2.Repositories;
using System.Collections.Generic;

namespace Case_2.Services
{
    public class RoomService
    {
        private RoomRepository repository;

        public RoomService(RoomRepository repository)
        {
            this.repository = repository;
        }

        public List<Room> GetAllRooms()
        {
            return repository.GetAll();
        }
    }
}