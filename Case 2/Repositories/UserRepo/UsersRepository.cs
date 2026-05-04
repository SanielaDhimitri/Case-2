//using Case_2.Models;
//using Microsoft.EntityFrameworkCore;
//using System;

//namespace Case_2.Registers.UserReg
//{
//    public class UsersRepository : IUserRepository
//    {
    
//        private readonly EfDbDbContext _context;

//        public UsersRepository(EfDbContext context)
//        {
//            _context = context;
//        }

//        public async Task<List<User>> GetAllAsync()
//        {
//            return await _context.Users.ToListAsync();
//        }

//        public async Task<User?> GetByEmailAsync(string email)
//        {
//            return await _context.Users
//                .FirstOrDefaultAsync(u => u.Email == email);
//        }

//        public async Task AddAsync(User user)
//        {
//            await _context.Users.AddAsync(user);
//        }

//        public async Task SaveAsync()
//        {
//            await _context.SaveChangesAsync();
//        }
//    }
//}
