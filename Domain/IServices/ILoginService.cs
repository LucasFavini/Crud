using plu.Domain.Models;
using plu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace plu.Domain.IServices
{
    public interface ILoginService
    {
        Task<User> ValidateUser(LogUser user);

    }
}
