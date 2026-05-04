public class BookingOverview
{
    public List<Booking> Bookings { get; set; }

    public BookingOverview()
    {
        Bookings = new List<Booking>();
    }

    public void AddBooking(Booking booking)
    {
        Bookings.Add(booking);
    }

    public List<Booking> GetAllBookings()
    {
        return Bookings;
    }
}