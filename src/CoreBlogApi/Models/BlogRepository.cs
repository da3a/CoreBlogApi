using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlogApi.Models
{
    public class BlogRepository : IBlogRepository
    {
        private readonly CoreBloggerContext context;
        public BlogRepository(CoreBloggerContext context)
        {
            this.context = context;
        }

        public IEnumerable<Blog> Blogs
        {
            get
            {
                return context.Blogs;
            }
        }

        public Blog GetById(int blogId)
        {
            return context.Blogs.First(x => x.BlogId == blogId);
        }
    }
}
