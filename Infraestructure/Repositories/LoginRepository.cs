using Microsoft.EntityFrameworkCore;
using plu.Domain.Models;
using plu.Infraestructure.context;
using plu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace plu.Infraestructure.Repositories
{
    public class LoginRepository : ILoginRepository
    {
        private readonly ApplicationDbContext _context;

        public LoginRepository(ApplicationDbContext context)
        {
             _context = context;
        }

        public async Task<User> ValidateUser(LogUser user)
        {
            var myUser = await _context.Users.Where(x => x.email == user.email && x.password == user.password).FirstOrDefaultAsync();

            return myUser;
        }
    }
}
