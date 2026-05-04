using Case_2.Models;

namespace Case_2.Comperators.Ascending
{
    public class NameAscendingComparator : IComparer<User>
    {
        public int Compare(User x, User y)
        {
            return string.Compare(x.Name, y.Name);
        }
    }
}

