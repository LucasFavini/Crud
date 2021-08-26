using plu.Domain.Models;
using plu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace plu.Infraestructure.Repositories
{
    public interface ILoginRepository
    {
        Task<User> ValidateUser(LogUser user);
    }
}
