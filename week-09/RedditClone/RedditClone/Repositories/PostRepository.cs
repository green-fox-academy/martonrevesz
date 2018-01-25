using RedditClone.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RedditClone.Models;

namespace RedditClone.Repositories
{
    public class PostRepository
    {
        public PostRepository(PostContext postContext)
        {
            PostContext = postContext;
        }

        public PostContext PostContext { get; set; }

        public List<Post> GetAllPosts()
        {
            return PostContext.Posts.ToList();
        }
    }
}
