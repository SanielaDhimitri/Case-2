using Case_2.Models;

namespace Case_2.Comperators.Descending
{
    public class IdDescendingComparator : IComparer<User>
    {
        public int Compare(User x, User y)
        {
            return y.UserId.CompareTo(x.UserId);
        }
    }
}
