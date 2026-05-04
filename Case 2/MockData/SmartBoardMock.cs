using Case_2.Models;
namespace Case_2.Mock
{
    public class SmartboardMock
    {
        public static List<Smartboard> GetSmartboards()
        {
            return new List<Smartboard>
            {
                new Smartboard { SmartboardId = 1, SmartboardName = "SB1", Availability = true },
                new Smartboard { SmartboardId = 2, SmartboardName = "SB2", Availability = false }
            };
        }
    }
}