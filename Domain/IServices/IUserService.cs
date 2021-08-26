using plu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace plu.Domain.IServices
{
    public interface IUserService
    {
        Task SaveUser(User user);
        Task <bool> ValidateExistence(User user);
    }
}
