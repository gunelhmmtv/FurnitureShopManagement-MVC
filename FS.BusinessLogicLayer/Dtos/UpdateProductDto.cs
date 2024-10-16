﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.BusinessLogicLayer.Dtos
{
    public class UpdateProductDto
    {
        public UpdateProductDto()
        {
            UploadedFileDtos = new HashSet<UploadedFileDto>();
        }
        public int Id { get; set; }
        public string ProductName { get; set; }

        public double Price { get; set; }

        public bool InStock { get; set; }
        public int CategoryId { get; set; }
        public ICollection<UploadedFileDto> UploadedFileDtos { get; set; }
    }
}
