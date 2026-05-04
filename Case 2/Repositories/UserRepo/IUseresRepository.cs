using Case_2.Models;

namespace Case_2.Registers.UserReg
{
    public interface IUseresRepository
    {
     
            Task<List<User>> GetAllUsersAsync();
            Task<User?> LoginAsync(string email, string password);
            Task CreateUserAsync(User user);
        }
    }
