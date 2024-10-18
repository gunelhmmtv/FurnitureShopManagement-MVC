using FS.CoreLayer.Enums;
using FS.DataAccessLayer.Abstract;
using FS.DataAccessLayer.EntityFrameworkCore.Contexts;
using FS.Entity.Accounts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.DataAccessLayer.EntityFrameworkCore.Concrete
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(FsContext dbContext) : base(dbContext)
        {
        }
        public Task<User> GetSigninUserWithDetailAsync(string email)
        {
            return TableEntity
                .Include(x => x.UserDetail)
                .Where(x => x.Email == email && x.UserDetail.StatusId == (int)RegisterStatusEnum.RegisterUser)
                .FirstOrDefaultAsync();

        }
    }
}
