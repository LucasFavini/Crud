using plu.Domain.IServices;
using plu.Domain.Models;
using plu.Infraestructure.Repositories;
using plu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace plu.Services
{
    public class LoginService : ILoginService 
    {
        private readonly ILoginRepository _loginRepository;
        public LoginService(ILoginRepository loginRepository)
        {
            _loginRepository = loginRepository;
        }

        public async Task<User> ValidateUser(LogUser user)
        {
            return await _loginRepository.ValidateUser(user);
        }
    }
}
