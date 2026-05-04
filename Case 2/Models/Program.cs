namespace Case_2.Models;

class Program
{
    static void Main(string[] args)
    {
        // Opret repository og service
        BookingRepository bookingRepository = new BookingRepository();
        BookingService bookingService = new BookingService(bookingRepository);

        // Opret en booking
        var booking = bookingService.CreateBooking(
            userId: 1,
            roomId: 101,
            startTime: DateTime.Now.AddHours(1),
            endTime: DateTime.Now.AddHours(3)
        );

        if (booking != null)
        {
            Console.WriteLine("Booking oprettet");
            Console.WriteLine($"Booking ID: {booking.BookingId}");
        }
        else
        {
            Console.WriteLine("Kunne ikke oprette booking (lokale optaget).");
        }

        // Hent bookinger for bruger
        var userBookings = bookingService.GetBookingsByUser(1);

        Console.WriteLine("\nBrugerens bookinger:");
        foreach (var b in userBookings)
        {
            Console.WriteLine($"Room: {b.RoomId}, Start: {b.StartTime}, Slut: {b.EndTime}");
        }
    }
}