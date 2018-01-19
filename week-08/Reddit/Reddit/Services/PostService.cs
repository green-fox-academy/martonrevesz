using Reddit.Models;
using Reddit.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reddit.Services
{
    public class PostService
    {
        public PostService(PostRepository postRepository)
        {
            PostRepository = postRepository;
        }

        public PostRepository PostRepository { get; set; }

        public List<Post> GetPosts()
        {
            return PostRepository.GetPosts();
        }

        public void CreatePost(Post post)
        {
            PostRepository.CreatePost(post);
        }
    }
}
