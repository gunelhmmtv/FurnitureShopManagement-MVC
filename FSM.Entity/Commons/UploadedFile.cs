using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.Entity.Commons
{
    public class UploadedFile :EditedBaseEntity
    {
        public string FileName { get; set; }
        public string ContentType { get; set; }
        public string RelativePath { get; set; }

        public int? UserId { get; set; }

        public int? ProductId { get; set; }
    }
}
