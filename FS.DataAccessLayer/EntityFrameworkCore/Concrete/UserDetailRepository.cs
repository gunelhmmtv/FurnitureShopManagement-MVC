using FS.DataAccessLayer.Abstract;
using FS.DataAccessLayer.EntityFrameworkCore.Contexts;
using FS.Entity.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.DataAccessLayer.EntityFrameworkCore.Concrete
{
    public class UserDetailRepository : GenericRepository<UserDetail>, IUserDetailRepository
    {
        public UserDetailRepository(FsContext dbContext) : base(dbContext)
        {
        }
    }
}
