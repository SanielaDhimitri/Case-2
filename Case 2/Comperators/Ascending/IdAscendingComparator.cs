using Case_2.Models;

namespace Case_2.Comperators.Ascending
{
    public class IdAscendingComparator:IComparer<User>
    {

        public int Compare(User x, User y)
        {
            return x.UserId.CompareTo(y.UserId);
        }
    }
}
