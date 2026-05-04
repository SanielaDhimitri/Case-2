using Case_2.Models;

namespace Case_2.MockData
{
    public class TimeSlotMock
    {
        public static List<TimeSlot> GetTimeSlots()
        {
            return new List<TimeSlot>
            {
                new TimeSlot(1, "08:00", "10:00"),
                new TimeSlot(2, "10:00", "12:00"),
                new TimeSlot(3, "12:00", "14:00"),
                new TimeSlot(4, "14:00", "16:00")
            };
        }
    }
}
