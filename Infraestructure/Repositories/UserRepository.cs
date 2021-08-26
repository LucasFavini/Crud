using Microsoft.EntityFrameworkCore;
using plu.Domain.IRepositories;
using plu.Infraestructure.context;
using plu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace plu.Infraestructure.Repositories
{
    public class UserRepository : IUserRepository
    {

        private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task SaveUser(User user)
        {
            _context.Add(user);
            await _context.SaveChangesAsync();
        } 

        public async Task<bool> ValidateExistence(User user)
        {
            var validate = await _context.Users.AnyAsync(x => x.name == user.name);
            return validate;
        }

    }
}
