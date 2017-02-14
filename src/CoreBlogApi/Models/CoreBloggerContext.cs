using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlogApi.Models
{
    public class CoreBloggerContext : DbContext
    {
        public CoreBloggerContext(DbContextOptions<CoreBloggerContext> options) : base(options)
        {
        }

        public DbSet<Blog> Blogs { get; set; }

        public DbSet<Post> Posts { get; set; }


        /// <summary>
        ///   For reference, not really needed
        /// </summary>
        /// <param name="builder"></param>
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Blog>().ToTable("Blogs");
        }
    }
}
