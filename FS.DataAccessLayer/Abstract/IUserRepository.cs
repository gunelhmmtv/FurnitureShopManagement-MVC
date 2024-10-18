using FS.Entity.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.DataAccessLayer.Abstract
{
    public interface IUserRepository : IGenericRepository<User>
    {
        Task<User> GetSigninUserWithDetailAsync(string email);
    }
}
