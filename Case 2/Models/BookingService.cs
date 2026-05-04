public class BookingService
{
    private BookingRepository bookingRepository;

    public BookingService(BookingRepository bookingRepository)
    {
        this.bookingRepository = bookingRepository;
    }

    public Booking CreateBooking(int userId, int roomId, DateTime startTime, DateTime endTime)
    {
        if (!CheckAvailability(roomId, startTime, endTime))
        {
            return null;
        }

        var booking = new Booking(
            new Random().Next(1, 10000),
            userId,
            roomId,
            startTime,
            endTime
        );

        bookingRepository.Save(booking);
        return booking;
    }

    public void CancelBooking(int bookingId)
    {
        bookingRepository.Delete(bookingId);
    }

    public List<Booking> GetBookingsByUser(int userId)
    {
        return bookingRepository.FindByUser(userId);
    }

    public bool CheckAvailability(int roomId, DateTime startTime, DateTime endTime)
    {
        var bookings = bookingRepository.FindByRoom(roomId);

        foreach (var booking in bookings)
        {
            if (startTime < booking.EndTime && endTime > booking.StartTime)
            {
                return false;
            }
        }

        return true;
    }
}
