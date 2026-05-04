using Case_2.Models;

namespace Case_2.Services.UserServ
{
    public interface IUserService
    { 
        List<User> GetAllUsers();
        User Login(string email, string password);
        List<User> GetUsersByRole(RoleType role);

        void CreateUser(User user);
        void UpdateUser(User user);
        void DeleteUser(int id);
    }
}

