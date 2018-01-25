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

        public void CreatePost(Post post)
        {
            PostContext.Posts.Add(post);
            PostContext.SaveChanges();
        }

        public Post GetLastPost()
        {
            return PostContext.Posts.Last();
        }

        public void UpvotePost(long id)
        {
            PostContext.Posts.FirstOrDefault(x => x.Id == id).Score++;
            PostContext.SaveChanges();
        }

        public Post GetPost(long id)
        {
            return PostContext.Posts.FirstOrDefault(p => p.Id == id);
        }

        public void DownvotePost(long id)
        {
            PostContext.Posts.FirstOrDefault(x => x.Id == id).Score--;
            PostContext.SaveChanges();
        }

        public void DeletePost(long id)
        {
            PostContext.Posts.Remove(PostContext.Posts.FirstOrDefault(x => x.Id == id));
            PostContext.SaveChanges();
        }

        public void UpdatePost(long id, Post post)
        {
            var currentPost = PostContext.Posts.FirstOrDefault(x => x.Id == id);
            if (post.Title != null)
                currentPost.Title = post.Title;
            if (post.Url != null)
                currentPost.Url = post.Url;
            if (post.Score !=null)
                currentPost.Score = post.Score;
            PostContext.SaveChanges();
        }
    }
}
