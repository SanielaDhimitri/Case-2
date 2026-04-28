using Case_2.Comperators.Ascending;
using Case_2.Comperators.Descending;
using Case_2.Models;
using Case_2.Services.UserServ;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Case_2.Pages.UsersPage
{
    public class GetAllUsersModel : PageModel
    {
        private readonly IUserService _userService;

        public List<User> Users { get; set; } = new List<User>();

        public GetAllUsersModel(IUserService userService)
        {
            _userService = userService;
        }

        [BindProperty]
        public string SearchString { get; set; }

        [BindProperty]
        public int? SearchId { get; set; }
        [BindProperty(SupportsGet = true)]
        public RoleType? Role { get; set; }
        public void OnGet()
        {
            if (Role.HasValue)
            {
                Users = _userService.GetUsersByRole(Role.Value);
            }
            else
            {
                Users = _userService.GetAllUsers();
            }
        }
        public void OnPostNameSearch()
        {
            Users = _userService.GetAllUsers()
                .Where(u => u.Name != null &&
                            u.Name.ToLower().Contains(SearchString.ToLower()))
                .ToList();
        }
        public void OnPostIdSearch()
        {
            Users = _userService.GetAllUsers()
                .Where(u => u.UserId == SearchId)
                .ToList();
        }
        public void OnGetSortById()
        {
            Users = _userService.GetAllUsers();
            Users.Sort(new IdAscendingComparator());
        }

        public void OnGetSortByIdDesc()
        {
            Users = _userService.GetAllUsers();
            Users.Sort(new IdDescendingComparator());
        }

        public void OnGetSortByName()
        {
            Users = _userService.GetAllUsers();
            Users.Sort(new NameAscendingComparator());
        }

        public void OnGetSortByNameDesc()
        {
            Users = _userService.GetAllUsers();
            Users.Sort(new NameDescendingComparator());
        }
    }
}