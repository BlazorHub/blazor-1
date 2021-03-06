﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PhotoSharingApplication.Shared.Core.Entities {
    public class Photo {
        public int Id { get; set; }
        public string Title { get; set; }
        public byte[] PhotoFile { get; set; }
        public string ImageMimeType { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UserName { get; set; }
        public virtual ICollection<Photo> Photos { get; set; }
    }
}
