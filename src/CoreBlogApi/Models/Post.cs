﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlogApi.Models
{
    public class Post
    {

        public int PostId { get; set; }

        public string Title { get; set; }

        public DateTime PublishDate { get; set; }

        public string Content { get; set; }

        public virtual Blog Blog { get; set; }

        public int BlogId { get; set; }
    }
}
