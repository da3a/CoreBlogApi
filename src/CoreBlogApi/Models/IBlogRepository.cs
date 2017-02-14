using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlogApi.Models
{
    public interface IBlogRepository
    {
        IEnumerable<Blog> Blogs { get; }

        Blog GetById(int blogId);
    }
}