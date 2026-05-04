using Case_2.Models;
namespace Case_2.Mock
{
    public class BookingMock
    {
        public static List<Booking> GetBookings()
        {
            return new List<Booking>
            {
                new Booking
                {
                    BookingId = 1,
                    RoomId = 101,
                    UserId = 1,
                    TimeSlot = new TimeSlot(1, "08:00", "10:00"),
                    Date = DateTime.Today,
                    Status = true
                },
                new Booking
                {
                    BookingId = 2,
                    RoomId = 102,
                    UserId = 2,
                    TimeSlot = new TimeSlot(2, "10:00", "12:00"),
                    Date = DateTime.Today,
                    Status = true
                }
            };
        }
    }
}