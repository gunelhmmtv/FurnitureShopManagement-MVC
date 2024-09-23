using FS.DataAccessLayer.Abstract;
using FS.DataAccessLayer.EntityFrameworkCore.Contexts;
using FS.Entity.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.DataAccessLayer.EntityFrameworkCore.Concrete
{
    public class UploadedFileRepository : GenericRepository<UploadedFile>, IUploadedFileRepository
    {
        public UploadedFileRepository(FsContext dbContext) : base(dbContext)
        {
        }
    }
}
