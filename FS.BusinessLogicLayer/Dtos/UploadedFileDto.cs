﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.BusinessLogicLayer.Dtos
{
    public class UploadedFileDto
    {
        public string FileName { get; set; }
        public string ContentType { get; set; }
        public string RelativePath { get; set; }
    }
}
