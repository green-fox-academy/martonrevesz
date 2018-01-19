using Reddit.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Reddit.Models;

namespace Reddit.Repositories
{
    public class PostRepository
    {
        public PostRepository(PostContext postContext)
        {
            PostContext = postContext;
        }

        public PostContext PostContext { get; set; }

        public List<Post> GetPosts()
        {
            return PostContext.Posts.ToList();
        }

        public void CreatePost(Post post)
        {
            PostContext.Posts.Add(post);
            PostContext.SaveChanges();
        }

        public void Up(long id)
        {
            PostContext.Posts.FirstOrDefault(x => x.PostId == id).Score++;
            PostContext.SaveChanges();
        }

        public void Down(long id)
        {
            PostContext.Posts.FirstOrDefault(x => x.PostId == id).Score--;
            PostContext.SaveChanges();
        }
    }
}
