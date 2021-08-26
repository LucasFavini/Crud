using plu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace plu.Domain.IRepositories
{
    public interface IUserRepository
    {
        Task SaveUser(User user);
        Task <bool> ValidateExistence(User user);
    }
}
