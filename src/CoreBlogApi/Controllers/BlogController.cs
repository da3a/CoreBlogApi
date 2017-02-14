using CoreBlogApi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlogApi.Controllers
{
    [Route("api/[controller]")]
    public class BlogController: Controller
    {
        IBlogRepository blogRepository;

        public BlogController(IBlogRepository blogRepository)
        {
            this.blogRepository = blogRepository;
        }

        [HttpGet]
        public IEnumerable<Blog> Get()
        {
            return blogRepository.Blogs;
        }
    }
}
