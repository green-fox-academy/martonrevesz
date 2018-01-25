using Microsoft.EntityFrameworkCore;
using RedditClone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditClone.Entities
{
    public class PostContext : DbContext
    {
        public PostContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Post> Posts { get; set; }
    }
}
