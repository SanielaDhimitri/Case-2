using Case_2.Models;

namespace Case_2.Comperators.Descending
{
    public class NameDescendingComparator : IComparer<User>
    {
        public int Compare(User x, User y)
        {
            return string.Compare(y?.Name, x?.Name, StringComparison.OrdinalIgnoreCase);
        }
    }
}
