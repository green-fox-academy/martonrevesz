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

        public void CreatePost(Post post, string user)
        {
            PostRepository.CreatePost(post, user);
        }

        public List<Post> GetTenPosts(int i)
        {
            return PostRepository.GetTenPosts(i);
        }

        public void Up(long id)
        {
            PostRepository.Up(id);
        }

        public void Down(long id)
        {
            PostRepository.Down(id);
        }

        public List<Post> FilterUser(string user)
        {
            return PostRepository.FilterUser(user);
        }

        public List<Post> FilterPositive()
        {
            return PostRepository.FilterPositive();
        }
    }
}
