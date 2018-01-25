using RedditClone.Models;
using RedditClone.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditClone.Services
{
    public class PostService
    {
        public PostService(PostRepository postRepository)
        {
            PostRepository = postRepository;
        }

        public PostRepository PostRepository { get; set; }

        public List<Post> GetAllPosts()
        {
            return PostRepository.GetAllPosts();
        }
    }
}
