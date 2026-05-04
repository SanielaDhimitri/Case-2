using Case_2.Mock;
using Case_2.Models;
using Microsoft.AspNetCore.Identity;

namespace Case_2.Services.UserServ
{
    public class UserMockService : IUserService
    {
            private List<User> _users = UserMock.GetMockUsers();

            public List<User> GetAllUsers()
            {
                return _users;
            }

        public User Login(string email, string password)
        {
            var user = _users.FirstOrDefault(u => u.Email == email);

            if (user == null)
                return null;

            var passwordHasher = new PasswordHasher<string>();

            var result = passwordHasher.VerifyHashedPassword(
                null,
                user.Password,
                password
            );

            if (result == PasswordVerificationResult.Success)
                return user;

            return null;
        }

        public List<User> GetUsersByRole(RoleType role)
        {
            return _users
                .Where(u => u.Role == role)
                .ToList();
        }


        public void CreateUser(User user)
            {
                user.UserId = _users.Max(u => u.UserId) + 1;
                _users.Add(user);
            }


            public void UpdateUser(User user)
            {
                var existing = _users.FirstOrDefault(u => u.UserId == user.UserId);
                if (existing != null)
                {
                    existing.Name = user.Name;
                    existing.Email = user.Email;
                    existing.Password = user.Password;
                    existing.Role = user.Role;
                }
            }

            public void DeleteUser(int id)
            {
                var user = _users.FirstOrDefault(u => u.UserId == id);
                if (user != null)
                    _users.Remove(user);
            }
        }
    }




